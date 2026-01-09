namespace ACBindings;

// SoundTableData
public unsafe struct SoundTableData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj
    public ACBindings.IntrusiveHashData__uint__SoundTableData_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__uint__SoundTableData_ptr

    // Child Types
    // SoundTableData_vtbl
    public unsafe struct SoundTableData_vtbl
    {
        // Members
        public System.IntPtr SoundTableData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IntrusiveHashTable__uint__SoundTableData_ptr sound_hash_;
    public uint num_stdatas_;
    public ACBindings.SoundData* data_;

    // Generated Constructor
    public SoundTableData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SoundTableData::GetSubDataIDs(SoundTableData*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, ACBindings.QualifiedDataIDArray*, void>)0x00552980)(ref this, id_array);
    // unsigned int __thiscall SoundTableData::pack_size(SoundTableData*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, uint>)0x00552A40)(ref this);
    // unsigned int __thiscall SoundTableData::Pack(SoundTableData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, void**, uint, uint>)0x00552AD0)(ref this, addr, size);
    // int __thiscall SoundTableData::Lookup(SoundTableData*,SoundType,SoundTableData**)
    public int Lookup(ACBindings.SoundType stype, ACBindings.SoundTableData** lookup_stdata) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, ACBindings.SoundType, ACBindings.SoundTableData**, int>)0x00552D20)(ref this, stype, lookup_stdata);
    // void __thiscall SoundTableData::SoundTableData(SoundTableData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, void>)0x00552DC0)(ref this);
    // void __thiscall SoundTableData::Destroy(SoundTableData*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, void>)0x00552F20)(ref this);
    // int __thiscall SoundTableData::UnPack(SoundTableData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SoundTableData, void**, uint, int>)0x00552F90)(ref this, addr, size);
}

