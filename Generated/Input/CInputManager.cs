namespace ACBindings;

// CInputManager
public unsafe struct CInputManager : System.IDisposable
{
    // Base Classes
    public ACBindings.ICIDM BaseClass_ICIDM; // ACBindings.ICIDM

    // Statics
    public static double* sm_timeKeyRepeatDelay = (double*)0x00818A78;
    public static double* sm_timeKeyRepeatSpeed = (double*)0x00818A80;

    // Child Types
    // CInputManager_vtbl
    public unsafe struct CInputManager_vtbl
    {
        // Members
        public System.IntPtr CInputManager_dtor_0; // function pointer
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
    // CInputManager::InputMapEntry
    public unsafe struct InputMapEntry
    {
        // Members
        public uint m_mapID;
        public ACBindings.IInputActionCallback* m_pcCallback;
        public int m_nPriority;

        // Methods
    }

    // Members
    public ACBindings.tagPOINT m_ptMousePos;
    public double m_ttLastInputEvent;
    public byte m_fWantMouseLookMode;
    public byte m_fInMouseLookMode;
    public byte m_textMode;
    public byte m_lastFocus;
    public ACBindings.List__CInputHandler_ptr m_actionList;
    public ACBindings.List__CInputHandler_ptr m_characterList;
    public ACBindings.List__CInputHandler_ptr m_mouseLookList;
    public ACBindings.List__CInputHandler_ptr m_mouseMoveList;
    public ACBindings.List__CInputHandler_ptr m_focusSwitchList;
    public ACBindings.List__CInputManager_InputMapEntry m_inputMapList;
    public ACBindings.CInputHandler* m_pKeyHitHandler;
    public float m_MouseLookSensitivity;
    public float m_MouseLookSmoothingAmount;
    public byte m_InvertMouseLookYAxis;
    public byte m_UseMouseTurning;
    public ACBindings.ActionMap* m_action_map;
    public ACBindings.IntrusiveHashTable__uint__ActionState_ptr m_hashActionStates;

    // Generated Constructor
    public CInputManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall CInputManager::OnStartup(CInputManager*,int)
    public byte OnStartup(int dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, int, byte>)0x00430E00)(ref this, dwUserData);
    // bool __thiscall CInputManager::SetActionMap(CInputManager*,unsigned int)
    public byte SetActionMap(uint actID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, uint, byte>)0x00430E50)(ref this, actID);
    // void __thiscall CInputManager::OnSwitchMouseMode(CInputManager*,bool)
    public void OnSwitchMouseMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, byte, void>)0x00430E90)(ref this, fEnterMouseLook);
    // bool __thiscall CInputManager::CallKeyHitHandler(CInputManager*,const QualifiedControl*,unsigned int*)
    public byte CallKeyHitHandler(ACBindings.QualifiedControl* i_key, uint* o_idAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.QualifiedControl*, uint*, byte>)0x00430EA0)(ref this, i_key, o_idAction);
    // void __thiscall CInputManager::StartAction(CInputManager*,InputEvent*)
    public void StartAction(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.InputEvent*, void>)0x00430EC0)(ref this, i_inEvt);
    // void __thiscall CInputManager::CallCharacterHandler(CInputManager*,wchar_t)
    public void CallCharacterHandler(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, System.Char, void>)0x00431350)(ref this, charToHandle);
    // void __thiscall CInputManager::CallMouseMoveHandler(CInputManager*,int,int)
    public void CallMouseMoveHandler(int cx, int cy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, int, int, void>)0x00431390)(ref this, cx, cy);
    // void __thiscall CInputManager::CallMouseLookHandler(CInputManager*,int,int)
    public void CallMouseLookHandler(int dxpos, int dypos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, int, int, void>)0x004313C0)(ref this, dxpos, dypos);
    // void __thiscall CInputManager::CallFocusSwitchHandler(CInputManager*,bool)
    public void CallFocusSwitchHandler(byte have_focus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, byte, void>)0x004313F0)(ref this, have_focus);
    // void __thiscall CInputManager::SendActionToListeners(CInputManager*,InputEvent*)
    public void SendActionToListeners(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.InputEvent*, void>)0x00431440)(ref this, i_inEvt);
    // void __thiscall CInputManager::SetMouseLookMode(CInputManager*,bool)
    public void SetMouseLookMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, byte, void>)0x00431560)(ref this, fEnterMouseLook);
    // void __thiscall CInputManager::SetTextMode(CInputManager*,bool)
    public void SetTextMode(byte mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, byte, void>)0x00431590)(ref this, mode);
    // bool __thiscall CInputManager::UnregisterInputHandler(CInputManager*,CInputHandler*,unsigned int)
    public byte UnregisterInputHandler(ACBindings.CInputHandler* handler, uint modes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.CInputHandler*, uint, byte>)0x00431770)(ref this, handler, modes);
    // bool __thiscall CInputManager::UnregisterInputMap(CInputManager*,unsigned int,IInputActionCallback*)
    public byte UnregisterInputMap(uint i_id, ACBindings.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, uint, ACBindings.IInputActionCallback*, byte>)0x00431870)(ref this, i_id, i_pcCallback);
    // void __thiscall CInputManager::UnregisterCallback(CInputManager*,IInputActionCallback*)
    public void UnregisterCallback(ACBindings.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.IInputActionCallback*, void>)0x004318B0)(ref this, i_pcCallback);
    // void __thiscall CInputManager::RegisterPreferences(CInputManager*)
    public void RegisterPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, void>)0x004319B0)(ref this);
    // bool __thiscall CInputManager::IsActionInProgress(CInputManager*,unsigned int)
    public byte IsActionInProgress(uint i_action) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, uint, byte>)0x00431AF0)(ref this, i_action);
    // void __thiscall CInputManager::~CInputManager(CInputManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, void>)0x00431BE0)(ref this);
    // bool __thiscall CInputManager::GetMouseLookMode(CInputManager*)
    public byte GetMouseLookMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, byte>)0x00431CD0)(ref this);
    // bool __thiscall CInputManager::GetTextMode(CInputManager*)
    public byte GetTextMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, byte>)0x00431CE0)(ref this);
    // const ActionMap* __thiscall CInputManager::GetActionMap(CInputManager*)
    public ACBindings.ActionMap* GetActionMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.ActionMap*>)0x00431CF0)(ref this);
    // long double __thiscall CInputManager::GetLastInputTimestamp(CInputManager*)
    public double GetLastInputTimestamp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, double>)0x00431D00)(ref this);
    // bool __thiscall CInputManager::RegisterInputMap(CInputManager*,unsigned int,IInputActionCallback*,int)
    public byte RegisterInputMap(uint i_id, ACBindings.IInputActionCallback* i_pcCallback, int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, uint, ACBindings.IInputActionCallback*, int, byte>)0x00431D10)(ref this, i_id, i_pcCallback, i_nPriority);
    // void __thiscall CInputManager::UseTime(CInputManager*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, void>)0x00431D60)(ref this);
    // bool __thiscall CInputManager::RegisterInputHandler(CInputManager*,CInputHandler*,unsigned int)
    public byte RegisterInputHandler(ACBindings.CInputHandler* handler, uint modes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.CInputHandler*, uint, byte>)0x00432140)(ref this, handler, modes);
    // void __thiscall CInputManager::CInputManager(CInputManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, void>)0x00432430)(ref this);
    // void __thiscall CInputManager::ToggleActionKey(CInputManager*,InputEvent*)
    public void ToggleActionKey(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.InputEvent*, void>)0x00432620)(ref this, i_inEvt);
    // void __thiscall CInputManager::DeactivateActionKey(CInputManager*,InputEvent*)
    public void DeactivateActionKey(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.InputEvent*, void>)0x004326D0)(ref this, i_inEvt);
    // void __thiscall CInputManager::TurnOffRunLock(CInputManager*)
    public void TurnOffRunLock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, void>)0x00432780)(ref this);
    // void __thiscall CInputManager::ActivateActionKey(CInputManager*,InputEvent*)
    public void ActivateActionKey(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.InputEvent*, void>)0x004327F0)(ref this, i_inEvt);
    // void __thiscall CInputManager::FireActionEvent(CInputManager*,InputEvent*)
    public void FireActionEvent(ACBindings.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.InputEvent*, void>)0x004328C0)(ref this, i_inEvt);
    // ShortCutManager* __thiscall CInputManager::GetMouseX(PlayerModule*)
    public ACBindings.ShortCutManager* GetMouseX() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CInputManager, ACBindings.ShortCutManager*>)0x004F1B20)(ref this);
}

