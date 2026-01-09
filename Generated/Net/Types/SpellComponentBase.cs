namespace ACBindings;

// SpellComponentBase
public unsafe struct SpellComponentBase : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SpellComponentBase_vtbl
    public unsafe struct SpellComponentBase_vtbl
    {
        // Members
        public System.IntPtr SpellComponentBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.SpellComponentCategory _category;
    public ACBindings.IDClass___tagDataID _iconID;
    public ACBindings.SpellComponentType _type;
    public uint _gesture;
    public float _time;
    public ACBindings.AC1Legacy.PStringBase__sbyte _text;
    public float _CDM;

    // Generated Constructor
    public SpellComponentBase() {
        _ConstructorInternal();
    }
    public SpellComponentBase(ACBindings.SpellComponentBase* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SpellComponentBase::SpellComponentBase(SpellComponentBase*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, void>)0x00489EE0)(ref this);
    // void __thiscall SpellComponentBase::~SpellComponentBase(SpellComponentBase*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, void>)0x00489F20)(ref this);
    // int* __thiscall SpellComponentBase::InqName(_DWORD*,int*)
    public int* InqName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, int*, int*>)0x00597D40)(ref this, a2);
    // unsigned int __thiscall SpellComponentBase::Pack(SpellComponentBase*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, void**, uint, uint>)0x005BCEB0)(ref this, addr, size);
    // void __thiscall SpellComponentBase::Init(SpellComponentBase*)
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, void>)0x005BCF60)(ref this);
    // int __thiscall SpellComponentBase::UnPack(SpellComponentBase*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, void**, uint, int>)0x005BCFA0)(ref this, addr, size);
    // void __thiscall SpellComponentBase::SpellComponentBase(SpellComponentBase*,const SpellComponentBase*)
    public void _ConstructorInternal(ACBindings.SpellComponentBase* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellComponentBase, ACBindings.SpellComponentBase*, void>)0x005BD360)(ref this, that);
}

