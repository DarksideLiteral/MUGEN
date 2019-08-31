#nullable enable

namespace DSLiteral.MUGEN
{
    public abstract class Operator : Expression
    {
        protected Operator(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; }
    }

    public class BinaryOperator : Operator
    {
        public BinaryOperator(string symbol) : base(symbol)
        {
        }
    }

    public class UnaryOperator : Operator
    {
        public UnaryOperator(string symbol) : base(symbol)
        {
        }
    }
}
