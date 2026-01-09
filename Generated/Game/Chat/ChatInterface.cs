namespace ACBindings;

// ChatInterface
public unsafe struct ChatInterface : System.IDisposable
{
    // Base Classes
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field

    // Child Types
    // ChatInterface_vtbl
    public unsafe struct ChatInterface_vtbl
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
        public System.IntPtr UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public uint m_eWindowID;
    public float m_fDefaultOpacity;
    public float m_fActiveOpacity;
    public float m_fCurrentOpacity;
    public ACBindings.UIElement_Text* m_chatEntry;
    public ACBindings.UIElement_Text* m_chatLog;
    public ACBindings.UIElement* m_chatNewNonVisibleTextIndicator;
    public ulong m_llTextTypeFilter;
    public ACBindings.UIElement_Text* m_pChatTargetButtonText;
    public ACBindings.PStringBaseArray__ushort m_InputHistory;
    public uint m_LastInputHistoryPos;
    public ACBindings.ClientCommunicationSystem* m_pCCS;

    // Generated Constructor
    public ChatInterface(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall ChatInterface::TypeIsActive(ChatInterface*,unsigned int)
    public byte TypeIsActive(uint i_ltt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, byte>)0x004F3B70)(ref this, i_ltt);
    // void __thiscall ChatInterface::RecvNotice_PlayerDescReceived(ChatInterface*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004F3BB0)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall ChatInterface::RecvNotice_ClearChatBuffer(ChatInterface*,unsigned int)
    public void RecvNotice_ClearChatBuffer(uint i_idWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, void>)0x004F3BC0)(ref this, i_idWindow);
    // void __thiscall ChatInterface::ActivateChatEntry(ChatInterface*)
    public void ActivateChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F3BF0)(ref this);
    // void __thiscall ChatInterface::DeactivateChatEntry(ChatInterface*)
    public void DeactivateChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F3C20)(ref this);
    // void __thiscall ChatInterface::HandleCommandOrAliasKey(ChatInterface*,unsigned int)
    public void HandleCommandOrAliasKey(uint i_inputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, void>)0x004F3C50)(ref this, i_inputAction);
    // bool __thiscall ChatInterface::IsTextEntryFocused(ChatInterface*)
    public byte IsTextEntryFocused() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, byte>)0x004F3D00)(ref this);
    // void __thiscall ChatInterface::RecvNotice_GameplayOptionChanged(ChatInterface*,const BaseProperty*,unsigned int)
    public void RecvNotice_GameplayOptionChanged(ACBindings.BaseProperty* i_prop, uint i_dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.BaseProperty*, uint, void>)0x004F3D40)(ref this, i_prop, i_dwUserData);
    // void __thiscall ChatInterface::SetOpacity(ChatInterface*,float)
    public void SetOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, float, void>)0x004F3D80)(ref this, i_fOpacity);
    // bool __thiscall ChatInterface::SetUIObject(ChatInterface*,UIObject*)
    public byte SetUIObject(ACBindings.UIObject* i_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.UIObject*, byte>)0x004F3DC0)(ref this, i_pcUIObject);
    // void __thiscall ChatInterface::BuildChatColorLookupTable(ChatInterface*)
    public void BuildChatColorLookupTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F3E20)(ref this);
    // void __thiscall ChatInterface::ListenToGlobalMessage(ChatInterface*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, int, void>)0x004F44A0)(ref this, i_messageID, i_data_int);
    // void __thiscall ChatInterface::UpdateFromPlayerModule(ChatInterface*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F4580)(ref this);
    // void __thiscall ChatInterface::ResizeTo(ChatInterface*,const int,const int)
    public void ResizeTo(int i_cWidth, int i_cHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, int, int, void>)0x004F4640)(ref this, i_cWidth, i_cHeight);
    // void __thiscall ChatInterface::SelectCommandFromHistory(ChatInterface*,bool)
    public void SelectCommandFromHistory(byte i_fPrevious) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, byte, void>)0x004F4690)(ref this, i_fPrevious);
    // bool __thiscall ChatInterface::OnToggleChatEntry(ChatInterface*)
    public byte OnToggleChatEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, byte>)0x004F4790)(ref this);
    // void __thiscall ChatInterface::SetDefaultOpacity(ChatInterface*,float)
    public void SetDefaultOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, float, void>)0x004F4820)(ref this, i_fOpacity);
    // void __thiscall ChatInterface::SetActiveOpacity(ChatInterface*,float)
    public void SetActiveOpacity(float i_fOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, float, void>)0x004F48A0)(ref this, i_fOpacity);
    // void __thiscall ChatInterface::PostInit(ChatInterface*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F4A30)(ref this);
    // void __thiscall ChatInterface::OnSetAttribute(ChatInterface*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.BaseProperty*, void>)0x004F4BC0)(ref this, attribute);
    // void __thiscall ChatInterface::~ChatInterface(ChatInterface*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F4DC0)(ref this);
    // LONG __thiscall ChatInterface::StartTell(UIElement_Text**,_DWORD*)
    public int StartTell(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, int*, int>)0x004F4E50)(ref this, a2);
    // void __thiscall ChatInterface::TruncateChatLog(ChatInterface*,unsigned int)
    public void TruncateChatLog(uint i_uiNewLength) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, void>)0x004F4EF0)(ref this, i_uiNewLength);
    // void __thiscall ChatInterface::RecvNotice_FontSettingsChanged(ChatInterface*,unsigned int,unsigned int)
    public void RecvNotice_FontSettingsChanged(uint i_nFontFace, uint i_nFontSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, uint, void>)0x004F50C0)(ref this, i_nFontFace, i_nFontSize);
    // void __thiscall ChatInterface::ChatInterface(ChatInterface*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004F51B0)(ref this, layout, full_desc);
    // void __thiscall ChatInterface::RecvNotice_DisplayFinalStringInfo(ChatInterface*,unsigned int,const StringInfo*,const StringInfo*,unsigned int)
    public void RecvNotice_DisplayFinalStringInfo(uint i_type, ACBindings.StringInfo* i_siMsg, ACBindings.StringInfo* i_siPrefix, uint i_idDestinationOverride) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, ACBindings.StringInfo*, ACBindings.StringInfo*, uint, void>)0x004F52A0)(ref this, i_type, i_siMsg, i_siPrefix, i_idDestinationOverride);
    // bool __thiscall ChatInterface::SetReplyTextInChatBox(ChatInterface*)
    public byte SetReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, byte>)0x004F53C0)(ref this);
    // bool __thiscall ChatInterface::SetMonarchReplyTextInChatBox(ChatInterface*)
    public byte SetMonarchReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, byte>)0x004F57D0)(ref this);
    // bool __thiscall ChatInterface::SetPatronReplyTextInChatBox(ChatInterface*)
    public byte SetPatronReplyTextInChatBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, byte>)0x004F5A80)(ref this);
    // void __thiscall ChatInterface::HandleTextReplacements(ChatInterface*)
    public void HandleTextReplacements() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F5D30)(ref this);
    // void __thiscall ChatInterface::ProcessCommand(ChatInterface*)
    public void ProcessCommand() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F5D60)(ref this);
    // UIElementMessageListenResult __thiscall ChatInterface::ListenToElementMessage(ChatInterface*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004F5E20)(ref this, i_rMsg);
    // void __thiscall ChatInterface::HandleEnterKey(ChatInterface*)
    public void HandleEnterKey() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, void>)0x004F5F30)(ref this);
    // void __thiscall ChatInterface::HandleReplyKey(ChatInterface*,unsigned int)
    public void HandleReplyKey(uint i_inputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, uint, void>)0x004F5FB0)(ref this, i_inputAction);
    // bool __thiscall ChatInterface::OnChildAction(ChatInterface*,const UIElement*,const InputEvent*)
    public byte OnChildAction(ACBindings.UIElement* i_pChild, ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatInterface, ACBindings.UIElement*, ACBindings.InputEvent*, byte>)0x004F61F0)(ref this, i_pChild, i_evt);
}

