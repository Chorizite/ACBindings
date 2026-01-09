namespace ACBindings;

// gmFloatyChatUI
public unsafe struct gmFloatyChatUI
{
    // Base Classes
    public ACBindings.ChatInterface BaseClass_ChatInterface; // ACBindings.ChatInterface

    // Child Types
    // gmFloatyChatUI_vtbl
    public unsafe struct gmFloatyChatUI_vtbl
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
        public System.IntPtr SetWindowTitle; // function pointer

        // Methods
    }

    // Methods
    // UIElement* __thiscall gmFloatyChatUI::DynamicCast(gmFloatyChatUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, uint, ACBindings.UIElement*>)0x004CEEF0)(ref this, i_eType);
    // unsigned int __thiscall gmFloatyChatUI::GetUIElementType(gmFloatyChatUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, uint>)0x004CEF20)(ref this);
    // UIElement* __cdecl gmFloatyChatUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004CEF30)(layout, full_desc);
    // void __thiscall gmFloatyChatUI::PostInit(gmFloatyChatUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, void>)0x004CEF70)(ref this);
    // UIElementMessageListenResult __thiscall gmFloatyChatUI::ListenToElementMessage(gmFloatyChatUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CEFA0)(ref this, i_rMsg);
    // void __thiscall gmFloatyChatUI::RecvNotice_SetChatWindowTitle(gmFloatyChatUI*,unsigned int,const StringInfo*)
    public void RecvNotice_SetChatWindowTitle(uint i_idWindow, ACBindings.StringInfo* i_siTitle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, uint, ACBindings.StringInfo*, void>)0x004CEFD0)(ref this, i_idWindow, i_siTitle);
    // void __cdecl gmFloatyChatUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CF040)();
    // void __thiscall gmFloatyChatUI::UpdateFromPlayerModule(gmFloatyChatUI*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, void>)0x004CF060)(ref this);
    // void __thiscall gmFloatyChatUI::ResizeTo(gmFloatyChatUI*,const int,const int)
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, int, int, void>)0x004CF340)(ref this, i_width, i_height);
    // void __thiscall gmFloatyChatUI::MoveTo(gmFloatyChatUI*,const int,const int)
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, int, int, void>)0x004CF4B0)(ref this, i_x, i_y);
    // void __thiscall gmFloatyChatUI::SetVisible(gmFloatyChatUI*,bool)
    public void SetVisible(byte i_fVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, byte, void>)0x004CF620)(ref this, i_fVisible);
    // bool __thiscall gmFloatyChatUI::SetWindowTitle(gmFloatyChatUI*,const StringInfo*)
    public byte SetWindowTitle(ACBindings.StringInfo* i_siTitle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, ACBindings.StringInfo*, byte>)0x004CF710)(ref this, i_siTitle);
    // void __thiscall gmFloatyChatUI::RecvNotice_GameplayOptionChanged(gmFloatyChatUI*,const BaseProperty*,unsigned int)
    public void RecvNotice_GameplayOptionChanged(ACBindings.BaseProperty* i_prop, uint i_dwUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFloatyChatUI, ACBindings.BaseProperty*, uint, void>)0x004D31D0)(ref this, i_prop, i_dwUserData);
}

