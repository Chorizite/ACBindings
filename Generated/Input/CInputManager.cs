namespace ACBindings.Internal;


/// <summary>Central manager for processing user input, maintaining lists of handlers for actions, character entry, mouse look/movement, and focus changes while tracking modes such as text entry and mouse‑look activation. Handles registration and removal of handlers and action maps, updates action states over time, and dispatches events to listeners based on the current state.</summary>
public unsafe struct CInputManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ICIDM BaseClass_ICIDM; // ACBindings.Internal.ICIDM

    // Statics
    public static double* sm_timeKeyRepeatDelay = (double*)0x00818A78;
    public static double* sm_timeKeyRepeatSpeed = (double*)0x00818A80;

    // Child Types
    public unsafe struct CInputManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, void> CInputManager_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, int, byte> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> InitializeKeymap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, double> GetLastInputTimestamp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, int> GetMouseX; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, int> GetMouseY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, int, int, byte> SetMouseXY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> ClearKeyMap; // function pointer
        public fixed byte gap28[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint, byte> AddKeyMap; // function pointer
        public System.IntPtr SaveKeyMap;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint, ACBindings.Internal.IInputActionCallback*, int, byte> RegisterInputMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint, ACBindings.Internal.IInputActionCallback*, byte> UnregisterInputMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.IInputActionCallback*, void> UnregisterCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint, byte> SetActionMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.ActionMap*> GetActionMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.CInputHandler*, uint, byte> RegisterInputHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.CInputHandler*, uint, byte> UnregisterInputHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.ControlSpecification, byte> IsMetaKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.ControlSpecification, ACBindings.Internal.DeviceType> GetDeviceTypeFromKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> ShiftKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> CtrlKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> AltKeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte, void> SetMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> GetMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.MouseLookBehavior, int, int, void> ConfigureMouseLookMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, System.IntPtr, byte*, int> OnMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte, void> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, void> OnUIElementActivationChanging; // function pointer
        public fixed byte gap7C[4];
        public System.IntPtr GetNameFromKey;
        public System.IntPtr GetNameFromMetaKey;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.QualifiedControl, uint, uint, byte> BindAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.QualifiedControl, uint, byte> UnbindByKey; // function pointer
        public System.IntPtr FindKeysForAction;
        public System.IntPtr FindConflictingInputMaps;
        public System.IntPtr FindConflictingControls;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint, uint, byte> UnbindAllByAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint> GetDoubleClickDelay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, uint> GetTapDelay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte, void> SetTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte> GetTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte, void> OnSwitchMouseMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, byte, void> OnSwitchTextMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CInputManager*, ACBindings.Internal.InputEvent*, void> SendActionToListeners; // function pointer

        // Methods
    }

    /// <summary>Links a specific input map identifier to an input action callback and assigns its handling priority within the input manager.</summary>
    public unsafe struct InputMapEntry
    {
        // Members
        public uint m_mapID;
        public ACBindings.Internal.IInputActionCallback* m_pcCallback;
        public int m_nPriority;

        // Methods
    }

    // Members
    public ACBindings.Internal.tagPOINT m_ptMousePos;
    public double m_ttLastInputEvent;
    public byte m_fWantMouseLookMode;
    public byte m_fInMouseLookMode;
    public byte m_textMode;
    public byte m_lastFocus;
    public ACBindings.Internal.List___CInputHandler_ptr m_actionList;
    public ACBindings.Internal.List___CInputHandler_ptr m_characterList;
    public ACBindings.Internal.List___CInputHandler_ptr m_mouseLookList;
    public ACBindings.Internal.List___CInputHandler_ptr m_mouseMoveList;
    public ACBindings.Internal.List___CInputHandler_ptr m_focusSwitchList;
    public ACBindings.Internal.List___CInputManager_InputMapEntry m_inputMapList;
    public ACBindings.Internal.CInputHandler* m_pKeyHitHandler;
    public float m_MouseLookSensitivity;
    public float m_MouseLookSmoothingAmount;
    public byte m_InvertMouseLookYAxis;
    public byte m_UseMouseTurning;
    public ACBindings.Internal.ActionMap* m_action_map;
    public ACBindings.Internal.IntrusiveHashTable__uint___ActionState_ptr m_hashActionStates;

    // Generated Constructor
    public CInputManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the input manager by activating its base component and loading a default action mapping.
    /// <code>Offset: 0x00430E00
    /// bool __thiscall CInputManager::OnStartup(CInputManager*,int)</code>
    /// </summary>
    /// <param name="dwUserData">Optional data passed to startup, currently unused.</param>
    /// <returns>True if an action map was successfully retrieved; otherwise false.</returns>
    public byte OnStartup(int dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, int, byte>)0x00430E00)(ref this, dwUserData);

    /// <summary>Sets the current input action map to the one identified by actID, releasing any previously active map.
    /// <code>Offset: 0x00430E50
    /// bool __thiscall CInputManager::SetActionMap(CInputManager*,unsigned int)</code>
    /// </summary>
    /// <param name="actID">Identifier of the action map to activate.</param>
    /// <returns>True if a valid action map was retrieved and set; otherwise false.</returns>
    public byte SetActionMap(uint actID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, uint, byte>)0x00430E50)(ref this, actID);

    /// <summary>Switches the input manager between normal mouse movement and mouse‑look mode based on the provided flag.
    /// <code>Offset: 0x00430E90
    /// void __thiscall CInputManager::OnSwitchMouseMode(CInputManager*,bool)</code>
    /// </summary>
    /// <param name="fEnterMouseLook">Indicates whether to enable (true) or disable (false) mouse‑look mode.</param>
    public void OnSwitchMouseMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, byte, void>)0x00430E90)(ref this, fEnterMouseLook);

    /// <summary>Invokes the currently assigned input handler for a key hit event, forwarding the qualified control and capturing the resulting action ID.
    /// <code>Offset: 0x00430EA0
    /// bool __thiscall CInputManager::CallKeyHitHandler(CInputManager*,const QualifiedControl*,unsigned int*)</code>
    /// </summary>
    /// <param name="i_key">The qualified key specification to handle.</param>
    /// <param name="o_idAction">Receives the identifier of the action triggered by the key hit.</param>
    /// <returns>True if a handler processed the key hit and returned true; otherwise false.</returns>
    public byte CallKeyHitHandler(ACBindings.Internal.QualifiedControl* i_key, uint* o_idAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.QualifiedControl*, uint*, byte>)0x00430EA0)(ref this, i_key, o_idAction);

    /// <summary>Begins processing for a specified input event by marking it as started and delegating initialization of its key map to the base implementation.
    /// <code>Offset: 0x00430EC0
    /// void __thiscall CInputManager::StartAction(CInputManager*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The input event that will be marked as starting and initialized.</param>
    public void StartAction(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.InputEvent*, void>)0x00430EC0)(ref this, i_inEvt);

    /// <summary>Notifies all registered character input handlers with the supplied character when the manager is in text mode.
    /// <code>Offset: 0x00431350
    /// void __thiscall CInputManager::CallCharacterHandler(CInputManager*,wchar_t)</code>
    /// </summary>
    /// <param name="charToHandle">The Unicode character that should be processed by each handler.</param>
    public void CallCharacterHandler(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, System.Char, void>)0x00431350)(ref this, charToHandle);

    /// <summary>Invokes every registered mouse move handler, passing the supplied cursor coordinates.
    /// <code>Offset: 0x00431390
    /// void __thiscall CInputManager::CallMouseMoveHandler(CInputManager*,int,int)</code>
    /// </summary>
    /// <param name="cx">Horizontal coordinate of the mouse position.</param>
    /// <param name="cy">Vertical coordinate of the mouse position.</param>
    public void CallMouseMoveHandler(int cx, int cy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, int, int, void>)0x00431390)(ref this, cx, cy);

    /// <summary>Dispatches mouse movement deltas to all registered mouse-look handlers.
    /// <code>Offset: 0x004313C0
    /// void __thiscall CInputManager::CallMouseLookHandler(CInputManager*,int,int)</code>
    /// </summary>
    /// <param name="dxpos">Horizontal change in mouse position.</param>
    /// <param name="dypos">Vertical change in mouse position.</param>
    public void CallMouseLookHandler(int dxpos, int dypos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, int, int, void>)0x004313C0)(ref this, dxpos, dypos);

    /// <summary>Calls each handler registered in the focus‑switch list, passing the updated focus state and mode flags.
    /// <code>Offset: 0x004313F0
    /// void __thiscall CInputManager::CallFocusSwitchHandler(CInputManager*,bool)</code>
    /// </summary>
    /// <param name="have_focus">True when the input manager gains focus; false when it loses focus.</param>
    public void CallFocusSwitchHandler(byte have_focus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, byte, void>)0x004313F0)(ref this, have_focus);

    /// <summary>Dispatches an input event to registered listeners, invoking a supplied callback first; if the callback does not handle the event and the manager has focus, forwards the event to all handlers in its action list.
    /// <code>Offset: 0x00431440
    /// void __thiscall CInputManager::SendActionToListeners(CInputManager*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The input event containing the action details and an optional callback handler.</param>
    public void SendActionToListeners(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.InputEvent*, void>)0x00431440)(ref this, i_inEvt);

    /// <summary>Sets the desired mouse‑look mode, updating internal state and notifying focus switch listeners.
    /// <code>Offset: 0x00431560
    /// void __thiscall CInputManager::SetMouseLookMode(CInputManager*,bool)</code>
    /// </summary>
    /// <param name="fEnterMouseLook">True to activate mouse‑look mode; false to deactivate.</param>
    public void SetMouseLookMode(byte fEnterMouseLook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, byte, void>)0x00431560)(ref this, fEnterMouseLook);

    /// <summary>Switches the input manager between text and non‑text mode, updating its internal flag and notifying observers of the new state.
    /// <code>Offset: 0x00431590
    /// void __thiscall CInputManager::SetTextMode(CInputManager*,bool)</code>
    /// </summary>
    /// <param name="mode">True to enable text mode; false to disable it.</param>
    public void SetTextMode(byte mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, byte, void>)0x00431590)(ref this, mode);

    /// <summary>Detaches the specified input handler from one or more internal lists according to a bitmask of modes.
    /// <code>Offset: 0x00431770
    /// bool __thiscall CInputManager::UnregisterInputHandler(CInputManager*,CInputHandler*,unsigned int)</code>
    /// </summary>
    /// <param name="handler">The input handler to remove.</param>
    /// <param name="modes">A bitmask selecting which categories to search: 1=action, 2=character, 4=mouse‑look, 8=focus switch, 0x10=mouse move, 0x20=key‑hit handler.</param>
    /// <returns>True if the handler was removed or not present; false only when mode 0x20 is set and the handler does not match the current key‑hit handler.</returns>
    public byte UnregisterInputHandler(ACBindings.Internal.CInputHandler* handler, uint modes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.CInputHandler*, uint, byte>)0x00431770)(ref this, handler, modes);

    /// <summary>Removes a registered input map matching the specified identifier and callback from the manager.
    /// <code>Offset: 0x00431870
    /// bool __thiscall CInputManager::UnregisterInputMap(CInputManager*,unsigned int,IInputActionCallback*)</code>
    /// </summary>
    /// <param name="i_id">The unique identifier of the input map to unregister.</param>
    /// <param name="i_pcCallback">The callback associated with the input map.</param>
    /// <returns>True if an entry was found and removed; otherwise, false.</returns>
    public byte UnregisterInputMap(uint i_id, ACBindings.Internal.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, uint, ACBindings.Internal.IInputActionCallback*, byte>)0x00431870)(ref this, i_id, i_pcCallback);

    /// <summary>Unregisters the specified input action callback, clearing its association in all action states and removing related entries from the input map list.
    /// <code>Offset: 0x004318B0
    /// void __thiscall CInputManager::UnregisterCallback(CInputManager*,IInputActionCallback*)</code>
    /// </summary>
    /// <param name="i_pcCallback">The callback to remove from registration.</param>
    public void UnregisterCallback(ACBindings.Internal.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.IInputActionCallback*, void>)0x004318B0)(ref this, i_pcCallback);

    /// <summary>Registers input‑related user preferences such as mouse look sensitivity, smoothing amount, inversion of vertical rotation, and character turning mode.
    /// <code>Offset: 0x004319B0
    /// void __thiscall CInputManager::RegisterPreferences(CInputManager*)</code>
    /// </summary>
    public void RegisterPreferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, void>)0x004319B0)(ref this);

    /// <summary>Determines whether the specified action id is currently active within the input manager.
    /// <code>Offset: 0x00431AF0
    /// bool __thiscall CInputManager::IsActionInProgress(CInputManager*,unsigned int)</code>
    /// </summary>
    /// <param name="i_action">The numeric identifier of the action to query.</param>
    /// <returns>True if the action is in progress; otherwise, false.</returns>
    public byte IsActionInProgress(uint i_action) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, uint, byte>)0x00431AF0)(ref this, i_action);

    /// <summary>Cleans up all resources associated with an input manager instance, including unregistering global configuration variables, releasing the associated action map, deallocating any dynamic hash table buckets, clearing all internal lists of input handlers and mapping entries, and resetting virtual tables to their base state.
    /// <code>Offset: 0x00431BE0
    /// void __thiscall CInputManager::~CInputManager(CInputManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, void>)0x00431BE0)(ref this);

    /// <summary>Determines whether mouse look mode has been requested by the user.
    /// <code>Offset: 0x00431CD0
    /// bool __thiscall CInputManager::GetMouseLookMode(CInputManager*)</code>
    /// </summary>
    /// <returns>true if the manager is set to use mouse look mode, otherwise false.</returns>
    public byte GetMouseLookMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, byte>)0x00431CD0)(ref this);

    /// <summary>Retrieves whether the input manager is currently in text mode.
    /// <code>Offset: 0x00431CE0
    /// bool __thiscall CInputManager::GetTextMode(CInputManager*)</code>
    /// </summary>
    /// <returns>True if text mode is active; otherwise false.</returns>
    public byte GetTextMode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, byte>)0x00431CE0)(ref this);

    /// <summary>Retrieves the action map currently assigned to this input manager.
    /// <code>Offset: 0x00431CF0
    /// const ActionMap* __thiscall CInputManager::GetActionMap(CInputManager*)</code>
    /// </summary>
    /// <returns>A constant pointer to the active ActionMap, which defines how inputs are interpreted.</returns>
    public ACBindings.Internal.ActionMap* GetActionMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.ActionMap*>)0x00431CF0)(ref this);

    /// <summary>Returns the timestamp of the most recent input event.
    /// <code>Offset: 0x00431D00
    /// long double __thiscall CInputManager::GetLastInputTimestamp(CInputManager*)</code>
    /// </summary>
    /// <returns>The time (in seconds) at which the last input was processed.</returns>
    public double GetLastInputTimestamp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, double>)0x00431D00)(ref this);

    /// <summary>Registers an input map entry with a unique identifier, callback interface, and priority into the manager’s list. Returns true when added successfully or false if the entry already exists.
    /// <code>Offset: 0x00431D10
    /// bool __thiscall CInputManager::RegisterInputMap(CInputManager*,unsigned int,IInputActionCallback*,int)</code>
    /// </summary>
    /// <param name="i_id">Identifier for the input map to register.</param>
    /// <param name="i_pcCallback">Pointer to the callback interface that handles input actions.</param>
    /// <param name="i_nPriority">Priority value determining the order of processing relative to other maps.</param>
    /// <returns>True if the entry was inserted; false if an identical entry is already present or insertion fails.</returns>
    public byte RegisterInputMap(uint i_id, ACBindings.Internal.IInputActionCallback* i_pcCallback, int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, uint, ACBindings.Internal.IInputActionCallback*, int, byte>)0x00431D10)(ref this, i_id, i_pcCallback, i_nPriority);

    /// <summary>Processes the current time to update action states, handling key repeats and toggle actions, and dispatches corresponding input events.
    /// <code>Offset: 0x00431D60
    /// void __thiscall CInputManager::UseTime(CInputManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, void>)0x00431D60)(ref this);

    /// <summary>
    /// Registers an input handler into one or more input categories based on the supplied mode bitmask, adding it to the appropriate internal lists and optionally setting it as the exclusive key‑hit handler.
    /// 
    /// <code>Offset: 0x00432140
    /// bool __thiscall CInputManager::RegisterInputHandler(CInputManager*,CInputHandler*,unsigned int)</code>
    /// </summary>
    /// <param name="handler">The input handler to register.</param>
    /// <param name="modes">Bit mask specifying which input categories to add the handler for:
    ///   • 0x01 – action list
    ///   • 0x02 – character list
    ///   • 0x04 – mouse look list
    ///   • 0x08 – focus switch list
    ///   • 0x10 – mouse move list
    ///   • 0x20 – key‑hit handler (only one may be registered; returns false if already set)
    /// </param>
    /// <returns>True if the handler was successfully added or assigned as the key‑hit handler; false if a key‑hit handler is already present.</returns>
    public byte RegisterInputHandler(ACBindings.Internal.CInputHandler* handler, uint modes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.CInputHandler*, uint, byte>)0x00432140)(ref this, handler, modes);

    /// <summary>Initializes a CInputManager instance, setting default values for mouse look mode, text mode, focus handling, and input handler lists. Registers user preferences and configures key repeat delay and speed from system parameters.
    /// <code>Offset: 0x00432430
    /// void __thiscall CInputManager::CInputManager(CInputManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, void>)0x00432430)(ref this);

    /// <summary>Toggles an action key state: starts it if not already active, otherwise stops and cleans up the existing state.
    /// <code>Offset: 0x00432620
    /// void __thiscall CInputManager::ToggleActionKey(CInputManager*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The input event whose action to toggle; its start flag is updated and it triggers initialization of the key map.</param>
    public void ToggleActionKey(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.InputEvent*, void>)0x00432620)(ref this, i_inEvt);

    /// <summary>Deactivates an action key by removing it from the current action state and, when no keys remain active for that action, removes the mapping entry and frees associated resources.
    /// <code>Offset: 0x004326D0
    /// void __thiscall CInputManager::DeactivateActionKey(CInputManager*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The input event representing the key to deactivate.</param>
    public void DeactivateActionKey(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.InputEvent*, void>)0x004326D0)(ref this, i_inEvt);

    /// <summary>Disables the run‑lock action state by removing it from the input manager’s hash table and notifying the keymap system of the change.
    /// <code>Offset: 0x00432780
    /// void __thiscall CInputManager::TurnOffRunLock(CInputManager*)</code>
    /// </summary>
    public void TurnOffRunLock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, void>)0x00432780)(ref this);

    /// <summary>Activates an action key by ensuring its ActionState exists, registering the key press, handling special run‑lock actions, marking the event as started, and delegating to the manager’s virtual InitializeKeymap implementation.
    /// <code>Offset: 0x004327F0
    /// void __thiscall CInputManager::ActivateActionKey(CInputManager*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The InputEvent describing the pressed key; may be updated to indicate that the action has begun.</param>
    public void ActivateActionKey(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.InputEvent*, void>)0x004327F0)(ref this, i_inEvt);

    /// <summary>Processes an input event by determining its toggle type from the action map and invoking the appropriate key handling routine—activate, deactivate, toggle, or start—based on the event’s extent.
    /// <code>Offset: 0x004328C0
    /// void __thiscall CInputManager::FireActionEvent(CInputManager*,InputEvent*)</code>
    /// </summary>
    /// <param name="i_inEvt">The input event to fire; contains action information, input extent, and key data. Its toggle type is set according to the action map before processing.</param>
    public void FireActionEvent(ACBindings.Internal.InputEvent* i_inEvt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.InputEvent*, void>)0x004328C0)(ref this, i_inEvt);

    /// <summary>Retrieves the shortcut manager associated with a specified player module, providing access to the player's configured shortcuts.
    /// <code>Offset: 0x004F1B20
    /// ShortCutManager* __thiscall CInputManager::GetMouseX(PlayerModule*)</code>
    /// </summary>
    /// <param name="this">Pointer to the PlayerModule whose shortcuts are requested.</param>
    /// <returns>Pointer to the ShortCutManager instance stored in the given PlayerModule.</returns>
    public ACBindings.Internal.ShortCutManager* GetMouseX() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CInputManager, ACBindings.Internal.ShortCutManager*>)0x004F1B20)(ref this);
}

