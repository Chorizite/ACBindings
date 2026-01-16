namespace ACBindings.Internal;


/// <summary>Captures all data associated with a user input action, including identifiers, key mapping, timing, repeat behavior, and the callback to invoke.</summary>
public unsafe struct InputEvent
{
    // Members
    public uint m_InputAction;
    public uint m_InputMapID;
    public ACBindings.Internal.QualifiedControl m_InputKey;
    public float m_InputExtent;
    public uint m_InputTimestamp;
    public uint m_ToggleType;
    public byte m_fStart;
    public double m_timeActionBegan;
    public uint m_cRepeatDelta;
    public uint m_cRepeatTotal;
    public ACBindings.Internal.tagPOINT m_ptMousePos;
    public ACBindings.Internal.IInputActionCallback* m_pcCallback;

    // Generated Constructor
    public InputEvent() {
        _ConstructorInternal();
    }
    public InputEvent(ACBindings.Internal.ActionState* as_) {
        _ConstructorInternal(as_);
    }

    // Methods

    /// <summary>Initializes a new InputEvent with default values indicating an inactive or unassigned input state.
    /// <code>Offset: 0x00430EE0
    /// void __thiscall InputEvent::InputEvent(InputEvent*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InputEvent, void>)0x00430EE0)(ref this);

    /// <summary>Initializes an InputEvent from an ActionState, copying action identifiers, extent, toggle settings, repeat counts, and callback while setting default key and map values.
    /// <code>Offset: 0x00430FF0
    /// void __thiscall InputEvent::InputEvent(InputEvent*,const ActionState*)</code>
    /// </summary>
    /// <param name="as">Source ActionState providing data for the event.</param>
    public void _ConstructorInternal(ACBindings.Internal.ActionState* as_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InputEvent, ACBindings.Internal.ActionState*, void>)0x00430FF0)(ref this, as_);
}

