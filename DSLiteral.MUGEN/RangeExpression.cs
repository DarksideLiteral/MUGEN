#nullable enable
using System;

namespace DSLiteral.MUGEN
{
    public sealed class RangeExpression : Expression
    {
        public RangeExpression(Expression min, Expression max, Includes include = Includes.Min | Includes.Max)
        {
            Min = min;
            Max = max;
            Include = include;
        }

        public Includes Include { get; }
        public Expression Max { get; }
        public Expression Min { get; }

        [Flags]
        public enum Includes
        {
            None = 0,
            Min = 1,
            Max = 2,
        }
    }
}
