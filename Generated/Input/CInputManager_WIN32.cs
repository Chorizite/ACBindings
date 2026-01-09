namespace ACBindings;

// CInputManager_WIN32
public unsafe struct CInputManager_WIN32 : System.IDisposable
{
    // Base Classes
    public ACBindings.CInputManager BaseClass_CInputManager; // ACBindings.CInputManager

    // Statics
    public static uint* sm_timeDoubleClick = (uint*)0x008F8C68;
    public static uint* sm_timeTap = (uint*)0x008F8C6C;
    public static uint* sm_cxDblClick = (uint*)0x008F8C70;
    public static uint* sm_cyDblClick = (uint*)0x008F8C74;

    // Child Types
    // CInputManager_WIN32_vtbl
    public unsafe struct CInputManager_WIN32_vtbl
    {
        // Members
        public System.IntPtr CInputManager_WIN32_dtor_0; // function pointer
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
        public fixed byte gap7C[4];
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
        public System.IntPtr OnSwitchMouseMode; // function pointer
        public System.IntPtr OnSwitchTextMode; // function pointer
        public System.IntPtr SendActionToListeners; // function pointer

        // Methods
    }
    // CInputManager_WIN32::ButtonHistoryEntry
    public unsafe struct ButtonHistoryEntry
    {
        // Base Classes
        public ACBindings.CTimestamp__uint BaseClass_CTimestamp; // ACBindings.CTimestamp__uint

        // Members
        public ACBindings.tagPOINT ptMousePos;

        // Methods
    }
    // CInputManager_WIN32::InputDevice
    public unsafe struct InputDevice
    {
        // Members
        public System.IntPtr pDev;
        public ACBindings._GUID guidInstance;
        public ACBindings._GUID guidProduct;
        public uint iDeviceIndex;
        public uint nType;
        public byte bActive;

        // Generated Constructor
        public InputDevice() {
            _ConstructorInternal();
        }

        // Methods
        // void __thiscall CInputManager_WIN32::InputDevice::InputDevice(CInputManager_WIN32::InputDevice*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32.InputDevice, void>)0x00686FF0)(ref this);
    }
    // CInputManager_WIN32::RecentControlState
    public unsafe struct RecentControlState
    {
        // Members
        public uint dwData;
        public ACBindings.ControlType type;
        public uint mode;
        public uint activation;
        public uint idActionMatched;
        public uint idInputMapMatched;

        // Methods
    }

    // Members
    public System.IntPtr m_pfnDirectInputCreate; // function pointer
    public int* m_hDInputDLL;
    public System.IntPtr m_pDI;
    public int* m_hwnd;
    public ACBindings.SmartArray__CInputManager_WIN32_InputDevice m_aDevices;
    public uint m_nKeyboardDevice;
    public uint m_nMouseDevice;
    public uint m_nVirtualDevice;
    public ACBindings.HashTable__ControlSpecification__ControlType m_hashControlToType;
    public ACBindings.HashTable__ControlSpecification__CInputManager_WIN32_RecentControlState m_hashActiveControls;
    public ACBindings.CMasterInputMap m_InputMap;
    public uint m_metaKeyMode;
    public ACBindings.PriorityHash__ControlSpecification__CInputManager_WIN32_ButtonHistoryEntry m_ButtonHistory;
    public ACBindings.tagPOINT m_ptMousePosBeforeMouseLookMode;
    public ACBindings.MouseLookBehavior m_eMouseLookBehavior;
    public ACBindings.tagPOINT m_ptNonMousePointerMovement;
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
    // bool __thiscall CInputManager_WIN32::InitializeKeymap(CInputManager_WIN32*)
    public byte InitializeKeymap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte>)0x00687060)(ref this);
    // bool __thiscall CInputManager_WIN32::AddDeviceToInputMap(CInputManager_WIN32*,CInputManager_WIN32::InputDevice*)
    public byte AddDeviceToInputMap(ACBindings.CInputManager_WIN32.InputDevice* inputDevice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.CInputManager_WIN32.InputDevice*, byte>)0x00687080)(ref this, inputDevice);
    // bool __thiscall CInputManager_WIN32::ClearKeyMap(CInputManager_WIN32*)
    public byte ClearKeyMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte>)0x00687100)(ref this);
    // bool __thiscall CInputManager_WIN32::IsMetaKey(CInputManager_WIN32*,ControlSpecification)
    public byte IsMetaKey(ACBindings.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.ControlSpecification, byte>)0x00687110)(ref this, key);
    // bool __thiscall CInputManager_WIN32::PollDevice(CInputManager_WIN32*,IDirectInputDevice8A*,bool)
    public byte PollDevice(System.IntPtr pDev, byte bAttemptAcquire) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, System.IntPtr, byte, byte>)0x00687130)(ref this, pDev, bAttemptAcquire);
    // void __thiscall CInputManager_WIN32::UpdateCharacter(CInputManager_WIN32*,wchar_t)
    public void UpdateCharacter(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, System.Char, void>)0x006871A0)(ref this, charToHandle);
    // ControlType __thiscall CInputManager_WIN32::DITypeToControlType(CInputManager_WIN32*,unsigned int)
    public ACBindings.ControlType DITypeToControlType(uint dwType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, ACBindings.ControlType>)0x006871E0)(ref this, dwType);
    // unsigned int __thiscall CInputManager_WIN32::DIDataToActivationType(CInputManager_WIN32*,ControlType,unsigned int,float*)
    public uint DIDataToActivationType(ACBindings.ControlType ct, uint dwData, float* o_rData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.ControlType, uint, float*, uint>)0x00687250)(ref this, ct, dwData, o_rData);
    // SubControlIndex __thiscall CInputManager_WIN32::SubControlFromData(CInputManager_WIN32*,ControlType,unsigned int)
    public ACBindings.SubControlIndex SubControlFromData(ACBindings.ControlType ct, uint dwData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.ControlType, uint, ACBindings.SubControlIndex>)0x00687320)(ref this, ct, dwData);
    // void __thiscall CInputManager_WIN32::SyncCursorToMousePos(CInputManager_WIN32*)
    public void SyncCursorToMousePos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x006873B0)(ref this);
    // bool __thiscall CInputManager_WIN32::BindAction(CInputManager_WIN32*,QualifiedControl,unsigned int,unsigned int)
    public byte BindAction(ACBindings.QualifiedControl i_key, uint i_idAction, uint i_idMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.QualifiedControl, uint, uint, byte>)0x006873F0)(ref this, i_key, i_idAction, i_idMap);
    // char __thiscall CInputManager_WIN32::FindConflictingInputMaps(_DWORD*,unsigned int,_DWORD*)
    public sbyte FindConflictingInputMaps(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, int*, sbyte>)0x00687440)(ref this, a2, a3);
    // void __thiscall CInputManager_WIN32::SendActionToListeners(CInputManager_WIN32*,InputEvent*)
    public void SendActionToListeners(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.InputEvent*, void>)0x00687460)(ref this, i_inEvt);
    // bool __thiscall CInputManager_WIN32::AddKeyMap(CInputManager_WIN32*,unsigned int)
    public byte AddKeyMap(uint actID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, byte>)0x00687510)(ref this, actID);
    // void __thiscall CInputManager_WIN32::AcquireAll(CInputManager_WIN32*)
    public void AcquireAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x00687550)(ref this);
    // void __thiscall CInputManager_WIN32::UnacquireAll(CInputManager_WIN32*)
    public void UnacquireAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x006875C0)(ref this);
    // void __thiscall CInputManager_WIN32::ReleaseDevices(CInputManager_WIN32*)
    public void ReleaseDevices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x00687610)(ref this);
    // bool __thiscall CInputManager_WIN32::IsMetaKeyDown(CInputManager_WIN32*,unsigned int)
    public byte IsMetaKeyDown(uint idKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, byte>)0x00687660)(ref this, idKey);
    // bool __thiscall CInputManager_WIN32::ShiftKeyDown(CInputManager_WIN32*)
    public byte ShiftKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte>)0x006876D0)(ref this);
    // bool __thiscall CInputManager_WIN32::CtrlKeyDown(CInputManager_WIN32*)
    public byte CtrlKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte>)0x006876E0)(ref this);
    // bool __thiscall CInputManager_WIN32::AltKeyDown(CInputManager_WIN32*)
    public byte AltKeyDown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte>)0x006876F0)(ref this);
    // void __thiscall CInputManager_WIN32::OnSwitchTextMode(CInputManager_WIN32*,bool)
    public void OnSwitchTextMode(byte mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte, void>)0x00687700)(ref this, mode);
    // DeviceType __thiscall CInputManager_WIN32::GetDeviceTypeFromKey(CInputManager_WIN32*,ControlSpecification)
    public ACBindings.DeviceType GetDeviceTypeFromKey(ACBindings.ControlSpecification key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.ControlSpecification, ACBindings.DeviceType>)0x00687900)(ref this, key);
    // bool __thiscall CInputManager_WIN32::AddKeyMap(int,volatile LONG*)
    public byte AddKeyMap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int*, byte>)0x00687AE0)(ref this, a2);
    // char __thiscall CInputManager_WIN32::SaveKeyMap(int,volatile LONG*)
    public sbyte SaveKeyMap(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int*, sbyte>)0x00687C70)(ref this, a2);
    // void __thiscall CInputManager_WIN32::AddDevicePointer(CInputManager_WIN32*,unsigned int,const _GUID*,const _GUID*,IDirectInputDevice8A*)
    public void AddDevicePointer(uint dwDeviceType, ACBindings._GUID* gInstance, ACBindings._GUID* gProduct, System.IntPtr pDevice) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, ACBindings._GUID*, ACBindings._GUID*, System.IntPtr, void>)0x00688070)(ref this, dwDeviceType, gInstance, gProduct, pDevice);
    // HRESULT __thiscall CInputManager_WIN32::AddDevice(CInputManager_WIN32*,unsigned int,const _GUID*,const _GUID*)
    public int AddDevice(uint dwDeviceType, ACBindings._GUID* gInstance, ACBindings._GUID* gProduct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, ACBindings._GUID*, ACBindings._GUID*, int>)0x00688240)(ref this, dwDeviceType, gInstance, gProduct);
    // int __stdcall CInputManager_WIN32::EnumSuitableDevicesCB(const DIDEVICEINSTANCEA*,void*)
    public static int EnumSuitableDevicesCB(System.IntPtr pDIDI, System.IntPtr pContext) => ((delegate* unmanaged[Stdcall]<System.IntPtr, System.IntPtr, int>)0x00688440)(pDIDI, pContext);
    // bool __thiscall CInputManager_WIN32::GetPreviousControlState(CInputManager_WIN32*,ControlSpecification,ControlType,CInputManager_WIN32::RecentControlState*)
    public byte GetPreviousControlState(ACBindings.ControlSpecification i_key, ACBindings.ControlType i_ct, ACBindings.CInputManager_WIN32.RecentControlState* o_rcsPreviousState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.ControlSpecification, ACBindings.ControlType, ACBindings.CInputManager_WIN32.RecentControlState*, byte>)0x00688470)(ref this, i_key, i_ct, o_rcsPreviousState);
    // bool __thiscall CInputManager_WIN32::EnumSuitableDevices(CInputManager_WIN32*)
    public byte EnumSuitableDevices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte>)0x00688810)(ref this);
    // void** __thiscall CInputManager_WIN32::GetNameFromKey_Internal(_DWORD*,void**,unsigned int,int)
    public void** GetNameFromKey_Internal(void** a2, uint a3, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void**, uint, int, void**>)0x00688890)(ref this, a2, a3, strtableEnum);
    // bool __thiscall CInputManager_WIN32::UnbindByKey(CInputManager_WIN32*,QualifiedControl,unsigned int)
    public byte UnbindByKey(ACBindings.QualifiedControl i_key, uint i_idMap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.QualifiedControl, uint, byte>)0x00688BE0)(ref this, i_key, i_idMap);
    // char __thiscall CInputManager_WIN32::FindKeysForAction(int,int,unsigned int,_DWORD*)
    public sbyte FindKeysForAction(int a2, uint id, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int, uint, int*, sbyte>)0x00688C40)(ref this, a2, id, a4);
    // bool __thiscall CInputManager_WIN32::FindConflictingControls(int,QualifiedControl*,unsigned int,_DWORD*)
    public byte FindConflictingControls(ACBindings.QualifiedControl* a2, uint id, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.QualifiedControl*, uint, int*, byte>)0x00688C80)(ref this, a2, id, a4);
    // bool __thiscall CInputManager_WIN32::UnbindAllByAction(CInputManager_WIN32*,unsigned int,unsigned int)
    public byte UnbindAllByAction(uint i_id, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, uint, byte>)0x00688CD0)(ref this, i_id, i_eMapID);
    // bool __thiscall CInputManager_WIN32::OnStartup(CInputManager_WIN32*,int)
    public byte OnStartup(int dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int, byte>)0x00688DA0)(ref this, dwUserData);
    // void** __thiscall CInputManager_WIN32::GetNameFromKey(_DWORD*,void**,unsigned int)
    public void** GetNameFromKey(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void**, uint, void**>)0x00688F30)(ref this, a2, a3);
    // void** __thiscall CInputManager_WIN32::GetNameFromMetaKey(_DWORD*,void**,unsigned int)
    public void** GetNameFromMetaKey(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void**, uint, void**>)0x00688F50)(ref this, a2, a3);
    // void** __thiscall CInputManager_WIN32::GetNameFromKey(char*,void**,_DWORD*)
    public void** GetNameFromKey(void** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void**, int*, void**>)0x00688F70)(ref this, a2, a3);
    // void __thiscall CInputManager_WIN32::OnShutdown(CInputManager_WIN32*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x006893B0)(ref this);
    // void __thiscall CInputManager_WIN32::CInputManager_WIN32(CInputManager_WIN32*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x006895D0)(ref this);
    // void __thiscall CInputManager_WIN32::ConfigureMouseLookMode(CInputManager_WIN32*,MouseLookBehavior,int,int)
    public void ConfigureMouseLookMode(ACBindings.MouseLookBehavior i_eBehavior, int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.MouseLookBehavior, int, int, void>)0x006896C0)(ref this, i_eBehavior, i_x, i_y);
    // unsigned int __thiscall CInputManager_WIN32::GetDoubleClickDelay(CInputManager_WIN32*)
    public uint GetDoubleClickDelay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint>)0x006896F0)(ref this);
    // unsigned int __thiscall CInputManager_WIN32::GetTapDelay(CInputManager_WIN32*)
    public uint GetTapDelay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint>)0x00689700)(ref this);
    // bool __thiscall CInputManager_WIN32::SetMouseXY(CInputManager_WIN32*,int,int)
    public byte SetMouseXY(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int, int, byte>)0x00689710)(ref this, i_xWindow, i_yWindow);
    // void __thiscall CInputManager_WIN32::~CInputManager_WIN32(CInputManager_WIN32*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x00689770)(ref this);
    // bool __thiscall CInputManager_WIN32::FireInputEvent(CInputManager_WIN32*,ControlSpecification,ControlType,unsigned int,unsigned int)
    public byte FireInputEvent(ACBindings.ControlSpecification key, ACBindings.ControlType ct, uint dwData, uint dwTimestamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, ACBindings.ControlSpecification, ACBindings.ControlType, uint, uint, byte>)0x00689890)(ref this, key, ct, dwData, dwTimestamp);
    // bool __thiscall CInputManager_WIN32::ProcessDeviceData(CInputManager_WIN32*,unsigned int,const DIDEVICEOBJECTDATA*)
    public byte ProcessDeviceData(uint nDevice, System.IntPtr dod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, uint, System.IntPtr, byte>)0x0068A070)(ref this, nDevice, dod);
    // void __thiscall CInputManager_WIN32::OnSwitchMouseMode(CInputManager_WIN32*,bool)
    public void OnSwitchMouseMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte, void>)0x0068A2A0)(ref this, fEnterMouseLook);
    // void __thiscall CInputManager_WIN32::GenerateKeyboardEvent(CInputManager_WIN32*,const tagMSG*)
    public void GenerateKeyboardEvent(System.IntPtr i_msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, System.IntPtr, void>)0x0068A3D0)(ref this, i_msg);
    // void __thiscall CInputManager_WIN32::GenerateMouseButtonEvent(CInputManager_WIN32*,int,bool,unsigned int)
    public void GenerateMouseButtonEvent(int iButton, byte fUp, uint dwTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int, byte, uint, void>)0x0068A4D0)(ref this, iButton, fUp, dwTime);
    // void __thiscall CInputManager_WIN32::GenerateMouseWheelEvent(CInputManager_WIN32*,int,unsigned int)
    public void GenerateMouseWheelEvent(int iDeltaZ, uint dwTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, int, uint, void>)0x0068A5A0)(ref this, iDeltaZ, dwTime);
    // void __thiscall CInputManager_WIN32::ReleasePressedKeys(CInputManager_WIN32*)
    public void ReleasePressedKeys() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x0068A620)(ref this);
    // void __thiscall CInputManager_WIN32::GetInput(CInputManager_WIN32*)
    public void GetInput() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x0068A830)(ref this);
    // void __thiscall CInputManager_WIN32::Activate(CInputManager_WIN32*,bool)
    public void Activate(byte fActive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, byte, void>)0x0068AB30)(ref this, fActive);
    // void __thiscall CInputManager_WIN32::UseTime(CInputManager_WIN32*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, void>)0x0068ABB0)(ref this);
    // int __thiscall CInputManager_WIN32::OnMessage(CInputManager_WIN32*,const tagMSG*,bool*)
    public int OnMessage(System.IntPtr i_msg, byte* o_fHandled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager_WIN32, System.IntPtr, byte*, int>)0x0068ABC0)(ref this, i_msg, o_fHandled);
}

