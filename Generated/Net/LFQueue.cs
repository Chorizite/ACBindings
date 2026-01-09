namespace ACBindings;

// LFQueue<WinInetAsyncHttpClient::HttpDownloadEvent*>
public unsafe struct LFQueue__WinInetAsyncHttpClient_HttpDownloadEvent_ptr
{
    // Members
    public System.IntPtr buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.List__WinInetAsyncHttpClient_HttpDownloadEvent_ptr m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.SharedCriticalSection m_backupListCritSec;

    // Methods
}

// LFQueue<WinInetAsyncHttpClient::HttpDownloadRequest*>
public unsafe struct LFQueue__WinInetAsyncHttpClient_HttpDownloadRequest_ptr
{
    // Members
    public System.IntPtr buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindings.List__WinInetAsyncHttpClient_HttpDownloadRequest_ptr m_backupList;
    public int m_dwBackupListLen;
    public ACBindings.SharedCriticalSection m_backupListCritSec;

    // Methods
}

