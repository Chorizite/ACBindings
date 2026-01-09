namespace ACBindings;

// ActionState
public unsafe struct ActionState
{
    // Base Classes
    public ACBindings.IntrusiveHashData__uint__ActionState_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__uint__ActionState_ptr

    // Child Types
    // ActionState::SingleKeyInfo
    public unsafe struct SingleKeyInfo
    {
        // Members
        public ACBindings.ControlSpecification key;
        public float extent;

        // Generated Constructor
        public SingleKeyInfo() {
            _ConstructorInternal();
        }

        // Methods
        // void __thiscall ActionState::SingleKeyInfo::SingleKeyInfo(ActionState::SingleKeyInfo*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionState.SingleKeyInfo, void>)0x00677BE0)(ref this);
    }

    // Members
    public double m_timeActionBegan;
    public uint m_cRepeatCount;
    public uint m_toggle;
    public ACBindings.IInputActionCallback* m_pcCallback;
    public ACBindings.SmartArray__ActionState_SingleKeyInfo m_rgKeys;

    // Methods
    // float __thiscall ActionState::GetExtent(ActionState*)
    public float GetExtent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionState, float>)0x00430F90)(ref this);
    // ActionStateChangeType __thiscall ActionState::RemoveKeyPress(ActionState*,InputEvent*)
    public ACBindings.ActionStateChangeType RemoveKeyPress(ACBindings.InputEvent* io_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionState, ACBindings.InputEvent*, ACBindings.ActionStateChangeType>)0x004315C0)(ref this, io_inEvt);
    // ActionStateChangeType __thiscall ActionState::AddKeyPress(ActionState*,InputEvent*)
    public ACBindings.ActionStateChangeType AddKeyPress(ACBindings.InputEvent* io_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionState, ACBindings.InputEvent*, ACBindings.ActionStateChangeType>)0x00431FA0)(ref this, io_inEvt);
}

