namespace ACBindings;

// Scene
public unsafe struct Scene
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // Scene_vtbl
    public unsafe struct Scene_vtbl
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
    public uint version;
    public uint num_objects;
    public ACBindings.ObjectDesc* objects;

    // Generated Constructor
    public Scene(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // DBObj* __cdecl Scene::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7DC0)();
    // int __thiscall Scene::Scene(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Scene, void**, int>)0x005A6FD0)(ref this, a2);
    // unsigned int __thiscall Scene::GetDBOType(Scene*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Scene, uint>)0x005A7000)(ref this);
    // void __thiscall Scene::Destroy(Scene*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Scene, void>)0x005A7350)(ref this);
    // unsigned int __thiscall Scene::Pack(Scene*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Scene, void**, uint, uint>)0x005A7380)(ref this, addr, size);
    // int __thiscall Scene::UnPack(Scene*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Scene, void**, uint, int>)0x005A7410)(ref this, addr, size);
}

