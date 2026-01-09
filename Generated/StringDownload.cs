namespace ACBindings;

// StringDownload
public unsafe struct StringDownload
{
    // Base Classes
    public ACBindings.AsyncCacheCallback BaseClass_AsyncCacheCallback; // ACBindings.AsyncCacheCallback

    // Child Types
    // StringDownload_vtbl
    public unsafe struct StringDownload_vtbl
    {
        // Members
        public System.IntPtr OnContextFinished; // function pointer
        public System.IntPtr OnTopLevelRequestFinished; // function pointer
        public System.IntPtr StringDownload_dtor_8; // function pointer

        // Methods
    }

    // Members
    public ACBindings.StringInfo m_info;
    public uint m_fontDIDNum;
    public uint m_fontColorNum;
    public ACBindings.AsyncContext m_prefetchContext;

    // Methods
}

