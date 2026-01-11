namespace ACBindings.Internal;

public unsafe struct CInputManager_WIN32 : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CInputManager BaseClass_CInputManager; // ACBindings.Internal.CInputManager

    // Child Types
    public unsafe struct CInputManager_WIN32_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> CInputManager_WIN32_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int, byte> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> InitializeKeymap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> OnShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, double> GetLastInputTimestamp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int> GetMouseX; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int> GetMouseY; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, int, int, byte> SetMouseXY; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> ClearKeyMap; // function pointer
        public fixed byte gap28[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, byte> AddKeyMap; // function pointer
        public System.IntPtr SaveKeyMap;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, ACBindings.Internal.IInputActionCallback*, int, byte> RegisterInputMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, ACBindings.Internal.IInputActionCallback*, byte> UnregisterInputMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.IInputActionCallback*, void> UnregisterCallback; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, byte> SetActionMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.ActionMap*> GetActionMap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.CInputHandler*, uint, byte> RegisterInputHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.CInputHandler*, uint, byte> UnregisterInputHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.ControlSpecification, byte> IsMetaKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType> GetDeviceTypeFromKey; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> ShiftKeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> CtrlKeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> AltKeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> SetMouseLookMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> GetMouseLookMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.MouseLookBehavior, int, int, void> ConfigureMouseLookMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, System.IntPtr, byte*, int> OnMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, void> OnUIElementActivationChanging; // function pointer
        public fixed byte gap7C[4];
        public System.IntPtr GetNameFromKey;
        public System.IntPtr GetNameFromMetaKey;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.QualifiedControl, uint, uint, byte> BindAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.QualifiedControl, uint, byte> UnbindByKey; // function pointer
        public System.IntPtr FindKeysForAction;
        public System.IntPtr FindConflictingInputMaps;
        public System.IntPtr FindConflictingControls;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint, uint, byte> UnbindAllByAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint> GetDoubleClickDelay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, uint> GetTapDelay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> SetTextMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte> GetTextMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> OnSwitchMouseMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, byte, void> OnSwitchTextMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager_WIN32*, ACBindings.Internal.InputEvent*, void> SendActionToListeners; // function pointer

        // Methods
    }
    public unsafe struct ButtonHistoryEntry
    {
        // Base Classes
        public ACBindings.Internal.CTimestamp__uint BaseClass_CTimestamp; // ACBindings.Internal.CTimestamp__uint

        // Members
        public ACBindings.Internal.tagPOINT ptMousePos;

        // Methods
    }
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

        /// <summary>
        /// <code>Offset: 0x00686FF0
        /// void __thiscall CInputManager_WIN32::InputDevice::InputDevice(CInputManager_WIN32::InputDevice*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32.InputDevice, void>)0x00686FF0)(ref this);
    }
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
    public delegate* unmanaged[Stdcall]<int*, uint, ACBindings.Internal._GUID*, void**, ACBindings.Internal.IUnknown*, int> m_pfnDirectInputCreate; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x00687060
    /// bool __thiscall CInputManager_WIN32::InitializeKeymap(CInputManager_WIN32*)</code>
    /// </summary>
    public byte InitializeKeymap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x00687060)(ref this);

    /// <summary>
    /// <code>Offset: 0x00687080
    /// bool __thiscall CInputManager_WIN32::AddDeviceToInputMap(CInputManager_WIN32*,CInputManager_WIN32::InputDevice*)</code>
    /// </summary>
    public byte AddDeviceToInputMap(ACBindings.Internal.CInputManager_WIN32.InputDevice* inputDevice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.CInputManager_WIN32.InputDevice*, byte>)0x00687080)(ref this, inputDevice);

    /// <summary>
    /// <code>Offset: 0x00687100
    /// bool __thiscall CInputManager_WIN32::ClearKeyMap(CInputManager_WIN32*)</code>
    /// </summary>
    public byte ClearKeyMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x00687100)(ref this);

    /// <summary>
    /// <code>Offset: 0x00687110
    /// bool __thiscall CInputManager_WIN32::IsMetaKey(CInputManager_WIN32*,ControlSpecification)</code>
    /// </summary>
    public byte IsMetaKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, byte>)0x00687110)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x00687130
    /// bool __thiscall CInputManager_WIN32::PollDevice(CInputManager_WIN32*,IDirectInputDevice8A*,bool)</code>
    /// </summary>
    public byte PollDevice(System.IntPtr pDev, byte bAttemptAcquire) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.IntPtr, byte, byte>)0x00687130)(ref this, pDev, bAttemptAcquire);

    /// <summary>
    /// <code>Offset: 0x006871A0
    /// void __thiscall CInputManager_WIN32::UpdateCharacter(CInputManager_WIN32*,wchar_t)</code>
    /// </summary>
    public void UpdateCharacter(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.Char, void>)0x006871A0)(ref this, charToHandle);

    /// <summary>
    /// <code>Offset: 0x006871E0
    /// ControlType __thiscall CInputManager_WIN32::DITypeToControlType(CInputManager_WIN32*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.ControlType DITypeToControlType(uint dwType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, ACBindings.Internal.ControlType>)0x006871E0)(ref this, dwType);

    /// <summary>
    /// <code>Offset: 0x00687250
    /// unsigned int __thiscall CInputManager_WIN32::DIDataToActivationType(CInputManager_WIN32*,ControlType,unsigned int,float*)</code>
    /// </summary>
    public uint DIDataToActivationType(ACBindings.Internal.ControlType ct, uint dwData, float* o_rData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlType, uint, float*, uint>)0x00687250)(ref this, ct, dwData, o_rData);

    /// <summary>
    /// <code>Offset: 0x00687320
    /// SubControlIndex __thiscall CInputManager_WIN32::SubControlFromData(CInputManager_WIN32*,ControlType,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.SubControlIndex SubControlFromData(ACBindings.Internal.ControlType ct, uint dwData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlType, uint, ACBindings.Internal.SubControlIndex>)0x00687320)(ref this, ct, dwData);

    /// <summary>
    /// <code>Offset: 0x006873B0
    /// void __thiscall CInputManager_WIN32::SyncCursorToMousePos(CInputManager_WIN32*)</code>
    /// </summary>
    public void SyncCursorToMousePos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006873B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006873F0
    /// bool __thiscall CInputManager_WIN32::BindAction(CInputManager_WIN32*,QualifiedControl,unsigned int,unsigned int)</code>
    /// </summary>
    public byte BindAction(ACBindings.Internal.QualifiedControl i_key, uint i_idAction, uint i_idMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.QualifiedControl, uint, uint, byte>)0x006873F0)(ref this, i_key, i_idAction, i_idMap);

    /// <summary>
    /// <code>Offset: 0x00687440
    /// char __thiscall CInputManager_WIN32::FindConflictingInputMaps(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    public sbyte FindConflictingInputMaps(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, int*, sbyte>)0x00687440)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00687460
    /// void __thiscall CInputManager_WIN32::SendActionToListeners(CInputManager_WIN32*,InputEvent*)</code>
    /// </summary>
    public void SendActionToListeners(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.InputEvent*, void>)0x00687460)(ref this, i_inEvt);

    /// <summary>
    /// <code>Offset: 0x00687510
    /// bool __thiscall CInputManager_WIN32::AddKeyMap(CInputManager_WIN32*,unsigned int)</code>
    /// </summary>
    public byte AddKeyMap(uint actID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, byte>)0x00687510)(ref this, actID);

    /// <summary>
    /// <code>Offset: 0x00687550
    /// void __thiscall CInputManager_WIN32::AcquireAll(CInputManager_WIN32*)</code>
    /// </summary>
    public void AcquireAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x00687550)(ref this);

    /// <summary>
    /// <code>Offset: 0x006875C0
    /// void __thiscall CInputManager_WIN32::UnacquireAll(CInputManager_WIN32*)</code>
    /// </summary>
    public void UnacquireAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006875C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00687610
    /// void __thiscall CInputManager_WIN32::ReleaseDevices(CInputManager_WIN32*)</code>
    /// </summary>
    public void ReleaseDevices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x00687610)(ref this);

    /// <summary>
    /// <code>Offset: 0x00687660
    /// bool __thiscall CInputManager_WIN32::IsMetaKeyDown(CInputManager_WIN32*,unsigned int)</code>
    /// </summary>
    public byte IsMetaKeyDown(uint idKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, byte>)0x00687660)(ref this, idKey);

    /// <summary>
    /// <code>Offset: 0x006876D0
    /// bool __thiscall CInputManager_WIN32::ShiftKeyDown(CInputManager_WIN32*)</code>
    /// </summary>
    public byte ShiftKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x006876D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006876E0
    /// bool __thiscall CInputManager_WIN32::CtrlKeyDown(CInputManager_WIN32*)</code>
    /// </summary>
    public byte CtrlKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x006876E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006876F0
    /// bool __thiscall CInputManager_WIN32::AltKeyDown(CInputManager_WIN32*)</code>
    /// </summary>
    public byte AltKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x006876F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00687700
    /// void __thiscall CInputManager_WIN32::OnSwitchTextMode(CInputManager_WIN32*,bool)</code>
    /// </summary>
    public void OnSwitchTextMode(byte mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte, void>)0x00687700)(ref this, mode);

    /// <summary>
    /// <code>Offset: 0x00687900
    /// DeviceType __thiscall CInputManager_WIN32::GetDeviceTypeFromKey(CInputManager_WIN32*,ControlSpecification)</code>
    /// </summary>
    public ACBindings.Internal.DeviceType GetDeviceTypeFromKey(ACBindings.Internal.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType>)0x00687900)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x00687AE0
    /// bool __thiscall CInputManager_WIN32::AddKeyMap(int,volatile LONG*)</code>
    /// </summary>
    public byte AddKeyMap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int*, byte>)0x00687AE0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00687C70
    /// char __thiscall CInputManager_WIN32::SaveKeyMap(int,volatile LONG*)</code>
    /// </summary>
    public sbyte SaveKeyMap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int*, sbyte>)0x00687C70)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00688070
    /// void __thiscall CInputManager_WIN32::AddDevicePointer(CInputManager_WIN32*,unsigned int,const _GUID*,const _GUID*,IDirectInputDevice8A*)</code>
    /// </summary>
    public void AddDevicePointer(uint dwDeviceType, ACBindings.Internal._GUID* gInstance, ACBindings.Internal._GUID* gProduct, System.IntPtr pDevice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, ACBindings.Internal._GUID*, ACBindings.Internal._GUID*, System.IntPtr, void>)0x00688070)(ref this, dwDeviceType, gInstance, gProduct, pDevice);

    /// <summary>
    /// <code>Offset: 0x00688240
    /// HRESULT __thiscall CInputManager_WIN32::AddDevice(CInputManager_WIN32*,unsigned int,const _GUID*,const _GUID*)</code>
    /// </summary>
    public int AddDevice(uint dwDeviceType, ACBindings.Internal._GUID* gInstance, ACBindings.Internal._GUID* gProduct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, ACBindings.Internal._GUID*, ACBindings.Internal._GUID*, int>)0x00688240)(ref this, dwDeviceType, gInstance, gProduct);

    /// <summary>
    /// <code>Offset: 0x00688440
    /// int __stdcall CInputManager_WIN32::EnumSuitableDevicesCB(const DIDEVICEINSTANCEA*,void*)</code>
    /// </summary>
    public static int EnumSuitableDevicesCB(System.IntPtr pDIDI, System.IntPtr pContext) => ((delegate* unmanaged[Stdcall]<System.IntPtr, System.IntPtr, int>)0x00688440)(pDIDI, pContext);

    /// <summary>
    /// <code>Offset: 0x00688470
    /// bool __thiscall CInputManager_WIN32::GetPreviousControlState(CInputManager_WIN32*,ControlSpecification,ControlType,CInputManager_WIN32::RecentControlState*)</code>
    /// </summary>
    public byte GetPreviousControlState(ACBindings.Internal.ControlSpecification i_key, ACBindings.Internal.ControlType i_ct, ACBindings.Internal.CInputManager_WIN32.RecentControlState* o_rcsPreviousState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, ACBindings.Internal.ControlType, ACBindings.Internal.CInputManager_WIN32.RecentControlState*, byte>)0x00688470)(ref this, i_key, i_ct, o_rcsPreviousState);

    /// <summary>
    /// <code>Offset: 0x00688810
    /// bool __thiscall CInputManager_WIN32::EnumSuitableDevices(CInputManager_WIN32*)</code>
    /// </summary>
    public byte EnumSuitableDevices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte>)0x00688810)(ref this);

    /// <summary>
    /// <code>Offset: 0x00688890
    /// void** __thiscall CInputManager_WIN32::GetNameFromKey_Internal(_DWORD*,void**,unsigned int,int)</code>
    /// </summary>
    public void** GetNameFromKey_Internal(void** a2, uint a3, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, uint, int, void**>)0x00688890)(ref this, a2, a3, strtableEnum);

    /// <summary>
    /// <code>Offset: 0x00688BE0
    /// bool __thiscall CInputManager_WIN32::UnbindByKey(CInputManager_WIN32*,QualifiedControl,unsigned int)</code>
    /// </summary>
    public byte UnbindByKey(ACBindings.Internal.QualifiedControl i_key, uint i_idMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.QualifiedControl, uint, byte>)0x00688BE0)(ref this, i_key, i_idMap);

    /// <summary>
    /// <code>Offset: 0x00688C40
    /// char __thiscall CInputManager_WIN32::FindKeysForAction(int,int,unsigned int,_DWORD*)</code>
    /// </summary>
    public sbyte FindKeysForAction(int a2, uint id, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, uint, int*, sbyte>)0x00688C40)(ref this, a2, id, a4);

    /// <summary>
    /// <code>Offset: 0x00688C80
    /// bool __thiscall CInputManager_WIN32::FindConflictingControls(int,QualifiedControl*,unsigned int,_DWORD*)</code>
    /// </summary>
    public byte FindConflictingControls(ACBindings.Internal.QualifiedControl* a2, uint id, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.QualifiedControl*, uint, int*, byte>)0x00688C80)(ref this, a2, id, a4);

    /// <summary>
    /// <code>Offset: 0x00688CD0
    /// bool __thiscall CInputManager_WIN32::UnbindAllByAction(CInputManager_WIN32*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte UnbindAllByAction(uint i_id, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, uint, byte>)0x00688CD0)(ref this, i_id, i_eMapID);

    /// <summary>
    /// <code>Offset: 0x00688DA0
    /// bool __thiscall CInputManager_WIN32::OnStartup(CInputManager_WIN32*,int)</code>
    /// </summary>
    public byte OnStartup(int dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, byte>)0x00688DA0)(ref this, dwUserData);

    /// <summary>
    /// <code>Offset: 0x00688F30
    /// void** __thiscall CInputManager_WIN32::GetNameFromKey(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    public void** GetNameFromKey(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, uint, void**>)0x00688F30)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00688F50
    /// void** __thiscall CInputManager_WIN32::GetNameFromMetaKey(_DWORD*,void**,unsigned int)</code>
    /// </summary>
    public void** GetNameFromMetaKey(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, uint, void**>)0x00688F50)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00688F70
    /// void** __thiscall CInputManager_WIN32::GetNameFromKey(char*,void**,_DWORD*)</code>
    /// </summary>
    public void** GetNameFromKey(void** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void**, int*, void**>)0x00688F70)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006893B0
    /// void __thiscall CInputManager_WIN32::OnShutdown(CInputManager_WIN32*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006893B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006895D0
    /// void __thiscall CInputManager_WIN32::CInputManager_WIN32(CInputManager_WIN32*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x006895D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006896C0
    /// void __thiscall CInputManager_WIN32::ConfigureMouseLookMode(CInputManager_WIN32*,MouseLookBehavior,int,int)</code>
    /// </summary>
    public void ConfigureMouseLookMode(ACBindings.Internal.MouseLookBehavior i_eBehavior, int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.MouseLookBehavior, int, int, void>)0x006896C0)(ref this, i_eBehavior, i_x, i_y);

    /// <summary>
    /// <code>Offset: 0x006896F0
    /// unsigned int __thiscall CInputManager_WIN32::GetDoubleClickDelay(CInputManager_WIN32*)</code>
    /// </summary>
    public uint GetDoubleClickDelay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint>)0x006896F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00689700
    /// unsigned int __thiscall CInputManager_WIN32::GetTapDelay(CInputManager_WIN32*)</code>
    /// </summary>
    public uint GetTapDelay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint>)0x00689700)(ref this);

    /// <summary>
    /// <code>Offset: 0x00689710
    /// bool __thiscall CInputManager_WIN32::SetMouseXY(CInputManager_WIN32*,int,int)</code>
    /// </summary>
    public byte SetMouseXY(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, int, byte>)0x00689710)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x00689770
    /// void __thiscall CInputManager_WIN32::~CInputManager_WIN32(CInputManager_WIN32*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x00689770)(ref this);

    /// <summary>
    /// <code>Offset: 0x00689890
    /// bool __thiscall CInputManager_WIN32::FireInputEvent(CInputManager_WIN32*,ControlSpecification,ControlType,unsigned int,unsigned int)</code>
    /// </summary>
    public byte FireInputEvent(ACBindings.Internal.ControlSpecification key, ACBindings.Internal.ControlType ct, uint dwData, uint dwTimestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, ACBindings.Internal.ControlSpecification, ACBindings.Internal.ControlType, uint, uint, byte>)0x00689890)(ref this, key, ct, dwData, dwTimestamp);

    /// <summary>
    /// <code>Offset: 0x0068A070
    /// bool __thiscall CInputManager_WIN32::ProcessDeviceData(CInputManager_WIN32*,unsigned int,const DIDEVICEOBJECTDATA*)</code>
    /// </summary>
    public byte ProcessDeviceData(uint nDevice, System.IntPtr dod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, uint, System.IntPtr, byte>)0x0068A070)(ref this, nDevice, dod);

    /// <summary>
    /// <code>Offset: 0x0068A2A0
    /// void __thiscall CInputManager_WIN32::OnSwitchMouseMode(CInputManager_WIN32*,bool)</code>
    /// </summary>
    public void OnSwitchMouseMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte, void>)0x0068A2A0)(ref this, fEnterMouseLook);

    /// <summary>
    /// <code>Offset: 0x0068A3D0
    /// void __thiscall CInputManager_WIN32::GenerateKeyboardEvent(CInputManager_WIN32*,const tagMSG*)</code>
    /// </summary>
    public void GenerateKeyboardEvent(System.IntPtr i_msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.IntPtr, void>)0x0068A3D0)(ref this, i_msg);

    /// <summary>
    /// <code>Offset: 0x0068A4D0
    /// void __thiscall CInputManager_WIN32::GenerateMouseButtonEvent(CInputManager_WIN32*,int,bool,unsigned int)</code>
    /// </summary>
    public void GenerateMouseButtonEvent(int iButton, byte fUp, uint dwTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, byte, uint, void>)0x0068A4D0)(ref this, iButton, fUp, dwTime);

    /// <summary>
    /// <code>Offset: 0x0068A5A0
    /// void __thiscall CInputManager_WIN32::GenerateMouseWheelEvent(CInputManager_WIN32*,int,unsigned int)</code>
    /// </summary>
    public void GenerateMouseWheelEvent(int iDeltaZ, uint dwTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, int, uint, void>)0x0068A5A0)(ref this, iDeltaZ, dwTime);

    /// <summary>
    /// <code>Offset: 0x0068A620
    /// void __thiscall CInputManager_WIN32::ReleasePressedKeys(CInputManager_WIN32*)</code>
    /// </summary>
    public void ReleasePressedKeys() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x0068A620)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068A830
    /// void __thiscall CInputManager_WIN32::GetInput(CInputManager_WIN32*)</code>
    /// </summary>
    public void GetInput() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x0068A830)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068AB30
    /// void __thiscall CInputManager_WIN32::Activate(CInputManager_WIN32*,bool)</code>
    /// </summary>
    public void Activate(byte fActive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, byte, void>)0x0068AB30)(ref this, fActive);

    /// <summary>
    /// <code>Offset: 0x0068ABB0
    /// void __thiscall CInputManager_WIN32::UseTime(CInputManager_WIN32*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, void>)0x0068ABB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0068ABC0
    /// int __thiscall CInputManager_WIN32::OnMessage(CInputManager_WIN32*,const tagMSG*,bool*)</code>
    /// </summary>
    public int OnMessage(System.IntPtr i_msg, byte* o_fHandled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager_WIN32, System.IntPtr, byte*, int>)0x0068ABC0)(ref this, i_msg, o_fHandled);
}

