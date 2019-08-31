#nullable enable
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DSLiteral.MUGEN.Characters
{
    public sealed class StateDefine
    {
        private readonly Dictionary<string, Trigger> items = new Dictionary<string, Trigger>();

        public Trigger? Anim { get => Get(); set => Set(value); }
        public Trigger? Ctrl { get => Get(); set => Set(value); }
        public Trigger? FaceP2 { get => Get(); set => Set(value); }
        public Trigger? HitCountPersist { get => Get(); set => Set(value); }
        public Trigger? HitDefPersist { get => Get(); set => Set(value); }
        public Trigger? Juggle { get => Get(); set => Set(value); }
        public Trigger? MoveHitPersist { get => Get(); set => Set(value); }
        public Trigger? MoveType { get => Get(); set => Set(value); }
        public Trigger? Physics { get => Get(); set => Set(value); }
        public Trigger? PowerAdd { get => Get(); set => Set(value); }
        public Trigger? SprPriority { get => Get(); set => Set(value); }
        public Trigger? Type { get => Get(); set => Set(value); }
        public Trigger? VelSet { get => Get(); set => Set(value); }

        private Trigger? Get([CallerMemberName]string name = null!) => this.items.TryGetValue(name, out var value) ? value : null;
        private void Set(Trigger? value, [CallerMemberName]string name = null!)
        {
            if (value is { })
                this.items[name] = value;
            else
                this.items.Remove(name);
        }
    }
}
