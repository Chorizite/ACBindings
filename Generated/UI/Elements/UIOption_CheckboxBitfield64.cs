namespace ACBindings.Internal;

public unsafe struct UIOption_CheckboxBitfield64 : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement_ListBox BaseClass_UIElement_ListBox; // ACBindings.Internal.UIElement_ListBox

    // Child Types
    public unsafe struct UIOption_CheckboxBitfield64_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> UIOption_CheckboxBitfield64_dtor_2a8; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> Refresh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> Changed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> RestoreSavedValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> RestoreDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> SaveCurrentValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> HandleDialogAndNotices; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, byte> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ulong, void> SetDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ulong> GetValue; // function pointer

        // Methods
    }
    public unsafe struct ChildInfo
    {
        // Members
        public ulong llMask;
        public ACBindings.Internal.StringInfo siLabel;
        public ACBindings.Internal.StringInfo siTooltip;

        // Generated Constructor
        public ChildInfo() {
            _ConstructorInternal();
        }

        // Methods

        /// <summary>
        /// <code>Offset: 0x00485A20
        /// void __thiscall UIOption_CheckboxBitfield64::ChildInfo::ChildInfo(UIOption_CheckboxBitfield64::ChildInfo*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64.ChildInfo, void>)0x00485A20)(ref this);
    }
    // UIOption_CheckboxBitfield64::PropertyType
    public enum PropertyType : byte
    {
        Normal_PropType = 0x0,
        Chat_PropType = 0x1
    }

    // Members
    public ulong m_default;
    public ulong m_saved;
    public ulong m_current;
    public ACBindings.Internal.PStringBase__sbyte m_prefName;
    public uint m_propName;
    public ACBindings.Internal.UIOption_CheckboxBitfield64.PropertyType m_propType;
    public ACBindings.Internal.SmartArray___UIOption_CheckboxBitfield64_ChildInfo m_rgChildValues;

    // Generated Constructor
    public UIOption_CheckboxBitfield64(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00485A60
    /// bool __thiscall UIOption_CheckboxBitfield64::Changed(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485A60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00485A90
    /// bool __thiscall UIOption_CheckboxBitfield64::SaveCurrentValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485A90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00485AC0
    /// bool __thiscall UIOption_CheckboxBitfield64::RestoreSavedValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00485B00
    /// bool __thiscall UIOption_CheckboxBitfield64::RestoreDefaultValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485B00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00485B40
    /// void __thiscall UIOption_CheckboxBitfield64::SetDefaultValue(UIOption_CheckboxBitfield64*,unsigned __int64)</code>
    /// </summary>
    public void SetDefaultValue(ulong defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ulong, void>)0x00485B40)(ref this, defaulta);

    /// <summary>
    /// <code>Offset: 0x00485B60
    /// void __thiscall UIOption_CheckboxBitfield64::RecvNotice_ReloadOptions(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void RecvNotice_ReloadOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x00485B60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00485D80
    /// void __thiscall UIOption_CheckboxBitfield64::Refresh(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x00485D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00485EA0
    /// UIElementMessageListenResult __thiscall UIOption_CheckboxBitfield64::ListenToElementMessage(UIOption_CheckboxBitfield64*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00485EA0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00486010
    /// void __thiscall UIOption_CheckboxBitfield64::UIOption_CheckboxBitfield64(UIOption_CheckboxBitfield64*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00486010)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004860A0
    /// UIElement* __thiscall UIOption_CheckboxBitfield64::DynamicCast(UIOption_CheckboxBitfield64*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, uint, ACBindings.Internal.UIElement*>)0x004860A0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004860E0
    /// unsigned int __thiscall UIOption_CheckboxBitfield64::GetUIElementType(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, uint>)0x004860E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486100
    /// UIElement* __thiscall UIOption_CheckboxBitfield64::DynamicCast(unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ACBindings.Internal.UIElement*>)0x00486100)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486110
    /// void __thiscall UIOption_CheckboxBitfield64::~UIOption_CheckboxBitfield64(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x00486110)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486180
    /// UIElement* __cdecl UIOption_CheckboxBitfield64::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00486180)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004861B0
    /// void __thiscall UIOption_CheckboxBitfield64::CreateChildren(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void CreateChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x004861B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486290
    /// void __cdecl UIOption_CheckboxBitfield64::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00486290)();

    /// <summary>
    /// <code>Offset: 0x004862B0
    /// void __thiscall UIOption_CheckboxBitfield64::SetGameplayOptionProperty(UIOption_CheckboxBitfield64*,unsigned int,UIOption_CheckboxBitfield64::PropertyType)</code>
    /// </summary>
    public void SetGameplayOptionProperty(uint i_propName, ACBindings.Internal.UIOption_CheckboxBitfield64.PropertyType i_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, uint, ACBindings.Internal.UIOption_CheckboxBitfield64.PropertyType, void>)0x004862B0)(ref this, i_propName, i_type);

    /// <summary>
    /// <code>Offset: 0x004863B0
    /// bool __thiscall UIOption_CheckboxBitfield64::Apply(UIOption_CheckboxBitfield64*,bool)</code>
    /// </summary>
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte, byte>)0x004863B0)(ref this, userRequested);

    /// <summary>
    /// <code>Offset: 0x00486510
    /// unsigned __int64 __thiscall UIOption_CheckboxBitfield64::GetValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public ulong GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ulong>)0x00486510)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486660
    /// void __thiscall UIOption_CheckboxBitfield64::AddChild(UIOption_CheckboxBitfield64*,unsigned __int64,unsigned int,unsigned int)</code>
    /// </summary>
    public void AddChild(ulong i_llMask, uint i_stLabel, uint i_stTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ulong, uint, uint, void>)0x00486660)(ref this, i_llMask, i_stLabel, i_stTooltip);
}

