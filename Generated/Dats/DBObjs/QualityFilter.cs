namespace ACBindings;

// QualityFilter
public unsafe struct QualityFilter : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // QualityFilter_vtbl
    public unsafe struct QualityFilter_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer
        public System.IntPtr Clear; // function pointer
        public System.IntPtr GetNumIntStats; // function pointer
        public System.IntPtr GetNumInt64Stats; // function pointer
        public System.IntPtr GetNumBoolStats; // function pointer
        public System.IntPtr GetNumFloatStats; // function pointer
        public System.IntPtr GetNumDIDStats; // function pointer
        public System.IntPtr GetNumIIDStats; // function pointer
        public System.IntPtr GetNumStringStats; // function pointer
        public System.IntPtr GetNumPositionStats; // function pointer

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
    // void __thiscall QualityFilter::Clear(QualityFilter*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, void>)0x006B2D90)(ref this);
    // int __thiscall QualityFilter::QueryInt(QualityFilter*,unsigned int)
    public int QueryInt(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, uint, int>)0x006B2E40)(ref this, stype);
    // int __thiscall QualityFilter::SetInt(QualityFilter*,unsigned int,const int)
    public int SetInt(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, uint, int, int>)0x006B2E70)(ref this, stype, val);
    // int __thiscall QualityFilter::QueryFloat(QualityFilter*,unsigned int)
    public int QueryFloat(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, uint, int>)0x006B2EE0)(ref this, stype);
    // unsigned int __thiscall QualityFilter::pack_size(QualityFilter*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*)
    public uint pack_size(uint* num_ints, uint* num_int64s, uint* num_bools, uint* num_floats, uint* num_dids, uint* num_iids, uint* num_strings, uint* num_positions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint>)0x006B2F20)(ref this, num_ints, num_int64s, num_bools, num_floats, num_dids, num_iids, num_strings, num_positions);
    // void __thiscall QualityFilter::~QualityFilter(QualityFilter*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, void>)0x006B31D0)(ref this);
    // unsigned int __thiscall QualityFilter::Pack(QualityFilter*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, void**, uint, uint>)0x006B3200)(ref this, addr, size);
    // int __thiscall QualityFilter::UnPack(QualityFilter*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityFilter, void**, uint, int>)0x006B3490)(ref this, addr, size);
}

