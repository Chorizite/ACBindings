namespace ACBindings.Internal;


/// <summary>Represents the interpreted state of a motion controller, including movement commands and active actions.</summary>
public unsafe struct InterpretedMotionState : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct InterpretedMotionState_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, void> InterpretedMotionState_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.InterpretedMotionState*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    /// <summary>Encapsulates compact representation of motion state flags for an interpreted animation, enabling efficient storage and quick bitwise queries.</summary>
    /// <remarks>Used internally by the motion engine to track active motion parameters within a 32‑bit aligned structure.</remarks>
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

    /// <summary>Copies movement-related fields from a source InterpretedMotionState into this instance, updating style and command data.
    /// <code>Offset: 0x0051F260
    /// void __thiscall InterpretedMotionState::copy_movement_from(InterpretedMotionState*,const InterpretedMotionState*)</code>
    /// </summary>
    /// <param name="rhs">Source InterpretedMotionState containing motion parameters to copy.</param>
    public void copy_movement_from(ACBindings.Internal.InterpretedMotionState* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, ACBindings.Internal.InterpretedMotionState*, void>)0x0051F260)(ref this, rhs);

    /// <summary>Resets internal motion state fields when the provided motion identifier matches a recognized command or style.
    /// <code>Offset: 0x0051F2A0
    /// void __thiscall InterpretedMotionState::RemoveMotion(InterpretedMotionState*,unsigned int)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to remove; specific values trigger clearing of turn, sidestep, forward or style commands.</param>
    public void RemoveMotion(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint, void>)0x0051F2A0)(ref this, motion);

    /// <summary>Creates an InterpretedMotionState instance, setting default motion parameters such as style, forward/ sidestep/turn commands and speeds, and initializing the actions list to empty.
    /// <code>Offset: 0x0051F3E0
    /// void __thiscall InterpretedMotionState::InterpretedMotionState(InterpretedMotionState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void>)0x0051F3E0)(ref this);

    /// <summary>Destroys an InterpretedMotionState instance by clearing its action list and releasing associated memory.
    /// <code>Offset: 0x0051F420
    /// void __thiscall InterpretedMotionState::Destroy(InterpretedMotionState*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void>)0x0051F420)(ref this);

    /// <summary>Adds a new action node to the motion state’s action list.
    /// <code>Offset: 0x0051F4F0
    /// void __thiscall InterpretedMotionState::AddAction(InterpretedMotionState*,unsigned int,float,unsigned int,int)</code>
    /// </summary>
    /// <param name="action">Identifier of the motion action to perform.</param>
    /// <param name="speed">Desired speed for the action.</param>
    /// <param name="stamp">Timestamp or sequence number associated with the action.</param>
    /// <param name="autonomous">Flag indicating whether the action is autonomous (non‑player controlled).</param>
    public void AddAction(uint action, float speed, uint stamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint, float, uint, int, void>)0x0051F4F0)(ref this, action, speed, stamp, autonomous);

    /// <summary>Applies a movement command to the interpreter, updating forward, sidestep, turn states or adding an action based on the motion code.
    /// <code>Offset: 0x0051F550
    /// void __thiscall InterpretedMotionState::ApplyMotion(InterpretedMotionState*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">The motion identifier encoded as a bitmask indicating type of movement and special behavior flags.</param>
    /// <param name="params">Pointer to a MovementParameters structure providing speed, action stamp, and other contextual data used when setting commands or adding actions.</param>
    public void ApplyMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint, ACBindings.Internal.MovementParameters*, void>)0x0051F550)(ref this, motion, params_);

    /// <summary>Removes the first action from the motion state's linked list and deallocates its storage.
    /// <code>Offset: 0x0051F5E0
    /// unsigned int __thiscall InterpretedMotionState::RemoveAction(InterpretedMotionState*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the removed action's identifier; returns 0 when the list is empty.</returns>
    public uint RemoveAction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint>)0x0051F5E0)(ref this);

    /// <summary>Retrieves the current number of actions stored in the motion state.
    /// <code>Offset: 0x0051F610
    /// unsigned int __thiscall InterpretedMotionState::GetNumActions(InterpretedMotionState*)</code>
    /// </summary>
    /// <returns>The total count of action nodes present.</returns>
    public uint GetNumActions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, uint>)0x0051F610)(ref this);

    /// <summary>Destroys an InterpretedMotionState, releasing its action list and resetting the base class state.
    /// <code>Offset: 0x0051FCC0
    /// void __thiscall InterpretedMotionState::~InterpretedMotionState(InterpretedMotionState*)</code>
    /// </summary>
    /// <param name="this">The instance of InterpretedMotionState to be destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void>)0x0051FCC0)(ref this);

    /// <summary>Serializes the motion state into a byte buffer, conditionally including fields based on their values and aligning data to four‑byte boundaries.
    /// <code>Offset: 0x0051FCE0
    /// unsigned int __thiscall InterpretedMotionState::Pack(InterpretedMotionState*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; will be advanced by the function as data is written.</param>
    /// <param name="size">Maximum number of bytes that may be written starting at *addr.</param>
    /// <returns>Number of bytes required to represent the full state, including alignment padding. If size is less than this value, nothing is written but the return still indicates the needed length.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void**, uint, uint>)0x0051FCE0)(ref this, addr, size);

    /// <summary>Reconstructs an InterpretedMotionState object by deserializing data from a buffer, interpreting flag bits to load optional motion parameters and action nodes.
    /// <code>Offset: 0x0051FF10
    /// int __thiscall InterpretedMotionState::UnPack(InterpretedMotionState*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the pointer to the input byte stream; advanced as bytes are consumed during unpacking.</param>
    /// <param name="size">Number of bytes available in the input buffer for reading.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpretedMotionState, void**, uint, int>)0x0051FF10)(ref this, addr, size);
}

