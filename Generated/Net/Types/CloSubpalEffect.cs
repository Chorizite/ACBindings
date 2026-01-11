namespace ACBindings.Internal;

public unsafe struct CloSubpalEffect
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloSubpalEffect_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, void> CloSubpalEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint numRanges;
    public uint* rangeStart;
    public uint* rangeLength;
    public ACBindings.Internal.IDClass____tagDataID palSet;

    // Generated Constructor
    public CloSubpalEffect() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A9590
    /// void __thiscall CloSubpalEffect::CloSubpalEffect(CloSubpalEffect*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloSubpalEffect, void>)0x005A9590)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9C20
    /// unsigned int __thiscall CloSubpalEffect::Pack(CloSubpalEffect*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloSubpalEffect, void**, uint, uint>)0x005A9C20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A9C90
    /// int __thiscall CloSubpalEffect::UnPack(CloSubpalEffect*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloSubpalEffect, void**, uint, int>)0x005A9C90)(ref this, addr, size);
}

