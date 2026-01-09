namespace ACBindings;

// SalvageResult
public unsafe struct SalvageResult
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SalvageResult_vtbl
    public unsafe struct SalvageResult_vtbl
    {
        // Members
        public System.IntPtr SalvageResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_material;
    public double m_workmanship;
    public int m_units;

    // Methods
    // unsigned int __thiscall SalvageResult::Pack(SalvageResult*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageResult, void**, uint, uint>)0x005CA810)(ref this, addr, size);
    // int __thiscall SalvageResult::UnPack(SalvageResult*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SalvageResult, void**, uint, int>)0x005CA850)(ref this, addr, size);
}

