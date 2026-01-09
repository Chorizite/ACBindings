namespace ACBindings;

// RawMotionState
public unsafe struct RawMotionState : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // RawMotionState_vtbl
    public unsafe struct RawMotionState_vtbl
    {
        // Members
        public System.IntPtr RawMotionState_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }
    // RawMotionState::PackBitfield
    public unsafe struct PackBitfield
    {
        // Members
        public short _bf_0;

        // Methods
    }

    // Members
    public ACBindings.LList__ActionNode actions;
    public ACBindings.HoldKey current_holdkey;
    public uint current_style;
    public uint forward_command;
    public ACBindings.HoldKey forward_holdkey;
    public float forward_speed;
    public uint sidestep_command;
    public ACBindings.HoldKey sidestep_holdkey;
    public float sidestep_speed;
    public uint turn_command;
    public ACBindings.HoldKey turn_holdkey;
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
    // void __thiscall RawMotionState::RemoveMotion(RawMotionState*,unsigned int)
    public void RemoveMotion(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, uint, void>)0x0051F1F0)(ref this, motion);
    // void __thiscall RawMotionState::RawMotionState(RawMotionState*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, void>)0x0051F300)(ref this);
    // void __thiscall RawMotionState::AddAction(RawMotionState*,unsigned int,float,unsigned int,int)
    public void AddAction(uint action, float speed, uint stamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, uint, float, uint, int, void>)0x0051F350)(ref this, action, speed, stamp, autonomous);
    // unsigned int __thiscall RawMotionState::RemoveAction(RawMotionState*)
    public uint RemoveAction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, uint>)0x0051F3B0)(ref this);
    // void __thiscall RawMotionState::Destroy(RawMotionState*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, void>)0x0051F630)(ref this);
    // void __thiscall RawMotionState::ApplyMotion(RawMotionState*,unsigned int,const MovementParameters*)
    public void ApplyMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, uint, ACBindings.MovementParameters*, void>)0x0051F670)(ref this, motion, params_);
    // unsigned int __thiscall RawMotionState::Pack(RawMotionState*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, void**, uint, uint>)0x0051F820)(ref this, addr, size);
    // int __thiscall RawMotionState::UnPack(RawMotionState*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, void**, uint, int>)0x0051FAD0)(ref this, addr, size);
    // void __thiscall RawMotionState::~RawMotionState(RawMotionState*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RawMotionState, void>)0x005200D0)(ref this);
}

