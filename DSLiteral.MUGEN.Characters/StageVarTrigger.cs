#nullable enable
using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public sealed class StageVarTrigger
    {
        private readonly Trigger? redirect;

        internal StageVarTrigger(Trigger? redirect)
        {
            this.redirect = redirect;
        }

        public Trigger Info_Author => Auto();
        public Trigger Info_DisplayName => Auto();
        public Trigger Info_Name => Auto();

        private Trigger Auto([CallerMemberName]string name = null!) => new Trigger(this.redirect, $"StageVar({name.Replace("_", ".")})");
    }
}
