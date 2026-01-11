namespace ACBindings.Internal;

public unsafe struct UIOption_CheckboxSlider
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement

    // Child Types
    public unsafe struct UIOption_CheckboxSlider_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> UIOption_CheckboxSlider_dtor_2a8; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, void> Refresh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte> Changed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte> RestoreSavedValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte> RestoreDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte> SaveCurrentValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, void> HandleDialogAndNotices; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, byte> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxSlider*, byte, float, void> SetDefaultValue; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIOption_Checkbox* m_pToggle;
    public ACBindings.Internal.UIOption_Slider* m_pSlider;
    public ACBindings.Internal.PStringBase__sbyte m_prefName;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004849D0
    /// void __thiscall UIOption_CheckboxSlider::Refresh(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, void>)0x004849D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484A00
    /// bool __thiscall UIOption_CheckboxSlider::Changed(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, byte>)0x00484A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484A40
    /// void __thiscall UIOption_CheckboxSlider::SetChangeNotification(UIOption_CheckboxSlider*,IOptionChangeHandler*)</code>
    /// </summary>
    public void SetChangeNotification(ACBindings.Internal.IOptionChangeHandler* i_pOCH) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, ACBindings.Internal.IOptionChangeHandler*, void>)0x00484A40)(ref this, i_pOCH);

    /// <summary>
    /// <code>Offset: 0x00484A80
    /// bool __thiscall UIOption_CheckboxSlider::Apply(UIOption_CheckboxSlider*,bool)</code>
    /// </summary>
    public byte Apply(byte i_userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, byte, byte>)0x00484A80)(ref this, i_userRequested);

    /// <summary>
    /// <code>Offset: 0x00484AC0
    /// bool __thiscall UIOption_CheckboxSlider::SaveCurrentValue(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, byte>)0x00484AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484AF0
    /// bool __thiscall UIOption_CheckboxSlider::RestoreSavedValue(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, byte>)0x00484AF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484B20
    /// bool __thiscall UIOption_CheckboxSlider::RestoreDefaultValue(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, byte>)0x00484B20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484B50
    /// void __thiscall UIOption_CheckboxSlider::SetDefaultValue(UIOption_CheckboxSlider*,bool,float)</code>
    /// </summary>
    public void SetDefaultValue(byte fToggleDefault, float rSliderDefault) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, byte, float, void>)0x00484B50)(ref this, fToggleDefault, rSliderDefault);

    /// <summary>
    /// <code>Offset: 0x00484B90
    /// void __thiscall UIOption_CheckboxSlider::SetUIPreference(_DWORD*,int*,char**)</code>
    /// </summary>
    public void SetUIPreference(int* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, int*, sbyte**, void>)0x00484B90)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00484BC0
    /// void __thiscall UIOption_CheckboxSlider::SetTooltip(UIOption_CheckboxSlider*,const StringInfo*)</code>
    /// </summary>
    public void SetTooltip(ACBindings.Internal.StringInfo* i_siTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, ACBindings.Internal.StringInfo*, void>)0x00484BC0)(ref this, i_siTooltip);

    /// <summary>
    /// <code>Offset: 0x00484BD0
    /// UIElementMessageListenResult __thiscall UIOption_CheckboxSlider::ListenToElementMessage(UIOption_CheckboxSlider*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00484BD0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00484CA0
    /// UIElement* __thiscall UIOption_CheckboxSlider::DynamicCast(UIOption_CheckboxSlider*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, uint, ACBindings.Internal.UIElement*>)0x00484CA0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00484CC0
    /// unsigned int __thiscall UIOption_CheckboxSlider::GetUIElementType(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, uint>)0x00484CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484CE0
    /// UIElement* __thiscall UIOption_CheckboxSlider::DynamicCast(unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, ACBindings.Internal.UIElement*>)0x00484CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484CF0
    /// UIElement* __cdecl UIOption_CheckboxSlider::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00484CF0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00484D20
    /// void __thiscall UIOption_CheckboxSlider::PostInit(UIOption_CheckboxSlider*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxSlider, void>)0x00484D20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00484DF0
    /// void __cdecl UIOption_CheckboxSlider::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00484DF0)();
}

