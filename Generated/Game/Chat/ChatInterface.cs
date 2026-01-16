namespace ACBindings.Internal;


/// <summary>Manages the chat UI, handling message input, history, and display updates while coordinating with the communication system and global events.</summary>
public unsafe struct ChatInterface : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field

    // Child Types
    public unsafe struct ChatInterface_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public uint m_eWindowID;
    public float m_fDefaultOpacity;
    public float m_fActiveOpacity;
    public float m_fCurrentOpacity;
    public ACBindings.Internal.UIElement_Text* m_chatEntry;
    public ACBindings.Internal.UIElement_Text* m_chatLog;
    public ACBindings.Internal.UIElement* m_chatNewNonVisibleTextIndicator;
    public ulong m_llTextTypeFilter;
    public ACBindings.Internal.UIElement_Text* m_pChatTargetButtonText;
    public ACBindings.Internal.PStringBaseArray__ushort m_InputHistory;
    public uint m_LastInputHistoryPos;
    public ACBindings.Internal.ClientCommunicationSystem* m_pCCS;

    // Generated Constructor
    public ChatInterface(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether a specific chat text type is enabled in the current filter.
    /// <code>Offset: 0x004F3B70
    /// bool __thiscall ChatInterface::TypeIsActive(ChatInterface*,unsigned int)</code>
    /// </summary>
    /// <param name="i_ltt">Index of the text type to check.</param>
    /// <returns>True if the bit for that text type is set; otherwise, false.</returns>
    public byte TypeIsActive(uint i_ltt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, byte>)0x004F3B70)(ref this, i_ltt);

    /// <summary>Notifies the chat interface that a player's description has been received and triggers any associated updates.
    /// <code>Offset: 0x004F3BB0
    /// void __thiscall ChatInterface::RecvNotice_PlayerDescReceived(ChatInterface*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The qualities data describing the player.</param>
    /// <param name="i_playerModule">Additional module information for the player.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004F3BB0)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Clears the chat log text of the interface if the specified window ID matches the current window or no specific ID is provided.
    /// <code>Offset: 0x004F3BC0
    /// void __thiscall ChatInterface::RecvNotice_ClearChatBuffer(ChatInterface*,unsigned int)</code>
    /// </summary>
    /// <param name="i_idWindow">The target window identifier; pass 0 to clear all windows regardless of ID.</param>
    public void RecvNotice_ClearChatBuffer(uint i_idWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F3BC0)(ref this, i_idWindow);

    /// <summary>Prepares the chat entry for use by clearing its input action callback, handling loss of focus, and notifying the UI system to toggle the chat interface.
    /// <code>Offset: 0x004F3BF0
    /// void __thiscall ChatInterface::ActivateChatEntry(ChatInterface*)</code>
    /// </summary>
    public void ActivateChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F3BF0)(ref this);

    /// <summary>Destroys the current chat entry UI element, invokes its action handler, and signals the UI system to toggle the chat entry off.
    /// <code>Offset: 0x004F3C20
    /// void __thiscall ChatInterface::DeactivateChatEntry(ChatInterface*)</code>
    /// </summary>
    public void DeactivateChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F3C20)(ref this);

    /// <summary>Handles a command or alias input by inserting the corresponding prefix into the chat entry field and preparing the UI for text entry.
    /// <code>Offset: 0x004F3C50
    /// void __thiscall ChatInterface::HandleCommandOrAliasKey(ChatInterface*,unsigned int)</code>
    /// </summary>
    /// <param name="i_inputAction">Identifier of the input action that triggered the command or alias prefix handling.</param>
    public void HandleCommandOrAliasKey(uint i_inputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F3C50)(ref this, i_inputAction);

    /// <summary>Determines whether the chat input field currently has keyboard focus within the chat interface.
    /// <code>Offset: 0x004F3D00
    /// bool __thiscall ChatInterface::IsTextEntryFocused(ChatInterface*)</code>
    /// </summary>
    /// <returns>True if the chat entry element is the active focus descendant; otherwise, false.</returns>
    public byte IsTextEntryFocused() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F3D00)(ref this);

    /// <summary>Updates the chat interface's text type filter when a gameplay option change notice with matching property name and window ID is received.
    /// <code>Offset: 0x004F3D40
    /// void __thiscall ChatInterface::RecvNotice_GameplayOptionChanged(ChatInterface*,const BaseProperty*,unsigned int)</code>
    /// </summary>
    /// <param name="i_prop">The property describing the changed gameplay option.</param>
    /// <param name="i_dwUserData">Identifier used to verify that the notice belongs to this chat window instance.</param>
    public void RecvNotice_GameplayOptionChanged(ACBindings.Internal.BaseProperty* i_prop, uint i_dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.BaseProperty*, uint, void>)0x004F3D40)(ref this, i_prop, i_dwUserData);

    /// <summary>Sets the current opacity of the chat interface and forwards the value to its UI component when available.
    /// <code>Offset: 0x004F3D80
    /// void __thiscall ChatInterface::SetOpacity(ChatInterface*,float)</code>
    /// </summary>
    /// <param name="i_fOpacity">The target opacity level to apply.</param>
    public void SetOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, float, void>)0x004F3D80)(ref this, i_fOpacity);

    /// <summary>Assigns a UI object to the chat interface and propagates its active opacity to any owning region that supports it.
    /// <code>Offset: 0x004F3DC0
    /// bool __thiscall ChatInterface::SetUIObject(ChatInterface*,UIObject*)</code>
    /// </summary>
    /// <param name="i_pcUIObject">The UI object to associate with this chat interface.</param>
    /// <returns>True if the base class successfully set the UI object; otherwise false.</returns>
    public byte SetUIObject(ACBindings.Internal.UIObject* i_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.UIObject*, byte>)0x004F3DC0)(ref this, i_pcUIObject);

    /// <summary>Builds a color lookup table for the chat log by configuring a BaseProperty with multiple color mappings and applying it to the UI element.
    /// <code>Offset: 0x004F3E20
    /// void __thiscall ChatInterface::BuildChatColorLookupTable(ChatInterface*)</code>
    /// </summary>
    public void BuildChatColorLookupTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F3E20)(ref this);

    /// <summary>Adjusts the chat interface's active opacity in response to a global fade message, gradually fading it in when text entry is focused or out otherwise, and unregistering from further messages once fully faded.
    /// <code>Offset: 0x004F44A0
    /// void __thiscall ChatInterface::ListenToGlobalMessage(ChatInterface*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">The identifier of the global message; only ID 3 triggers the opacity adjustment logic.</param>
    /// <param name="i_data_int">Additional data supplied with the message (currently unused by this handler).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, int, void>)0x004F44A0)(ref this, i_messageID, i_data_int);

    /// <summary>Updates the chat interface’s text type filter by querying player module options for its window ID.
    /// <code>Offset: 0x004F4580
    /// void __thiscall ChatInterface::UpdateFromPlayerModule(ChatInterface*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F4580)(ref this);

    /// <summary>Resizes the chat interface to the specified dimensions, preserving the scroll position if it was at the bottom before resizing.
    /// <code>Offset: 0x004F4640
    /// void __thiscall ChatInterface::ResizeTo(ChatInterface*,const int,const int)</code>
    /// </summary>
    /// <param name="i_cWidth">The desired width of the chat window in pixels.</param>
    /// <param name="i_cHeight">The desired height of the chat window in pixels.</param>
    public void ResizeTo(int i_cWidth, int i_cHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, int, int, void>)0x004F4640)(ref this, i_cWidth, i_cHeight);

    /// <summary>Selects a command from the chat history based on the specified navigation direction, updating the input field to display that entry or clearing it when moving beyond available entries.
    /// <code>Offset: 0x004F4690
    /// void __thiscall ChatInterface::SelectCommandFromHistory(ChatInterface*,bool)</code>
    /// </summary>
    /// <param name="i_fPrevious">If true, selects the previous command; if false, moves forward through the history (or clears the entry when no more commands remain).</param>
    public void SelectCommandFromHistory(byte i_fPrevious) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte, void>)0x004F4690)(ref this, i_fPrevious);

    /// <summary>Toggles the chat input field between active and inactive states, updating focus and emitting a toggle notice.
    /// <code>Offset: 0x004F4790
    /// bool __thiscall ChatInterface::OnToggleChatEntry(ChatInterface*)</code>
    /// </summary>
    /// <returns>True when the operation completes successfully.</returns>
    public byte OnToggleChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F4790)(ref this);

    /// <summary>Sets the default opacity for the chat interface and updates the current opacity when needed.
    /// <code>Offset: 0x004F4820
    /// void __thiscall ChatInterface::SetDefaultOpacity(ChatInterface*,float)</code>
    /// </summary>
    /// <param name="i_fOpacity">The opacity value to establish as the new default for the chat interface.</param>
    public void SetDefaultOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, float, void>)0x004F4820)(ref this, i_fOpacity);

    /// <summary>Sets the active opacity of the chat interface and updates its appearance when the chat entry has focus.
    /// <code>Offset: 0x004F48A0
    /// void __thiscall ChatInterface::SetActiveOpacity(ChatInterface*,float)</code>
    /// </summary>
    /// <param name="i_fOpacity">The new opacity value for the active state, ranging from 0 to 1.</param>
    public void SetActiveOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, float, void>)0x004F48A0)(ref this, i_fOpacity);

    /// <summary>Initializes the chat interface after construction by locating child UI elements, setting initial opacity and text type filter, registering event listeners and global message handlers, and preparing communication system references.
    /// <code>Offset: 0x004F4A30
    /// void __thiscall ChatInterface::PostInit(ChatInterface*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F4A30)(ref this);

    /// <summary>Handles a property change on the chat interface by delegating the attribute to UIElement::OnSetAttribute and updating the default or active opacity when those specific properties are set.
    /// <code>Offset: 0x004F4BC0
    /// void __thiscall ChatInterface::OnSetAttribute(ChatInterface*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The BaseProperty whose name and value should be applied to this chat interface.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.BaseProperty*, void>)0x004F4BC0)(ref this, attribute);

    /// <summary>Destroys the chat interface by unregistering event listeners, freeing input history, deleting any pending target button text, and invoking base class destructors to clean up resources.
    /// <code>Offset: 0x004F4DC0
    /// void __thiscall ChatInterface::~ChatInterface(ChatInterface*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F4DC0)(ref this);

    /// <summary>Prepares the chat interface for a private message by inserting an "@tell" prefix into the input buffer, setting focus to the chat entry field, moving the cursor to the end of the pre‑filled text, and clearing any selection.
    /// <code>Offset: 0x004F4E50
    /// LONG __thiscall ChatInterface::StartTell(UIElement_Text**,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wide-character string containing the target player’s name; the function prefixes this with "@tell " in the input buffer.</param>
    /// <returns>Returns a status code resulting from decrementing an internal reference counter. A value of zero indicates that cleanup callbacks were invoked; non‑zero values represent remaining references or error codes.</returns>
    public int StartTell(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, int*, int>)0x004F4E50)(ref this, a2);

    /// <summary>Truncates the chat log to a specified maximum length, removing entire lines if necessary so that no partial lines remain.
    /// <code>Offset: 0x004F4EF0
    /// void __thiscall ChatInterface::TruncateChatLog(ChatInterface*,unsigned int)</code>
    /// </summary>
    /// <param name="i_uiNewLength">Maximum number of characters allowed in the chat log after truncation.</param>
    public void TruncateChatLog(uint i_uiNewLength) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F4EF0)(ref this, i_uiNewLength);

    /// <summary>Updates the chat log's font face and size in response to a font settings change notice, applying only when both indices are valid.
    /// <code>Offset: 0x004F50C0
    /// void __thiscall ChatInterface::RecvNotice_FontSettingsChanged(ChatInterface*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_nFontFace">Index of the chosen font face (valid values 0–5).</param>
    /// <param name="i_nFontSize">Index of the chosen font size (valid values 0–5).</param>
    public void RecvNotice_FontSettingsChanged(uint i_nFontFace, uint i_nFontSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, uint, void>)0x004F50C0)(ref this, i_nFontFace, i_nFontSize);

    /// <summary>Initializes a chat interface UI element using the provided layout descriptor and element description.
    /// <code>Offset: 0x004F51B0
    /// void __thiscall ChatInterface::ChatInterface(ChatInterface*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining dimensions, elements, and state information for the UI.</param>
    /// <param name="full_desc">Element description containing properties, child elements, and rendering details specific to the chat interface.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004F51B0)(ref this, layout, full_desc);

    /// <summary>Displays a formatted chat notice in the interface, appending an optional prefix and scrolling as needed. The message appears only when directed to this window or when no destination override is supplied and the type is active.
    /// <code>Offset: 0x004F52A0
    /// void __thiscall ChatInterface::RecvNotice_DisplayFinalStringInfo(ChatInterface*,unsigned int,const StringInfo*,const StringInfo*,unsigned int)</code>
    /// </summary>
    /// <param name="i_type">Identifier for the notice style or channel.</param>
    /// <param name="i_siMsg">StringInfo containing the main chat text to display.</param>
    /// <param name="i_siPrefix">Optional StringInfo prefix shown before the message when valid.</param>
    /// <param name="i_idDestinationOverride">Window identifier override; if non‑zero, limits output to that window only. Zero means broadcast to active windows.</param>
    public void RecvNotice_DisplayFinalStringInfo(uint i_type, ACBindings.Internal.StringInfo* i_siMsg, ACBindings.Internal.StringInfo* i_siPrefix, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void>)0x004F52A0)(ref this, i_type, i_siMsg, i_siPrefix, i_idDestinationOverride);

    /// <summary>Transforms a reply command entered in the chat box into an @tell command targeting the last teller, updating the entry text and cursor position.
    /// <code>Offset: 0x004F53C0
    /// bool __thiscall ChatInterface::SetReplyTextInChatBox(ChatInterface*)</code>
    /// </summary>
    /// <returns>Always false; the return value is not used to indicate success or failure.</returns>
    public byte SetReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F53C0)(ref this);

    /// <summary>Prepares a monarch reply by replacing the current chat entry text with an '@tell' command addressed to the last monarch user.
    /// <code>Offset: 0x004F57D0
    /// bool __thiscall ChatInterface::SetMonarchReplyTextInChatBox(ChatInterface*)</code>
    /// </summary>
    /// <returns>False; the function performs its action via side effects only and always returns false.</returns>
    public byte SetMonarchReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F57D0)(ref this);

    /// <summary>Attempts to insert a formatted patron reply into the chat input field using the last known patron username and current chat entry content; currently always returns false.
    /// <code>Offset: 0x004F5A80
    /// bool __thiscall ChatInterface::SetPatronReplyTextInChatBox(ChatInterface*)</code>
    /// </summary>
    /// <returns>False (the function does not indicate success).</returns>
    public byte SetPatronReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F5A80)(ref this);

    /// <summary>Handles text replacements within the chat interface by attempting to set reply text in the chat box; if that fails, tries a monarch reply, and finally falls back to a patron reply.
    /// <code>Offset: 0x004F5D30
    /// void __thiscall ChatInterface::HandleTextReplacements(ChatInterface*)</code>
    /// </summary>
    public void HandleTextReplacements() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F5D30)(ref this);

    /// <summary>Processes the current chat entry: retrieves the entered text, sends it as a command to the client communication system if connected, updates input history, clears the chat field, and releases any temporary resources.
    /// <code>Offset: 0x004F5D60
    /// void __thiscall ChatInterface::ProcessCommand(ChatInterface*)</code>
    /// </summary>
    public void ProcessCommand() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F5D60)(ref this);

    /// <summary>Intercepts and processes chat‑related UI messages, executing commands when the input field is submitted, scrolling the log on specific triggers, applying text replacements, and registering for global messages for particular event IDs.
    /// <code>Offset: 0x004F5E20
    /// UIElementMessageListenResult __thiscall ChatInterface::ListenToElementMessage(ChatInterface*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being dispatched.</param>
    /// <returns>Result indicating whether the message was handled by this listener or forwarded to the base UIElement implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004F5E20)(ref this, i_rMsg);

    /// <summary>Handles the Enter key press in the chat interface by submitting the current chat entry, toggling chat mode when appropriate, and processing the entered command.
    /// <code>Offset: 0x004F5F30
    /// void __thiscall ChatInterface::HandleEnterKey(ChatInterface*)</code>
    /// </summary>
    public void HandleEnterKey() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F5F30)(ref this);

    /// <summary>Populates the chat entry field with the name of the most recent target (monarch, patron, or teller) when a reply key shortcut is pressed.
    /// <code>Offset: 0x004F5FB0
    /// void __thiscall ChatInterface::HandleReplyKey(ChatInterface*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Reference to the ChatInterface instance.</param>
    /// <param name="i_inputAction">Identifier of the input action indicating which reply shortcut was triggered.</param>
    public void HandleReplyKey(uint i_inputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F5FB0)(ref this, i_inputAction);

    /// <summary>Processes input events targeted at the chat interface’s child elements, handling actions such as scrolling the chat entry, navigating command history, submitting or canceling a message, and paging through text.
    /// <code>Offset: 0x004F61F0
    /// bool __thiscall ChatInterface::OnChildAction(ChatInterface*,const UIElement*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_pChild">The child UI element that received the input event.</param>
    /// <param name="i_evt">Information about the input action to be processed.</param>
    /// <returns>True if the event was handled by this function; otherwise forwards it to the base implementation and returns its result.</returns>
    public byte OnChildAction(ACBindings.Internal.UIElement* i_pChild, ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte>)0x004F61F0)(ref this, i_pChild, i_evt);
}

