namespace ACBindings.Internal;

public unsafe struct IKeystoneControl
{
    // Base Classes
    public ACBindings.Internal.IKeystoneBaseWindow BaseClass_IKeystoneBaseWindow; // ACBindings.Internal.IKeystoneBaseWindow

    // Child Types
    public unsafe struct IKeystoneControl_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ACBindings.Internal.Region**, ACBindings.Internal.tagPOINT*, uint*, int> GetDimensions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, int> GetTabStop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, int> GetTabIndex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ushort*, ushort*> GetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ushort*, ushort*> GetDefaultAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ushort*> GetTagName; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ushort*, ushort*, int> SetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ushort*, ushort*, int> SetDefaultAttribute; // function pointer
        public System.IntPtr GetNamesOfAttributes;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ACBindings.Internal.IKeystoneDocument*, int> SetDocument; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ACBindings.Internal.IKeystoneWindow*, int> SetWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ACBindings.Internal.IKeystoneWindow*> GetWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ACBindings.Internal.IKeystoneResourceFont*> GetFont; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneControl*, ushort*> GetDirectory; // function pointer
        public System.IntPtr CleanUpAttributeNameStruct;

        // Methods
    }

    // Methods
}

