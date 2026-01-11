namespace ACBindings.Internal;

public unsafe struct CloObjectEffect : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloObjectEffect_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, void> CloObjectEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloObjectEffect*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint partNum;
    public ACBindings.Internal.IDClass____tagDataID objectID;
    public uint numTextureEffects;
    public ACBindings.Internal.CloTextureEffect* textureEffects;

    // Generated Constructor
    public CloObjectEffect() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A9390
    /// unsigned int __thiscall CloObjectEffect::pack_size(CloObjectEffect*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, uint>)0x005A9390)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9430
    /// void __thiscall CloObjectEffect::CloObjectEffect(CloObjectEffect*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void>)0x005A9430)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A94B0
    /// void __thiscall CloObjectEffect::~CloObjectEffect(CloObjectEffect*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void>)0x005A94B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9700
    /// unsigned int __thiscall CloObjectEffect::Pack(CloObjectEffect*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void**, uint, uint>)0x005A9700)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A9780
    /// int __thiscall CloObjectEffect::UnPack(CloObjectEffect*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloObjectEffect, void**, uint, int>)0x005A9780)(ref this, addr, size);
}

