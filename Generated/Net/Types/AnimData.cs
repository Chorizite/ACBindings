namespace ACBindings.Internal;

public unsafe struct AnimData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AnimData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, void> AnimData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID anim_id;
    public int low_frame;
    public int high_frame;
    public float framerate;

    // Generated Constructor
    public AnimData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005268E0
    /// void __thiscall AnimData::AnimData(AnimData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimData, void>)0x005268E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526A00
    /// unsigned int __thiscall AnimData::Pack(AnimData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimData, void**, uint, uint>)0x00526A00)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00526A50
    /// int __thiscall AnimData::UnPack(AnimData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimData, void**, uint, int>)0x00526A50)(ref this, addr, size);
}

