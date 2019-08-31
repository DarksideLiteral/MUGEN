#nullable enable

using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public sealed class GetHitVarTrigger
    {
        private readonly Trigger? redirect;

        internal GetHitVarTrigger(Trigger? redirect)
        {
            this.redirect = redirect;
        }

        public Trigger AnimType => Auto();
        public Trigger GroundType => Auto();
        public Trigger AirType => Auto();
        public Trigger Damage => Auto();
        public Trigger HitShakeTime => Auto();
        public Trigger HitTime => Auto();
        public Trigger SlideTime => Auto();
        public Trigger CtrlTime => Auto();
        public Trigger RecoverTime => Auto();
        public Trigger HitCount => Auto();
        public Trigger FallCount => Auto();
        public Trigger XVel => Auto();
        public Trigger YVel => Auto();
        public Trigger YAccel => Auto();
        public Trigger Fall => Auto();
        public Trigger Fall_Damage => Auto();
        public Trigger Fall_XVel => Auto();
        public Trigger Fall_YVel => Auto();
        public Trigger Fall_Recover => Auto();
        public Trigger Fall_RecoverTime => Auto();
        public Trigger ChainID => Auto();
        public Trigger Guarded => Auto();
        public Trigger IsBound => Auto();
        public Trigger XVelAdd => Auto();
        public Trigger YVelAdd => Auto();
        public Trigger Type => Auto();
        public Trigger XOff => Auto();
        public Trigger YOff => Auto();
        public Trigger ZOff => Auto();
        public Trigger Fall_Kill => Auto();
        public Trigger Fall_Envshake_Time => Auto();
        public Trigger Fall_Envshake_Freq => Auto();
        public Trigger Fall_Envshake_Ampl => Auto();
        public Trigger Fall_Envshake_Phase => Auto();

        private Trigger Auto([CallerMemberName]string name = null!) => new Trigger(this.redirect, $"GetHitVar({name.Replace("_", ".")})");
    }
}
