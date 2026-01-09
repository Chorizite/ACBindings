namespace ACBindings;

// CloTextureEffect
public unsafe struct CloTextureEffect
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CloTextureEffect_vtbl
    public unsafe struct CloTextureEffect_vtbl
    {
        // Members
        public System.IntPtr CloTextureEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID oldTexID;
    public ACBindings.IDClass___tagDataID newTexID;

    // Generated Constructor
    public CloTextureEffect() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CloTextureEffect::CloTextureEffect(CloTextureEffect*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloTextureEffect, void>)0x005A9500)(ref this);
    // int __thiscall CloTextureEffect::UnPack(CloTextureEffect*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloTextureEffect, void**, uint, int>)0x005A98C0)(ref this, addr, size);
}

