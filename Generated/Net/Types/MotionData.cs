namespace ACBindings.Internal;

public unsafe struct MotionData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct MotionData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, void> MotionData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MotionData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public byte num_anims;
    public ACBindings.Internal.AnimData* anims;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.AC1Legacy.Vector3 omega;
    public byte bitfield;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00522FD0
    /// void __thiscall MotionData::~MotionData(MotionData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void>)0x00522FD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526D50
    /// void __thiscall MotionData::Destroy(MotionData*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void>)0x00526D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526F80
    /// unsigned int __thiscall MotionData::Pack(MotionData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void**, uint, uint>)0x00526F80)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527170
    /// int __thiscall MotionData::UnPack(MotionData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionData, void**, uint, int>)0x00527170)(ref this, addr, size);
}

