namespace ACBindings.Internal;

public unsafe struct BodyPart : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct BodyPart_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, void> BodyPart_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BodyPart*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.DAMAGE_TYPE _dtype;
    public int _dval;
    public float _dvar;
    public ACBindings.Internal.ArmorCache _acache;
    public ACBindings.Internal.BODY_HEIGHT _bh;
    public ACBindings.Internal.BodyPartSelectionData* _bpsd;

    // Generated Constructor
    public BodyPart() {
        _ConstructorInternal();
    }
    public BodyPart(ACBindings.Internal.BodyPart* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058FFF0
    /// void __thiscall BodyPart::BodyPart(BodyPart*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void>)0x0058FFF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D20A0
    /// unsigned int __thiscall BodyPart::GetPackSize(BodyPart*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, uint>)0x005D20A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2180
    /// void __thiscall BodyPart::~BodyPart(BodyPart*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void>)0x005D2180)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2210
    /// unsigned int __thiscall BodyPart::Pack(BodyPart*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void**, uint, uint>)0x005D2210)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D22A0
    /// int __thiscall BodyPart::UnPack(BodyPart*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, void**, uint, int>)0x005D22A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D2460
    /// void __thiscall BodyPart::BodyPart(BodyPart*,const BodyPart*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.BodyPart* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BodyPart, ACBindings.Internal.BodyPart*, void>)0x005D2460)(ref this, rhs);
}

