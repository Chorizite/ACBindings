namespace ACBindings.Internal;


/// <summary>
/// Represents a user‑interface option that presents multiple checkboxes backed by a 64‑bit bitfield. Holds default, current and saved values, tracks property identifiers, and maintains child checkbox metadata for populating a list box. Provides logic for applying changes to the player module, restoring defaults, and notifying the UI system of state transitions.
/// </summary>
public unsafe struct UIOption_CheckboxBitfield64 : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement_ListBox BaseClass_UIElement_ListBox; // ACBindings.Internal.UIElement_ListBox

    // Child Types
    public unsafe struct UIOption_CheckboxBitfield64_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> UIOption_CheckboxBitfield64_dtor_2a8; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, void> Refresh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> Changed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> RestoreSavedValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> RestoreDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte> SaveCurrentValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, void> HandleDialogAndNotices; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, byte, byte> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ulong, void> SetDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_CheckboxBitfield64*, ulong> GetValue; // function pointer

        // Methods
    }

    /// <summary>Single child checkbox representation within a 64‑bit bitfield option, storing its bitmask and UI text for label and tooltip.</summary>
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

        /// <summary>Initializes a new ChildInfo structure, setting the bitmask to zero and constructing default StringInfo members for label and tooltip.
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

    /// <summary>Determines whether the current 64‑bit checkbox state differs from the stored value.
    /// <code>Offset: 0x00485A60
    /// bool __thiscall UIOption_CheckboxBitfield64::Changed(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    /// <returns>True if any bit in m_current is different from the corresponding bit in m_saved; otherwise false.</returns>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485A60)(ref this);

    /// <summary>Copies the current checkbox bitfield value obtained via RecvNotice_DisplayStringInfo into both the current and saved fields, marking the option as unchanged.
    /// <code>Offset: 0x00485A90
    /// bool __thiscall UIOption_CheckboxBitfield64::SaveCurrentValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    /// <returns>True to indicate successful save operation.</returns>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485A90)(ref this);

    /// <summary>Restores the option’s current bitfield value from the saved state, then signals the UI that the dialog has closed and items have moved on the server.
    /// <code>Offset: 0x00485AC0
    /// bool __thiscall UIOption_CheckboxBitfield64::RestoreSavedValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    /// <returns>True to indicate successful restoration.</returns>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485AC0)(ref this);

    /// <summary>Resets the option's current value to its predefined default, closes any open dialog, and notifies the system that the item has been moved.
    /// <code>Offset: 0x00485B00
    /// bool __thiscall UIOption_CheckboxBitfield64::RestoreDefaultValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    /// <returns>Always true to indicate success.</returns>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte>)0x00485B00)(ref this);

    /// <summary>Sets the default bitfield value for this checkbox option.
    /// <code>Offset: 0x00485B40
    /// void __thiscall UIOption_CheckboxBitfield64::SetDefaultValue(UIOption_CheckboxBitfield64*,unsigned __int64)</code>
    /// </summary>
    /// <param name="this">The UIOption_CheckboxBitfield64 instance to modify.</param>
    /// <param name="defaulta">The 64‑bit value to assign as the default.</param>
    public void SetDefaultValue(ulong defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ulong, void>)0x00485B40)(ref this, defaulta);

    /// <summary>Reloads the checkbox bitfield options by fetching the stored value into the current state and invoking any registered update callbacks.
    /// <code>Offset: 0x00485B60
    /// void __thiscall UIOption_CheckboxBitfield64::RecvNotice_ReloadOptions(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void RecvNotice_ReloadOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x00485B60)(ref this);

    /// <summary>Updates child checkboxes to reflect the current 64‑bit option value, setting checked state and image based on whether each mask is satisfied.
    /// <code>Offset: 0x00485D80
    /// void __thiscall UIOption_CheckboxBitfield64::Refresh(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x00485D80)(ref this);

    /// <summary>Handles toggle events for a 64‑bit checkbox option, updating the underlying bitfield and forwarding the message to the base list‑box handler.
    /// <code>Offset: 0x00485EA0
    /// UIElementMessageListenResult __thiscall UIOption_CheckboxBitfield64::ListenToElementMessage(UIOption_CheckboxBitfield64*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element event being processed.</param>
    /// <returns>A UIElementMessageListenResult value indicating whether the message was handled by this option or passed to the base ListBox implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00485EA0)(ref this, i_rMsg);

    /// <summary>Initializes a checkbox bitfield UI option within the specified layout, setting all internal state to default values and preparing the list‑box base structure for user interaction.
    /// <code>Offset: 0x00486010
    /// void __thiscall UIOption_CheckboxBitfield64::UIOption_CheckboxBitfield64(UIOption_CheckboxBitfield64*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing sizing, positioning, and child element information for the UI component.</param>
    /// <param name="full_desc">Element descriptor containing visual and behavioral attributes of the checkbox list box.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00486010)(ref this, layout, full_desc);

    /// <summary>Attempts to cast a UIOption_CheckboxBitfield64 instance to a UIElement based on the supplied type identifier. If the requested type matches one of the supported identifiers, returns a pointer to the embedded UIElement; otherwise returns nullptr.
    /// <code>Offset: 0x004860A0
    /// UIElement* __thiscall UIOption_CheckboxBitfield64::DynamicCast(UIOption_CheckboxBitfield64*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric identifier representing the desired target type.</param>
    /// <returns>Pointer to the UIElement component if the cast succeeds; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, uint, ACBindings.Internal.UIElement*>)0x004860A0)(ref this, i_eType);

    /// <summary>Retrieves the UI element type identifier for this checkbox bitfield option.
    /// <code>Offset: 0x004860E0
    /// unsigned int __thiscall UIOption_CheckboxBitfield64::GetUIElementType(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant identifying the element type (0x10000044).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, uint>)0x004860E0)(ref this);

    /// <summary>Attempts to cast this UIOption_CheckboxBitfield64 instance to a UIElement of the specified runtime type.
    /// <code>Offset: 0x00486100
    /// UIElement* __thiscall UIOption_CheckboxBitfield64::DynamicCast(unsigned int)</code>
    /// </summary>
    /// <param name="this">Runtime type identifier for the desired UIElement subclass.</param>
    /// <returns>A pointer to the resulting UIElement if the cast succeeds; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ACBindings.Internal.UIElement*>)0x00486100)(ref this);

    /// <summary>Destroys a UIOption_CheckboxBitfield64 instance, freeing its child value array, releasing the preference name string, and invoking destructors for UIElement_ListBox and UIOption base classes.
    /// <code>Offset: 0x00486110
    /// void __thiscall UIOption_CheckboxBitfield64::~UIOption_CheckboxBitfield64(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x00486110)(ref this);

    /// <summary>Creates a new UIOption_CheckboxBitfield64 instance and returns its underlying UIElement.
    /// <code>Offset: 0x00486180
    /// UIElement* __cdecl UIOption_CheckboxBitfield64::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes the overall layout context for the element.</param>
    /// <param name="full_desc">Provides detailed description of the checkbox bitfield element to be created.</param>
    /// <returns>A pointer to the newly created UIElement, or nullptr if allocation or initialization fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00486180)(layout, full_desc);

    /// <summary>Creates checkbox items within the option’s list box from stored child values, assigns each item its label, tooltip and internal ID, then recalculates layout dimensions and signals the parent of any changes.
    /// <code>Offset: 0x004861B0
    /// void __thiscall UIOption_CheckboxBitfield64::CreateChildren(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    public void CreateChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, void>)0x004861B0)(ref this);

    /// <summary>Registers the checkbox bitfield UI option class with the UI framework, associating it with an element type identifier and a factory function.
    /// <code>Offset: 0x00486290
    /// void __cdecl UIOption_CheckboxBitfield64::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00486290)();

    /// <summary>Sets the option’s property identifier and type when its stored preference name matches a specific global name using a case‑insensitive comparison.
    /// <code>Offset: 0x004862B0
    /// void __thiscall UIOption_CheckboxBitfield64::SetGameplayOptionProperty(UIOption_CheckboxBitfield64*,unsigned int,UIOption_CheckboxBitfield64::PropertyType)</code>
    /// </summary>
    /// <param name="i_propName">Identifier for the property being set.</param>
    /// <param name="i_type">Enumeration value specifying the property’s type.</param>
    public void SetGameplayOptionProperty(uint i_propName, ACBindings.Internal.UIOption_CheckboxBitfield64.PropertyType i_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, uint, ACBindings.Internal.UIOption_CheckboxBitfield64.PropertyType, void>)0x004862B0)(ref this, i_propName, i_type);

    /// <summary>Applies the stored bitfield setting to the player module, updating the corresponding option and optionally creating a notice when requested.
    /// <code>Offset: 0x004863B0
    /// bool __thiscall UIOption_CheckboxBitfield64::Apply(UIOption_CheckboxBitfield64*,bool)</code>
    /// </summary>
    /// <param name="userRequested">Indicates whether the change was initiated by the user; if true a notice is generated after applying the option.</param>
    /// <returns>True if the option was successfully applied (a property name exists); otherwise false.</returns>
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, byte, byte>)0x004863B0)(ref this, userRequested);

    /// <summary>Returns the current value of a 64‑bit checkbox option, retrieving it from the player module when a property name is defined or returning the default value otherwise.
    /// <code>Offset: 0x00486510
    /// unsigned __int64 __thiscall UIOption_CheckboxBitfield64::GetValue(UIOption_CheckboxBitfield64*)</code>
    /// </summary>
    /// <returns>The 64‑bit unsigned integer representing the option state.</returns>
    public ulong GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ulong>)0x00486510)(ref this);

    /// <summary>Adds a child checkbox entry represented by the provided 64‑bit mask to this option’s list of child values.
    /// <code>Offset: 0x00486660
    /// void __thiscall UIOption_CheckboxBitfield64::AddChild(UIOption_CheckboxBitfield64*,unsigned __int64,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_llMask">Bitmask identifying which bits in the option’s bitfield correspond to this child checkbox.</param>
    /// <param name="i_stLabel">String ID for the checkbox label (currently not retained).</param>
    /// <param name="i_stTooltip">String ID for the checkbox tooltip (currently not retained).</param>
    public void AddChild(ulong i_llMask, uint i_stLabel, uint i_stTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_CheckboxBitfield64, ulong, uint, uint, void>)0x00486660)(ref this, i_llMask, i_stLabel, i_stTooltip);
}

