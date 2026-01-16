namespace ACBindings.Internal;


/// <summary>Holds a collection of qualified data identifiers mapped to their corresponding database object save information, enabling efficient lookup and bracketed iteration.</summary>
public unsafe struct QualifiedDataIDArray : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashTable___QualifiedDataID___DBObjSaveInfo_ptr BaseClass_IntrusiveHashTable; // ACBindings.Internal.IntrusiveHashTable___QualifiedDataID___DBObjSaveInfo_ptr

    // Child Types
    public unsafe struct QualifiedDataIDArray_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualifiedDataIDArray*, void> QualifiedDataIDArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashIterator___QualifiedDataID___DBObjSaveInfo_ptr m_CurBracketIterator;
    public uint m_LastBracketIndex;

    // Generated Constructor
    public QualifiedDataIDArray(int nRequestStartSize) {
        _ConstructorInternal(nRequestStartSize);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Constructs a hash table container for QualifiedDataID objects with the specified initial bucket count and initializes iteration state.
    /// <code>Offset: 0x004149F0
    /// void __thiscall QualifiedDataIDArray::QualifiedDataIDArray(QualifiedDataIDArray*,int)</code>
    /// </summary>
    /// <param name="nRequestStartSize">Desired starting number of buckets for the hash table.</param>
    public void _ConstructorInternal(int nRequestStartSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, int, void>)0x004149F0)(ref this, nRequestStartSize);

    /// <summary>Positions m_CurBracketIterator to reference the element located at position idx in the array’s internal hash table. This operation performs a linear traversal and may be expensive, hence the method name.
    /// <code>Offset: 0x0041A2A0
    /// void __thiscall QualifiedDataIDArray::ExpensiveUpdateIterator(QualifiedDataIDArray*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The QualifiedDataIDArray instance whose iterator is being updated.</param>
    /// <param name="idx">Zero‑based index of the desired element within the hash table; if larger than the number of elements, the iterator ends at the last entry.</param>
    public void ExpensiveUpdateIterator(uint idx) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, uint, void>)0x0041A2A0)(ref this, idx);

    /// <summary>Releases all resources used by the QualifiedDataIDArray, clearing its hash table contents and freeing any dynamically allocated bucket storage.
    /// <code>Offset: 0x0041A410
    /// void __thiscall QualifiedDataIDArray::~QualifiedDataIDArray(QualifiedDataIDArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, void>)0x0041A410)(ref this);

    /// <summary>Adopts a DBObjSaveInfo into the array, inserting it when new or merging subdata flags if an entry already exists; deletes the passed object if merged. Resets internal iterator on successful adoption.
    /// <code>Offset: 0x0041A450
    /// bool __thiscall QualifiedDataIDArray::AdoptDBObjSaveInfo(QualifiedDataIDArray*,DBObjSaveInfo*)</code>
    /// </summary>
    /// <param name="i_pHashData">The DBObjSaveInfo to be added or merged into the array.</param>
    /// <returns>True if the array was modified (insertion or flag merge); otherwise false.</returns>
    public byte AdoptDBObjSaveInfo(ACBindings.Internal.DBObjSaveInfo* i_pHashData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, ACBindings.Internal.DBObjSaveInfo*, byte>)0x0041A450)(ref this, i_pHashData);

    /// <summary>Adds a QualifiedDataID to the collection or updates its sub‑data ID flags if it already exists.
    /// <code>Offset: 0x0041A4E0
    /// bool __thiscall QualifiedDataIDArray::AddQDID(QualifiedDataIDArray*,const QualifiedDataID*,unsigned int)</code>
    /// </summary>
    /// <param name="i_data">The data identifier to insert or modify.</param>
    /// <param name="i_dwSubDataIDFlags">Bitmask of sub‑data ID flags associated with the entry.</param>
    /// <returns>True when a new entry is added or existing flags are changed; false if the provided ID is invalid, memory allocation fails, or no flag modification occurs.</returns>
    public byte AddQDID(ACBindings.Internal.QualifiedDataID* i_data, uint i_dwSubDataIDFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, ACBindings.Internal.QualifiedDataID*, uint, byte>)0x0041A4E0)(ref this, i_data, i_dwSubDataIDFlags);

    /// <summary>Copies qualified data IDs from a source array into this QualifiedDataIDArray and returns true if any were added.
    /// <code>Offset: 0x0041A590
    /// char __thiscall QualifiedDataIDArray::CopyDIDs(QualifiedDataIDArray*,_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer array where the third element specifies the count of IDs and the first element points to the ID values.</param>
    /// <param name="i_dwSubDataIDFlags">Flags applied when adding each data ID.</param>
    /// <returns>Non‑zero if at least one ID was added successfully; zero otherwise.</returns>
    public sbyte CopyDIDs(int* a2, uint i_dwSubDataIDFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, int*, uint, sbyte>)0x0041A590)(ref this, a2, i_dwSubDataIDFlags);

    /// <summary>Adds a qualified data identifier into the array using the specified integer index and optional sub‑data flags.
    /// <code>Offset: 0x0041AAA0
    /// bool __thiscall QualifiedDataIDArray::AddDID(QualifiedDataIDArray*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The primary identifier used to construct the QualifiedDataID.</param>
    /// <param name="i_dwSubDataIDFlags">Bitmask of flags that modify the behavior of the addition.</param>
    /// <returns>True if the QualifiedDataID was successfully added; otherwise, false.</returns>
    public byte AddDID(int a2, uint i_dwSubDataIDFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataIDArray, int, uint, byte>)0x0041AAA0)(ref this, a2, i_dwSubDataIDFlags);
}

