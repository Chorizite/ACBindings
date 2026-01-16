namespace ACBindings.Internal;


/// <summary>Manages a memory‑mapped file, tracking its open status, existence, and related pointers for efficient data access.</summary>
public unsafe struct MMapUtil : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DataSource BaseClass_DataSource; // ACBindings.Internal.DataSource

    // Child Types
    public unsafe struct MMapUtil_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, void> MMapUtil_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, void> Close; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, sbyte*, byte, byte, byte, int, uint, uint, sbyte*> MMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, sbyte*> GetMappingAddr; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MMapUtil*, byte> GetFileAlreadyExisted; // function pointer

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

    /// <summary>Releases resources associated with the memory‑mapped file, closing handles and unmapping views when a file is open, then resets the base DataSource state.
    /// <code>Offset: 0x006BD0A0
    /// void __thiscall MMapUtil::~MMapUtil(MMapUtil*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MMapUtil, void>)0x006BD0A0)(ref this);

    /// <summary>Reports whether the data file mapped by this instance existed prior to opening.
    /// <code>Offset: 0x006BD110
    /// bool __thiscall MMapUtil::GetFileAlreadyExisted(MMapUtil*)</code>
    /// </summary>
    /// <returns>True if the file already existed; otherwise, false.</returns>
    public byte GetFileAlreadyExisted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MMapUtil, byte>)0x006BD110)(ref this);

    /// <summary>Maps the specified file into memory with optional creation constraints, access mode, and offset control.
    /// <code>Offset: 0x006BD140
    /// char* __thiscall MMapUtil::MMap(MMapUtil*,const char*,bool,bool,bool,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="filename">Path of the file to map.</param>
    /// <param name="readOnly">Open the file in read‑only mode when true; otherwise open for read/write.</param>
    /// <param name="fMustAlreadyExist">If true, fail if the file does not already exist.</param>
    /// <param name="nukeOldFile">When true, attempt to create a new file only if it does not yet exist; mapping fails if an existing file is present.</param>
    /// <param name="sizeNeeded">For read/write mappings, extend the file by writing four zero bytes at this offset before mapping.</param>
    /// <param name="fileOffsetHighOrder32Bits">High 32 bits of the file offset from which the view starts.</param>
    /// <param name="fileOffsetLowOrder32Bits">Low 32 bits of the file offset from which the view starts.</param>
    /// <returns>A pointer to the base address of the mapped region, or null if mapping fails.</returns>
    public sbyte* MMap(sbyte* filename, byte readOnly, byte fMustAlreadyExist, byte nukeOldFile, int sizeNeeded, uint fileOffsetHighOrder32Bits, uint fileOffsetLowOrder32Bits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MMapUtil, sbyte*, byte, byte, byte, int, uint, uint, sbyte*>)0x006BD140)(ref this, filename, readOnly, fMustAlreadyExist, nukeOldFile, sizeNeeded, fileOffsetHighOrder32Bits, fileOffsetLowOrder32Bits);
}

