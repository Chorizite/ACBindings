namespace ACBindings;

// InputEvent
public unsafe struct InputEvent
{
    // Members
    public uint m_InputAction;
    public uint m_InputMapID;
    public ACBindings.QualifiedControl m_InputKey;
    public float m_InputExtent;
    public uint m_InputTimestamp;
    public uint m_ToggleType;
    public byte m_fStart;
    public double m_timeActionBegan;
    public uint m_cRepeatDelta;
    public uint m_cRepeatTotal;
    public ACBindings.tagPOINT m_ptMousePos;
    public ACBindings.IInputActionCallback* m_pcCallback;

    // Generated Constructor
    public InputEvent() {
        _ConstructorInternal();
    }
    public InputEvent(ACBindings.ActionState* as_) {
        _ConstructorInternal(as_);
    }

    // Methods
    // void __thiscall InputEvent::InputEvent(InputEvent*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InputEvent, void>)0x00430EE0)(ref this);
    // void __thiscall InputEvent::InputEvent(InputEvent*,const ActionState*)
    public void _ConstructorInternal(ACBindings.ActionState* as_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InputEvent, ACBindings.ActionState*, void>)0x00430FF0)(ref this, as_);
}

