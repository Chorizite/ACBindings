namespace ACBindings.Internal;


/// <summary>Wraps an IChatNetworkSink instance, representing a chat client.</summary>
public unsafe struct IChatClient
{
    // Base Classes
    public ACBindings.Internal.IChatNetworkSink BaseClass_IChatNetworkSink; // ACBindings.Internal.IChatNetworkSink

    // Child Types
    public unsafe struct IChatClient_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetworkSink*, ACBindings.Internal.tagBLOB, int> OnNetworkData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ACBindings.Internal.IChatNetwork*, ACBindings.Internal.IChatClientEventSink*, ACBindings.Internal.IChatClientAsyncResultSink*, ushort*, int> Init; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, int> Term; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, int> UseTime; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, double, int> SetTime; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ushort*, int> SetDisplayName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, uint, ushort*, int> EnterRoomByID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ushort*, ushort*, ACBindings.Internal.tagBLOB, ACBindings.Internal.tagBLOB, int> EnterRoomByName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, uint, int> ExitRoomByID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ushort*, ACBindings.Internal.tagBLOB, ACBindings.Internal.tagBLOB, int> ExitRoomByName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ushort*, ushort*, ACBindings.Internal.tagBLOB, ACBindings.Internal.tagBLOB, int> SendToRoomByName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, uint, ushort*, ACBindings.Internal.tagBLOB, ACBindings.Internal.tagBLOB, int> SendToRoomByID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ushort*, int> Squelch; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatClient*, ushort*, int> UnSquelch; // function pointer

        // Methods
    }

    // Methods
}

