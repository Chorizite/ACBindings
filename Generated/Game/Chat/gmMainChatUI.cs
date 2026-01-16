namespace ACBindings.Internal;


/// <summary>
/// Central chat UI component that extends base chat functionality, managing talk‑focus menu selections, squelch toggling, and window state (maximize/restore) handling while coordinating with the communication system.
/// </summary>
public unsafe struct gmMainChatUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ChatInterface BaseClass_ChatInterface; // ACBindings.Internal.ChatInterface

    // Child Types
    public unsafe struct gmMainChatUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmMainChatUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_pSquelchToggleButton;
    public ACBindings.Internal.SmartArray___UIElement_Text_ptr m_aTalkFocusButtons;
    public ACBindings.Internal.UIElement_Text* m_pChatTargetButtonText;
    public byte m_Maximized;
    public int m_OldY;
    public int m_OldHeight;

    // Generated Constructor
    public gmMainChatUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Moves the chat UI to a new screen position and updates internal offset attributes to preserve relative layout.
    /// <code>Offset: 0x004CD930
    /// void __thiscall gmMainChatUI::MoveTo(gmMainChatUI*,const int,const int)</code>
    /// </summary>
    /// <param name="x">Target X coordinate in screen space.</param>
    /// <param name="y">Target Y coordinate in screen space.</param>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, int, int, void>)0x004CD930)(ref this, x, y);

    /// <summary>Shows or hides a chat UI panel identified by its ID.
    /// <code>Offset: 0x004CD9F0
    /// void __thiscall gmMainChatUI::RecvNotice_SetPanelVisibility(gmMainChatUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_ePanelID">The identifier of the panel whose visibility is being set.</param>
    /// <param name="i_bVisible">True to make the panel visible; false to hide it.</param>
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, byte, void>)0x004CD9F0)(ref this, i_ePanelID, i_bVisible);

    /// <summary>Handles a click on a text tag that matches ID 268435457, initiating a private message if the chat input is not focused.
    /// <code>Offset: 0x004CDA80
    /// void __thiscall gmMainChatUI::RecvNotice_TextTag_IIDStringClick(UIElement_Text**,int,int,_DWORD*)</code>
    /// </summary>
    /// <param name="this">The gmMainChatUI instance handling the event.</param>
    /// <param name="a2">Identifier of the clicked text tag.</param>
    /// <param name="a3">Additional event data (unused).</param>
    /// <param name="a4">Pointer to data specifying the private message target, passed to StartTell.</param>
    public void RecvNotice_TextTag_IIDStringClick(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, int, int, int*, void>)0x004CDA80)(ref this, a2, a3, a4);

    /// <summary>Toggles the chat window between a maximized and a normal state, recalculating and applying new height, width, and position values while preserving the previous size for later restoration.
    /// <code>Offset: 0x004CDAC0
    /// void __thiscall gmMainChatUI::HandleMaximizeButton(gmMainChatUI*)</code>
    /// </summary>
    public void HandleMaximizeButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CDAC0)(ref this);

    /// <summary>Resizes the main chat user interface to the specified width and height, preserving the scroll position if it was already at the bottom.
    /// <code>Offset: 0x004CDD10
    /// void __thiscall gmMainChatUI::ResizeTo(gmMainChatUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_cWidth">Desired width of the chat UI in pixels.</param>
    /// <param name="i_cHeight">Desired height of the chat UI in pixels.</param>
    public void ResizeTo(int i_cWidth, int i_cHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, int, int, void>)0x004CDD10)(ref this, i_cWidth, i_cHeight);

    /// <summary>Initializes the main chat UI with the given layout and element description, establishing base chat functionality and default visual properties.
    /// <code>Offset: 0x004CDD60
    /// void __thiscall gmMainChatUI::gmMainChatUI(gmMainChatUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining dimensions and elements for the UI.</param>
    /// <param name="full_desc">Full element description containing state and child information.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CDD60)(ref this, layout, full_desc);

    /// <summary>Returns a UIElement pointer to the current object when the requested type matches specific identifiers; otherwise returns nullptr.
    /// <code>Offset: 0x004CDDD0
    /// UIElement* __thiscall gmMainChatUI::DynamicCast(gmMainChatUI*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The gmMainChatUI instance on which the cast is performed.</param>
    /// <param name="i_eType">Identifier of the target type for dynamic casting.</param>
    /// <returns>Pointer to this object as a UIElement if the requested type matches; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, ACBindings.Internal.UIElement*>)0x004CDDD0)(ref this, i_eType);

    /// <summary>Returns the unique identifier for the main chat UI element type.
    /// <code>Offset: 0x004CDE00
    /// unsigned int __thiscall gmMainChatUI::GetUIElementType(gmMainChatUI*)</code>
    /// </summary>
    /// <returns>A constant unsigned integer (268435521) that represents this UI component within the system.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint>)0x004CDE00)(ref this);

    /// <summary>Destroys a gmMainChatUI instance, unregistering it from global events, freeing the squelch toggle button if allocated, and invoking base class destructors.
    /// <code>Offset: 0x004CDE10
    /// void __thiscall gmMainChatUI::~gmMainChatUI(gmMainChatUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CDE10)(ref this);

    /// <summary>Toggles the squelch status for the currently selected speakable target, updating the UI button state and notifying the communication system of the change.
    /// <code>Offset: 0x004CDEA0
    /// void __thiscall gmMainChatUI::ToggleSquelchOnCurrentSpeakableTarget(gmMainChatUI*)</code>
    /// </summary>
    public void ToggleSquelchOnCurrentSpeakableTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CDEA0)(ref this);

    /// <summary>Registers the main chat UI element class with the UI system.
    /// <code>Offset: 0x004CDFC0
    /// void __cdecl gmMainChatUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CDFC0)();

    /// <summary>Retrieves the talk‑focus menu item corresponding to a given focus identifier by scanning the chat UI's list of talk‑focus buttons.
    /// <code>Offset: 0x004CDFE0
    /// UIElement_Text* __thiscall gmMainChatUI::GetTalkFocusMenuItem(gmMainChatUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eFocus">The focus identifier used to locate the matching button.</param>
    /// <returns>The UIElement_Text representing the matched talk‑focus menu item, or null if no match is found.</returns>
    public ACBindings.Internal.UIElement_Text* GetTalkFocusMenuItem(uint i_eFocus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, ACBindings.Internal.UIElement_Text*>)0x004CDFE0)(ref this, i_eFocus);

    /// <summary>Resets all talk‑focus menu buttons to match the current communication system state and then selects the most recent speakable target.
    /// <code>Offset: 0x004CE110
    /// void __thiscall gmMainChatUI::ResetAllTalkFocusMenuButtons(gmMainChatUI*)</code>
    /// </summary>
    public void ResetAllTalkFocusMenuButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CE110)(ref this);

    /// <summary>Handles a user’s selection from the talk focus menu in the chat UI.
    /// <code>Offset: 0x004CE1B0
    /// void __thiscall gmMainChatUI::HandleSelection(gmMainChatUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eFocus">Identifier of the selected talk focus option (typically 0‑13).</param>
    public void HandleSelection(uint i_eFocus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, void>)0x004CE1B0)(ref this, i_eFocus);

    /// <summary>Selects a chat target by its object ID, updating UI elements such as the squelch toggle button and tell‑to text. Enables or disables talk focus based on whether the target can be spoken to, and records the last speakable target.
    /// <code>Offset: 0x004CE3A0
    /// void __thiscall gmMainChatUI::SetSelected(gmMainChatUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidTarget">Identifier of the object to set as the current chat target.</param>
    public void SetSelected(uint i_iidTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, void>)0x004CE3A0)(ref this, i_iidTarget);

    /// <summary>Handles incoming UI element messages for the main chat interface, routing actions such as maximize button presses, menu selections, and toggling squelch on the current target before delegating to the base ChatInterface logic.
    /// <code>Offset: 0x004CE6F0
    /// UIElementMessageListenResult __thiscall gmMainChatUI::ListenToElementMessage(gmMainChatUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the message received from a UI element, including identifiers, message type, parameters, and coordinates.</param>
    /// <returns>UIElementMessageListenResult indicating whether the message was processed or forwarded.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CE6F0)(ref this, i_rMsg);

    /// <summary>Checks whether the chat target should be updated based on talk focus settings and proximity, selecting an appropriate object or clearing the selection as needed. Runs approximately every second.
    /// <code>Offset: 0x004CE790
    /// void __thiscall gmMainChatUI::UseTime(gmMainChatUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CE790)(ref this);

    /// <summary>Initializes the talk‑focus menu by locating the chat UI's menu element, clearing any existing buttons, adding a set of predefined target options (e.g., Tell to Monarch, All, Vassals, etc.), assigning each an attribute code, and storing references to those buttons for later use.
    /// <code>Offset: 0x004CE8C0
    /// void __thiscall gmMainChatUI::InitTalkFocusMenu(gmMainChatUI*)</code>
    /// </summary>
    public void InitTalkFocusMenu() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CE8C0)(ref this);

    /// <summary>Responds to a change in the selected object by updating the chat interface when a new talkable entity is chosen.
    /// <code>Offset: 0x004CECC0
    /// void __thiscall gmMainChatUI::RecvNotice_SelectionChanged(gmMainChatUI*)</code>
    /// </summary>
    /// <param name="this">The chat UI instance whose selection state may be updated.</param>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CECC0)(ref this);

    /// <summary>Enables or disables a chat talk‑focus menu item, updating its state and handling special cases such as Olthoi mode or the currently selected focus.
    /// <code>Offset: 0x004CED10
    /// void __thiscall gmMainChatUI::EnableSelection(gmMainChatUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_eFocus">Identifier of the talk focus to modify.</param>
    /// <param name="i_bEnabled">True to enable selection; false to disable it.</param>
    public void EnableSelection(uint i_eFocus, byte i_bEnabled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, byte, void>)0x004CED10)(ref this, i_eFocus, i_bEnabled);

    /// <summary>Initializes the main chat UI after construction. Sets up talk‑focus button count, registers for global messages and notice handlers, prepares the talk focus menu, selects the default entry and triggers its handling.
    /// <code>Offset: 0x004CEDA0
    /// void __thiscall gmMainChatUI::PostInit(gmMainChatUI*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmMainChatUI instance being initialized.</param>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, void>)0x004CEDA0)(ref this);

    /// <summary>Handles global chat messages, performing special actions for message IDs 3 and 11 before delegating to the base interface.
    /// <code>Offset: 0x004CEE90
    /// void __thiscall gmMainChatUI::ListenToGlobalMessage(gmMainChatUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the received global message.</param>
    /// <param name="i_data_int">Auxiliary data associated with the message.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMainChatUI, uint, int, void>)0x004CEE90)(ref this, i_messageID, i_data_int);
}

