namespace ACBindings.Internal;

public unsafe struct ICIDM
{
    // Child Types
    public unsafe struct ICIDM_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> ICIDM_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int, byte> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> InitializeKeymap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> OnShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, double> GetLastInputTimestamp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int> GetMouseX; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int> GetMouseY; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int, int, byte> SetMouseXY; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> ClearKeyMap; // function pointer
        public fixed byte gap28[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, byte> AddKeyMap; // function pointer
        public System.IntPtr SaveKeyMap;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, ACBindings.Internal.IInputActionCallback*, int, byte> RegisterInputMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, ACBindings.Internal.IInputActionCallback*, byte> UnregisterInputMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.IInputActionCallback*, void> UnregisterCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, byte> SetActionMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.ActionMap*> GetActionMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.CInputHandler*, uint, byte> RegisterInputHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.CInputHandler*, uint, byte> UnregisterInputHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.ControlSpecification, byte> IsMetaKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType> GetDeviceTypeFromKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> ShiftKeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> CtrlKeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> AltKeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte, void> SetMouseLookMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> GetMouseLookMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.MouseLookBehavior, int, int, void> ConfigureMouseLookMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, System.IntPtr, byte*, int> OnMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte, void> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> OnUIElementActivationChanging; // function pointer
        public System.IntPtr GetNameFromKey;
        public System.IntPtr GetNameFromMetaKey;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.QualifiedControl, uint, uint, byte> BindAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.QualifiedControl, uint, byte> UnbindByKey; // function pointer
        public System.IntPtr FindKeysForAction;
        public System.IntPtr FindConflictingInputMaps;
        public System.IntPtr FindConflictingControls;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, uint, byte> UnbindAllByAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint> GetDoubleClickDelay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint> GetTapDelay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte, void> SetTextMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> GetTextMode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

