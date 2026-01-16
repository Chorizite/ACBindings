namespace ACBindings.Internal;


/// <summary>Manages disk‑based persistence of data blocks by coordinating block allocation, B‑tree index maintenance, and file metadata. Handles read/write access control, supports optional compression, and tracks free space while ensuring thread safety.</summary>
public unsafe struct DiskController : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DiskConBase BaseClass_DiskConBase; // ACBindings.Internal.DiskConBase

    // Child Types
    public unsafe struct DiskController_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, void> DiskController_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DiskConInitInfo*, byte> InitFile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, int> HowmuchFreeSpace; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> LoadIterationList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> SaveIterationList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DATFILE_TYPE> GetDataset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, uint> GetSubset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ulong> GetDatFileID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> IsInitialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> IsReadOnly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, byte> IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DatIDStamp*, void> SetDatIDStamp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*> GetDatIDStamp; // function pointer
        public System.IntPtr GetFilename;
        public System.IntPtr GetDataSize;
        public System.IntPtr GetUncompressedDataSize;
        public System.IntPtr GetDatestamp;
        public System.IntPtr GetIteration;
        public System.IntPtr GetVersion;
        public System.IntPtr GetIsCompressed;
        public System.IntPtr LoadDataEx;
        public System.IntPtr SaveAndCompressData;
        public System.IntPtr SavePreCompressedData;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte> SaveDataEx; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> AttemptToCompress; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> Decompress; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CLBlockAllocator block_man_m;
    public ACBindings.Internal.BTree did_tree_m;
    public ACBindings.Internal.PStringBase__sbyte filename_m;
    public ACBindings.Internal.DiskFileInfo_t file_info_m;

    // Generated Constructor
    public DiskController() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Computes the total free space on the disk by multiplying block size with number of free blocks.
    /// <code>Offset: 0x004F8E00
    /// int __thiscall DiskController::HowmuchFreeSpace(DiskController*)</code>
    /// </summary>
    /// <returns>An integer representing the available free space in bytes (or appropriate units).</returns>
    public int HowmuchFreeSpace() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int>)0x004F8E00)(ref this);

    /// <summary>Creates and returns a DatIDStamp representing the disk's file identifier using the controller's file information.
    /// <code>Offset: 0x004F8E10
    /// DatIDStamp* __thiscall DiskController::GetDatIDStamp(DiskController*,DatIDStamp*)</code>
    /// </summary>
    /// <param name="result">Pointer to a DatIDStamp structure that will receive the stamp data.</param>
    /// <returns>The same pointer passed in, now populated with the stamp values.</returns>
    public ACBindings.Internal.DatIDStamp* GetDatIDStamp(ACBindings.Internal.DatIDStamp* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*>)0x004F8E10)(ref this, result);

    /// <summary>Retrieves the internal filename string stored within the disk controller instance.
    /// <code>Offset: 0x004F8E30
    /// char* __thiscall DiskController::GetFilename(char*)</code>
    /// </summary>
    /// <returns>A pointer to the character buffer containing the filename associated with this DiskController.</returns>
    public sbyte* GetFilename() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, sbyte*>)0x004F8E30)(ref this);

    /// <summary>Retrieves the master map identifier stored in the DiskController instance and places it into the provided output pointer.
    /// <code>Offset: 0x004F8E40
    /// _DWORD* __thiscall DiskController::GetMasterMapDID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD where the master map identifier will be written.</param>
    /// <returns>The same pointer supplied as a2, now containing the retrieved identifier.</returns>
    public int* GetMasterMapDID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int*, int*>)0x004F8E40)(ref this, a2);

    /// <summary>Closes the disk controller, persisting the BTree when writable, closing the underlying data file, destroying tree structures, and resetting the initialized flag.
    /// <code>Offset: 0x00671360
    /// bool __thiscall DiskController::Close(DiskController*)</code>
    /// </summary>
    /// <returns>True if the close operation succeeded; otherwise false.</returns>
    public byte Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, byte>)0x00671360)(ref this);

    /// <summary>Retrieves the list of member identifiers associated with this disk controller into the supplied array.
    /// <code>Offset: 0x006713A0
    /// char __thiscall DiskController::GetMembers(int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer that will receive the member IDs.</param>
    /// <returns>A status code indicating whether the operation succeeded (non‑zero) or failed (zero).</returns>
    public sbyte GetMembers(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int*, sbyte>)0x006713A0)(ref this, a2);

    /// <summary>Sets the data ID stamp for the disk controller unless it operates in read‑only mode. Copies the supplied stamp into the file info's version number and, if the controller has been initialized, writes the associated BTree to persistent storage.
    /// <code>Offset: 0x006713B0
    /// void __thiscall DiskController::SetDatIDStamp(DiskController*,DatIDStamp*)</code>
    /// </summary>
    /// <param name="stamp">The DatIDStamp containing major and minor version numbers to apply.</param>
    public void SetDatIDStamp(ACBindings.Internal.DatIDStamp* stamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.DatIDStamp*, void>)0x006713B0)(ref this, stamp);

    /// <summary>Saves data associated with the provided file information into persistent storage, applying the specified size and flag parameters.
    /// <code>Offset: 0x006714E0
    /// int __thiscall DiskController::SaveData(void*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">The amount of data (in elements or bytes) to write.</param>
    /// <param name="a3">Pointer to a structure containing file metadata used during the save operation.</param>
    /// <param name="a4">Flags that influence how the data is written (e.g., overwrite mode, compression).</param>
    /// <returns>Returns a non‑zero value on success; zero or negative indicates an error.</returns>
    public int SaveData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int, int>)0x006714E0)(ref this, a2, a3, a4);

    /// <summary>Writes and compresses a data segment identified by the supplied parameters into persistent storage. The operation prepares an internal descriptor structure before delegating to the controller’s core save routine.
    /// <code>Offset: 0x00671530
    /// int __thiscall DiskController::SaveAndCompressData(void*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">The block identifier or size of the data to be saved.</param>
    /// <param name="a3">A pointer to the source data or its metadata used during compression.</param>
    /// <param name="a4">Compression flags controlling the algorithm applied.</param>
    /// <returns>Zero on success; a negative value indicates an error condition.</returns>
    public int SaveAndCompressData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int, int>)0x00671530)(ref this, a2, a3, a4);

    /// <summary>Saves pre‑compressed data associated with the disk controller using supplied parameters.
    /// <code>Offset: 0x00671580
    /// int __thiscall DiskController::SavePreCompressedData(void*,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier or flags influencing how the data is handled.</param>
    /// <param name="a3">Pointer to the source data block; its header value contributes to internal state.</param>
    /// <param name="a4">Additional parameter, often size or mode flag for saving.</param>
    /// <returns>Result code from the underlying save operation; zero typically indicates success.</returns>
    public int SavePreCompressedData(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int, int>)0x00671580)(ref this, a2, a3, a4);

    /// <summary>Compresses an uncompressed cache pack into a new packed format, storing the result in the provided output structure.
    /// <code>Offset: 0x006715D0
    /// bool __thiscall DiskController::AttemptToCompress(DiskController*,const Cache_Pack_t*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="i_cpUncompressed">The cache pack containing data to be compressed.</param>
    /// <param name="o_cpCompressed">A pre‑allocated Cache_Pack_t that will receive the compressed buffer and updated size metadata.</param>
    /// <returns>True if compression succeeds; otherwise, false when input is too small or compression fails.</returns>
    public byte AttemptToCompress(ACBindings.Internal.Cache_Pack_t* i_cpUncompressed, ACBindings.Internal.Cache_Pack_t* o_cpCompressed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte>)0x006715D0)(ref this, i_cpUncompressed, o_cpCompressed);

    /// <summary>Calculates the block count needed for a requested byte size and expands the underlying file or removes old data until enough free blocks remain.
    /// <code>Offset: 0x00671730
    /// bool __thiscall DiskController::CheckRoom(DiskController*,int)</code>
    /// </summary>
    /// <param name="size_l">The number of bytes that must be stored in the disk controller.</param>
    /// <returns>True after ensuring sufficient room; always returns true.</returns>
    public byte CheckRoom(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, byte>)0x00671730)(ref this, size_l);

    /// <summary>Attempts to obtain a datestamp for the specified identifier, but always returns zero.
    /// <code>Offset: 0x00671780
    /// int __thiscall DiskController::GetDatestamp(void*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the disk item whose datestamp is requested.</param>
    /// <returns>Zero, indicating no valid timestamp is returned by this function.</returns>
    public int GetDatestamp(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x00671780)(ref this, a2);

    /// <summary>Retrieves the version number associated with the specified identifier from the disk controller, returning it as an unsigned integer or zero on failure.
    /// <code>Offset: 0x006717D0
    /// unsigned int __thiscall DiskController::GetVersion(int*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier for which to obtain a version number.</param>
    /// <returns>High-order word of the retrieved version if successful; otherwise 0.</returns>
    public uint GetVersion(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, uint>)0x006717D0)(ref this, a2);

    /// <summary>Checks whether the specified disk entry is stored in compressed form.
    /// <code>Offset: 0x00671830
    /// char __thiscall DiskController::GetIsCompressed(int*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the disk entry to query.</param>
    /// <returns>Non-zero if the entry is compressed; otherwise zero.</returns>
    public sbyte GetIsCompressed(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, sbyte>)0x00671830)(ref this, a2);

    /// <summary>Retrieves the iteration number for a given data ID, but always returns 0.
    /// <code>Offset: 0x00671890
    /// int __thiscall DiskController::GetIteration(void*,int)</code>
    /// </summary>
    /// <param name="a2">Data identifier whose iteration is requested.</param>
    /// <returns>Zero. The function does not expose an iteration value through its return type.</returns>
    public int GetIteration(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x00671890)(ref this, a2);

    /// <summary>Invokes an internal query for the data block identified by the supplied integer and returns zero when successful or –1 if the operation fails.
    /// <code>Offset: 0x006718E0
    /// int __thiscall DiskController::GetDataSize(void*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the data block to query.</param>
    /// <returns>Zero on success; –1 indicates failure.</returns>
    public int GetDataSize(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x006718E0)(ref this, a2);

    /// <summary>Returns the uncompressed data size for a specified block ID stored by the disk controller. If the block is already uncompressed, zero is returned. When the block cannot be located or an error occurs during retrieval, –1 is returned.
    /// <code>Offset: 0x00671930
    /// int __thiscall DiskController::GetUncompressedDataSize(int*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the block whose uncompressed size is requested.</param>
    /// <returns>Size in bytes of the uncompressed data for the specified block; 0 if already uncompressed; –1 on failure.</returns>
    public int GetUncompressedDataSize(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int>)0x00671930)(ref this, a2);

    /// <summary>Decompresses a cache pack that contains compressed data and stores the result in the supplied output structure.
    /// <code>Offset: 0x00671A20
    /// bool __thiscall DiskController::Decompress(DiskController*,const Cache_Pack_t*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="i_cpCompressed">Input cache pack containing compressed data.</param>
    /// <param name="o_cpUncompressed">Output cache pack to receive decompressed data.</param>
    /// <returns>True if decompression succeeded; otherwise, false.</returns>
    public byte Decompress(ACBindings.Internal.Cache_Pack_t* i_cpCompressed, ACBindings.Internal.Cache_Pack_t* o_cpUncompressed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte>)0x00671A20)(ref this, i_cpCompressed, o_cpUncompressed);

    /// <summary>Loads data identified by the supplied parameters into memory through an internal virtual handler, initializing a parameter block with default values before invocation.
    /// <code>Offset: 0x00671B20
    /// int __thiscall DiskController::LoadData(void*,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier or key for the data to load.</param>
    /// <param name="a3">Additional options or sub‑identifier influencing the load operation.</param>
    /// <returns>Status code from the underlying loader: non‑negative on success, negative on failure.</returns>
    public int LoadData(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, int>)0x00671B20)(ref this, a2, a3);

    /// <summary>Loads block metadata from the controller’s B‑Tree and optionally reads its data into a cache pack. The operation is modulated by flag bits that can skip the data load, suppress buffer reconfiguration, or bypass an optional post‑load callback.
    /// <code>Offset: 0x00671B60
    /// char __thiscall DiskController::LoadDataEx(int,int,Cache_Pack_t*,LONG*,char)</code>
    /// </summary>
    /// <param name="a2">Key identifying the block to retrieve within the controller’s B‑Tree.</param>
    /// <param name="nNumberOfBytesToRead">Cache_Pack_t object that receives the loaded data; its version field is set from the metadata and, unless flags prevent it, its buffer is reconfigured to match the block size reported in the header.</param>
    /// <param name="bShortRead">Output buffer (at least 24 bytes) populated with the block’s header information extracted from the B‑Tree node.</param>
    /// <param name="a5">Control flags:
    ///     • Bit 1 (value 2): causes an immediate return after copying metadata, skipping data load and all further processing.
    ///     • Bits 0 and 2 together suppress reconfiguration of the cache buffer and skip any post‑load callback; bit 0 alone also suppresses the callback if it is requested by the block’s header.</param>
    /// <returns>Non‑zero on success (metadata copied, data loaded or early return), zero when the node is missing, the load fails, or the optional post‑load callback returns false.</returns>
    public sbyte LoadDataEx(int a2, ACBindings.Internal.Cache_Pack_t* nNumberOfBytesToRead, int* bShortRead, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, ACBindings.Internal.Cache_Pack_t*, int*, sbyte, sbyte>)0x00671B60)(ref this, a2, nNumberOfBytesToRead, bShortRead, a5);

    /// <summary>Determines whether the specified identifier exists within this DiskController's data set, optionally returning additional information via an output buffer.
    /// <code>Offset: 0x00671CB0
    /// int __thiscall DiskController::IsMember(void*,int,int*)</code>
    /// </summary>
    /// <param name="a2">The identifier to look up in the controller's internal BTree.</param>
    /// <param name="a3">Optional pointer to a buffer that receives detailed lookup data; if null, a temporary buffer is used internally.</param>
    /// <returns>Non-zero if the identifier is present; zero otherwise.</returns>
    public int IsMember(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int*, int>)0x00671CB0)(ref this, a2, a3);

    /// <summary>Deletes the data entry identified by the specified key when the disk controller is writable, optionally verifying that an associated field does not exceed a given threshold before removal.
    /// <code>Offset: 0x00671D00
    /// bool __thiscall DiskController::DeleteData(int,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">The unique identifier of the data record to delete.</param>
    /// <param name="a3">An optional limit; if non‑zero, deletion occurs only when the record’s stored value is less than or equal to this value. If zero, the limit check is omitted.</param>
    /// <returns>True if the record was found and removed successfully; otherwise false (e.g., controller read‑only, key not present, or threshold not met).</returns>
    public byte DeleteData(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, uint, int, byte>)0x00671D00)(ref this, a2, a3);

    /// <summary>Sets the DiskController's master map identifier and records the previous value in the supplied IDClass object, unless the controller is read‑only, in which case it stores an INVALID_DID constant.
    /// <code>Offset: 0x00671D40
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall DiskController::SetMasterMapDID(int,IDClass&lt;_tagDataID,32,0&gt;*,int)</code>
    /// </summary>
    /// <param name="a2">IDClass instance that receives the prior master map DID (or INVALID_DID when read‑only).</param>
    /// <param name="a3">New master map DID to assign.</param>
    /// <returns>Reference to the supplied IDClass object.</returns>
    public ACBindings.Internal.IDClass____tagDataID* SetMasterMapDID(ACBindings.Internal.IDClass____tagDataID* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.IDClass____tagDataID*, int, ACBindings.Internal.IDClass____tagDataID*>)0x00671D40)(ref this, a2, a3);

    /// <summary>Loads an iteration list from the controller's data file, deserializing it into the supplied CMostlyConsecutiveIntSet instance.
    /// <code>Offset: 0x00671D80
    /// bool __thiscall DiskController::LoadIterationList(DiskController*,CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    /// <param name="Iters">The set to receive the loaded iterations; must not be null.</param>
    /// <returns>True if the list was successfully loaded and unpacked without errors; otherwise false.</returns>
    public byte LoadIterationList(ACBindings.Internal.CMostlyConsecutiveIntSet* Iters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte>)0x00671D80)(ref this, Iters);

    /// <summary>Saves the given set of iterations to disk by serializing it into a cache pack and invoking the base class save routine.
    /// <code>Offset: 0x00671E80
    /// bool __thiscall DiskController::SaveIterationList(DiskController*,CMostlyConsecutiveIntSet*)</code>
    /// </summary>
    /// <param name="Iters">The collection of iteration indices to persist.</param>
    /// <returns>True if the data was successfully written; otherwise false.</returns>
    public byte SaveIterationList(ACBindings.Internal.CMostlyConsecutiveIntSet* Iters) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte>)0x00671E80)(ref this, Iters);

    /// <summary>Initializes a DiskController instance by configuring its internal state, allocating block memory, creating an identifier tree, and preparing file information.
    /// <code>Offset: 0x00671F80
    /// void __thiscall DiskController::DiskController(DiskController*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, void>)0x00671F80)(ref this);

    /// <summary>Finalizes the DiskController by persisting changes to disk if it was initialized and writable, then releases all allocated resources and resets internal state.
    /// <code>Offset: 0x00671FE0
    /// void __thiscall DiskController::~DiskController(DiskController*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, void>)0x00671FE0)(ref this);

    /// <summary>Saves or updates a BTEntry using the supplied Cache_Pack_t and flag options, handling versioning, timestamps, and BTree consistency.
    /// <code>Offset: 0x00672060
    /// bool __thiscall DiskController::SaveDataEx(DiskController*,BTEntry*,Cache_Pack_t*,unsigned int)</code>
    /// </summary>
    /// <param name="io_entNew">The entry to write or update in the disk controller's tree structure.</param>
    /// <param name="i_cpUser">Cache pack containing the data to be stored or retrieved during the operation.</param>
    /// <param name="dwFlags">Bitmask specifying the operation mode (e.g., load iteration list, save iteration list) and additional options.</param>
    /// <returns>True if the entry was successfully updated; otherwise false.</returns>
    public byte SaveDataEx(ACBindings.Internal.BTEntry* io_entNew, ACBindings.Internal.Cache_Pack_t* i_cpUser, uint dwFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte>)0x00672060)(ref this, io_entNew, i_cpUser, dwFlags);

    /// <summary>Deletes entries whose identifiers satisfy both the subset mask (a2) and the pattern mask (a3). When a3 is zero, the function succeeds without removing any items. The operation fails—returning 0—if the controller is read‑only or if no entries match the masks.
    /// <code>Offset: 0x006722B0
    /// char __thiscall DiskController::DeleteDataByMask(char*,int,int)</code>
    /// </summary>
    /// <param name="a2">Mask selecting which data subsets are considered during deletion.</param>
    /// <param name="a3">Pattern mask applied to identifiers; zero causes a no‑op success.</param>
    /// <returns>Non‑zero (1) when at least one entry is deleted or a3 equals zero and the controller allows modification; 0 if the controller is read‑only or no entries match the masks.</returns>
    public sbyte DeleteDataByMask(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, int, int, sbyte>)0x006722B0)(ref this, a2, a3);

    /// <summary>Initializes a disk data file using the provided initialization information. Opens an existing file or creates a new one based on flags, validates compatibility with engine/game versions, loads or recovers its B‑Tree structure, and stores related metadata.
    /// <code>Offset: 0x006723D0
    /// bool __thiscall DiskController::InitFile(DiskController*,DiskConInitInfo*)</code>
    /// </summary>
    /// <param name="info_r">Pointer to DiskConInitInfo containing file path, open flags, block size, data set identifiers, and version numbers.</param>
    /// <returns>True if the file was successfully opened or created and initialized; otherwise false.</returns>
    public byte InitFile(ACBindings.Internal.DiskConInitInfo* info_r) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DiskController, ACBindings.Internal.DiskConInitInfo*, byte>)0x006723D0)(ref this, info_r);
}

