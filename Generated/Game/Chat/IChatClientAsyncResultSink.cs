namespace ACBindings.Internal;


/// <summary>Provides an interface for receiving callbacks when asynchronous chat client operations complete.</summary>
public unsafe struct IChatClientAsyncResultSink
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IChatClientAsyncResultSink_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClientAsyncResultSink*, int, ushort*, ACBindings.Internal.tagBLOB, void> OnEnterRoomByNameResult; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClientAsyncResultSink*, int, ushort*, ACBindings.Internal.tagBLOB, void> OnExitRoomByNameResult; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClientAsyncResultSink*, int, ushort*, ushort*, ACBindings.Internal.tagBLOB, void> OnSendToRoomByNameResult; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClientAsyncResultSink*, int, uint, ushort*, ACBindings.Internal.tagBLOB, void> OnSendToRoomByIDResult; // function pointer

        // Methods
    }

    // Methods
}

