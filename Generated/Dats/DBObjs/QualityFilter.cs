namespace ACBindings.Internal;

public unsafe struct QualityFilter : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct QualityFilter_vtbl
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

    /// <summary>
    /// <code>Offset: 0x006B2D90
    /// void __thiscall QualityFilter::Clear(QualityFilter*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void>)0x006B2D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B2E40
    /// int __thiscall QualityFilter::QueryInt(QualityFilter*,unsigned int)</code>
    /// </summary>
    public int QueryInt(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint, int>)0x006B2E40)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x006B2E70
    /// int __thiscall QualityFilter::SetInt(QualityFilter*,unsigned int,const int)</code>
    /// </summary>
    public int SetInt(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint, int, int>)0x006B2E70)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x006B2EE0
    /// int __thiscall QualityFilter::QueryFloat(QualityFilter*,unsigned int)</code>
    /// </summary>
    public int QueryFloat(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint, int>)0x006B2EE0)(ref this, stype);

    /// <summary>
    /// <code>Offset: 0x006B2F20
    /// unsigned int __thiscall QualityFilter::pack_size(QualityFilter*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public uint pack_size(uint* num_ints, uint* num_int64s, uint* num_bools, uint* num_floats, uint* num_dids, uint* num_iids, uint* num_strings, uint* num_positions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint>)0x006B2F20)(ref this, num_ints, num_int64s, num_bools, num_floats, num_dids, num_iids, num_strings, num_positions);

    /// <summary>
    /// <code>Offset: 0x006B31D0
    /// void __thiscall QualityFilter::~QualityFilter(QualityFilter*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void>)0x006B31D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B3200
    /// unsigned int __thiscall QualityFilter::Pack(QualityFilter*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void**, uint, uint>)0x006B3200)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B3490
    /// int __thiscall QualityFilter::UnPack(QualityFilter*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityFilter, void**, uint, int>)0x006B3490)(ref this, addr, size);
}

