namespace ACBindings;

// IChatClient
public unsafe struct IChatClient
{
    // Base Classes
    public ACBindings.IChatNetworkSink BaseClass_IChatNetworkSink; // ACBindings.IChatNetworkSink

    // Child Types
    // IChatClient_vtbl
    public unsafe struct IChatClient_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnNetworkData; // function pointer
        public System.IntPtr Init; // function pointer
        public System.IntPtr Term; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr SetTime; // function pointer
        public System.IntPtr SetDisplayName; // function pointer
        public System.IntPtr EnterRoomByID; // function pointer
        public System.IntPtr EnterRoomByName; // function pointer
        public System.IntPtr ExitRoomByID; // function pointer
        public System.IntPtr ExitRoomByName; // function pointer
        public System.IntPtr SendToRoomByName; // function pointer
        public System.IntPtr SendToRoomByID; // function pointer
        public System.IntPtr Squelch; // function pointer
        public System.IntPtr UnSquelch; // function pointer

        // Methods
    }

    // Methods
}

