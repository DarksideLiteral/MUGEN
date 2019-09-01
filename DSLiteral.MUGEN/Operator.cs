#nullable enable

using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

    public class BinaryOperator : Operator, IReadOnlyList<Expression>
    {
        private readonly Expression[] items;

        public BinaryOperator(string symbol, params Expression[] items) : base(symbol)
        {
            this.items = items;
        }

        public Expression this[int index] => this.items[index];

        public int Count => this.items.Length;

        public override string Export(bool deformat)
        {
            var symbol = Export($" {Symbol} ", deformat);
            var value = string.Join(symbol, from i in this.items select i.Export(deformat));
            return $"({value})";
        }

        public IEnumerator<Expression> GetEnumerator() => this.items.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class UnaryOperator : Operator
    {
        public UnaryOperator(string symbol, Expression value) : base(symbol)
        {
            Value = value;
        }

        public Expression Value { get; }

        public override string Export(bool deformat) => $"{Export(Symbol, deformat)}({Value.Export(deformat)})";
    }
}
