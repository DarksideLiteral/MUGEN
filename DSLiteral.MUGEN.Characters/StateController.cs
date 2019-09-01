#nullable enable

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

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
                if (name == "type" && !(value is Trigger))
                    throw new ArgumentException();
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
        public Trigger? Type { get => (Trigger?)Get(); set => Set(value); }

        public string Export()
        {
            var value = new StringBuilder();
            value.AppendLine("[state ]");
            foreach (var i in TriggerAll)
            {
                value.Append("triggerall=").Append(i.Export()).AppendLine();
            }
            for (int i = 0; i < Trigger.Count; ++i)
            {
                foreach (var j in Trigger[i])
                {
                    value.Append("trigger").Append(i + 1).Append("=").Append(j.Export()).AppendLine();
                }
            }
            foreach (var i in this.items)
            {
                value.Append(i.Key.Export()).Append("=").Append(i.Value.Export()).AppendLine();
            }
            return value.ToString();
        }

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

        public override string ToString()
        {
            var value = new StringBuilder();
            value.AppendLine("[State ]");
            foreach (var i in TriggerAll)
            {
                value.Append("TriggerAll = ").Append(i.ToString()).AppendLine();
            }
            for (int i = 0; i < Trigger.Count; ++i)
            {
                foreach (var j in Trigger[i])
                {
                    value.Append("Trigger").Append(i + 1).Append(" = ").Append(j.ToString()).AppendLine();
                }
            }
            foreach (var i in this.items)
            {
                value.Append(i.Key.ToString()).Append(" = ").Append(i.Value.ToString()).AppendLine();
            }
            return value.ToString();
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
