namespace ACBindings;

// PhysicsScript
public unsafe struct PhysicsScript
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // PhysicsScript_vtbl
    public unsafe struct PhysicsScript_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.OldSmartArray__PhysicsScriptData_ptr script_data;
    public double length;

    // Methods
    // DBObj* __cdecl PhysicsScript::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7EB0)();
    // unsigned int __thiscall PhysicsScript::GetDBOType(PhysicsScript*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScript, uint>)0x005221F0)(ref this);
    // void __thiscall PhysicsScript::Destroy(PhysicsScript*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScript, void>)0x00522210)(ref this);
    // void __thiscall PhysicsScript::GetSubDataIDs(PhysicsScript*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScript, ACBindings.QualifiedDataIDArray*, void>)0x00522280)(ref this, id_array);
    // unsigned int __thiscall PhysicsScript::pack_size(PhysicsScript*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScript, uint>)0x005222B0)(ref this);
    // unsigned int __thiscall PhysicsScript::Pack(PhysicsScript*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScript, void**, uint, uint>)0x00522300)(ref this, addr, size);
    // int __thiscall PhysicsScript::UnPack(PhysicsScript*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScript, void**, uint, int>)0x005223D0)(ref this, addr, size);
}

