namespace ACBindings.Internal;


/// <summary>Represents the state of a jump pack used in gameplay, including range (extent), launch velocity, position data, and timestamps for instance creation, server updates, teleports, and forced positioning. Encapsulates packing and unpacking logic for network serialization.</summary>
public unsafe struct JumpPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct JumpPack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, void> JumpPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float extent;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.Position position;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public JumpPack(float extent, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.Position* position, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(extent, velocity, position, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods

    /// <summary>Initializes a JumpPack object with specified extent, velocity, position, and timestamps, resetting its internal frame to identity before copying data from the supplied Position.
    /// <code>Offset: 0x00517770
    /// void __thiscall JumpPack::JumpPack(JumpPack*,float,const AC1Legacy::Vector3*,const Position*,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="extent">The maximum reach or range for the jump pack's effect.</param>
    /// <param name="velocity">Pointer to a vector specifying initial velocity applied by the jump pack.</param>
    /// <param name="position">Pointer to a Position structure providing object cell ID and frame data to set as the jump pack's starting state.</param>
    /// <param name="instance_timestamp">Timestamp marking when this instance was created.</param>
    /// <param name="server_control_timestamp">Timestamp indicating last server control update relevant to this jump pack.</param>
    /// <param name="teleport_timestamp">Timestamp of the most recent teleport event associated with the jump pack.</param>
    /// <param name="force_position_ts">Timestamp used for forced position updates.</param>
    public void _ConstructorInternal(float extent, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.Position* position, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.JumpPack, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ushort, ushort, ushort, ushort, void>)0x00517770)(ref this, extent, velocity, position, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);

    /// <summary>Packs JumpPack state into a serialization buffer, writing extent, velocity vector, packed position data and timestamps while applying alignment.
    /// <code>Offset: 0x00517810
    /// unsigned int __thiscall JumpPack::Pack(JumpPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in the output buffer; advanced as data is written.</param>
    /// <param name="size">Number of bytes remaining in the buffer that may be used for packing.</param>
    /// <returns>Number of bytes written (including any padding) when the buffer has sufficient space, or the required byte count otherwise.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.JumpPack, void**, uint, uint>)0x00517810)(ref this, addr, size);

    /// <summary>Unpacks serialized jump data from a buffer into the JumpPack instance, extracting extent, velocity, position, and timestamps while advancing the read pointer.
    /// <code>Offset: 0x005178F0
    /// int __thiscall JumpPack::UnPack(JumpPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the data buffer; updated as bytes are consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer available for unpacking.</param>
    /// <returns>Non‑zero if all required data was successfully extracted; zero if insufficient data or an error occurred during unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.JumpPack, void**, uint, int>)0x005178F0)(ref this, addr, size);
}

