﻿#nullable enable

namespace DSLiteral.MUGEN
{
    public abstract class Expression
    {
        internal Expression() { }

        protected static string Export(string value, bool deformat) => deformat ? value.ToLower().Replace(" ", "") : value;

        public string Export() => Export(true);
        public abstract string Export(bool deformat);

        public sealed override string ToString() => Export(false);

        public static implicit operator Expression(bool value) => new Int32Literal(value ? 1 : 0);
        public static implicit operator Expression(float value) => new Float32Literal(value);
        public static implicit operator Expression(int value) => new Int32Literal(value);
        public static implicit operator Expression((Expression, Expression) value) => new TupleExpression(value.Item1, value.Item2);
        public static implicit operator Expression((Expression, Expression, Expression) value) => new TupleExpression(value.Item1, value.Item2, value.Item3);
    }
}
