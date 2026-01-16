namespace ACBindings.Internal;


/// <summary>Represents a snapshot of an entity’s movement state, including motion data, position, timestamps, and control flags for synchronization between client and server.</summary>
public unsafe struct MoveToStatePack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MoveToStatePack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, void> MoveToStatePack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RawMotionState raw_motion_state;
    public ACBindings.Internal.Position position;
    public int contact;
    public int longjump_mode;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public MoveToStatePack(ACBindings.Internal.RawMotionState* raw_motion_state, ACBindings.Internal.Position* position, int contact, int longjump_mode, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(raw_motion_state, position, contact, longjump_mode, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods

    /// <summary>Computes the byte count required to serialize a MoveToStatePack instance, including raw motion state and position data, with 4‑byte alignment.
    /// <code>Offset: 0x005173A0
    /// unsigned int __thiscall MoveToStatePack::pack_size(MoveToStatePack*)</code>
    /// </summary>
    /// <returns>The total packet size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, uint>)0x005173A0)(ref this);

    /// <summary>Serializes a MoveToStatePack instance into a binary buffer when sufficient space is provided, writing motion state, position, timestamps, and control flags in sequence.
    /// <code>Offset: 0x005173F0
    /// unsigned int __thiscall MoveToStatePack::Pack(MoveToStatePack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point past the written data.</param>
    /// <param name="size">Number of bytes available at *addr; must be at least the size returned by PackSize() for serialization to occur.</param>
    /// <returns>The number of bytes required to pack the MoveToStatePack, regardless of whether the buffer had sufficient space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, void**, uint, uint>)0x005173F0)(ref this, addr, size);

    /// <summary>Restores a MoveToStatePack from serialized data, reading motion state, position, timestamps and flags while advancing the buffer pointer.
    /// <code>Offset: 0x005174B0
    /// int __thiscall MoveToStatePack::UnPack(MoveToStatePack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the byte stream; on return points past the consumed data.</param>
    /// <param name="size">Number of bytes available in the stream.</param>
    /// <returns>1 if unpack succeeded; 0 if size insufficient or sub-unpack failed.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, void**, uint, int>)0x005174B0)(ref this, addr, size);

    /// <summary>Constructs a MoveToStatePack from supplied motion state, position data, contact flag, long‑jump mode, and timestamp values.
    /// <code>Offset: 0x00517AF0
    /// void __thiscall MoveToStatePack::MoveToStatePack(MoveToStatePack*,const RawMotionState*,const Position*,int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="raw_motion_state">Source RawMotionState to copy into the pack.</param>
    /// <param name="position">Position information (cell ID and frame) used to initialize the pack's position member.</param>
    /// <param name="contact">Flag indicating whether the entity is in contact with a surface or object.</param>
    /// <param name="longjump_mode">Mode identifier controlling long‑jump behavior for the pack.</param>
    /// <param name="instance_timestamp">Timestamp marking when this state was created on the client instance.</param>
    /// <param name="server_control_timestamp">Timestamp indicating server‑controlled update timing.</param>
    /// <param name="teleport_timestamp">Timestamp used to track teleportation events.</param>
    /// <param name="force_position_ts">Timestamp signaling a forced position override.</param>
    public void _ConstructorInternal(ACBindings.Internal.RawMotionState* raw_motion_state, ACBindings.Internal.Position* position, int contact, int longjump_mode, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, ACBindings.Internal.RawMotionState*, ACBindings.Internal.Position*, int, int, ushort, ushort, ushort, ushort, void>)0x00517AF0)(ref this, raw_motion_state, position, contact, longjump_mode, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
}

