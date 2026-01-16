namespace ACBindings.Internal;


/// <summary>Serves as a COM event sink for chat client notifications, enabling applications to handle events from the chat system.</summary>
/// <remarks>Implements IUnknown and is used to receive callbacks in an event‑driven chat architecture.</remarks>
public unsafe struct IChatClientEventSink
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IChatClientEventSink_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClientEventSink*, uint, ushort*, ushort*, ACBindings.Internal.tagBLOB, void> OnSendToRoom; // function pointer

        // Methods
    }

    // Methods
}

