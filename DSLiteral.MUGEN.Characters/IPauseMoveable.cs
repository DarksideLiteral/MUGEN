#nullable enable

namespace DSLiteral.MUGEN.Characters
{
    public interface IPauseMoveable
    {
        Expression? PauseMoveTime { get; set; }
        Expression? SuperMoveTime { get; set; }
    }
}
