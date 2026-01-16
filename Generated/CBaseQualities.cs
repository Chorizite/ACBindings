namespace ACBindings.Internal;


/// <summary>Maintains a collection of typed statistics for an object, storing integer, 64‑bit, boolean, floating‑point, string, data ID, instance ID, and positional values within separate hash tables.</summary>
public unsafe struct CBaseQualities : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for CBaseQualities, exposing operations to query and modify enchantments, movement characteristics, and to pack/unpack quality data.</summary>
    public unsafe struct CBaseQualities_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, void> CBaseQualities_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, uint, int*, int, int> EnchantInt; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, uint, double*, int> EnchantFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, uint, ACBindings.Internal.EnchantedQualityDetails*, int> GetFloatEnchantmentDetails; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float*, int> InqRunRate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float*, int> InqMaxRunRate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float, float*, int> InqJumpVelocity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float, int> CanJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, float, int*, int> JumpStaminaCost; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CBaseQualities*, sbyte*, uint, int> InqWeenieTypeString; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint _weenie_type;
    public System.IntPtr _intStatsTable;
    public System.IntPtr _int64StatsTable;
    public System.IntPtr _boolStatsTable;
    public System.IntPtr _floatStatsTable;
    public System.IntPtr _strStatsTable;
    public System.IntPtr _didStatsTable;
    public System.IntPtr _iidStatsTable;
    public System.IntPtr _posStatsTable;

    // Generated Constructor
    public CBaseQualities(int a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves an integer quality for a specified stat type, optionally applying enchantments to the base value.
    /// <code>Offset: 0x00590C20
    /// int __thiscall CBaseQualities::InqInt(CBaseQualities*,unsigned int,int*,int,int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the stat type to query.</param>
    /// <param name="retval">Pointer that receives the retrieved integer value.</param>
    /// <param name="raw">If zero, applies any enchants via EnchantInt; otherwise returns the raw base value unchanged.</param>
    /// <param name="allow_negative">When applying enchantments, indicates whether negative values are permitted.</param>
    /// <returns>Non-zero (1) if the stat was found and written to retval; zero if no matching stat exists or the table is absent.</returns>
    public int InqInt(uint stype, int* retval, int raw, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int*, int, int, int>)0x00590C20)(ref this, stype, retval, raw, allow_negative);

    /// <summary>Retrieves a 64‑bit statistic identified by stype and writes it into retval; returns success status.
    /// <code>Offset: 0x00590C70
    /// int __thiscall CBaseQualities::InqInt64(CBaseQualities*,unsigned int,__int64*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the statistic to query.</param>
    /// <param name="retval">Pointer where the retrieved 64‑bit value is stored.</param>
    /// <returns>Non‑zero if the statistic was found, zero otherwise.</returns>
    public int InqInt64(uint stype, long* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, long*, int>)0x00590C70)(ref this, stype, retval);

    /// <summary>Retrieves a boolean attribute identified by stype from the object's bool stats table and stores it in retval.
    /// <code>Offset: 0x00590CA0
    /// int __thiscall CBaseQualities::InqBool(CBaseQualities*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the desired boolean stat.</param>
    /// <param name="retval">Receives the attribute value if found.</param>
    /// <returns>1 if the attribute was present; 0 otherwise.</returns>
    public int InqBool(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int*, int>)0x00590CA0)(ref this, stype, retval);

    /// <summary>Retrieves the float value for the specified stat type, optionally applying enchantment modifiers before returning it.
    /// <code>Offset: 0x00590CD0
    /// int __thiscall CBaseQualities::InqFloat(CBaseQualities*,unsigned int,long double*,int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the desired statistic.</param>
    /// <param name="retval">Pointer to a long double where the retrieved (or enchanted) value is stored.</param>
    /// <param name="raw">If zero, applies any applicable enchantments; if non‑zero, returns the raw value unchanged.</param>
    /// <returns>Non‑zero when the stat exists and its value was written to *retval; otherwise zero.</returns>
    public int InqFloat(uint stype, double* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, double*, int, int>)0x00590CD0)(ref this, stype, retval, raw);

    /// <summary>Retrieves the data identifier corresponding to the supplied key and writes it into the provided location.
    /// <code>Offset: 0x00590D20
    /// int __thiscall CBaseQualities::InqDataID(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The lookup key for the desired data ID.</param>
    /// <param name="a3">Pointer to store the retrieved data ID if found.</param>
    /// <returns>Non‑zero on success, zero when the key is not present or the internal table is missing.</returns>
    public int InqDataID(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, int, int*, int>)0x00590D20)(ref this, a2, a3);

    /// <summary>Queries the instance ID table for a given type identifier and writes the associated instance ID to an output parameter.
    /// <code>Offset: 0x00590D50
    /// int __thiscall CBaseQualities::InqInstanceID(CBaseQualities*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="stype">The identifier of the type whose instance ID is requested.</param>
    /// <param name="retval">Receives the found instance ID when the lookup succeeds.</param>
    /// <returns>1 if the instance ID was successfully retrieved; 0 if the table is missing or the type identifier is not present.</returns>
    public int InqInstanceID(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, uint*, int>)0x00590D50)(ref this, stype, retval);

    /// <summary>Retrieves the Position corresponding to a specified statistic type.
    /// <code>Offset: 0x00590D80
    /// int __thiscall CBaseQualities::InqPosition(CBaseQualities*,unsigned int,Position*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the desired position statistic.</param>
    /// <param name="retval">Structure populated with object cell ID and frame data upon success.</param>
    /// <returns>Non-zero if the position was found; zero otherwise.</returns>
    public int InqPosition(uint stype, ACBindings.Internal.Position* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, ACBindings.Internal.Position*, int>)0x00590D80)(ref this, stype, retval);

    /// <summary>Removes an integer statistic identified by <paramref name="stype"/> from this object's integer statistics table, returning a status code.
    /// <code>Offset: 0x00591400
    /// int __thiscall CBaseQualities::RemoveInt(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the integer statistic to remove.</param>
    /// <returns>Zero if no integer statistics table exists or removal fails; otherwise a non‑zero value indicating success.</returns>
    public int RemoveInt(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591400)(ref this, stype);

    /// <summary>Stores the supplied value for the integer stat identified by <paramref name="stype"/> within the object's statistics table, creating the table on first use.
    /// <code>Offset: 0x00591430
    /// int __thiscall CBaseQualities::SetInt(CBaseQualities*,unsigned int,const int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the integer stat to modify.</param>
    /// <param name="val">New value for the specified stat.</param>
    /// <returns>Non‑zero if the operation succeeded; zero if allocation failed or an error occurred.</returns>
    public int SetInt(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int, int>)0x00591430)(ref this, stype, val);

    /// <summary>Removes the specified 64‑bit statistic identified by stype from the object's statistics table.
    /// <code>Offset: 0x00591500
    /// int __thiscall CBaseQualities::RemoveInt64(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the stat to remove.</param>
    /// <returns>1 if the stat was found and removed; otherwise 0.</returns>
    public int RemoveInt64(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591500)(ref this, stype);

    /// <summary>
    /// Sets or updates a 64‑bit integer stat identified by <c>stype</c>. Ensures the internal hash table for int64 stats exists, then inserts the value if absent or replaces the existing entry. Returns non‑zero on success, zero on allocation failure.
    /// 
    /// <code>Offset: 0x00591530
    /// int __thiscall CBaseQualities::SetInt64(CBaseQualities*,unsigned int,const __int64)</code>
    /// </summary>
    /// <param name="stype">The identifier of the statistic to set.</param>
    /// <param name="val">The 64‑bit integer value to associate with the given stat type.</param>
    /// <returns>Non‑zero if the operation succeeded; zero if memory could not be allocated for the stats table.</returns>
    public int SetInt64(uint stype, long val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, long, int>)0x00591530)(ref this, stype, val);

    /// <summary>Removes the boolean stat identified by stype from this object's bool stats table.
    /// <code>Offset: 0x00591610
    /// int __thiscall CBaseQualities::RemoveBool(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier of the boolean stat to remove.</param>
    /// <returns>Non‑zero if removal succeeded; zero otherwise (including when there is no bool stats table).</returns>
    public int RemoveBool(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591610)(ref this, stype);

    /// <summary>Sets a boolean statistic identified by the supplied stat type to the specified value, creating the internal hash table if necessary.
    /// <code>Offset: 0x00591640
    /// int __thiscall CBaseQualities::SetBool(CBaseQualities*,unsigned int,const int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the statistic to set.</param>
    /// <param name="val">The integer value representing the new state for the statistic (typically 0 or 1).</param>
    /// <returns>Non‑zero on success; zero if memory allocation failed or the operation could not be performed.</returns>
    public int SetBool(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int, int>)0x00591640)(ref this, stype, val);

    /// <summary>Removes a float statistic identified by the given type from the object’s statistics table if present.
    /// <code>Offset: 0x00591710
    /// int __thiscall CBaseQualities::RemoveFloat(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the float stat to remove.</param>
    /// <returns>An integer indicating success (non‑zero) or failure (0).</returns>
    public int RemoveFloat(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00591710)(ref this, stype);

    /// <summary>Stores or updates a floating‑point statistic for the object, creating the float statistics table if necessary.
    /// <code>Offset: 0x00591740
    /// int __thiscall CBaseQualities::SetFloat(CBaseQualities*,unsigned int,const long double)</code>
    /// </summary>
    /// <param name="stype">Identifier of the statistic to set.</param>
    /// <param name="val">Value to associate with that statistic.</param>
    /// <returns>Non‑zero if the operation succeeds; zero if allocation fails or insertion cannot be performed.</returns>
    public int SetFloat(uint stype, double val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, double, int>)0x00591740)(ref this, stype, val);

    /// <summary>Assigns or updates the integer value associated with a specified data ID in the object's internal hash table, creating the table on first use.
    /// <code>Offset: 0x00591820
    /// int __thiscall CBaseQualities::SetDataID(_DWORD*,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">The unsigned integer key representing the data ID.</param>
    /// <param name="a3">The integer value to associate with the given data ID.</param>
    /// <returns>Non‑zero if the operation succeeds; zero if the internal hash table cannot be allocated.</returns>
    public int SetDataID(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int, int>)0x00591820)(ref this, a2, a3);

    /// <summary>Removes the specified instance identifier from the object's IID statistics table, if present.
    /// <code>Offset: 0x005918F0
    /// int __thiscall CBaseQualities::RemoveInstanceID(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the instance to remove.</param>
    /// <returns>Non‑zero if an entry was found and deleted; zero otherwise.</returns>
    public int RemoveInstanceID(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x005918F0)(ref this, stype);

    /// <summary>Stores or updates an instance identifier in the object's internal table, creating the table if necessary.
    /// <code>Offset: 0x00591920
    /// int __thiscall CBaseQualities::SetInstanceID(CBaseQualities*,unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="stype">Identifier key for the instance ID.</param>
    /// <param name="val">Value to associate with the given key.</param>
    /// <returns>Non‑zero on success; zero indicates allocation failure or insertion error.</returns>
    public int SetInstanceID(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, uint, int>)0x00591920)(ref this, stype, val);

    /// <summary>Retrieves a string statistic by its identifier from the object's string table, updating an output reference and managing reference counts accordingly.
    /// <code>Offset: 0x005919F0
    /// int __thiscall CBaseQualities::InqString(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Identifier of the desired string statistic.</param>
    /// <param name="a3">Pointer that will receive the retrieved string object; if it previously referenced another string, that reference is released.</param>
    /// <returns>Non‑zero when the identifier exists in the table, zero otherwise.</returns>
    public int InqString(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, int, int*, int>)0x005919F0)(ref this, a2, a3);

    /// <summary>Sets the value of a string property identified by key within this object's statistics table.
    /// <code>Offset: 0x00591CC0
    /// int __thiscall CBaseQualities::SetString(_DWORD*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="a2">The unique identifier for the string property to set.</param>
    /// <param name="a3">Pointer to the string data to associate with the key.</param>
    /// <returns>Non‑zero on success; zero if allocation failed or the addition could not be performed.</returns>
    public int SetString(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int*, int>)0x00591CC0)(ref this, a2, a3);

    /// <summary>Stores or updates a positional statistic identified by stype in the object's position statistics table.
    /// <code>Offset: 0x00591DA0
    /// int __thiscall CBaseQualities::SetPosition(CBaseQualities*,unsigned int,const Position*)</code>
    /// </summary>
    /// <param name="stype">Identifier of the stat type to set.</param>
    /// <param name="val">Pointer to a Position structure containing the new cell ID and frame data.</param>
    /// <returns>Non‑zero if the operation succeeds; zero on failure (e.g., memory allocation or hash table insertion fails).</returns>
    public int SetPosition(uint stype, ACBindings.Internal.Position* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, ACBindings.Internal.Position*, int>)0x00591DA0)(ref this, stype, val);

    /// <summary>Removes a data identifier from the object's data ID table if present.
    /// <code>Offset: 0x00592220
    /// int __thiscall CBaseQualities::RemoveDataID(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The unsigned integer representing the data identifier to remove.</param>
    /// <returns>Non‑zero when the identifier was successfully removed; zero otherwise.</returns>
    public int RemoveDataID(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00592220)(ref this, stype);

    /// <summary>Removes the position entry identified by the specified type from the object's position statistics table.
    /// <code>Offset: 0x00592250
    /// int __thiscall CBaseQualities::RemovePosition(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The unique identifier of the position to remove.</param>
    /// <returns>An integer; non‑zero if a position was removed, zero otherwise.</returns>
    public int RemovePosition(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x00592250)(ref this, stype);

    /// <summary>Removes a string entry from the object's string statistics table identified by the supplied type index, handling reference counting and cleanup.
    /// <code>Offset: 0x005925F0
    /// int __thiscall CBaseQualities::RemoveString(CBaseQualities*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">The identifier of the string to remove from the statistics table.</param>
    /// <returns>An integer indicating the removal result: non‑zero if the string was successfully removed; zero otherwise.</returns>
    public int RemoveString(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint, int>)0x005925F0)(ref this, stype);

    /// <summary>Updates a bitmask to indicate which statistic tables are present in the object.
    /// <code>Offset: 0x00596BD0
    /// void __thiscall CBaseQualities::SetPackHeader(CBaseQualities*,unsigned int*)</code>
    /// </summary>
    /// <param name="bitfield">Pointer to an unsigned integer that receives flag bits for each non‑null stats table (e.g., 1 for int, 2 for bool, 4 for float, 8 for did, 0x10 for string, 0x20 for position, 0x40 for iid, 0x80 for int64).</param>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint*, void>)0x00596BD0)(ref this, bitfield);

    /// <summary>Calculates the total packed size of an object’s statistics by summing the contributions from all available stat tables (int, int64, bool, float, string, did, iid, and position). The returned value indicates how many bytes are required to serialize or pack these stats.
    /// <code>Offset: 0x00596C30
    /// unsigned int __thiscall CBaseQualities::GetPackSize(CBaseQualities*)</code>
    /// </summary>
    /// <returns>The total packed size in bytes for the object's statistics.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, uint>)0x00596C30)(ref this);

    /// <summary>Initializes a new CBaseQualities object by setting its virtual table pointer and clearing all statistic tables.
    /// <code>Offset: 0x00596D00
    /// void*** __thiscall CBaseQualities::CBaseQualities(void***,int)</code>
    /// </summary>
    /// <param name="a2">Optional construction parameter, currently unused.</param>
    /// <returns>The initialized instance of CBaseQualities.</returns>
    public void*** _ConstructorInternal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, int, void***>)0x00596D00)(ref this, a2);

    /// <summary>Destroys a CBaseQualities instance by releasing all associated statistic tables and resetting its virtual function table.
    /// <code>Offset: 0x00596D30
    /// void __thiscall CBaseQualities::~CBaseQualities(CBaseQualities*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, void>)0x00596D30)(ref this);

    /// <summary>Packs the base qualities object into a contiguous memory block, writing a header and serializing each non‑null stats table in order.
    /// <code>Offset: 0x00596D40
    /// unsigned int __thiscall CBaseQualities::Pack(CBaseQualities*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated to point after written data.</param>
    /// <param name="size">Maximum number of bytes available for packing; if insufficient, no data is written.</param>
    /// <returns>The total byte count required to serialize the object. This value is returned regardless of whether the provided buffer was large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, void**, uint, uint>)0x00596D40)(ref this, addr, size);

    /// <summary>Unpacks serialized quality data from the provided buffer into this object's internal statistic tables, setting the weenie type and allocating or clearing tables as needed based on flag bits.
    /// <code>Offset: 0x00596E10
    /// int __thiscall CBaseQualities::UnPack(CBaseQualities*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the packed data; advanced past each unpacked segment.</param>
    /// <param name="left">Number of bytes remaining in the buffer that may be read during this operation.</param>
    /// <returns>Non‑zero if all required data was successfully unpacked and verified; zero indicates failure or insufficient data.</returns>
    public int UnPack(void** addr, uint left) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CBaseQualities, void**, uint, int>)0x00596E10)(ref this, addr, left);
}

