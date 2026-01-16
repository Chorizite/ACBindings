namespace ACBindings.Internal;


/// <summary>Provides client‑side UI management, handling camera control, input callbacks, vendor and target interactions, cursor state, radar visibility, and sound table access for the game.</summary>
public unsafe struct ClientUISystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Statics
    public static ACBindings.Internal.ClientUISystem** s_pUISystem = (ACBindings.Internal.ClientUISystem**)0x00871354;

    // Child Types
    public unsafe struct ClientUISystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientUISystem*, ACBindings.Internal.ClientUISystem.Enum6> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientUISystem::Enum17
    public enum Enum17 : uint
    {
    }
    // ClientUISystem::Enum18
    public enum Enum18 : uint
    {
    }
    // ClientUISystem::Enum19
    public enum Enum19 : uint
    {
    }
    // ClientUISystem::Enum6
    public enum Enum6 : uint
    {
    }
    // ClientUISystem::Enum7
    public enum Enum7 : uint
    {
    }
    // ClientUISystem::Enum8
    public enum Enum8 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public uint m_cBusy;
    public uint groundObject;
    public uint requestedGroundObject;
    public uint vendorID;
    public uint attemptOpenVendorID;
    public uint attemptSaleObjectID;
    public ACBindings.Internal.Target_Mode targetMode;
    public ACBindings.Internal.IDClass____tagDataID m_didCurrentCursor;
    public ACBindings.Internal.CSoundTable* soundTable;
    public byte m_bLeaveTargetMode;
    public ACBindings.Internal.CameraSet* m_pCameraSet;
    public byte m_bRadarVisible;
    public byte m_bRadarBlank;

    // Generated Constructor
    public ClientUISystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the singleton instance of the client UI system.
    /// <code>Offset: 0x00564D30
    /// ClientUISystem* __cdecl ClientUISystem::GetUISystem()</code>
    /// </summary>
    /// <returns>A pointer to the active ClientUISystem, or nullptr if the system has not been initialized.</returns>
    public static ACBindings.Internal.ClientUISystem* GetUISystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientUISystem*>)0x00564D30)();

    /// <summary>Marks the client UI as ready during system startup.
    /// <code>Offset: 0x00564D40
    /// void __thiscall ClientUISystem::OnStartup(ClientUISystem*)</code>
    /// </summary>
    public void OnStartup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00564D40)(ref this);

    /// <summary>Retrieves the UI sound table, loading it on first request if not already initialized.
    /// <code>Offset: 0x00564D50
    /// const CSoundTable* __thiscall ClientUISystem::GetUISoundTable(ClientUISystem*)</code>
    /// </summary>
    /// <returns>The CSoundTable instance used for UI sound definitions.</returns>
    public ACBindings.Internal.CSoundTable* GetUISoundTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CSoundTable*>)0x00564D50)(ref this);

    /// <summary>
    /// Handles an item mana query response by updating the item's mana value and notifying relevant systems of success or failure.
    /// 
    /// <code>Offset: 0x00564D80
    /// unsigned int __thiscall ClientUISystem::Handle_Item__QueryItemManaResponse(ClientUISystem*,unsigned int,float,int)</code>
    /// </summary>
    /// <param name="target">Identifier of the item whose mana is being updated.</param>
    /// <param name="mana">The new mana value for the specified item.</param>
    /// <param name="fSuccess">Non‑zero if the query succeeded; zero if it failed.</param>
    /// <returns>Zero, indicating successful handling of the response event.</returns>
    public uint Handle_Item__QueryItemManaResponse(uint target, float mana, int fSuccess) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, float, int, uint>)0x00564D80)(ref this, target, mana, fSuccess);

    /// <summary>Attempts to sell an item with ID <paramref name="objectID"/> to a vendor identified by <paramref name="vendorID"/>.
    /// <code>Offset: 0x00564DB0
    /// void __thiscall ClientUISystem::AttemptSellToVendor(ClientUISystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="vendorID">The unique identifier of the target vendor.</param>
    /// <param name="objectID">The unique identifier of the item to be sold.</param>
    public void AttemptSellToVendor(uint vendorID, uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint, void>)0x00564DB0)(ref this, vendorID, objectID);

    /// <summary>Closes the current vendor interface when a vendor is active.
    /// <code>Offset: 0x00564E10
    /// void __thiscall ClientUISystem::CloseVendor(ClientUISystem*,bool)</code>
    /// </summary>
    /// <param name="updating">Specifies whether the vendor should remain open for updates; if false, clears the vendor ID before closing.</param>
    public void CloseVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, byte, void>)0x00564E10)(ref this, updating);

    /// <summary>Handles a character confirmation request by routing to the appropriate notice handler based on request type.
    /// <code>Offset: 0x00564E40
    /// int __stdcall ClientUISystem::Handle_Character__ConfirmationRequest(int,int,int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the confirmation request type (e.g., 1 for allegiance, 2 for skill alteration).</param>
    /// <param name="a2">Parameter associated with the request, such as target ID or value.</param>
    /// <param name="a3">Character identifier initiating the request.</param>
    /// <returns>Zero after processing the request; no error handling is performed.</returns>
    public static int Handle_Character__ConfirmationRequest(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, int>)0x00564E40)(a1, a2, a3);

    /// <summary>Invokes CM_Character::SendNotice_AbortConfirmationRequest to signal that a character confirmation dialog has finished, passing the user's choice and the associated context.
    /// <code>Offset: 0x00564F20
    /// unsigned int __thiscall ClientUISystem::Handle_Character__ConfirmationDone(ClientUISystem*,int,unsigned int)</code>
    /// </summary>
    /// <param name="confirm">Non‑zero if the user accepted the confirmation; zero if canceled.</param>
    /// <param name="context">Identifier for the pending confirmation request to be aborted.</param>
    /// <returns>Zero, indicating completion without errors.</returns>
    public uint Handle_Character__ConfirmationDone(int confirm, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, int, uint, uint>)0x00564F20)(ref this, confirm, context);

    /// <summary>Notifies the UI system of the world identifier during login processing.
    /// <code>Offset: 0x00564F40
    /// int __stdcall ClientUISystem::Handle_Login__WorldInfo(int,int,int)</code>
    /// </summary>
    /// <param name="a1">Reserved for future use; currently ignored.</param>
    /// <param name="a2">Reserved for future use; currently ignored.</param>
    /// <param name="a3">The numeric identifier of the world to be announced.</param>
    /// <returns>Zero, indicating successful handling.</returns>
    public static int Handle_Login__WorldInfo(int a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int, int, int>)0x00564F40)(a1, a2, a3);

    /// <summary>Creates and assigns a new CameraSet to the UI system using the provided SmartBox. If allocation fails, sets the camera set pointer to null.
    /// <code>Offset: 0x00564F60
    /// void __thiscall ClientUISystem::InitializeCameraSet(ClientUISystem*,SmartBox*)</code>
    /// </summary>
    /// <param name="i_pSmartBox">The SmartBox used to construct the CameraSet.</param>
    public void InitializeCameraSet(ACBindings.Internal.SmartBox* i_pSmartBox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.SmartBox*, void>)0x00564F60)(ref this, i_pSmartBox);

    /// <summary>Provides access to the ClientUISystem's CameraSet instance for camera control and configuration.
    /// <code>Offset: 0x00564F90
    /// CameraSet* __thiscall ClientUISystem::AccessCameraSet(ClientUISystem*)</code>
    /// </summary>
    /// <returns>The CameraSet object used by this ClientUISystem for managing camera state.</returns>
    public ACBindings.Internal.CameraSet* AccessCameraSet() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CameraSet*>)0x00564F90)(ref this);

    /// <summary>Displays the chat UI when i_bActive is true; otherwise performs no action.
    /// <code>Offset: 0x00564FA0
    /// void __thiscall ClientUISystem::RecvNotice_ToggleChatEntry(ClientUISystem*,bool)</code>
    /// </summary>
    /// <param name="i_bActive">True to show the chat entry, false to leave it hidden.</param>
    public void RecvNotice_ToggleChatEntry(byte i_bActive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, byte, void>)0x00564FA0)(ref this, i_bActive);

    /// <summary>Processes a friends list update by relaying the new data to the social system and returning a status code.
    /// <code>Offset: 0x00564FC0
    /// unsigned int __thiscall ClientUISystem::Handle_Social__FriendsUpdate(ClientUISystem*,const FriendDataList*,int)</code>
    /// </summary>
    /// <param name="friendDataList">The collection of friend information received from the server.</param>
    /// <param name="updateType">An integer flag indicating the nature of the update (e.g., added, removed, modified).</param>
    /// <returns>Zero on success; other values are not used by this implementation.</returns>
    public uint Handle_Social__FriendsUpdate(ACBindings.Internal.FriendDataList* friendDataList, int updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.FriendDataList*, int, uint>)0x00564FC0)(ref this, friendDataList, updateType);

    /// <summary>Broadcasts an updated character title table to the social system, prompting UI components to refresh.
    /// <code>Offset: 0x00564FE0
    /// unsigned int __thiscall ClientUISystem::Handle_Social__CharacterTitleTable(ClientUISystem*,const CharacterTitleTable*)</code>
    /// </summary>
    /// <param name="titleTable">The table containing the character's current titles and display information.</param>
    /// <returns>An unsigned integer status code; zero indicates successful handling.</returns>
    public uint Handle_Social__CharacterTitleTable(ACBindings.Internal.CharacterTitleTable* titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CharacterTitleTable*, uint>)0x00564FE0)(ref this, titleTable);

    /// <summary>Adds a character title and optionally designates it as the display title for the user.
    /// <code>Offset: 0x00565000
    /// unsigned int __thiscall ClientUISystem::Handle_Social__AddOrSetCharacterTitle(ClientUISystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="newTitle">Identifier of the title to be added.</param>
    /// <param name="bSetAsDisplayTitle">Non‑zero value sets this title as the current display title; zero leaves the existing display title unchanged.</param>
    /// <returns>Zero on success (currently always returned).</returns>
    public uint Handle_Social__AddOrSetCharacterTitle(uint newTitle, int bSetAsDisplayTitle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, int, uint>)0x00565000)(ref this, newTitle, bSetAsDisplayTitle);

    /// <summary>Updates the player's contract tracker table with data received from a social event.
    /// <code>Offset: 0x00565030
    /// unsigned int __thiscall ClientUISystem::Handle_Social__SendClientContractTrackerTable(ClientUISystem*,const CContractTrackerTable*)</code>
    /// </summary>
    /// <param name="contractTrackerTable">The contract tracker information to apply to the player system.</param>
    /// <returns>An unsigned integer status code, zero indicates successful update.</returns>
    public uint Handle_Social__SendClientContractTrackerTable(ACBindings.Internal.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CContractTrackerTable*, uint>)0x00565030)(ref this, contractTrackerTable);

    /// <summary>Handles the start barber event for a character by forwarding parameters to CM_Character::SendNotice_StartBarberNotice.
    /// <code>Offset: 0x00565050
    /// int __stdcall ClientUISystem::Handle_Character__StartBarber(int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)</code>
    /// </summary>
    /// <param name="a1">First argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a2">Second argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a3">Third argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a4">Fourth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a5">Fifth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a6">Sixth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a7">Seventh argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a8">Eighth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a9">Ninth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a10">Tenth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a11">Eleventh argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a12">Twelfth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a13">Thirteenth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a14">Fourteenth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a15">Fifteenth argument passed to SendNotice_StartBarberNotice.</param>
    /// <param name="a16">Sixteenth argument passed to SendNotice_StartBarberNotice.</param>
    /// <returns>Zero indicating the event was handled successfully.</returns>
    public static int Handle_Character__StartBarber(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16) => ((delegate* unmanaged[Stdcall]<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)0x00565050)(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16);

    /// <summary>Destroys a ClientUISystem instance, releasing references, unregistering event handlers, and cleaning up associated resources such as the camera set and radar visibility flags. Restores base class vtables to their original state before destruction.
    /// <code>Offset: 0x005650B0
    /// void __thiscall ClientUISystem::~ClientUISystem(ClientUISystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x005650B0)(ref this);

    /// <summary>Decrements the internal Turbine reference counter for the UI system and destroys its IInputActionCallback base when the count reaches zero.
    /// <code>Offset: 0x00565140
    /// unsigned int __thiscall ClientUISystem::Release(ClientUISystem*)</code>
    /// </summary>
    /// <returns>The updated reference count after decrementing, or zero if the object was released.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint>)0x00565140)(ref this);

    /// <summary>Shuts down the client UI system by clearing global references and releasing associated resources such as the sound table and camera set.
    /// <code>Offset: 0x00565170
    /// void __thiscall ClientUISystem::OnShutdown(ClientUISystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565170)(ref this);

    /// <summary>Attempts to retrieve a specified interface from this ClientUISystem instance. If successful, writes the interface pointer into o_ppvInterface (if supplied) and stores a success code in result; otherwise sets an error code indicating the interface is not supported.
    /// <code>Offset: 0x005651E0
    /// TResult* __thiscall ClientUISystem::QueryInterface(ClientUISystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Output structure receiving status code; on success m_val is 0, on failure it contains -2147467262.</param>
    /// <param name="i_rcInterface">GUID of the interface being queried.</param>
    /// <param name="o_ppvInterface">Optional output pointer that receives the address of the requested interface if available.</param>
    /// <returns>Pointer to the result structure containing the operation status.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x005651E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Changes the ground object displayed by the UI, clearing any existing selection, closing vendors, and optionally informing the server that inventory contents are no longer needed.
    /// <code>Offset: 0x005652B0
    /// void __thiscall ClientUISystem::SetGroundObject(ClientUISystem*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="groundObject">Identifier of the new ground object to display; zero clears the current selection.</param>
    /// <param name="askServer">If true, sends a notification to stop receiving contents for the previous ground object.</param>
    public void SetGroundObject(uint groundObject, byte askServer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte, void>)0x005652B0)(ref this, groundObject, askServer);

    /// <summary>Registers input action callbacks for the client UI system when a character session begins, binding this object’s callback interface to specific action IDs via the global ICIDM manager.
    /// <code>Offset: 0x00565380
    /// void __thiscall ClientUISystem::OnBeginCharacterSession(ClientUISystem*)</code>
    /// </summary>
    public void OnBeginCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565380)(ref this);

    /// <summary>Updates the UI cursor based on client state, including busy status, targeting mode, combat mode and current selection. Determines the appropriate cursor data ID and applies it through UIElementManager when a change occurs.
    /// <code>Offset: 0x005653D0
    /// void __thiscall ClientUISystem::UpdateCursorState(ClientUISystem*)</code>
    /// </summary>
    /// <param name="this">The ClientUISystem instance whose cursor state is updated.</param>
    public void UpdateCursorState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x005653D0)(ref this);

    /// <summary>Synchronizes a contract tracker with the player system, optionally deleting it or designating it as the current display.
    /// <code>Offset: 0x005654F0
    /// unsigned int __thiscall ClientUISystem::Handle_Social__SendClientContractTracker(ClientUISystem*,const CContractTracker*,int,int)</code>
    /// </summary>
    /// <param name="contractTracker">The contract tracker data to update.</param>
    /// <param name="bDeleteContract">If non‑zero, removes the contract from tracking.</param>
    /// <param name="bSetAsDisplayContract">If non‑zero, sets this contract as the one shown in UI.</param>
    /// <returns>Zero, indicating completion of the operation.</returns>
    public uint Handle_Social__SendClientContractTracker(ACBindings.Internal.CContractTracker* contractTracker, int bDeleteContract, int bSetAsDisplayContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.CContractTracker*, int, int, uint>)0x005654F0)(ref this, contractTracker, bDeleteContract, bSetAsDisplayContract);

    /// <summary>Initializes the client UI subsystem by configuring interface vtables, establishing reference counts, setting default state flags, and registering a notice handler with the global event system.
    /// <code>Offset: 0x00565540
    /// void __thiscall ClientUISystem::ClientUISystem(ClientUISystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565540)(ref this);

    /// <summary>Increments the internal busy counter; when transitioning from idle to busy (count changes from 0 to 1), updates the cursor state accordingly.
    /// <code>Offset: 0x00565610
    /// void __thiscall ClientUISystem::IncrementBusyCount(ClientUISystem*)</code>
    /// </summary>
    public void IncrementBusyCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565610)(ref this);

    /// <summary>Decrements the UI busy counter and updates the cursor state when the counter reaches zero.
    /// <code>Offset: 0x00565630
    /// void __thiscall ClientUISystem::DecrementBusyCount(ClientUISystem*)</code>
    /// </summary>
    public void DecrementBusyCount() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565630)(ref this);

    /// <summary>Closes any open trade or vendor windows, clears ground object selection, resets combat target status, and deselects the current selected object.
    /// <code>Offset: 0x00565640
    /// void __thiscall ClientUISystem::CleanUpGameUI(ClientUISystem*)</code>
    /// </summary>
    public void CleanUpGameUI() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565640)(ref this);

    /// <summary>Decrements the UI busy counter and restores cursor state when an item use completes; forwards a supplied error code to the communication system for handling.
    /// <code>Offset: 0x005656A0
    /// unsigned int __thiscall ClientUISystem::Handle_Item__UseDone(ClientUISystem*,const unsigned int)</code>
    /// </summary>
    /// <param name="etype">Error or event type related to the completed item usage; zero indicates no error.</param>
    /// <returns>Zero, unused as a status indicator.</returns>
    public uint Handle_Item__UseDone(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint>)0x005656A0)(ref this, etype);

    /// <summary>Changes the UI's target mode to the specified value and adjusts input handling and cursor appearance accordingly.
    /// <code>Offset: 0x005656E0
    /// void __thiscall ClientUISystem::SetTargetMode(ClientUISystem*,Target_Mode)</code>
    /// </summary>
    /// <param name="i_targetMode">The desired target mode, such as none or use-target.</param>
    public void SetTargetMode(ACBindings.Internal.Target_Mode i_targetMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.Target_Mode, void>)0x005656E0)(ref this, i_targetMode);

    /// <summary>Uses an object identified by i_iid or switches the UI into use mode when no ID is provided.
    /// <code>Offset: 0x00565750
    /// void __thiscall ClientUISystem::UseObject(ClientUISystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iid">The identifier of the object to use; zero indicates toggling to use mode if not already active.</param>
    public void UseObject(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, void>)0x00565750)(ref this, i_iid);

    /// <summary>Starts examining the object with the supplied ID or switches the UI into examine mode when no ID is provided.
    /// <code>Offset: 0x005657B0
    /// void __thiscall ClientUISystem::ExamineObject(ClientUISystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iid">The identifier of the ground object to examine; zero causes the system to enter examine target mode instead of targeting a specific object.</param>
    public void ExamineObject(uint i_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, void>)0x005657B0)(ref this, i_iid);

    /// <summary>Examines a specific spell by its identifier, or initiates examine mode when no ID is supplied.
    /// <code>Offset: 0x00565810
    /// void __thiscall ClientUISystem::ExamineSpell(ClientUISystem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_spellID">The unique identifier of the spell to examine; passing 0 enters examine mode without targeting a particular spell.</param>
    public void ExamineSpell(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, void>)0x00565810)(ref this, i_spellID);

    /// <summary>Ends the current character session by cleaning up game UI and resetting all related UI states such as cursor, target mode, radar visibility, ground objects, vendor interactions, and busy status.
    /// <code>Offset: 0x00565870
    /// void __thiscall ClientUISystem::OnEndCharacterSession(ClientUISystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565870)(ref this);

    /// <summary>Executes the specified target mode action—use, examine, or acquire—for the item identified by itemID.
    /// <code>Offset: 0x005658D0
    /// void __thiscall ClientUISystem::ExecuteTargetModeForItem(ClientUISystem*,unsigned int,Target_Mode)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the target item.</param>
    /// <param name="mode">The desired target mode to apply.</param>
    public void ExecuteTargetModeForItem(uint itemID, ACBindings.Internal.Target_Mode mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, ACBindings.Internal.Target_Mode, void>)0x005658D0)(ref this, itemID, mode);

    /// <summary>Executes a target mode action for the specified spell. If the mode is TARGET_MODE_EXAMINE, the spell is examined.
    /// <code>Offset: 0x00565910
    /// void __thiscall ClientUISystem::ExecuteTargetModeForSpell(ClientUISystem*,unsigned int,Target_Mode)</code>
    /// </summary>
    /// <param name="spellID">The unique identifier of the spell to act upon.</param>
    /// <param name="mode">The target mode specifying how the spell should be handled.</param>
    public void ExecuteTargetModeForSpell(uint spellID, ACBindings.Internal.Target_Mode mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, ACBindings.Internal.Target_Mode, void>)0x00565910)(ref this, spellID, mode);

    /// <summary>Processes an input event by mapping its action code to in‑game behaviour such as object usage, targeting, combat commands, UI toggles, screenshot capture, help or plugin manager access.
    /// <code>Offset: 0x00565930
    /// bool __thiscall ClientUISystem::OnAction(ClientUISystem*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event specifying the action and associated data (key, mouse position, etc.).</param>
    /// <returns>True if the event was handled; otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.InputEvent*, byte>)0x00565930)(ref this, i_evt);

    /// <summary>Displays a notification that the portal storm has subsided and updates related UI elements to reflect the change.
    /// <code>Offset: 0x00565CD0
    /// unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormSubsided(ClientUISystem*)</code>
    /// </summary>
    /// <returns>Zero, indicating successful completion of the operation.</returns>
    public uint Handle_Misc__PortalStormSubsided() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint>)0x00565CD0)(ref this);

    /// <summary>Notifies players that a Portal Storm is brewing due to crowding, plays the storm sound on the relevant physics object, and broadcasts the storm level based on the provided extent.
    /// <code>Offset: 0x00565D70
    /// unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormBrewing(ClientUISystem*,float)</code>
    /// </summary>
    /// <param name="extent">The intensity or radius of the portal storm to be communicated via notice.</param>
    /// <returns>Zero; return value not used.</returns>
    public uint Handle_Misc__PortalStormBrewing(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, float, uint>)0x00565D70)(ref this, extent);

    /// <summary>Displays a portal‑storm imminent notification, plays the associated sound effect for the current SmartBox object if present, and broadcasts the portal storm level to other subsystems.
    /// <code>Offset: 0x00565E40
    /// unsigned int __thiscall ClientUISystem::Handle_Misc__PortalStormImminent(ClientUISystem*,float)</code>
    /// </summary>
    /// <param name="extent">The numeric extent or intensity of the impending portal storm; used when sending the notice to other components.</param>
    /// <returns>Zero, indicating that the operation completed successfully.</returns>
    public uint Handle_Misc__PortalStormImminent(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, float, uint>)0x00565E40)(ref this, extent);

    /// <summary>Checks for player inactivity and logs off after a 20‑minute idle period, exits target mode when requested, updates cursor state, and releases associated resources.
    /// <code>Offset: 0x00565F90
    /// void __thiscall ClientUISystem::UseTime(ClientUISystem*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, void>)0x00565F90)(ref this);

    /// <summary>Processes a salvage operation result from the server and updates the UI scroll with detailed information about materials salvaged, non‑suitables, or failure.
    /// <code>Offset: 0x005663C0
    /// unsigned int __thiscall ClientUISystem::Handle_Inventory__Recv_SalvageOperationsResultData(ClientUISystem*,const SalvageOperationsResultData*)</code>
    /// </summary>
    /// <param name="operationsResultData">Contains details of the salvage operation, including results, skill used, and any augmentation bonus.</param>
    /// <returns>Zero indicating successful handling; callers ignore this return value.</returns>
    public uint Handle_Inventory__Recv_SalvageOperationsResultData(ACBindings.Internal.SalvageOperationsResultData* operationsResultData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, ACBindings.Internal.SalvageOperationsResultData*, uint>)0x005663C0)(ref this, operationsResultData);

    /// <summary>Processes the client's request to view an object's contents by interacting with the client object maintenance system, retrieving the specified weenie object, clearing any pending destruction queue entries, and updating ground‑object state if applicable.
    /// <code>Offset: 0x00566610
    /// void __thiscall ClientUISystem::OnViewContents(_DWORD*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the object whose contents are requested.</param>
    /// <param name="a3">Additional flag or context influencing how the view is processed.</param>
    public void OnViewContents(uint object_id, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, int, void>)0x00566610)(ref this, object_id, a3);

    /// <summary>Handles the result of a targeted item usage attempt by interpreting properties from the supplied collection, updating cursor state, triggering inventory events, and invoking any associated callbacks.
    /// <code>Offset: 0x00566700
    /// void __cdecl ClientUISystem::TargetedUsageCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Collection containing property data about the attempted use action.</param>
    public static void TargetedUsageCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x00566700)(i_rcResults);

    /// <summary>Handles client‑side processing after an object or item has been used, interpreting results from the property collection, triggering inventory usage events, updating UI cursor state, notifying the player system of the usage, and logging a localized “Using the …” message to the scroll window.
    /// <code>Offset: 0x005668C0
    /// void __cdecl ClientUISystem::UsageCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Collection of properties describing the outcome of the use action, including identifiers for used items or objects.</param>
    public static void UsageCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x005668C0)(i_rcResults);

    /// <summary>Processes vendor information from a data buffer, updating UI state and notifying relevant components about the opened vendor and any pending sale actions.
    /// <code>Offset: 0x00566AB0
    /// void __thiscall ClientUISystem::Handle_VendorInfo(ClientUISystem*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="buff">Pointer to the serialized vendor data packet.</param>
    /// <param name="size">Size of the data packet in bytes.</param>
    public void Handle_VendorInfo(System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, System.IntPtr, uint, void>)0x00566AB0)(ref this, buff, size);

    /// <summary>Formats an elapsed time given in seconds into a human‑readable string containing months (mo), days (d), hours (h), minutes (m) and seconds (s). The resulting text is returned via a newly allocated wide‑character buffer.
    /// <code>Offset: 0x00566BB0
    /// char __cdecl ClientUISystem::DeltaTimeToString(double,wchar_t**)</code>
    /// </summary>
    /// <param name="a1">Elapsed time to format, expressed in seconds.</param>
    /// <param name="a2">Receives a pointer to the newly allocated wide‑character string containing the formatted time; the caller owns this memory and must release it when no longer needed.</param>
    /// <returns>Always returns 1 to indicate successful formatting.</returns>
    public static sbyte DeltaTimeToString(double a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<double, System.IntPtr, sbyte>)0x00566BB0)(a1, a2);

    /// <summary>Prompts the player to confirm using a Mana Stone on a specified target, asking whether to destroy the target and drain its mana into the stone. Builds a confirmation dialog with relevant properties in the current UI context.
    /// <code>Offset: 0x00566EE0
    /// bool __thiscall ClientUISystem::TargetedUsageConfirmation_ManaStone(ClientUISystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="toolID">Identifier of the Mana Stone item being used.</param>
    /// <param name="targetID">Identifier of the object whose mana will be drained.</param>
    /// <returns>Always true, indicating that the confirmation dialog was created and shown.</returns>
    public byte TargetedUsageConfirmation_ManaStone(uint toolID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint, byte>)0x00566EE0)(ref this, toolID, targetID);

    /// <summary>Displays a confirmation dialog informing the player that using this altar will grant player‑killer status, then registers the selected altar ID for subsequent processing.
    /// <code>Offset: 0x005671C0
    /// bool __thiscall ClientUISystem::UsageConfirmation_PKAltar(ClientUISystem*,unsigned int)</code>
    /// </summary>
    /// <param name="altarID">Identifier of the PK altar to confirm usage for.</param>
    /// <returns>Always returns true.</returns>
    public byte UsageConfirmation_PKAltar(uint altarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte>)0x005671C0)(ref this, altarID);

    /// <summary>Displays a confirmation dialog when attempting to use an NPK altar, warning that doing so will turn the player into a non‑player killer and prevent attacking or being attacked by other player killers.
    /// <code>Offset: 0x005673B0
    /// bool __thiscall ClientUISystem::UsageConfirmation_NPKAltar(ClientUISystem*,unsigned int)</code>
    /// </summary>
    /// <param name="altarID">The identifier of the altar being used.</param>
    /// <returns>True if the confirmation dialog was created successfully; otherwise false (always true in current implementation).</returns>
    public byte UsageConfirmation_NPKAltar(uint altarID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte>)0x005673B0)(ref this, altarID);

    /// <summary>Creates and displays a confirmation dialog asking the user whether to use a specified rare item.
    /// <code>Offset: 0x005675A0
    /// bool __thiscall ClientUISystem::UsageConfirmation_VolatileRare(ClientUISystem*,unsigned int)</code>
    /// </summary>
    /// <param name="rareID">The identifier of the rare item to be used.</param>
    /// <returns>True if the dialog was created successfully; always returns true in this implementation.</returns>
    public byte UsageConfirmation_VolatileRare(uint rareID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, byte>)0x005675A0)(ref this, rareID);

    /// <summary>Displays a confirmation dialog for salvaging the specified tool on the target object and initiates the associated callback.
    /// <code>Offset: 0x00567790
    /// bool __thiscall ClientUISystem::TargetedUsageConfirmation_Salvage(ClientUISystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="toolID">Identifier of the item used to perform salvage.</param>
    /// <param name="targetID">Identifier of the object being salvaged.</param>
    /// <returns>True, indicating the dialog was successfully created.</returns>
    public byte TargetedUsageConfirmation_Salvage(uint toolID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint, uint, byte>)0x00567790)(ref this, toolID, targetID);

    /// <summary>Increments the internal reference count of the specified client communication system and returns the new count.
    /// <code>Offset: 0x0056F560
    /// unsigned int __thiscall ClientUISystem::AddRef(ClientCommunicationSystem*)</code>
    /// </summary>
    /// <param name="this">The client communication system instance whose reference counter is to be incremented.</param>
    /// <returns>The updated reference count after incrementing.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientUISystem, uint>)0x0056F560)(ref this);
}

