namespace ACBindings.Internal;

public unsafe struct GeneratorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, void> GeneratorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float probability;
    public ACBindings.Internal.IDClass____tagDataID type;
    public double delay;
    public int initCreate;
    public int maxNum;
    public ACBindings.Internal.RegenerationType whenCreate;
    public ACBindings.Internal.RegenLocationType whereCreate;
    public int stackSize;
    public uint ptid;
    public float shade;
    public ACBindings.Internal.Position pos_val;
    public uint slot;

    // Generated Constructor
    public GeneratorProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D18D0
    /// void __thiscall GeneratorProfile::GeneratorProfile(GeneratorProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorProfile, void>)0x005D18D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D1950
    /// int __thiscall GeneratorProfile::UnPack(GeneratorProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorProfile, void**, uint, int>)0x005D1950)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D1AA0
    /// unsigned int __thiscall GeneratorProfile::Pack(GeneratorProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorProfile, void**, uint, uint>)0x005D1AA0)(ref this, addr, size);
}

