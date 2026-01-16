namespace ACBindings.Internal;


/// <summary>Represents a player's collection of character identities, tracking existing, deleted, and account-related data including status, limits, and feature flags.</summary>
public unsafe struct CharacterSet : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.StrHashData BaseClass_StrHashData; // ACBindings.Internal.StrHashData

    // Child Types
    public unsafe struct CharacterSet_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, void> CharacterSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CharacterSet*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___CharacterIdentity set_;
    public ACBindings.Internal.AC1Legacy.SmartArray___CharacterIdentity delSet_;
    public uint status_;
    public int numAllowedCharacters_;
    public ACBindings.Internal.accountID account_;
    public int m_fUseTurbineChat;
    public int m_fHasThroneofDestiny;

    // Generated Constructor
    public CharacterSet() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new character set with default values, creating empty character lists and setting up account information for a fresh instance.
    /// <code>Offset: 0x00479D30
    /// void __thiscall CharacterSet::CharacterSet(CharacterSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void>)0x00479D30)(ref this);

    /// <summary>Deallocates the CharacterSet, freeing its character identity arrays and decrementing the reference count of the linked account object.
    /// <code>Offset: 0x00479D80
    /// void __thiscall CharacterSet::~CharacterSet(CharacterSet*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void>)0x00479D80)(ref this);

    /// <summary>Retrieves a character identity by index from the set, returning null when the index is invalid or the identity’s GID is zero.
    /// <code>Offset: 0x004E8B20
    /// CharacterIdentity* __thiscall CharacterSet::GetIdentity(CharacterSet*,int)</code>
    /// </summary>
    /// <param name="indexSigned">The zero‑based index of the desired character identity within the set.</param>
    /// <returns>A pointer to the requested CharacterIdentity, or nullptr if the index exceeds the set size or the identity has a zero GID.</returns>
    public ACBindings.Internal.CharacterIdentity* GetIdentity(int indexSigned) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, ACBindings.Internal.CharacterIdentity*>)0x004E8B20)(ref this, indexSigned);

    /// <summary>Removes a character identity from the set by index, shifting subsequent identities to close the gap.
    /// <code>Offset: 0x004FE960
    /// void __thiscall CharacterSet::ClearIdentity(CharacterSet*,int)</code>
    /// </summary>
    /// <param name="slot">The zero‑based index of the identity to delete; if outside the valid range, the call has no effect.</param>
    public void ClearIdentity(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, void>)0x004FE960)(ref this, slot);

    /// <summary>Returns the name of the character identity at the specified index within the set, if that entry exists and has a valid ID; otherwise returns nullptr.
    /// <code>Offset: 0x004FE980
    /// const char* __thiscall CharacterSet::GetName(CharacterSet*,int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position in the internal character identity array.</param>
    /// <returns>A pointer to the character’s name string or null when the index is out of range or the entry lacks a valid ID.</returns>
    public sbyte* GetName(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, sbyte*>)0x004FE980)(ref this, index);

    /// <summary>Retrieves the global ID of the character located at a given index within the set.
    /// <code>Offset: 0x004FE9B0
    /// unsigned int __thiscall CharacterSet::GetGID(CharacterSet*,int)</code>
    /// </summary>
    /// <param name="slot">Zero‑based position in the internal character array.</param>
    /// <returns>The global identifier if the slot is valid and contains a character; otherwise 0.</returns>
    public uint GetGID(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, uint>)0x004FE9B0)(ref this, slot);

    /// <summary>Retrieves the zero‑based slot index of a character with the specified avatar ID within the set; returns –1 when the set is empty, the ID is not found, or the entry is invalid.
    /// <code>Offset: 0x004FE9E0
    /// int __thiscall CharacterSet::GetSlot(CharacterSet*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidAvatar">The avatar identifier to search for in the set.</param>
    /// <returns>-1 if the avatar is not present or the set contains no valid entries; otherwise, the index of the matching slot.</returns>
    public int GetSlot(uint i_iidAvatar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, uint, int>)0x004FE9E0)(ref this, i_iidAvatar);

    /// <summary>Retrieves the number of seconds a character at the specified slot remains greyed out, returning zero when the slot is invalid or empty.
    /// <code>Offset: 0x004FEA20
    /// unsigned int __thiscall CharacterSet::GetGreyedOutFor(CharacterSet*,int)</code>
    /// </summary>
    /// <param name="slot">Index of the character slot within the set.</param>
    /// <returns>The duration in seconds the character is greyed out, or 0 if the slot is out‑of‑range, disallowed by numAllowedCharacters_, or contains no character.</returns>
    public uint GetGreyedOutFor(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, int, uint>)0x004FEA20)(ref this, slot);

    /// <summary>Computes the size in bytes required to pack the character set, including added and removed characters, account data, and alignment padding.
    /// <code>Offset: 0x004FEC30
    /// unsigned int __thiscall CharacterSet::pack_size(CharacterSet*)</code>
    /// </summary>
    /// <returns>An unsigned integer indicating the number of bytes needed for serialization.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, uint>)0x004FEC30)(ref this);

    /// <summary>Packs the character set data into a binary buffer pointed to by addr, serializing status, sets of characters, deletion list, allowed count, account ID, and chat flags. Requires that size be at least the required pack size; otherwise no data is written.
    /// <code>Offset: 0x004FECE0
    /// unsigned int __thiscall CharacterSet::Pack(CharacterSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that will advance as bytes are written into the buffer.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>Number of bytes that would be written (the required pack size). If size is insufficient, returns the required size without writing any data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void**, uint, uint>)0x004FECE0)(ref this, addr, size);

    /// <summary>Deserializes a CharacterSet object from a binary stream, populating its status, character collections, and associated metadata.
    /// <code>Offset: 0x004FEDC0
    /// int __thiscall CharacterSet::UnPack(CharacterSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the buffer; advanced as fields are unpacked.</param>
    /// <param name="size">Maximum number of bytes that may be read from the buffer (used internally during string unpacking).</param>
    /// <returns>1 on success, indicating that all data was unpacked correctly.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, void**, uint, int>)0x004FEDC0)(ref this, addr, size);

    /// <summary>Adds a character identity to the set when absent, resizing storage automatically.
    /// <code>Offset: 0x004FEF70
    /// int __thiscall CharacterSet::AddIdentity(CharacterSet*,CharacterIdentity*)</code>
    /// </summary>
    /// <param name="toAdd">The character identity to insert.</param>
    /// <returns>Non-zero if the identity was inserted; zero if it already existed in the set.</returns>
    public int AddIdentity(ACBindings.Internal.CharacterIdentity* toAdd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharacterSet, ACBindings.Internal.CharacterIdentity*, int>)0x004FEF70)(ref this, toAdd);
}

