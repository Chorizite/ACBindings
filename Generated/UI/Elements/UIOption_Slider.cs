namespace ACBindings;

// UIOption_Slider
public unsafe struct UIOption_Slider : System.IDisposable
{
    // Base Classes
    public ACBindings.UIOption BaseClass_UIOption; // ACBindings.UIOption
    public ACBindings.UIElement_Scrollbar BaseClass_UIElement_Scrollbar; // ACBindings.UIElement_Scrollbar

    // Child Types
    // UIOption_Slider_vtbl
    public unsafe struct UIOption_Slider_vtbl
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
        public System.IntPtr UIOption_Slider_dtor_2a8; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public fixed byte gap2B0[8];
        public System.IntPtr Refresh; // function pointer
        public System.IntPtr Changed; // function pointer
        public System.IntPtr RestoreSavedValue; // function pointer
        public System.IntPtr RestoreDefaultValue; // function pointer
        public System.IntPtr SaveCurrentValue; // function pointer
        public System.IntPtr SetChangeNotification; // function pointer
        public System.IntPtr HandleDialogAndNotices; // function pointer
        public System.IntPtr Apply; // function pointer
        public System.IntPtr SetDefaultValue; // function pointer

        // Methods
    }

    // Members
    public float m_default;
    public float m_saved;
    public float m_current;
    public ACBindings.PStringBase__sbyte m_prefName;
    public uint m_propName;
    public float m_lowerValue;
    public float m_upperValue;
    public uint m_numStops;
    public ushort m_precision;
    public byte m_setAsInt;

    // Generated Constructor
    public UIOption_Slider(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIOption_Slider::Refresh(UIOption_Slider*)
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, void>)0x00484E10)(ref this);
    // bool __thiscall UIOption_Slider::Changed(UIOption_Slider*)
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, byte>)0x00484E80)(ref this);
    // bool __thiscall UIOption_Slider::RestoreSavedValue(UIOption_Slider*)
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, byte>)0x00484EA0)(ref this);
    // bool __thiscall UIOption_Slider::RestoreDefaultValue(UIOption_Slider*)
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, byte>)0x00484ED0)(ref this);
    // void __thiscall UIOption_Slider::SetDefaultValue(UIOption_Slider*,float)
    public void SetDefaultValue(float defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, float, void>)0x00484F00)(ref this, defaulta);
    // UIElementMessageListenResult __thiscall UIOption_Slider::ListenToElementMessage(UIOption_Slider*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00484F10)(ref this, i_rMsg);
    // float __thiscall UIOption_Slider::GetCurrentValue(UIOption_Slider*)
    public float GetCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, float>)0x00484F80)(ref this);
    // void __thiscall UIOption_Slider::SetCurrentValue(UIOption_Slider*,float)
    public void SetCurrentValue(float i_fNewValue) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, float, void>)0x00484F90)(ref this, i_fNewValue);
    // void __thiscall UIOption_Slider::~UIOption_Slider(UIOption_Slider*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, void>)0x00484FC0)(ref this);
    // UIElement* __thiscall UIOption_Slider::DynamicCast(UIOption_Slider*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, uint, ACBindings.UIElement*>)0x00485020)(ref this, i_eType);
    // unsigned int __thiscall UIOption_Slider::GetUIElementType(UIOption_Slider*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, uint>)0x00485060)(ref this);
    // UIElement* __thiscall UIOption_Slider::DynamicCast(unsigned int)
    public ACBindings.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, ACBindings.UIElement*>)0x00485080)(ref this);
    // char __thiscall UIOption_Slider::SetUIPreference(UIOption*,char**)
    public sbyte SetUIPreference(sbyte** tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, sbyte**, sbyte>)0x00485090)(ref this, tableID);
    // void __thiscall UIOption_Slider::SetLabel(UIOption_Slider*,const StringInfo*)
    public void SetLabel(ACBindings.StringInfo* i_siLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, ACBindings.StringInfo*, void>)0x004851C0)(ref this, i_siLabel);
    // void __thiscall UIOption_Slider::UIOption_Slider(UIOption_Slider*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00485310)(ref this, layout, full_desc);
    // UIElement* __cdecl UIOption_Slider::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004853C0)(layout, full_desc);
    // void __thiscall UIOption_Slider::SetGameplayOptionProperty(UIOption_Slider*,unsigned int)
    public void SetGameplayOptionProperty(uint propName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, uint, void>)0x004853F0)(ref this, propName);
    // void __cdecl UIOption_Slider::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004855E0)();
    // bool __thiscall UIOption_Slider::Apply(UIOption_Slider*,bool)
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, byte, byte>)0x00485600)(ref this, userRequested);
    // float __thiscall UIOption_Slider::GetValue(UIOption_Slider*)
    public float GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, float>)0x004857E0)(ref this);
    // bool __thiscall UIOption_Slider::SaveCurrentValue(UIOption_Slider*)
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, byte>)0x004859E0)(ref this);
    // void __thiscall UIOption_Slider::RecvNotice_RefreshOptionsPanel(UIOption_Slider*)
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, void>)0x00485A00)(ref this);
    // void __thiscall UIOption_Slider::SetTooltip(UIOption_Menu*,const StringInfo*)
    public void SetTooltip(ACBindings.StringInfo* i_siTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Slider, ACBindings.StringInfo*, void>)0x00487410)(ref this, i_siTooltip);
}

