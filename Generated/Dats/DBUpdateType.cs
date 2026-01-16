namespace ACBindings.Internal;


/// <summary>Central cache manager coordinating asynchronous data access, DDD operations, and disk controller lookup within the client’s database system.</summary>
/// <remarks>It extends ThreadedCache, manages plugins for distributed data download (DDD) status reporting, tracks pending downloads and early saves, and exposes region/language configuration to the runtime.</remarks>
/// 
/// <member name="baseclass_0">
///   <summary>ThreadedCache base providing worker thread infrastructure for asynchronous cache requests.</summary>
/// </member>
/// 
/// <member name="baseclass_1d4">
///   <summary>CPluginManagerTemplate&lt;CDDDStatusPlugin&gt; that registers DDD status plugins and dispatches DDDEvent notifications.</summary>
/// </member>
/// 
/// <member name="m_DatFiles">
///   <summary>SmartArray&lt;DiskController*,1&gt; holding active disk controllers for loaded data files.</summary>
/// </member>
/// 
/// <member name="m_fReadOnly">
///   <summary>Indicates whether the cache operates in read‑only mode, preventing modifications to cached data.</summary>
/// </member>
/// 
/// <member name="m_fEngineOnly">
///   <summary>Flags engine‑only operation; when true only engine resources are loaded and used.</summary>
/// </member>
/// 
/// <member name="m_ridDDDRegion">
///   <summary>The current Distributed Data Download (DDD) region identifier, used to route data requests appropriately.</summary>
/// </member>
/// 
/// <member name="m_DDDState">
///   <summary>Enumeration representing the current state of the DDD subsystem (idle, patching, interrogation, etc.).</summary>
/// </member>
/// 
/// <member name="m_MissingIters">
///   <summary>SmartArray&lt;MissingIteration,1&gt; tracking data iterations that are missing during a DDD session.</summary>
/// </member>
/// 
/// <member name="m_PendingDownloads">
///   <summary>AutoGrowHashTable&lt;QualifiedDataID,MissingIteration*&gt; mapping pending download identifiers to their corresponding missing iteration records.</summary>
/// </member>
/// 
/// <member name="m_DatFileByIDTable">
///   <summary>HashTable&lt;unsigned __int64,DiskController*,0&gt; providing fast lookup of disk controllers by data file ID.</summary>
/// </member>
/// 
/// <member name="m_EarlySaves">
///   <summary>SmartArray&lt;QualifiedDataID,1&gt; storing identifiers of data that have been saved early in a DDD session.</summary>
/// </member>
/// 
/// <member name="m_cbEarlySaves">
///   <summary>Total size, in bytes, of data stored in m_EarlySaves during the current DDD operation.</summary>
/// </member>
/// 
/// <member name="m_eNameRuleLanguage">
///   <summary>Language code used for resolving name rules and localizing database entries.</summary>
/// </member>
/// 
/// <member name="m_pNetQueue">
///   <summary>Pointer to the network queue object that handles outgoing asynchronous requests.</summary>
/// </member>
/// 
/// <member name="m_strDatFilePath">
///   <summary>PStringBase&lt;unsigned short&gt; holding the current data file path used for disk controller initialization.</summary>
/// </member>
public unsafe struct CLCache : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ThreadedCache BaseClass_ThreadedCache; // ACBindings.Internal.ThreadedCache
    public ACBindings.Internal.CPluginManagerTemplate___CDDDStatusPlugin BaseClass_CPluginManagerTemplate; // ACBindings.Internal.CPluginManagerTemplate___CDDDStatusPlugin

    // Child Types
    public unsafe struct CLCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DBCache_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DBCache.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> ResetCache; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, int, int, uint, ACBindings.Internal.DBObj*> GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES> PreFetch; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DatIDStamp*, byte> InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte, byte> SetShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> IsLoader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte> SetRegion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> UnloadCellData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> AskForLastWords; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte, byte> SetLanguageInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DestroyObjectCaches; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, void> StopThread; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> WorkerExecuteRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncGetRequest*, void> WorkerExecuteGetRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncSaveRequest*, void> WorkerExecuteSaveRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncPurgeRequest*, void> WorkerExecutePurgeRequest; // function pointer
        public System.IntPtr Init;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, void> Init_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.AsyncContext*> AsyncSaveDDDMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> WorkerExecuteBeginDDDRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> OnBeginDDDRequestFinished; // function pointer

        // Methods
    }

    /// <summary>
    /// Initiates an asynchronous DDD process in the CLCache subsystem, extending AsyncCache::CAsyncRequest to handle callbacks and reference management for the request lifecycle.
    /// </summary>
    public unsafe struct CAsyncBeginDDDRequest
    {
        // Base Classes
        public ACBindings.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.Internal.AsyncCache.CAsyncRequest

        // Child Types
        public unsafe struct CAsyncBeginDDDRequest_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> CLCache; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, byte> bAllDependanciesDone; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, byte> ReadyToUnhash; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> ReleaseDBObj; // function pointer

            // Methods
        }

        // Methods
    }
    // CLCache::CCLCacheAsyncOperation
    public enum CCLCacheAsyncOperation : byte
    {
        MM_3h = 0x3,
        opAsyncBeginDDD = 0x3,
        opCLCacheNextAsyncOperation = 0x4
    }
    // CLCache::DatFileIndex
    public enum DatFileIndex : byte
    {
        PortalDatIndex = 0x0,
        LocalDatIndex = 0x1,
        CellDatIndex = 0x2,
        HighResDatIndex = 0x3,
        nDatFiles = 0x4
    }

    // Members
    public ACBindings.Internal.SmartArray___DiskController_ptr m_DatFiles;
    public byte m_fReadOnly;
    public byte m_fEngineOnly;
    public uint m_ridDDDRegion;
    public ACBindings.Internal._F43682D933327F9F3CA6C70AFCFC5243 m_DDDState;
    public ACBindings.Internal.SmartArray___MissingIteration m_MissingIters;
    public ACBindings.Internal.AutoGrowHashTable___QualifiedDataID___MissingIteration_ptr m_PendingDownloads;
    public ACBindings.Internal.HashTable__ulong___DiskController_ptr m_DatFileByIDTable;
    public ACBindings.Internal.SmartArray___QualifiedDataID m_EarlySaves;
    public uint m_cbEarlySaves;
    public uint m_eNameRuleLanguage;
    public System.IntPtr m_pNetQueue;
    public ACBindings.Internal.PStringBase__ushort m_strDatFilePath;

    // Generated Constructor
    public CLCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Resets the cache by clearing its internal DDD state and delegating to the base database cache reset routine.
    /// <code>Offset: 0x004F7F40
    /// void __thiscall CLCache::ResetCache(CLCache*)</code>
    /// </summary>
    public void ResetCache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004F7F40)(ref this);

    /// <summary>Stores the supplied network queue reference into the cache instance and returns it.
    /// <code>Offset: 0x004F7F70
    /// int __thiscall CLCache::SetNetQueue(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Reference to the network queue used by the cache.</param>
    /// <returns>The value of the network queue after assignment.</returns>
    public int SetNetQueue(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, int, int>)0x004F7F70)(ref this, a2);

    /// <summary>Processes an asynchronous cache request, releasing it when its operation code equals 3 and delegating normal requests to the ThreadedCache worker.
    /// <code>Offset: 0x004F7F80
    /// void __thiscall CLCache::WorkerExecuteRequest(CLCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="pReq">The async cache request to handle.</param>
    public void WorkerExecuteRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x004F7F80)(ref this, pReq);

    /// <summary>Handles finished asynchronous cache requests; for operation code 3, invokes a custom handler with the dat file path, otherwise forwards to the base AsyncCache implementation.
    /// <code>Offset: 0x004F7FA0
    /// void __thiscall CLCache::OnRequestFinished(CLCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="pReq">The completed async request that triggered this callback.</param>
    public void OnRequestFinished(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x004F7FA0)(ref this, pReq);

    /// <summary>
    /// Retrieves the requested interface from a CLCache instance by matching the provided GUID and returns the result through an output parameter.
    /// 
    /// <code>Offset: 0x004F8380
    /// TResult* __thiscall CLCache::QueryInterface(CLCache*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Pointer to a TResult structure that receives the status code of the operation; zero indicates success.</param>
    /// <param name="i_rInterfaceType">GUID specifying the desired interface type.</param>
    /// <param name="o_ppOutInterface">Receives the pointer to the requested interface if it is found within the cache.</param>
    /// <returns>Returns the same TResult pointer supplied in the result parameter, containing the operation status.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rInterfaceType, void** o_ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x004F8380)(ref this, result, i_rInterfaceType, o_ppOutInterface);

    /// <summary>Processes a begin DDD request by handling pending missing iterations, retrieving or purging associated data from the cache, and marking the operation as successful.
    /// <code>Offset: 0x004F8430
    /// void __thiscall CLCache::WorkerExecuteBeginDDDRequest(CLCache*,CLCache::CAsyncBeginDDDRequest*)</code>
    /// </summary>
    /// <param name="pReq">The asynchronous begin DDD request object to be completed. The function sets its Result field upon completion.</param>
    public void WorkerExecuteBeginDDDRequest(ACBindings.Internal.CLCache.CAsyncBeginDDDRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void>)0x004F8430)(ref this, pReq);

    /// <summary>Retrieves the data ID stamp from the primary disk file and copies it into the supplied structure.
    /// <code>Offset: 0x004F8570
    /// bool __thiscall CLCache::InqDatIDStamp(CLCache*,DatIDStamp*)</code>
    /// </summary>
    /// <param name="id_vstamp">Receives the retrieved DatIDStamp; must not be null.</param>
    /// <returns>True if a disk controller is available, otherwise false.</returns>
    public byte InqDatIDStamp(ACBindings.Internal.DatIDStamp* id_vstamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DatIDStamp*, byte>)0x004F8570)(ref this, id_vstamp);

    /// <summary>Serializes the supplied message data and attempts to deliver it to the database; updates the provided result with a status code.
    /// <code>Offset: 0x004F85B0
    /// TResult* __thiscall CLCache::AdoptAndDeliverMessage(CLCache*,TResult*,FakeMessageData*)</code>
    /// </summary>
    /// <param name="result">The TResult object that receives the operation status (0 for success, -2147467259 on failure).</param>
    /// <param name="i_FMD">The FakeMessageData instance to be serialized and sent.</param>
    /// <returns>The same TResult pointer passed in, now containing the result code of the delivery attempt.</returns>
    public ACBindings.Internal.TResult* AdoptAndDeliverMessage(ACBindings.Internal.TResult* result, ACBindings.Internal.FakeMessageData* i_FMD) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.TResult*, ACBindings.Internal.FakeMessageData*, ACBindings.Internal.TResult*>)0x004F85B0)(ref this, result, i_FMD);

    /// <summary>Initiates an asynchronous request to obtain data identified by the provided QualifiedDataID from external sources when a PacketController instance is available.
    /// <code>Offset: 0x004F8C50
    /// bool __thiscall CLCache::AsyncGetFromOtherSources(CLCache*,const QualifiedDataID*,DBOCache*)</code>
    /// </summary>
    /// <param name="qdid">The identifier for the data object that should be retrieved asynchronously.</param>
    /// <param name="pObjCache">An optional cache where fetched objects may be stored; this parameter is currently unused by the function.</param>
    /// <returns>True if the request was dispatched (PacketController instance exists); otherwise false.</returns>
    public byte AsyncGetFromOtherSources(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, byte>)0x004F8C50)(ref this, qdid, pObjCache);

    /// <summary>Notifies all registered DDD status plugins of a DDDEvent, passing along the event identifier and associated byte count.
    /// <code>Offset: 0x004F8CB0
    /// void __thiscall CLCache::NotifyDDDEvent(CLCache*,DDDEvent,unsigned int)</code>
    /// </summary>
    /// <param name="EventNum">Identifier for the DDD event to be propagated.</param>
    /// <param name="nBytes">Size in bytes related to the event payload.</param>
    public void NotifyDDDEvent(ACBindings.Internal.DDDEvent EventNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DDDEvent, uint, void>)0x004F8CB0)(ref this, EventNum, nBytes);

    /// <summary>Queues a DDD data message for asynchronous storage by packing its contents into a SmartBuffer and enqueuing it with the cache’s async request queue. The provided AsyncContext is initialized with an ID and returned for later status tracking.
    /// <code>Offset: 0x004F8E90
    /// AsyncContext* __thiscall CLCache::AsyncSaveDDDMessage(CLCache*,AsyncContext*,const DDD_DataMessage*)</code>
    /// </summary>
    /// <param name="result">The context object that will receive the operation identifier.</param>
    /// <param name="pEvent">The DDD data message to be saved asynchronously.</param>
    /// <returns>The same AsyncContext instance, now configured to represent the pending async save request.</returns>
    public ACBindings.Internal.AsyncContext* AsyncSaveDDDMessage(ACBindings.Internal.AsyncContext* result, ACBindings.Internal.DDD_DataMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.AsyncContext*, ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.AsyncContext*>)0x004F8E90)(ref this, result, pEvent);

    /// <summary>Sets the cache's data region to the specified ID, loading the corresponding DAT file and updating internal state. If the requested region is already active, no action is taken and the call succeeds.
    /// <code>Offset: 0x004F92D0
    /// bool __thiscall CLCache::SetRegion(CLCache*,unsigned int)</code>
    /// </summary>
    /// <param name="rid">The identifier of the target region.</param>
    /// <returns>True if the region was already set or was successfully switched; otherwise false.</returns>
    public byte SetRegion(uint rid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, uint, byte>)0x004F92D0)(ref this, rid);

    /// <summary>Sets the cache's language by locating and loading the appropriate data file, then initializing the disk controller for that locale.
    /// <code>Offset: 0x004F95F0
    /// bool __thiscall CLCache::SetLanguageInternal(CLCache*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="language_l">Language identifier to switch the cache to.</param>
    /// <param name="engine_only">If true, loads only engine resources; otherwise loads full game resources.</param>
    /// <returns>True if the language was successfully set and initialized; otherwise false.</returns>
    public byte SetLanguageInternal(uint language_l, byte engine_only) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, uint, byte, byte>)0x004F95F0)(ref this, language_l, engine_only);

    /// <summary>
    /// Retrieves the appropriate DiskController for a given data identifier or dat file ID from the cache.
    /// 
    /// <code>Offset: 0x004F9B40
    /// DiskController* __thiscall CLCache::GetDiskController(CLCache*,const QualifiedDataID*,unsigned __int64)</code>
    /// </summary>
    /// <param name="qdid">
    /// The QualifiedDataID specifying the type and ID of the requested data object.
    /// </param>
    /// <param name="idRequestedDatFile">
    /// An optional 64‑bit dat file ID. If non‑zero, the function first attempts to locate a controller for that specific file before falling back to type-based resolution.
    /// </param>
    /// <returns>
    /// A pointer to the DiskController responsible for handling the requested data; returns null if no suitable controller exists.
    /// </returns>
    public ACBindings.Internal.DiskController* GetDiskController(ACBindings.Internal.QualifiedDataID* qdid, ulong idRequestedDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.QualifiedDataID*, ulong, ACBindings.Internal.DiskController*>)0x004F9B40)(ref this, qdid, idRequestedDatFile);

    /// <summary>Determines whether a data file identified by the specified ID is currently loaded.
    /// <code>Offset: 0x004F9C30
    /// bool __thiscall CLCache::IsDatFileLoaded(CLCache*,unsigned __int64)</code>
    /// </summary>
    /// <param name="idDatFile">The unique identifier of the data file to check.</param>
    /// <returns>True if the data file is present in the cache; otherwise, false.</returns>
    public byte IsDatFileLoaded(ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ulong, byte>)0x004F9C30)(ref this, idDatFile);

    /// <summary>Begins the distributed data download (DDD) process by initializing internal state, recording missing iterations, and scheduling an asynchronous start operation.
    /// <code>Offset: 0x004FA660
    /// void __thiscall CLCache::OnBeginDDD(CLCache*,const DDD_BeginDDDMessage*)</code>
    /// </summary>
    /// <param name="pEvent">Message containing expected data size and list of missing iterations for the DDD session.</param>
    public void OnBeginDDD(ACBindings.Internal.DDD_BeginDDDMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DDD_BeginDDDMessage*, void>)0x004FA660)(ref this, pEvent);

    /// <summary>Initializes the CLCache instance by allocating internal structures, loading data packs, creating disk controllers, and setting up master map references.
    /// <code>Offset: 0x004FA8B0
    /// char __thiscall CLCache::Init(int,int*,char,int,char,int,int,int)</code>
    /// </summary>
    /// <param name="this">The CLCache object to initialize.</param>
    /// <param name="a2">Pointer to a string containing the path of the data pack to load.</param>
    /// <param name="a3">Flag indicating whether the cache should operate in read‑only mode.</param>
    /// <param name="a4">Reserved parameter; currently unused by the implementation.</param>
    /// <param name="a5">Flag used during disk controller configuration, typically marking engine‑only behavior.</param>
    /// <param name="a6">Integer value passed to initialization routines (e.g., engine version or identifier).</param>
    /// <param name="a7">Optional parameter supplied after master map setup, often specifying cache size limits or additional options.</param>
    /// <param name="a8">Boolean flag controlling final configuration steps during initialization.</param>
    /// <returns>Non‑zero if the cache was successfully initialized; zero otherwise.</returns>
    public sbyte Init(int* a2, sbyte a3, int a4, sbyte a5, int a6, int a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, int*, sbyte, int, sbyte, int, int, int, sbyte>)0x004FA8B0)(ref this, a2, a3, a4, a5, a6, a7, a8);

    /// <summary>Loads the high‑resolution data pack (client_highres.dat) into the cache when available, initializing a DiskController for the file and registering it in the internal lookup table.
    /// <code>Offset: 0x004FADF0
    /// void __thiscall CLCache::LoadHighResDat(CLCache*)</code>
    /// </summary>
    public void LoadHighResDat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FADF0)(ref this);

    /// <summary>Handles a server interrogation message by updating cache state, loading required data files, collecting iteration information, building an interrogation response, and delivering it to the requester.
    /// <code>Offset: 0x004FAF80
    /// void __thiscall CLCache::OnServerInterrogation(CLCache*,const DDD_InterrogationMessage*)</code>
    /// </summary>
    /// <param name="pEvent">The incoming interrogation message containing server region, product flags, and language settings.</param>
    public void OnServerInterrogation(ACBindings.Internal.DDD_InterrogationMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DDD_InterrogationMessage*, void>)0x004FAF80)(ref this, pEvent);

    /// <summary>Removes a pending download identified by the supplied QualifiedDataID from the cache's queue. If this removal empties all pending downloads, signals that downloading is complete.
    /// <code>Offset: 0x004FB290
    /// bool __thiscall CLCache::RemovePendingDownload(CLCache*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">The identifier of the data whose pending download should be cancelled or removed.</param>
    /// <returns>True if the specified download was found and removed; false otherwise.</returns>
    public byte RemovePendingDownload(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.QualifiedDataID*, byte>)0x004FB290)(ref this, qdid);

    /// <summary>Finalizes a DDD operation by clearing pending downloads, resetting early saves and missing iterations, sending an end message if appropriate, transitioning the cache state to runtime, and notifying the system of the patch‑time end for the current region.
    /// <code>Offset: 0x004FB450
    /// void __thiscall CLCache::OnEndDDD(CLCache*)</code>
    /// </summary>
    public void OnEndDDD() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FB450)(ref this);

    /// <summary>Processes all missing data iterations recorded during a DDD session after the initial begin request has finished, updating pending download entries, initializing disk controllers when necessary, and finally marking the DDD state as complete.
    /// <code>Offset: 0x004FB4E0
    /// void __thiscall CLCache::OnBeginDDDRequestFinished(CLCache*,CLCache::CAsyncBeginDDDRequest*)</code>
    /// </summary>
    /// <param name="pReq">The asynchronous begin DDD request that just completed; this method does not use its contents directly but performs cleanup based on cached missing iterations.</param>
    public void OnBeginDDDRequestFinished(ACBindings.Internal.CLCache.CAsyncBeginDDDRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void>)0x004FB4E0)(ref this, pReq);

    /// <summary>Initializes the CLCache instance by allocating and registering numerous object types with unique identifiers in an intrusive hash table, thereby setting up the cache for subsequent use.
    /// <code>Offset: 0x004FB850
    /// void __thiscall CLCache::Init_Internal(CLCache*)</code>
    /// </summary>
    /// <param name="this">The CLCache instance to be initialized.</param>
    public void Init_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FB850)(ref this);

    /// <summary>Releases all resources owned by a CLCache instance: closes disk controllers, clears data caches and hash tables, frees allocated memory for early saves, pending downloads, and missing iterations, removes plugin manager links, and finally invokes the base ThreadedCache destructor.
    /// <code>Offset: 0x004FC9D0
    /// void __thiscall CLCache::~CLCache(CLCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FC9D0)(ref this);

    /// <summary>Periodically updates the cache by invoking the base class update routine and then processing any queued DDD network messages, updating internal state or notifying listeners according to the message type.
    /// <code>Offset: 0x004FCBE0
    /// void __thiscall CLCache::UseTime(CLCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FCBE0)(ref this);

    /// <summary>Processes the result of an asynchronous cache save operation, handling success by cleaning up pending downloads in region 2 and delegating to the base class; on failure it reports an error and triggers a debug abort.
    /// <code>Offset: 0x004FCEB0
    /// void __thiscall CLCache::OnSaveRequestFinished(CLCache*,CAsyncSaveRequest*)</code>
    /// </summary>
    /// <param name="pSaveReq">The asynchronous save request whose completion is being processed.</param>
    public void OnSaveRequestFinished(ACBindings.Internal.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.CAsyncSaveRequest*, void>)0x004FCEB0)(ref this, pSaveReq);

    /// <summary>Initializes a new instance of the CLCache class, setting up its internal cache structures, default properties (read‑only mode, region ID, name rule language), and preparing tables for disk files, pending downloads, early saves, and network queue.
    /// <code>Offset: 0x004FCF90
    /// void __thiscall CLCache::CLCache(CLCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FCF90)(ref this);
}


/// <summary>Manages block‑based storage on a file system, coordinating allocation, deallocation, and transactional updates.</summary>
/// <remarks>Encapsulates the underlying disk device, file metadata, and an expansion flag for dynamic growth.</remarks>
/// <field name="file_info_mp"><summary>Pointer to the current file’s metadata used during allocation operations.</summary></field>
/// <field name="file_man_m"><summary>Disk device handle responsible for low‑level read/write interactions with the backing file.</summary></field>
/// <field name="expandable_mf"><summary>Indicates whether the allocator may enlarge its backing file to accommodate additional blocks.</summary></field>
public unsafe struct CLBlockAllocator : System.IDisposable
{
    // Members
    public ACBindings.Internal.DiskFileInfo_t* file_info_mp;
    public ACBindings.Internal.DiskDev file_man_m;
    public byte expandable_mf;

    // Generated Constructor
    public CLBlockAllocator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a CLBlockAllocator by setting its file information pointer to nullptr, constructing the file manager component, and disabling expansion.
    /// <code>Offset: 0x00674E20
    /// void __thiscall CLBlockAllocator::CLBlockAllocator(CLBlockAllocator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, void>)0x00674E20)(ref this);

    /// <summary>Closes the file handle managed by this block allocator, releasing the associated resource and marking the handle as invalid.
    /// <code>Offset: 0x00674E40
    /// void __thiscall CLBlockAllocator::~CLBlockAllocator(CLBlockAllocator*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, void>)0x00674E40)(ref this);

    /// <summary>Closes the data file used by the block allocator and clears its file information reference.
    /// <code>Offset: 0x00674E50
    /// int __thiscall CLBlockAllocator::Close_Data_File(CLBlockAllocator*)</code>
    /// </summary>
    /// <returns>The result status code returned by the underlying disk device close operation.</returns>
    public int Close_Data_File() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int>)0x00674E50)(ref this);

    /// <summary>Saves the block allocator's disk file information to persistent storage using a synchronous write operation.
    /// <code>Offset: 0x00674E70
    /// int __thiscall CLBlockAllocator::SaveFileInfo(CLBlockAllocator*)</code>
    /// </summary>
    /// <returns>Zero on success; non‑zero indicates an error returned by DiskDev::SyncWrite.</returns>
    public int SaveFileInfo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int>)0x00674E70)(ref this);

    /// <summary>Reverts a chain of allocated blocks beginning at <paramref name="startOffset"/>, marking each block as free and updating the allocator metadata if necessary.
    /// <code>Offset: 0x00674E90
    /// int __thiscall CLBlockAllocator::StoreDataRollback(CLBlockAllocator*,unsigned int,int)</code>
    /// </summary>
    /// <param name="dataSize">Size of the data that was previously stored; this value is not used in the rollback logic.</param>
    /// <param name="startOffset">The offset of the first block to be rolled back.</param>
    /// <returns>Zero on success, otherwise an error code returned by DiskDev operations.</returns>
    public int StoreDataRollback(uint dataSize, int startOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, uint, int, int>)0x00674E90)(ref this, dataSize, startOffset);

    /// <summary>Deletes a chain of blocks from the allocator’s free list starting at the given offset, optionally marks them as freed, updates file metadata and writes all changes back to disk.
    /// <code>Offset: 0x00674F50
    /// int __thiscall CLBlockAllocator::DeleteBlocks(CLBlockAllocator*,int,int,int,bool)</code>
    /// </summary>
    /// <param name="startOffset">The offset of the first block to delete; if zero no blocks are traversed before updating metadata.</param>
    /// <param name="finalOffset">Disk offset where the last freed block is written and where the updated free list head is stored.</param>
    /// <param name="oldFreeCount">Previous count of free blocks, used to recalculate the new total after deletion.</param>
    /// <param name="fRefree">When true, each traversed block is marked as freed by setting a high bit; when false only traversal occurs without marking.</param>
    /// <returns>Zero on success; otherwise returns an error code from disk I/O operations.</returns>
    public int DeleteBlocks(int startOffset, int finalOffset, int oldFreeCount, byte fRefree) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int, int, int, byte, int>)0x00674F50)(ref this, startOffset, finalOffset, oldFreeCount, fRefree);

    /// <summary>Expands the backing file by adding full blocks of the configured block size and updates internal metadata on disk.
    /// <code>Offset: 0x00675040
    /// int __thiscall CLBlockAllocator::ExpandFile(CLBlockAllocator*,int)</code>
    /// </summary>
    /// <param name="size_l">The number of bytes to add; only whole blocks are allocated, any remainder is ignored.</param>
    /// <returns>1 if expansion succeeded and all metadata was written; 0 otherwise.</returns>
    public int ExpandFile(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int, int>)0x00675040)(ref this, size_l);

    /// <summary>Stores data from a cache pack into the allocator’s storage, updating free block metadata while writing necessary blocks to disk.
    /// <code>Offset: 0x00675150
    /// int __thiscall CLBlockAllocator::Store_Data(CLBlockAllocator*,Cache_Pack_t*,int)</code>
    /// </summary>
    /// <param name="pack_buf">The cache pack containing the buffer and related information to be persisted.</param>
    /// <param name="startOffset">Initial offset within the file where data should begin; may include a flag bit used during allocation.</param>
    /// <returns>Zero on success, or an error code returned by disk read/write operations.</returns>
    public int Store_Data(ACBindings.Internal.Cache_Pack_t* pack_buf, int startOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.Cache_Pack_t*, int, int>)0x00675150)(ref this, pack_buf, startOffset);

    /// <summary>Updates block allocation metadata by writing block references from the supplied cache pack buffer into disk storage, managing free and used block lists as needed.
    /// <code>Offset: 0x006752A0
    /// int __thiscall CLBlockAllocator::Update(CLBlockAllocator*,Cache_Pack_t*,int)</code>
    /// </summary>
    /// <param name="pack_buf">Cache_Pack_t containing the data to be written to the file.</param>
    /// <param name="inOffset">File offset at which the write operation should begin.</param>
    /// <returns>Zero on success; non‑zero error code if a disk I/O failure occurs during the update.</returns>
    public int Update(ACBindings.Internal.Cache_Pack_t* pack_buf, int inOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.Cache_Pack_t*, int, int>)0x006752A0)(ref this, pack_buf, inOffset);

    /// <summary>Loads block‑aligned data from the allocator’s file into a cache pack, optionally allowing partial reads.
    /// <code>Offset: 0x00675480
    /// bool __thiscall CLBlockAllocator::Load_Data(CLBlockAllocator*,Cache_Pack_t*,int,bool)</code>
    /// </summary>
    /// <param name="buf_out">Cache_Pack_t structure that receives the loaded data; its buffer is reconfigured to hold at least 4 bytes before reading.</param>
    /// <param name="offset">File offset where loading starts; may be updated by the routine as it processes chained blocks.</param>
    /// <param name="bShortRead">If true permits a short read when the requested data cannot be fully retrieved; otherwise requires the entire block to load successfully.</param>
    /// <returns>True if all required data was loaded (or a short read is permitted); false on error or insufficient data when short reads are disallowed.</returns>
    public byte Load_Data(ACBindings.Internal.Cache_Pack_t* buf_out, int offset, byte bShortRead) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.Cache_Pack_t*, int, byte, byte>)0x00675480)(ref this, buf_out, offset, bShortRead);

    /// <summary>Saves a transaction to disk by serializing the provided DiskTransactInfo into a buffer, ensuring it does not exceed 64 bytes, then synchronously writing it via DiskDev.
    /// <code>Offset: 0x006755E0
    /// int __thiscall CLBlockAllocator::SaveTransaction(CLBlockAllocator*,DiskTransactInfo*)</code>
    /// </summary>
    /// <param name="pTransInfo">The transaction information to serialize and persist.</param>
    /// <returns>An integer status: zero or positive on success from SyncWrite; negative –101 if the serialized size exceeds 64 bytes.</returns>
    public int SaveTransaction(ACBindings.Internal.DiskTransactInfo* pTransInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.DiskTransactInfo*, int>)0x006755E0)(ref this, pTransInfo);

    /// <summary>Resets the allocator's current transaction by creating a new transaction record and persisting it.
    /// <code>Offset: 0x00675680
    /// int __thiscall CLBlockAllocator::ClearTransaction(CLBlockAllocator*)</code>
    /// </summary>
    /// <returns>The status returned by CLBlockAllocator::SaveTransaction, indicating whether the transaction was cleared successfully.</returns>
    public int ClearTransaction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int>)0x00675680)(ref this);

    /// <summary>Reads a transaction record from the allocator’s backing file into a new DiskTransactInfo instance and validates its magic number.
    /// <code>Offset: 0x006756A0
    /// int __thiscall CLBlockAllocator::ReadTransaction(CLBlockAllocator*,DiskTransactInfo**)</code>
    /// </summary>
    /// <param name="pTranInfo">Pointer to receive the allocated DiskTransactInfo object; caller must free the returned instance.</param>
    /// <returns>Zero on success; non‑zero otherwise (may be an error code from DiskDev::SyncRead or –101 if validation fails).</returns>
    public int ReadTransaction(ACBindings.Internal.DiskTransactInfo** pTranInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.DiskTransactInfo**, int>)0x006756A0)(ref this, pTranInfo);

    /// <summary>Creates a new data file for block allocation, initializing the free‑block list and persisting the file’s metadata.
    /// <code>Offset: 0x00675780
    /// int __thiscall CLBlockAllocator::CreateDataFile(CLBlockAllocator*,DiskFileInfo_t*,int,int,int)</code>
    /// </summary>
    /// <param name="fileInfo">Structure to receive file size, block size, number of free blocks, and updated id_vnum information.</param>
    /// <param name="initialOffset">Ignored on input; used internally as a temporary offset during free‑block construction.</param>
    /// <param name="fileSizePtr">Pointer to an integer holding the desired file size in bytes; may be updated by DiskDev::Open_File.</param>
    /// <param name="flags">Bit flags controlling creation behavior; bit 1 (value 2) marks the file as expandable and is also forwarded to Open_File.</param>
    /// <returns>Zero on success. On failure, returns a non‑zero error code from DiskDev::Open_File or a subsequent DiskDev::SyncWrite operation.</returns>
    public int CreateDataFile(ACBindings.Internal.DiskFileInfo_t* a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.DiskFileInfo_t*, int, int, int, int>)0x00675780)(ref this, a2, a3, a4, a5);

    /// <summary>Opens a data file for block allocation, verifies its header, and begins a read transaction when successful.
    /// <code>Offset: 0x00675920
    /// int __thiscall CLBlockAllocator::OpenDataFile(CLBlockAllocator*,volatile LONG*,int,int*,int,DiskTransactInfo**)</code>
    /// </summary>
    /// <param name="lpBuffer">Pointer to a buffer that holds the filename string used to open the file; also serves as storage for file information during the operation.</param>
    /// <param name="a3">Reserved flag value (unused in this implementation).</param>
    /// <param name="a4">Output parameter receiving an identifier or handle returned by the file opening routine.</param>
    /// <param name="a5">Flag set indicating whether the allocator should be expandable; bit 2 of this value is examined to determine that property.</param>
    /// <param name="pTranInfo">Receives a pointer to transaction information upon successful creation of a read transaction; otherwise left unchanged.</param>
    /// <returns>Zero on success, or a negative error code (e.g., –102) if the file header is invalid or another failure occurs during opening or initialization.</returns>
    public int OpenDataFile(int* lpBuffer, int a3, int* a4, int a5, ACBindings.Internal.DiskTransactInfo** pTranInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int*, int, int*, int, ACBindings.Internal.DiskTransactInfo**, int>)0x00675920)(ref this, lpBuffer, a3, a4, a5, pTranInfo);
}


/// <summary>Extends the core caching system with distributed data download handling, regional language switching, and advanced disk controller management.</summary>
public unsafe struct gmCLCache
{
    // Base Classes
    public ACBindings.Internal.CLCache BaseClass_CLCache; // ACBindings.Internal.CLCache

    // Child Types
    public unsafe struct gmCLCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DBCache_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DBCache.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> ResetCache; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, int, int, uint, ACBindings.Internal.DBObj*> GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES> PreFetch; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DatIDStamp*, byte> InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte, byte> SetShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> IsLoader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte> SetRegion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> UnloadCellData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> AskForLastWords; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte, byte> SetLanguageInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DestroyObjectCaches; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, void> StopThread; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> WorkerExecuteRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncGetRequest*, void> WorkerExecuteGetRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncSaveRequest*, void> WorkerExecuteSaveRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncPurgeRequest*, void> WorkerExecutePurgeRequest; // function pointer
        public System.IntPtr Init;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, void> Init_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.AsyncContext*> AsyncSaveDDDMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> WorkerExecuteBeginDDDRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> OnBeginDDDRequestFinished; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Create a MasterDBMap instance, initialize it, reset static game pack version counters, and then delegate cache initialization to the base CLCache with the supplied parameters.
    /// <code>Offset: 0x0058B870
    /// char __thiscall gmCLCache::Init(void*,int*,char,int,char,int,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer forwarded unchanged to the base CLCache::Init for cache configuration.</param>
    /// <param name="a3">Character value passed through to the base init.</param>
    /// <param name="a4">Integer value passed through to the base init.</param>
    /// <param name="a5">Character value passed through to the base init.</param>
    /// <param name="a6">Integer argument ignored by this function and not forwarded to CLCache::Init.</param>
    /// <param name="a7">Integer value forwarded as the seventh parameter to CLCache::Init.</param>
    /// <param name="a8">Integer value forwarded as the eighth parameter to CLCache::Init.</param>
    /// <returns>Non‑zero on successful initialization; zero if MasterDBMap creation or base init fails.</returns>
    public sbyte Init(int* a2, sbyte a3, int a4, sbyte a5, int a6, int a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCLCache, int*, sbyte, int, sbyte, int, int, int, sbyte>)0x0058B870)(ref this, a2, a3, a4, a5, a6, a7, a8);

    /// <summary>Initializes the gmCLCache by setting up internal cache structures and registering a series of resource caches in a global intrusive hash table.
    /// <code>Offset: 0x0058B8F0
    /// void __thiscall gmCLCache::Init_Internal(gmCLCache*)</code>
    /// </summary>
    public void Init_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCLCache, void>)0x0058B8F0)(ref this);
}

