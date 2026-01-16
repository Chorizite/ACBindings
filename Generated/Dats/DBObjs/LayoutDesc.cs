namespace ACBindings.Internal;


/// <summary>Defines layout parameters for a user interface, including display size and collections of elements used during rendering.</summary>
public unsafe struct LayoutDesc : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Statics
    public static byte* s_bUseDescCache = (byte*)0x00835A70;
    public static ACBindings.Internal.HashTable___IDClass____tagDataID___HashTable__uint___ElementDesc* s_DescCache = (ACBindings.Internal.HashTable___IDClass____tagDataID___HashTable__uint___ElementDesc*)0x00835A78;

    // Child Types
    public unsafe struct LayoutDesc_vtbl
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
    public uint m_displayWidth;
    public uint m_displayHeight;
    public ACBindings.Internal.HashTable__uint___ElementDesc m_elements;
    public ACBindings.Internal.PStringBase__sbyte m_strElementHeader;
    public ACBindings.Internal.PStringBase__sbyte m_strElementWHeader;
    public ACBindings.Internal.PStringBase__sbyte m_strStateHeader;
    public ACBindings.Internal.PStringBase__sbyte m_strStateWHeader;

    // Generated Constructor
    public LayoutDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates and constructs a new LayoutDesc instance, returning it as a DBObj pointer.
    /// <code>Offset: 0x00459340
    /// DBObj* __cdecl LayoutDesc::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly allocated LayoutDesc (DBObj), or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00459340)();

    /// <summary>Retrieves the database object type identifier for this LayoutDesc instance.
    /// <code>Offset: 0x00459360
    /// unsigned int __thiscall LayoutDesc::GetDBOType(LayoutDesc*)</code>
    /// </summary>
    /// <returns>The numeric ID of the LayoutDesc DBO type, which is always 35.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, uint>)0x00459360)(ref this);

    /// <summary>Collects all qualified data identifiers associated with a layout's elements and inserts them into the supplied array, processing nested elements as necessary.
    /// <code>Offset: 0x0069A7A0
    /// void __thiscall LayoutDesc::GetSubDataIDs(LayoutDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">Container that receives the collected QualifiedDataID values.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0069A7A0)(ref this, id_array);

    /// <summary>Retrieves the ElementDesc associated with the specified element ID from the layout's element collection.
    /// <code>Offset: 0x0069A850
    /// ElementDesc* __thiscall LayoutDesc::AccessElementDesc(LayoutDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="elementID">The unique identifier of the desired element within the layout.</param>
    /// <returns>A pointer to the matching ElementDesc, or null if no element exists for that ID.</returns>
    public ACBindings.Internal.ElementDesc* AccessElementDesc(uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, uint, ACBindings.Internal.ElementDesc*>)0x0069A850)(ref this, elementID);

    /// <summary>Clears a LayoutDesc instance by resetting dimensions, removing all stored elements, and releasing internal string buffers.
    /// <code>Offset: 0x0069AD50
    /// void __thiscall LayoutDesc::Destroy(LayoutDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, void>)0x0069AD50)(ref this);

    /// <summary>Initializes a new LayoutDesc instance, resetting display dimensions to zero, creating an empty hash table for elements, and setting up reference‑counted header strings with default values.
    /// <code>Offset: 0x0069B060
    /// void __thiscall LayoutDesc::LayoutDesc(LayoutDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, void>)0x0069B060)(ref this);

    /// <summary>Destroys a LayoutDesc instance, freeing header strings and element data before delegating to the DBObj destructor.
    /// <code>Offset: 0x0069B0F0
    /// void __thiscall LayoutDesc::~LayoutDesc(LayoutDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, void>)0x0069B0F0)(ref this);

    /// <summary>Serializes layout dimensions and element table to the given archive, populating fields from the stream when loading.
    /// <code>Offset: 0x0069B370
    /// void __thiscall LayoutDesc::Serialize(LayoutDesc*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayoutDesc, ACBindings.Internal.Archive*, void>)0x0069B370)(ref this, io_archive);

    /// <summary>Recursively resolves an ElementDesc from a LayoutDesc, filling the supplied descriptor with all inherited data while preventing infinite loops.
    /// <code>Offset: 0x0069B400
    /// bool __cdecl LayoutDesc::InqFullDesc(ElementDesc*,ElementDesc*,int*)</code>
    /// </summary>
    /// <param name="rhs">The source element descriptor whose full definition is requested.</param>
    /// <param name="a2">The destination descriptor that will receive the resolved description.</param>
    /// <param name="a3">A list of visited element identifiers used to avoid circular references during recursion.</param>
    /// <returns>True if the full description was successfully obtained; otherwise false.</returns>
    public static byte InqFullDesc(ACBindings.Internal.ElementDesc* rhs, ACBindings.Internal.ElementDesc* a2, int* a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ElementDesc*, ACBindings.Internal.ElementDesc*, int*, byte>)0x0069B400)(rhs, a2, a3);
}

