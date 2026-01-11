namespace ACBindings.Internal;

public unsafe struct BodyPartSelectionData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct BodyPartSelectionData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, void> BodyPartSelectionData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPartSelectionData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float HLF;
    public float MLF;
    public float LLF;
    public float HRF;
    public float MRF;
    public float LRF;
    public float HLB;
    public float MLB;
    public float LLB;
    public float HRB;
    public float MRB;
    public float LRB;

    // Generated Constructor
    public BodyPartSelectionData() {
        _ConstructorInternal();
    }
    public BodyPartSelectionData(ACBindings.Internal.BodyPartSelectionData* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Provides the fixed size of a BodyPartSelectionData pack in bytes.
    /// <code>Offset: 0x00422370
    /// unsigned int __thiscall BodyPartSelectionData::GetPackSize(BodyPartSelectionData*)</code>
    /// </summary>
    /// <returns>The size, in bytes, of the BodyPartSelectionData structure (typically 48).</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, uint>)0x00422370)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D20F0
    /// void __thiscall BodyPartSelectionData::BodyPartSelectionData(BodyPartSelectionData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, void>)0x005D20F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2120
    /// void __thiscall BodyPartSelectionData::BodyPartSelectionData(BodyPartSelectionData*,const BodyPartSelectionData*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.BodyPartSelectionData* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, ACBindings.Internal.BodyPartSelectionData*, void>)0x005D2120)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005D25E0
    /// unsigned int __thiscall BodyPartSelectionData::Pack(BodyPartSelectionData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, void**, uint, uint>)0x005D25E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D2690
    /// int __thiscall BodyPartSelectionData::UnPack(BodyPartSelectionData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPartSelectionData, void**, uint, int>)0x005D2690)(ref this, addr, size);
}

