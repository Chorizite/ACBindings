namespace ACBindings;

// UIOption_ActionKeyMap
public unsafe struct UIOption_ActionKeyMap : System.IDisposable
{
    // Base Classes
    public ACBindings.UIOption BaseClass_UIOption; // ACBindings.UIOption
    public ACBindings.UIElement_Text BaseClass_UIElement_Text; // ACBindings.UIElement_Text

    // Child Types
    // UIOption_ActionKeyMap_vtbl
    public unsafe struct UIOption_ActionKeyMap_vtbl
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
        public System.IntPtr UIOption_ActionKeyMap_dtor_2a8; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public System.IntPtr Refresh; // function pointer
        public System.IntPtr Changed; // function pointer
        public System.IntPtr RestoreSavedValue; // function pointer
        public System.IntPtr RestoreDefaultValue; // function pointer
        public System.IntPtr SaveCurrentValue; // function pointer
        public System.IntPtr SetChangeNotification; // function pointer
        public System.IntPtr HandleDialogAndNotices; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_Button* m_buttonClear;
    public ACBindings.SmartArray__UIElement_Button_ptr m_aKeyButtons;
    public uint m_idInputAction;
    public uint m_idInputMap;
    public ACBindings.List__QualifiedControl m_qclDefaults;
    public ACBindings.List__QualifiedControl m_qclSaved;
    public ACBindings.List__QualifiedControl m_qclCurrent;
    public ACBindings.QualifiedControl m_qcBindingBeingChanged;
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
    // void __thiscall UIOption_ActionKeyMap::RecvNotice_RefreshOptionsPanel(UIOption_ActionKeyMap*)
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x00487420)(ref this);
    // void __thiscall UIOption_ActionKeyMap::CloseMapWarnDialog(UIOption_ActionKeyMap*)
    public void CloseMapWarnDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x00487430)(ref this);
    // void __thiscall UIOption_ActionKeyMap::Refresh(UIOption_ActionKeyMap*)
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x00487640)(ref this);
    // bool __thiscall UIOption_ActionKeyMap::Changed(UIOption_ActionKeyMap*)
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, byte>)0x00487AA0)(ref this);
    // bool __thiscall UIOption_ActionKeyMap::EraseBinding(UIOption_ActionKeyMap*,int)
    public byte EraseBinding(int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, int, byte>)0x00487B40)(ref this, i_nBindingNumber);
    // void __thiscall UIOption_ActionKeyMap::PostInit(UIOption_ActionKeyMap*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x00487BF0)(ref this);
    // bool __thiscall UIOption_ActionKeyMap::SetBinding(UIOption_ActionKeyMap*,QualifiedControl,int)
    public byte SetBinding(ACBindings.QualifiedControl i_qc, int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, ACBindings.QualifiedControl, int, byte>)0x00487E50)(ref this, i_qc, i_nBindingNumber);
    // bool __thiscall UIOption_ActionKeyMap::ClearAllBindings(UIOption_ActionKeyMap*)
    public byte ClearAllBindings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, byte>)0x00488200)(ref this);
    // UIElement* __thiscall UIOption_ActionKeyMap::DynamicCast(UIOption_ActionKeyMap*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, uint, ACBindings.UIElement*>)0x00488430)(ref this, i_eType);
    // unsigned int __thiscall UIOption_ActionKeyMap::GetUIElementType(UIOption_ActionKeyMap*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, uint>)0x00488470)(ref this);
    // UIElement* __thiscall UIOption_ActionKeyMap::DynamicCast(unsigned int)
    public ACBindings.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, ACBindings.UIElement*>)0x00488490)(ref this);
    // void __thiscall UIOption_ActionKeyMap::~UIOption_ActionKeyMap(UIOption_ActionKeyMap*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x004884A0)(ref this);
    // UIElement* __cdecl UIOption_ActionKeyMap::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00488560)(layout, full_desc);
    // bool __thiscall UIOption_ActionKeyMap::SaveCurrentValue(UIOption_ActionKeyMap*)
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, byte>)0x00488590)(ref this);
    // bool __thiscall UIOption_ActionKeyMap::RestoreSavedValue(UIOption_ActionKeyMap*)
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, byte>)0x004885B0)(ref this);
    // bool __thiscall UIOption_ActionKeyMap::RestoreDefaultValue(UIOption_ActionKeyMap*)
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, byte>)0x00488820)(ref this);
    // void __thiscall UIOption_ActionKeyMap::RefreshMappings(UIOption_ActionKeyMap*)
    public void RefreshMappings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x00488850)(ref this);
    // void __thiscall UIOption_ActionKeyMap::RecvNotice_RefreshActionKeyMapping(UIOption_ActionKeyMap*,const QualifiedControl*)
    public void RecvNotice_RefreshActionKeyMapping(ACBindings.QualifiedControl* qcMapped) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, ACBindings.QualifiedControl*, void>)0x004888A0)(ref this, qcMapped);
    // void __thiscall UIOption_ActionKeyMap::RecvNotice_CloseDialog(UIOption_ActionKeyMap*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, uint, ACBindings.PropertyCollection*, void>)0x004888D0)(ref this, context, data);
    // void __thiscall UIOption_ActionKeyMap::SetMouseTurningDefaults(UIOption_ActionKeyMap*)
    public void SetMouseTurningDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, void>)0x00488A20)(ref this);
    // void __cdecl UIOption_ActionKeyMap::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00488BF0)();
    // void __thiscall UIOption_ActionKeyMap::ListenToGlobalMessage(UIOption_ActionKeyMap*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, uint, int, void>)0x00488D00)(ref this, i_messageID, i_data_int);
    // bool __thiscall UIOption_ActionKeyMap::OpenMapWarnDialog(UIOption_ActionKeyMap*,StringInfo*)
    public byte OpenMapWarnDialog(ACBindings.StringInfo* siMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, ACBindings.StringInfo*, byte>)0x00488D30)(ref this, siMsg);
    // bool __thiscall UIOption_ActionKeyMap::OpenOverwriteBindingDialog(_DWORD*,_DWORD*)
    public byte OpenOverwriteBindingDialog(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, int*, byte>)0x00488F20)(ref this, a2);
    // bool __thiscall UIOption_ActionKeyMap::OpenCantOverwriteBindingDialog(UIOption_ActionKeyMap*)
    public byte OpenCantOverwriteBindingDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, byte>)0x00489630)(ref this);
    // bool __thiscall UIOption_ActionKeyMap::KeyHitHandler(UIOption_ActionKeyMap*,const QualifiedControl*,unsigned int*)
    public byte KeyHitHandler(ACBindings.QualifiedControl* i_key, uint* o_idAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, ACBindings.QualifiedControl*, uint*, byte>)0x004898A0)(ref this, i_key, o_idAction);
    // bool __thiscall UIOption_ActionKeyMap::InitiateBinding(UIOption_ActionKeyMap*,int)
    public byte InitiateBinding(int i_nBindingNumber) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, int, byte>)0x00489D00)(ref this, i_nBindingNumber);
    // UIElementMessageListenResult __thiscall UIOption_ActionKeyMap::ListenToElementMessage(UIOption_ActionKeyMap*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_ActionKeyMap, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00489DB0)(ref this, i_rMsg);
}

