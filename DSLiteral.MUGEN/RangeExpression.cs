#nullable enable

using System;
using System.Text;

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

        public override string Export(bool deformat)
        {
            return new StringBuilder()
                .Append(Include.HasFlag(Includes.Min) ? "[" : "(")
                .Append(Min.Export(deformat))
                .Append(Export(", ", deformat))
                .Append(Max.Export(deformat))
                .Append(Include.HasFlag(Includes.Max) ? "]" : ")")
                .ToString();
        }

        [Flags]
        public enum Includes
        {
            None = 0,
            Min = 1,
            Max = 2,
        }
    }
}
