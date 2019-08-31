#nullable enable
using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public sealed class ConstTrigger
    {
        private readonly Trigger? redirect;

        internal ConstTrigger(Trigger? redirect)
        {
            this.redirect = redirect;
        }

        public Trigger Data_AirJuggle => Auto();
        public Trigger Data_Attack => Auto();
        public Trigger Data_Defence => Auto();
        public Trigger Data_Fall_Defence_Mul => Auto();
        public Trigger Data_FloatPersistIndex => Auto();
        public Trigger Data_Guard_SparkNo => Auto();
        public Trigger Data_IntPersistIndex => Auto();
        public Trigger Data_KO_Echo => Auto();
        public Trigger Data_Liedown_Time => Auto();
        public Trigger Data_Life => Auto();
        public Trigger Data_SparkNo => Auto();
        public Trigger Movement_Airjump_Num => Auto();
        public Trigger Movement_AirJump_Height => Auto();
        public Trigger Movement_Crouch_Friction => Auto();
        public Trigger Movement_Stand_Friction => Auto();
        public Trigger Movement_YAccel => Auto();
        public Trigger Size_Air_Back => Auto();
        public Trigger Size_Air_Front => Auto();
        public Trigger Size_Attack_Dist => Auto();
        public Trigger Size_Draw_Offset_X => Auto();
        public Trigger Size_Draw_Offset_Y => Auto();
        public Trigger Size_Ground_Back => Auto();
        public Trigger Size_Ground_Front => Auto();
        public Trigger Size_Head_Pos_X => Auto();
        public Trigger Size_Head_Pos_Y => Auto();
        public Trigger Size_Height => Auto();
        public Trigger Size_Mid_Pos_X => Auto();
        public Trigger Size_Mid_Pos_Y => Auto();
        public Trigger Size_Proj_Attack_Dist => Auto();
        public Trigger Size_Proj_Doscale => Auto();
        public Trigger Size_Shadowoffset => Auto();
        public Trigger Size_XScale => Auto();
        public Trigger Size_YScale => Auto();
        public Trigger Velocity_Walk_Fwd_X => Auto();
        public Trigger Velocity_Walk_Back_X => Auto();
        public Trigger Velocity_Run_Fwd_X => Auto();
        public Trigger Velocity_Run_Fwd_Y => Auto();
        public Trigger Velocity_Run_Back_X => Auto();
        public Trigger Velocity_Run_Back_Y => Auto();
        public Trigger Velocity_Jump_Y => Auto();
        public Trigger Velocity_Jump_Neu_X => Auto();
        public Trigger Velocity_Jump_Back_X => Auto();
        public Trigger Velocity_Jump_Fwd_X => Auto();
        public Trigger Velocity_Runjumo_Back_X => Auto();
        public Trigger Velocity_Runjumo_Fwd_X => Auto();
        public Trigger Velocity_AirJump_Y => Auto();
        public Trigger Velocity_AirJump_Neu_X => Auto();
        public Trigger Velocity_AirJump_Back_X => Auto();
        public Trigger Velocity_AirJump_Fwd_X => Auto();

        private Trigger Auto([CallerMemberName]string name = null!) => new Trigger(this.redirect, $"Const({name.Replace("_", ".")})");
    }
}
