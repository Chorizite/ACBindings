namespace ACBindings.Internal;


/// <summary>Represents an entity's motion state, including active actions, input commands for forward, sidestep, and turn movements, associated hold keys, and corresponding speeds.</summary>
public unsafe struct RawMotionState : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct RawMotionState_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, void> RawMotionState_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RawMotionState*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    /// <summary>Stores a 16‑bit packed bitfield that encodes motion state flags within RawMotionState.</summary>
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

    /// <summary>Resets turn and sidestep commands when the motion code matches their identifiers; otherwise, restores forward or style commands to predefined default values if the supplied motion matches the current setting.
    /// <code>Offset: 0x0051F1F0
    /// void __thiscall RawMotionState::RemoveMotion(RawMotionState*,unsigned int)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to clear or reset. Matches specific command codes for turning, sidestepping, forwarding, or styling motions.</param>
    public void RemoveMotion(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint, void>)0x0051F1F0)(ref this, motion);

    /// <summary>Initializes a RawMotionState instance with default motion settings and an empty action list.
    /// <code>Offset: 0x0051F300
    /// void __thiscall RawMotionState::RawMotionState(RawMotionState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void>)0x0051F300)(ref this);

    /// <summary>Adds a new motion action to the state’s queue, recording its identifier, movement speed, timestamp, and autonomy flag.
    /// <code>Offset: 0x0051F350
    /// void __thiscall RawMotionState::AddAction(RawMotionState*,unsigned int,float,unsigned int,int)</code>
    /// </summary>
    /// <param name="action">Identifier of the action to enqueue.</param>
    /// <param name="speed">Desired speed associated with the action.</param>
    /// <param name="stamp">Timestamp or ordering value for the action.</param>
    /// <param name="autonomous">Flag indicating whether the action should be performed automatically (non‑interactive).</param>
    public void AddAction(uint action, float speed, uint stamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint, float, uint, int, void>)0x0051F350)(ref this, action, speed, stamp, autonomous);

    /// <summary>Removes the first entry from the motion state’s action list and deallocates its node.
    /// <code>Offset: 0x0051F3B0
    /// unsigned int __thiscall RawMotionState::RemoveAction(RawMotionState*)</code>
    /// </summary>
    /// <returns>An unsigned integer value taken from the removed node; returns zero if no actions were present.</returns>
    public uint RemoveAction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint>)0x0051F3B0)(ref this);

    /// <summary>Clears the motion state's action list, deallocating all stored action nodes.
    /// <code>Offset: 0x0051F630
    /// void __thiscall RawMotionState::Destroy(RawMotionState*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void>)0x0051F630)(ref this);

    /// <summary>Applies a movement command to the state object by interpreting the supplied motion identifier and parameters, updating internal motion flags, speeds, hold keys, and adding queued actions as needed.
    /// <code>Offset: 0x0051F670
    /// void __thiscall RawMotionState::ApplyMotion(RawMotionState*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">The motion identifier specifying which type of motion to apply (turn, sidestep, forward, or style change).</param>
    /// <param name="params">A pointer to a <c>MovementParameters</c> structure providing speed, hold key, and other motion-related data.</param>
    public void ApplyMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, uint, ACBindings.Internal.MovementParameters*, void>)0x0051F670)(ref this, motion, params_);

    /// <summary>Serializes the current motion state into a compact binary format, writing only active fields to the supplied buffer.
    /// <code>Offset: 0x0051F820
    /// unsigned int __thiscall RawMotionState::Pack(RawMotionState*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer pointer; data is written at *addr and the pointer is advanced by the number of bytes written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer. If fewer bytes are available than required, no data is written but the full size needed is still returned.</param>
    /// <returns>Number of bytes required to fully encode the motion state, including header and all action entries.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void**, uint, uint>)0x0051F820)(ref this, addr, size);

    /// <summary>Restores a RawMotionState object from serialized data, interpreting a bitmask to determine which fields and action nodes are present.
    /// <code>Offset: 0x0051FAD0
    /// int __thiscall RawMotionState::UnPack(RawMotionState*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to the buffer location; the function advances this pointer as data is consumed.</param>
    /// <param name="size">The number of bytes remaining in the buffer for unpacking.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void**, uint, int>)0x0051FAD0)(ref this, addr, size);

    /// <summary>Destructs a RawMotionState object, releasing its internal resources and resetting the base class vtable pointer to PackObj.
    /// <code>Offset: 0x005200D0
    /// void __thiscall RawMotionState::~RawMotionState(RawMotionState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RawMotionState, void>)0x005200D0)(ref this);
}

