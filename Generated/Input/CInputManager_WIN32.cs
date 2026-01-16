namespace ACBindings.Internal;


/// <summary>
/// Manages Windows input using DirectInput, tracking attached devices, mapping keys to actions, and supporting mouse‑look and text modes.
/// </summary>
public unsafe struct CInputManager_WIN32 : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CInputManager BaseClass_CInputManager; // ACBindings.Internal.CInputManager

    // Statics
    public static uint* sm_timeDoubleClick = (uint*)0x008F8C68;
    public static uint* sm_timeTap = (uint*)0x008F8C6C;
    public static uint* sm_cxDblClick = (uint*)0x008F8C70;
    public static uint* sm_cyDblClick = (uint*)0x008F8C74;

    // Child Types
    public unsafe struct CInputManager_WIN32_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> CInputManager_WIN32_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int, byte> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> InitializeKeymap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, double> GetLastInputTimestamp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int> GetMouseX; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int> GetMouseY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int, int, byte> SetMouseXY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> ClearKeyMap; // function pointer
        public fixed byte gap28[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, byte> AddKeyMap; // function pointer
        public System.IntPtr SaveKeyMap;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, ACBindings.Internal.IInputActionCallback*, int, byte> RegisterInputMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, ACBindings.Internal.IInputActionCallback*, byte> UnregisterInputMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.IInputActionCallback*, void> UnregisterCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, byte> SetActionMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.ActionMap*> GetActionMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.CInputHandler*, uint, byte> RegisterInputHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.CInputHandler*, uint, byte> UnregisterInputHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.ControlSpecification, byte> IsMetaKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType> GetDeviceTypeFromKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> ShiftKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> CtrlKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> AltKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> SetMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> GetMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.MouseLookBehavior, int, int, void> ConfigureMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, System.IntPtr, byte*, int> OnMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> OnUIElementActivationChanging; // function pointer
        public fixed byte gap7C[4];
        public System.IntPtr GetNameFromKey;
        public System.IntPtr GetNameFromMetaKey;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.QualifiedControl, uint, uint, byte> BindAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.QualifiedControl, uint, byte> UnbindByKey; // function pointer
        public System.IntPtr FindKeysForAction;
        public System.IntPtr FindConflictingInputMaps;
        public System.IntPtr FindConflictingControls;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, uint, byte> UnbindAllByAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint> GetDoubleClickDelay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint> GetTapDelay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> SetTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> GetTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> OnSwitchMouseMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> OnSwitchTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.InputEvent*, void> SendActionToListeners; // function pointer

        // Methods
    }

    /// <summary>Tracks a button event by recording its timestamp and the mouse position at that time.</summary>
    public unsafe struct ButtonHistoryEntry
    {
        // Base Classes
        public ACBindings.Internal.CTimestamp__uint BaseClass_CTimestamp; // ACBindings.Internal.CTimestamp__uint

        // Members
        public ACBindings.Internal.tagPOINT ptMousePos;

        // Methods
    }

    /// <summary>Encapsulates a DirectInput device for the Win32 input manager, storing its device pointer, instance and product GUIDs, index, type, and active status.</summary>
    public unsafe struct InputDevice
    {
        // Members
        public System.IntPtr pDev;
        public ACBindings.Internal._GUID guidInstance;
        public ACBindings.Internal._GUID guidProduct;
        public uint iDeviceIndex;
        public uint nType;
        public byte bActive;

        // Generated Constructor
        public InputDevice() {
            _ConstructorInternal();
        }

        // Methods

        /// <summary>Initializes an InputDevice instance with default values, clearing the DirectInput device pointer and resetting all GUIDs, indices, type, and activity status to their neutral states.
        /// <code>Offset: 0x00686FF0
        /// void __thiscall CInputManager_WIN32::InputDevice::InputDevice(CInputManager_WIN32::InputDevice*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32.InputDevice, void>)0x00686FF0)(ref this);
    }

    /// <summary>Captures the most recent state of an input control within the Win32 input manager. Includes raw data, control type, operation mode, activation flag, and identifiers for associated action and input mapping.</summary>
    public unsafe struct RecentControlState
    {
        // Members
        public uint dwData;
        public ACBindings.Internal.ControlType type;
        public uint mode;
        public uint activation;
        public uint idActionMatched;
        public uint idInputMapMatched;

        // Methods
    }

    // Members
    public static delegate* unmanaged[Stdcall]<int*, uint, ACBindings.Internal._GUID*, void**, ACBindings.Internal.IUnknown*, int> m_pfnDirectInputCreate; // function pointer
    public int* m_hDInputDLL;
    public System.IntPtr m_pDI;
    public int* m_hwnd;
    public ACBindings.Internal.SmartArray___CInputManager_WIN32_InputDevice m_aDevices;
    public uint m_nKeyboardDevice;
    public uint m_nMouseDevice;
    public uint m_nVirtualDevice;
    public ACBindings.Internal.HashTable___ControlSpecification___ControlType m_hashControlToType;
    public ACBindings.Internal.HashTable___ControlSpecification___CInputManager_WIN32_RecentControlState m_hashActiveControls;
    public ACBindings.Internal.CMasterInputMap m_InputMap;
    public uint m_metaKeyMode;
    public ACBindings.Internal.PriorityHash___ControlSpecification___CInputManager_WIN32_ButtonHistoryEntry m_ButtonHistory;
    public ACBindings.Internal.tagPOINT m_ptMousePosBeforeMouseLookMode;
    public ACBindings.Internal.MouseLookBehavior m_eMouseLookBehavior;
    public ACBindings.Internal.tagPOINT m_ptNonMousePointerMovement;
    public byte m_fClientIsActive;
    public byte m_fMainWindowHasFocus;
    public int m_cSetCapture;
    public byte m_bProcessingKeyDown;
    public byte m_bProcessingActionInResponseToKeyDown;
    public byte m_bIgnoreNextChar;

    // Generated Constructor
    public CInputManager_WIN32() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the input manager’s keymap by clearing existing mappings and acquiring interface support from the current action map.
    /// <code>Offset: 0x00687060
    /// bool __thiscall CInputManager_WIN32::InitializeKeymap(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>True to indicate successful initialization.</returns>
    public byte InitializeKeymap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x00687060)(ref this);

    /// <summary>Registers a new input device with the manager’s internal mapping and returns success status.
    /// <code>Offset: 0x00687080
    /// bool __thiscall CInputManager_WIN32::AddDeviceToInputMap(CInputManager_WIN32*,CInputManager_WIN32::InputDevice*)</code>
    /// </summary>
    /// <param name="inputDevice">The device to register.</param>
    /// <returns>True if the device was added successfully; otherwise false.</returns>
    public byte AddDeviceToInputMap(ACBindings.Internal.CInputManager_WIN32.InputDevice* inputDevice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.CInputManager_WIN32.InputDevice*, byte>)0x00687080)(ref this, inputDevice);

    /// <summary>Resets all key mappings in the input manager, clearing current bindings.
    /// <code>Offset: 0x00687100
    /// bool __thiscall CInputManager_WIN32::ClearKeyMap(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>true after successfully clearing the key map.</returns>
    public byte ClearKeyMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x00687100)(ref this);

    /// <summary>Determines whether a specified control is designated as a meta key in the input manager's mapping.
    /// <code>Offset: 0x00687110
    /// bool __thiscall CInputManager_WIN32::IsMetaKey(CInputManager_WIN32*,ControlSpecification)</code>
    /// </summary>
    /// <param name="key">The control specification to evaluate.</param>
    /// <returns>true if the control corresponds to a meta key; otherwise, false.</returns>
    public byte IsMetaKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, byte>)0x00687110)(ref this, key);

    /// <summary>
    /// Attempts to increment the reference count on a DirectInput device, retrying once for specific COM errors when bAttemptAcquire is true. Returns true if the device can be safely polled; otherwise returns false.
    /// 
    /// <code>Offset: 0x00687130
    /// bool __thiscall CInputManager_WIN32::PollDevice(CInputManager_WIN32*,IDirectInputDevice8A*,bool)</code>
    /// </summary>
    /// <param name="pDev">Pointer to an IDirectInputDevice8A instance that should not be null.</param>
    /// <param name="bAttemptAcquire">If set, allows a single retry of AddRef when encountering transient errors such as device lost or unavailable.</param>
    /// <returns>True if the device's reference count was successfully increased; false otherwise.</returns>
    public byte PollDevice(System.IntPtr pDev, byte bAttemptAcquire) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.IntPtr, byte, byte>)0x00687130)(ref this, pDev, bAttemptAcquire);

    /// <summary>Processes a typed character when the application is in text mode and focused on the main window.
    /// <code>Offset: 0x006871A0
    /// void __thiscall CInputManager_WIN32::UpdateCharacter(CInputManager_WIN32*,wchar_t)</code>
    /// </summary>
    /// <param name="charToHandle">The Unicode character to be forwarded to registered character handlers.</param>
    public void UpdateCharacter(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.Char, void>)0x006871A0)(ref this, charToHandle);

    /// <summary>
    /// Converts a DirectInput device type identifier into an internal ControlType enumeration value.
    /// 
    /// <code>Offset: 0x006871E0
    /// ControlType __thiscall CInputManager_WIN32::DITypeToControlType(CInputManager_WIN32*,unsigned int)</code>
    /// </summary>
    /// <param name="dwType">DirectInput device type code (e.g., 1 for relative axis, 2 for absolute axis, 4 or 8 for button, 16 for POV).</param>
    /// <returns>Corresponding ControlType value such as ct_RelAxis, ct_AbsAxis, ct_Button, ct_POV, or ct_Invalid if the type is unrecognized.</returns>
    public ACBindings.Internal.ControlType DITypeToControlType(uint dwType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, ACBindings.Internal.ControlType>)0x006871E0)(ref this, dwType);

    /// <summary>Converts raw DirectInput data into a normalized value and an activation type code based on the specified control type.
    /// <code>Offset: 0x00687250
    /// unsigned int __thiscall CInputManager_WIN32::DIDataToActivationType(CInputManager_WIN32*,ControlType,unsigned int,float*)</code>
    /// </summary>
    /// <param name="ct">Specifies the kind of input (button, relative axis, absolute axis, or POV).</param>
    /// <param name="dwData">Raw data read from the device.</param>
    /// <param name="o_rData">Receives a floating‑point representation of the processed value.</param>
    /// <returns>Zero if the control type is unsupported; otherwise an activation type identifier that represents how the input should be interpreted (e.g., 1 for button press, 2 for release, or 128 for continuous axis data).</returns>
    public uint DIDataToActivationType(ACBindings.Internal.ControlType ct, uint dwData, float* o_rData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlType, uint, float*, uint>)0x00687250)(ref this, ct, dwData, o_rData);

    /// <summary>Determines the sub‑control index for an input device based on its control type and data value.
    /// <code>Offset: 0x00687320
    /// SubControlIndex __thiscall CInputManager_WIN32::SubControlFromData(CInputManager_WIN32*,ControlType,unsigned int)</code>
    /// </summary>
    /// <param name="ct">The type of control (e.g., relative axis, absolute axis, POV).</param>
    /// <param name="dwData">A value representing the specific data or position associated with the control.</param>
    /// <returns>Returns a SubControlIndex indicating which sub‑control applies; returns 0 when no matching sub‑control exists.</returns>
    public ACBindings.Internal.SubControlIndex SubControlFromData(ACBindings.Internal.ControlType ct, uint dwData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlType, uint, ACBindings.Internal.SubControlIndex>)0x00687320)(ref this, ct, dwData);

    /// <summary>Synchronizes the system cursor to match the internal mouse coordinates stored in the input manager.
    /// <code>Offset: 0x006873B0
    /// void __thiscall CInputManager_WIN32::SyncCursorToMousePos(CInputManager_WIN32*)</code>
    /// </summary>
    public void SyncCursorToMousePos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006873B0)(ref this);

    /// <summary>Associates a qualified input control with an action in the specified input map.
    /// <code>Offset: 0x006873F0
    /// bool __thiscall CInputManager_WIN32::BindAction(CInputManager_WIN32*,QualifiedControl,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_key">The control specification, including metamode and activation flags, to bind.</param>
    /// <param name="i_idAction">Identifier of the action to which the control will be bound.</param>
    /// <param name="i_idMap">Identifier of the input map that should receive the new binding.</param>
    /// <returns>True if the input map was created (or found) and the mapping added successfully; otherwise, false.</returns>
    public byte BindAction(ACBindings.Internal.QualifiedControl i_key, uint i_idAction, uint i_idMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.QualifiedControl, uint, uint, byte>)0x006873F0)(ref this, i_key, i_idAction, i_idMap);

    /// <summary>Returns any input maps that conflict with the specified map by delegating to the underlying ActionMap if present.
    /// <code>Offset: 0x00687440
    /// char __thiscall CInputManager_WIN32::FindConflictingInputMaps(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Identifier of the input map whose conflicts are being queried.</param>
    /// <param name="a3">Pointer to a buffer where conflicting map identifiers will be stored.</param>
    /// <returns>Non‑zero value if conflicting maps were retrieved; zero if no underlying ActionMap exists or none conflict.</returns>
    public sbyte FindConflictingInputMaps(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, int*, sbyte>)0x00687440)(ref this, a2, a3);

    /// <summary>Dispatches an input event to all registered handlers, temporarily marking the event as originating from a key‑down when the manager is currently processing one.
    /// <code>Offset: 0x00687460
    /// void __thiscall CInputManager_WIN32::SendActionToListeners(CInputManager_WIN32*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The input event to be sent to listeners.</param>
    public void SendActionToListeners(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.InputEvent*, void>)0x00687460)(ref this, i_inEvt);

    /// <summary>Adds a key mapping configuration identified by the specified action ID to the input manager's master map.
    /// <code>Offset: 0x00687510
    /// bool __thiscall CInputManager_WIN32::AddKeyMap(CInputManager_WIN32*,unsigned int)</code>
    /// </summary>
    /// <param name="actID">The identifier of the action set whose key map should be merged into the manager.</param>
    /// <returns>True if the mapping was successfully retrieved and merged; otherwise, false when no mapping exists or merge fails.</returns>
    public byte AddKeyMap(uint actID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, byte>)0x00687510)(ref this, actID);

    /// <summary>Acquires all input devices registered with this manager, increments their reference counts, and marks each device as active.
    /// <code>Offset: 0x00687550
    /// void __thiscall CInputManager_WIN32::AcquireAll(CInputManager_WIN32*)</code>
    /// </summary>
    public void AcquireAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x00687550)(ref this);

    /// <summary>Releases all input device objects managed by the instance and marks them inactive.
    /// <code>Offset: 0x006875C0
    /// void __thiscall CInputManager_WIN32::UnacquireAll(CInputManager_WIN32*)</code>
    /// </summary>
    public void UnacquireAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006875C0)(ref this);

    /// <summary>Releases all input devices managed by the instance, unacquiring and releasing each DirectInput device and clearing the device list.
    /// <code>Offset: 0x00687610
    /// void __thiscall CInputManager_WIN32::ReleaseDevices(CInputManager_WIN32*)</code>
    /// </summary>
    public void ReleaseDevices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x00687610)(ref this);

    /// <summary>Determines whether a specified key is currently acting as an active meta key based on the input map and the manager's meta key mode.
    /// <code>Offset: 0x00687660
    /// bool __thiscall CInputManager_WIN32::IsMetaKeyDown(CInputManager_WIN32*,unsigned int)</code>
    /// </summary>
    /// <param name="idKey">Identifier of the key to test for meta‑key status.</param>
    /// <returns>True if the key matches the current meta key mode; otherwise false.</returns>
    public byte IsMetaKeyDown(uint idKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, byte>)0x00687660)(ref this, idKey);

    /// <summary>Determines if either the left or right Shift key is pressed by querying the input manager's meta‑key state.
    /// <code>Offset: 0x006876D0
    /// bool __thiscall CInputManager_WIN32::ShiftKeyDown(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>True when a Shift key is held; otherwise, false.</returns>
    public byte ShiftKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x006876D0)(ref this);

    /// <summary>Determines whether the Control (Ctrl) modifier key is currently held down.
    /// <code>Offset: 0x006876E0
    /// bool __thiscall CInputManager_WIN32::CtrlKeyDown(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>True when the Ctrl key state is active; otherwise, false.</returns>
    public byte CtrlKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x006876E0)(ref this);

    /// <summary>Indicates whether the Alt key is currently pressed.
    /// <code>Offset: 0x006876F0
    /// bool __thiscall CInputManager_WIN32::AltKeyDown(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>True if the Alt key is down; otherwise, false.</returns>
    public byte AltKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x006876F0)(ref this);

    /// <summary>When text mode is enabled during an action that has been triggered by a key‑down event, marks the next character as ignored so it does not affect gameplay.
    /// <code>Offset: 0x00687700
    /// void __thiscall CInputManager_WIN32::OnSwitchTextMode(CInputManager_WIN32*,bool)</code>
    /// </summary>
    /// <param name="mode">True to activate the ignore‑next‑character behavior; false leaves the state unchanged.</param>
    public void OnSwitchTextMode(byte mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte, void>)0x00687700)(ref this, mode);

    /// <summary>Determines the input device type associated with a given control specification.
    /// <code>Offset: 0x00687900
    /// DeviceType __thiscall CInputManager_WIN32::GetDeviceTypeFromKey(CInputManager_WIN32*,ControlSpecification)</code>
    /// </summary>
    /// <param name="key">The ControlSpecification whose key is used to locate the device.</param>
    /// <returns>DeviceType indicating the owning device: 0 if no match, 1 for mouse, 2 for keyboard, and 3 for other devices.</returns>
    public ACBindings.Internal.DeviceType GetDeviceTypeFromKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType>)0x00687900)(ref this, key);

    /// <summary>Adds a key map configuration from the specified file into this input manager's master input map.
    /// <code>Offset: 0x00687AE0
    /// bool __thiscall CInputManager_WIN32::AddKeyMap(int,volatile LONG*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a ref‑counted string that contains the filename or path of the key mapping file to load.</param>
    /// <returns>True if the file was loaded and merged successfully; otherwise, false.</returns>
    public byte AddKeyMap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int*, byte>)0x00687AE0)(ref this, a2);

    /// <summary>Stores the current key‑mapping configuration into a file represented by the supplied reference‑counted buffer.
    /// <code>Offset: 0x00687C70
    /// char __thiscall CInputManager_WIN32::SaveKeyMap(int,volatile LONG*)</code>
    /// </summary>
    /// <param name="a2">Reference‑counted buffer that receives the serialized key‑map data.</param>
    /// <returns>Non‑zero if the save operation succeeded; zero otherwise.</returns>
    public sbyte SaveKeyMap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int*, sbyte>)0x00687C70)(ref this, a2);

    /// <summary>Adds a DirectInput device to the manager by storing its instance and product GUIDs along with the device pointer and marking it active.
    /// <code>Offset: 0x00688070
    /// void __thiscall CInputManager_WIN32::AddDevicePointer(CInputManager_WIN32*,unsigned int,const _GUID*,const _GUID*,IDirectInputDevice8A*)</code>
    /// </summary>
    /// <param name="dwDeviceType">Numeric identifier for the type of device (e.g., keyboard, mouse).</param>
    /// <param name="gInstance">GUID that uniquely identifies this particular hardware instance.</param>
    /// <param name="gProduct">GUID that identifies the product family or model of the device.</param>
    /// <param name="pDevice">Pointer to the IDirectInputDevice8A interface representing the device.</param>
    public void AddDevicePointer(uint dwDeviceType, ACBindings.Internal._GUID* gInstance, ACBindings.Internal._GUID* gProduct, System.IntPtr pDevice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, ACBindings.Internal._GUID*, ACBindings.Internal._GUID*, System.IntPtr, void>)0x00688070)(ref this, dwDeviceType, gInstance, gProduct, pDevice);

    /// <summary>Registers a DirectInput device with the input manager using its type and GUIDs, preparing it for subsequent input handling.
    /// <code>Offset: 0x00688240
    /// HRESULT __thiscall CInputManager_WIN32::AddDevice(CInputManager_WIN32*,unsigned int,const _GUID*,const _GUID*)</code>
    /// </summary>
    /// <param name="dwDeviceType">Numeric code identifying the device category (e.g., mouse, keyboard, or joystick). </param>
    /// <param name="gInstance">GUID that uniquely identifies the specific instance of the device to be added. </param>
    /// <param name="gProduct">GUID representing the product identifier for the device; forwarded to the internal registration routine. </param>
    /// <returns>Zero on success or if the device is already registered; a negative HRESULT indicates failure during creation or configuration.</returns>
    public int AddDevice(uint dwDeviceType, ACBindings.Internal._GUID* gInstance, ACBindings.Internal._GUID* gProduct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, ACBindings.Internal._GUID*, ACBindings.Internal._GUID*, int>)0x00688240)(ref this, dwDeviceType, gInstance, gProduct);

    /// <summary>Enumerates DirectInput devices, adding those that are not keyboards or mice to the input manager.
    /// <code>Offset: 0x00688440
    /// int __stdcall CInputManager_WIN32::EnumSuitableDevicesCB(const DIDEVICEINSTANCEA*,void*)</code>
    /// </summary>
    /// <param name="pDIDI">Pointer to a DIDEVICEINSTANCEA structure describing a device found during enumeration.</param>
    /// <param name="pContext">Pointer to the CInputManager_WIN32 instance used as context for the callback.</param>
    /// <returns>Always returns 1, signaling that enumeration should continue.</returns>
    public static int EnumSuitableDevicesCB(System.IntPtr pDIDI, System.IntPtr pContext) => ((delegate* unmanaged[Stdcall]<System.IntPtr, System.IntPtr, int>)0x00688440)(pDIDI, pContext);

    /// <summary>
    /// Retrieves the prior state of a specified input control from the manager’s active controls cache, or initializes a new state when not present.
    /// 
    /// <code>Offset: 0x00688470
    /// bool __thiscall CInputManager_WIN32::GetPreviousControlState(CInputManager_WIN32*,ControlSpecification,ControlType,CInputManager_WIN32::RecentControlState*)</code>
    /// </summary>
    /// <param name="i_key">Identifier of the control whose previous state is requested.</param>
    /// <param name="i_ct">The type of control (e.g., button, POV).</param>
    /// <param name="o_rcsPreviousState">Pointer to a RecentControlState structure that receives the retrieved or initialized state.</param>
    /// <returns>True if an existing previous state was found; otherwise false and o_rcsPreviousState contains a default-initialized state.</returns>
    public byte GetPreviousControlState(ACBindings.Internal.ControlSpecification i_key, ACBindings.Internal.ControlType i_ct, ACBindings.Internal.CInputManager_WIN32.RecentControlState* o_rcsPreviousState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, ACBindings.Internal.ControlType, ACBindings.Internal.CInputManager_WIN32.RecentControlState*, byte>)0x00688470)(ref this, i_key, i_ct, o_rcsPreviousState);

    /// <summary>Enumerates suitable input devices, registering standard keyboard and mouse along with a virtual device, and initiates DirectInput enumeration to populate the device list.
    /// <code>Offset: 0x00688810
    /// bool __thiscall CInputManager_WIN32::EnumSuitableDevices(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>True if the enumeration succeeded; otherwise false.</returns>
    public byte EnumSuitableDevices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x00688810)(ref this);

    /// <summary>
    /// Retrieves the localized name for a key code, optionally including subcontrol information, and writes it into the supplied string buffer.
    /// 
    /// <code>Offset: 0x00688890
    /// void** __thiscall CInputManager_WIN32::GetNameFromKey_Internal(_DWORD*,void**,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a string buffer that receives the key's name.</param>
    /// <param name="a3">Key code identifying the input device button.</param>
    /// <param name="strtableEnum">Enumeration value selecting the string table for lookup.</param>
    /// <returns>Returns the same pointer supplied in <c>a2</c>, now pointing to a buffer containing the key's name.</returns>
    public void** GetNameFromKey_Internal(void** a2, uint a3, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, uint, int, void**>)0x00688890)(ref this, a2, a3, strtableEnum);

    /// <summary>Removes a binding for the specified key from an input map identified by its ID. If the map or key does not exist, returns false.
    /// <code>Offset: 0x00688BE0
    /// bool __thiscall CInputManager_WIN32::UnbindByKey(CInputManager_WIN32*,QualifiedControl,unsigned int)</code>
    /// </summary>
    /// <param name="i_key">The control specification to unbind.</param>
    /// <param name="i_idMap">The identifier of the target input map section.</param>
    /// <returns>True when the key was successfully removed; otherwise false.</returns>
    public byte UnbindByKey(ACBindings.Internal.QualifiedControl i_key, uint i_idMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.QualifiedControl, uint, byte>)0x00688BE0)(ref this, i_key, i_idMap);

    /// <summary>Retrieves key bindings for a specified action from the input map identified by id.
    /// <code>Offset: 0x00688C40
    /// char __thiscall CInputManager_WIN32::FindKeysForAction(int,int,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Index of the action whose keys are requested.</param>
    /// <param name="id">Identifier of the input map containing the action definitions; if zero or not found, the function fails.</param>
    /// <param name="a4">Pointer to receive the key information for the action.</param>
    /// <returns>Non‑zero if the key bindings were successfully retrieved; otherwise zero.</returns>
    public sbyte FindKeysForAction(int a2, uint id, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, uint, int*, sbyte>)0x00688C40)(ref this, a2, id, a4);

    /// <summary>
    /// Checks whether the given QualifiedControl conflicts with any controls in the input map identified by id. If conflicts exist, they are recorded into the supplied output array and the function returns true; otherwise it returns false.
    /// 
    /// <code>Offset: 0x00688C80
    /// bool __thiscall CInputManager_WIN32::FindConflictingControls(int,QualifiedControl*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The control to test for conflicts.</param>
    /// <param name="id">Identifier of the input map to examine.</param>
    /// <param name="a4">Output buffer that receives information about conflicting controls.</param>
    /// <returns>True if a conflict is detected; otherwise false.</returns>
    public byte FindConflictingControls(ACBindings.Internal.QualifiedControl* a2, uint id, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.QualifiedControl*, uint, int*, byte>)0x00688C80)(ref this, a2, id, a4);

    /// <summary>Unbinds all bindings for the specified action id from the input map identified by eMapID. Returns true if a matching map exists and unbinding succeeds.
    /// <code>Offset: 0x00688CD0
    /// bool __thiscall CInputManager_WIN32::UnbindAllByAction(CInputManager_WIN32*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_id">The identifier of the action to unbind.</param>
    /// <param name="i_eMapID">The identifier of the target input map section.</param>
    /// <returns>True if bindings were successfully removed; otherwise false.</returns>
    public byte UnbindAllByAction(uint i_id, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, uint, byte>)0x00688CD0)(ref this, i_id, i_eMapID);

    /// <summary>Initializes the Win32 input subsystem by loading DirectInput8.dll, creating an IDirectInput8 object, enumerating and acquiring suitable input devices, and configuring key mapping for user interaction.
    /// <code>Offset: 0x00688DA0
    /// bool __thiscall CInputManager_WIN32::OnStartup(CInputManager_WIN32*,int)</code>
    /// </summary>
    /// <param name="dwUserData">Handle to the application window (HWND) that will receive input events.</param>
    /// <returns>True if all initialization steps succeed; otherwise false.</returns>
    public byte OnStartup(int dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, byte>)0x00688DA0)(ref this, dwUserData);

    /// <summary>Retrieves the textual name for a specified input key and stores it in the supplied buffer, then returns that buffer.
    /// <code>Offset: 0x00688F30
    /// void** __thiscall CInputManager_WIN32::GetNameFromKey(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a memory location where the key's name will be written.</param>
    /// <param name="a3">Identifier of the key whose name is requested.</param>
    /// <returns>The pointer supplied in `a2` after it has been populated with the key name.</returns>
    public void** GetNameFromKey(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, uint, void**>)0x00688F30)(ref this, a2, a3);

    /// <summary>Retrieves the display name for a meta key and returns it.
    /// <code>Offset: 0x00688F50
    /// void** __thiscall CInputManager_WIN32::GetNameFromMetaKey(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The input manager instance.</param>
    /// <param name="a2">Pointer that will receive the retrieved name string.</param>
    /// <param name="a3">Identifier of the meta key whose name is requested.</param>
    /// <returns>Same as <paramref name="a2"/>, containing the obtained name string.</returns>
    public void** GetNameFromMetaKey(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, uint, void**>)0x00688F50)(ref this, a2, a3);

    /// <summary>Retrieves a human‑readable name for a key or key combination, allocating a string buffer that contains the description and storing it in the supplied pointer.
    /// <code>Offset: 0x00688F70
    /// void** __thiscall CInputManager_WIN32::GetNameFromKey(char*,void**,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the allocated string buffer; after the call *a2 points to the constructed name.</param>
    /// <param name="a3">Array of two DWORD values: element 0 specifies the base key code, element 1 encodes active meta‑modifier flags used when forming the name.</param>
    /// <returns>Returns the same pointer passed in as a2. The caller owns the string buffer referenced by *a2 and should release it when no longer needed.</returns>
    public void** GetNameFromKey(void** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, int*, void**>)0x00688F70)(ref this, a2, a3);

    /// <summary>Cleans up input map entries, active control mappings, and releases all DirectInput devices before shutting down the input manager.
    /// <code>Offset: 0x006893B0
    /// void __thiscall CInputManager_WIN32::OnShutdown(CInputManager_WIN32*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006893B0)(ref this);

    /// <summary>Initializes a Win32 input manager by resetting DirectInput pointers, configuring device indices, constructing hash tables and an input map, setting default mouse look settings, enabling main window focus, and invoking CoInitialize for COM support.
    /// <code>Offset: 0x006895D0
    /// void __thiscall CInputManager_WIN32::CInputManager_WIN32(CInputManager_WIN32*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006895D0)(ref this);

    /// <summary>Configures the input manager's mouse look behavior and, if the chosen mode is GotoXY, records a target position to be used for that mode.
    /// <code>Offset: 0x006896C0
    /// void __thiscall CInputManager_WIN32::ConfigureMouseLookMode(CInputManager_WIN32*,MouseLookBehavior,int,int)</code>
    /// </summary>
    /// <param name="i_eBehavior">The desired mouse look behavior to apply.</param>
    /// <param name="i_x">X coordinate for the GotoXY mode; ignored when other behaviors are selected.</param>
    /// <param name="i_y">Y coordinate for the GotoXY mode; ignored when other behaviors are selected.</param>
    public void ConfigureMouseLookMode(ACBindings.Internal.MouseLookBehavior i_eBehavior, int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.MouseLookBehavior, int, int, void>)0x006896C0)(ref this, i_eBehavior, i_x, i_y);

    /// <summary>Retrieves the double‑click delay setting used by the input manager.
    /// <code>Offset: 0x006896F0
    /// unsigned int __thiscall CInputManager_WIN32::GetDoubleClickDelay(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>The delay, in milliseconds, between successive clicks to be considered a double click.</returns>
    public uint GetDoubleClickDelay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint>)0x006896F0)(ref this);

    /// <summary>Retrieves the configured tap‑delay value used by the Win32 input manager.
    /// <code>Offset: 0x00689700
    /// unsigned int __thiscall CInputManager_WIN32::GetTapDelay(CInputManager_WIN32*)</code>
    /// </summary>
    /// <returns>The tap‑delay in milliseconds, returned as an unsigned integer.</returns>
    public uint GetTapDelay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint>)0x00689700)(ref this);

    /// <summary>Sets the mouse cursor to the specified window coordinates when mouse look mode is not active, converting to screen space before moving the cursor.
    /// <code>Offset: 0x00689710
    /// bool __thiscall CInputManager_WIN32::SetMouseXY(CInputManager_WIN32*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">X coordinate in client area.</param>
    /// <param name="i_yWindow">Y coordinate in client area.</param>
    /// <returns>True if the position was set; false if mouse look mode is enabled and the update is suppressed.</returns>
    public byte SetMouseXY(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, int, byte>)0x00689710)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// Destroys the Win32 input manager by releasing DirectInput interfaces, freeing the loaded DirectInput DLL, uninitializing COM, clearing device lists and hash tables, deleting dynamic arrays, and invoking the base class destructor.
    /// 
    /// <code>Offset: 0x00689770
    /// void __thiscall CInputManager_WIN32::~CInputManager_WIN32(CInputManager_WIN32*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x00689770)(ref this);

    /// <summary>Processes an input event by translating raw device data into a higher‑level action or control state, updating button history and meta key mode, invoking any registered callbacks, and firing appropriate action events.
    /// <code>Offset: 0x00689890
    /// bool __thiscall CInputManager_WIN32::FireInputEvent(CInputManager_WIN32*,ControlSpecification,ControlType,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="key">Specification of the control that generated the event.</param>
    /// <param name="ct">Type of the control (e.g., button, axis).</param>
    /// <param name="dwData">Raw data value supplied by the input device.</param>
    /// <param name="dwTimestamp">Clock tick at which the event was received.</param>
    /// <returns>True after successfully handling the event.</returns>
    public byte FireInputEvent(ACBindings.Internal.ControlSpecification key, ACBindings.Internal.ControlType ct, uint dwData, uint dwTimestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, ACBindings.Internal.ControlType, uint, uint, byte>)0x00689890)(ref this, key, ct, dwData, dwTimestamp);

    /// <summary>Processes a DirectInput device object data entry for the specified device, determines its control type (adding it to the lookup table if unknown), compares against the previous state, and generates one or more input events reflecting any changes.
    /// <code>Offset: 0x0068A070
    /// bool __thiscall CInputManager_WIN32::ProcessDeviceData(CInputManager_WIN32*,unsigned int,const DIDEVICEOBJECTDATA*)</code>
    /// </summary>
    /// <param name="nDevice">Index of the input device within the manager's device list.</param>
    /// <param name="dod">Pointer to a DIDEVICEOBJECTDATA structure containing the raw data from the DirectInput device.</param>
    /// <returns>True if an event was successfully fired for the data; false if the data could not be processed or no change occurred.</returns>
    public byte ProcessDeviceData(uint nDevice, System.IntPtr dod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, System.IntPtr, byte>)0x0068A070)(ref this, nDevice, dod);

    /// <summary>Switches between normal and mouse‑look navigation, managing cursor capture, visibility, and restoring the mouse position according to the configured look behaviour.
    /// <code>Offset: 0x0068A2A0
    /// void __thiscall CInputManager_WIN32::OnSwitchMouseMode(CInputManager_WIN32*,bool)</code>
    /// </summary>
    /// <param name="fEnterMouseLook">True to enter mouse‑look mode; false to exit it.</param>
    public void OnSwitchMouseMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte, void>)0x0068A2A0)(ref this, fEnterMouseLook);

    /// <summary>Converts a Windows keyboard message into internal control events, dispatching key‑down and key‑up notifications while handling toggle keys and extended scancodes.
    /// <code>Offset: 0x0068A3D0
    /// void __thiscall CInputManager_WIN32::GenerateKeyboardEvent(CInputManager_WIN32*,const tagMSG*)</code>
    /// </summary>
    /// <param name="i_msg">The Windows MSG structure describing the keyboard event to process.</param>
    public void GenerateKeyboardEvent(System.IntPtr i_msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.IntPtr, void>)0x0068A3D0)(ref this, i_msg);

    /// <summary>Generates a mouse button event, updates capture state and fires an input event when the button’s state changes.
    /// <code>Offset: 0x0068A4D0
    /// void __thiscall CInputManager_WIN32::GenerateMouseButtonEvent(CInputManager_WIN32*,int,bool,unsigned int)</code>
    /// </summary>
    /// <param name="iButton">Index of the mouse button to process.</param>
    /// <param name="fUp">True if this is a button‑up (release) event; false for button‑down.</param>
    /// <param name="dwTime">Timestamp or tick count associated with the event.</param>
    public void GenerateMouseButtonEvent(int iButton, byte fUp, uint dwTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, byte, uint, void>)0x0068A4D0)(ref this, iButton, fUp, dwTime);

    /// <summary>
    /// Creates a mouse wheel button event for the specified wheel movement.
    /// 
    /// <code>Offset: 0x0068A5A0
    /// void __thiscall CInputManager_WIN32::GenerateMouseWheelEvent(CInputManager_WIN32*,int,unsigned int)</code>
    /// </summary>
    /// <param name="iDeltaZ">
    /// Wheel delta; positive values indicate upward scrolling, zero or negative values indicate downward scrolling.
    /// </param>
    /// <param name="dwTime">
    /// Timestamp at which the event is generated.
    /// </param>
    public void GenerateMouseWheelEvent(int iDeltaZ, uint dwTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, uint, void>)0x0068A5A0)(ref this, iDeltaZ, dwTime);

    /// <summary>Releases all currently active input controls, removing them from the internal state and firing release events for each associated action.
    /// <code>Offset: 0x0068A620
    /// void __thiscall CInputManager_WIN32::ReleasePressedKeys(CInputManager_WIN32*)</code>
    /// </summary>
    public void ReleasePressedKeys() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x0068A620)(ref this);

    /// <summary>Polls all active input devices (keyboard, mouse, virtual), updates cursor positioning, handles mouse‑look behavior, and forwards the processed input to registered handlers.
    /// <code>Offset: 0x0068A830
    /// void __thiscall CInputManager_WIN32::GetInput(CInputManager_WIN32*)</code>
    /// </summary>
    public void GetInput() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x0068A830)(ref this);

    /// <summary>Activates or deactivates the input manager for a client session, managing device acquisition, key release, focus handling, and cursor visibility accordingly.
    /// <code>Offset: 0x0068AB30
    /// void __thiscall CInputManager_WIN32::Activate(CInputManager_WIN32*,bool)</code>
    /// </summary>
    /// <param name="fActive">Desired active state of the client: true to activate, false to deactivate.</param>
    public void Activate(byte fActive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte, void>)0x0068AB30)(ref this, fActive);

    /// <summary>Updates the input manager’s internal time state by fetching current input events and propagating timing updates to the base manager.
    /// <code>Offset: 0x0068ABB0
    /// void __thiscall CInputManager_WIN32::UseTime(CInputManager_WIN32*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x0068ABB0)(ref this);

    /// <summary>Processes a Win32 window message into internal input events, handling mouse movement, button presses, wheel scrolling, keyboard keys, character input, and device enumeration requests.
    /// <code>Offset: 0x0068ABC0
    /// int __thiscall CInputManager_WIN32::OnMessage(CInputManager_WIN32*,const tagMSG*,bool*)</code>
    /// </summary>
    /// <param name="i_msg">Pointer to the MSG structure containing the Windows message to process.</param>
    /// <param name="o_fHandled">Output flag set to true when the message is consumed by this manager; false if it should be passed on.</param>
    /// <returns>Zero for normal handling. One indicates that the message was an extended mouse button event (buttons 4–7) or a special enumeration request, which may require additional processing by the caller.</returns>
    public int OnMessage(System.IntPtr i_msg, byte* o_fHandled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.IntPtr, byte*, int>)0x0068ABC0)(ref this, i_msg, o_fHandled);
}

