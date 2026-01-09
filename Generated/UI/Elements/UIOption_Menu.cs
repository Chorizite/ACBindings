namespace ACBindings;

// UIOption_Menu
public unsafe struct UIOption_Menu : System.IDisposable
{
    // Base Classes
    public ACBindings.UIOption BaseClass_UIOption; // ACBindings.UIOption
    public ACBindings.UIElement_Menu BaseClass_UIElement_Menu; // ACBindings.UIElement_Menu

    // Child Types
    // UIOption_Menu_vtbl
    public unsafe struct UIOption_Menu_vtbl
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
        public System.IntPtr UIOption_Menu_dtor_2a8; // function pointer
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
        public System.IntPtr SetEntries;
        public System.IntPtr SetLiteralEntries;
        public System.IntPtr GetValue; // function pointer

        // Methods
    }

    // Members
    public uint m_default;
    public uint m_saved;
    public uint m_current;
    public ACBindings.PStringBase__sbyte m_prefName;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIOption_Menu::Refresh(UIOption_Menu*)
    public void Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, void>)0x00484020)(ref this);
    // bool __thiscall UIOption_Menu::Changed(UIOption_Menu*)
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, byte>)0x004840B0)(ref this);
    // bool __thiscall UIOption_Menu::SaveCurrentValue(UIOption_Menu*)
    public byte SaveCurrentValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, byte>)0x004840D0)(ref this);
    // bool __thiscall UIOption_Menu::RestoreSavedValue(UIOption_Menu*)
    public byte RestoreSavedValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, byte>)0x004840F0)(ref this);
    // bool __thiscall UIOption_Menu::RestoreDefaultValue(UIOption_Menu*)
    public byte RestoreDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, byte>)0x00484120)(ref this);
    // void __thiscall UIOption_Menu::SetDefaultValue(UIOption_Menu*,const unsigned int)
    public void SetDefaultValue(uint defaulta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, uint, void>)0x00484150)(ref this, defaulta);
    // UIElementMessageListenResult __thiscall UIOption_Menu::ListenToElementMessage(UIOption_Menu*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00484160)(ref this, i_rMsg);
    // void __thiscall UIOption_Menu::RecvNotice_RefreshOptionsPanel(UIOption_Menu*)
    public void RecvNotice_RefreshOptionsPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, void>)0x004841E0)(ref this);
    // unsigned int __thiscall UIOption_Menu::GetValue(UIOption_Menu*)
    public uint GetValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, uint>)0x00484200)(ref this);
    // void __thiscall UIOption_Menu::HandleDialogAndNotices(UIOption_Menu*,bool)
    public void HandleDialogAndNotices(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, byte, void>)0x00484230)(ref this, userRequested);
    // void __thiscall UIOption_Menu::ListenToGlobalMessage(UIOption_Menu*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, uint, int, void>)0x00484270)(ref this, i_messageID, i_data_int);
    // void __thiscall UIOption_Menu::~UIOption_Menu(UIOption_Menu*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, void>)0x004842C0)(ref this);
    // UIElement* __thiscall UIOption_Menu::DynamicCast(UIOption_Menu*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, uint, ACBindings.UIElement*>)0x00484320)(ref this, i_eType);
    // unsigned int __thiscall UIOption_Menu::GetUIElementType(UIOption_Menu*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, uint>)0x00484360)(ref this);
    // UIElement* __thiscall UIOption_Menu::DynamicCast(unsigned int)
    public ACBindings.UIElement* DynamicCast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, ACBindings.UIElement*>)0x00484380)(ref this);
    // void __thiscall UIOption_Menu::SetLabel(UIOption_Menu*,const StringInfo*)
    public void SetLabel(ACBindings.StringInfo* i_siLabel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, ACBindings.StringInfo*, void>)0x00484390)(ref this, i_siLabel);
    // unsigned int __thiscall UIOption_Menu::SetEntries(char*,_DWORD*,_DWORD*,int)
    public uint SetEntries(int* a2, int* a3, int strtableEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, int*, int*, int, uint>)0x004843D0)(ref this, a2, a3, strtableEnum);
    // bool __thiscall UIOption_Menu::Apply(UIOption_Menu*,bool)
    public byte Apply(byte userRequested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, byte, byte>)0x00484510)(ref this, userRequested);
    // void __thiscall UIOption_Menu::SetUserPreference(UIOption*,bool (__cdecl**tableID)())
    public void SetUserPreference(delegate* unmanaged[Cdecl]<byte>* tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, delegate* unmanaged[Cdecl]<byte>*, void>)0x004845C0)(ref this, tableID);
    // void __cdecl UIOption_Menu::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00484720)();
    // void __thiscall UIOption_Menu::SetUIPreference(UIOption*,bool (__cdecl**tableID)())
    public void SetUIPreference(delegate* unmanaged[Cdecl]<byte>* tableID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, delegate* unmanaged[Cdecl]<byte>*, void>)0x00484740)(ref this, tableID);
    // unsigned int __thiscall UIOption_Menu::SetLiteralEntries(char*,int,_DWORD*)
    public uint SetLiteralEntries(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, int, int*, uint>)0x00484900)(ref this, a2, a3);
    // void __thiscall UIOption_Menu::RecvNotice_ReloadOptions(UIOption_Menu*)
    public void RecvNotice_ReloadOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIOption_Menu, void>)0x00486DC0)(ref this);
}

