namespace ACBindings.Internal;


/// <summary>Encapsulates an IUnknown interface to serve as a COM advise sink, enabling event notifications via reference counting and query interfaces.</summary>
/// <remarks>Used internally for asynchronous communication between components in the application.</remarks>
public unsafe struct AsyncIAdviseSink
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIAdviseSink_vtbl
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

        // Methods
    }

    // Methods
}

