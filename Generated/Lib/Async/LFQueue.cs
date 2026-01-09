namespace ACBindings;

// LFQueue<AsyncCache::CAsyncRequest*>
public unsafe struct LFQueue__AsyncCache_CAsyncRequest_ptr
{
    // Members
    public ACBindings.AsyncCache.CAsyncRequest** buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.List__AsyncCache_CAsyncRequest_ptr m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.SharedCriticalSection m_backupListCritSec;

    // Methods
}

