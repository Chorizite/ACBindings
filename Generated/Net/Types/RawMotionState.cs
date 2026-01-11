namespace ACBindings.Internal;

public unsafe struct RawMotionState : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct RawMotionState_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, void> RawMotionState_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    public unsafe struct PackBitfield
    {
        // Members
        public short _bf_0;

        // Methods
    }

    // Members
    public ACBindings.Internal.LList___ActionNode actions;
    public ACBindings.Internal.HoldKey current_holdkey;
    public uint current_style;
    public uint forward_command;
    public ACBindings.Internal.HoldKey forward_holdkey;
    public float forward_speed;
    public uint sidestep_command;
    public ACBindings.Internal.HoldKey sidestep_holdkey;
    public float sidestep_speed;
    public uint turn_command;
    public ACBindings.Internal.HoldKey turn_holdkey;
    public float turn_speed;

    // Generated Constructor
    public RawMotionState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051F1F0
    /// void __thiscall RawMotionState::RemoveMotion(RawMotionState*,unsigned int)</code>
    /// </summary>
    public void RemoveMotion(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint, void>)0x0051F1F0)(ref this, motion);

    /// <summary>
    /// <code>Offset: 0x0051F300
    /// void __thiscall RawMotionState::RawMotionState(RawMotionState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void>)0x0051F300)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051F350
    /// void __thiscall RawMotionState::AddAction(RawMotionState*,unsigned int,float,unsigned int,int)</code>
    /// </summary>
    public void AddAction(uint action, float speed, uint stamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint, float, uint, int, void>)0x0051F350)(ref this, action, speed, stamp, autonomous);

    /// <summary>
    /// <code>Offset: 0x0051F3B0
    /// unsigned int __thiscall RawMotionState::RemoveAction(RawMotionState*)</code>
    /// </summary>
    public uint RemoveAction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint>)0x0051F3B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051F630
    /// void __thiscall RawMotionState::Destroy(RawMotionState*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void>)0x0051F630)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051F670
    /// void __thiscall RawMotionState::ApplyMotion(RawMotionState*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public void ApplyMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint, ACBindings.Internal.MovementParameters*, void>)0x0051F670)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x0051F820
    /// unsigned int __thiscall RawMotionState::Pack(RawMotionState*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void**, uint, uint>)0x0051F820)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0051FAD0
    /// int __thiscall RawMotionState::UnPack(RawMotionState*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void**, uint, int>)0x0051FAD0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005200D0
    /// void __thiscall RawMotionState::~RawMotionState(RawMotionState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void>)0x005200D0)(ref this);
}

