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

        public override string Export() => string.Join(",", this.items.AsEnumerable());

        public override string ToString() => string.Join(", ", this.items.AsEnumerable());

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
