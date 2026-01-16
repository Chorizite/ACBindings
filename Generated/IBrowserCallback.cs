namespace ACBindings.Internal;


/// <summary>Provides a virtual function table reference for dynamic dispatch of browser-related callbacks within the application.</summary>
public unsafe struct IBrowserCallback
{
    // Child Types
    public unsafe struct IBrowserCallback_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, ushort*, ushort*, byte*, void> BeforeNavigate2; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, void> DownloadBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, int, int, void> ProgressChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, void> DownloadComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, ushort*, void> NavigateComplete2; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, ushort*, ushort*, int, byte*, void> NavigateError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, ushort*, void> DocumentComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserCallback*, ushort*, void> TitleChange; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

