namespace ACBindings.Internal;

public unsafe struct IKeystoneDocument
{
    // Base Classes
    public ACBindings.Internal.IKeystoneBaseWindow BaseClass_IKeystoneBaseWindow; // ACBindings.Internal.IKeystoneBaseWindow

    // Child Types
    public unsafe struct IKeystoneDocument_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ACBindings.Internal.KS_STATUS> GetStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ACBindings.Internal.IKeystoneResourceKSML*> GetDocumentSource; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, System.IntPtr, void> SetASPCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, System.IntPtr, void> SetSoundCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, System.IntPtr, void> SetWndProc; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, System.IntPtr> GetASPCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, System.IntPtr> GetSoundCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, System.IntPtr> GetWndProc; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ushort*, ACBindings.Internal.IKeystoneControl**, int> CreateElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ACBindings.Internal.tagRECT*, int> SetLogicalSurfaceDimensions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ACBindings.Internal.tagRECT*> GetLogicalSurfaceDimensions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ushort*> GetGet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ACBindings.Internal.Region*> GetLayoutArea; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, ACBindings.Internal.Region*, void> SetLayoutArea; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, int, void> InsertLineBreak; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, void> AdjustForMargin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneDocument*, int> IsInIFrame; // function pointer

        // Methods
    }

    // Methods
}

