namespace ACBindings;

// gmStatManagementUI
public unsafe struct gmStatManagementUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Child Types
    // gmStatManagementUI_vtbl
    public unsafe struct gmStatManagementUI_vtbl
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
        public fixed byte gap138[4];
        public System.IntPtr Update; // function pointer
        public System.IntPtr UpdateCharacterInfo; // function pointer
        public System.IntPtr UpdatePKStatus; // function pointer
        public System.IntPtr UpdateExperience; // function pointer
        public System.IntPtr SetSelection; // function pointer
        public System.IntPtr UpdateSelection; // function pointer
        public System.IntPtr RaiseSelection; // function pointer
        public System.IntPtr Raise10Selection; // function pointer
        public System.IntPtr GetCostToRaise; // function pointer
        public System.IntPtr MessageIsFromSelectedElement; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_Text* m_pNameText;
    public ACBindings.UIElement_Text* m_pHeritageText;
    public ACBindings.UIElement_Text* m_pPKStatusText;
    public ACBindings.UIElement_Text* m_pLevelText;
    public ACBindings.UIElement_Text* m_pTotalXPText;
    public ACBindings.UIElement_Text* m_pXPToLevelText;
    public ACBindings.UIElement_Text* m_pLuminanceLabelText;
    public ACBindings.UIElement_Text* m_pLuminanceText;
    public ACBindings.UIElement_Meter* m_pXPToLevelMeter;
    public ACBindings.UIElement_ListBox* m_pListBox;
    public ACBindings.SmartArray__InfoRegion_ptr m_rgTokens;
    public byte m_bAwaitingRaise;
    public uint m_titleID;

    // Generated Constructor
    public gmStatManagementUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElementMessageListenResult __thiscall gmStatManagementUI::ListenToElementMessage(gmStatManagementUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004F0870)(ref this, i_rMsg);
    // void __thiscall gmStatManagementUI::RecvNotice_PlayerDescReceived(gmStatManagementUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004F0980)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmStatManagementUI::RecvNotice_EnchantmentsChanged(gmStatManagementUI*)
    public void RecvNotice_EnchantmentsChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, void>)0x004F09A0)(ref this);
    // void __thiscall gmStatManagementUI::RecvNotice_UpdateCharacterTitleTable(gmStatManagementUI*,const CharacterTitleTable*)
    public void RecvNotice_UpdateCharacterTitleTable(ACBindings.CharacterTitleTable* i_titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CharacterTitleTable*, void>)0x004F09C0)(ref this, i_titleTable);
    // void __thiscall gmStatManagementUI::RecvNotice_SetDisplayCharacterTitle(gmStatManagementUI*,unsigned int)
    public void RecvNotice_SetDisplayCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, uint, void>)0x004F09E0)(ref this, i_title);
    // void __thiscall gmStatManagementUI::OnQualityRemoved(gmStatManagementUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004F0A00)(ref this, cwobj, stype, senum);
    // void __thiscall gmStatManagementUI::PostInit(gmStatManagementUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, void>)0x004F0A20)(ref this);
    // bool __thiscall gmStatManagementUI::Update(gmStatManagementUI*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CACQualities*, byte>)0x004F0CB0)(ref this, i_playerDesc);
    // bool __thiscall gmStatManagementUI::UpdatePKStatus(gmStatManagementUI*,const CACQualities*)
    public byte UpdatePKStatus(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CACQualities*, byte>)0x004F0D30)(ref this, i_playerDesc);
    // UIElement_Text* __thiscall gmStatManagementUI::GetFooterTitleLabel(gmStatManagementUI*)
    public ACBindings.UIElement_Text* GetFooterTitleLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Text*>)0x004F0E00)(ref this);
    // UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineOneLabel(gmStatManagementUI*)
    public ACBindings.UIElement_Text* GetFooterLineOneLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Text*>)0x004F0E50)(ref this);
    // UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineOneValue(gmStatManagementUI*)
    public ACBindings.UIElement_Text* GetFooterLineOneValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Text*>)0x004F0EA0)(ref this);
    // UIElement_Meter* __thiscall gmStatManagementUI::GetFooterMeter(gmStatManagementUI*)
    public ACBindings.UIElement_Meter* GetFooterMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Meter*>)0x004F0EF0)(ref this);
    // UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineTwoLabel(gmStatManagementUI*)
    public ACBindings.UIElement_Text* GetFooterLineTwoLabel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Text*>)0x004F0F40)(ref this);
    // UIElement_Text* __thiscall gmStatManagementUI::GetFooterLineTwoValue(gmStatManagementUI*)
    public ACBindings.UIElement_Text* GetFooterLineTwoValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Text*>)0x004F0F90)(ref this);
    // UIElement_Button* __thiscall gmStatManagementUI::GetFooterButton(gmStatManagementUI*)
    public ACBindings.UIElement_Button* GetFooterButton() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Button*>)0x004F0FE0)(ref this);
    // UIElement_Button* __thiscall gmStatManagementUI::GetFooter10Button(gmStatManagementUI*)
    public ACBindings.UIElement_Button* GetFooter10Button() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.UIElement_Button*>)0x004F1030)(ref this);
    // void __thiscall gmStatManagementUI::gmStatManagementUI(gmStatManagementUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004F1080)(ref this, layout, full_desc);
    // bool __thiscall gmStatManagementUI::Update(gmStatManagementUI*)
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, byte>)0x004F1130)(ref this);
    // bool __thiscall gmStatManagementUI::FlushList(gmStatManagementUI*)
    public byte FlushList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, byte>)0x004F11E0)(ref this);
    // void __thiscall gmStatManagementUI::~gmStatManagementUI(gmStatManagementUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, void>)0x004F1270)(ref this);
    // bool __thiscall gmStatManagementUI::UpdateCharacterInfo(gmStatManagementUI*,const CACQualities*)
    public byte UpdateCharacterInfo(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CACQualities*, byte>)0x004F1400)(ref this, i_playerDesc);
    // bool __thiscall gmStatManagementUI::UpdateExperience(gmStatManagementUI*,const CACQualities*)
    public byte UpdateExperience(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmStatManagementUI, ACBindings.CACQualities*, byte>)0x004F1700)(ref this, i_playerDesc);
}

