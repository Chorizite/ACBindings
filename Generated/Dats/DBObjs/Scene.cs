namespace ACBindings.Internal;


/// <summary>Represents a scene within the database system, containing version data and an array of object descriptors for serialization.</summary>
public unsafe struct Scene
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct Scene_vtbl
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
    public uint version;
    public uint num_objects;
    public ACBindings.Internal.ObjectDesc* objects;

    // Generated Constructor
    public Scene(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Allocates and constructs a new Scene object, returning a pointer to its underlying DBObj base class.
    /// <code>Offset: 0x004F7DC0
    /// DBObj* __cdecl Scene::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the created DBObj instance, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7DC0)();

    /// <summary>Initializes a Scene instance, constructing its DBObj base with the supplied data pointer, setting up PackObj vtable entries, and clearing the object list.
    /// <code>Offset: 0x005A6FD0
    /// int __thiscall Scene::Scene(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer passed to the DBObj constructor for initialization of the underlying database object.</param>
    /// <returns>The constructed Scene object (this) after initialization.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void**, int>)0x005A6FD0)(ref this, a2);

    /// <summary>Returns the database object type identifier for a Scene instance.
    /// <code>Offset: 0x005A7000
    /// unsigned int __thiscall Scene::GetDBOType(Scene*)</code>
    /// </summary>
    /// <returns>A constant integer value 27 representing the Scene DBO type.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, uint>)0x005A7000)(ref this);

    /// <summary>Destroys all objects owned by the scene, freeing their memory and resetting the object count to zero.
    /// <code>Offset: 0x005A7350
    /// void __thiscall Scene::Destroy(Scene*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void>)0x005A7350)(ref this);

    /// <summary>Serializes a Scene into a binary buffer. The first 4 bytes contain the object count, followed by each ObjectDesc packed sequentially.
    /// <code>Offset: 0x005A7380
    /// unsigned int __thiscall Scene::Pack(Scene*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position within the destination buffer; updated to point past the last written byte when serialization succeeds.</param>
    /// <param name="size">Maximum number of bytes available at *addr for serialization.</param>
    /// <returns>The total number of bytes required to serialize the scene. If size is smaller than this value, no data is written and the function returns the required length.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void**, uint, uint>)0x005A7380)(ref this, addr, size);

    /// <summary>Deserializes a Scene instance from a binary stream, allocating and populating its ObjectDesc array.
    /// <code>Offset: 0x005A7410
    /// int __thiscall Scene::UnPack(Scene*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; advanced past the data consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the source buffer; must be at least four to contain the object count. The value is not modified by the function.</param>
    /// <returns>Non‑zero if unpacking succeeded; zero if the buffer contains fewer than four bytes.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Scene, void**, uint, int>)0x005A7410)(ref this, addr, size);
}

