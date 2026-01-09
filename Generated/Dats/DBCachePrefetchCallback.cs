namespace ACBindings;

// DBCachePrefetchCallback
public unsafe struct DBCachePrefetchCallback
{
    // Base Classes
    public ACBindings.AsyncCacheCallback BaseClass_AsyncCacheCallback; // ACBindings.AsyncCacheCallback

    // Child Types
    // DBCachePrefetchCallback_vtbl
    public unsafe struct DBCachePrefetchCallback_vtbl
    {
        // Members
        public System.IntPtr OnContextFinished; // function pointer
        public System.IntPtr OnTopLevelRequestFinished; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AsyncContext m_PreFetchContext;
    public ACBindings.HashSet__QualifiedDataID m_hashRequestedIDs;

    // Methods
    // void __thiscall DBCachePrefetchCallback::OnContextFinished(DBCachePrefetchCallback*,AsyncContext,AsyncResult,unsigned int)
    public void OnContextFinished(ACBindings.AsyncContext hContext, ACBindings.AsyncResult Result, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCachePrefetchCallback, ACBindings.AsyncContext, ACBindings.AsyncResult, uint, void>)0x00414E50)(ref this, hContext, Result, dwUser1);
    // void __thiscall DBCachePrefetchCallback::PreFetch(DBCachePrefetchCallback*,const QualifiedDataID*)
    public void PreFetch(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCachePrefetchCallback, ACBindings.QualifiedDataID*, void>)0x00414E90)(ref this, qdid);
    // void __thiscall DBCachePrefetchCallback::OnTopLevelRequestFinished(DBCachePrefetchCallback*,AsyncContext,QualifiedDataID,AsyncResult,unsigned int,int,void*)
    public void OnTopLevelRequestFinished(ACBindings.AsyncContext hContext, ACBindings.QualifiedDataID qdid, ACBindings.AsyncResult Result, uint dwUser1, int nTimesFinished, System.IntPtr hInternal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBCachePrefetchCallback, ACBindings.AsyncContext, ACBindings.QualifiedDataID, ACBindings.AsyncResult, uint, int, System.IntPtr, void>)0x00414F30)(ref this, hContext, qdid, Result, dwUser1, nTimesFinished, hInternal);
}

