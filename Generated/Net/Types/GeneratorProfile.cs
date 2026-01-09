namespace ACBindings;

// GeneratorProfile
public unsafe struct GeneratorProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GeneratorProfile_vtbl
    public unsafe struct GeneratorProfile_vtbl
    {
        // Members
        public System.IntPtr GeneratorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float probability;
    public ACBindings.IDClass___tagDataID type;
    public double delay;
    public int initCreate;
    public int maxNum;
    public ACBindings.RegenerationType whenCreate;
    public ACBindings.RegenLocationType whereCreate;
    public int stackSize;
    public uint ptid;
    public float shade;
    public ACBindings.Position pos_val;
    public uint slot;

    // Generated Constructor
    public GeneratorProfile() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall GeneratorProfile::GeneratorProfile(GeneratorProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorProfile, void>)0x005D18D0)(ref this);
    // int __thiscall GeneratorProfile::UnPack(GeneratorProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorProfile, void**, uint, int>)0x005D1950)(ref this, addr, size);
    // unsigned int __thiscall GeneratorProfile::Pack(GeneratorProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorProfile, void**, uint, uint>)0x005D1AA0)(ref this, addr, size);
}

