namespace ACBindings.Internal;


/// <summary>Tracks the state of an input action, recording when the action began, how many times it has repeated, its toggle status, and a callback reference. Holds key information for single-key actions via a smart array.</summary>
public unsafe struct ActionState
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashData__uint___ActionState_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___ActionState_ptr

    // Child Types

    /// <summary>Describes a single key input event, including its control specification and the extent of activation.</summary>
    public unsafe struct SingleKeyInfo
    {
        // Members
        public ACBindings.Internal.ControlSpecification key;
        public float extent;

        // Generated Constructor
        public SingleKeyInfo() {
            _ConstructorInternal();
        }

        // Methods

        /// <summary>Initializes the key field to an invalid identifier, marking the instance as unused or unassigned.
        /// <code>Offset: 0x00677BE0
        /// void __thiscall ActionState::SingleKeyInfo::SingleKeyInfo(ActionState::SingleKeyInfo*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionState.SingleKeyInfo, void>)0x00677BE0)(ref this);
    }

    // Members
    public double m_timeActionBegan;
    public uint m_cRepeatCount;
    public uint m_toggle;
    public ACBindings.Internal.IInputActionCallback* m_pcCallback;
    public ACBindings.Internal.SmartArray___ActionState_SingleKeyInfo m_rgKeys;

    // Methods

    /// <summary>Retrieves the extent of the key with the greatest absolute value among those stored in this action state.
    /// <code>Offset: 0x00430F90
    /// float __thiscall ActionState::GetExtent(ActionState*)</code>
    /// </summary>
    /// <returns>The signed extent corresponding to that key, or zero if the state contains no keys.</returns>
    public float GetExtent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionState, float>)0x00430F90)(ref this);

    /// <summary>Removes a key press from the action state and updates or terminates the action accordingly.
    /// <code>Offset: 0x004315C0
    /// ActionStateChangeType __thiscall ActionState::RemoveKeyPress(ActionState*,InputEvent*)</code>
    /// </summary>
    /// <param name="io_inEvt">The input event whose key press is to be removed.</param>
    /// <returns>The resulting change type: unchanged, stopped (if no keys remain), or updated (if the active extent changes).</returns>
    public ACBindings.Internal.ActionStateChangeType RemoveKeyPress(ACBindings.Internal.InputEvent* io_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionState, ACBindings.Internal.InputEvent*, ACBindings.Internal.ActionStateChangeType>)0x004315C0)(ref this, io_inEvt);

    /// <summary>Records a key press for an action state, updating or adding key information and adjusting timing and toggle data.
    /// <code>Offset: 0x00431FA0
    /// ActionStateChangeType __thiscall ActionState::AddKeyPress(ActionState*,InputEvent*)</code>
    /// </summary>
    /// <param name="io_inEvt">Event containing the pressed key’s details such as key code, extent, timestamp, toggle type, and optional callback.</param>
    /// <returns>Zero when this is the first key press; otherwise returns asctActionUpdated. If the new input’s absolute extent does not exceed any previously recorded extent for that action, a value of 2 is returned to indicate that no higher extent was achieved.</returns>
    public ACBindings.Internal.ActionStateChangeType AddKeyPress(ACBindings.Internal.InputEvent* io_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionState, ACBindings.Internal.InputEvent*, ACBindings.Internal.ActionStateChangeType>)0x00431FA0)(ref this, io_inEvt);
}

