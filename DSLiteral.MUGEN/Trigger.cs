#nullable enable

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

        public static implicit operator Trigger(string name) => new Trigger(null, name);
    }
}
