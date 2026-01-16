namespace ACBindings.Internal;


/// <summary>
/// Represents a checkbox option whose state is encoded as bits within an unsigned integer mask.  
/// Extends the base checkbox logic by storing a bitmask that determines which individual options are considered set when evaluating or applying the setting. 
/// </summary>
public unsafe struct UIOption_CheckboxBitfield
{
    // Base Classes
    public ACBindings.Internal.UIOption_Checkbox BaseClass_UIOption_Checkbox; // ACBindings.Internal.UIOption_Checkbox

    // Child Types
    public unsafe struct UIOption_CheckboxBitfield_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> UIOption_CheckboxBitfield_dtor_2a8; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, void> Refresh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> Changed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> RestoreSavedValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> RestoreDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> SaveCurrentValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> HandleDialogAndNotices; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, byte> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> SetDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte, void> SetCurrentValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield*, byte> GetValue; // function pointer

        // Methods
    }

    // Members
    public uint m_bitmask;

    // Methods

    /// <summary>Performs a type-safe cast of the checkbox bitfield option to a UIElement, delegating to base class logic unless a specific type identifier is matched.
    /// <code>Offset: 0x00486700
    /// UIElement* __thiscall UIOption_CheckboxBitfield::DynamicCast(UIOption_CheckboxBitfield*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier representing the target UI element type for casting.</param>
    /// <returns>Pointer to the corresponding UIElement if the cast succeeds; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, uint, ACBindings.Internal.UIElement*>)0x00486700)(ref this, i_eType);

    /// <summary>Provides the unique identifier for a checkbox bitfield UI element.
    /// <code>Offset: 0x00486770
    /// unsigned int __thiscall UIOption_CheckboxBitfield::GetUIElementType(UIOption_CheckboxBitfield*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the UI element type (268435523).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, uint>)0x00486770)(ref this);

    /// <summary>Creates a checkbox bitfield UI element from the supplied layout and element descriptors.
    /// <code>Offset: 0x00486780
    /// UIElement* __cdecl UIOption_CheckboxBitfield::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing display dimensions and header strings for the option panel.</param>
    /// <param name="full_desc">Element descriptor defining visual style, state machine, and identifiers of the checkbox component.</param>
    /// <returns>Pointer to the constructed UIElement on success; null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00486780)(layout, full_desc);

    /// <summary>Attempts to retrieve a UIElement reference for the current checkbox bitfield instance, returning a valid pointer when the underlying object can be viewed as a UI element; otherwise returns nullptr.
    /// <code>Offset: 0x004867E0
    /// UIElement* __thiscall UIOption_CheckboxBitfield::DynamicCast(unsigned int)</code>
    /// </summary>
    /// <returns>A pointer to UIElement if available; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, ACBindings.Internal.UIElement*>)0x004867E0)(ref this);

    /// <summary>Registers the UIOption_CheckboxBitfield class for runtime creation by assigning a unique element ID and providing a factory callback.
    /// <code>Offset: 0x00486830
    /// void __cdecl UIOption_CheckboxBitfield::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00486830)();

    /// <summary>Applies a checkbox bitfield setting to the relevant player option or user preference, updating the stored bitmask according to whether the checkbox is checked and notifying observers of the change.
    /// <code>Offset: 0x00486850
    /// bool __thiscall UIOption_CheckboxBitfield::Apply(UIOption_CheckboxBitfield*,bool)</code>
    /// </summary>
    /// <param name="userRequested">True if the change was initiated by the user; this value is passed to the notification system when the option is applied.</param>
    /// <returns>True if the setting was successfully applied; false if no applicable property or preference was found.</returns>
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, byte, byte>)0x00486850)(ref this, userRequested);

    /// <summary>
    /// Returns true when all bits specified by the instance’s bitmask are set in the current option or preference value associated with this checkbox.
    /// 
    /// <code>Offset: 0x00486AC0
    /// bool __thiscall UIOption_CheckboxBitfield::GetValue(UIOption_CheckboxBitfield*)</code>
    /// </summary>
    /// <returns>A boolean indicating whether the stored value satisfies the mask.</returns>
    public byte GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield, byte>)0x00486AC0)(ref this);
}

