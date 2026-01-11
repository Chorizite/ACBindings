namespace ACBindings.Internal;

public unsafe struct MaterialModifier : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct MaterialModifier_vtbl
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
    public ACBindings.Internal.SmartArray___MaterialProperty_ptr properties;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004503F0
    /// void __thiscall MaterialModifier::GetSubDataIDs(MaterialModifier*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004503F0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00450420
    /// bool __thiscall MaterialModifier::GetSubObjects(MaterialModifier*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, byte>)0x00450420)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450450
    /// bool __thiscall MaterialModifier::ReleaseSubObjects(MaterialModifier*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, byte>)0x00450450)(ref this);

    /// <summary>
    /// <code>Offset: 0x004504C0
    /// void __thiscall MaterialModifier::End(MaterialModifier*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, void>)0x004504C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004505A0
    /// DBObj* __cdecl MaterialModifier::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004505A0)();

    /// <summary>
    /// <code>Offset: 0x004505F0
    /// void __thiscall MaterialModifier::~MaterialModifier(MaterialModifier*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, void>)0x004505F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450680
    /// bool __thiscall MaterialModifier::CopyInto(MaterialModifier*,DBObj*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, ACBindings.Internal.DBObj*, byte>)0x00450680)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x00450700
    /// void __thiscall MaterialModifier::Serialize(MaterialModifier*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, ACBindings.Internal.Archive*, void>)0x00450700)(ref this, io_archive);
}

