namespace ACBindings;

// ICIDM
public unsafe struct ICIDM
{
    // Statics
    public static ACBindings.ICIDM* s_cidm = (ACBindings.ICIDM*)0x00837FF4;

    // Child Types
    // ICIDM_vtbl
    public unsafe struct ICIDM_vtbl
    {
        // Members
        public System.IntPtr ICIDM_dtor_0; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr InitializeKeymap; // function pointer
        public System.IntPtr OnShutdown; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr GetLastInputTimestamp; // function pointer
        public System.IntPtr GetMouseX; // function pointer
        public System.IntPtr GetMouseY; // function pointer
        public System.IntPtr SetMouseXY; // function pointer
        public System.IntPtr ClearKeyMap; // function pointer
        public fixed byte gap28[4];
        public System.IntPtr AddKeyMap; // function pointer
        public System.IntPtr SaveKeyMap;
        public System.IntPtr RegisterInputMap; // function pointer
        public System.IntPtr UnregisterInputMap; // function pointer
        public System.IntPtr UnregisterCallback; // function pointer
        public System.IntPtr SetActionMap; // function pointer
        public System.IntPtr GetActionMap; // function pointer
        public System.IntPtr RegisterInputHandler; // function pointer
        public System.IntPtr UnregisterInputHandler; // function pointer
        public System.IntPtr IsMetaKey; // function pointer
        public System.IntPtr GetDeviceTypeFromKey; // function pointer
        public System.IntPtr ShiftKeyDown; // function pointer
        public System.IntPtr CtrlKeyDown; // function pointer
        public System.IntPtr AltKeyDown; // function pointer
        public System.IntPtr SetMouseLookMode; // function pointer
        public System.IntPtr GetMouseLookMode; // function pointer
        public System.IntPtr ConfigureMouseLookMode; // function pointer
        public System.IntPtr OnMessage; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr OnUIElementActivationChanging; // function pointer
        public System.IntPtr GetNameFromKey;
        public System.IntPtr GetNameFromMetaKey;
        public System.IntPtr BindAction; // function pointer
        public System.IntPtr UnbindByKey; // function pointer
        public System.IntPtr FindKeysForAction;
        public System.IntPtr FindConflictingInputMaps;
        public System.IntPtr FindConflictingControls;
        public System.IntPtr UnbindAllByAction; // function pointer
        public System.IntPtr GetDoubleClickDelay; // function pointer
        public System.IntPtr GetTapDelay; // function pointer
        public System.IntPtr SetTextMode; // function pointer
        public System.IntPtr GetTextMode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

