namespace ACBindings.Internal;


/// <summary>Represents a configurable menu option in the UI, storing default, saved, and current values tied to a preference name.</summary>
/// <remarks>Provides drop‑down list functionality and handles applying or restoring user selections.</remarks>
public unsafe struct UIOption_Menu : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement_Menu BaseClass_UIElement_Menu; // ACBindings.Internal.UIElement_Menu

    // Child Types
    public unsafe struct UIOption_Menu_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, float, void> RecvNotice_LoadChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_Ping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_ReloadOptions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_ExamineObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_FellowAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_FellowQuit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_BeginGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_EndGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, void> RecvNotice_GameOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, void> RecvNotice_StartGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_BeginEnterWorld; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_CastCurrentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_FirstSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_FirstSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_LastSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_LastSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_NextSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_NextSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_PrevSpellSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_PrevSpellTab; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SpellAdded; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_VitaeChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_CloseTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_OpenTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_ResetTrade; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_Logoff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_SelectionChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_SplitStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> UIOption_Menu_dtor_2a8; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, void> Refresh; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte> Changed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte> RestoreSavedValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte> RestoreDefaultValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte> SaveCurrentValue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, void> HandleDialogAndNotices; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, byte, byte> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint, void> SetDefaultValue; // function pointer
        public System.IntPtr SetEntries;
        public System.IntPtr SetLiteralEntries;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_Menu*, uint> GetValue; // function pointer

        // Methods
    }

    // Members
    public uint m_default;
    public uint m_saved;
    public uint m_current;
    public ACBindings.Internal.PStringBase__sbyte m_prefName;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Selects the menu item whose associated attribute matches the object's current value. If no items exist or none match, defaults to the first item in the list. Operates on the UIElement_Menu baseclass of the option.
    /// <code>Offset: 0x00484020
    /// void __thiscall UIOption_Menu::Refresh(UIOption_Menu*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, void>)0x00484020)(ref this);

    /// <summary>Determines whether the menu’s current selection differs from its previously saved value.
    /// <code>Offset: 0x004840B0
    /// bool __thiscall UIOption_Menu::Changed(UIOption_Menu*)</code>
    /// </summary>
    /// <returns>True if the current option differs from the stored value, otherwise false.</returns>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, byte>)0x004840B0)(ref this);

    /// <summary>Saves the current menu option value into the persisted state, updating both current and saved fields.
    /// <code>Offset: 0x004840D0
    /// bool __thiscall UIOption_Menu::SaveCurrentValue(UIOption_Menu*)</code>
    /// </summary>
    /// <returns>True after storing the value successfully.</returns>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, byte>)0x004840D0)(ref this);

    /// <summary>Restores the menu option’s current value to its previously saved state, closes the associated dialog, and notifies the server of a move action.
    /// <code>Offset: 0x004840F0
    /// bool __thiscall UIOption_Menu::RestoreSavedValue(UIOption_Menu*)</code>
    /// </summary>
    /// <returns>True (always).</returns>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, byte>)0x004840F0)(ref this);

    /// <summary>Restores the menu option’s current value to its default and triggers required UI updates.
    /// <code>Offset: 0x00484120
    /// bool __thiscall UIOption_Menu::RestoreDefaultValue(UIOption_Menu*)</code>
    /// </summary>
    /// <returns>True when the default has been applied successfully.</returns>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, byte>)0x00484120)(ref this);

    /// <summary>Sets the option's default value.
    /// <code>Offset: 0x00484150
    /// void __thiscall UIOption_Menu::SetDefaultValue(UIOption_Menu*,const unsigned int)</code>
    /// </summary>
    /// <param name="defaulta">The new default value for the menu option.</param>
    public void SetDefaultValue(uint defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, uint, void>)0x00484150)(ref this, defaulta);

    /// <summary>Responds to menu selection events by opening, closing, or updating the associated popup list based on the selected item.
    /// <code>Offset: 0x00484160
    /// UIElementMessageListenResult __thiscall UIOption_Menu::ListenToElementMessage(UIOption_Menu*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing the event and target element.</param>
    /// <returns>Result from the base UIElement_Menu message handler.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00484160)(ref this, i_rMsg);

    /// <summary>Updates the menu’s current option state from an open‑dialog notice and then triggers a server‑side move‑item notification to refresh the options panel.
    /// <code>Offset: 0x004841E0
    /// void __thiscall UIOption_Menu::RecvNotice_RefreshOptionsPanel(UIOption_Menu*)</code>
    /// </summary>
    /// <param name="this">The UIOption_Menu instance invoking the handler.</param>
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, void>)0x004841E0)(ref this);

    /// <summary>Retrieves the current integer preference value associated with this menu option. If no preference is stored, zero is returned.
    /// <code>Offset: 0x00484200
    /// unsigned int __thiscall UIOption_Menu::GetValue(UIOption_Menu*)</code>
    /// </summary>
    /// <returns>The stored preference value, or 0 if none exists.</returns>
    public uint GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, uint>)0x00484200)(ref this);

    /// <summary>Handles option dialogs and notices for a menu item, temporarily suppressing confirmation when the user initiates an action while delayed confirmation is enabled.
    /// <code>Offset: 0x00484230
    /// void __thiscall UIOption_Menu::HandleDialogAndNotices(UIOption_Menu*,bool)</code>
    /// </summary>
    /// <param name="userRequested">True if the action was triggered by the user; false otherwise.</param>
    public void HandleDialogAndNotices(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, byte, void>)0x00484230)(ref this, userRequested);

    /// <summary>Handles global messages for UIOption_Menu, performing special handling when message ID 3 is received after the menu has been used once, then unregistering from that message and delegating to the base button handler.
    /// <code>Offset: 0x00484270
    /// void __thiscall UIOption_Menu::ListenToGlobalMessage(UIOption_Menu*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message to process.</param>
    /// <param name="i_data_int">Optional integer data associated with the message.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, uint, int, void>)0x00484270)(ref this, i_messageID, i_data_int);

    /// <summary>Destroys a UIOption_Menu instance, releasing its menu elements and decrementing the reference count of the stored preference name buffer.
    /// <code>Offset: 0x004842C0
    /// void __thiscall UIOption_Menu::~UIOption_Menu(UIOption_Menu*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, void>)0x004842C0)(ref this);

    /// <summary>Performs a type-safe cast of a UIOption_Menu instance to its corresponding UIElement subtype based on an integer type identifier, returning a pointer to the appropriate base subobject or null when no match exists.
    /// <code>Offset: 0x00484320
    /// UIElement* __thiscall UIOption_Menu::DynamicCast(UIOption_Menu*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type code indicating which UIElement-derived class to return.</param>
    /// <returns>A pointer to the requested UIElement base class within the UIOption_Menu object, or nullptr if the type is unsupported or the source object is null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, uint, ACBindings.Internal.UIElement*>)0x00484320)(ref this, i_eType);

    /// <summary>Returns the unique integer identifying the menu option UI element type.
    /// <code>Offset: 0x00484360
    /// unsigned int __thiscall UIOption_Menu::GetUIElementType(UIOption_Menu*)</code>
    /// </summary>
    /// <returns>The constant 268435512, corresponding to the UI element type for a menu option.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, uint>)0x00484360)(ref this);

    /// <summary>Attempts to treat this UIOption_Menu instance as a UIElement of the type identified by an unsigned integer.
    /// <code>Offset: 0x00484380
    /// UIElement* __thiscall UIOption_Menu::DynamicCast(unsigned int)</code>
    /// </summary>
    /// <param name="typeId">Identifier specifying the target UIElement type for casting.</param>
    /// <returns>A pointer to the UIElement representation of the current object if the cast is valid; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, ACBindings.Internal.UIElement*>)0x00484380)(ref this);

    /// <summary>Updates the display label of the menu option with the supplied StringInfo.
    /// <code>Offset: 0x00484390
    /// void __thiscall UIOption_Menu::SetLabel(UIOption_Menu*,const StringInfo*)</code>
    /// </summary>
    /// <param name="i_siLabel">The StringInfo containing the new label text and related data.</param>
    public void SetLabel(ACBindings.Internal.StringInfo* i_siLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, ACBindings.Internal.StringInfo*, void>)0x00484390)(ref this, i_siLabel);

    /// <summary>Populates the menu with text items using the supplied string ID and attribute arrays, returning the count of entries inserted.
    /// <code>Offset: 0x004843D0
    /// unsigned int __thiscall UIOption_Menu::SetEntries(char*,_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the UIOption_Menu instance.</param>
    /// <param name="a2">Pointer to an array that contains a pointer to the string ID table followed by the entry count at index 2.</param>
    /// <param name="a3">Pointer to an array of integer attributes, one for each menu entry.</param>
    /// <param name="strtableEnum">Enumeration identifying which string table to use when resolving text IDs.</param>
    /// <returns>The number of entries processed and inserted into the menu.</returns>
    public uint SetEntries(int* a2, int* a3, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, int*, int*, int, uint>)0x004843D0)(ref this, a2, a3, strtableEnum);

    /// <summary>Applies the current menu selection as a user preference, updating stored values and notifying listeners. Returns true when the value changes, otherwise false.
    /// <code>Offset: 0x00484510
    /// bool __thiscall UIOption_Menu::Apply(UIOption_Menu*,bool)</code>
    /// </summary>
    /// <param name="userRequested">Indicates whether the change was initiated by the user; influences notification behavior.</param>
    /// <returns>True if the preference was updated and notifications sent; false if no update occurred.</returns>
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, byte, byte>)0x00484510)(ref this, userRequested);

    /// <summary>Sets the user preference for a menu option, updating its label and tooltip while managing associated notice callbacks.
    /// <code>Offset: 0x004845C0
    /// void __thiscall UIOption_Menu::SetUserPreference(UIOption*,bool (__cdecl**tableID)())</code>
    /// </summary>
    /// <param name="this">The UIOption instance whose preference is being set.</param>
    /// <param name="tableID">A pointer to an array of functions that supply preference data such as string ID and tooltip information.</param>
    public void SetUserPreference(delegate* unmanaged[Cdecl]<byte>* tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, delegate* unmanaged[Cdecl]<byte>*, void>)0x004845C0)(ref this, tableID);

    /// <summary>Registers the UIOption_Menu element type within the UI subsystem by associating its unique identifier with its constructor function.
    /// <code>Offset: 0x00484720
    /// void __cdecl UIOption_Menu::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00484720)();

    /// <summary>Configures a menu option’s label, tooltip, and available values by querying a preference table, updating the associated notice function if necessary.
    /// <code>Offset: 0x00484740
    /// void __thiscall UIOption_Menu::SetUIPreference(UIOption*,bool (__cdecl**tableID)())</code>
    /// </summary>
    /// <param name="tableID">A pointer to a pointer-to-function that returns bool; it serves as the identifier for the preference table used by this menu option. The function updates the internal notice function reference when the supplied table differs from the current one.</param>
    public void SetUIPreference(delegate* unmanaged[Cdecl]<byte>* tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, delegate* unmanaged[Cdecl]<byte>*, void>)0x00484740)(ref this, tableID);

    /// <summary>Populates a menu's list box with literal text items sourced from a data structure, assigning each item an integer attribute taken from a parallel array.
    /// <code>Offset: 0x00484900
    /// unsigned int __thiscall UIOption_Menu::SetLiteralEntries(char*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="data">Pointer to a structure whose offset 8 holds the number of entries and which supplies the string literals for each menu item.</param>
    /// <param name="values">Pointer to an array of integers providing attribute values that are stored with each inserted item.</param>
    /// <returns>The number of items processed and added to the menu.</returns>
    public uint SetLiteralEntries(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, int, int*, uint>)0x00484900)(ref this, a2, a3);

    /// <summary>Responds to a reload‑options notification by forwarding the event to the base notice handler’s player object description change routine.
    /// <code>Offset: 0x00486DC0
    /// void __thiscall UIOption_Menu::RecvNotice_ReloadOptions(UIOption_Menu*)</code>
    /// </summary>
    public void RecvNotice_ReloadOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_Menu, void>)0x00486DC0)(ref this);
}

