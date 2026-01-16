namespace ACBindings.Internal;


/// <summary>Facilitates asynchronous download of string resources, encapsulating cache callbacks, string metadata, font identifiers, color settings, and prefetch context.</summary>
/// <remarks>Used within the resource management subsystem to ensure efficient retrieval and rendering of textual content.</remarks>
public unsafe struct StringDownload
{
    // Base Classes
    public ACBindings.Internal.AsyncCacheCallback BaseClass_AsyncCacheCallback; // ACBindings.Internal.AsyncCacheCallback

    // Child Types
    public unsafe struct StringDownload_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringDownload*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncResult, uint, void> OnContextFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringDownload*, ACBindings.Internal.AsyncContext, ACBindings.Internal.QualifiedDataID, ACBindings.Internal.AsyncResult, uint, int, System.IntPtr, void> OnTopLevelRequestFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StringDownload*, void> StringDownload_dtor_8; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.StringInfo m_info;
    public uint m_fontDIDNum;
    public uint m_fontColorNum;
    public ACBindings.Internal.AsyncContext m_prefetchContext;

    // Methods
}

