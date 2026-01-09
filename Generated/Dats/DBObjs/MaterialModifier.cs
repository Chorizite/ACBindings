namespace ACBindings;

// MaterialModifier
public unsafe struct MaterialModifier : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // MaterialModifier_vtbl
    public unsafe struct MaterialModifier_vtbl
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
    public ACBindings.SmartArray__MaterialProperty_ptr properties;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall MaterialModifier::GetSubDataIDs(MaterialModifier*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, ACBindings.QualifiedDataIDArray*, void>)0x004503F0)(ref this, id_array);
    // bool __thiscall MaterialModifier::GetSubObjects(MaterialModifier*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, byte>)0x00450420)(ref this);
    // bool __thiscall MaterialModifier::ReleaseSubObjects(MaterialModifier*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, byte>)0x00450450)(ref this);
    // void __thiscall MaterialModifier::End(MaterialModifier*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, void>)0x004504C0)(ref this);
    // DBObj* __cdecl MaterialModifier::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004505A0)();
    // void __thiscall MaterialModifier::~MaterialModifier(MaterialModifier*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, void>)0x004505F0)(ref this);
    // bool __thiscall MaterialModifier::CopyInto(MaterialModifier*,DBObj*)
    public byte CopyInto(ACBindings.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, ACBindings.DBObj*, byte>)0x00450680)(ref this, retval);
    // void __thiscall MaterialModifier::Serialize(MaterialModifier*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialModifier, ACBindings.Archive*, void>)0x00450700)(ref this, io_archive);
}

