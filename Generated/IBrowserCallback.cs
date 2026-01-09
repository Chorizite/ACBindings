namespace ACBindings;

// IBrowserCallback
public unsafe struct IBrowserCallback
{
    // Child Types
    // IBrowserCallback_vtbl
    public unsafe struct IBrowserCallback_vtbl
    {
        // Members
        public System.IntPtr BeforeNavigate2; // function pointer
        public System.IntPtr DownloadBegin; // function pointer
        public System.IntPtr ProgressChange; // function pointer
        public System.IntPtr DownloadComplete; // function pointer
        public System.IntPtr NavigateComplete2; // function pointer
        public System.IntPtr NavigateError; // function pointer
        public System.IntPtr DocumentComplete; // function pointer
        public System.IntPtr TitleChange; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

