namespace ACBindings.Internal;

public unsafe struct IKeystoneBaseWindow
{
    // Base Classes
    public ACBindings.Internal.IResourceNotify BaseClass_IResourceNotify; // ACBindings.Internal.IResourceNotify

    // Child Types
    public unsafe struct IKeystoneBaseWindow_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IResourceNotify*, ACBindings.Internal.IResourceNotify*, ACBindings.Internal.KS_STATUS, int> NotifyResourceStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IResourceNotify*, ushort*> GetName; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, uint, uint, int, int> SendMessageA; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.IKeystoneBaseWindow*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.IKeystoneBaseWindow*> GetFirstChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.IKeystoneBaseWindow*> GetNextSibling; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.Region*> GetRegion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.IKeystoneBaseWindow*, int> SetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.IKeystoneBaseWindow*, int> SetFirstChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.IKeystoneBaseWindow*, int> SetNextSibling; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.Region*, int> SetRegion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, System.IntPtr, int> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, System.IntPtr, int> SerializeForPrint; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, int> SetFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, float> GetZOrder; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, float, int> SetZOrder; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, int> IsAbsolute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneBaseWindow*, ACBindings.Internal.E_BASEWINDOW_TYPE> GetType; // function pointer

        // Methods
    }

    // Methods
}

