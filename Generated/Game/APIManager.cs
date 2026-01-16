namespace ACBindings.Internal;


/// <summary>Manages access to the AC plugin and Asheron's Call implementation, handling initialization, readiness checks, and UI state.</summary>
public unsafe struct APIManager
{
    // Statics
    public static ACBindings.Internal.APIManager** m_pCliAPI = (ACBindings.Internal.APIManager**)0x00871054;
    public static int* m_UIReady = (int*)0x00871058;

    // Child Types

    /// <summary>Implements the Asheron’s Call client API, providing methods to manage character sessions, interact with the user interface, manipulate items, and coordinate with the SmartBox system for automation.</summary>
    /// <remarks>Supports COM reference counting via AddRef and Release. Acts as a bridge between the game's UI layer and client logic.</remarks>
    /// <seealso cref="APIManager::IAsheronsCall"/>
    public unsafe struct IAsheronsCallImpl
    {
        // Base Classes
        public ACBindings.Internal.IAsheronsCall BaseClass_IAsheronsCall; // ACBindings.Internal.IAsheronsCall

        // Child Types
        public unsafe struct IAsheronsCallImpl_vtbl
        {
            // Members
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ushort*, ACBindings.Internal.eChatTypes, int> WriteToChat; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ushort*, int, int> IssueChatBarCommand; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SelectItem; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SetSelectedObjectID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SetPreviousSelectedItemID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetSelectedItemID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetPreviousSelectedItemID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> ExamineObject; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> UseObject; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int> UseObjectOn; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int> UseEquippedItem; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ACBindings.Internal.eCombatMode, int> ChangeCombatMode; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, ACBindings.Internal.eCombatMode*, int> GetCombatMode; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int, int> MoveItemExternal; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int, int, int> MoveItemInternal; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, uint, int> CastSpell; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> GetBusyCount; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> IncrementBusyCount; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> DecrementBusyCount; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> IsStandingStill; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> StopCompletely; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, float, int> TurnToHeading; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int, int> SetAutoRun; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> GetIsOutdoors; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, double*, double*, int> GetCurCoords; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, float*, float*, float*, float*, int> GetCurLoc; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetPlayerID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetVendorID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetGroundContainerID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> GetSelectedStackCount; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SetSelectedStackCount; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> TradeWindow_IsOpen; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint*, int> TradeWindow_GetPartnerID; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> TradeWindow_AddItem; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> TradeWindow_Clear; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> TradeWindow_Accept; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> TradeWindow_Close; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SalvagePanel_Open; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SalvagePanel_Add; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> SalvagePanel_Remove; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> SalvagePanel_Close; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> SalvagePanel_Clear; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> SalvagePanel_Salvage; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int> EndCharacterSession; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int> BeginCharacterSession; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int> GetChatState; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, int*, int*, int> GetScreenDimensions; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, int*, int> ItemIsKnown; // function pointer
            public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IAsheronsCall*, uint, ushort**, int> GetItemName; // function pointer

            // Methods
        }

        // Members
        public int m_cRef;

        // Methods

        /// <summary>Increments the object's internal reference counter in a thread‑safe manner and returns the updated count.
        /// <code>Offset: 0x0055A7B0
        /// unsigned int __stdcall APIManager::IAsheronsCallImpl::AddRef(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        /// <param name="this">The instance whose reference count is increased.</param>
        /// <returns>The new reference count after incrementing.</returns>
        public static uint AddRef(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint>)0x0055A7B0)(this_);

        /// <summary>Attempts to send a chat‑bar command using the supplied UTF‑16 text. Currently returns E_FAIL regardless of input.
        /// <code>Offset: 0x0055A7D0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::IssueChatBarCommand(APIManager::IAsheronsCallImpl*,unsigned __int16*,const int)</code>
        /// </summary>
        /// <param name="txt">UTF‑16 string containing the command text to be sent.</param>
        /// <param name="isBotOriginated">Non‑zero if the command is generated by a bot; zero for user input.</param>
        /// <returns>HRESULT indicating success or failure. Currently always E_FAIL (0x80004005).</returns>
        public static int IssueChatBarCommand(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, ushort* txt, int isBotOriginated) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, ushort*, int, int>)0x0055A7D0)(this_, txt, isBotOriginated);

        /// <summary>Selects the specified game object as the current selection.
        /// <code>Offset: 0x0055A7E0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SelectItem(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        /// <param name="objectID">The unique identifier of the object to select.</param>
        /// <returns>Zero (S_OK) indicating success.</returns>
        public static int SelectItem(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A7E0)(this_, objectID);

        /// <summary>Assigns the specified object ID as the current selection for this call implementation.
        /// <code>Offset: 0x0055A800
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetSelectedObjectID(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        /// <param name="objectID">Identifier of the object to select.</param>
        /// <returns>S_OK (zero) on success.</returns>
        public static int SetSelectedObjectID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A800)(this_, objectID);

        /// <summary>Records the supplied item ID as the previously selected object within the Asheron's Call context.
        /// <code>Offset: 0x0055A820
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetPreviousSelectedItemID(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        /// <param name="objectID">The identifier of the item to store as the last selected object.</param>
        /// <returns>Zero on success; a nonzero HRESULT indicates failure.</returns>
        public static int SetPreviousSelectedItemID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A820)(this_, objectID);

        /// <summary>Retrieves the identifier of the currently selected item.
        /// <code>Offset: 0x0055A840
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetSelectedItemID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        /// <param name="selectedID">Pointer to receive the selected item's identifier.</param>
        /// <returns>S_OK (0) on success; this implementation never fails.</returns>
        public static int GetSelectedItemID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* selectedID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A840)(this_, selectedID);

        /// <summary>Retrieves the ID of the previously selected item and stores it in the supplied variable.
        /// <code>Offset: 0x0055A860
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetPreviousSelectedItemID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        /// <param name="selectedID">Pointer to unsigned int that receives the previous selection ID.</param>
        /// <returns>S_OK (0), indicating successful retrieval of the ID.</returns>
        public static int GetPreviousSelectedItemID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* selectedID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A860)(this_, selectedID);

        /// <summary>Examines the specified object in the client user interface.
        /// <code>Offset: 0x0055A880
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::ExamineObject(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        /// <param name="objectID">The identifier of the object to examine.</param>
        /// <returns>S_OK (0) indicating successful execution.</returns>
        public static int ExamineObject(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A880)(this_, objectID);

        /// <summary>Activates the object identified by the supplied ID via ItemHolder.
        /// <code>Offset: 0x0055A8A0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::UseObject(APIManager::IAsheronsCallImpl*,const unsigned int)</code>
        /// </summary>
        /// <param name="objectID">Identifier of the object to use.</param>
        /// <returns>HRESULT indicating success (zero) or failure.</returns>
        public static int UseObject(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055A8A0)(this_, objectID);

        /// <summary>Attempts to use the object identified by <paramref name="useThisID"/> on the target identified by <paramref name="onThisID"/>, delegating to ItemHolder::UseObject.
        /// <code>Offset: 0x0055A8C0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::UseObjectOn(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)</code>
        /// </summary>
        /// <param name="useThisID">Identifier of the object to be used.</param>
        /// <param name="onThisID">Identifier of the target object on which the use action is performed.</param>
        /// <returns>Zero (S_OK) indicating success.</returns>
        public static int UseObjectOn(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint useThisID, uint onThisID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055A8C0)(this_, useThisID, onThisID);

        /// <summary>Uses an equipped item identified by useThisID on the target entity specified by onThisID, handling reference counting and interface queries internally.
        /// <code>Offset: 0x0055A910
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::UseEquippedItem(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)</code>
        /// </summary>
        /// <param name="useThisID">Identifier of the equipped item to use.</param>
        /// <param name="onThisID">Identifier of the target entity for the item usage.</param>
        /// <returns>HRESULT indicating success; currently always returns S_OK (0).</returns>
        public static int UseEquippedItem(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint useThisID, uint onThisID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055A910)(this_, useThisID, onThisID);

        /// <summary>Switches the player's combat mode when a valid mode is supplied and the UI system is ready.
        /// <code>Offset: 0x0055A960
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::ChangeCombatMode(APIManager::IAsheronsCallImpl*,const eCombatMode)</code>
        /// </summary>
        /// <param name="newCombatMode">Desired combat mode, must be one of NonCombat, Melee, Missile or Magic.</param>
        /// <returns>Zero on success; an HRESULT error code if the mode is invalid or the UI system is not available.</returns>
        public static int ChangeCombatMode(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, ACBindings.Internal.eCombatMode newCombatMode) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, ACBindings.Internal.eCombatMode, int>)0x0055A960)(this_, newCombatMode);

        /// <summary>Checks whether the client UI system has been initialized.
        /// <code>Offset: 0x0055A9B0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetVendorID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        /// <param name="id">Ignored; not used by this implementation.</param>
        /// <returns>S_OK (0) if the UI system is ready; otherwise E_FAIL (-2147467259).</returns>
        public static int GetVendorID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055A9B0)(this_, id);

        /// <summary>Moves an item identified by <paramref name="objectID"/> into the target location specified by <paramref name="draggedOnID"/>, optionally dropping it when placement fails.
        /// <code>Offset: 0x0055A9E0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::MoveItemExternal(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int,const int)</code>
        /// </summary>
        /// <param name="this">Instance of <c>IAsheronsCallImpl</c>.</param>
        /// <param name="objectID">Identifier of the item to be moved.</param>
        /// <param name="draggedOnID">Identifier of the target container or slot for the item.</param>
        /// <param name="dropIfGiveFails"><c>0</c> indicates no drop action on failure; non‑zero triggers a drop when placement cannot succeed.</param>
        /// <returns>True if the move succeeded (AttemptPlaceIn3D returned 0); otherwise, false.</returns>
        public static int MoveItemExternal(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID, uint draggedOnID, int dropIfGiveFails) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int, int>)0x0055A9E0)(this_, objectID, draggedOnID, dropIfGiveFails);

        /// <summary>Attempts to place an item identified by objectID into the container identified by containerID at the specified position, optionally attempting automatic merge.
        /// <code>Offset: 0x0055AA00
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::MoveItemInternal(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int,const int,const int)</code>
        /// </summary>
        /// <param name="objectID">Identifier of the item to be moved.</param>
        /// <param name="containerID">Target container identifier.</param>
        /// <param name="place">Desired slot within the container where the item should be placed.</param>
        /// <param name="attemptAutoMerge">Flag indicating whether an automatic merge with an existing stack should be attempted (non‑zero for true).</param>
        /// <returns>1 if the item was successfully placed; 0 otherwise. Note that this function does not use standard COM success codes.</returns>
        public static int MoveItemInternal(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint objectID, uint containerID, int place, int attemptAutoMerge) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int, int, int>)0x0055AA00)(this_, objectID, containerID, place, attemptAutoMerge);

        /// <summary>Casts a spell identified by <paramref name="spellID"/> onto the target specified by <paramref name="targetID"/> after verifying that the user interface is ready.
        /// <code>Offset: 0x0055AA30
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::CastSpell(APIManager::IAsheronsCallImpl*,const unsigned int,const unsigned int)</code>
        /// </summary>
        /// <param name="spellID">The unique identifier of the spell to be cast.</param>
        /// <param name="targetID">The unique identifier of the entity on which to cast the spell.</param>
        /// <returns>HRESULT value: zero on success; otherwise a negative error code if the UI system is not ready or required interface queries fail.</returns>
        public static int CastSpell(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint spellID, uint targetID) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, uint, int>)0x0055AA30)(this_, spellID, targetID);

        /// <summary>Attempts to set the selected stack count but is unsupported; always returns a failure HRESULT.
        /// <code>Offset: 0x0055AAB0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetSelectedStackCount(APIManager::IAsheronsCallImpl*,int*)</code>
        /// </summary>
        /// <param name="isOpen">Pointer to an integer that would specify the desired stack count or state (unused by this implementation).</param>
        /// <returns>A constant HRESULT value indicating operation failed (e.g., -2147467259); no internal state is modified.</returns>
        public static int SetSelectedStackCount(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int* isOpen) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int*, int>)0x0055AAB0)(this_, isOpen);

        /// <summary>Decrements the busy counter for an Asheron's Call instance and indicates completion status.
        /// <code>Offset: 0x0055AAC0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::DecrementBusyCount(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        /// <returns>An HRESULT describing whether the decrement succeeded (S_OK) or failed (E_FAIL).</returns>
        public static int DecrementBusyCount(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AAC0)(this_);

        /// <summary>Determines whether the associated entity in SmartBox is stationary and returns the result via an output parameter.
        /// <code>Offset: 0x0055AAD0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::IsStandingStill(APIManager::IAsheronsCallImpl*,int*)</code>
        /// </summary>
        /// <param name="isStandingStill">Receives a non‑zero value when the entity is standing still; zero otherwise.</param>
        /// <returns>S_OK if the status was retrieved successfully, or E_FAIL when SmartBox is unavailable.</returns>
        public static int IsStandingStill(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int* isStandingStill) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int*, int>)0x0055AAD0)(this_, isStandingStill);

        /// <summary>Terminates the current Asheron’s Call session if a valid smartbox and related call object exist, returning S_OK on success.
        /// <code>Offset: 0x0055AB00
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::StopCompletely(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        /// <returns>S_OK (0) if the session is stopped successfully; otherwise E_FAIL (-2147467259) when prerequisites are not met or stopping fails.</returns>
        public static int StopCompletely(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AB00)(this_);

        /// <summary>Sets the entity's facing direction to a heading specified in degrees within 0–360 and requires an active smartbox context.
        /// <code>Offset: 0x0055AB30
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::TurnToHeading(APIManager::IAsheronsCallImpl*,const float)</code>
        /// </summary>
        /// <param name="heading">Target orientation in degrees; must be greater than or equal to 0 and less than 360.</param>
        /// <returns>HRESULT: S_OK on success, otherwise an error code if the heading is out of range or required context is missing.</returns>
        public static int TurnToHeading(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, float heading) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, float, int>)0x0055AB30)(this_, heading);

        /// <summary>Enables or disables automatic execution for this Asheron's Call instance by communicating with the SmartBox manager; disabling triggers a release of the object's reference.
        /// <code>Offset: 0x0055ABA0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::SetAutoRun(APIManager::IAsheronsCallImpl*,const int)</code>
        /// </summary>
        /// <param name="val">Non‑zero to enable auto‑run, zero to disable it.</param>
        /// <returns>Zero on success; otherwise E_FAIL (0x80004005) if the global SmartBox or its manager is unavailable.</returns>
        public static int SetAutoRun(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int val) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int, int>)0x0055ABA0)(this_, val);

        /// <summary>Retrieves the current X and Y coordinates of the player when the user interface is available and a player system exists.
        /// <code>Offset: 0x0055ABF0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetCurCoords(APIManager::IAsheronsCallImpl*,long double*,long double*)</code>
        /// </summary>
        /// <param name="coordX">Pointer to receive the X coordinate.</param>
        /// <param name="coordY">Pointer to receive the Y coordinate.</param>
        /// <returns>S_OK (0) on success; S_FALSE (1) if the player system could not provide coordinates; 0x80004005 (-2147467259) when the UI is not ready or no player system is available.</returns>
        public static int GetCurCoords(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, double* coordX, double* coordY) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, double*, double*, int>)0x0055ABF0)(this_, coordX, coordY);

        /// <summary>Attempts to retrieve the current location but currently only checks UI readiness, calls the UI system, and unconditionally fails.
        /// <code>Offset: 0x0055AC40
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetCurLoc(APIManager::IAsheronsCallImpl*,unsigned int*,float*,float*,float*,float*)</code>
        /// </summary>
        /// <param name="this">Pointer to the IAsheronsCallImpl instance.</param>
        /// <param name="landblock">Output parameter intended for the landblock identifier of the current location.</param>
        /// <param name="x">Output parameter intended for the X coordinate of the current location.</param>
        /// <param name="y">Output parameter intended for the Y coordinate of the current location.</param>
        /// <param name="z">Output parameter intended for the Z coordinate of the current location.</param>
        /// <param name="heading">Output parameter intended for the heading (orientation) at the current location.</param>
        /// <returns>E_FAIL (-2147467259), indicating that the operation is not implemented or has failed.</returns>
        public static int GetCurLoc(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* landblock, float* x, float* y, float* z, float* heading) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, float*, float*, float*, float*, int>)0x0055AC40)(this_, landblock, x, y, z, heading);

        /// <summary>Retrieves the current player's identifier from the active SmartBox instance when the UI system is ready.
        /// <code>Offset: 0x0055AC70
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetPlayerID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        /// <param name="id">Receives the player ID; set to zero if no SmartBox data exists.</param>
        /// <returns>S_OK (0) on success, or E_FAIL (-2147467259) when the UI is not initialized or the UISystem is missing.</returns>
        public static int GetPlayerID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055AC70)(this_, id);

        /// <summary>Retrieves the identifier of the current ground container from the UI system and writes it to the supplied pointer.
        /// <code>Offset: 0x0055ACC0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetGroundContainerID(APIManager::IAsheronsCallImpl*,unsigned int*)</code>
        /// </summary>
        /// <param name="id">Pointer that receives the ground container ID on success.</param>
        /// <returns>S_OK if the UI system is ready; otherwise E_FAIL when the UI system is not available or UI is not initialized.</returns>
        public static int GetGroundContainerID(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint* id) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint*, int>)0x0055ACC0)(this_, id);

        /// <summary>Resets the trade window, clearing all pending trade data.
        /// <code>Offset: 0x0055AD00
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::TradeWindow_Clear(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        /// <returns>S_OK (0) on success.</returns>
        public static int TradeWindow_Clear(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AD00)(this_);

        /// <summary>Ends the current character session by logging off the player through the system interface, provided the UI is ready.
        /// <code>Offset: 0x0055AD10
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::EndCharacterSession(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        /// <returns>S_OK (0) if the character was logged off successfully; otherwise returns E_FAIL when the UI system is not initialized or unavailable.</returns>
        public static int EndCharacterSession(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int>)0x0055AD10)(this_);

        /// <summary>Starts a session for the specified character when the user interface is ready.
        /// <code>Offset: 0x0055AD50
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::BeginCharacterSession(APIManager::IAsheronsCallImpl*,unsigned int)</code>
        /// </summary>
        /// <param name="this">Pointer to the IAsheronsCallImpl instance.</param>
        /// <param name="iidCharacter">Identifier of the character to log on.</param>
        /// <returns>Zero (S_OK) if the character logs in successfully; otherwise a non‑zero HRESULT indicating failure, such as UI not ready or login error.</returns>
        public static int BeginCharacterSession(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint iidCharacter) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int>)0x0055AD50)(this_, iidCharacter);

        /// <summary>Obtains the current screen width and height from the render device and writes them to the supplied pointers.
        /// <code>Offset: 0x0055AD90
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetScreenDimensions(APIManager::IAsheronsCallImpl*,int*,int*)</code>
        /// </summary>
        /// <param name="area3DWidth">Pointer to receive the display width in pixels.</param>
        /// <param name="area3DHeight">Pointer to receive the display height in pixels.</param>
        /// <returns>HRESULT indicating success (S_OK).</returns>
        public static int GetScreenDimensions(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, int* area3DWidth, int* area3DHeight) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, int*, int*, int>)0x0055AD90)(this_, area3DWidth, area3DHeight);

        /// <summary>Verifies whether an item identified by its unique ID exists within the client object maintenance system and reports the result through a Boolean output parameter.
        /// <code>Offset: 0x0055ADC0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::ItemIsKnown(APIManager::IAsheronsCallImpl*,const unsigned int,int*)</code>
        /// </summary>
        /// <param name="itemID">Unique identifier of the item to check.</param>
        /// <param name="isKnown">Pointer to receive 1 if the item is known, otherwise 0.</param>
        /// <returns>HRESULT indicating operation success; always S_OK in current implementation.</returns>
        public static int ItemIsKnown(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint itemID, int* isKnown) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, int*, int>)0x0055ADC0)(this_, itemID, isKnown);

        /// <summary>Releases a reference to the call implementation, decrementing its internal reference counter and deleting the instance when the count reaches zero.
        /// <code>Offset: 0x0055AE10
        /// unsigned int __stdcall APIManager::IAsheronsCallImpl::Release(APIManager::IAsheronsCallImpl*)</code>
        /// </summary>
        /// <param name="this">Pointer to the current IAsheronsCallImpl instance.</param>
        /// <returns>The new reference count after release.</returns>
        public static uint Release(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint>)0x0055AE10)(this_);

        /// <summary>Retrieves the name of a game item given its unique identifier.
        /// <code>Offset: 0x0055AE40
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::GetItemName(APIManager::IAsheronsCallImpl*,const unsigned int,unsigned __int16**)</code>
        /// </summary>
        /// <param name="itemID">Unique identifier for the desired item.</param>
        /// <param name="itemName">Receives a pointer to a UTF‑16 string containing the item's name; caller responsible for freeing the allocated memory.</param>
        /// <returns>Zero on success, or an HRESULT error code indicating failure (e.g., UI not ready or item not found).</returns>
        public static int GetItemName(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, uint itemID, ushort** itemName) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, uint, ushort**, int>)0x0055AE40)(this_, itemID, itemName);

        /// <summary>Adds a UTF‑16 string to the client chat scroll area under the specified chat type.
        /// <code>Offset: 0x0055B0E0
        /// HRESULT __stdcall APIManager::IAsheronsCallImpl::WriteToChat(APIManager::IAsheronsCallImpl*,unsigned __int16*,const eChatTypes)</code>
        /// </summary>
        /// <param name="txt">Null-terminated wide-character message to display.</param>
        /// <param name="type">Chat category indicating where the text should appear.</param>
        /// <returns>HRESULT; S_OK if the message was queued, E_FAIL when the UI system is not ready or unavailable.</returns>
        public static int WriteToChat(ACBindings.Internal.APIManager.IAsheronsCallImpl* this_, ushort* txt, ACBindings.Internal.eChatTypes type) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.APIManager.IAsheronsCallImpl*, ushort*, ACBindings.Internal.eChatTypes, int>)0x0055B0E0)(this_, txt, type);
    }

    // Members
    public ACBindings.Internal.IACPlugin* m_pPlugin;
    public ACBindings.Internal.IAsheronsCall* m_pAsheronsCallImpl;

    // Methods

    /// <summary>Retrieves the AC plugin instance from the API manager.
    /// <code>Offset: 0x0055A740
    /// IACPlugin* __cdecl APIManager::GetACPlugin()</code>
    /// </summary>
    /// <returns>The IACPlugin interface instance, or null if not available.</returns>
    public static ACBindings.Internal.IACPlugin* GetACPlugin() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IACPlugin*>)0x0055A740)();

    /// <summary>Retrieves the Asheron's Call implementation instance, creating a new one when none exists.
    /// <code>Offset: 0x0055AED0
    /// IAsheronsCall* __thiscall APIManager::GetAsheronsCallImpl(APIManager*)</code>
    /// </summary>
    /// <returns>A pointer to the IAsheronsCall implementation or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.IAsheronsCall* GetAsheronsCallImpl() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.APIManager, ACBindings.Internal.IAsheronsCall*>)0x0055AED0)(ref this);

    /// <summary>
    /// Initializes the API manager by loading the ACPlugin DLL, retrieving the CreateACPlugin entry point, creating an AsheronsCall implementation, and storing it for global access.
    /// 
    /// <code>Offset: 0x0055AF00
    /// int __cdecl APIManager::Init()</code>
    /// </summary>
    /// <returns>
    /// Non-zero if initialization succeeded; zero otherwise.
    /// </returns>
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x0055AF00)();

    /// <summary>Sets the API manager’s UI readiness state and, when moving from ready to not ready while a client API exists with an active interface, retrieves the Asheron&#39;s Call implementation before updating the internal flag.
    /// <code>Offset: 0x0055B070
    /// void __cdecl APIManager::SetUIReady(int)</code>
    /// </summary>
    /// <param name="isReady">Non‑zero indicates the UI is ready; zero indicates it is not ready.</param>
    public static void SetUIReady(int isReady) => ((delegate* unmanaged[Cdecl]<int, void>)0x0055B070)(isReady);

    /// <summary>Determines whether the CLI API is available and initializes its implementation instance on first use.
    /// <code>Offset: 0x0055B0A0
    /// int __cdecl APIManager::APIIsReady()</code>
    /// </summary>
    /// <returns>Zero if the API pointer or its implementation is missing, non‑zero otherwise.</returns>
    public static int APIIsReady() => ((delegate* unmanaged[Cdecl]<int>)0x0055B0A0)();
}

