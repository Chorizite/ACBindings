namespace ACBindings;

// LFQueue<unsigned long>
public unsafe struct LFQueue__uint
{
    // Members
    public uint* buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.List__uint m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.SharedCriticalSection m_backupListCritSec;

    // Methods
}

// LFQueue<ODBCRequest*>
public unsafe struct LFQueue__ODBCRequest_ptr
{
    // Members
    public System.IntPtr buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.List__ODBCRequest_ptr m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.SharedCriticalSection m_backupListCritSec;

    // Methods
}

