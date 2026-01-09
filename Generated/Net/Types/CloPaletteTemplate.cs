namespace ACBindings;

// CloPaletteTemplate
public unsafe struct CloPaletteTemplate : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CloPaletteTemplate_vtbl
    public unsafe struct CloPaletteTemplate_vtbl
    {
        // Members
        public System.IntPtr CloPaletteTemplate_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID iconID;
    public uint numSubpalEffects;
    public ACBindings.CloSubpalEffect* subpalEffects;

    // Generated Constructor
    public CloPaletteTemplate() {
        _ConstructorInternal();
    }
    public CloPaletteTemplate(ACBindings.CloPaletteTemplate* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall CloPaletteTemplate::pack_size(CloPaletteTemplate*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloPaletteTemplate, uint>)0x005A93E0)(ref this);
    // void __thiscall CloPaletteTemplate::CloPaletteTemplate(CloPaletteTemplate*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloPaletteTemplate, void>)0x005A9520)(ref this);
    // void __thiscall CloPaletteTemplate::~CloPaletteTemplate(CloPaletteTemplate*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloPaletteTemplate, void>)0x005A9540)(ref this);
    // unsigned int __thiscall CloPaletteTemplate::Pack(CloPaletteTemplate*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloPaletteTemplate, void**, uint, uint>)0x005A9AB0)(ref this, addr, size);
    // int __thiscall CloPaletteTemplate::UnPack(CloPaletteTemplate*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloPaletteTemplate, void**, uint, int>)0x005A9B20)(ref this, addr, size);
    // void __thiscall CloPaletteTemplate::CloPaletteTemplate(CloPaletteTemplate*,const CloPaletteTemplate*)
    public void _ConstructorInternal(ACBindings.CloPaletteTemplate* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloPaletteTemplate, ACBindings.CloPaletteTemplate*, void>)0x005A9D50)(ref this, rhs);
}

