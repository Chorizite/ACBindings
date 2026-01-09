namespace ACBindings;

// SCellDB
public unsafe struct SCellDB
{
    // Child Types
    // SCellDB_vtbl
    public unsafe struct SCellDB_vtbl
    {
        // Members
        public System.IntPtr SCellDB_dtor_0; // function pointer
        public System.IntPtr ServerSettingTime; // function pointer
        public System.IntPtr StartupCheckpointing; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int numMigrationsInProgress_;
    public ACBindings.LFQueue__uint landblockCreationRequests_;
    public int numAllocatedLandblocks_;
    public System.IntPtr landBlockCreator_;
    public ACBindings.CQuickTimer m_timerPruneInactiveLandblocks;
    public int numInactiveLandblocks_;
    public ACBindings.NIDList__SLandBlock_ptr inactiveList_;
    public System.IntPtr migratePendingListHead_;
    public ACBindings.AlwaysLoaded m_blocksAlwaysLoaded;
    public ACBindings.BlockListLoader m_blocksForbidLogin;
    public ACBindings.BlockListLoader m_blocksForbidCorpseDrop;
    public int m_cur_block_x;
    public int m_cur_block_y;
    public double m_cur_block_ts;
    public int fInCreateLandBlockInternal_;
    public uint blockIDCurrentlyFetching_;
    public System.IntPtr checkMgr_;
    public int fShuttingDown_;
    public System.IntPtr requestThread_;
    public ACBindings.LongHash__BlockCreationInfo blockLookupHash_;
    public int numBlockLookups_;
    public ACBindings.LongHash__BlockUpdate blockUpdateHash_;
    public int numBlockUpdates_;
    public ACBindings.LongHash__BlockUpdate blockInsertHash_;
    public int numBlockInserts_;
    public ACBindings.AC1Legacy.HashTable__uint__double m_blockingLoadFailures;
    public double lastCheckpointedLoadedBlocks_;
    public ACBindings.LFQueue__ODBCRequest_ptr blockLookupResponseQ_;
    public ACBindings.LFQueue__ODBCRequest_ptr blockUpdateResponseQ_;
    public ACBindings.LFQueue__ODBCRequest_ptr blockInsertResponseQ_;

    // Methods
}

