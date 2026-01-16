namespace ACBindings.Internal;


/// <summary>Captures positional data and state for an object within a simulation or game world, including timestamps, coordinates, velocity, placement ID, and collision status.</summary>
public unsafe struct PositionPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PositionPack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PositionPack*, void> PositionPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PositionPack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PositionPack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PositionPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ushort instance_timestamp;
    public ushort position_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_timestamp;
    public ACBindings.Internal.Position position;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public uint placement_id;
    public int has_contact;

    // Generated Constructor
    public PositionPack() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Computes the byte size of a PositionPack serialization and writes a bitmask that indicates which optional fields will be included.
    /// <code>Offset: 0x00516F40
    /// unsigned int __cdecl PositionPack::GetPackSize(unsigned int*,const Position*,const AC1Legacy::Vector3*,unsigned int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="bitfield">Output mask describing included data: bit 0 for velocity, bit 1 for placement ID, bit 2 for contact flag, bits 3‑6 indicate omission (when set) of quaternion components qw, qx, qy, qz that are below the magnitude threshold.</param>
    /// <param name="p">Pointer to a Position object; its frame is examined to determine which quaternion components are transmitted and to obtain the base type size via NoDrawHook::GetType.</param>
    /// <param name="velocity">If any component’s absolute value is ≥ 0.00019999999, bit 0 of the mask is set and 12 bytes for the velocity vector are added to the total size.</param>
    /// <param name="placement_id">Non‑zero values cause bit 1 of the mask to be set and add an additional 4 bytes for the placement ID field.</param>
    /// <param name="has_contact">A non‑zero value sets bit 2 of the mask; this flag does not alter the packet size.</param>
    /// <param name="instance_timestamp">Timestamp parameter unused in size calculation (reserved for future use).</param>
    /// <param name="position_timestamp">Timestamp parameter unused in size calculation (reserved for future use).</param>
    /// <param name="teleport_timestamp">Timestamp parameter unused in size calculation (reserved for future use).</param>
    /// <param name="force_position_timestamp">Timestamp parameter unused in size calculation (reserved for future use).</param>
    /// <returns>Unsigned integer representing the total packet size in bytes, including base fields and any optional data indicated by the bitmask.</returns>
    public static uint GetPackSize(uint* bitfield, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* velocity, uint placement_id, int has_contact, ushort instance_timestamp, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Cdecl]<uint*, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, uint, int, ushort, ushort, ushort, ushort, uint>)0x00516F40)(bitfield, p, velocity, placement_id, has_contact, instance_timestamp, position_timestamp, teleport_timestamp, force_position_timestamp);

    /// <summary>Constructs a PositionPack instance, initializing its base class virtual table pointer, setting up the embedded position object's vtable, assigning an identity frame with zero translation to the position, and caching that frame for future use.
    /// <code>Offset: 0x00517080
    /// void __thiscall PositionPack::PositionPack(PositionPack*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPack, void>)0x00517080)(ref this);

    /// <summary>Packs a Position object’s state into a binary buffer, writing a bitfield header followed by optional orientation components, velocity vector, placement ID, and timestamp fields according to flags.
    /// <code>Offset: 0x005170C0
    /// void __cdecl PositionPack::PackPosition(void**,unsigned int,unsigned int,const Position*,const AC1Legacy::Vector3*,unsigned int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in the buffer; updated to point after the written block.</param>
    /// <param name="size">Remaining size of the buffer in bytes, used when including optional velocity data.</param>
    /// <param name="bitfield">Bitmask controlling which fields are serialized (e.g., velocity, placement ID, quaternion components).</param>
    /// <param name="p">Position object providing origin and frame quaternion for packing.</param>
    /// <param name="velocity">Velocity vector to include if the corresponding flag is set; ignored otherwise.</param>
    /// <param name="placement_id">Placement identifier written when its flag is present.</param>
    /// <param name="has_contact">Contact state of the position; not serialized by this function but part of the source structure.</param>
    /// <param name="instance_timestamp">Timestamp for instance data, written after optional fields.</param>
    /// <param name="position_timestamp">Position timestamp, follows instance timestamp.</param>
    /// <param name="teleport_timestamp">Teleport event timestamp, follows previous timestamps.</param>
    /// <param name="force_position_timestamp">Force position timestamp, written last before advancing pointer.</param>
    public static void PackPosition(void** addr, uint size, uint bitfield, ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* velocity, uint placement_id, int has_contact, ushort instance_timestamp, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Cdecl]<void**, uint, uint, ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, uint, int, ushort, ushort, ushort, ushort, void>)0x005170C0)(addr, size, bitfield, p, velocity, placement_id, has_contact, instance_timestamp, position_timestamp, teleport_timestamp, force_position_timestamp);

    /// <summary>Packages position, velocity, and related metadata into a binary format for transmission or storage.
    /// <code>Offset: 0x005171B0
    /// unsigned int __thiscall PositionPack::Pack(PositionPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the destination buffer where packed data will be written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>The total size, in bytes, of the packed data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPack, void**, uint, uint>)0x005171B0)(ref this, addr, size);

    /// <summary>Unpacks serialized position data into the PositionPack object, updating its position, velocity, placement ID, and timestamp fields based on flags encoded in the stream.
    /// <code>Offset: 0x00517240
    /// int __thiscall PositionPack::UnPack(PositionPack*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The PositionPack instance to populate.</param>
    /// <param name="addr">Pointer to a buffer pointer; it is advanced as data is read.</param>
    /// <param name="size">Number of bytes remaining in the buffer, used to guard optional fields.</param>
    /// <returns>1 on success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPack, void**, uint, int>)0x00517240)(ref this, addr, size);
}

