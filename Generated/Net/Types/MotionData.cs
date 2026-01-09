namespace ACBindings;

// MotionData
public unsafe struct MotionData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj
    public ACBindings.LongHashData BaseClass_LongHashData; // ACBindings.LongHashData

    // Child Types
    // MotionData_vtbl
    public unsafe struct MotionData_vtbl
    {
        // Members
        public System.IntPtr MotionData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public byte num_anims;
    public ACBindings.AnimData* anims;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public ACBindings.AC1Legacy.Vector3 omega;
    public byte bitfield;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall MotionData::~MotionData(MotionData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionData, void>)0x00522FD0)(ref this);
    // void __thiscall MotionData::Destroy(MotionData*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionData, void>)0x00526D50)(ref this);
    // unsigned int __thiscall MotionData::Pack(MotionData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionData, void**, uint, uint>)0x00526F80)(ref this, addr, size);
    // int __thiscall MotionData::UnPack(MotionData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionData, void**, uint, int>)0x00527170)(ref this, addr, size);
}

