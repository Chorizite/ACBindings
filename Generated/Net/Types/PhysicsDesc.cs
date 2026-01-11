namespace ACBindings.Internal;

public unsafe struct PhysicsDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PhysicsDesc_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, void> PhysicsDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsDesc*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004529B0
    /// AC1Legacy::Vector3* __thiscall PhysicsDesc::get_omega(PhysicsDesc*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* get_omega(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x004529B0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x004538B0
    /// Position* __thiscall PhysicsDesc::get_position(PhysicsDesc*,Position*)</code>
    /// </summary>
    public ACBindings.Internal.Position* get_position(ACBindings.Internal.Position* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, ACBindings.Internal.Position*, ACBindings.Internal.Position*>)0x004538B0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x004F32B0
    /// unsigned int __thiscall PhysicsDesc::get_animframe_id(ChatRoomTracker*)</code>
    /// </summary>
    public uint get_animframe_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x004F32B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051DF70
    /// unsigned int __thiscall PhysicsDesc::get_autonomous_movement(ChatRoomTracker*)</code>
    /// </summary>
    public uint get_autonomous_movement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x0051DF70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051DF80
    /// unsigned __int16 __thiscall PhysicsDesc::get_timestamp(PhysicsDesc*,PhysicsTimeStamp)</code>
    /// </summary>
    public ushort get_timestamp(ACBindings.Internal.PhysicsTimeStamp stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, ACBindings.Internal.PhysicsTimeStamp, ushort>)0x0051DF80)(ref this, stamp);

    /// <summary>
    /// <code>Offset: 0x0051DF90
    /// unsigned int __thiscall PhysicsDesc::get_parent_id(PhysicsDesc*)</code>
    /// </summary>
    public uint get_parent_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x0051DF90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051DFA0
    /// unsigned int __thiscall PhysicsDesc::get_parent_location_id(ACCharGenResult*)</code>
    /// </summary>
    public uint get_parent_location_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint>)0x0051DFA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051DFC0
    /// unsigned int __thiscall PhysicsDesc::get_child_id(PhysicsDesc*,unsigned int)</code>
    /// </summary>
    public uint get_child_id(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint, uint>)0x0051DFC0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x0051DFD0
    /// unsigned int __thiscall PhysicsDesc::get_child_location_id(PhysicsDesc*,unsigned int)</code>
    /// </summary>
    public uint get_child_location_id(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, uint, uint>)0x0051DFD0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x0051DFE0
    /// void __thiscall PhysicsDesc::PhysicsDesc(PhysicsDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void>)0x0051DFE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051E0E0
    /// void __thiscall PhysicsDesc::Destroy(PhysicsDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void>)0x0051E0E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051E250
    /// void __thiscall PhysicsDesc::~PhysicsDesc(PhysicsDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void>)0x0051E250)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051E270
    /// _DWORD* __thiscall PhysicsDesc::get_mtable_id(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* get_mtable_id(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, int*, int*>)0x0051E270)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0051E280
    /// _DWORD* __thiscall PhysicsDesc::get_setup_id(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* get_setup_id(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, int*, int*>)0x0051E280)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0051E2D0
    /// unsigned int __thiscall PhysicsDesc::Pack(PhysicsDesc*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void**, uint, uint>)0x0051E2D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0051E8E0
    /// int __thiscall PhysicsDesc::UnPack(PhysicsDesc*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsDesc, void**, uint, int>)0x0051E8E0)(ref this, addr, size);
}

