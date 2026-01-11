namespace ACBindings.Internal;

public unsafe struct IBasicVideo
{
    // Base Classes
    public ACBindings.Internal.IDispatch BaseClass_IDispatch; // ACBindings.Internal.IDispatch

    // Child Types
    public unsafe struct IBasicVideo_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint*, int> GetTypeInfoCount; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint, uint, System.IntPtr, int> GetTypeInfo; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, ACBindings.Internal._GUID*, ushort**, uint, uint, int*, int> GetIDsOfNames; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, int, ACBindings.Internal._GUID*, uint, ushort, System.IntPtr, System.IntPtr, System.IntPtr, uint*, int> Invoke; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, double*, int> get_AvgTimePerFrame; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_BitRate; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_BitErrorRate; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_VideoWidth; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_VideoHeight; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_SourceLeft; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_SourceLeft; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_SourceWidth; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_SourceWidth; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_SourceTop; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_SourceTop; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_SourceHeight; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_SourceHeight; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_DestinationLeft; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_DestinationLeft; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_DestinationWidth; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_DestinationWidth; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_DestinationTop; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_DestinationTop; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int> put_DestinationHeight; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int> get_DestinationHeight; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int, int, int, int> SetSourcePosition; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int*, int*, int*, int> GetSourcePosition; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int> SetDefaultSourcePosition; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int, int, int, int> SetDestinationPosition; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int*, int*, int*, int> GetDestinationPosition; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int> SetDefaultDestinationPosition; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int*, int> GetVideoSize; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int, int, int*, int*, int> GetVideoPaletteEntries; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int*, int*, int> GetCurrentImage; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int> IsUsingDefaultSource; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IBasicVideo*, int> IsUsingDefaultDestination; // function pointer

        // Methods
    }

    // Methods
}

