namespace ACBindings;

// CAnimation
public unsafe struct CAnimation : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CAnimation_vtbl
    public unsafe struct CAnimation_vtbl
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
    public ACBindings.AFrame* pos_frames;
    public ACBindings.AnimFrame* part_frames;
    public int has_hooks;
    public uint num_parts;
    public uint num_frames;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl CAnimation::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7B30)();
    // void __thiscall CAnimation::GetSubDataIDs(CAnimation*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimation, ACBindings.QualifiedDataIDArray*, void>)0x00520200)(ref this, id_array);
    // unsigned int __thiscall CAnimation::pack_size(CAnimation*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimation, uint>)0x00520250)(ref this);
    // unsigned int __thiscall CAnimation::Pack(CAnimation*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimation, void**, uint, uint>)0x00520590)(ref this, addr, size);
    // int __thiscall CAnimation::UnPack(CAnimation*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimation, void**, uint, int>)0x00520660)(ref this, addr, size);
    // void __thiscall CAnimation::Destroy(CAnimation*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimation, void>)0x00520780)(ref this);
    // void __thiscall CAnimation::~CAnimation(CAnimation*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAnimation, void>)0x005207C0)(ref this);
}

