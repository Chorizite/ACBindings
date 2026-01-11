namespace ACBindings.Internal;

public unsafe struct CloPaletteTemplate : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloPaletteTemplate_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, void> CloPaletteTemplate_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CloPaletteTemplate*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID iconID;
    public uint numSubpalEffects;
    public ACBindings.Internal.CloSubpalEffect* subpalEffects;

    // Generated Constructor
    public CloPaletteTemplate() {
        _ConstructorInternal();
    }
    public CloPaletteTemplate(ACBindings.Internal.CloPaletteTemplate* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A93E0
    /// unsigned int __thiscall CloPaletteTemplate::pack_size(CloPaletteTemplate*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, uint>)0x005A93E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9520
    /// void __thiscall CloPaletteTemplate::CloPaletteTemplate(CloPaletteTemplate*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void>)0x005A9520)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9540
    /// void __thiscall CloPaletteTemplate::~CloPaletteTemplate(CloPaletteTemplate*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void>)0x005A9540)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9AB0
    /// unsigned int __thiscall CloPaletteTemplate::Pack(CloPaletteTemplate*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void**, uint, uint>)0x005A9AB0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A9B20
    /// int __thiscall CloPaletteTemplate::UnPack(CloPaletteTemplate*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, void**, uint, int>)0x005A9B20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005A9D50
    /// void __thiscall CloPaletteTemplate::CloPaletteTemplate(CloPaletteTemplate*,const CloPaletteTemplate*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CloPaletteTemplate* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloPaletteTemplate, ACBindings.Internal.CloPaletteTemplate*, void>)0x005A9D50)(ref this, rhs);
}

