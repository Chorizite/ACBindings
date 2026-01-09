namespace ACBindings;

// ClothingBase
public unsafe struct ClothingBase : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ClothingBase_vtbl
    public unsafe struct ClothingBase_vtbl
    {
        // Members
        public System.IntPtr ClothingBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint numObjectEffects;
    public ACBindings.CloObjectEffect* objectEffects;

    // Generated Constructor
    public ClothingBase() {
        _ConstructorInternal();
    }
    public ClothingBase(ACBindings.ClothingBase* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall ClothingBase::pack_size(ClothingBase*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, uint>)0x005A9D80)(ref this);
    // void __thiscall ClothingBase::ClothingBase(ClothingBase*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, void>)0x005A9DD0)(ref this);
    // void __thiscall ClothingBase::~ClothingBase(ClothingBase*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, void>)0x005A9DF0)(ref this);
    // int __thiscall ClothingBase::ApplyPartAndTextureChanges(ClothingBase*,ObjDesc*)
    public int ApplyPartAndTextureChanges(ACBindings.ObjDesc* od) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, ACBindings.ObjDesc*, int>)0x005A9F60)(ref this, od);
    // unsigned int __thiscall ClothingBase::Pack(ClothingBase*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, void**, uint, uint>)0x005AA070)(ref this, addr, size);
    // int __thiscall ClothingBase::UnPack(ClothingBase*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, void**, uint, int>)0x005AA0E0)(ref this, addr, size);
    // void __thiscall ClothingBase::ClothingBase(ClothingBase*,const ClothingBase*)
    public void _ConstructorInternal(ACBindings.ClothingBase* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClothingBase, ACBindings.ClothingBase*, void>)0x005AA230)(ref this, rhs);
}

