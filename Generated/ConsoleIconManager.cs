namespace ACBindings.Internal;


/// <summary>Provides icon management for console applications, storing handles to current and previous big/small icons while enabling retrieval of the console window handle via a function pointer. Inherits dialog handling and crash cleanup capabilities and keeps a reference to the kernel32 module for system calls.</summary>
public unsafe struct ConsoleIconManager
{
    // Base Classes
    public ACBindings.Internal.DialogBoxGateway BaseClass_DialogBoxGateway; // ACBindings.Internal.DialogBoxGateway
    public ACBindings.Internal.CrashCleaner BaseClass_CrashCleaner; // ACBindings.Internal.CrashCleaner

    // Child Types
    public unsafe struct ConsoleIconManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, void> ConsoleIconManager_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, byte, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxEnd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, byte> ReportThread_OnDialogBoxBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, byte, void> ReportThread_OnDialogBoxEnd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, byte> DialogThread_OnDialogBoxBegin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ConsoleIconManager*, byte, void> DialogThread_OnDialogBoxEnd; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_hIconBig;
    public System.IntPtr m_hIconSmall;
    public System.IntPtr m_hOldIconBig;
    public System.IntPtr m_hOldIconSmall;
    public int* m_hKernel32;
    public static delegate* unmanaged[Stdcall]<int*> m_pfGetConsoleWindow; // function pointer

    // Methods
}

