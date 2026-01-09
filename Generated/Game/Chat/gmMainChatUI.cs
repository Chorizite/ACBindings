namespace ACBindings;

// gmMainChatUI
public unsafe struct gmMainChatUI : System.IDisposable
{
    // Base Classes
    public ACBindings.ChatInterface BaseClass_ChatInterface; // ACBindings.ChatInterface

    // Child Types
    // gmMainChatUI_vtbl
    public unsafe struct gmMainChatUI_vtbl
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
    public ACBindings.UIElement_Text* m_pSquelchToggleButton;
    public ACBindings.SmartArray__UIElement_Text_ptr m_aTalkFocusButtons;
    public ACBindings.UIElement_Text* m_pChatTargetButtonText;
    public byte m_Maximized;
    public int m_OldY;
    public int m_OldHeight;

    // Generated Constructor
    public gmMainChatUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmMainChatUI::MoveTo(gmMainChatUI*,const int,const int)
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, int, int, void>)0x004CD930)(ref this, x, y);
    // void __thiscall gmMainChatUI::RecvNotice_SetPanelVisibility(gmMainChatUI*,unsigned int,bool)
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, byte, void>)0x004CD9F0)(ref this, i_ePanelID, i_bVisible);
    // void __thiscall gmMainChatUI::RecvNotice_TextTag_IIDStringClick(UIElement_Text**,int,int,_DWORD*)
    public void RecvNotice_TextTag_IIDStringClick(int a2, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, int, int, int*, void>)0x004CDA80)(ref this, a2, a3, a4);
    // void __thiscall gmMainChatUI::HandleMaximizeButton(gmMainChatUI*)
    public void HandleMaximizeButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CDAC0)(ref this);
    // void __thiscall gmMainChatUI::ResizeTo(gmMainChatUI*,const int,const int)
    public void ResizeTo(int i_cWidth, int i_cHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, int, int, void>)0x004CDD10)(ref this, i_cWidth, i_cHeight);
    // void __thiscall gmMainChatUI::gmMainChatUI(gmMainChatUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004CDD60)(ref this, layout, full_desc);
    // UIElement* __thiscall gmMainChatUI::DynamicCast(gmMainChatUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, ACBindings.UIElement*>)0x004CDDD0)(ref this, i_eType);
    // unsigned int __thiscall gmMainChatUI::GetUIElementType(gmMainChatUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint>)0x004CDE00)(ref this);
    // void __thiscall gmMainChatUI::~gmMainChatUI(gmMainChatUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CDE10)(ref this);
    // void __thiscall gmMainChatUI::ToggleSquelchOnCurrentSpeakableTarget(gmMainChatUI*)
    public void ToggleSquelchOnCurrentSpeakableTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CDEA0)(ref this);
    // void __cdecl gmMainChatUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CDFC0)();
    // UIElement_Text* __thiscall gmMainChatUI::GetTalkFocusMenuItem(gmMainChatUI*,unsigned int)
    public ACBindings.UIElement_Text* GetTalkFocusMenuItem(uint i_eFocus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, ACBindings.UIElement_Text*>)0x004CDFE0)(ref this, i_eFocus);
    // void __thiscall gmMainChatUI::ResetAllTalkFocusMenuButtons(gmMainChatUI*)
    public void ResetAllTalkFocusMenuButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CE110)(ref this);
    // void __thiscall gmMainChatUI::HandleSelection(gmMainChatUI*,unsigned int)
    public void HandleSelection(uint i_eFocus) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, void>)0x004CE1B0)(ref this, i_eFocus);
    // void __thiscall gmMainChatUI::SetSelected(gmMainChatUI*,unsigned int)
    public void SetSelected(uint i_iidTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, void>)0x004CE3A0)(ref this, i_iidTarget);
    // UIElementMessageListenResult __thiscall gmMainChatUI::ListenToElementMessage(gmMainChatUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CE6F0)(ref this, i_rMsg);
    // void __thiscall gmMainChatUI::UseTime(gmMainChatUI*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CE790)(ref this);
    // void __thiscall gmMainChatUI::InitTalkFocusMenu(gmMainChatUI*)
    public void InitTalkFocusMenu() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CE8C0)(ref this);
    // void __thiscall gmMainChatUI::RecvNotice_SelectionChanged(gmMainChatUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CECC0)(ref this);
    // void __thiscall gmMainChatUI::EnableSelection(gmMainChatUI*,unsigned int,bool)
    public void EnableSelection(uint i_eFocus, byte i_bEnabled) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, byte, void>)0x004CED10)(ref this, i_eFocus, i_bEnabled);
    // void __thiscall gmMainChatUI::PostInit(gmMainChatUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, void>)0x004CEDA0)(ref this);
    // void __thiscall gmMainChatUI::ListenToGlobalMessage(gmMainChatUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMainChatUI, uint, int, void>)0x004CEE90)(ref this, i_messageID, i_data_int);
}

