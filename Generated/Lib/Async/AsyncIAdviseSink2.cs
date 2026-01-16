namespace ACBindings.Internal;


/// <summary>Wraps an existing AsyncIAdviseSink, providing a lightweight container for asynchronous COM advise handling within the application.</summary>
public unsafe struct AsyncIAdviseSink2
{
    // Base Classes
    public ACBindings.Internal.AsyncIAdviseSink BaseClass_AsyncIAdviseSink; // ACBindings.Internal.AsyncIAdviseSink

    // Child Types
    public unsafe struct AsyncIAdviseSink2_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, System.IntPtr, System.IntPtr, void> Begin_OnDataChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Finish_OnDataChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, uint, int, void> Begin_OnViewChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Finish_OnViewChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, System.IntPtr, void> Begin_OnRename; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Finish_OnRename; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Begin_OnSave; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Finish_OnSave; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Begin_OnClose; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink*, void> Finish_OnClose; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink2*, System.IntPtr, void> Begin_OnLinkSrcChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.AsyncIAdviseSink2*, void> Finish_OnLinkSrcChange; // function pointer

        // Methods
    }

    // Methods
}

