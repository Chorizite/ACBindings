namespace ACBindings.Internal;


/// <summary>Holds restriction mapping information, including bitmask flags and monarch identifier, for efficient lookup via a hash table.</summary>
public unsafe struct RestrictionDB : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct RestrictionDB_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, void> RestrictionDB_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RestrictionDB*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _bitmask;
    public uint _monarch_iid;
    public ACBindings.Internal.PHashTable__uint__uint _table;

    // Generated Constructor
    public RestrictionDB() {
        _ConstructorInternal();
    }
    public RestrictionDB(ACBindings.Internal.RestrictionDB* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Sets or clears the open‑house flag within the restriction database's bitmask.
    /// <code>Offset: 0x005AF3C0
    /// void __thiscall RestrictionDB::SetOpenHouse(RestrictionDB*,int)</code>
    /// </summary>
    /// <param name="open">Non‑zero to enable, zero to disable the open‑house restriction.</param>
    public void SetOpenHouse(int open) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, int, void>)0x005AF3C0)(ref this, open);

    /// <summary>Serializes a RestrictionDB instance into a binary stream, writing its type identifier, bitmask, monarch IID, and delegating packing of the underlying table to its base class.
    /// <code>Offset: 0x005AF3E0
    /// unsigned int __thiscall RestrictionDB::Pack(RestrictionDB*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the destination buffer; advanced as data is written.</param>
    /// <param name="size">Maximum number of bytes remaining in the buffer; if insufficient, no data is written.</param>
    /// <returns>The total number of bytes required to pack this RestrictionDB object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void**, uint, uint>)0x005AF3E0)(ref this, addr, size);

    /// <summary>Determines whether a guest is permitted by the restriction database, applying bitmask rules and optional monarch matching.
    /// <code>Offset: 0x005AF9A0
    /// int __thiscall RestrictionDB::IsAllowedIn(RestrictionDB*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="guest">Identifier of the potential guest.</param>
    /// <param name="monarch">Identifier of the current monarch used for comparison with the stored monarch ID.</param>
    /// <returns>Non‑zero if the guest satisfies all restrictions; zero otherwise.</returns>
    public int IsAllowedIn(uint guest, uint monarch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, uint, uint, int>)0x005AF9A0)(ref this, guest, monarch);

    /// <summary>Unpacks serialized restriction data from the supplied buffer, initializing the object's bitmask, monarch ID and hash table fields.
    /// <code>Offset: 0x005AFA40
    /// int __thiscall RestrictionDB::UnPack(RestrictionDB*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that references the start of the packed data; the method advances this pointer past the bytes it consumes.</param>
    /// <param name="size">Number of bytes remaining in the buffer pointed to by *addr; must be large enough for the expected format.</param>
    /// <returns>Non‑zero if the unpacking succeeds, zero on failure (e.g., insufficient data or corrupted format).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void**, uint, int>)0x005AFA40)(ref this, addr, size);

    /// <summary>Initializes a RestrictionDB instance by setting up its vtable pointers, resetting bitmask and monarch ID to zero, and constructing the underlying hash table with appropriate defaults.
    /// <code>Offset: 0x005AFF60
    /// void __thiscall RestrictionDB::RestrictionDB(RestrictionDB*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void>)0x005AFF60)(ref this);

    /// <summary>Destroys a RestrictionDB instance, releasing all allocated hash table entries and resetting internal structures to a clean state.
    /// <code>Offset: 0x005AFFE0
    /// void __thiscall RestrictionDB::~RestrictionDB(RestrictionDB*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, void>)0x005AFFE0)(ref this);

    /// <summary>Initializes a RestrictionDB object by copying restriction data and table entries from an existing instance.
    /// <code>Offset: 0x005B0060
    /// void __thiscall RestrictionDB::RestrictionDB(RestrictionDB*,const RestrictionDB*)</code>
    /// </summary>
    /// <param name="rhs">The RestrictionDB instance whose data will be copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.RestrictionDB* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RestrictionDB, ACBindings.Internal.RestrictionDB*, void>)0x005B0060)(ref this, rhs);
}

