#nullable enable

using System.Text;

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

        public override string ToString()
        {
            var value = new StringBuilder();
            if (Redirect is { })
            {
                value.Append(Redirect).Append(",");
            }
            value.Append(Name);
            return value.ToString();
        }
    }
}
