namespace ACBindings;

// UIOption_CheckboxBitfield64
public unsafe struct UIOption_CheckboxBitfield64 : System.IDisposable
{
    // Base Classes
    public ACBindings.UIOption BaseClass_UIOption; // ACBindings.UIOption
    public ACBindings.UIElement_ListBox BaseClass_UIElement_ListBox; // ACBindings.UIElement_ListBox

    // Child Types
    // UIOption_CheckboxBitfield64_vtbl
    public unsafe struct UIOption_CheckboxBitfield64_vtbl
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
        public System.IntPtr UIOption_CheckboxBitfield64_dtor_2a8; // function pointer
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
        public System.IntPtr GetValue; // function pointer

        // Methods
    }
    // UIOption_CheckboxBitfield64::ChildInfo
    public unsafe struct ChildInfo
    {
        // Members
        public ulong llMask;
        public ACBindings.StringInfo siLabel;
        public ACBindings.StringInfo siTooltip;

        // Generated Constructor
        public ChildInfo() {
            _ConstructorInternal();
        }

        // Methods
        // void __thiscall UIOption_CheckboxBitfield64::ChildInfo::ChildInfo(UIOption_CheckboxBitfield64::ChildInfo*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64.ChildInfo, void>)0x00485A20)(ref this);
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
    public ACBindings.PStringBase__sbyte m_prefName;
    public uint m_propName;
    public ACBindings.UIOption_CheckboxBitfield64.PropertyType m_propType;
    public ACBindings.SmartArray__UIOption_CheckboxBitfield64_ChildInfo m_rgChildValues;

    // Generated Constructor
    public UIOption_CheckboxBitfield64(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall UIOption_CheckboxBitfield64::Changed(UIOption_CheckboxBitfield64*)
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, byte>)0x00485A60)(ref this);
    // bool __thiscall UIOption_CheckboxBitfield64::SaveCurrentValue(UIOption_CheckboxBitfield64*)
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, byte>)0x00485A90)(ref this);
    // bool __thiscall UIOption_CheckboxBitfield64::RestoreSavedValue(UIOption_CheckboxBitfield64*)
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, byte>)0x00485AC0)(ref this);
    // bool __thiscall UIOption_CheckboxBitfield64::RestoreDefaultValue(UIOption_CheckboxBitfield64*)
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, byte>)0x00485B00)(ref this);
    // void __thiscall UIOption_CheckboxBitfield64::SetDefaultValue(UIOption_CheckboxBitfield64*,unsigned __int64)
    public void SetDefaultValue(ulong defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, ulong, void>)0x00485B40)(ref this, defaulta);
    // void __thiscall UIOption_CheckboxBitfield64::RecvNotice_ReloadOptions(UIOption_CheckboxBitfield64*)
    public void RecvNotice_ReloadOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, void>)0x00485B60)(ref this);
    // void __thiscall UIOption_CheckboxBitfield64::Refresh(UIOption_CheckboxBitfield64*)
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, void>)0x00485D80)(ref this);
    // UIElementMessageListenResult __thiscall UIOption_CheckboxBitfield64::ListenToElementMessage(UIOption_CheckboxBitfield64*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00485EA0)(ref this, i_rMsg);
    // void __thiscall UIOption_CheckboxBitfield64::UIOption_CheckboxBitfield64(UIOption_CheckboxBitfield64*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00486010)(ref this, layout, full_desc);
    // UIElement* __thiscall UIOption_CheckboxBitfield64::DynamicCast(UIOption_CheckboxBitfield64*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, uint, ACBindings.UIElement*>)0x004860A0)(ref this, i_eType);
    // unsigned int __thiscall UIOption_CheckboxBitfield64::GetUIElementType(UIOption_CheckboxBitfield64*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, uint>)0x004860E0)(ref this);
    // UIElement* __thiscall UIOption_CheckboxBitfield64::DynamicCast(unsigned int)
    public ACBindings.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, ACBindings.UIElement*>)0x00486100)(ref this);
    // void __thiscall UIOption_CheckboxBitfield64::~UIOption_CheckboxBitfield64(UIOption_CheckboxBitfield64*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, void>)0x00486110)(ref this);
    // UIElement* __cdecl UIOption_CheckboxBitfield64::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00486180)(layout, full_desc);
    // void __thiscall UIOption_CheckboxBitfield64::CreateChildren(UIOption_CheckboxBitfield64*)
    public void CreateChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, void>)0x004861B0)(ref this);
    // void __cdecl UIOption_CheckboxBitfield64::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00486290)();
    // void __thiscall UIOption_CheckboxBitfield64::SetGameplayOptionProperty(UIOption_CheckboxBitfield64*,unsigned int,UIOption_CheckboxBitfield64::PropertyType)
    public void SetGameplayOptionProperty(uint i_propName, ACBindings.UIOption_CheckboxBitfield64.PropertyType i_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, uint, ACBindings.UIOption_CheckboxBitfield64.PropertyType, void>)0x004862B0)(ref this, i_propName, i_type);
    // bool __thiscall UIOption_CheckboxBitfield64::Apply(UIOption_CheckboxBitfield64*,bool)
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, byte, byte>)0x004863B0)(ref this, userRequested);
    // unsigned __int64 __thiscall UIOption_CheckboxBitfield64::GetValue(UIOption_CheckboxBitfield64*)
    public ulong GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, ulong>)0x00486510)(ref this);
    // void __thiscall UIOption_CheckboxBitfield64::AddChild(UIOption_CheckboxBitfield64*,unsigned __int64,unsigned int,unsigned int)
    public void AddChild(ulong i_llMask, uint i_stLabel, uint i_stTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_CheckboxBitfield64, ulong, uint, uint, void>)0x00486660)(ref this, i_llMask, i_stLabel, i_stTooltip);
}

