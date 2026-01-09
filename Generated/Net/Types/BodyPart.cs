namespace ACBindings;

// BodyPart
public unsafe struct BodyPart : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // BodyPart_vtbl
    public unsafe struct BodyPart_vtbl
    {
        // Members
        public System.IntPtr BodyPart_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.DAMAGE_TYPE _dtype;
    public int _dval;
    public float _dvar;
    public ACBindings.ArmorCache _acache;
    public ACBindings.BODY_HEIGHT _bh;
    public ACBindings.BodyPartSelectionData* _bpsd;

    // Generated Constructor
    public BodyPart() {
        _ConstructorInternal();
    }
    public BodyPart(ACBindings.BodyPart* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall BodyPart::BodyPart(BodyPart*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPart, void>)0x0058FFF0)(ref this);
    // unsigned int __thiscall BodyPart::GetPackSize(BodyPart*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPart, uint>)0x005D20A0)(ref this);
    // void __thiscall BodyPart::~BodyPart(BodyPart*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPart, void>)0x005D2180)(ref this);
    // unsigned int __thiscall BodyPart::Pack(BodyPart*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPart, void**, uint, uint>)0x005D2210)(ref this, addr, size);
    // int __thiscall BodyPart::UnPack(BodyPart*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPart, void**, uint, int>)0x005D22A0)(ref this, addr, size);
    // void __thiscall BodyPart::BodyPart(BodyPart*,const BodyPart*)
    public void _ConstructorInternal(ACBindings.BodyPart* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BodyPart, ACBindings.BodyPart*, void>)0x005D2460)(ref this, rhs);
}

