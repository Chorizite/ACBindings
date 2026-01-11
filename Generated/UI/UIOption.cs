namespace ACBindings.Internal;

public unsafe struct UIOption : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIOption_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> UIOption_dtor_2a8; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, void> Refresh; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte> Changed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte> RestoreSavedValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte> RestoreDefaultValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte> SaveCurrentValue; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, ACBindings.Internal.IOptionChangeHandler*, void> SetChangeNotification; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIOption*, byte, void> HandleDialogAndNotices; // function pointer

        // Methods
    }

    // Members
    public byte m_confirmChange;
    public byte m_bDelayConfirmation;
    public uint m_dialogContext;
    public byte m_shouldReloadOptions;
    public byte m_shouldRefreshOptionsPanel;
    public delegate* unmanaged[Cdecl]<byte> m_noticeFuncPtr; // function pointer
    public ACBindings.Internal.IOptionChangeHandler* m_pOCH;
    public uint m_nUserData;

    // Generated Constructor
    public UIOption() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004EFE70
    /// void __thiscall UIOption::UIOption(UIOption*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, void>)0x004EFE70)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EFED0
    /// void __thiscall UIOption::~UIOption(UIOption*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, void>)0x004EFED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EFF00
    /// void __thiscall UIOption::SetLabel(UIOption*,unsigned int,unsigned int)</code>
    /// </summary>
    public void SetLabel(uint stringID, uint tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, uint, void>)0x004EFF00)(ref this, stringID, tableID);

    /// <summary>
    /// <code>Offset: 0x004EFF50
    /// void __thiscall UIOption::SetTooltip(UIOption*,unsigned int,unsigned int)</code>
    /// </summary>
    public void SetTooltip(uint stringID, uint tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, uint, void>)0x004EFF50)(ref this, stringID, tableID);

    /// <summary>
    /// <code>Offset: 0x004EFFA0
    /// void __thiscall UIOption::SetConfirmChange(UIOption*,bool)</code>
    /// </summary>
    public void SetConfirmChange(byte bDelayConfirmation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, byte, void>)0x004EFFA0)(ref this, bDelayConfirmation);

    /// <summary>
    /// <code>Offset: 0x004EFFB0
    /// void __thiscall UIOption::SetChangeNotification(UIOption*,IOptionChangeHandler*)</code>
    /// </summary>
    public void SetChangeNotification(ACBindings.Internal.IOptionChangeHandler* i_pOCH) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, ACBindings.Internal.IOptionChangeHandler*, void>)0x004EFFB0)(ref this, i_pOCH);

    /// <summary>
    /// <code>Offset: 0x004EFFC0
    /// void __thiscall UIOption::SetUserData(UIOption*,unsigned int)</code>
    /// </summary>
    public void SetUserData(uint i_nUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, void>)0x004EFFC0)(ref this, i_nUserData);

    /// <summary>
    /// <code>Offset: 0x004F0070
    /// void __thiscall UIOption::RecvNotice_CloseDialog(UIOption*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, ACBindings.Internal.PropertyCollection*, void>)0x004F0070)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x004F0160
    /// bool __thiscall UIOption::InqGameplayOptionProperty(UIOption*,unsigned int,BaseProperty*)</code>
    /// </summary>
    public byte InqGameplayOptionProperty(uint propName, ACBindings.Internal.BaseProperty* baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, ACBindings.Internal.BaseProperty*, byte>)0x004F0160)(ref this, propName, baseProp);

    /// <summary>
    /// <code>Offset: 0x004F03E0
    /// bool __thiscall UIOption::InqGameplayOptionNameAndTooltip(UIOption*,unsigned int,StringInfo*,StringInfo*)</code>
    /// </summary>
    public byte InqGameplayOptionNameAndTooltip(uint propName, ACBindings.Internal.StringInfo* siName, ACBindings.Internal.StringInfo* siTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, byte>)0x004F03E0)(ref this, propName, siName, siTooltip);

    /// <summary>
    /// <code>Offset: 0x004F0560
    /// bool __thiscall UIOption::InqDefaultGameplayOptionProperty(UIOption*,unsigned int,BaseProperty*)</code>
    /// </summary>
    public byte InqDefaultGameplayOptionProperty(uint propName, ACBindings.Internal.BaseProperty* baseProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, uint, ACBindings.Internal.BaseProperty*, byte>)0x004F0560)(ref this, propName, baseProp);

    /// <summary>
    /// <code>Offset: 0x004F05D0
    /// void __thiscall UIOption::HandleDialog(UIOption*)</code>
    /// </summary>
    public void HandleDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, void>)0x004F05D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F0820
    /// void __thiscall UIOption::HandleDialogAndNotices(UIOption*,bool)</code>
    /// </summary>
    public void HandleDialogAndNotices(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIOption, byte, void>)0x004F0820)(ref this, userRequested);
}

