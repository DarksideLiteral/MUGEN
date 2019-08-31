#nullable enable
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DSLiteral.MUGEN
{
    public sealed class TupleExpression : Expression, IReadOnlyList<Expression>
    {
        private readonly Expression[] items;

        public TupleExpression(params Expression[] items)
        {
            this.items = items;
        }

        public Expression this[int index] => this.items[index];

        public int Count => this.items.Length;

        public IEnumerator<Expression> GetEnumerator() => this.items.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
