#nullable enable

using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public class Character
    {
        private readonly Trigger? redirect;

        public Character(Trigger? redirect = null)
        {
            this.redirect = redirect;
        }

        public Trigger A => Auto();
        public Trigger Abs(Expression value) => Auto(value);
        public Trigger ACos(Expression value) => Auto(value);
        public Trigger AILevel => Auto();
        public Trigger Alive => Auto();
        public Trigger Anim => Auto();
        public Trigger AnimElem => Auto();
        public Trigger AnimElemNo(Expression value) => Auto(value);
        public Trigger AnimElemTime(Expression value) => Auto(value);
        public Trigger AnimExist(Expression value) => Auto(value);
        public Trigger AnimTime => Auto();
        public Trigger ASin(Expression value) => Auto(value);
        public Trigger ATan(Expression value) => Auto(value);
        public Trigger AuthorName => Auto();
        public Trigger B => Auto();
        public Trigger BackEdge => Auto();
        public Trigger BackEdgeBodyDist => Auto();
        public Trigger BackEdgeDist => Auto();
        public Trigger BottomEdge => Auto();
        public Trigger C => Auto();
        public Trigger2 CameraPos => Auto2();
        public Trigger CameraZoom => Auto();
        public Trigger Ceil(Expression value) => Auto(value);
        public Trigger Command => Auto();
        public Trigger Cond(Expression value) => Cond(true, value, false);
        public Trigger Cond(Expression c, Expression t, Expression f) => Auto((c, t, f));
        public ConstTrigger Const => new ConstTrigger(this.redirect);
        public Trigger Const240p(Expression value) => Auto(value);
        public Trigger Const480p(Expression value) => Auto(value);
        public Trigger Const720p(Expression value) => Auto(value);
        public Trigger Cos(Expression value) => Auto(value);
        public Trigger Ctrl => Auto();
        public Trigger DrawGame => Auto();
        public Trigger E => Auto();
        public Trigger Exp(Expression value) => Auto(value);
        public Trigger F => Auto();
        public Trigger FVar(Expression value) => Auto(value);
        public Trigger Facing => Auto();
        public Trigger Floor(Expression value) => Auto(value);
        public Trigger FrontEdge => Auto();
        public Trigger FrontEdgeBodyDist => Auto();
        public Trigger FrontEdgeDist => Auto();
        public Trigger GameHeight => Auto();
        public Trigger GameTime => Auto();
        public Trigger GameWidth => Auto();
        public GetHitVarTrigger GetHitVar => new GetHitVarTrigger(this.redirect);
        public Trigger H => Auto();
        public Trigger HitCount => Auto();
        public Trigger HitDefAttr => Auto();
        public Trigger HitFall => Auto();
        public Trigger HitOver => Auto();
        public Trigger HitPauseTime => Auto();
        public Trigger HitShakeOver => Auto();
        public Trigger2 HitVel => Auto2();
        public Trigger I => Auto();
        public Trigger Id => Auto();
        public Trigger IfElse(Expression c, Expression t, Expression f) => Auto((c, t, f));
        public Trigger InGuardDist => Auto();
        public Trigger IsHelper(Expression? value = null) => Auto(value);
        public Trigger IsHomeTeam => Auto();
        public Trigger LeftEdge => Auto();
        public Trigger Life => Auto();
        public Trigger LifeMax => Auto();
        public Trigger Ln(Expression value) => Auto(value);
        public Trigger Log(Expression value, Expression value2) => Auto((value, value2));
        public Trigger Lose => Auto();
        public Trigger LoseKO => Auto();
        public Trigger LoseTime => Auto();
        public Trigger MatchNo => Auto();
        public Trigger MatchOver => Auto();
        public Trigger MoveContact => Auto();
        public Trigger MoveGuarded => Auto();
        public Trigger MoveHit => Auto();
        public Trigger MoveReversed => Auto();
        public Trigger MoveType => Auto();
        public Trigger N => Auto();
        public Trigger Name => Auto();
        public Trigger NumEnemy => Auto();
        public Trigger NumExplod(Expression? value = null) => Auto(value);
        public Trigger NumHelper(Expression? value = null) => Auto(value);
        public Trigger NumPartner => Auto();
        public Trigger NumProj => Auto();
        public Trigger NumProjId(Expression? value = null) => Auto(value);
        public Trigger NumTarget(Expression? value = null) => Auto(value);
        public Trigger P1Name => Name;
        public Trigger2 P2BodyDist => Auto2();
        public Trigger2 P2Dist => Auto2();
        public Trigger P2Life => Auto();
        public Trigger P2MoveType => Auto();
        public Trigger P2Name => Auto();
        public Trigger P2StateNo => Auto();
        public Trigger P2StateType => Auto();
        public Trigger P3Name => Auto();
        public Trigger P4Name => Auto();
        public Trigger PalNo => Auto();
        public Trigger2 ParentDist => Auto2();
        public Trigger Physics => Auto();
        public Trigger PI => Auto();
        public Trigger PlayerIdExist(Expression value) => Auto(value);
        public Trigger2 Pos => Auto2();
        public Trigger Power => Auto();
        public Trigger PowerMax => Auto();
        public Trigger PrevStateNo => Auto();
        public Trigger ProjCancelTime(Expression? value = null) => Auto(value);
        public Trigger ProjContactTime(Expression value) => Auto(value);
        public Trigger ProjGuardedTime(Expression value) => Auto(value);
        public Trigger ProjHitTime(Expression value) => Auto(value);
        public Trigger Random => Auto();
        public Trigger RightEdge => Auto();
        public Trigger2 RootDist => Auto2();
        public Trigger RoundNo => Auto();
        public Trigger RoundState => Auto();
        public Trigger RoundsExisted => Auto();
        public Trigger S => Auto();
        public Trigger2 ScreenPos => Auto2();
        public Trigger ScreenHeight => Auto();
        public Trigger ScreenWidth => Auto();
        public Trigger SelfAnimExist(Expression value) => Auto(value);
        public Trigger Sin(Expression value) => Auto(value);
        public Trigger StateNo => Auto();
        public Trigger StateType => Auto();
        public StageVarTrigger StageVar => new StageVarTrigger(this.redirect);
        public Trigger SysFVar(Expression value) => Auto(value);
        public Trigger SysVar(Expression value) => Auto(value);
        public Trigger Tan(Expression value) => Auto(value);
        public Trigger TeamMode => Auto();
        public Trigger TeamSide => Auto();
        public Trigger TicksPerSecond => Auto();
        public Trigger Time => Auto();
        public Trigger TopEdge => Auto();
        public Trigger UniqHitCount => Auto();
        public Trigger Var(Expression value) => Auto(value);
        public Trigger2 Vel => Auto2();
        public Trigger Win => Auto();
        public Trigger WinKO => Auto();
        public Trigger WinPerfect => Auto();
        public Trigger WinTime => Auto();

        private Trigger Auto(Expression? arg = null, [CallerMemberName]string name = null!) => new Trigger(this.redirect, name, arg);
        private Trigger2 Auto2([CallerMemberName]string name = null!) => new Trigger2(this.redirect, name);
    }
}
