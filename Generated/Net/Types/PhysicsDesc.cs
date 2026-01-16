namespace ACBindings.Internal;


/// <summary>Describes the physical state of a game entity, including its position, velocity, rotation, and hierarchical relationships. Stores motion parameters, collision identifiers, and optional rendering attributes such as scale and translucency. Supports packing and unpacking for serialization.</summary>
public unsafe struct PhysicsDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PhysicsDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, void> PhysicsDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, void**, uint, int> UnPack; // function pointer

        // Methods
    }
    // PhysicsDesc::PhysicsDescInfo
    public enum PhysicsDescInfo : uint
    {
    }

    // Members
    public uint bitfield;
    public System.IntPtr movement_buffer;
    public uint buff_length;
    public int autonomous_movement;
    public uint animframe_id;
    public ACBindings.Internal.Position pos;
    public uint state;
    public float object_scale;
    public float friction;
    public float elasticity;
    public float translucency;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.AC1Legacy.Vector3 acceleration;
    public ACBindings.Internal.AC1Legacy.Vector3 omega;
    public uint num_children;
    public uint* child_ids;
    public uint* child_location_ids;
    public uint parent_id;
    public uint location_id;
    public ACBindings.Internal.IDClass____tagDataID mtable_id;
    public ACBindings.Internal.IDClass____tagDataID stable_id;
    public ACBindings.Internal.IDClass____tagDataID phstable_id;
    public ACBindings.Internal.PScriptType default_script;
    public float default_script_intensity;
    public ACBindings.Internal.IDClass____tagDataID setup_id;
    public fixed ushort timestamps[9];

    // Generated Constructor
    public PhysicsDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Copies the object's angular velocity into the supplied vector and returns a pointer to it.
    /// <code>Offset: 0x004529B0
    /// AC1Legacy::Vector3* __thiscall PhysicsDesc::get_omega(PhysicsDesc*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">The vector that receives the copy of the object's angular velocity.</param>
    /// <returns>A pointer to the result vector containing the copied angular velocity.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* get_omega(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x004529B0)(ref this, result);

    /// <summary>
    /// Retrieves the position of this physics object and copies it into the supplied Position structure.
    /// 
    /// <code>Offset: 0x004538B0
    /// Position* __thiscall PhysicsDesc::get_position(PhysicsDesc*,Position*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Position instance that will receive the object's cell ID and frame data.</param>
    /// <returns>The same Position pointer passed in, now populated with the object's current position information.</returns>
    public ACBindings.Internal.Position* get_position(ACBindings.Internal.Position* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, ACBindings.Internal.Position*, ACBindings.Internal.Position*>)0x004538B0)(ref this, result);

    /// <summary>Retrieves the roleplay chat room identifier from a chat room tracker instance.
    /// <code>Offset: 0x004F32B0
    /// unsigned int __thiscall PhysicsDesc::get_animframe_id(ChatRoomTracker*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ChatRoomTracker whose roleplay chat room ID is returned.</param>
    /// <returns>The roleplay chat room ID as an unsigned integer.</returns>
    public uint get_animframe_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x004F32B0)(ref this);

    /// <summary>Retrieves the LFG chat room identifier from the supplied chat room tracker.
    /// <code>Offset: 0x0051DF70
    /// unsigned int __thiscall PhysicsDesc::get_autonomous_movement(ChatRoomTracker*)</code>
    /// </summary>
    /// <param name="chatRoomTracker">The chat room tracker instance to query.</param>
    /// <returns>The unsigned integer identifier of the LFG chat room.</returns>
    public uint get_autonomous_movement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x0051DF70)(ref this);

    /// <summary>Returns the stored timestamp associated with the specified stamp index.
    /// <code>Offset: 0x0051DF80
    /// unsigned __int16 __thiscall PhysicsDesc::get_timestamp(PhysicsDesc*,PhysicsTimeStamp)</code>
    /// </summary>
    /// <param name="stamp">Index identifying which timestamp to retrieve from the object's array.</param>
    /// <returns>The 16‑bit timestamp value.</returns>
    public ushort get_timestamp(ACBindings.Internal.PhysicsTimeStamp stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, ACBindings.Internal.PhysicsTimeStamp, ushort>)0x0051DF80)(ref this, stamp);

    /// <summary>Retrieves the identifier of the parent object associated with this physics description.
    /// <code>Offset: 0x0051DF90
    /// unsigned int __thiscall PhysicsDesc::get_parent_id(PhysicsDesc*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the parent object's ID.</returns>
    public uint get_parent_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x0051DF90)(ref this);

    /// <summary>Retrieves the starting area identifier from a character generation result.
    /// <code>Offset: 0x0051DFA0
    /// unsigned int __thiscall PhysicsDesc::get_parent_location_id(ACCharGenResult*)</code>
    /// </summary>
    /// <param name="this">The character generation result containing start area information.</param>
    /// <returns>The unsigned integer representing the start area ID.</returns>
    public uint get_parent_location_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x0051DFA0)(ref this);

    /// <summary>Retrieves the identifier of the child entity at the specified index within the physics object's child list.
    /// <code>Offset: 0x0051DFC0
    /// unsigned int __thiscall PhysicsDesc::get_child_id(PhysicsDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based index of the child whose ID is requested.</param>
    /// <returns>The unique identifier assigned to the child at the provided position.</returns>
    public uint get_child_id(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint, uint>)0x0051DFC0)(ref this, index);

    /// <summary>Retrieves the location identifier for a child physics object at the specified index.
    /// <code>Offset: 0x0051DFD0
    /// unsigned int __thiscall PhysicsDesc::get_child_location_id(PhysicsDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position within the object's child list.</param>
    /// <returns>The unique identifier representing the child's physical location.</returns>
    public uint get_child_location_id(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint, uint>)0x0051DFD0)(ref this, index);

    /// <summary>Initializes a PhysicsDesc object with default physics parameters, zeroing movement buffers, setting the position frame to an identity transform and origin at (0,0,0), and assigning standard friction, elasticity, scale, and state values.
    /// <code>Offset: 0x0051DFE0
    /// void __thiscall PhysicsDesc::PhysicsDesc(PhysicsDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void>)0x0051DFE0)(ref this);

    /// <summary>Deletes dynamic arrays associated with child IDs and movement data, clears buffers, and resets all fields of the PhysicsDesc object to default values.
    /// <code>Offset: 0x0051E0E0
    /// void __thiscall PhysicsDesc::Destroy(PhysicsDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void>)0x0051E0E0)(ref this);

    /// <summary>Destroys a PhysicsDesc instance, freeing allocated buffers, child ID lists, and resetting base class vtables to their default state.
    /// <code>Offset: 0x0051E250
    /// void __thiscall PhysicsDesc::~PhysicsDesc(PhysicsDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void>)0x0051E250)(ref this);

    /// <summary>Copies the object's mtable ID into the supplied buffer and returns that buffer.
    /// <code>Offset: 0x0051E270
    /// _DWORD* __thiscall PhysicsDesc::get_mtable_id(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a 32‑bit storage location for the mtable ID.</param>
    /// <returns>The same pointer provided as a2, now containing the mtable ID.</returns>
    public int* get_mtable_id(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, int*, int*>)0x0051E270)(ref this, a2);

    /// <summary>Retrieves the physics description's setup identifier and writes it to the supplied output location.
    /// <code>Offset: 0x0051E280
    /// _DWORD* __thiscall PhysicsDesc::get_setup_id(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD that receives the setup ID value.</param>
    /// <returns>The same pointer passed in, pointing to the stored setup ID.</returns>
    public int* get_setup_id(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, int*, int*>)0x0051E280)(ref this, a2);

    /// <summary>Serializes a PhysicsDesc instance into the supplied buffer, writing only fields that are present according to internal flags. The method updates the buffer pointer as it writes data and returns the total number of bytes required for the serialization.
    /// <code>Offset: 0x0051E2D0
    /// unsigned int __thiscall PhysicsDesc::Pack(PhysicsDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position within the output buffer; will be advanced by the size written.</param>
    /// <param name="size">Maximum number of bytes available in the buffer. If this is less than the amount needed, nothing is written.</param>
    /// <returns>The total number of bytes required to serialize the PhysicsDesc object, regardless of whether the actual write occurred.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void**, uint, uint>)0x0051E2D0)(ref this, addr, size);

    /// <summary>Populates the current PhysicsDesc instance from a binary buffer, interpreting field presence via an internal bitfield. The method updates the provided address pointer to consume the data and returns success.
    /// <code>Offset: 0x0051E8E0
    /// int __thiscall PhysicsDesc::UnPack(PhysicsDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that references the start of packed data; on return it points past the consumed bytes.</param>
    /// <param name="size">Remaining size of the buffer, used for bounds checks before reading optional fields.</param>
    /// <returns>Always 1 indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void**, uint, int>)0x0051E8E0)(ref this, addr, size);
}

