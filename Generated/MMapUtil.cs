namespace ACBindings;

// MMapUtil
public unsafe struct MMapUtil : System.IDisposable
{
    // Base Classes
    public ACBindings.DataSource BaseClass_DataSource; // ACBindings.DataSource

    // Child Types
    // MMapUtil_vtbl
    public unsafe struct MMapUtil_vtbl
    {
        // Members
        public System.IntPtr MMapUtil_dtor_0; // function pointer
        public System.IntPtr Close; // function pointer
        public System.IntPtr MMap; // function pointer
        public System.IntPtr GetMappingAddr; // function pointer
        public System.IntPtr GetFileAlreadyExisted; // function pointer

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
    // void __thiscall MMapUtil::~MMapUtil(MMapUtil*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MMapUtil, void>)0x006BD0A0)(ref this);
    // bool __thiscall MMapUtil::GetFileAlreadyExisted(MMapUtil*)
    public byte GetFileAlreadyExisted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MMapUtil, byte>)0x006BD110)(ref this);
    // char* __thiscall MMapUtil::MMap(MMapUtil*,const char*,bool,bool,bool,int,unsigned int,unsigned int)
    public sbyte* MMap(sbyte* filename, byte readOnly, byte fMustAlreadyExist, byte nukeOldFile, int sizeNeeded, uint fileOffsetHighOrder32Bits, uint fileOffsetLowOrder32Bits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MMapUtil, sbyte*, byte, byte, byte, int, uint, uint, sbyte*>)0x006BD140)(ref this, filename, readOnly, fMustAlreadyExist, nukeOldFile, sizeNeeded, fileOffsetHighOrder32Bits, fileOffsetLowOrder32Bits);
}

