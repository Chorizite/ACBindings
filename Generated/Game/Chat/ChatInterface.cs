namespace ACBindings.Internal;

public unsafe struct ChatInterface : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field

    // Child Types
    public unsafe struct ChatInterface_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ChatInterface*, void> UpdateFromPlayerModule; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004F3B70
    /// bool __thiscall ChatInterface::TypeIsActive(ChatInterface*,unsigned int)</code>
    /// </summary>
    public byte TypeIsActive(uint i_ltt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, byte>)0x004F3B70)(ref this, i_ltt);

    /// <summary>
    /// <code>Offset: 0x004F3BB0
    /// void __thiscall ChatInterface::RecvNotice_PlayerDescReceived(ChatInterface*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004F3BB0)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004F3BC0
    /// void __thiscall ChatInterface::RecvNotice_ClearChatBuffer(ChatInterface*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ClearChatBuffer(uint i_idWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F3BC0)(ref this, i_idWindow);

    /// <summary>
    /// <code>Offset: 0x004F3BF0
    /// void __thiscall ChatInterface::ActivateChatEntry(ChatInterface*)</code>
    /// </summary>
    public void ActivateChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F3BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F3C20
    /// void __thiscall ChatInterface::DeactivateChatEntry(ChatInterface*)</code>
    /// </summary>
    public void DeactivateChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F3C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F3C50
    /// void __thiscall ChatInterface::HandleCommandOrAliasKey(ChatInterface*,unsigned int)</code>
    /// </summary>
    public void HandleCommandOrAliasKey(uint i_inputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F3C50)(ref this, i_inputAction);

    /// <summary>
    /// <code>Offset: 0x004F3D00
    /// bool __thiscall ChatInterface::IsTextEntryFocused(ChatInterface*)</code>
    /// </summary>
    public byte IsTextEntryFocused() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F3D00)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F3D40
    /// void __thiscall ChatInterface::RecvNotice_GameplayOptionChanged(ChatInterface*,const BaseProperty*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_GameplayOptionChanged(ACBindings.Internal.BaseProperty* i_prop, uint i_dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.BaseProperty*, uint, void>)0x004F3D40)(ref this, i_prop, i_dwUserData);

    /// <summary>
    /// <code>Offset: 0x004F3D80
    /// void __thiscall ChatInterface::SetOpacity(ChatInterface*,float)</code>
    /// </summary>
    public void SetOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, float, void>)0x004F3D80)(ref this, i_fOpacity);

    /// <summary>
    /// <code>Offset: 0x004F3DC0
    /// bool __thiscall ChatInterface::SetUIObject(ChatInterface*,UIObject*)</code>
    /// </summary>
    public byte SetUIObject(ACBindings.Internal.UIObject* i_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.UIObject*, byte>)0x004F3DC0)(ref this, i_pcUIObject);

    /// <summary>
    /// <code>Offset: 0x004F3E20
    /// void __thiscall ChatInterface::BuildChatColorLookupTable(ChatInterface*)</code>
    /// </summary>
    public void BuildChatColorLookupTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F3E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F44A0
    /// void __thiscall ChatInterface::ListenToGlobalMessage(ChatInterface*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, int, void>)0x004F44A0)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004F4580
    /// void __thiscall ChatInterface::UpdateFromPlayerModule(ChatInterface*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F4580)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F4640
    /// void __thiscall ChatInterface::ResizeTo(ChatInterface*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int i_cWidth, int i_cHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, int, int, void>)0x004F4640)(ref this, i_cWidth, i_cHeight);

    /// <summary>
    /// <code>Offset: 0x004F4690
    /// void __thiscall ChatInterface::SelectCommandFromHistory(ChatInterface*,bool)</code>
    /// </summary>
    public void SelectCommandFromHistory(byte i_fPrevious) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte, void>)0x004F4690)(ref this, i_fPrevious);

    /// <summary>
    /// <code>Offset: 0x004F4790
    /// bool __thiscall ChatInterface::OnToggleChatEntry(ChatInterface*)</code>
    /// </summary>
    public byte OnToggleChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F4790)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F4820
    /// void __thiscall ChatInterface::SetDefaultOpacity(ChatInterface*,float)</code>
    /// </summary>
    public void SetDefaultOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, float, void>)0x004F4820)(ref this, i_fOpacity);

    /// <summary>
    /// <code>Offset: 0x004F48A0
    /// void __thiscall ChatInterface::SetActiveOpacity(ChatInterface*,float)</code>
    /// </summary>
    public void SetActiveOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, float, void>)0x004F48A0)(ref this, i_fOpacity);

    /// <summary>
    /// <code>Offset: 0x004F4A30
    /// void __thiscall ChatInterface::PostInit(ChatInterface*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F4A30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F4BC0
    /// void __thiscall ChatInterface::OnSetAttribute(ChatInterface*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.BaseProperty*, void>)0x004F4BC0)(ref this, attribute);

    /// <summary>
    /// <code>Offset: 0x004F4DC0
    /// void __thiscall ChatInterface::~ChatInterface(ChatInterface*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F4DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F4E50
    /// LONG __thiscall ChatInterface::StartTell(UIElement_Text**,_DWORD*)</code>
    /// </summary>
    public int StartTell(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, int*, int>)0x004F4E50)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F4EF0
    /// void __thiscall ChatInterface::TruncateChatLog(ChatInterface*,unsigned int)</code>
    /// </summary>
    public void TruncateChatLog(uint i_uiNewLength) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F4EF0)(ref this, i_uiNewLength);

    /// <summary>
    /// <code>Offset: 0x004F50C0
    /// void __thiscall ChatInterface::RecvNotice_FontSettingsChanged(ChatInterface*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FontSettingsChanged(uint i_nFontFace, uint i_nFontSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, uint, void>)0x004F50C0)(ref this, i_nFontFace, i_nFontSize);

    /// <summary>
    /// <code>Offset: 0x004F51B0
    /// void __thiscall ChatInterface::ChatInterface(ChatInterface*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004F51B0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004F52A0
    /// void __thiscall ChatInterface::RecvNotice_DisplayFinalStringInfo(ChatInterface*,unsigned int,const StringInfo*,const StringInfo*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_DisplayFinalStringInfo(uint i_type, ACBindings.Internal.StringInfo* i_siMsg, ACBindings.Internal.StringInfo* i_siPrefix, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void>)0x004F52A0)(ref this, i_type, i_siMsg, i_siPrefix, i_idDestinationOverride);

    /// <summary>
    /// <code>Offset: 0x004F53C0
    /// bool __thiscall ChatInterface::SetReplyTextInChatBox(ChatInterface*)</code>
    /// </summary>
    public byte SetReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F53C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F57D0
    /// bool __thiscall ChatInterface::SetMonarchReplyTextInChatBox(ChatInterface*)</code>
    /// </summary>
    public byte SetMonarchReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F57D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F5A80
    /// bool __thiscall ChatInterface::SetPatronReplyTextInChatBox(ChatInterface*)</code>
    /// </summary>
    public byte SetPatronReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, byte>)0x004F5A80)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F5D30
    /// void __thiscall ChatInterface::HandleTextReplacements(ChatInterface*)</code>
    /// </summary>
    public void HandleTextReplacements() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F5D30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F5D60
    /// void __thiscall ChatInterface::ProcessCommand(ChatInterface*)</code>
    /// </summary>
    public void ProcessCommand() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F5D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F5E20
    /// UIElementMessageListenResult __thiscall ChatInterface::ListenToElementMessage(ChatInterface*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004F5E20)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004F5F30
    /// void __thiscall ChatInterface::HandleEnterKey(ChatInterface*)</code>
    /// </summary>
    public void HandleEnterKey() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, void>)0x004F5F30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F5FB0
    /// void __thiscall ChatInterface::HandleReplyKey(ChatInterface*,unsigned int)</code>
    /// </summary>
    public void HandleReplyKey(uint i_inputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, uint, void>)0x004F5FB0)(ref this, i_inputAction);

    /// <summary>
    /// <code>Offset: 0x004F61F0
    /// bool __thiscall ChatInterface::OnChildAction(ChatInterface*,const UIElement*,const InputEvent*)</code>
    /// </summary>
    public byte OnChildAction(ACBindings.Internal.UIElement* i_pChild, ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatInterface, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte>)0x004F61F0)(ref this, i_pChild, i_evt);
}

