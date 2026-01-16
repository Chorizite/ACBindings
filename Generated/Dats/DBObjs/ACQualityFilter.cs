namespace ACBindings.Internal;


/// <summary>
/// Specialized quality filter extending the base QualityFilter, storing integer attribute, secondary attribute and skill statistics to evaluate object quality during gameplay or database operations.
/// </summary>
public unsafe struct ACQualityFilter
{
    // Base Classes
    public ACBindings.Internal.QualityFilter BaseClass_QualityFilter; // ACBindings.Internal.QualityFilter

    // Child Types
    public unsafe struct ACQualityFilter_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACQualityFilter*, uint> GetNumAttributeStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACQualityFilter*, uint> GetNumAttribute2ndStats; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACQualityFilter*, uint> GetNumSkillStats; // function pointer

        // Methods
    }

    // Members
    public int* _attribute_stat_filter;
    public int* _attribute2nd_stat_filter;
    public int* _skill_stat_filter;

    // Generated Constructor
    public ACQualityFilter(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Returns the number of position statistics supported by ACQualityFilter, which is a constant value of 32.
    /// <code>Offset: 0x004504B0
    /// unsigned int __thiscall ACQualityFilter::GetNumPositionStats(ACQualityFilter*)</code>
    /// </summary>
    /// <returns>The count of position stats (32).</returns>
    public uint GetNumPositionStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x004504B0)(ref this);

    /// <summary>Retrieves the database object type identifier for this quality filter instance.
    /// <code>Offset: 0x004CCC10
    /// unsigned int __thiscall ACQualityFilter::GetDBOType(ACQualityFilter*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the DBO type; for ACQualityFilter it is always 268435468.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x004CCC10)(ref this);

    /// <summary>Returns the fixed number of attribute second statistics that the quality filter handles.
    /// <code>Offset: 0x00520B90
    /// unsigned int __thiscall ACQualityFilter::GetNumAttribute2ndStats(ACQualityFilter*)</code>
    /// </summary>
    /// <returns>The count of attribute second statistics, currently always seven.</returns>
    public uint GetNumAttribute2ndStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x00520B90)(ref this);

    /// <summary>Allocates and constructs an ACQualityFilter instance, returning a reference to its DBObj base interface.
    /// <code>Offset: 0x0058B790
    /// DBObj* __cdecl ACQualityFilter::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created DBObj object, or nullptr when memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B790)();

    /// <summary>Sets the specified stat type's value in the filter array of an ACQualityFilter instance.
    /// <code>Offset: 0x005CCB50
    /// int __thiscall ACQualityFilter::SetAttribute(ACQualityFilter*,unsigned int,const int)</code>
    /// </summary>
    /// <param name="stype">The index of the attribute to update.</param>
    /// <param name="val">The integer value to assign to that attribute.</param>
    /// <returns>Non‑zero if the assignment succeeded; zero if the stat type is out of bounds or allocation fails.</returns>
    public int SetAttribute(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint, int, int>)0x005CCB50)(ref this, stype, val);

    /// <summary>Returns the filter value for a given second-attribute type index.
    /// <code>Offset: 0x005CCBC0
    /// int __thiscall ACQualityFilter::QueryAttribute2nd(ACQualityFilter*,unsigned int)</code>
    /// </summary>
    /// <param name="stype">Index of the desired attribute in the second-attribute filter array.</param>
    /// <returns>The integer flag stored at that index if it exists; otherwise zero.</returns>
    public int QueryAttribute2nd(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint, int>)0x005CCBC0)(ref this, stype);

    /// <summary>Sets a secondary attribute filter value at the specified index, allocating storage as needed.
    /// <code>Offset: 0x005CCBF0
    /// int __thiscall ACQualityFilter::SetAttribute2nd(ACQualityFilter*,unsigned int,const int)</code>
    /// </summary>
    /// <param name="stype">Index of the secondary attribute to set.</param>
    /// <param name="val">Value assigned to that attribute slot.</param>
    /// <returns>1 if the operation succeeds; 0 if the index is out of bounds or memory allocation fails.</returns>
    public int SetAttribute2nd(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint, int, int>)0x005CCBF0)(ref this, stype, val);

    /// <summary>Clears the quality filter by resetting its base class state and deallocating any attribute or skill filter arrays, setting pointers to null.
    /// <code>Offset: 0x005CCC70
    /// void __thiscall ACQualityFilter::Clear(ACQualityFilter*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void>)0x005CCC70)(ref this);

    /// <summary>Retrieves the total count of float-based statistic filters within an ACQualityFilter instance.
    /// <code>Offset: 0x005CCCC0
    /// unsigned int __thiscall ACQualityFilter::GetNumFloatStats(ACQualityFilter*)</code>
    /// </summary>
    /// <returns>The number of float stat filters, which is 512 for this implementation.</returns>
    public uint GetNumFloatStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x005CCCC0)(ref this);

    /// <summary>Returns the total count of boolean statistics available in the quality filter.
    /// <code>Offset: 0x005CCCD0
    /// unsigned int __thiscall ACQualityFilter::GetNumBoolStats(ACQualityFilter*)</code>
    /// </summary>
    /// <returns>The constant integer 256, representing the number of bool stats that can be queried.</returns>
    public uint GetNumBoolStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x005CCCD0)(ref this);

    /// <summary>Retrieves the total number of Data ID (DID) statistics tracked by this quality filter.
    /// <code>Offset: 0x005CCCE0
    /// unsigned int __thiscall ACQualityFilter::GetNumDIDStats(ACQualityFilter*)</code>
    /// </summary>
    /// <returns>The count of DID statistics, always 64 for this implementation.</returns>
    public uint GetNumDIDStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x005CCCE0)(ref this);

    /// <summary>Computes the byte size required to serialize an ACQualityFilter, updating supplied counters with the numbers of attributes, secondary attributes and skills present.
    /// <code>Offset: 0x005CCCF0
    /// unsigned int __thiscall ACQualityFilter::pack_size(ACQualityFilter*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="num_attributes">Receives the count of non‑zero attribute statistics stored in the filter.</param>
    /// <param name="num_attribute2nds">Receives the count of non‑zero secondary attribute statistics stored in the filter.</param>
    /// <param name="num_ints">Receives the number of integer statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_int64s">Receives the number of 64‑bit integer statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_bools">Receives the number of boolean statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_floats">Receives the number of floating‑point statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_dids">Receives the number of data ID statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_iids">Receives the number of instance ID statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_strings">Receives the number of string statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_positions">Receives the number of position statistics serialized by the base QualityFilter component.</param>
    /// <param name="num_skills">Receives the count of non‑zero skill statistics stored in the filter.</param>
    /// <returns>Unsigned integer representing the total size in bytes required to serialize this ACQualityFilter instance, including overhead for each entry.</returns>
    public uint pack_size(uint* num_attributes, uint* num_attribute2nds, uint* num_ints, uint* num_int64s, uint* num_bools, uint* num_floats, uint* num_dids, uint* num_iids, uint* num_strings, uint* num_positions, uint* num_skills) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint>)0x005CCCF0)(ref this, num_attributes, num_attribute2nds, num_ints, num_int64s, num_bools, num_floats, num_dids, num_iids, num_strings, num_positions, num_skills);

    /// <summary>Initializes an ACQualityFilter instance, setting up base classes and resetting internal filter pointers.
    /// <code>Offset: 0x005CCE30
    /// void*** __thiscall ACQualityFilter::ACQualityFilter(void***,void**)</code>
    /// </summary>
    /// <param name="instance">Pointer to the object being constructed.</param>
    /// <param name="initData">Optional initialization data passed to the base constructor.</param>
    /// <returns>The initialized ACQualityFilter object pointer.</returns>
    public void*** _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void**, void***>)0x005CCE30)(ref this, a2);

    /// <summary>Serializes an ACQualityFilter instance into a binary buffer, writing counts of attribute groups and indices of active integer stat filters.
    /// <code>Offset: 0x005CCE70
    /// unsigned int __thiscall ACQualityFilter::Pack(ACQualityFilter*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the destination buffer pointer; after packing it points to the next free byte.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>Size in bytes required to fully serialize this object. If the supplied size is smaller, no data is written and the return value indicates how many bytes would be needed.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void**, uint, uint>)0x005CCE70)(ref this, addr, size);

    /// <summary>Unpacks serialized ACQualityFilter data from a byte stream, initializing base filters, attributes, secondary attributes, and skill statistics.
    /// <code>Offset: 0x005CCFD0
    /// int __thiscall ACQualityFilter::UnPack(ACQualityFilter*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position within the input buffer; updated to point after the consumed data.</param>
    /// <param name="size">Number of bytes remaining in the buffer at entry; must be sufficient for a full packed representation or the function fails.</param>
    /// <returns>Non‑zero if unpacking succeeds, zero if the buffer is too small or data is invalid.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void**, uint, int>)0x005CCFD0)(ref this, addr, size);
}

