namespace ACBindings.Internal;


/// <summary>
/// Represents a user‑configurable slider option within the UI, tracking its default, current, and saved values while linking to either a preference key or a gameplay property.
/// </summary>
public unsafe struct UIOption_Slider : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement_Scrollbar BaseClass_UIElement_Scrollbar; // ACBindings.Internal.UIElement_Scrollbar

    // Child Types
    public unsafe struct UIOption_Slider_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> UIOption_Slider_dtor_2a8; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, void> Refresh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte> Changed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte> RestoreSavedValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte> RestoreDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte> SaveCurrentValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, void> HandleDialogAndNotices; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, byte, byte> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Slider*, float, void> SetDefaultValue; // function pointer

        // Methods
    }

    // Members
    public float m_default;
    public float m_saved;
    public float m_current;
    public ACBindings.Internal.PStringBase__sbyte m_prefName;
    public uint m_propName;
    public float m_lowerValue;
    public float m_upperValue;
    public uint m_numStops;
    public ushort m_precision;
    public byte m_setAsInt;

    // Generated Constructor
    public UIOption_Slider(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Clamps the slider’s current value to its defined lower and upper limits, computes the relative position within that range, and updates the associated scrollbar element to reflect this new value.
    /// <code>Offset: 0x00484E10
    /// void __thiscall UIOption_Slider::Refresh(UIOption_Slider*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, void>)0x00484E10)(ref this);

    /// <summary>Determines whether the slider's current value has diverged from its last saved setting.
    /// <code>Offset: 0x00484E80
    /// bool __thiscall UIOption_Slider::Changed(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>True if the current value differs from the stored value, otherwise false.</returns>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, byte>)0x00484E80)(ref this);

    /// <summary>Restores the slider’s current value to its last saved state, closes any open dialog associated with the option, and notifies the server of the change.
    /// <code>Offset: 0x00484EA0
    /// bool __thiscall UIOption_Slider::RestoreSavedValue(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>True if the restoration succeeded (always true in this implementation).</returns>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, byte>)0x00484EA0)(ref this);

    /// <summary>Restores the slider’s current value to its default, closes any open dialog, and notifies the system of the change.
    /// <code>Offset: 0x00484ED0
    /// bool __thiscall UIOption_Slider::RestoreDefaultValue(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>True to indicate the operation succeeded.</returns>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, byte>)0x00484ED0)(ref this);

    /// <summary>Sets the slider’s default value.
    /// <code>Offset: 0x00484F00
    /// void __thiscall UIOption_Slider::SetDefaultValue(UIOption_Slider*,float)</code>
    /// </summary>
    /// <param name="defaulta">The new default float value for the slider.</param>
    public void SetDefaultValue(float defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, float, void>)0x00484F00)(ref this, defaulta);

    /// <summary>Responds to slider messages by updating the current value and scrolling area when a specific message id (10) from the slider element is received, then forwards processing to the scrollbar base handler.
    /// <code>Offset: 0x00484F10
    /// UIElementMessageListenResult __thiscall UIOption_Slider::ListenToElementMessage(UIOption_Slider*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>The result of listening to the element message as determined by the base scrollbar implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00484F10)(ref this, i_rMsg);

    /// <summary>Retrieves the current value of the slider component.
    /// <code>Offset: 0x00484F80
    /// float __thiscall UIOption_Slider::GetCurrentValue(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>A float representing the slider’s presently selected value.</returns>
    public float GetCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, float>)0x00484F80)(ref this);

    /// <summary>Updates the slider's current value and triggers associated notifications.
    /// <code>Offset: 0x00484F90
    /// void __thiscall UIOption_Slider::SetCurrentValue(UIOption_Slider*,float)</code>
    /// </summary>
    /// <param name="i_fNewValue">The new value to assign to the slider.</param>
    public void SetCurrentValue(float i_fNewValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, float, void>)0x00484F90)(ref this, i_fNewValue);

    /// <summary>Destroys a UIOption_Slider instance, releasing its preference name buffer and properly destructing all inherited components.
    /// <code>Offset: 0x00484FC0
    /// void __thiscall UIOption_Slider::~UIOption_Slider(UIOption_Slider*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, void>)0x00484FC0)(ref this);

    /// <summary>Provides a runtime cast from UIOption_Slider to the requested UIElement-derived type identified by i_eType.
    /// <code>Offset: 0x00485020
    /// UIElement* __thiscall UIOption_Slider::DynamicCast(UIOption_Slider*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired element type; specific values (268435511, 10, 11, 1, 12) are supported.</param>
    /// <returns>Pointer to the corresponding UIElement instance if the cast matches a known type; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, uint, ACBindings.Internal.UIElement*>)0x00485020)(ref this, i_eType);

    /// <summary>Returns the unique identifier representing a slider UI element type.
    /// <code>Offset: 0x00485060
    /// unsigned int __thiscall UIOption_Slider::GetUIElementType(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>The UI element type ID for a slider control.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, uint>)0x00485060)(ref this);

    /// <summary>Attempts to interpret the slider instance as a UIElement matching the supplied type identifier.
    /// <code>Offset: 0x00485080
    /// UIElement* __thiscall UIOption_Slider::DynamicCast(unsigned int)</code>
    /// </summary>
    /// <param name="typeId">Identifier of the desired UIElement type for casting.</param>
    /// <returns>A pointer to the UIElement if the cast succeeds; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, ACBindings.Internal.UIElement*>)0x00485080)(ref this);

    /// <summary>Configures the slider based on stored UI preference data for a given table ID, updating its label, tooltip and range as needed.
    /// <code>Offset: 0x00485090
    /// char __thiscall UIOption_Slider::SetUIPreference(UIOption*,char**)</code>
    /// </summary>
    /// <param name="tableID">Pointer to a string that identifies the preference table; may be updated with an internal reference during configuration.</param>
    /// <returns>Non‑zero if the preference was successfully retrieved and applied; zero otherwise.</returns>
    public sbyte SetUIPreference(sbyte** tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, sbyte**, sbyte>)0x00485090)(ref this, tableID);

    /// <summary>Updates the slider’s displayed label by applying the supplied StringInfo to its text child element, if such an element exists.
    /// <code>Offset: 0x004851C0
    /// void __thiscall UIOption_Slider::SetLabel(UIOption_Slider*,const StringInfo*)</code>
    /// </summary>
    /// <param name="i_siLabel">StringInfo containing the new label text and related metadata.</param>
    public void SetLabel(ACBindings.Internal.StringInfo* i_siLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, ACBindings.Internal.StringInfo*, void>)0x004851C0)(ref this, i_siLabel);

    /// <summary>Initializes a slider option UI element, establishing default range and behavior, and registers it with the global event handler.
    /// <code>Offset: 0x00485310
    /// void __thiscall UIOption_Slider::UIOption_Slider(UIOption_Slider*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description used to configure visual layout of the element.</param>
    /// <param name="full_desc">Element descriptor containing configuration for the slider control.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00485310)(ref this, layout, full_desc);

    /// <summary>Creates a new slider UI element from the provided layout and element description.
    /// <code>Offset: 0x004853C0
    /// UIElement* __cdecl UIOption_Slider::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information defining dimensions and elements for the UI.</param>
    /// <param name="full_desc">Complete descriptor of the slider element to be instantiated.</param>
    /// <returns>Pointer to the created UIElement instance, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004853C0)(layout, full_desc);

    /// <summary>Sets the slider’s gameplay option association using a property identifier, then updates the UI to display the option’s name, tooltip and default value appropriately.
    /// <code>Offset: 0x004853F0
    /// void __thiscall UIOption_Slider::SetGameplayOptionProperty(UIOption_Slider*,unsigned int)</code>
    /// </summary>
    /// <param name="propName">The unique identifier of the gameplay option that this slider should control.</param>
    public void SetGameplayOptionProperty(uint propName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, uint, void>)0x004853F0)(ref this, propName);

    /// <summary>Registers UIOption_Slider as a UI element class, enabling its creation through the UI system's factory mechanism.
    /// <code>Offset: 0x004855E0
    /// void __cdecl UIOption_Slider::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004855E0)();

    /// <summary>Applies the slider’s current value to the appropriate system—setting a player‑module property if a property name is specified, otherwise updating a persistent preference—and then notifies listeners of the change.
    /// <code>Offset: 0x00485600
    /// bool __thiscall UIOption_Slider::Apply(UIOption_Slider*,bool)</code>
    /// </summary>
    /// <param name="userRequested">Indicates whether the caller requested this change; it is passed to the notice handler after applying the value.</param>
    /// <returns>True when the option was successfully applied, false if no target property or preference could be resolved.</returns>
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, byte, byte>)0x00485600)(ref this, userRequested);

    /// <summary>
    /// Retrieves the current value for a UI slider option. The method queries the player module's property system; if the property is absent it falls back to the corresponding user preference or the default value, converting between integer and float representations according to the m_setAsInt flag.
    /// 
    /// <code>Offset: 0x004857E0
    /// float __thiscall UIOption_Slider::GetValue(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>The slider’s value as a float, interpreted as an integer when m_setAsInt is true.</returns>
    public float GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, float>)0x004857E0)(ref this);

    /// <summary>Stores the slider’s current value into its internal state and marks it as saved, ensuring subsequent operations use the updated value.
    /// <code>Offset: 0x004859E0
    /// bool __thiscall UIOption_Slider::SaveCurrentValue(UIOption_Slider*)</code>
    /// </summary>
    /// <returns>Always true to indicate the operation succeeded.</returns>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, byte>)0x004859E0)(ref this);

    /// <summary>Refreshes the slider control in the options panel by synchronizing its current value with the stored preference and notifying the system of the updated position.
    /// <code>Offset: 0x00485A00
    /// void __thiscall UIOption_Slider::RecvNotice_RefreshOptionsPanel(UIOption_Slider*)</code>
    /// </summary>
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, void>)0x00485A00)(ref this);

    /// <summary>Sets the tooltip displayed when hovering over the slider control.
    /// <code>Offset: 0x00487410
    /// void __thiscall UIOption_Slider::SetTooltip(UIOption_Menu*,const StringInfo*)</code>
    /// </summary>
    /// <param name="i_siTooltip">The StringInfo containing the tooltip text to display.</param>
    public void SetTooltip(ACBindings.Internal.StringInfo* i_siTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Slider, ACBindings.Internal.StringInfo*, void>)0x00487410)(ref this, i_siTooltip);
}

