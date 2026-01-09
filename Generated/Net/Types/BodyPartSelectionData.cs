namespace ACBindings;

// BodyPartSelectionData
public unsafe struct BodyPartSelectionData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // BodyPartSelectionData_vtbl
    public unsafe struct BodyPartSelectionData_vtbl
    {
        // Members
        public System.IntPtr BodyPartSelectionData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    public BodyPartSelectionData(ACBindings.BodyPartSelectionData* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // unsigned int __thiscall BodyPartSelectionData::GetPackSize(BodyPartSelectionData*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPartSelectionData, uint>)0x00422370)(ref this);
    // void __thiscall BodyPartSelectionData::BodyPartSelectionData(BodyPartSelectionData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPartSelectionData, void>)0x005D20F0)(ref this);
    // void __thiscall BodyPartSelectionData::BodyPartSelectionData(BodyPartSelectionData*,const BodyPartSelectionData*)
    public void _ConstructorInternal(ACBindings.BodyPartSelectionData* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPartSelectionData, ACBindings.BodyPartSelectionData*, void>)0x005D2120)(ref this, that);
    // unsigned int __thiscall BodyPartSelectionData::Pack(BodyPartSelectionData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPartSelectionData, void**, uint, uint>)0x005D25E0)(ref this, addr, size);
    // int __thiscall BodyPartSelectionData::UnPack(BodyPartSelectionData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPartSelectionData, void**, uint, int>)0x005D2690)(ref this, addr, size);
}

