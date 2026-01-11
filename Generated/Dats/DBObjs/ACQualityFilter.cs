namespace ACBindings.Internal;

public unsafe struct ACQualityFilter
{
    // Base Classes
    public ACBindings.Internal.QualityFilter BaseClass_QualityFilter; // ACBindings.Internal.QualityFilter

    // Child Types
    public unsafe struct ACQualityFilter_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, void> Clear; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumIntStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumInt64Stats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumBoolStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumFloatStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumDIDStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumIIDStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumStringStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityFilter*, uint> GetNumPositionStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACQualityFilter*, uint> GetNumAttributeStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACQualityFilter*, uint> GetNumAttribute2ndStats; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACQualityFilter*, uint> GetNumSkillStats; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004504B0
    /// unsigned int __thiscall ACQualityFilter::GetNumPositionStats(ACQualityFilter*)</code>
    /// </summary>
    public uint GetNumPositionStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x004504B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CCC10
    /// unsigned int __thiscall ACQualityFilter::GetDBOType(ACQualityFilter*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x004CCC10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00520B90
    /// unsigned int __thiscall ACQualityFilter::GetNumAttribute2ndStats(ACQualityFilter*)</code>
    /// </summary>
    public uint GetNumAttribute2ndStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x00520B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058B790
    /// DBObj* __cdecl ACQualityFilter::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B790)();

    /// <summary>
    /// <code>Offset: 0x005CCB50
    /// int __thiscall ACQualityFilter::SetAttribute(ACQualityFilter*,unsigned int,const int)</code>
    /// </summary>
    public int SetAttribute(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint, int, int>)0x005CCB50)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005CCBC0
    /// int __thiscall ACQualityFilter::QueryAttribute2nd(ACQualityFilter*,unsigned int)</code>
    /// </summary>
    public int QueryAttribute2nd(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint, int>)0x005CCBC0)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x005CCBF0
    /// int __thiscall ACQualityFilter::SetAttribute2nd(ACQualityFilter*,unsigned int,const int)</code>
    /// </summary>
    public int SetAttribute2nd(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint, int, int>)0x005CCBF0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005CCC70
    /// void __thiscall ACQualityFilter::Clear(ACQualityFilter*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void>)0x005CCC70)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CCCC0
    /// unsigned int __thiscall ACQualityFilter::GetNumFloatStats(ACQualityFilter*)</code>
    /// </summary>
    public uint GetNumFloatStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x005CCCC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CCCD0
    /// unsigned int __thiscall ACQualityFilter::GetNumBoolStats(ACQualityFilter*)</code>
    /// </summary>
    public uint GetNumBoolStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x005CCCD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CCCE0
    /// unsigned int __thiscall ACQualityFilter::GetNumDIDStats(ACQualityFilter*)</code>
    /// </summary>
    public uint GetNumDIDStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint>)0x005CCCE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CCCF0
    /// unsigned int __thiscall ACQualityFilter::pack_size(ACQualityFilter*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public uint pack_size(uint* num_attributes, uint* num_attribute2nds, uint* num_ints, uint* num_int64s, uint* num_bools, uint* num_floats, uint* num_dids, uint* num_iids, uint* num_strings, uint* num_positions, uint* num_skills) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint>)0x005CCCF0)(ref this, num_attributes, num_attribute2nds, num_ints, num_int64s, num_bools, num_floats, num_dids, num_iids, num_strings, num_positions, num_skills);

    /// <summary>
    /// <code>Offset: 0x005CCE30
    /// void*** __thiscall ACQualityFilter::ACQualityFilter(void***,void**)</code>
    /// </summary>
    public void*** _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void**, void***>)0x005CCE30)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005CCE70
    /// unsigned int __thiscall ACQualityFilter::Pack(ACQualityFilter*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void**, uint, uint>)0x005CCE70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CCFD0
    /// int __thiscall ACQualityFilter::UnPack(ACQualityFilter*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACQualityFilter, void**, uint, int>)0x005CCFD0)(ref this, addr, size);
}

