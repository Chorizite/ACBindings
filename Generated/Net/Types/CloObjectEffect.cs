namespace ACBindings;

// CloObjectEffect
public unsafe struct CloObjectEffect : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CloObjectEffect_vtbl
    public unsafe struct CloObjectEffect_vtbl
    {
        // Members
        public System.IntPtr CloObjectEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint partNum;
    public ACBindings.IDClass___tagDataID objectID;
    public uint numTextureEffects;
    public ACBindings.CloTextureEffect* textureEffects;

    // Generated Constructor
    public CloObjectEffect() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall CloObjectEffect::pack_size(CloObjectEffect*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloObjectEffect, uint>)0x005A9390)(ref this);
    // void __thiscall CloObjectEffect::CloObjectEffect(CloObjectEffect*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloObjectEffect, void>)0x005A9430)(ref this);
    // void __thiscall CloObjectEffect::~CloObjectEffect(CloObjectEffect*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloObjectEffect, void>)0x005A94B0)(ref this);
    // unsigned int __thiscall CloObjectEffect::Pack(CloObjectEffect*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloObjectEffect, void**, uint, uint>)0x005A9700)(ref this, addr, size);
    // int __thiscall CloObjectEffect::UnPack(CloObjectEffect*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CloObjectEffect, void**, uint, int>)0x005A9780)(ref this, addr, size);
}

