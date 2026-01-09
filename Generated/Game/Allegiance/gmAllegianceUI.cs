namespace ACBindings;

// gmAllegianceUI
public unsafe struct gmAllegianceUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Child Types
    // gmAllegianceUI_vtbl
    public unsafe struct gmAllegianceUI_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer

        // Methods
    }

    // Members
    public byte m_bAwaitingUpdate;
    public uint m_iidSelectedVassal;
    public uint m_iidPossibleNewPatron;
    public uint m_iidPossibleKickedVassal;
    public uint m_uiAcceptSwearServerContextID;
    public ACBindings.UIElement_Text* m_pAllegianceName;
    public ACBindings.UIElement_Text* m_pPlayerFollowers;
    public ACBindings.UIElement_Text* m_pPlayerRank;
    public ACBindings.UIElement* m_pMonarchField;
    public ACBindings.UIElement_Text* m_pMonarchLabel;
    public ACBindings.UIElement_Text* m_pMonarchName;
    public ACBindings.UIElement_Text* m_pMonarchFollowers;
    public ACBindings.UIElement* m_pPatronField;
    public ACBindings.UIElement_Text* m_pPatronName;
    public ACBindings.UIElement_ListBox* m_pVassalListBox;
    public ACBindings.UIElement_Button* m_pSwearButton;
    public ACBindings.UIElement_Button* m_pBreakButton;
    public ACBindings.UIElement_Button* m_pKickButton;
    public uint m_swearContext;
    public uint m_acceptSwearContext;
    public uint m_breakContext;
    public uint m_kickContext;

    // Generated Constructor
    public gmAllegianceUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmAllegianceUI::ListenToGlobalMessage(gmAllegianceUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, uint, int, void>)0x00490B90)(ref this, i_messageID, i_data_int);
    // void __thiscall gmAllegianceUI::UpdateSwearButton(gmAllegianceUI*)
    public void UpdateSwearButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00490BC0)(ref this);
    // void __thiscall gmAllegianceUI::UpdateBreakButton(gmAllegianceUI*)
    public void UpdateBreakButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00490CB0)(ref this);
    // bool __thiscall gmAllegianceUI::CloseAcceptSwearConfirmationDialog(gmAllegianceUI*,bool)
    public byte CloseAcceptSwearConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte, byte>)0x00490D30)(ref this, i_bConfirm);
    // bool __thiscall gmAllegianceUI::CloseBreakConfirmationDialog(gmAllegianceUI*,bool)
    public byte CloseBreakConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte, byte>)0x00490D70)(ref this, i_bConfirm);
    // bool __thiscall gmAllegianceUI::CloseKickConfirmationDialog(gmAllegianceUI*,bool)
    public byte CloseKickConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte, byte>)0x00490DE0)(ref this, i_bConfirm);
    // void __thiscall gmAllegianceUI::gmAllegianceUI(gmAllegianceUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00490E20)(ref this, layout, full_desc);
    // UIElement* __thiscall gmAllegianceUI::DynamicCast(gmAllegianceUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, uint, ACBindings.UIElement*>)0x00490EF0)(ref this, i_eType);
    // unsigned int __thiscall gmAllegianceUI::GetUIElementType(gmAllegianceUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, uint>)0x00490F10)(ref this);
    // void __thiscall gmAllegianceUI::~gmAllegianceUI(gmAllegianceUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00490F20)(ref this);
    // UIElement* __cdecl gmAllegianceUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00490FF0)(layout, full_desc);
    // void __thiscall gmAllegianceUI::RecvNotice_PlayerDescReceived(gmAllegianceUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x00491020)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmAllegianceUI::RecvNotice_SelectionChanged(gmAllegianceUI*)
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00491050)(ref this);
    // void __thiscall gmAllegianceUI::RecvNotice_AbortConfirmationRequest(gmAllegianceUI*,int,unsigned int)
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, int, uint, void>)0x00491060)(ref this, confirmationType, context);
    // void __thiscall gmAllegianceUI::OnQualityRemoved(gmAllegianceUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x00491090)(ref this, cwobj, stype, senum);
    // void __thiscall gmAllegianceUI::PostInit(gmAllegianceUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00491170)(ref this);
    // void __cdecl gmAllegianceUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004914D0)();
    // void __thiscall gmAllegianceUI::OnVisibilityChanged(gmAllegianceUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte, void>)0x00491520)(ref this, i_bVisible);
    // void __thiscall gmAllegianceUI::UpdatePlayerData(gmAllegianceUI*)
    public void UpdatePlayerData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00491610)(ref this);
    // void __thiscall gmAllegianceUI::UpdatePatronData(gmAllegianceUI*)
    public void UpdatePatronData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00491AA0)(ref this);
    // void __thiscall gmAllegianceUI::UpdateMonarchData(gmAllegianceUI*)
    public void UpdateMonarchData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00491E20)(ref this);
    // void __thiscall gmAllegianceUI::RecvNotice_EnchantmentsChanged(gmAllegianceUI*)
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00492330)(ref this);
    // void __thiscall gmAllegianceUI::RecvNotice_CloseDialog(gmAllegianceUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, uint, ACBindings.PropertyCollection*, void>)0x00492340)(ref this, context, data);
    // void __thiscall gmAllegianceUI::RecvNotice_AllegianceLogin(gmAllegianceUI*,unsigned int,bool)
    public void RecvNotice_AllegianceLogin(uint i_iidMember, byte i_bNowLoggedIn) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, uint, byte, void>)0x00492500)(ref this, i_iidMember, i_bNowLoggedIn);
    // void __thiscall gmAllegianceUI::UpdateVassalsData(gmAllegianceUI*)
    public void UpdateVassalsData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00492620)(ref this);
    // void __thiscall gmAllegianceUI::Update(gmAllegianceUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, void>)0x00492950)(ref this);
    // void __thiscall gmAllegianceUI::RecvNotice_AllegianceUpdate(gmAllegianceUI*,const CAllegianceProfile*,unsigned int)
    public void RecvNotice_AllegianceUpdate(ACBindings.CAllegianceProfile* i_prof, uint i_uiRank) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, ACBindings.CAllegianceProfile*, uint, void>)0x00492A60)(ref this, i_prof, i_uiRank);
    // void __thiscall gmAllegianceUI::RecvNotice_AllegianceUpdateAborted(gmAllegianceUI*,unsigned int)
    public void RecvNotice_AllegianceUpdateAborted(uint i_etype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, uint, void>)0x00492A70)(ref this, i_etype);
    // bool __thiscall gmAllegianceUI::MakeSwearConfirmationDialog(gmAllegianceUI*)
    public byte MakeSwearConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte>)0x00492A90)(ref this);
    // char __thiscall gmAllegianceUI::MakeAcceptSwearConfirmationDialog(_DWORD*,const char*,int)
    public sbyte MakeAcceptSwearConfirmationDialog(sbyte* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, sbyte*, int, sbyte>)0x00492C70)(ref this, a2, a3);
    // bool __thiscall gmAllegianceUI::MakeBreakConfirmationDialog(gmAllegianceUI*)
    public byte MakeBreakConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte>)0x00492ED0)(ref this);
    // bool __thiscall gmAllegianceUI::MakeKickConfirmationDialog(gmAllegianceUI*)
    public byte MakeKickConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, byte>)0x004930F0)(ref this);
    // UIElementMessageListenResult __thiscall gmAllegianceUI::ListenToElementMessage(gmAllegianceUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00493310)(ref this, i_rMsg);
    // char __thiscall gmAllegianceUI::RecvNotice_SwearAllegianceRequest(_DWORD*,int*,const char*)
    public sbyte RecvNotice_SwearAllegianceRequest(int* a2, sbyte* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAllegianceUI, int*, sbyte*, sbyte>)0x004933F0)(ref this, a2, a3);
}

