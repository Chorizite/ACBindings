namespace ACBindings.Internal;


/// <summary>Represents a material modifier that associates a database object with an array of property overrides, enabling dynamic adjustment of material attributes.</summary>
public unsafe struct MaterialModifier : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct MaterialModifier_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___MaterialProperty_ptr properties;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Collects sub‑data identifiers from all material properties and appends them to the specified array.
    /// <code>Offset: 0x004503F0
    /// void __thiscall MaterialModifier::GetSubDataIDs(MaterialModifier*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the gathered data IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004503F0)(ref this, id_array);

    /// <summary>Verifies that every material property in the modifier can provide its sub‑objects; returns true only when all calls succeed.
    /// <code>Offset: 0x00450420
    /// bool __thiscall MaterialModifier::GetSubObjects(MaterialModifier*)</code>
    /// </summary>
    /// <returns>True if all properties report success; false if any fails.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, byte>)0x00450420)(ref this);

    /// <summary>Releases sub-objects for every property stored in this material modifier, propagating failures.
    /// <code>Offset: 0x00450450
    /// bool __thiscall MaterialModifier::ReleaseSubObjects(MaterialModifier*)</code>
    /// </summary>
    /// <returns>True when all property sub-objects were released successfully; otherwise false.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, byte>)0x00450450)(ref this);

    /// <summary>Releases all sub‑objects of the modifier’s properties, deletes each property object, clears the property array, and frees allocated memory when necessary.
    /// <code>Offset: 0x004504C0
    /// void __thiscall MaterialModifier::End(MaterialModifier*)</code>
    /// </summary>
    /// <param name="this">The MaterialModifier instance to clean up.</param>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, void>)0x004504C0)(ref this);

    /// <summary>Creates a new MaterialModifier instance, initializing its base DBObj fields and vtable pointer.
    /// <code>Offset: 0x004505A0
    /// DBObj* __cdecl MaterialModifier::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated DBObj representing the MaterialModifier; null if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004505A0)();

    /// <summary>Destroys a MaterialModifier object, freeing its property array and invoking the base class destructor for cleanup.
    /// <code>Offset: 0x004505F0
    /// void __thiscall MaterialModifier::~MaterialModifier(MaterialModifier*)</code>
    /// </summary>
    /// <param name="this">Pointer to the MaterialModifier instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, void>)0x004505F0)(ref this);

    /// <summary>Copies all material properties from the current modifier into a target DBObj, expanding its internal array as required.
    /// <code>Offset: 0x00450680
    /// bool __thiscall MaterialModifier::CopyInto(MaterialModifier*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">The destination DBObj that will receive the copied properties.</param>
    /// <returns>True if every property was successfully copied; otherwise false.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, ACBindings.Internal.DBObj*, byte>)0x00450680)(ref this, retval);

    /// <summary>Serializes the MaterialModifier, including its base class and associated material properties, to or from an Archive. Handles both reading and writing of property data according to archive flags.
    /// <code>Offset: 0x00450700
    /// void __thiscall MaterialModifier::Serialize(MaterialModifier*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization; determines read/write mode via its flags.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialModifier, ACBindings.Internal.Archive*, void>)0x00450700)(ref this, io_archive);
}

