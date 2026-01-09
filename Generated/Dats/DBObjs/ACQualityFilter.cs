namespace ACBindings;

// ACQualityFilter
public unsafe struct ACQualityFilter
{
    // Base Classes
    public ACBindings.QualityFilter BaseClass_QualityFilter; // ACBindings.QualityFilter

    // Child Types
    // ACQualityFilter_vtbl
    public unsafe struct ACQualityFilter_vtbl
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
        public System.IntPtr GetNumAttributeStats; // function pointer
        public System.IntPtr GetNumAttribute2ndStats; // function pointer
        public System.IntPtr GetNumSkillStats; // function pointer

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
    // unsigned int __thiscall ACQualityFilter::GetNumPositionStats(ACQualityFilter*)
    public uint GetNumPositionStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint>)0x004504B0)(ref this);
    // unsigned int __thiscall ACQualityFilter::GetDBOType(ACQualityFilter*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint>)0x004CCC10)(ref this);
    // unsigned int __thiscall ACQualityFilter::GetNumAttribute2ndStats(ACQualityFilter*)
    public uint GetNumAttribute2ndStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint>)0x00520B90)(ref this);
    // DBObj* __cdecl ACQualityFilter::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B790)();
    // int __thiscall ACQualityFilter::SetAttribute(ACQualityFilter*,unsigned int,const int)
    public int SetAttribute(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint, int, int>)0x005CCB50)(ref this, stype, val);
    // int __thiscall ACQualityFilter::QueryAttribute2nd(ACQualityFilter*,unsigned int)
    public int QueryAttribute2nd(uint stype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint, int>)0x005CCBC0)(ref this, stype);
    // int __thiscall ACQualityFilter::SetAttribute2nd(ACQualityFilter*,unsigned int,const int)
    public int SetAttribute2nd(uint stype, int val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint, int, int>)0x005CCBF0)(ref this, stype, val);
    // void __thiscall ACQualityFilter::Clear(ACQualityFilter*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, void>)0x005CCC70)(ref this);
    // unsigned int __thiscall ACQualityFilter::GetNumFloatStats(ACQualityFilter*)
    public uint GetNumFloatStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint>)0x005CCCC0)(ref this);
    // unsigned int __thiscall ACQualityFilter::GetNumBoolStats(ACQualityFilter*)
    public uint GetNumBoolStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint>)0x005CCCD0)(ref this);
    // unsigned int __thiscall ACQualityFilter::GetNumDIDStats(ACQualityFilter*)
    public uint GetNumDIDStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint>)0x005CCCE0)(ref this);
    // unsigned int __thiscall ACQualityFilter::pack_size(ACQualityFilter*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*,unsigned int*)
    public uint pack_size(uint* num_attributes, uint* num_attribute2nds, uint* num_ints, uint* num_int64s, uint* num_bools, uint* num_floats, uint* num_dids, uint* num_iids, uint* num_strings, uint* num_positions, uint* num_skills) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint>)0x005CCCF0)(ref this, num_attributes, num_attribute2nds, num_ints, num_int64s, num_bools, num_floats, num_dids, num_iids, num_strings, num_positions, num_skills);
    // void*** __thiscall ACQualityFilter::ACQualityFilter(void***,void**)
    public void*** _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, void**, void***>)0x005CCE30)(ref this, a2);
    // unsigned int __thiscall ACQualityFilter::Pack(ACQualityFilter*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, void**, uint, uint>)0x005CCE70)(ref this, addr, size);
    // int __thiscall ACQualityFilter::UnPack(ACQualityFilter*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACQualityFilter, void**, uint, int>)0x005CCFD0)(ref this, addr, size);
}

