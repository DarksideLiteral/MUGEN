#nullable enable

using System.Text;

namespace DSLiteral.MUGEN
{
    public sealed class Trigger : Expression
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

        public override string Export() => ToString();

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
    }
}
