namespace ACBindings.Internal;


/// <summary>Handles landblock creation, migration, and pruning in the game's cell system, managing asynchronous requests, timers, and block state lists.</summary>
public unsafe struct SCellDB
{
    // Child Types
    public unsafe struct SCellDB_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SCellDB*, void> SCellDB_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SCellDB*, double, void> ServerSettingTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SCellDB*, sbyte*, sbyte*, uint, int> StartupCheckpointing; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int numMigrationsInProgress_;
    public ACBindings.Internal.LFQueue__uint landblockCreationRequests_;
    public int numAllocatedLandblocks_;
    public System.IntPtr landBlockCreator_;
    public ACBindings.Internal.CQuickTimer m_timerPruneInactiveLandblocks;
    public int numInactiveLandblocks_;
    public ACBindings.Internal.NIDList___SLandBlock_ptr inactiveList_;
    public System.IntPtr migratePendingListHead_;
    public ACBindings.Internal.AlwaysLoaded m_blocksAlwaysLoaded;
    public ACBindings.Internal.BlockListLoader m_blocksForbidLogin;
    public ACBindings.Internal.BlockListLoader m_blocksForbidCorpseDrop;
    public int m_cur_block_x;
    public int m_cur_block_y;
    public double m_cur_block_ts;
    public int fInCreateLandBlockInternal_;
    public uint blockIDCurrentlyFetching_;
    public System.IntPtr checkMgr_;
    public int fShuttingDown_;
    public System.IntPtr requestThread_;
    public ACBindings.Internal.LongHash___BlockCreationInfo blockLookupHash_;
    public int numBlockLookups_;
    public ACBindings.Internal.LongHash___BlockUpdate blockUpdateHash_;
    public int numBlockUpdates_;
    public ACBindings.Internal.LongHash___BlockUpdate blockInsertHash_;
    public int numBlockInserts_;
    public ACBindings.Internal.AC1Legacy.HashTable__uint__double m_blockingLoadFailures;
    public double lastCheckpointedLoadedBlocks_;
    public ACBindings.Internal.LFQueue___ODBCRequest_ptr blockLookupResponseQ_;
    public ACBindings.Internal.LFQueue___ODBCRequest_ptr blockUpdateResponseQ_;
    public ACBindings.Internal.LFQueue___ODBCRequest_ptr blockInsertResponseQ_;

    // Methods
}

