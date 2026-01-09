namespace ACBindings;

// IKeystone
public unsafe struct IKeystone
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IKeystone_vtbl
    public unsafe struct IKeystone_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr KsCreateMessageBox; // function pointer
        public System.IntPtr KsCreateWindow; // function pointer
        public System.IntPtr KsGetWindow; // function pointer
        public System.IntPtr KsGetDevice; // function pointer
        public System.IntPtr KsSetCursor; // function pointer
        public System.IntPtr KsUpdate; // function pointer
        public System.IntPtr KsDispatchMessage; // function pointer
        public System.IntPtr KsSetFocusWindow; // function pointer
        public System.IntPtr KsGetFocusWindow; // function pointer
        public System.IntPtr KsRegisterClass; // function pointer
        public System.IntPtr KsUnregisterClass; // function pointer
        public System.IntPtr KsGetClassInfo; // function pointer
        public System.IntPtr KsSetWindowPos; // function pointer
        public System.IntPtr KsTrackMouseEvent; // function pointer
        public System.IntPtr KsUnTrackMouseEvent; // function pointer
        public System.IntPtr KsGetLastError; // function pointer
        public System.IntPtr KsEnumerateControlTags; // function pointer
        public System.IntPtr KsDestroyWindow; // function pointer
        public System.IntPtr KsSetLastError; // function pointer
        public System.IntPtr KsGetWorkingDirectory; // function pointer
        public System.IntPtr KsChangeSetting; // function pointer
        public System.IntPtr KsWindowFromPoint; // function pointer
        public System.IntPtr KsSetTimer; // function pointer
        public System.IntPtr KsKillTimer; // function pointer
        public System.IntPtr KsTranslateAccelerator; // function pointer

        // Methods
    }

    // Methods
}

