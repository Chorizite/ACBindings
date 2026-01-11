namespace ACBindings.Internal;

public unsafe struct InterpretedMotionState : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct InterpretedMotionState_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, void> InterpretedMotionState_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    public unsafe struct PackBitfield
    {
        // Members
        public sbyte _bf_0;
        public sbyte _padding_1;

        // Methods
    }

    // Members
    public uint current_style;
    public uint forward_command;
    public float forward_speed;
    public uint sidestep_command;
    public float sidestep_speed;
    public uint turn_command;
    public float turn_speed;
    public ACBindings.Internal.LList___ActionNode actions;

    // Generated Constructor
    public InterpretedMotionState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051F260
    /// void __thiscall InterpretedMotionState::copy_movement_from(InterpretedMotionState*,const InterpretedMotionState*)</code>
    /// </summary>
    public void copy_movement_from(ACBindings.Internal.InterpretedMotionState* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, ACBindings.Internal.InterpretedMotionState*, void>)0x0051F260)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0051F2A0
    /// void __thiscall InterpretedMotionState::RemoveMotion(InterpretedMotionState*,unsigned int)</code>
    /// </summary>
    public void RemoveMotion(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint, void>)0x0051F2A0)(ref this, motion);

    /// <summary>
    /// <code>Offset: 0x0051F3E0
    /// void __thiscall InterpretedMotionState::InterpretedMotionState(InterpretedMotionState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void>)0x0051F3E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051F420
    /// void __thiscall InterpretedMotionState::Destroy(InterpretedMotionState*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void>)0x0051F420)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051F4F0
    /// void __thiscall InterpretedMotionState::AddAction(InterpretedMotionState*,unsigned int,float,unsigned int,int)</code>
    /// </summary>
    public void AddAction(uint action, float speed, uint stamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint, float, uint, int, void>)0x0051F4F0)(ref this, action, speed, stamp, autonomous);

    /// <summary>
    /// <code>Offset: 0x0051F550
    /// void __thiscall InterpretedMotionState::ApplyMotion(InterpretedMotionState*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public void ApplyMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint, ACBindings.Internal.MovementParameters*, void>)0x0051F550)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x0051F5E0
    /// unsigned int __thiscall InterpretedMotionState::RemoveAction(InterpretedMotionState*)</code>
    /// </summary>
    public uint RemoveAction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint>)0x0051F5E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051F610
    /// unsigned int __thiscall InterpretedMotionState::GetNumActions(InterpretedMotionState*)</code>
    /// </summary>
    public uint GetNumActions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint>)0x0051F610)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051FCC0
    /// void __thiscall InterpretedMotionState::~InterpretedMotionState(InterpretedMotionState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void>)0x0051FCC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051FCE0
    /// unsigned int __thiscall InterpretedMotionState::Pack(InterpretedMotionState*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void**, uint, uint>)0x0051FCE0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0051FF10
    /// int __thiscall InterpretedMotionState::UnPack(InterpretedMotionState*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void**, uint, int>)0x0051FF10)(ref this, addr, size);
}

