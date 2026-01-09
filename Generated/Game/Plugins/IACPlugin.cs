namespace ACBindings;

// IACPlugin
public unsafe struct IACPlugin
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IACPlugin_vtbl
    public unsafe struct IACPlugin_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr QueryPluginList; // function pointer
        public System.IntPtr QueryPluginInformation; // function pointer
        public System.IntPtr OnUIInitialized; // function pointer
        public System.IntPtr OnLoginComplete; // function pointer
        public System.IntPtr OnChatWindowText; // function pointer
        public System.IntPtr OnChatBarEnter; // function pointer
        public System.IntPtr OnDeleteObject; // function pointer
        public System.IntPtr OnSelectedTargetChange; // function pointer
        public System.IntPtr OnCombatModeChange; // function pointer
        public System.IntPtr OnBusyCountDecremented; // function pointer
        public System.IntPtr OnBusyCountIncremented; // function pointer
        public System.IntPtr OnTradeWindowOpened; // function pointer
        public System.IntPtr OnTradeWindowItemAdded; // function pointer
        public System.IntPtr OnTradeWindowClosed; // function pointer
        public System.IntPtr OnTradeWindowAccepted; // function pointer
        public System.IntPtr OnTradeWindowDeclined; // function pointer
        public System.IntPtr OnTradeWindowCleared; // function pointer
        public System.IntPtr OnTradeCompleted; // function pointer

        // Methods
    }

    // Methods
}

