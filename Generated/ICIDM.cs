namespace ACBindings.Internal;


/// <summary>Provides a lightweight handle to a COM-style object, containing a single pointer to its virtual function table for method dispatch.</summary>
/// <remarks>Aligned to 4 bytes on 32‑bit Windows; typically used as the base of objects in decompiled code where full class layout is not available.</remarks>
public unsafe struct ICIDM
{
    // Statics
    public static ACBindings.Internal.ICIDM** s_cidm = (ACBindings.Internal.ICIDM**)0x00837FF4;

    // Child Types
    public unsafe struct ICIDM_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> ICIDM_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int, byte> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> InitializeKeymap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, double> GetLastInputTimestamp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int> GetMouseX; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int> GetMouseY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, int, int, byte> SetMouseXY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> ClearKeyMap; // function pointer
        public fixed byte gap28[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, byte> AddKeyMap; // function pointer
        public System.IntPtr SaveKeyMap;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, ACBindings.Internal.IInputActionCallback*, int, byte> RegisterInputMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, ACBindings.Internal.IInputActionCallback*, byte> UnregisterInputMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.IInputActionCallback*, void> UnregisterCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, byte> SetActionMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.ActionMap*> GetActionMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.CInputHandler*, uint, byte> RegisterInputHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.CInputHandler*, uint, byte> UnregisterInputHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.ControlSpecification, byte> IsMetaKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType> GetDeviceTypeFromKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> ShiftKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> CtrlKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> AltKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte, void> SetMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> GetMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.MouseLookBehavior, int, int, void> ConfigureMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, System.IntPtr, byte*, int> OnMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte, void> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, void> OnUIElementActivationChanging; // function pointer
        public System.IntPtr GetNameFromKey;
        public System.IntPtr GetNameFromMetaKey;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.QualifiedControl, uint, uint, byte> BindAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, ACBindings.Internal.QualifiedControl, uint, byte> UnbindByKey; // function pointer
        public System.IntPtr FindKeysForAction;
        public System.IntPtr FindConflictingInputMaps;
        public System.IntPtr FindConflictingControls;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint, uint, byte> UnbindAllByAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint> GetDoubleClickDelay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, uint> GetTapDelay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte, void> SetTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ICIDM*, byte> GetTextMode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

