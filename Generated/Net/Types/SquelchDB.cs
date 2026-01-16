namespace ACBindings.Internal;


/// <summary>Maintains per‑account and per‑character squelch configurations, mapping account identifiers to hashes and character IDs to SquelchInfo objects for efficient lookup, with a global default configuration applied when no specific entry exists.</summary>
public unsafe struct SquelchDB : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SquelchDB_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, void> SquelchDB_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchDB*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable___AC1Legacy_PStringBase__sbyte__uint _account_hash;
    public ACBindings.Internal.PackableHashTable__uint___SquelchInfo _character_hash;
    public ACBindings.Internal.SquelchInfo _global_squelch_info;

    // Generated Constructor
    public SquelchDB() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Packs the account, character, and global squelch tables into a contiguous memory buffer.
    /// <code>Offset: 0x006B1B70
    /// unsigned int __thiscall SquelchDB::Pack(SquelchDB*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where packed data will be stored.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>Number of bytes required to pack the entire SquelchDB state; if size is sufficient, that many bytes are written into addr.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void**, uint, uint>)0x006B1B70)(ref this, addr, size);

    /// <summary>Determines whether a player is currently squelched for a specified message type by looking up their ID in the character hash table.
    /// <code>Offset: 0x006B1C00
    /// int __thiscall SquelchDB::IsPlayerSquelched(SquelchDB*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="player_iid">The unique identifier of the player to query.</param>
    /// <param name="msg_type">The message type to check against the player's squelch settings.</param>
    /// <returns>Non‑zero if the player is squelched for the given message type; otherwise zero.</returns>
    public int IsPlayerSquelched(uint player_iid, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, uint, uint, int>)0x006B1C00)(ref this, player_iid, msg_type);

    /// <summary>Determines whether a player is squelched for a specific message type, considering global, account‑level, and personal settings.
    /// <code>Offset: 0x006B2360
    /// BOOL __thiscall SquelchDB::IsSquelched(SquelchDB*,unsigned int,int*,unsigned int)</code>
    /// </summary>
    /// <param name="player_iid">Player identifier to check.</param>
    /// <param name="a3">Pointer used as the key when querying the account hash table; may represent an account string or identifier.</param>
    /// <param name="msg_type">Message type for which squelch status is evaluated.</param>
    /// <returns>True if the message should be suppressed for the player, otherwise false.</returns>
    public byte IsSquelched(uint player_iid, int* a3, uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, uint, int*, uint, byte>)0x006B2360)(ref this, player_iid, a3, msg_type);

    /// <summary>Clears all stored squelch information for accounts and characters, and resets the global squelch configuration.
    /// <code>Offset: 0x006B27B0
    /// void __thiscall SquelchDB::Clear(SquelchDB*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void>)0x006B27B0)(ref this);

    /// <summary>Restores the SquelchDB state from a serialized buffer, clearing existing data before unpacking account and character hash tables along with global squelch information.
    /// <code>Offset: 0x006B27D0
    /// int __thiscall SquelchDB::UnPack(SquelchDB*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer containing packed data.</param>
    /// <param name="size">Size in bytes of the packed data.</param>
    /// <returns>Non‑zero if all components were successfully unpacked; otherwise zero.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void**, uint, int>)0x006B27D0)(ref this, addr, size);

    /// <summary>Initializes a new SquelchDB instance, creating empty account and character hash tables and resetting the global squelch information to its default state.
    /// <code>Offset: 0x006B2A90
    /// void __thiscall SquelchDB::SquelchDB(SquelchDB*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void>)0x006B2A90)(ref this);

    /// <summary>Destroys a SquelchDB object by clearing its account and character hash tables, resetting the global squelch info, releasing any dynamically allocated resources, and restoring base-class virtual function pointers to their default state.
    /// <code>Offset: 0x006B2B10
    /// void __thiscall SquelchDB::~SquelchDB(SquelchDB*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchDB, void>)0x006B2B10)(ref this);
}

