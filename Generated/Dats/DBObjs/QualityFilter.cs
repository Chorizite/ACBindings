namespace ACBindings.Internal;


/// <summary>
/// Holds per‑statistic filter flags used in quality evaluation, supporting integer, 64‑bit integer, boolean, float, string, data ID, interface ID and position types. Provides packing/unpacking of enabled filters for persistence or transmission and manages dynamic allocation and cleanup of the underlying arrays.
/// </summary>
public unsafe struct QualityFilter : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct QualityFilter_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, void> Clear; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumIntStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumInt64Stats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumBoolStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumFloatStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumDIDStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumIIDStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumStringStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumPositionStats; // function pointer

        // Methods
    }

    // Members
    public int* _int_stat_filter;
    public int* _int64_stat_filter;
    public int* _bool_stat_filter;
    public int* _float_stat_filter;
    public int* _string_stat_filter;
    public int* _did_stat_filter;
    public int* _iid_stat_filter;
    public int* _position_stat_filter;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all dynamically allocated filter arrays associated with the QualityFilter instance, freeing memory for each stat type and resetting pointers to null.
    /// <code>Offset: 0x006B2D90
    /// void __thiscall QualityFilter::Clear(QualityFilter*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void>)0x006B2D90)(ref this);

    /// <summary>Retrieves an integer statistic from the filter array by index if it exists; otherwise returns zero.
    /// <code>Offset: 0x006B2E40
    /// int __thiscall QualityFilter::QueryInt(QualityFilter*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Index of the statistic to query.</param>
    /// <returns>The value of the requested statistic, or 0 when unavailable.</returns>
    public int QueryInt(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint, int>)0x006B2E40)(ref this, stype);

    /// <summary>Assigns an integer value to the specified stat type within the quality filter, allocating the underlying array on first use.
    /// <code>Offset: 0x006B2E70
    /// int __thiscall QualityFilter::SetInt(QualityFilter*,unsigned int,const int)</code>
    /// </summary>
    /// <param name="stype">Index of the statistic type to set.</param>
    /// <param name="val">Integer value to store at that index.</param>
    /// <returns>Non‑zero if the assignment succeeds; zero when the requested index exceeds the filter capacity or memory allocation fails.</returns>
    public int SetInt(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint, int, int>)0x006B2E70)(ref this, stype, val);

    /// <summary>Retrieves the filter value for a specified statistic type if available.
    /// <code>Offset: 0x006B2EE0
    /// int __thiscall QualityFilter::QueryFloat(QualityFilter*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Index of the statistic to query.</param>
    /// <returns>The integer filter value corresponding to the provided statistic index, or 0 if no such filter exists.</returns>
    public int QueryFloat(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint, int>)0x006B2EE0)(ref this, stype);

    /// <summary>Calculates the byte size necessary to pack active statistics for a QualityFilter instance, updating supplied counters with how many stats are present for each data type.
    /// <code>Offset: 0x006B2F20
    /// unsigned int __thiscall QualityFilter::pack_size(QualityFilter*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="num_ints">Number of enabled integer statistics.</param>
    /// <param name="num_int64s">Number of enabled 64‑bit integer statistics.</param>
    /// <param name="num_bools">Number of enabled boolean statistics.</param>
    /// <param name="num_floats">Number of enabled floating‑point statistics.</param>
    /// <param name="num_dids">Number of enabled data ID statistics.</param>
    /// <param name="num_iids">Number of enabled interface ID statistics.</param>
    /// <param name="num_strings">Number of enabled string statistics.</param>
    /// <param name="num_positions">Number of enabled position statistics.</param>
    /// <returns>The total number of bytes required to serialize the filter's active statistics.</returns>
    public uint pack_size(uint* num_ints, uint* num_int64s, uint* num_bools, uint* num_floats, uint* num_dids, uint* num_iids, uint* num_strings, uint* num_positions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint>)0x006B2F20)(ref this, num_ints, num_int64s, num_bools, num_floats, num_dids, num_iids, num_strings, num_positions);

    /// <summary>Destroys a QualityFilter instance, resetting virtual tables, clearing internal filter state, and invoking base class destructors.
    /// <code>Offset: 0x006B31D0
    /// void __thiscall QualityFilter::~QualityFilter(QualityFilter*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void>)0x006B31D0)(ref this);

    /// <summary>Serializes the QualityFilter state into a contiguous memory block, returning the required byte count. If the supplied buffer is large enough, writes type counts followed by indices of active filter entries.
    /// <code>Offset: 0x006B3200
    /// unsigned int __thiscall QualityFilter::Pack(QualityFilter*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; will be advanced past written data.</param>
    /// <param name="size">Size in bytes of the buffer pointed to by addr.</param>
    /// <returns>Number of bytes needed to represent the packed QualityFilter data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void**, uint, uint>)0x006B3200)(ref this, addr, size);

    /// <summary>Unpacks serialized filter indices into QualityFilter's internal arrays, allocating storage as required and advancing the data pointer.
    /// <code>Offset: 0x006B3490
    /// int __thiscall QualityFilter::UnPack(QualityFilter*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer that refers to the start of the serialized buffer; after unpacking it points past the processed data.</param>
    /// <param name="size">Size in bytes of the buffer referenced by *addr; must be at least 28 bytes for the header information.</param>
    /// <returns>True if all data was consumed without exceeding size, otherwise false.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void**, uint, int>)0x006B3490)(ref this, addr, size);
}

