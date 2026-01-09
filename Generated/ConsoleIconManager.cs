namespace ACBindings;

// ConsoleIconManager
public unsafe struct ConsoleIconManager
{
    // Base Classes
    public ACBindings.DialogBoxGateway BaseClass_DialogBoxGateway; // ACBindings.DialogBoxGateway
    public ACBindings.CrashCleaner BaseClass_CrashCleaner; // ACBindings.CrashCleaner

    // Child Types
    // ConsoleIconManager_vtbl
    public unsafe struct ConsoleIconManager_vtbl
    {
        // Members
        public System.IntPtr ConsoleIconManager_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr OnDialogBoxBegin; // function pointer
        public System.IntPtr OnDialogBoxEnd; // function pointer
        public System.IntPtr ReportThread_OnDialogBoxBegin; // function pointer
        public System.IntPtr ReportThread_OnDialogBoxEnd; // function pointer
        public System.IntPtr DialogThread_OnDialogBoxBegin; // function pointer
        public System.IntPtr DialogThread_OnDialogBoxEnd; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_hIconBig;
    public System.IntPtr m_hIconSmall;
    public System.IntPtr m_hOldIconBig;
    public System.IntPtr m_hOldIconSmall;
    public int* m_hKernel32;
    public System.IntPtr m_pfGetConsoleWindow; // function pointer

    // Methods
}

