namespace ACBindings.Internal;

public unsafe struct LFQueue__uint
{
    // Members
    public uint* buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.Internal.List__uint m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.Internal.SharedCriticalSection m_backupListCritSec;

    // Methods
}

public unsafe struct LFQueue___ODBCRequest_ptr
{
    // Members
    public System.IntPtr buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.Internal.List___ODBCRequest_ptr m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.Internal.SharedCriticalSection m_backupListCritSec;

    // Methods
}

