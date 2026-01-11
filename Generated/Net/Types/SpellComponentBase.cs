namespace ACBindings.Internal;

public unsafe struct SpellComponentBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellComponentBase_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, void> SpellComponentBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellComponentBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.SpellComponentCategory _category;
    public ACBindings.Internal.IDClass____tagDataID _iconID;
    public ACBindings.Internal.SpellComponentType _type;
    public uint _gesture;
    public float _time;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _text;
    public float _CDM;

    // Generated Constructor
    public SpellComponentBase() {
        _ConstructorInternal();
    }
    public SpellComponentBase(ACBindings.Internal.SpellComponentBase* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00489EE0
    /// void __thiscall SpellComponentBase::SpellComponentBase(SpellComponentBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void>)0x00489EE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00489F20
    /// void __thiscall SpellComponentBase::~SpellComponentBase(SpellComponentBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void>)0x00489F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00597D40
    /// int* __thiscall SpellComponentBase::InqName(_DWORD*,int*)</code>
    /// </summary>
    public int* InqName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, int*, int*>)0x00597D40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BCEB0
    /// unsigned int __thiscall SpellComponentBase::Pack(SpellComponentBase*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void**, uint, uint>)0x005BCEB0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BCF60
    /// void __thiscall SpellComponentBase::Init(SpellComponentBase*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void>)0x005BCF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BCFA0
    /// int __thiscall SpellComponentBase::UnPack(SpellComponentBase*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, void**, uint, int>)0x005BCFA0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BD360
    /// void __thiscall SpellComponentBase::SpellComponentBase(SpellComponentBase*,const SpellComponentBase*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SpellComponentBase* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellComponentBase, ACBindings.Internal.SpellComponentBase*, void>)0x005BD360)(ref this, that);
}

