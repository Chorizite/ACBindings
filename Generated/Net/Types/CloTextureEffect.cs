namespace ACBindings.Internal;

public unsafe struct CloTextureEffect
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloTextureEffect_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, void> CloTextureEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloTextureEffect*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID oldTexID;
    public ACBindings.Internal.IDClass____tagDataID newTexID;

    // Generated Constructor
    public CloTextureEffect() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A9500
    /// void __thiscall CloTextureEffect::CloTextureEffect(CloTextureEffect*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloTextureEffect, void>)0x005A9500)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A98C0
    /// int __thiscall CloTextureEffect::UnPack(CloTextureEffect*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloTextureEffect, void**, uint, int>)0x005A98C0)(ref this, addr, size);
}

