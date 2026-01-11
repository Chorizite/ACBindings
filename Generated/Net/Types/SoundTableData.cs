namespace ACBindings.Internal;

public unsafe struct SoundTableData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.IntrusiveHashData__uint___SoundTableData_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___SoundTableData_ptr

    // Child Types
    public unsafe struct SoundTableData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, void> SoundTableData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SoundTableData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IntrusiveHashTable__uint___SoundTableData_ptr sound_hash_;
    public uint num_stdatas_;
    public ACBindings.Internal.SoundData* data_;

    // Generated Constructor
    public SoundTableData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00552980
    /// void __thiscall SoundTableData::GetSubDataIDs(SoundTableData*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00552980)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00552A40
    /// unsigned int __thiscall SoundTableData::pack_size(SoundTableData*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, uint>)0x00552A40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552AD0
    /// unsigned int __thiscall SoundTableData::Pack(SoundTableData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void**, uint, uint>)0x00552AD0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00552D20
    /// int __thiscall SoundTableData::Lookup(SoundTableData*,SoundType,SoundTableData**)</code>
    /// </summary>
    public int Lookup(ACBindings.Internal.SoundType stype, ACBindings.Internal.SoundTableData** lookup_stdata) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, ACBindings.Internal.SoundType, ACBindings.Internal.SoundTableData**, int>)0x00552D20)(ref this, stype, lookup_stdata);

    /// <summary>
    /// <code>Offset: 0x00552DC0
    /// void __thiscall SoundTableData::SoundTableData(SoundTableData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void>)0x00552DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552F20
    /// void __thiscall SoundTableData::Destroy(SoundTableData*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void>)0x00552F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552F90
    /// int __thiscall SoundTableData::UnPack(SoundTableData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SoundTableData, void**, uint, int>)0x00552F90)(ref this, addr, size);
}

