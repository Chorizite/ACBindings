namespace ACBindings.Internal;

public unsafe struct UIOption_ActionKeyMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIOption BaseClass_UIOption; // ACBindings.Internal.UIOption
    public ACBindings.Internal.UIElement_Text BaseClass_UIElement_Text; // ACBindings.Internal.UIElement_Text

    // Child Types
    public unsafe struct UIOption_ActionKeyMap_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> UIOption_ActionKeyMap_dtor_2a8; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, void> Refresh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> Changed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> RestoreSavedValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> RestoreDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte> SaveCurrentValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption_ActionKeyMap*, byte, void> HandleDialogAndNotices; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00487420
    /// void __thiscall UIOption_ActionKeyMap::RecvNotice_RefreshOptionsPanel(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487420)(ref this);

    /// <summary>
    /// <code>Offset: 0x00487430
    /// void __thiscall UIOption_ActionKeyMap::CloseMapWarnDialog(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void CloseMapWarnDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487430)(ref this);

    /// <summary>
    /// <code>Offset: 0x00487640
    /// void __thiscall UIOption_ActionKeyMap::Refresh(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487640)(ref this);

    /// <summary>
    /// <code>Offset: 0x00487AA0
    /// bool __thiscall UIOption_ActionKeyMap::Changed(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00487AA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00487B40
    /// bool __thiscall UIOption_ActionKeyMap::EraseBinding(UIOption_ActionKeyMap*,int)</code>
    /// </summary>
    public byte EraseBinding(int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, int, byte>)0x00487B40)(ref this, i_nBindingNumber);

    /// <summary>
    /// <code>Offset: 0x00487BF0
    /// void __thiscall UIOption_ActionKeyMap::PostInit(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00487BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00487E50
    /// bool __thiscall UIOption_ActionKeyMap::SetBinding(UIOption_ActionKeyMap*,QualifiedControl,int)</code>
    /// </summary>
    public byte SetBinding(ACBindings.Internal.QualifiedControl i_qc, int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.QualifiedControl, int, byte>)0x00487E50)(ref this, i_qc, i_nBindingNumber);

    /// <summary>
    /// <code>Offset: 0x00488200
    /// bool __thiscall UIOption_ActionKeyMap::ClearAllBindings(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public byte ClearAllBindings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00488200)(ref this);

    /// <summary>
    /// <code>Offset: 0x00488430
    /// UIElement* __thiscall UIOption_ActionKeyMap::DynamicCast(UIOption_ActionKeyMap*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint, ACBindings.Internal.UIElement*>)0x00488430)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00488470
    /// unsigned int __thiscall UIOption_ActionKeyMap::GetUIElementType(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint>)0x00488470)(ref this);

    /// <summary>
    /// <code>Offset: 0x00488490
    /// UIElement* __thiscall UIOption_ActionKeyMap::DynamicCast(unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.UIElement*>)0x00488490)(ref this);

    /// <summary>
    /// <code>Offset: 0x004884A0
    /// void __thiscall UIOption_ActionKeyMap::~UIOption_ActionKeyMap(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x004884A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00488560
    /// UIElement* __cdecl UIOption_ActionKeyMap::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00488560)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00488590
    /// bool __thiscall UIOption_ActionKeyMap::SaveCurrentValue(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00488590)(ref this);

    /// <summary>
    /// <code>Offset: 0x004885B0
    /// bool __thiscall UIOption_ActionKeyMap::RestoreSavedValue(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x004885B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00488820
    /// bool __thiscall UIOption_ActionKeyMap::RestoreDefaultValue(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00488820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00488850
    /// void __thiscall UIOption_ActionKeyMap::RefreshMappings(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void RefreshMappings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00488850)(ref this);

    /// <summary>
    /// <code>Offset: 0x004888A0
    /// void __thiscall UIOption_ActionKeyMap::RecvNotice_RefreshActionKeyMapping(UIOption_ActionKeyMap*,const QualifiedControl*)</code>
    /// </summary>
    public void RecvNotice_RefreshActionKeyMapping(ACBindings.Internal.QualifiedControl* qcMapped) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.QualifiedControl*, void>)0x004888A0)(ref this, qcMapped);

    /// <summary>
    /// <code>Offset: 0x004888D0
    /// void __thiscall UIOption_ActionKeyMap::RecvNotice_CloseDialog(UIOption_ActionKeyMap*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint, ACBindings.Internal.PropertyCollection*, void>)0x004888D0)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x00488A20
    /// void __thiscall UIOption_ActionKeyMap::SetMouseTurningDefaults(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public void SetMouseTurningDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, void>)0x00488A20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00488BF0
    /// void __cdecl UIOption_ActionKeyMap::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00488BF0)();

    /// <summary>
    /// <code>Offset: 0x00488D00
    /// void __thiscall UIOption_ActionKeyMap::ListenToGlobalMessage(UIOption_ActionKeyMap*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, uint, int, void>)0x00488D00)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x00488D30
    /// bool __thiscall UIOption_ActionKeyMap::OpenMapWarnDialog(UIOption_ActionKeyMap*,StringInfo*)</code>
    /// </summary>
    public byte OpenMapWarnDialog(ACBindings.Internal.StringInfo* siMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.StringInfo*, byte>)0x00488D30)(ref this, siMsg);

    /// <summary>
    /// <code>Offset: 0x00488F20
    /// bool __thiscall UIOption_ActionKeyMap::OpenOverwriteBindingDialog(_DWORD*,_DWORD*)</code>
    /// </summary>
    public byte OpenOverwriteBindingDialog(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, int*, byte>)0x00488F20)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00489630
    /// bool __thiscall UIOption_ActionKeyMap::OpenCantOverwriteBindingDialog(UIOption_ActionKeyMap*)</code>
    /// </summary>
    public byte OpenCantOverwriteBindingDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, byte>)0x00489630)(ref this);

    /// <summary>
    /// <code>Offset: 0x004898A0
    /// bool __thiscall UIOption_ActionKeyMap::KeyHitHandler(UIOption_ActionKeyMap*,const QualifiedControl*,unsigned int*)</code>
    /// </summary>
    public byte KeyHitHandler(ACBindings.Internal.QualifiedControl* i_key, uint* o_idAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.QualifiedControl*, uint*, byte>)0x004898A0)(ref this, i_key, o_idAction);

    /// <summary>
    /// <code>Offset: 0x00489D00
    /// bool __thiscall UIOption_ActionKeyMap::InitiateBinding(UIOption_ActionKeyMap*,int)</code>
    /// </summary>
    public byte InitiateBinding(int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, int, byte>)0x00489D00)(ref this, i_nBindingNumber);

    /// <summary>
    /// <code>Offset: 0x00489DB0
    /// UIElementMessageListenResult __thiscall UIOption_ActionKeyMap::ListenToElementMessage(UIOption_ActionKeyMap*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption_ActionKeyMap, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00489DB0)(ref this, i_rMsg);
}

