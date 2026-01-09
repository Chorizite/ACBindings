namespace ACBindings;

// PhysicsDesc
public unsafe struct PhysicsDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // PhysicsDesc_vtbl
    public unsafe struct PhysicsDesc_vtbl
    {
        // Members
        public System.IntPtr PhysicsDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    public ACBindings.Position pos;
    public uint state;
    public float object_scale;
    public float friction;
    public float elasticity;
    public float translucency;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public ACBindings.AC1Legacy.Vector3 acceleration;
    public ACBindings.AC1Legacy.Vector3 omega;
    public uint num_children;
    public uint* child_ids;
    public uint* child_location_ids;
    public uint parent_id;
    public uint location_id;
    public ACBindings.IDClass___tagDataID mtable_id;
    public ACBindings.IDClass___tagDataID stable_id;
    public ACBindings.IDClass___tagDataID phstable_id;
    public ACBindings.PScriptType default_script;
    public float default_script_intensity;
    public ACBindings.IDClass___tagDataID setup_id;
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
    // AC1Legacy::Vector3* __thiscall PhysicsDesc::get_omega(PhysicsDesc*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* get_omega(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x004529B0)(ref this, result);
    // Position* __thiscall PhysicsDesc::get_position(PhysicsDesc*,Position*)
    public ACBindings.Position* get_position(ACBindings.Position* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, ACBindings.Position*, ACBindings.Position*>)0x004538B0)(ref this, result);
    // unsigned int __thiscall PhysicsDesc::get_animframe_id(ChatRoomTracker*)
    public uint get_animframe_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, uint>)0x004F32B0)(ref this);
    // unsigned int __thiscall PhysicsDesc::get_autonomous_movement(ChatRoomTracker*)
    public uint get_autonomous_movement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, uint>)0x0051DF70)(ref this);
    // unsigned __int16 __thiscall PhysicsDesc::get_timestamp(PhysicsDesc*,PhysicsTimeStamp)
    public ushort get_timestamp(ACBindings.PhysicsTimeStamp stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, ACBindings.PhysicsTimeStamp, ushort>)0x0051DF80)(ref this, stamp);
    // unsigned int __thiscall PhysicsDesc::get_parent_id(PhysicsDesc*)
    public uint get_parent_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, uint>)0x0051DF90)(ref this);
    // unsigned int __thiscall PhysicsDesc::get_parent_location_id(ACCharGenResult*)
    public uint get_parent_location_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, uint>)0x0051DFA0)(ref this);
    // unsigned int __thiscall PhysicsDesc::get_child_id(PhysicsDesc*,unsigned int)
    public uint get_child_id(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, uint, uint>)0x0051DFC0)(ref this, index);
    // unsigned int __thiscall PhysicsDesc::get_child_location_id(PhysicsDesc*,unsigned int)
    public uint get_child_location_id(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, uint, uint>)0x0051DFD0)(ref this, index);
    // void __thiscall PhysicsDesc::PhysicsDesc(PhysicsDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, void>)0x0051DFE0)(ref this);
    // void __thiscall PhysicsDesc::Destroy(PhysicsDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, void>)0x0051E0E0)(ref this);
    // void __thiscall PhysicsDesc::~PhysicsDesc(PhysicsDesc*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, void>)0x0051E250)(ref this);
    // _DWORD* __thiscall PhysicsDesc::get_mtable_id(_DWORD*,_DWORD*)
    public int* get_mtable_id(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, int*, int*>)0x0051E270)(ref this, a2);
    // _DWORD* __thiscall PhysicsDesc::get_setup_id(_DWORD*,_DWORD*)
    public int* get_setup_id(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, int*, int*>)0x0051E280)(ref this, a2);
    // unsigned int __thiscall PhysicsDesc::Pack(PhysicsDesc*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, void**, uint, uint>)0x0051E2D0)(ref this, addr, size);
    // int __thiscall PhysicsDesc::UnPack(PhysicsDesc*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsDesc, void**, uint, int>)0x0051E8E0)(ref this, addr, size);
}

