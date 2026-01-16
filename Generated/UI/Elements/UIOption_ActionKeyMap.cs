namespace ACBindings.Internal;


/// <summary>Handles the mapping of keyboard and mouse inputs to in‑game actions, providing default, saved, and current bindings while presenting an editable UI panel for users.</summary>
/// <remarks>This component integrates with the global input manager and UI system, managing dialogs, change notifications, and persistence across sessions. It derives from UIOption and UIElement_Text, enabling it to respond to user interactions and update bound actions in real time.</remarks>
public unsafe struct UIOption_ActionKeyMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement_Text BaseClass_UIElement_Text; // ACBindings.Internal.UIElement_Text

    // Child Types
    public unsafe struct UIOption_ActionKeyMap_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> UIOption_ActionKeyMap_dtor_2a8; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> Refresh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> Changed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> RestoreSavedValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> RestoreDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> SaveCurrentValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> HandleDialogAndNotices; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Button* m_buttonClear;
    public ACBindings.Internal.SmartArray___UIElement_Button_ptr m_aKeyButtons;
    public uint m_idInputAction;
    public uint m_idInputMap;
    public ACBindings.Internal.List___QualifiedControl m_qclDefaults;
    public ACBindings.Internal.List___QualifiedControl m_qclSaved;
    public ACBindings.Internal.List___QualifiedControl m_qclCurrent;
    public ACBindings.Internal.QualifiedControl m_qcBindingBeingChanged;
    public int m_nBindingBeingChanged;
    public uint m_ctxtDialog;
    public uint m_ctxtOverwriteBindingDialog;
    public uint m_ctxtCantOverwriteBindingDialog;
    public int m_skipConfirmation;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Refreshes the action key mapping options panel in response to a server notice.
    /// <code>Offset: 0x00487420
    /// void __thiscall UIOption_ActionKeyMap::RecvNotice_RefreshOptionsPanel(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487420)(ref this);

    /// <summary>Closes the map warning dialog if it is currently open and clears its context handle.
    /// <code>Offset: 0x00487430
    /// void __thiscall UIOption_ActionKeyMap::CloseMapWarnDialog(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void CloseMapWarnDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487430)(ref this);

    /// <summary>Refreshes the key‑binding UI by iterating over all action buttons, updating each button’s label and tooltip to reflect the current binding or a “New Binding” placeholder. After processing, it enables or disables the Clear button based on whether any bindings exist.
    /// <code>Offset: 0x00487640
    /// void __thiscall UIOption_ActionKeyMap::Refresh(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487640)(ref this);

    /// <summary>Determines whether the current key map differs from the stored configuration by comparing the sizes and contents of the saved and current control lists.
    /// <code>Offset: 0x00487AA0
    /// bool __thiscall UIOption_ActionKeyMap::Changed(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>True if a difference exists; otherwise, false.</returns>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00487AA0)(ref this);

    /// <summary>Removes the key binding at the specified index from the current action map, updates the system, and notifies any change handlers.
    /// <code>Offset: 0x00487B40
    /// bool __thiscall UIOption_ActionKeyMap::EraseBinding(UIOption_ActionKeyMap*,int)</code>
    /// </summary>
    /// <param name="i_nBindingNumber">Zero‑based index of the binding to erase in the current list.</param>
    /// <returns>True if the binding was successfully removed; false if the index is invalid or no valid binding exists.</returns>
    public byte EraseBinding(int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, int, byte>)0x00487B40)(ref this, i_nBindingNumber);

    /// <summary>Initializes the action‑key mapping UI element, loading default bindings, registering global event handlers, and preparing child controls for user interaction.
    /// <code>Offset: 0x00487BF0
    /// void __thiscall UIOption_ActionKeyMap::PostInit(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487BF0)(ref this);

    /// <summary>Sets or updates the binding for an action key in this option's map based on the supplied control and list index.
    /// <code>Offset: 0x00487E50
    /// bool __thiscall UIOption_ActionKeyMap::SetBinding(UIOption_ActionKeyMap*,QualifiedControl,int)</code>
    /// </summary>
    /// <param name="i_qc">The key configuration to assign, including key code, metamode, and activation flag.</param>
    /// <param name="i_nBindingNumber">Zero‑based position in the current bindings list where the new binding should be inserted; negative values clamp to 0 and values beyond the list size append at the end.</param>
    /// <returns>True when the binding was successfully registered or updated and the UI was refreshed, otherwise false (e.g., invalid key, disabled activation, or conflict handling failure).</returns>
    public byte SetBinding(ACBindings.Internal.QualifiedControl i_qc, int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.QualifiedControl, int, byte>)0x00487E50)(ref this, i_qc, i_nBindingNumber);

    /// <summary>Removes every key binding from the current action map, clearing its internal list and informing listeners.
    /// <code>Offset: 0x00488200
    /// bool __thiscall UIOption_ActionKeyMap::ClearAllBindings(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>Always returns true after successfully clearing all bindings.</returns>
    public byte ClearAllBindings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00488200)(ref this);

    /// <summary>Performs a type-safe downcast of this object to its UIElement base when the supplied type identifier matches known UIElement types.
    /// <code>Offset: 0x00488430
    /// UIElement* __thiscall UIOption_ActionKeyMap::DynamicCast(UIOption_ActionKeyMap*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Integer indicating the target type; specific values (268435508, 12, or 10) correspond to UIElement and related subtypes.</param>
    /// <returns>Pointer to the UIElement part of this object if the requested type matches; otherwise, null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint, ACBindings.Internal.UIElement*>)0x00488430)(ref this, i_eType);

    /// <summary>Returns the unique identifier of the UI element type represented by this action key map option.
    /// <code>Offset: 0x00488470
    /// unsigned int __thiscall UIOption_ActionKeyMap::GetUIElementType(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>The numeric ID corresponding to the element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint>)0x00488470)(ref this);

    /// <summary>Attempts to cast the current UIOption_ActionKeyMap instance to a UIElement based on the supplied type identifier, returning the base class pointer or null.
    /// <code>Offset: 0x00488490
    /// UIElement* __thiscall UIOption_ActionKeyMap::DynamicCast(unsigned int)</code>
    /// </summary>
    /// <param name="this">Type identifier indicating the desired element type for casting.</param>
    /// <returns>A pointer to the UIElement base if the cast succeeds; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.UIElement*>)0x00488490)(ref this);

    /// <summary>Destroys a UIOption_ActionKeyMap object, unregistering global event handlers, clearing input binding lists, deleting any dynamically allocated key button array, and invoking base class destructors.
    /// <code>Offset: 0x004884A0
    /// void __thiscall UIOption_ActionKeyMap::~UIOption_ActionKeyMap(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x004884A0)(ref this);

    /// <summary>Creates a UI element representing an action key map using the supplied layout and element description.
    /// <code>Offset: 0x00488560
    /// UIElement* __cdecl UIOption_ActionKeyMap::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes display dimensions and elements for the UI layout.</param>
    /// <param name="full_desc">Full descriptor of the UI element to instantiate.</param>
    /// <returns>A pointer to the newly created UIElement, or null if creation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00488560)(layout, full_desc);

    /// <summary>Copies the current key mapping into the saved state, marking it as committed.
    /// <code>Offset: 0x00488590
    /// bool __thiscall UIOption_ActionKeyMap::SaveCurrentValue(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>Always returns true to indicate the operation succeeded.</returns>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00488590)(ref this);

    /// <summary>Restores the input-action mappings for this action map from the stored configuration, updating internal state and notifying the system of changes.
    /// <code>Offset: 0x004885B0
    /// bool __thiscall UIOption_ActionKeyMap::RestoreSavedValue(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>True if the restore operation completed successfully; otherwise false.</returns>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x004885B0)(ref this);

    /// <summary>Restores the action’s key mapping to its default configuration.
    /// <code>Offset: 0x00488820
    /// bool __thiscall UIOption_ActionKeyMap::RestoreDefaultValue(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>True, indicating the defaults were applied successfully.</returns>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00488820)(ref this);

    /// <summary>Refreshes the current input mapping list for this action by clearing any cached bindings, fetching updated mappings from the global input manager, and notifying the option framework of a change.
    /// <code>Offset: 0x00488850
    /// void __thiscall UIOption_ActionKeyMap::RefreshMappings(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void RefreshMappings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00488850)(ref this);

    /// <summary>Refreshes action key mappings for the specified control when it is valid and active.
    /// <code>Offset: 0x004888A0
    /// void __thiscall UIOption_ActionKeyMap::RecvNotice_RefreshActionKeyMapping(UIOption_ActionKeyMap*,const QualifiedControl*)</code>
    /// </summary>
    /// <param name="qcMapped">The control whose mapping has been updated or notified.</param>
    public void RecvNotice_RefreshActionKeyMapping(ACBindings.Internal.QualifiedControl* qcMapped) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.QualifiedControl*, void>)0x004888A0)(ref this, qcMapped);

    /// <summary>
    /// Closes a key‑binding dialog, resetting temporary binding state and applying any confirmed changes when the dialog is an overwrite‑binding prompt.
    /// 
    /// <code>Offset: 0x004888D0
    /// void __thiscall UIOption_ActionKeyMap::RecvNotice_CloseDialog(UIOption_ActionKeyMap*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">The identifier of the dialog being closed (e.g., overwrite‑binding or cannot‑overwrite‑binding context).</param>
    /// <param name="data">A collection of properties supplied with the notice, typically containing user confirmation data; may be null if not needed.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint, ACBindings.Internal.PropertyCollection*, void>)0x004888D0)(ref this, context, data);

    /// <summary>Restores the default mouse‑wheel bindings for camera zoom actions when the corresponding input action is detected, updates the internal binding state and notifies the user via a scrolling message.
    /// <code>Offset: 0x00488A20
    /// void __thiscall UIOption_ActionKeyMap::SetMouseTurningDefaults(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void SetMouseTurningDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00488A20)(ref this);

    /// <summary>Registers the UIOption_ActionKeyMap class with the UI framework, enabling its creation through layout descriptors.
    /// <code>Offset: 0x00488BF0
    /// void __cdecl UIOption_ActionKeyMap::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00488BF0)();

    /// <summary>Handles global messages for the action key mapping UI, performing special handling for message 12 to reset mouse‑turning defaults before delegating to base text element logic.
    /// <code>Offset: 0x00488D00
    /// void __thiscall UIOption_ActionKeyMap::ListenToGlobalMessage(UIOption_ActionKeyMap*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message received.</param>
    /// <param name="i_data_int">Associated integer data for the message.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint, int, void>)0x00488D00)(ref this, i_messageID, i_data_int);

    /// <summary>Opens a warning dialog in the current UI using the supplied message string.
    /// <code>Offset: 0x00488D30
    /// bool __thiscall UIOption_ActionKeyMap::OpenMapWarnDialog(UIOption_ActionKeyMap*,StringInfo*)</code>
    /// </summary>
    /// <param name="siMsg">The message to display; must be valid and non‑empty.</param>
    /// <returns>True if the dialog was successfully created, otherwise false (e.g., when a dialog is already active or the message is invalid).</returns>
    public byte OpenMapWarnDialog(ACBindings.Internal.StringInfo* siMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.StringInfo*, byte>)0x00488D30)(ref this, siMsg);

    /// <summary>Opens an overwrite‑binding confirmation dialog when no other option map dialog is active. The dialog displays the key(s) and action(s) supplied in a2 and then creates the UI element through DialogFactory.
    /// <code>Offset: 0x00488F20
    /// bool __thiscall UIOption_ActionKeyMap::OpenOverwriteBindingDialog(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array of binding descriptors.  
    /// - `a2[0]` points to the first descriptor.  
    /// - `a2[2]` holds the number of bindings described by the array.  
    /// Each descriptor contains identifiers for a key and its associated action, which are used to populate the dialog text.</param>
    /// <returns>True if the dialog was successfully created; otherwise false.</returns>
    public byte OpenOverwriteBindingDialog(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, int*, byte>)0x00488F20)(ref this, a2);

    /// <summary>Opens a dialog informing the user that the current key binding cannot be overwritten, using details of the pending binding change.
    /// <code>Offset: 0x00489630
    /// bool __thiscall UIOption_ActionKeyMap::OpenCantOverwriteBindingDialog(UIOption_ActionKeyMap*)</code>
    /// </summary>
    /// <returns>True if the dialog was successfully created; otherwise false.</returns>
    public byte OpenCantOverwriteBindingDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00489630)(ref this);

    /// <summary>Handles key‑press events in the action‑key mapping options panel, updating the current binding and handling conflicts with existing bindings.
    /// <code>Offset: 0x004898A0
    /// bool __thiscall UIOption_ActionKeyMap::KeyHitHandler(UIOption_ActionKeyMap*,const QualifiedControl*,unsigned int*)</code>
    /// </summary>
    /// <param name="i_key">The key press to process, including its modifiers and activation flags.</param>
    /// <param name="o_idAction">Receives the identifier of the action bound to this key (if any).</param>
    /// <returns>True if the key was processed or a conflict dialog was displayed; false when an error prevented updating the binding.</returns>
    public byte KeyHitHandler(ACBindings.Internal.QualifiedControl* i_key, uint* o_idAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.QualifiedControl*, uint*, byte>)0x004898A0)(ref this, i_key, o_idAction);

    /// <summary>Initiates a key binding change by presenting a warning dialog and starting input capture for the specified binding number.
    /// <code>Offset: 0x00489D00
    /// bool __thiscall UIOption_ActionKeyMap::InitiateBinding(UIOption_ActionKeyMap*,int)</code>
    /// </summary>
    /// <param name="i_nBindingNumber">Index of the action binding to be changed.</param>
    /// <returns>True if the binding process was started successfully; otherwise, false.</returns>
    public byte InitiateBinding(int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, int, byte>)0x00489D00)(ref this, i_nBindingNumber);

    /// <summary>Handles element messages for the key‑binding panel, initiating, erasing, or clearing bindings based on mouse actions, and forwards other events to the underlying text handler.
    /// <code>Offset: 0x00489DB0
    /// UIElementMessageListenResult __thiscall UIOption_ActionKeyMap::ListenToElementMessage(UIOption_ActionKeyMap*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message received.</param>
    /// <returns>A UIElementMessageListenResult indicating whether the message was processed by this component.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00489DB0)(ref this, i_rMsg);
}

