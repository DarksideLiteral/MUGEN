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
    }

    public sealed class Int32Literal : Literal
    {
        internal Int32Literal(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }

    public sealed class StringLiteral : Literal
    {
        private StringLiteral(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static implicit operator StringLiteral(string value) => new StringLiteral(value);
    }
}
