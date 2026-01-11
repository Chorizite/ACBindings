namespace ACBindings.Internal;

public unsafe struct VividTargetIndicator : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Statics
    public static ACBindings.Internal.VividTargetIndicator* s_pVTInstance = (ACBindings.Internal.VividTargetIndicator*)0x00842234;

    // Child Types
    public unsafe struct VividTargetIndicator_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.CACQualities*, void> RecvNotice_WeenieDescEvent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, byte, void> RecvNotice_AllegianceLogin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CAllegianceProfile*, uint, void> RecvNotice_AllegianceUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void> RecvNotice_CharGenVerificationResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, uint, void> RecvNotice_AbortConfirmationRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AbuseReportResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, void> RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.PowerBarMode, void> RecvNotice_BeginPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.PowerBarMode, void> RecvNotice_FinishPowerbar; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, float, void> RecvNotice_LoadChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_Ping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.QualifiedControl*, void> RecvNotice_RefreshActionKeyMapping; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_ReloadOptions; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_RemoveShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.PowerBarMode, float, void> RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, void> RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.ATTACK_HEIGHT, void> RecvNotice_AttackHeightChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, float, void> RecvNotice_DesiredAttackPowerChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.COMBAT_MODE, void> RecvNotice_SetCombatMode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, float, void> RecvNotice_UpdateObjectHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_ExamineObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_ExamineSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.AppraisalProfile*, void> RecvNotice_SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_FellowAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_FellowDismissed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_FellowQuit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.Fellow*, uint, void> RecvNotice_FellowUpdated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_FellowshipDisbanded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CFellowship*, void> RecvNotice_FellowshipUpdate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_BeginGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_EndGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, void> RecvNotice_GameOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, void> RecvNotice_JoinGameResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, void> RecvNotice_MoveResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, int, void> RecvNotice_OpponentOffersStalemate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, ACBindings.Internal.GameMoveData*, void> RecvNotice_OpponentTurn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, void> RecvNotice_StartGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, void> RecvNotice_TryToQuitGame; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_FailedHouseTransaction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.HouseData*, void> RecvNotice_UpdateHouseData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.HouseProfile*, void> RecvNotice_UpdateHouseProfile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.HousePaymentList*, void> RecvNotice_UpdateRentPayment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, void> RecvNotice_UpdateRentTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AddSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_OpenSalvagePanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_RemoveSalvageItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, byte, void> RecvNotice_BeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_EndPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.UIElement*, int, void> RecvNotice_ItemListBeginDrag; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> RecvNotice_ItemListDragOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SetGroundObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_ShowPendingInPlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_StopViewingObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, float, byte, void> RecvNotice_UpdateItemMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_BeginEnterWorld; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AddSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_CastCurrentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, void> RecvNotice_CastQuickslotSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_EnchantmentsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_FirstSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_FirstSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_LastSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_LastSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_NextSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_NextSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_PrevSpellSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_PrevSpellTab; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_RemoveSpellShortcut; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SetSelectedSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SpellAdded; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SpellRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, void> RecvNotice_UpdateSpellComponents; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_VitaeChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_PlayerPortalStormed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, float, void> RecvNotice_PortalStormLevel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, void> RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SetDisplayCharacterTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CContractTracker*, void> RecvNotice_SetDisplayContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CharacterTitleTable*, void> RecvNotice_UpdateCharacterTitleTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CContractTracker*, int, void> RecvNotice_UpdateContractTracker; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CContractTrackerTable*, void> RecvNotice_UpdateContractTrackerTable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.FriendDataList*, int, void> RecvNotice_UpdateFriendsList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AcceptTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, uint, void> RecvNotice_AddItemToTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_ClearTradeAcceptance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_CloseTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_DeclineTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_OpenTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, double, void> RecvNotice_RegisterTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_RemoveItemFromTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_ResetTrade; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_TradeAnItemForDummies; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_TradeFailure; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_SkillAdvancementClassChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_ClearChatBuffer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, byte, void> RecvNotice_EnableChatTargetSelection; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, void> RecvNotice_EndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.SpellComponentCategory, int, void> RecvNotice_FillComponentBuyList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_FontSettingsChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_FullMergingItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.BaseProperty*, uint, void> RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_Logoff; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_NewParentContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_OpenContainedContainer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void> RecvNotice_PlayerDescReceived; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.PlayerOption, void> RecvNotice_PlayerOptionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_SelectionChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_SetChatWindowTitle; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, int, void> RecvNotice_SetDisplayInventory; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, void> RecvNotice_SetFramerateDisplay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, byte, void> RecvNotice_SetPanelVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_SplitStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, uint, void> RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, void> RecvNotice_ToggleChatEntry; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, ACBindings.Internal.CACQualities*, void> RecvNotice_UpdateCharacterInformation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, void> RecvNotice_UpdateRadarVisibility; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_UpdateSquelchPanel; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, void> RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, void> RecvNotice_AddItemToSell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, byte, void> RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, int, void> RecvNotice_BookAddPageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, int, void> RecvNotice_BookDeletePageResponse; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.VividTargetIndicator*, uint, int, ACBindings.Internal.PageData*, void> RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;

        // Methods
    }

    // Members
    public uint m_idSelectedTarget;
    public ACBindings.Internal.RGBAColor m_clrSelectedObjectColor;
    public uint m_vtiCurrent;
    public ACBindings.Internal.RGBAColor m_clrOnScreen;
    public ACBindings.Internal.RGBAColor m_clrOffScreen;
    public ACBindings.Internal.SmartArray___RenderSurface_ptr m_rgSourceImages;
    public ACBindings.Internal.UIElement* m_pOffScreen;
    public ACBindings.Internal.UIElement* m_pOnScreen;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_rgOnScreenCorners;
    public byte m_bDisplayOn;
    public byte m_bEnabled;

    // Generated Constructor
    public VividTargetIndicator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F6980
    /// void __thiscall VividTargetIndicator::SetSelected(VividTargetIndicator*,unsigned int)</code>
    /// </summary>
    public void SetSelected(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, uint, void>)0x004F6980)(ref this, iid);

    /// <summary>
    /// <code>Offset: 0x004F6A70
    /// Graphic* __thiscall VividTargetIndicator::CopyImage(VividTargetIndicator*,const RenderSurface*,const RGBAColor*)</code>
    /// </summary>
    public ACBindings.Internal.Graphic* CopyImage(ACBindings.Internal.RenderSurface* i_pImg, ACBindings.Internal.RGBAColor* i_clr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.RenderSurface*, ACBindings.Internal.RGBAColor*, ACBindings.Internal.Graphic*>)0x004F6A70)(ref this, i_pImg, i_clr);

    /// <summary>
    /// <code>Offset: 0x004F6BE0
    /// void __thiscall VividTargetIndicator::RecvNotice_ServerSaysMoveItem(VividTargetIndicator*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004F6BE0)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004F6BF0
    /// void __thiscall VividTargetIndicator::UpdateDisplayState(VividTargetIndicator*)</code>
    /// </summary>
    public void UpdateDisplayState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, void>)0x004F6BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F6C40
    /// void __thiscall VividTargetIndicator::RecvNotice_PlayerDescReceived(VividTargetIndicator*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004F6C40)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004F6C90
    /// void __thiscall VividTargetIndicator::RecvNotice_PlayerOptionChanged(VividTargetIndicator*,PlayerOption)</code>
    /// </summary>
    public void RecvNotice_PlayerOptionChanged(ACBindings.Internal.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.PlayerOption, void>)0x004F6C90)(ref this, i_eOption);

    /// <summary>
    /// <code>Offset: 0x004F6CE0
    /// void __thiscall VividTargetIndicator::SetEnabled(VividTargetIndicator*,bool)</code>
    /// </summary>
    public void SetEnabled(byte i_bOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, byte, void>)0x004F6CE0)(ref this, i_bOn);

    /// <summary>
    /// <code>Offset: 0x004F6D40
    /// void __thiscall VividTargetIndicator::RecvNotice_SelectionChanged(VividTargetIndicator*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, void>)0x004F6D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F6D50
    /// void __thiscall VividTargetIndicator::RecvNotice_ChangeRadarLook(VividTargetIndicator*,CWeenieObject*)</code>
    /// </summary>
    public void RecvNotice_ChangeRadarLook(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.CWeenieObject*, void>)0x004F6D50)(ref this, i_obj);

    /// <summary>
    /// <code>Offset: 0x004F6D60
    /// void __thiscall VividTargetIndicator::OnQualityRemoved(VividTargetIndicator*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004F6D60)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004F6D80
    /// void __thiscall VividTargetIndicator::SetOffScreenImage(VividTargetIndicator*,unsigned int,const RGBAColor*)</code>
    /// </summary>
    public void SetOffScreenImage(uint i_vti, ACBindings.Internal.RGBAColor* i_clr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, uint, ACBindings.Internal.RGBAColor*, void>)0x004F6D80)(ref this, i_vti, i_clr);

    /// <summary>
    /// <code>Offset: 0x004F6DF0
    /// void __thiscall VividTargetIndicator::SetOnScreenColor(VividTargetIndicator*,const RGBAColor*)</code>
    /// </summary>
    public void SetOnScreenColor(ACBindings.Internal.RGBAColor* i_clr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.RGBAColor*, void>)0x004F6DF0)(ref this, i_clr);

    /// <summary>
    /// <code>Offset: 0x004F6E70
    /// void __thiscall VividTargetIndicator::~VividTargetIndicator(VividTargetIndicator*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, void>)0x004F6E70)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F6EF0
    /// void __thiscall VividTargetIndicator::OnDraw(VividTargetIndicator*,unsigned int,ObjectSelectStatus,const tagRECT*,const float)</code>
    /// </summary>
    public void OnDraw(uint object_id, ACBindings.Internal.ObjectSelectStatus oss, ACBindings.Internal.tagRECT* bbox, float heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void>)0x004F6EF0)(ref this, object_id, oss, bbox, heading);

    /// <summary>
    /// <code>Offset: 0x004F7720
    /// void __thiscall VividTargetIndicator::VividTargetIndicator(VividTargetIndicator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, void>)0x004F7720)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F7870
    /// void __cdecl VividTargetIndicator::Draw(unsigned int,ObjectSelectStatus,const tagRECT*,const float)</code>
    /// </summary>
    public static void Draw(uint object_id, ACBindings.Internal.ObjectSelectStatus oss, ACBindings.Internal.tagRECT* bbox, float heading) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.ObjectSelectStatus, ACBindings.Internal.tagRECT*, float, void>)0x004F7870)(object_id, oss, bbox, heading);

    /// <summary>
    /// <code>Offset: 0x004F78A0
    /// bool __thiscall VividTargetIndicator::Initialized(VividTargetIndicator*,gmSmartBoxUI*)</code>
    /// </summary>
    public byte Initialized(ACBindings.Internal.gmSmartBoxUI* i_pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VividTargetIndicator, ACBindings.Internal.gmSmartBoxUI*, byte>)0x004F78A0)(ref this, i_pParent);
}

