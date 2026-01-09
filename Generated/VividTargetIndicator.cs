namespace ACBindings;

// VividTargetIndicator
public unsafe struct VividTargetIndicator : System.IDisposable
{
    // Base Classes
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Statics
    public static ACBindings.VividTargetIndicator* s_pVTInstance = (ACBindings.VividTargetIndicator*)0x00842234;

    // Child Types
    // VividTargetIndicator_vtbl
    public unsafe struct VividTargetIndicator_vtbl
    {
        // Members
        public System.IntPtr IsEngine; // function pointer
        public System.IntPtr RecvNotice_CharacterSet; // function pointer
        public System.IntPtr RecvNotice_PlayerObjDescChanged; // function pointer
        public System.IntPtr RecvNotice_RuntimeDDDStatus; // function pointer
        public System.IntPtr RecvNotice_ItemAttributesChanged; // function pointer
        public System.IntPtr RecvNotice_ServerSaysAttemptFailed; // function pointer
        public System.IntPtr RecvNotice_ServerSaysMoveItem; // function pointer
        public System.IntPtr RecvNotice_SetSelectedItem; // function pointer
        public System.IntPtr RecvNotice_CharacterError; // function pointer
        public System.IntPtr RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public System.IntPtr RecvNotice_BeingDeleted; // function pointer
        public System.IntPtr RecvNotice_CreateObject; // function pointer
        public System.IntPtr RecvNotice_CloseDialog; // function pointer
        public System.IntPtr RecvNotice_DisplayFinalStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public System.IntPtr RecvNotice_OpenDialog; // function pointer
        public System.IntPtr RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public System.IntPtr RecvNotice_TextTag_IIDClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public System.IntPtr RecvNotice_UpdateGameView; // function pointer
        public System.IntPtr RecvNotice_WeenieDescEvent; // function pointer
        public System.IntPtr RecvNotice_AllegianceLogin; // function pointer
        public System.IntPtr RecvNotice_AllegianceUpdate; // function pointer
        public System.IntPtr RecvNotice_AllegianceUpdateAborted; // function pointer
        public System.IntPtr RecvNotice_SwearAllegianceRequest;
        public System.IntPtr RecvNotice_CharGenVerificationResponse; // function pointer
        public System.IntPtr RecvNotice_AbortConfirmationRequest; // function pointer
        public System.IntPtr RecvNotice_AbuseReportResponse; // function pointer
        public System.IntPtr RecvNotice_AddShortcut; // function pointer
        public System.IntPtr RecvNotice_AlterAttribute_ConfirmationRequest;
        public System.IntPtr RecvNotice_AlterSkill_ConfirmationRequest;
        public System.IntPtr RecvNotice_Augmentation_ConfirmationRequest;
        public System.IntPtr RecvNotice_BeginPowerbar; // function pointer
        public System.IntPtr RecvNotice_ChangeRadarLook; // function pointer
        public System.IntPtr RecvNotice_CraftInteraction_ConfirmationRequest;
        public System.IntPtr RecvNotice_FinishPowerbar; // function pointer
        public System.IntPtr RecvNotice_LoadChanged; // function pointer
        public System.IntPtr RecvNotice_Ping; // function pointer
        public System.IntPtr RecvNotice_RefreshActionKeyMapping; // function pointer
        public System.IntPtr RecvNotice_ReloadOptions; // function pointer
        public System.IntPtr RecvNotice_RemoveShortcut; // function pointer
        public System.IntPtr RecvNotice_SetPowerbarLevel; // function pointer
        public System.IntPtr RecvNotice_StartBarberNotice;
        public System.IntPtr RecvNotice_UseShortcut; // function pointer
        public System.IntPtr RecvNotice_YesNo_ConfirmationRequest;
        public System.IntPtr RecvNotice_AttackHeightChanged; // function pointer
        public System.IntPtr RecvNotice_DesiredAttackPowerChanged; // function pointer
        public System.IntPtr RecvNotice_SetCombatMode; // function pointer
        public System.IntPtr RecvNotice_UpdateObjectHealth; // function pointer
        public System.IntPtr RecvNotice_ExamineObject; // function pointer
        public System.IntPtr RecvNotice_ExamineSpell; // function pointer
        public System.IntPtr RecvNotice_SetAppraiseInfo; // function pointer
        public System.IntPtr RecvNotice_FellowAdded; // function pointer
        public System.IntPtr RecvNotice_FellowDismissed; // function pointer
        public System.IntPtr RecvNotice_FellowQuit; // function pointer
        public System.IntPtr RecvNotice_FellowUpdated; // function pointer
        public System.IntPtr RecvNotice_FellowshipDisbanded; // function pointer
        public System.IntPtr RecvNotice_FellowshipLeaderChanged; // function pointer
        public System.IntPtr RecvNotice_FellowshipRequest;
        public System.IntPtr RecvNotice_FellowshipUpdate; // function pointer
        public System.IntPtr RecvNotice_BeginGame; // function pointer
        public System.IntPtr RecvNotice_EndGame; // function pointer
        public System.IntPtr RecvNotice_GameOver; // function pointer
        public System.IntPtr RecvNotice_JoinGameResponse; // function pointer
        public System.IntPtr RecvNotice_MoveResponse; // function pointer
        public System.IntPtr RecvNotice_OpponentOffersStalemate; // function pointer
        public System.IntPtr RecvNotice_OpponentTurn; // function pointer
        public System.IntPtr RecvNotice_StartGame; // function pointer
        public System.IntPtr RecvNotice_TryToQuitGame; // function pointer
        public System.IntPtr RecvNotice_FailedHouseTransaction; // function pointer
        public System.IntPtr RecvNotice_UpdateHouseData; // function pointer
        public System.IntPtr RecvNotice_UpdateHouseProfile; // function pointer
        public System.IntPtr RecvNotice_UpdateRentPayment; // function pointer
        public System.IntPtr RecvNotice_UpdateRentTime; // function pointer
        public System.IntPtr RecvNotice_AddSalvageItem; // function pointer
        public System.IntPtr RecvNotice_OpenSalvagePanel; // function pointer
        public System.IntPtr RecvNotice_RemoveSalvageItem; // function pointer
        public System.IntPtr RecvNotice_BeginDrag; // function pointer
        public System.IntPtr RecvNotice_EndPendingInPlayer; // function pointer
        public System.IntPtr RecvNotice_ItemListBeginDrag; // function pointer
        public System.IntPtr RecvNotice_ItemListDragOver; // function pointer
        public System.IntPtr RecvNotice_SetGroundObject; // function pointer
        public System.IntPtr RecvNotice_ShowPendingInPlayer; // function pointer
        public System.IntPtr RecvNotice_StopViewingObject; // function pointer
        public System.IntPtr RecvNotice_UpdateItemMana; // function pointer
        public System.IntPtr RecvNotice_BeginEnterWorld; // function pointer
        public System.IntPtr RecvNotice_AddSpellShortcut; // function pointer
        public System.IntPtr RecvNotice_CastCurrentSpell; // function pointer
        public System.IntPtr RecvNotice_CastQuickslotSpell; // function pointer
        public System.IntPtr RecvNotice_EnchantmentsChanged; // function pointer
        public System.IntPtr RecvNotice_FirstSpellSelection; // function pointer
        public System.IntPtr RecvNotice_FirstSpellTab; // function pointer
        public System.IntPtr RecvNotice_LastSpellSelection; // function pointer
        public System.IntPtr RecvNotice_LastSpellTab; // function pointer
        public System.IntPtr RecvNotice_NextSpellSelection; // function pointer
        public System.IntPtr RecvNotice_NextSpellTab; // function pointer
        public System.IntPtr RecvNotice_PrevSpellSelection; // function pointer
        public System.IntPtr RecvNotice_PrevSpellTab; // function pointer
        public System.IntPtr RecvNotice_RemoveSpellShortcut; // function pointer
        public System.IntPtr RecvNotice_SetSelectedSpell; // function pointer
        public System.IntPtr RecvNotice_SpellAdded; // function pointer
        public System.IntPtr RecvNotice_SpellRemoved; // function pointer
        public System.IntPtr RecvNotice_UpdateSpellComponents; // function pointer
        public System.IntPtr RecvNotice_VitaeChanged; // function pointer
        public System.IntPtr RecvNotice_PlayerPortalStormed; // function pointer
        public System.IntPtr RecvNotice_PortalStormLevel; // function pointer
        public System.IntPtr RecvNotice_AddCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_AddFriend;
        public System.IntPtr RecvNotice_ChatCommand_DisplayFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveAllFriends; // function pointer
        public System.IntPtr RecvNotice_ChatCommand_RemoveFriend;
        public System.IntPtr RecvNotice_SetDisplayCharacterTitle; // function pointer
        public System.IntPtr RecvNotice_SetDisplayContractTracker; // function pointer
        public System.IntPtr RecvNotice_UpdateCharacterTitleTable; // function pointer
        public System.IntPtr RecvNotice_UpdateContractTracker; // function pointer
        public System.IntPtr RecvNotice_UpdateContractTrackerTable; // function pointer
        public System.IntPtr RecvNotice_UpdateFriendsList; // function pointer
        public System.IntPtr RecvNotice_AcceptTrade; // function pointer
        public System.IntPtr RecvNotice_AddItemToTrade; // function pointer
        public System.IntPtr RecvNotice_ClearTradeAcceptance; // function pointer
        public System.IntPtr RecvNotice_CloseTrade; // function pointer
        public System.IntPtr RecvNotice_DeclineTrade; // function pointer
        public System.IntPtr RecvNotice_OpenTrade; // function pointer
        public System.IntPtr RecvNotice_RegisterTrade; // function pointer
        public System.IntPtr RecvNotice_RemoveItemFromTrade; // function pointer
        public System.IntPtr RecvNotice_ResetTrade; // function pointer
        public System.IntPtr RecvNotice_TradeAnItemForDummies; // function pointer
        public System.IntPtr RecvNotice_TradeFailure; // function pointer
        public System.IntPtr RecvNotice_SkillAdvancementClassChanged; // function pointer
        public System.IntPtr RecvNotice_ClearChatBuffer; // function pointer
        public System.IntPtr RecvNotice_EnableChatTargetSelection; // function pointer
        public System.IntPtr RecvNotice_EndCharacterSession; // function pointer
        public System.IntPtr RecvNotice_FillComponentBuyList; // function pointer
        public System.IntPtr RecvNotice_FontSettingsChanged; // function pointer
        public System.IntPtr RecvNotice_FullMergingItem; // function pointer
        public System.IntPtr RecvNotice_GameplayOptionChanged; // function pointer
        public System.IntPtr RecvNotice_LoadUI;
        public System.IntPtr RecvNotice_Logoff; // function pointer
        public System.IntPtr RecvNotice_NewParentContainer; // function pointer
        public System.IntPtr RecvNotice_OpenContainedContainer; // function pointer
        public System.IntPtr RecvNotice_PlayerDescReceived; // function pointer
        public System.IntPtr RecvNotice_PlayerOptionChanged; // function pointer
        public System.IntPtr RecvNotice_RefreshOptionsPanel; // function pointer
        public System.IntPtr RecvNotice_SaveUI;
        public System.IntPtr RecvNotice_SelectionChanged; // function pointer
        public System.IntPtr RecvNotice_SetChatWindowTitle; // function pointer
        public System.IntPtr RecvNotice_SetDisplayInventory; // function pointer
        public System.IntPtr RecvNotice_SetFramerateDisplay; // function pointer
        public System.IntPtr RecvNotice_SetPanelVisibility; // function pointer
        public System.IntPtr RecvNotice_SplitStack; // function pointer
        public System.IntPtr RecvNotice_StackSliderChanged; // function pointer
        public System.IntPtr RecvNotice_StartTell;
        public System.IntPtr RecvNotice_ToggleChatEntry; // function pointer
        public System.IntPtr RecvNotice_UpdateCharacterInformation; // function pointer
        public System.IntPtr RecvNotice_UpdateRadarVisibility; // function pointer
        public System.IntPtr RecvNotice_UpdateSquelchPanel; // function pointer
        public System.IntPtr RecvNotice_UpdateToolbarSelectionDisplay; // function pointer
        public System.IntPtr RecvNotice_UserPreferenceChanged;
        public System.IntPtr RecvNotice_UserPreferenceChanged_Menu;
        public System.IntPtr RecvNotice_AddItemToSell; // function pointer
        public System.IntPtr RecvNotice_CloseVendor; // function pointer
        public System.IntPtr RecvNotice_OpenVendor;
        public System.IntPtr RecvNotice_BookAddPageResponse; // function pointer
        public System.IntPtr RecvNotice_BookDeletePageResponse; // function pointer
        public System.IntPtr RecvNotice_BookPageDataResponse; // function pointer
        public System.IntPtr RecvNotice_OpenBook;

        // Methods
    }

    // Members
    public uint m_idSelectedTarget;
    public ACBindings.RGBAColor m_clrSelectedObjectColor;
    public uint m_vtiCurrent;
    public ACBindings.RGBAColor m_clrOnScreen;
    public ACBindings.RGBAColor m_clrOffScreen;
    public ACBindings.SmartArray__RenderSurface_ptr m_rgSourceImages;
    public ACBindings.UIElement* m_pOffScreen;
    public ACBindings.UIElement* m_pOnScreen;
    public ACBindings.SmartArray__UIElement_ptr m_rgOnScreenCorners;
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
    // void __thiscall VividTargetIndicator::SetSelected(VividTargetIndicator*,unsigned int)
    public void SetSelected(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, uint, void>)0x004F6980)(ref this, iid);
    // Graphic* __thiscall VividTargetIndicator::CopyImage(VividTargetIndicator*,const RenderSurface*,const RGBAColor*)
    public ACBindings.Graphic* CopyImage(ACBindings.RenderSurface* i_pImg, ACBindings.RGBAColor* i_clr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.RenderSurface*, ACBindings.RGBAColor*, ACBindings.Graphic*>)0x004F6A70)(ref this, i_pImg, i_clr);
    // void __thiscall VividTargetIndicator::RecvNotice_ServerSaysMoveItem(VividTargetIndicator*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004F6BE0)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall VividTargetIndicator::UpdateDisplayState(VividTargetIndicator*)
    public void UpdateDisplayState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, void>)0x004F6BF0)(ref this);
    // void __thiscall VividTargetIndicator::RecvNotice_PlayerDescReceived(VividTargetIndicator*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004F6C40)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall VividTargetIndicator::RecvNotice_PlayerOptionChanged(VividTargetIndicator*,PlayerOption)
    public void RecvNotice_PlayerOptionChanged(ACBindings.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.PlayerOption, void>)0x004F6C90)(ref this, i_eOption);
    // void __thiscall VividTargetIndicator::SetEnabled(VividTargetIndicator*,bool)
    public void SetEnabled(byte i_bOn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, byte, void>)0x004F6CE0)(ref this, i_bOn);
    // void __thiscall VividTargetIndicator::RecvNotice_SelectionChanged(VividTargetIndicator*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, void>)0x004F6D40)(ref this);
    // void __thiscall VividTargetIndicator::RecvNotice_ChangeRadarLook(VividTargetIndicator*,CWeenieObject*)
    public void RecvNotice_ChangeRadarLook(ACBindings.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.CWeenieObject*, void>)0x004F6D50)(ref this, i_obj);
    // void __thiscall VividTargetIndicator::OnQualityRemoved(VividTargetIndicator*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004F6D60)(ref this, cwobj, stype, senum);
    // void __thiscall VividTargetIndicator::SetOffScreenImage(VividTargetIndicator*,unsigned int,const RGBAColor*)
    public void SetOffScreenImage(uint i_vti, ACBindings.RGBAColor* i_clr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, uint, ACBindings.RGBAColor*, void>)0x004F6D80)(ref this, i_vti, i_clr);
    // void __thiscall VividTargetIndicator::SetOnScreenColor(VividTargetIndicator*,const RGBAColor*)
    public void SetOnScreenColor(ACBindings.RGBAColor* i_clr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.RGBAColor*, void>)0x004F6DF0)(ref this, i_clr);
    // void __thiscall VividTargetIndicator::~VividTargetIndicator(VividTargetIndicator*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, void>)0x004F6E70)(ref this);
    // void __thiscall VividTargetIndicator::OnDraw(VividTargetIndicator*,unsigned int,ObjectSelectStatus,const tagRECT*,const float)
    public void OnDraw(uint object_id, ACBindings.ObjectSelectStatus oss, ACBindings.tagRECT* bbox, float heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, uint, ACBindings.ObjectSelectStatus, ACBindings.tagRECT*, float, void>)0x004F6EF0)(ref this, object_id, oss, bbox, heading);
    // void __thiscall VividTargetIndicator::VividTargetIndicator(VividTargetIndicator*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, void>)0x004F7720)(ref this);
    // void __cdecl VividTargetIndicator::Draw(unsigned int,ObjectSelectStatus,const tagRECT*,const float)
    public static void Draw(uint object_id, ACBindings.ObjectSelectStatus oss, ACBindings.tagRECT* bbox, float heading) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.ObjectSelectStatus, ACBindings.tagRECT*, float, void>)0x004F7870)(object_id, oss, bbox, heading);
    // bool __thiscall VividTargetIndicator::Initialized(VividTargetIndicator*,gmSmartBoxUI*)
    public byte Initialized(ACBindings.gmSmartBoxUI* i_pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VividTargetIndicator, ACBindings.gmSmartBoxUI*, byte>)0x004F78A0)(ref this, i_pParent);
}

