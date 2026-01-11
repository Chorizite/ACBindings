namespace ACBindings.Internal;

public unsafe struct gmFloatyMainChatUI
{
    // Base Classes
    public ACBindings.Internal.gmMainChatUI BaseClass_gmMainChatUI; // ACBindings.Internal.gmMainChatUI

    // Child Types
    public unsafe struct gmFloatyMainChatUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyMainChatUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_pTopBorder;
    public ACBindings.Internal.UIElement* m_pLeftBorder;
    public ACBindings.Internal.UIElement* m_pBottomBorder;
    public ACBindings.Internal.UIElement* m_pRightBorder;
    public ACBindings.Internal.UIElement* m_pTopLeftCorner;
    public ACBindings.Internal.UIElement* m_pTopRightCorner;
    public ACBindings.Internal.UIElement* m_pBottomLeftCorner;
    public ACBindings.Internal.UIElement* m_pBottomRightCorner;
    public ACBindings.Internal.UIElement* m_pTopBorder_Locked;
    public ACBindings.Internal.UIElement* m_pLeftBorder_Locked;
    public ACBindings.Internal.UIElement* m_pBottomBorder_Locked;
    public ACBindings.Internal.UIElement* m_pRightBorder_Locked;
    public ACBindings.Internal.UIElement* m_pTopLeftCorner_Locked;
    public ACBindings.Internal.UIElement* m_pTopRightCorner_Locked;
    public ACBindings.Internal.UIElement* m_pBottomLeftCorner_Locked;
    public ACBindings.Internal.UIElement* m_pBottomRightCorner_Locked;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004D2F70
    /// UIElement* __thiscall gmFloatyMainChatUI::DynamicCast(gmFloatyMainChatUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, uint, ACBindings.Internal.UIElement*>)0x004D2F70)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004D2FB0
    /// UIElement* __cdecl gmFloatyMainChatUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004D2FB0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004D3000
    /// void __thiscall gmFloatyMainChatUI::UpdateLockedStatus(gmFloatyMainChatUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, void>)0x004D3000)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D3280
    /// void __cdecl gmFloatyMainChatUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D3280)();

    /// <summary>
    /// <code>Offset: 0x004D32A0
    /// void __thiscall gmFloatyMainChatUI::PostInit(gmFloatyMainChatUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, void>)0x004D32A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D3570
    /// void __thiscall gmFloatyMainChatUI::ListenToGlobalMessage(gmFloatyMainChatUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, uint, int, void>)0x004D3570)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004D35A0
    /// void __thiscall gmFloatyMainChatUI::UpdateFromPlayerModule(gmFloatyMainChatUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, void>)0x004D35A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D3830
    /// void __thiscall gmFloatyMainChatUI::ResizeTo(gmFloatyMainChatUI*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, int, int, void>)0x004D3830)(ref this, i_width, i_height);

    /// <summary>
    /// <code>Offset: 0x004D3940
    /// void __thiscall gmFloatyMainChatUI::MoveTo(gmFloatyMainChatUI*,const int,const int)</code>
    /// </summary>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyMainChatUI, int, int, void>)0x004D3940)(ref this, i_x, i_y);
}

