#nullable enable

namespace DSLiteral.MUGEN.Characters
{
    public sealed class Trigger2
    {
        public Trigger2(Trigger? redirect, string name)
        {
            Redirect = redirect;
            Name = name;
        }

        public string Name { get; }
        public Trigger? Redirect { get; }
        public Trigger X => new Trigger(Redirect, $"{Name} X");
        public Trigger Y => new Trigger(Redirect, $"{Name} Y");
    }
}
