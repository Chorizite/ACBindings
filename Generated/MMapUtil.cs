namespace ACBindings.Internal;

public unsafe struct MMapUtil : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DataSource BaseClass_DataSource; // ACBindings.Internal.DataSource

    // Child Types
    public unsafe struct MMapUtil_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, void> MMapUtil_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, void> Close; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, sbyte*, byte, byte, byte, int, uint, uint, sbyte*> MMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, sbyte*> GetMappingAddr; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, byte> GetFileAlreadyExisted; // function pointer

        // Methods
    }

    // Members
    public byte fFileOpen_;
    public byte fFileAlreadyExisted_;
    public sbyte* loadDataFileAddr_;
    public System.IntPtr loadDataFile_;
    public System.IntPtr loadDataFileMapping_;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006BD0A0
    /// void __thiscall MMapUtil::~MMapUtil(MMapUtil*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MMapUtil, void>)0x006BD0A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BD110
    /// bool __thiscall MMapUtil::GetFileAlreadyExisted(MMapUtil*)</code>
    /// </summary>
    public byte GetFileAlreadyExisted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MMapUtil, byte>)0x006BD110)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BD140
    /// char* __thiscall MMapUtil::MMap(MMapUtil*,const char*,bool,bool,bool,int,unsigned int,unsigned int)</code>
    /// </summary>
    public sbyte* MMap(sbyte* filename, byte readOnly, byte fMustAlreadyExist, byte nukeOldFile, int sizeNeeded, uint fileOffsetHighOrder32Bits, uint fileOffsetLowOrder32Bits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MMapUtil, sbyte*, byte, byte, byte, int, uint, uint, sbyte*>)0x006BD140)(ref this, filename, readOnly, fMustAlreadyExist, nukeOldFile, sizeNeeded, fileOffsetHighOrder32Bits, fileOffsetLowOrder32Bits);
}

