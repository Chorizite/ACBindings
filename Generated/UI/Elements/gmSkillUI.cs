namespace ACBindings;

// gmSkillUI
public unsafe struct gmSkillUI
{
    // Base Classes
    public ACBindings.gmStatManagementUI BaseClass_gmStatManagementUI; // ACBindings.gmStatManagementUI

    // Child Types
    // gmSkillUI_vtbl
    public unsafe struct gmSkillUI_vtbl
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
        public System.IntPtr GetCostToRaise10; // function pointer

        // Methods
    }

    // Members
    public uint m_SelectedSkill;
    public int m_SelectedIndex;

    // Generated Constructor
    public gmSkillUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmSkillUI::gmSkillUI(gmSkillUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0049B040)(ref this, layout, full_desc);
    // UIElement* __thiscall gmSkillUI::DynamicCast(gmSkillUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, uint, ACBindings.UIElement*>)0x0049B090)(ref this, i_eType);
    // unsigned int __thiscall gmSkillUI::GetUIElementType(gmSkillUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, uint>)0x0049B0B0)(ref this);
    // void __thiscall gmSkillUI::PostInit(gmSkillUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, void>)0x0049B0C0)(ref this);
    // UIElement* __cdecl gmSkillUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0049B100)(layout, full_desc);
    // unsigned int __thiscall gmSkillUI::GetCostToRaise10(gmSkillUI*,const CACQualities*)
    public uint GetCostToRaise10(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, uint>)0x0049B130)(ref this, i_playerDesc);
    // bool __thiscall gmSkillUI::MessageIsFromSelectedElement(gmSkillUI*,StatType,unsigned int)
    public byte MessageIsFromSelectedElement(ACBindings.StatType i_statType, uint i_statEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.StatType, uint, byte>)0x0049B210)(ref this, i_statType, i_statEnum);
    // void __cdecl gmSkillUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049B290)();
    // bool __thiscall gmSkillUI::SetSelection(gmSkillUI*,UIElement*)
    public byte SetSelection(ACBindings.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.UIElement*, byte>)0x0049B2B0)(ref this, selectedUI);
    // bool __thiscall gmSkillUI::DisplayDefaultFooter(gmSkillUI*,const CACQualities*)
    public byte DisplayDefaultFooter(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, byte>)0x0049B380)(ref this, i_playerDesc);
    // bool __thiscall gmSkillUI::DisplaySelectionFooter_Untrained(gmSkillUI*,const CACQualities*)
    public byte DisplaySelectionFooter_Untrained(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, byte>)0x0049B5C0)(ref this, i_playerDesc);
    // unsigned int __thiscall gmSkillUI::GetCostToRaise(gmSkillUI*,const CACQualities*)
    public uint GetCostToRaise(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, uint>)0x0049B8F0)(ref this, i_playerDesc);
    // bool __thiscall gmSkillUI::Raise10Selection(gmSkillUI*)
    public byte Raise10Selection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, byte>)0x0049B9D0)(ref this);
    // bool __thiscall gmSkillUI::DisplaySelectionFooter_Trained(gmSkillUI*,const CACQualities*)
    public byte DisplaySelectionFooter_Trained(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, byte>)0x0049BAD0)(ref this, i_playerDesc);
    // bool __thiscall gmSkillUI::AddSortedSkill(gmSkillUI*,unsigned int,const SkillBase*,UIElement*,UIElement*)
    public byte AddSortedSkill(uint i_SkillID, ACBindings.SkillBase* i_SkillBase, ACBindings.UIElement* i_pAfter, ACBindings.UIElement* i_pBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, uint, ACBindings.SkillBase*, ACBindings.UIElement*, ACBindings.UIElement*, byte>)0x0049C040)(ref this, i_SkillID, i_SkillBase, i_pAfter, i_pBefore);
    // bool __thiscall gmSkillUI::UpdateSelection(gmSkillUI*)
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, byte>)0x0049C310)(ref this);
    // void __cdecl gmSkillUI::TrainSkillDialogCallback(const PropertyCollection*)
    public static void TrainSkillDialogCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x0049C480)(i_rcResults);
    // bool __thiscall gmSkillUI::RebuildSkillList(gmSkillUI*)
    public byte RebuildSkillList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, byte>)0x0049C610)(ref this);
    // void __thiscall gmSkillUI::RecvNotice_PlayerDescReceived(gmSkillUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x0049C840)(ref this, i_playerDesc, i_playerModule);
    // void __thiscall gmSkillUI::RecvNotice_SkillAdvancementClassChanged(gmSkillUI*)
    public void RecvNotice_SkillAdvancementClassChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, void>)0x0049C850)(ref this);
    // bool __thiscall gmSkillUI::TrainSkill(gmSkillUI*,const CACQualities*)
    public byte TrainSkill(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, ACBindings.CACQualities*, byte>)0x0049C860)(ref this, i_playerDesc);
    // bool __thiscall gmSkillUI::RaiseSelection(gmSkillUI*)
    public byte RaiseSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSkillUI, byte>)0x0049CB30)(ref this);
}

