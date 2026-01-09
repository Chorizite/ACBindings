namespace ACBindings;

// InterpretedMotionState
public unsafe struct InterpretedMotionState : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // InterpretedMotionState_vtbl
    public unsafe struct InterpretedMotionState_vtbl
    {
        // Members
        public System.IntPtr InterpretedMotionState_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }
    // InterpretedMotionState::PackBitfield
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
    public ACBindings.LList__ActionNode actions;

    // Generated Constructor
    public InterpretedMotionState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall InterpretedMotionState::copy_movement_from(InterpretedMotionState*,const InterpretedMotionState*)
    public void copy_movement_from(ACBindings.InterpretedMotionState* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, ACBindings.InterpretedMotionState*, void>)0x0051F260)(ref this, rhs);
    // void __thiscall InterpretedMotionState::RemoveMotion(InterpretedMotionState*,unsigned int)
    public void RemoveMotion(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, uint, void>)0x0051F2A0)(ref this, motion);
    // void __thiscall InterpretedMotionState::InterpretedMotionState(InterpretedMotionState*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, void>)0x0051F3E0)(ref this);
    // void __thiscall InterpretedMotionState::Destroy(InterpretedMotionState*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, void>)0x0051F420)(ref this);
    // void __thiscall InterpretedMotionState::AddAction(InterpretedMotionState*,unsigned int,float,unsigned int,int)
    public void AddAction(uint action, float speed, uint stamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, uint, float, uint, int, void>)0x0051F4F0)(ref this, action, speed, stamp, autonomous);
    // void __thiscall InterpretedMotionState::ApplyMotion(InterpretedMotionState*,unsigned int,const MovementParameters*)
    public void ApplyMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, uint, ACBindings.MovementParameters*, void>)0x0051F550)(ref this, motion, params_);
    // unsigned int __thiscall InterpretedMotionState::RemoveAction(InterpretedMotionState*)
    public uint RemoveAction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, uint>)0x0051F5E0)(ref this);
    // unsigned int __thiscall InterpretedMotionState::GetNumActions(InterpretedMotionState*)
    public uint GetNumActions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, uint>)0x0051F610)(ref this);
    // void __thiscall InterpretedMotionState::~InterpretedMotionState(InterpretedMotionState*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, void>)0x0051FCC0)(ref this);
    // unsigned int __thiscall InterpretedMotionState::Pack(InterpretedMotionState*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, void**, uint, uint>)0x0051FCE0)(ref this, addr, size);
    // int __thiscall InterpretedMotionState::UnPack(InterpretedMotionState*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpretedMotionState, void**, uint, int>)0x0051FF10)(ref this, addr, size);
}

