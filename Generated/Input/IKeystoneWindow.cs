namespace ACBindings.Internal;

public unsafe struct IKeystoneWindow
{
    // Base Classes
    public ACBindings.Internal.IKeystoneBaseWindow BaseClass_IKeystoneBaseWindow; // ACBindings.Internal.IKeystoneBaseWindow

    // Child Types
    public unsafe struct IKeystoneWindow_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, uint, uint, int, int> DefWindowProcA; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.tagRECT*> GetLogicalSurfaceDimensions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, System.IntPtr> GetClientAreaTextures; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, System.IntPtr, int> SetClientAreaTextures; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneResourceKSML*> GetDocumentSource; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.tagRECT*> GetScrollRect; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int> GetScrollX; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int> GetScrollY; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int, int> SetScrollX; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int, int> SetScrollY; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneResourceImage*, ACBindings.Internal.tagPOINT*, int> SetCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int> IsVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ushort*, ACBindings.Internal.IKeystoneControl*> GetControlByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.tagPOINT*, ACBindings.Internal.IKeystoneControl*> GetControlFromPoint; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, uint, ACBindings.Internal.IKeystoneControl*> TranslateAcceleratorA; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ushort*, ushort*, int> RegisterAccelerator; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int, int> ShowWindow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ushort*, ACBindings.Internal.IKeystoneControl**, int> CreateElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int> ReLayout; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int> PopulateControlCatalog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneControl*, int> SetFocusControl; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneControl*> GetFocusControl; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ushort*, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int> Open; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, System.IntPtr> GetASPCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, System.IntPtr> GetSoundCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int, uint> GetWindowLongA; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneControl*, int> AddDirtyControl; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneControl*, uint, int> TrackMouseEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ACBindings.Internal.IKeystoneControl*, uint, int> UnTrackMouseEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, System.IntPtr, System.IntPtr, int> Back; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, System.IntPtr, System.IntPtr, int> Forward; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, int> IsDirty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, uint, int> SwapToNextDocument; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneWindow*, ushort*, int> Print; // function pointer

        // Methods
    }

    // Methods
}

