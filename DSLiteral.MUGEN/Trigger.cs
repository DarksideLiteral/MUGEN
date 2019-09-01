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

        public override string Export()
        {
            var value = new StringBuilder();
            if (Redirect is { })
            {
                value.Append(Redirect.Export()).Append(",");
            }
            value.Append(Name.ToLower());
            if (Arg is { })
            {
                value.Append("(").Append(Arg.Export()).Append(")");
            }
            return value.ToString();
        }

        public override int GetHashCode() => Export().GetHashCode();

        public override string ToString()
        {
            var value = new StringBuilder();
            if (Redirect is { })
            {
                value.Append(Redirect.ToString()).Append(",");
            }
            value.Append(Name);
            if (Arg is { })
            {
                value.Append("(").Append(Arg.ToString()).Append(")");
            }
            return value.ToString();
        }

        public static implicit operator Trigger(string name) => new Trigger(null, name);

        public static bool operator ==(Trigger left, Trigger right) => left.Equals(right);
        public static bool operator !=(Trigger left, Trigger right) => !left.Equals(right);
    }
}
