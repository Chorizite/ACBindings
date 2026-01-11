namespace ACBindings.Internal;

public unsafe struct Archive : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.Archive.tagSetCurrentCoreVersion* SetCurrentCoreVersion = (ACBindings.Internal.Archive.tagSetCurrentCoreVersion*)0x008183B8;

    // Child Types
    public unsafe struct Archive_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForPacking; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive*, byte, void> SetCheckpointing; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive*, void> InitVersionStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive*, void> CreateVersionStack; // function pointer

        // Methods
    }
    public unsafe struct SetVersionRow
    {
        // Base Classes
        public ACBindings.Internal.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.Internal.ArchiveInitializer

        // Child Types
        public unsafe struct SetVersionRow_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive.SetVersionRow*, ACBindings.Internal.Archive*, byte> InitializeArchive; // function pointer

            // Methods
        }

        // Members
        public ACBindings.Internal.ArchiveVersionRow* m_rInitialData;

        // Methods

        /// <summary>Initializes the archive by pushing the SetVersionRow’s initial data as a new version row, provided the archive is not marked with flag 4 and the push succeeds.
        /// <code>Offset: 0x0040AC30
        /// bool __thiscall Archive::SetVersionRow::InitializeArchive(Archive::SetVersionRow*,Archive*)</code>
        /// </summary>
        /// <param name="this">The SetVersionRow instance containing the initial data to apply.</param>
        /// <param name="io_rcArchive">The archive object that will receive the new version row.</param>
        /// <returns>True when the archive was successfully initialized; otherwise false.</returns>
        public byte InitializeArchive(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive.SetVersionRow, ACBindings.Internal.Archive*, byte>)0x0040AC30)(ref this, io_rcArchive);
    }
    // Archive::tagPacking
    public enum tagPacking : byte
    {
        Packing = 0x0
    }
    public unsafe struct tagSetCurrentCoreVersion
    {
        // Base Classes
        public ACBindings.Internal.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.Internal.ArchiveInitializer

        // Child Types
        public unsafe struct tagSetCurrentCoreVersion_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Archive.tagSetCurrentCoreVersion*, ACBindings.Internal.Archive*, byte> InitializeArchive; // function pointer

            // Methods
        }

        // Methods
    }
    // Archive::tagUnpacking
    public enum tagUnpacking : byte
    {
        Unpacking = 0x0
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_flags;
    public ACBindings.Internal.TResult m_hrError;
    public ACBindings.Internal.SmartBuffer m_buffer;
    public uint m_currOffset;
    public System.IntPtr m_pcUserDataHash;
    public ACBindings.Internal.IArchiveVersionStack* m_pVersionStack;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Returns the amount of data currently stored in the archive.
    /// <code>Offset: 0x0040A8D0
    /// unsigned int __thiscall Archive::GetSizeUsed(Archive*)</code>
    /// </summary>
    /// <returns>The current offset within the underlying buffer, representing the used size.</returns>
    public uint GetSizeUsed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint>)0x0040A8D0)(ref this);

    /// <summary>Sets the current offset within the archive's internal buffer.
    /// <code>Offset: 0x0040A8E0
    /// void __thiscall Archive::SetCurrentPosition(Archive*,unsigned int)</code>
    /// </summary>
    /// <param name="i_position">The desired position, in bytes, for the next read or write operation.</param>
    public void SetCurrentPosition(uint i_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint, void>)0x0040A8E0)(ref this, i_position);

    /// <summary>Computes the number of bytes remaining in the archive's internal buffer based on the current offset.
    /// <code>Offset: 0x0040A8F0
    /// unsigned int __thiscall Archive::GetSizeLeft(Archive*)</code>
    /// </summary>
    /// <returns>The amount of data still available for processing within the archive.</returns>
    public uint GetSizeLeft() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint>)0x0040A8F0)(ref this);

    /// <summary>Returns a SmartBuffer that references the archive’s serialized data from offset 0 up to the current write position.
    /// <code>Offset: 0x0040A900
    /// SmartBuffer* __thiscall Archive::GetSerializedBuffer(Archive*,SmartBuffer*)</code>
    /// </summary>
    /// <param name="result">The buffer object to receive the windowed view of the internal data.</param>
    /// <returns>The same SmartBuffer pointer configured to represent the serialized portion of the archive.</returns>
    public ACBindings.Internal.SmartBuffer* GetSerializedBuffer(ACBindings.Internal.SmartBuffer* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, ACBindings.Internal.SmartBuffer*, ACBindings.Internal.SmartBuffer*>)0x0040A900)(ref this, result);

    /// <summary>Creates a sub‑buffer representing the unprocessed portion of the archive starting at the current offset and returns it.
    /// <code>Offset: 0x0040A920
    /// SmartBuffer* __thiscall Archive::GetRemainingBuffer(Archive*,SmartBuffer*)</code>
    /// </summary>
    /// <param name="result">Pointer to a SmartBuffer that receives the view into the archive buffer.</param>
    /// <returns>The same pointer passed in, initialized to the remaining data window.</returns>
    public ACBindings.Internal.SmartBuffer* GetRemainingBuffer(ACBindings.Internal.SmartBuffer* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, ACBindings.Internal.SmartBuffer*, ACBindings.Internal.SmartBuffer*>)0x0040A920)(ref this, result);

    /// <summary>Initializes the archive’s version stack. If a stack already exists, its reference count is increased; otherwise a new stack is created.
    /// <code>Offset: 0x0040A940
    /// void __thiscall Archive::InitVersionStack(Archive*)</code>
    /// </summary>
    public void InitVersionStack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, void>)0x0040A940)(ref this);

    /// <summary>
    /// Retrieves a version identifier from the archive's version stack based on a supplied token, or returns zero if no stack exists.
    /// 
    /// <code>Offset: 0x0040A960
    /// unsigned int __thiscall Archive::GetVersionByToken(Archive*,unsigned int)</code>
    /// </summary>
    /// <param name="i_tokVersion">Token specifying which version to retrieve.</param>
    /// <returns>Unsigned integer representing the requested version; zero indicates failure or absence of a version stack.</returns>
    public uint GetVersionByToken(uint i_tokVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint, uint>)0x0040A960)(ref this, i_tokVersion);

    /// <summary>Enables or disables checkpointing for the archive by setting or clearing the internal flag.
    /// <code>Offset: 0x0040A9D0
    /// void __thiscall Archive::SetCheckpointing(Archive*,bool)</code>
    /// </summary>
    /// <param name="checkpointing">True to enable checkpointing; false to disable.</param>
    public void SetCheckpointing(byte checkpointing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, byte, void>)0x0040A9D0)(ref this, checkpointing);

    /// <summary>Determines whether the archive instance was created using a database loader.
    /// <code>Offset: 0x0040A9F0
    /// bool __thiscall Archive::UsingDBLoader(Archive*)</code>
    /// </summary>
    /// <returns>True if the 0x8000 flag is set in m_flags; otherwise, false.</returns>
    public byte UsingDBLoader() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, byte>)0x0040A9F0)(ref this);

    /// <summary>Sets or clears the DB loader usage flag in the archive.
    /// <code>Offset: 0x0040AA10
    /// void __thiscall Archive::SetDBLoader(Archive*,bool)</code>
    /// </summary>
    /// <param name="using_DBLoader">True to enable DB loader; false to disable it.</param>
    public void SetDBLoader(byte using_DBLoader) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, byte, void>)0x0040AA10)(ref this, using_DBLoader);

    /// <summary>Controls whether the archive stores data on 4‑byte boundaries by setting or clearing a flag in its internal state.
    /// <code>Offset: 0x0040AA30
    /// void __thiscall Archive::SetWordAligned(Archive*,bool)</code>
    /// </summary>
    /// <param name="aligned">True to enable word alignment; false to disable it.</param>
    public void SetWordAligned(byte aligned) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, byte, void>)0x0040AA30)(ref this, aligned);

    /// <summary>Marks the archive as failed by setting an error flag and assigning a default error code.
    /// <code>Offset: 0x0040AA50
    /// void __thiscall Archive::RaiseError(Archive*)</code>
    /// </summary>
    public void RaiseError() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, void>)0x0040AA50)(ref this);

    /// <summary>Determines whether the archive’s data stream aligns on a 4‑byte boundary.
    /// <code>Offset: 0x0040AA60
    /// bool __thiscall Archive::IsWordAligned(Archive*)</code>
    /// </summary>
    /// <returns>True if the internal alignment flag is set; otherwise, false.</returns>
    public byte IsWordAligned() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, byte>)0x0040AA60)(ref this);

    /// <summary>Updates the archive's current version by referencing a version token and an integer identifier.
    /// <code>Offset: 0x0040AA70
    /// bool __thiscall Archive::SetVersionByToken(Archive*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_tokVersion">The token identifying the version to set.</param>
    /// <param name="i_iVersion">The numeric version associated with the token.</param>
    /// <returns>True if the version was successfully set; otherwise, false and records an error in the archive.</returns>
    public byte SetVersionByToken(uint i_tokVersion, uint i_iVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint, uint, byte>)0x0040AA70)(ref this, i_tokVersion, i_iVersion);

    /// <summary>Pushes a version row onto the archive’s internal version stack. If no stack is available, marks an error and assigns an invalid handle to the supplied object.
    /// <code>Offset: 0x0040AAD0
    /// IDClass&lt;_tagVersionHandle,32,0&gt;* __thiscall Archive::PushVersionRow(_DWORD*,IDClass&lt;_tagVersionHandle,32,0&gt;*)</code>
    /// </summary>
    /// <param name="a2">The IDClass instance representing the version handle to be pushed.</param>
    /// <returns>The same IDClass pointer; if the operation fails its id field is set to INVALID_VERSIONHANDLE_0.baseclass_0.id.</returns>
    public ACBindings.Internal.IDClass____tagVersionHandle* PushVersionRow(ACBindings.Internal.IDClass____tagVersionHandle* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, ACBindings.Internal.IDClass____tagVersionHandle*, ACBindings.Internal.IDClass____tagVersionHandle*>)0x0040AAD0)(ref this, a2);

    /// <summary>Pushed a new version row into the archive, delegating to an internal version stack if present. When the archive is in an error state or lacks a stack, marks the supplied handle as invalid.
    /// <code>Offset: 0x0040AB30
    /// IDClass&lt;_tagVersionHandle,32,0&gt;* __thiscall Archive::PushVersionRow(_DWORD*,IDClass&lt;_tagVersionHandle,32,0&gt;*,int)</code>
    /// </summary>
    /// <param name="a2">The version handle object to push onto the archive.</param>
    /// <param name="a3">Additional context or flags influencing the push operation.</param>
    /// <returns>Pointer to the provided version handle after any modifications.</returns>
    public ACBindings.Internal.IDClass____tagVersionHandle* PushVersionRow(ACBindings.Internal.IDClass____tagVersionHandle* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, ACBindings.Internal.IDClass____tagVersionHandle*, int, ACBindings.Internal.IDClass____tagVersionHandle*>)0x0040AB30)(ref this, a2, a3);

    /// <summary>Retrieves a version row by handle from the archive's version stack. Delegates to the underlying version stack implementation if available.
    /// <code>Offset: 0x0040AB90
    /// char __thiscall Archive::GetVersionRowByHandle(_DWORD**,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier for the requested row.</param>
    /// <param name="a3">Additional parameter influencing retrieval, such as sub-index or flags.</param>
    /// <returns>Non‑zero on success; zero when no version stack is present or retrieval fails.</returns>
    public sbyte GetVersionRowByHandle(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, int, int, sbyte>)0x0040AB90)(ref this, a2, a3);

    /// <summary>Provides direct access to a contiguous block of bytes in the archive's internal buffer at the specified position and length without copying them.
    /// <code>Offset: 0x0040AC70
    /// unsigned __int8* __thiscall Archive::PeekBytes(Archive*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_position">Zero‑based offset within the archive where the requested bytes begin.</param>
    /// <param name="i_size">Number of consecutive bytes to retrieve starting from i_position.</param>
    /// <returns>A pointer to the requested byte sequence, or nullptr if the buffer is too small, an error flag has already been set, or the request cannot be satisfied.</returns>
    public byte* PeekBytes(uint i_position, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint, uint, byte*>)0x0040AC70)(ref this, i_position, i_size);

    /// <summary>Retrieves a block of bytes from the archive at the current position, advancing the read offset.
    /// <code>Offset: 0x0040ACF0
    /// unsigned __int8* __thiscall Archive::GetBytes(Archive*,unsigned int)</code>
    /// </summary>
    /// <param name="i_size">Number of bytes to read.</param>
    /// <returns>Pointer to the requested byte sequence, or nullptr if not enough data is available.</returns>
    public byte* GetBytes(uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint, byte*>)0x0040ACF0)(ref this, i_size);

    /// <summary>Aligns the archive's current offset to satisfy alignment requirements for objects of a given size, advancing the cursor and optionally clearing any inserted padding bytes.
    /// <code>Offset: 0x0040AD10
    /// void __thiscall Archive::CheckAlignment(Archive*,unsigned int)</code>
    /// </summary>
    /// <param name="i_objectSize">The size of the object whose natural alignment is required.</param>
    public void CheckAlignment(uint i_objectSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, uint, void>)0x0040AD10)(ref this, i_objectSize);

    /// <summary>Creates a new archive version stack instance and assigns it to the object's m_pVersionStack member. If memory allocation fails, sets m_pVersionStack to null.
    /// <code>Offset: 0x0040AEF0
    /// void __thiscall Archive::CreateVersionStack(Archive*)</code>
    /// </summary>
    public void CreateVersionStack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, void>)0x0040AEF0)(ref this);

    /// <summary>Frees all user data objects stored in the archive, invoking their cleanup routines and deallocating memory.
    /// <code>Offset: 0x0040AF20
    /// void __thiscall Archive::ReleaseUserData(Archive*)</code>
    /// </summary>
    public void ReleaseUserData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, void>)0x0040AF20)(ref this);

    /// <summary>Initializes the archive for packing by setting up its internal buffer, resetting state flags and offset, and invoking the supplied ArchiveInitializer.
    /// <code>Offset: 0x0040AFB0
    /// void __thiscall Archive::InitForPacking(Archive*,const ArchiveInitializer*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_rInitializer">The initializer used to configure the archive’s settings before packing begins.</param>
    /// <param name="i_buffer">The SmartBuffer that will serve as the archive’s data container; if it differs from the current buffer or is not uniquely shared, the existing buffer is released and replaced.</param>
    public void InitForPacking(ACBindings.Internal.ArchiveInitializer* i_rInitializer, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void>)0x0040AFB0)(ref this, i_rInitializer, i_buffer);

    /// <summary>Initializes the Archive instance for unpacking by resetting internal state, assigning a new data buffer, preparing the version stack, and invoking the provided ArchiveInitializer.
    /// <code>Offset: 0x0040B020
    /// void __thiscall Archive::InitForUnpacking(Archive*,const ArchiveInitializer*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_rInitializer">The initializer object used to configure the archive during unpacking.</param>
    /// <param name="i_buffer">The source buffer containing archived data to read from.</param>
    public void InitForUnpacking(ACBindings.Internal.ArchiveInitializer* i_rInitializer, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void>)0x0040B020)(ref this, i_rInitializer, i_buffer);

    /// <summary>Releases the archive's resources, including user data callbacks, buffer memory, and any associated version stack, resetting the object to a clean state.
    /// <code>Offset: 0x0040B060
    /// void __thiscall Archive::~Archive(Archive*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Archive, void>)0x0040B060)(ref this);
}

