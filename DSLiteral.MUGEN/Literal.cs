#nullable enable

namespace DSLiteral.MUGEN
{
    public abstract class Literal : Expression
    {
        internal Literal() { }
    }

    public sealed class Float32Literal : Literal
    {
        internal Float32Literal(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public override string Export(bool deformat)
        {
            var value = Value.ToString();
            if (value == "0")
                return "0.";
            if (!deformat)
                return value;
            if (value.StartsWith("0."))
                return value.Substring(2);
            return value.TrimEnd('0');
        }
    }

    public sealed class Int32Literal : Literal
    {
        internal Int32Literal(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public override string Export(bool deformat) => Value.ToString();
    }

    public sealed class StringLiteral : Literal
    {
        private StringLiteral(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override string Export(bool deformat) => $"\"{Value}\"";

        public static implicit operator StringLiteral(string value) => new StringLiteral(value);
    }
}
