namespace ACBindings;

// CloSubpalEffect
public unsafe struct CloSubpalEffect
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CloSubpalEffect_vtbl
    public unsafe struct CloSubpalEffect_vtbl
    {
        // Members
        public System.IntPtr CloSubpalEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint numRanges;
    public uint* rangeStart;
    public uint* rangeLength;
    public ACBindings.IDClass___tagDataID palSet;

    // Generated Constructor
    public CloSubpalEffect() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CloSubpalEffect::CloSubpalEffect(CloSubpalEffect*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloSubpalEffect, void>)0x005A9590)(ref this);
    // unsigned int __thiscall CloSubpalEffect::Pack(CloSubpalEffect*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloSubpalEffect, void**, uint, uint>)0x005A9C20)(ref this, addr, size);
    // int __thiscall CloSubpalEffect::UnPack(CloSubpalEffect*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloSubpalEffect, void**, uint, int>)0x005A9C90)(ref this, addr, size);
}

