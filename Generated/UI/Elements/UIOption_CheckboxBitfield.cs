namespace ACBindings.Internal;

public unsafe struct UIOption_CheckboxBitfield
{
    // Base Classes
    public ACBindings.Internal.UIOption_Checkbox BaseClass_UIOption_Checkbox; // ACBindings.Internal.UIOption_Checkbox

    // Child Types
    public unsafe struct UIOption_CheckboxBitfield_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> UIOption_CheckboxBitfield_dtor_2a8; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> Refresh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> Changed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> RestoreSavedValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> RestoreDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> SaveCurrentValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> HandleDialogAndNotices; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, byte> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> SetDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> SetCurrentValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> GetValue; // function pointer

        // Methods
    }

    // Members
    public uint m_bitmask;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00486700
    /// UIElement* __thiscall UIOption_CheckboxBitfield::DynamicCast(UIOption_CheckboxBitfield*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, uint, ACBindings.Internal.UIElement*>)0x00486700)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00486770
    /// unsigned int __thiscall UIOption_CheckboxBitfield::GetUIElementType(UIOption_CheckboxBitfield*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, uint>)0x00486770)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486780
    /// UIElement* __cdecl UIOption_CheckboxBitfield::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00486780)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004867E0
    /// UIElement* __thiscall UIOption_CheckboxBitfield::DynamicCast(unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, ACBindings.Internal.UIElement*>)0x004867E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00486830
    /// void __cdecl UIOption_CheckboxBitfield::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00486830)();

    /// <summary>
    /// <code>Offset: 0x00486850
    /// bool __thiscall UIOption_CheckboxBitfield::Apply(UIOption_CheckboxBitfield*,bool)</code>
    /// </summary>
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, byte, byte>)0x00486850)(ref this, userRequested);

    /// <summary>
    /// <code>Offset: 0x00486AC0
    /// bool __thiscall UIOption_CheckboxBitfield::GetValue(UIOption_CheckboxBitfield*)</code>
    /// </summary>
    public byte GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, byte>)0x00486AC0)(ref this);
}

