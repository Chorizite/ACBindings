namespace ACBindings.Internal;


/// <summary>
/// Captures an entity’s position, contact identifier, and multiple timestamps for autonomous control synchronization.  
/// Serializes to and from a binary buffer, enabling network transmission or persistent storage of state updates.
/// </summary>
public unsafe struct AutonomousPositionPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AutonomousPositionPack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, void> AutonomousPositionPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Position position;
    public int contact;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public AutonomousPositionPack(ACBindings.Internal.Position* position, int contact, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(position, contact, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods

    /// <summary>Initializes an AutonomousPositionPack object with a given Position, contact identifier, and associated timestamps.
    /// <code>Offset: 0x00517570
    /// void __thiscall AutonomousPositionPack::AutonomousPositionPack(AutonomousPositionPack*,const Position*,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="position">Source position to copy into the pack.</param>
    /// <param name="contact">Contact index or type used by the autonomous system.</param>
    /// <param name="instance_timestamp">Timestamp marking when this instance was created.</param>
    /// <param name="server_control_timestamp">Timestamp from server control updates.</param>
    /// <param name="teleport_timestamp">Timestamp indicating a teleport event.</param>
    /// <param name="force_position_ts">Timestamp of the last forced position update.</param>
    public void _ConstructorInternal(ACBindings.Internal.Position* position, int contact, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutonomousPositionPack, ACBindings.Internal.Position*, int, ushort, ushort, ushort, ushort, void>)0x00517570)(ref this, position, contact, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);

    /// <summary>Packs an AutonomousPositionPack into a binary buffer, serializing position information, timestamps, and contact status while ensuring proper alignment.
    /// <code>Offset: 0x005175F0
    /// unsigned int __thiscall AutonomousPositionPack::Pack(AutonomousPositionPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer location; if sufficient space is provided, the function writes data here and advances the pointer accordingly.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>The total number of bytes required to store the packed representation (including alignment padding). If size is insufficient, no data is written but the return value still indicates the needed length.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutonomousPositionPack, void**, uint, uint>)0x005175F0)(ref this, addr, size);

    /// <summary>Unpacks an AutonomousPositionPack from serialized data, updating timestamps and contact flag after validating buffer length.
    /// <code>Offset: 0x005176A0
    /// int __thiscall AutonomousPositionPack::UnPack(AutonomousPositionPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the source buffer pointer; advanced as data is consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer available for unpacking.</param>
    /// <returns>Returns 1 if the object was unpacked successfully; returns 0 if the buffer is too small or an error occurs during unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutonomousPositionPack, void**, uint, int>)0x005176A0)(ref this, addr, size);
}

