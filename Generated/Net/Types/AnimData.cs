namespace ACBindings;

// AnimData
public unsafe struct AnimData
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AnimData_vtbl
    public unsafe struct AnimData_vtbl
    {
        // Members
        public System.IntPtr AnimData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID anim_id;
    public int low_frame;
    public int high_frame;
    public float framerate;

    // Generated Constructor
    public AnimData() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AnimData::AnimData(AnimData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimData, void>)0x005268E0)(ref this);
    // unsigned int __thiscall AnimData::Pack(AnimData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimData, void**, uint, uint>)0x00526A00)(ref this, addr, size);
    // int __thiscall AnimData::UnPack(AnimData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AnimData, void**, uint, int>)0x00526A50)(ref this, addr, size);
}

