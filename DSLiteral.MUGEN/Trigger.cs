#nullable enable

using System;
using System.Text;

namespace DSLiteral.MUGEN
{
    public sealed class Trigger : Expression, IEquatable<Trigger>
    {
        public Trigger(Trigger? redirect, string name, Expression? arg = null)
        {
            Redirect = redirect;
            Name = name;
            Arg = arg;
        }

        public Expression? Arg { get; }
        public string Name { get; }
        public Trigger? Redirect { get; }

        public override bool Equals(object? obj) => obj is Trigger other && Equals(other);

        public bool Equals(Trigger other) => Export() == other.Export();

        public override string Export(bool deformat)
        {
            var value = new StringBuilder();
            if (Redirect is { })
            {
                value.Append(Redirect.Export(deformat)).Append(",");
            }
            value.Append(Export(Name, deformat));
            if (Arg is { })
            {
                value.Append("(").Append(Arg.Export(deformat)).Append(")");
            }
            return value.ToString();
        }

        public override int GetHashCode() => Export().GetHashCode();

        public static implicit operator Trigger(string name) => new Trigger(null, name);

        public static bool operator ==(Trigger left, Trigger right) => left.Equals(right);
        public static bool operator !=(Trigger left, Trigger right) => !left.Equals(right);
    }
}
