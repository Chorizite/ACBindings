namespace ACBindings.Internal;

public unsafe struct ClothingBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ClothingBase_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, void> ClothingBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClothingBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint numObjectEffects;
    public ACBindings.Internal.CloObjectEffect* objectEffects;

    // Generated Constructor
    public ClothingBase() {
        _ConstructorInternal();
    }
    public ClothingBase(ACBindings.Internal.ClothingBase* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A9D80
    /// unsigned int __thiscall ClothingBase::pack_size(ClothingBase*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, uint>)0x005A9D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9DD0
    /// void __thiscall ClothingBase::ClothingBase(ClothingBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void>)0x005A9DD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9DF0
    /// void __thiscall ClothingBase::~ClothingBase(ClothingBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void>)0x005A9DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A9F60
    /// int __thiscall ClothingBase::ApplyPartAndTextureChanges(ClothingBase*,ObjDesc*)</code>
    /// </summary>
    public int ApplyPartAndTextureChanges(ACBindings.Internal.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, ACBindings.Internal.ObjDesc*, int>)0x005A9F60)(ref this, od);

    /// <summary>
    /// <code>Offset: 0x005AA070
    /// unsigned int __thiscall ClothingBase::Pack(ClothingBase*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void**, uint, uint>)0x005AA070)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AA0E0
    /// int __thiscall ClothingBase::UnPack(ClothingBase*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, void**, uint, int>)0x005AA0E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AA230
    /// void __thiscall ClothingBase::ClothingBase(ClothingBase*,const ClothingBase*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ClothingBase* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClothingBase, ACBindings.Internal.ClothingBase*, void>)0x005AA230)(ref this, rhs);
}

