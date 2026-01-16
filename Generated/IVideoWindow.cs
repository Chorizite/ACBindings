namespace ACBindings.Internal;


/// <summary>Exposes a COM dispatch interface for controlling a video rendering window within the application.</summary>
public unsafe struct IVideoWindow
{
    // Base Classes
    public ACBindings.Internal.IDispatch BaseClass_IDispatch; // ACBindings.Internal.IDispatch

    // Child Types
    public unsafe struct IVideoWindow_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint*, int> GetTypeInfoCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, uint, uint, System.IntPtr, int> GetTypeInfo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, ACBindings.Internal._GUID*, ushort**, uint, uint, int*, int> GetIDsOfNames; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IDispatch*, int, ACBindings.Internal._GUID*, uint, ushort, System.IntPtr, System.IntPtr, System.IntPtr, uint*, int> Invoke; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, ushort*, int> put_Caption; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, ushort**, int> get_Caption; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_WindowStyle; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_WindowStyle; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_WindowStyleEx; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_WindowStyleEx; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_AutoShow; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_AutoShow; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_WindowState; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_WindowState; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_BackgroundPalette; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_BackgroundPalette; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_Visible; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_Visible; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_Left; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_Left; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_Width; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_Width; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_Top; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_Top; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_Height; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_Height; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_Owner; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_Owner; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_MessageDrain; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_MessageDrain; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_BorderColor; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_BorderColor; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> get_FullScreenMode; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> put_FullScreenMode; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> SetWindowForeground; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int, int, int, int> NotifyOwnerMessage; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int, int, int, int> SetWindowPosition; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int*, int*, int*, int> GetWindowPosition; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int*, int> GetMinIdealImageSize; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int*, int> GetMaxIdealImageSize; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int*, int*, int*, int> GetRestorePosition; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int, int> HideCursor; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IVideoWindow*, int*, int> IsCursorHidden; // function pointer

        // Methods
    }

    // Methods
}

