#nullable enable
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public sealed class StateController : DynamicObject
    {
        private readonly Dictionary<Trigger, Expression> items = new Dictionary<Trigger, Expression>();

        public Expression? this[Trigger name]
        {
            get
            {
                if (name.ToString().StartsWith("trigger", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException();
                return this.items.TryGetValue(name, out var value) ? value : null;
            }
            set
            {
                if (name.ToString().StartsWith("trigger", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException();
                if (value is { })
                    this.items[name] = value;
                else
                    this.items.Remove(name);
            }
        }

        public Expression? IgnoreHitPause { get => Get(); set => Set(value); }
        public Expression? Persistent { get => Get(); set => Set(value); }
        public List<List<Expression>> Trigger { get; } = new List<List<Expression>>();
        public List<Expression> TriggerAll { get; } = new List<Expression>();
        public Expression? Type { get => Get(); set => Set(value); }

        private Expression? Get([CallerMemberName]string name = null!) => this[name];
        private void Set(Expression? value, [CallerMemberName]string name = null!) => this[name] = value;
    }

    //#region
    //public abstract class BindTo : StateController
    //{
    //    public Expression? Facing { get => Get(); set => Set(value); }
    //    public Expression? Pos { get => Get(); set => Set(value); }
    //    public Expression? Time { get => Get(); set => Set(value); }
    //}

    //public abstract class ChangeAnimBase : StateController
    //{
    //    protected ChangeAnimBase(Expression value, Expression? elem = null)
    //    {
    //        Value = value;
    //        Elem = elem;
    //    }

    //    public Expression? Elem { get => Get(); set => Set(value); }
    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public abstract class ChangeStateBase : StateController
    //{
    //    protected ChangeStateBase(Expression value)
    //    {
    //        Value = value;
    //    }

    //    public Expression? Anim { get => Get(); set => Set(value); }
    //    public Expression? Ctrl { get => Get(); set => Set(value); }
    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public abstract class PalFXBase : StateController
    //{
    //    public Expression? Add { get => Get(); set => Set(value); }
    //    public Expression? Color { get => Get(); set => Set(value); }
    //    public Expression? InvertAll { get => Get(); set => Set(value); }
    //    public Expression? Mul { get => Get(); set => Set(value); }
    //    public Expression? SinAdd { get => Get(); set => Set(value); }
    //    public Expression? Time { get => Get(); set => Set(value); }
    //}

    //public abstract class ToClipboard : StateController
    //{
    //    protected ToClipboard(Expression text, Expression? @params = null)
    //    {
    //        Text = text;
    //        Params = @params;
    //    }

    //    public Expression? Params { get => Get(); set => Set(value); }
    //    public Expression Text { get => Get()!; set => Set(value); }
    //}
    //#endregion

    //#region
    //public sealed class AfterImage : StateController
    //{
    //    public Expression? Alpha { get => Get(); set => Set(value); }
    //    public Expression? FrameGap { get => Get(); set => Set(value); }
    //    public Expression? Length { get => Get(); set => Set(value); }
    //    public Expression? PalAdd { get => Get(); set => Set(value); }
    //    public Expression? PalBright { get => Get(); set => Set(value); }
    //    public Expression? PalColor { get => Get(); set => Set(value); }
    //    public Expression? PalContrast { get => Get(); set => Set(value); }
    //    public Expression? PalInvertAll { get => Get(); set => Set(value); }
    //    public Expression? PalMul { get => Get(); set => Set(value); }
    //    public Expression? PalPostBright { get => Get(); set => Set(value); }
    //    public Expression? Time { get => Get(); set => Set(value); }
    //    public Expression? TimeGap { get => Get(); set => Set(value); }
    //    public Expression? Trans { get => Get(); set => Set(value); }
    //}

    //public sealed class AfterImageTime : StateController
    //{
    //    public Expression? Time { get => Get(); set => Set(value); }
    //}

    //public sealed class AllPalFX : PalFXBase { }

    //public sealed class AngleAdd : StateController
    //{
    //    public AngleAdd(Expression value)
    //    {
    //        Value = value;
    //    }

    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public sealed class AngleDraw : StateController
    //{
    //    public Expression? Scale { get => Get(); set => Set(value); }
    //    public Expression? Value { get => Get(); set => Set(value); }
    //}

    //public sealed class AngleMul : StateController
    //{
    //    public AngleMul(Expression value)
    //    {
    //        Value = value;
    //    }

    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public sealed class AngleSet : StateController
    //{
    //    public AngleSet(Expression value)
    //    {
    //        Value = value;
    //    }

    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public sealed class AppendToClipboard : ToClipboard
    //{
    //    public AppendToClipboard(Expression text, Expression? @params = null) : base(text, @params) { }
    //}

    //public sealed class AssertSpecial : StateController
    //{
    //    public AssertSpecial(Expression flag, Expression? flag2 = null, Expression? flag3 = null)
    //    {
    //        Flag = flag;
    //        Flag2 = flag2;
    //        Flag3 = flag3;
    //    }

    //    public Expression Flag { get => Get()!; set => Set(value); }
    //    public Expression? Flag2 { get => Get(); set => Set(value); }
    //    public Expression? Flag3 { get => Get(); set => Set(value); }
    //}

    //public sealed class AttackDist : StateController
    //{
    //    public AttackDist(Expression value)
    //    {
    //        Value = value;
    //    }

    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public sealed class AttackMulSet : StateController
    //{
    //    public AttackMulSet(Expression value)
    //    {
    //        Value = value;
    //    }

    //    public Expression Value { get => Get()!; set => Set(value); }
    //}

    //public sealed class BGPalFX : PalFXBase { }

    //public sealed class BindToParent : BindTo { }

    //public sealed class BindToRoot : BindTo { }

    //public sealed class BindToTarget : BindTo { }

    //public sealed class ChangeAnim : ChangeAnimBase
    //{
    //    public ChangeAnim(Expression value, Expression? elem = null) : base(value, elem) { }
    //}

    //public sealed class ChangeAnim2 : ChangeAnimBase
    //{
    //    public ChangeAnim2(Expression value, Expression? elem = null) : base(value, elem) { }
    //}

    //public sealed class ChangeState : ChangeStateBase
    //{
    //    public ChangeState(Expression value) : base(value) { }
    //}

    //public sealed class DisplayToClipboard : ToClipboard
    //{
    //    public DisplayToClipboard(Expression text, Expression? @params = null) : base(text, @params) { }
    //}

    //public sealed class Explod : StateController, IPauseMoveable
    //{
    //    public Explod(Expression anim)
    //    {
    //        Anim = anim;
    //    }

    //    public Expression? Accel { get => Get(); set => Set(value); }
    //    public Expression? Alpha { get => Get(); set => Set(value); }
    //    public Expression? Angle { get => Get(); set => Set(value); }
    //    public Expression Anim { get => Get()!; set => Set(value); }
    //    public Expression? BindId { get => Get(); set => Set(value); }
    //    public Expression? BindTime { get => Get(); set => Set(value); }
    //    public Expression? Facing { get => Get(); set => Set(value); }
    //    public Expression? Id { get => Get(); set => Set(value); }
    //    public Expression? OnTop { get => Get(); set => Set(value); }
    //    public Expression? OwnPal { get => Get(); set => Set(value); }
    //    public Expression? PauseMoveTime { get => Get(); set => Set(value); }
    //    public Expression? Pos { get => Get(); set => Set(value); }
    //    public Expression? PosType { get => Get(); set => Set(value); }
    //    public Expression? Random { get => Get(); set => Set(value); }
    //    public Expression? ReMapPal { get => Get(); set => Set(value); }
    //    public Expression? RemoveOnGethit { get => Get(); set => Set(value); }
    //    public Expression? RemoveTime { get => Get(); set => Set(value); }
    //    public Expression? Scale { get => Get(); set => Set(value); }
    //    public Expression? Shadow { get => Get(); set => Set(value); }
    //    public Expression? Space { get => Get(); set => Set(value); }
    //    public Expression? SprPriority { get => Get(); set => Set(value); }
    //    public Expression? SuperMoveTime { get => Get(); set => Set(value); }
    //    public Expression? Trans { get => Get(); set => Set(value); }
    //    public Expression? Vel { get => Get(); set => Set(value); }
    //    public Expression? VFacing { get => Get(); set => Set(value); }
    //    public Expression? XAngle { get => Get(); set => Set(value); }
    //    public Expression? YAngle { get => Get(); set => Set(value); }
    //}

    //public sealed class PalFX : PalFXBase { }

    //public sealed class SelfState : ChangeStateBase
    //{
    //    public SelfState(Expression value) : base(value) { }
    //}
    //#endregion
}
