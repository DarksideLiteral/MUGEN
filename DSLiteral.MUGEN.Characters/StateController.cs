#nullable enable

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public sealed class StateController : DynamicObject
    {
        private readonly Dictionary<Trigger, Expression> items = new Dictionary<Trigger, Expression>();

        public Expression? this[Trigger name]
        {
            get
            {
                if (name.ToString().StartsWith("trigger", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException();
                return this.items.TryGetValue(name, out var value) ? value : null;
            }
            set
            {
                if (name.ToString().StartsWith("trigger", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException();
                if (value is { })
                    this.items[name] = value;
                else
                    this.items.Remove(name);
            }
        }

        public Expression? IgnoreHitPause { get => Get(); set => Set(value); }
        public Expression? Persistent { get => Get(); set => Set(value); }
        public List<List<Expression>> Trigger { get; } = new List<List<Expression>>();
        public List<Expression> TriggerAll { get; } = new List<Expression>();
        public Expression? Type { get => Get(); set => Set(value); }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            yield return nameof(Type);
            yield return nameof(TriggerAll);
            yield return nameof(Trigger);
            foreach (var i in this.items)
            {
                yield return i.Key.ToString();
            }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            result = this[binder.Name];
            return result is { };
        }

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            if (value is null)
                this[binder.Name] = null;
            else if (value is Expression expression)
                this[binder.Name] = expression;
            else
                return false;
            return true;
        }

        private Expression? Get([CallerMemberName]string name = null!) => this[name];

        private void Set(Expression? value, [CallerMemberName]string name = null!) => this[name] = value;
    }
}
