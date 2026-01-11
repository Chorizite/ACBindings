namespace ACBindings.Internal;

public unsafe struct IKeystone
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IKeystone_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*, int> KsCreateMessageBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*, ushort*, uint, ACBindings.Internal.tagRECT*, float, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int> KsCreateWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*, ACBindings.Internal.IKeystoneWindow*> KsGetWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, System.IntPtr> KsGetDevice; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneResourceImage*, ACBindings.Internal.tagPOINT*, int> KsSetCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, int> KsUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, uint, uint, int, int*, ACBindings.Internal.IKeystoneWindow*> KsDispatchMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneWindow*, int> KsSetFocusWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneWindow*> KsGetFocusWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.KSWNDCLASS*, int> KsRegisterClass; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*, int> KsUnregisterClass; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*, ACBindings.Internal.KSWNDCLASS**, int> KsGetClassInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*, ushort*, ACBindings.Internal.tagRECT*, uint, int> KsSetWindowPos; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneWindow*, uint, int> KsTrackMouseEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneWindow*, uint, int> KsUnTrackMouseEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, int> KsGetLastError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, System.IntPtr, int> KsEnumerateControlTags; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneWindow*, int> KsDestroyWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, int, int> KsSetLastError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ushort*> KsGetWorkingDirectory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, uint, System.IntPtr, void**, int> KsChangeSetting; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.tagPOINT*, ACBindings.Internal.IKeystoneWindow*> KsWindowFromPoint; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneControl*, uint, uint, int> KsSetTimer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, ACBindings.Internal.IKeystoneControl*, uint, int> KsKillTimer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystone*, int*, int*, System.IntPtr, int> KsTranslateAccelerator; // function pointer

        // Methods
    }

    // Methods
}

