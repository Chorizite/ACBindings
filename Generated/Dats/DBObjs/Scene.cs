namespace ACBindings.Internal;

public unsafe struct Scene
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct Scene_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public uint version;
    public uint num_objects;
    public ACBindings.Internal.ObjectDesc* objects;

    // Generated Constructor
    public Scene(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7DC0
    /// DBObj* __cdecl Scene::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7DC0)();

    /// <summary>
    /// <code>Offset: 0x005A6FD0
    /// int __thiscall Scene::Scene(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void**, int>)0x005A6FD0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005A7000
    /// unsigned int __thiscall Scene::GetDBOType(Scene*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, uint>)0x005A7000)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A7350
    /// void __thiscall Scene::Destroy(Scene*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void>)0x005A7350)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A7380
    /// unsigned int __thiscall Scene::Pack(Scene*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void**, uint, uint>)0x005A7380)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A7410
    /// int __thiscall Scene::UnPack(Scene*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void**, uint, int>)0x005A7410)(ref this, addr, size);
}

