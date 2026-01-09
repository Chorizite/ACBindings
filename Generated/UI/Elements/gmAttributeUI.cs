namespace ACBindings;

// gmAttributeUI
public unsafe struct gmAttributeUI
{
    // Base Classes
    public ACBindings.gmStatManagementUI BaseClass_gmStatManagementUI; // ACBindings.gmStatManagementUI

    // Child Types
    // gmAttributeUI_vtbl
    public unsafe struct gmAttributeUI_vtbl
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
    public int m_SelectedIndex;

    // Methods
    // UIElement* __thiscall gmAttributeUI::DynamicCast(gmAttributeUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, uint, ACBindings.UIElement*>)0x0049CC40)(ref this, i_eType);
    // unsigned int __thiscall gmAttributeUI::GetUIElementType(gmAttributeUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, uint>)0x0049CC60)(ref this);
    // UIElement* __cdecl gmAttributeUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0049CC70)(layout, full_desc);
    // void __cdecl gmAttributeUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049CD10)();
    // bool __thiscall gmAttributeUI::SetSelection(gmAttributeUI*,UIElement*)
    public byte SetSelection(ACBindings.UIElement* selectedUI) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.UIElement*, byte>)0x0049CD30)(ref this, selectedUI);
    // unsigned int __thiscall gmAttributeUI::GetCostToRaise(gmAttributeUI*,const CACQualities*)
    public uint GetCostToRaise(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.CACQualities*, uint>)0x0049CDF0)(ref this, i_playerDesc);
    // unsigned int __thiscall gmAttributeUI::GetCostToRaise10(gmAttributeUI*,const CACQualities*)
    public uint GetCostToRaise10(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.CACQualities*, uint>)0x0049CEE0)(ref this, i_playerDesc);
    // bool __thiscall gmAttributeUI::MessageIsFromSelectedElement(gmAttributeUI*,StatType,unsigned int)
    public byte MessageIsFromSelectedElement(ACBindings.StatType i_statType, uint i_statEnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.StatType, uint, byte>)0x0049D000)(ref this, i_statType, i_statEnum);
    // bool __thiscall gmAttributeUI::DisplayDefaultFooter(gmAttributeUI*,const CACQualities*)
    public byte DisplayDefaultFooter(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.CACQualities*, byte>)0x0049D050)(ref this, i_playerDesc);
    // bool __thiscall gmAttributeUI::RaiseSelection(gmAttributeUI*)
    public byte RaiseSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, byte>)0x0049D290)(ref this);
    // bool __thiscall gmAttributeUI::Raise10Selection(gmAttributeUI*)
    public byte Raise10Selection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, byte>)0x0049D3C0)(ref this);
    // bool __thiscall gmAttributeUI::DisplaySelectionFooter_Attribute(gmAttributeUI*,const CACQualities*)
    public byte DisplaySelectionFooter_Attribute(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.CACQualities*, byte>)0x0049D4F0)(ref this, i_playerDesc);
    // bool __thiscall gmAttributeUI::DisplaySelectionFooter_Vital(gmAttributeUI*,const CACQualities*)
    public byte DisplaySelectionFooter_Vital(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, ACBindings.CACQualities*, byte>)0x0049D920)(ref this, i_playerDesc);
    // void __thiscall gmAttributeUI::PostInit(gmAttributeUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, void>)0x0049DDE0)(ref this);
    // bool __thiscall gmAttributeUI::UpdateSelection(gmAttributeUI*)
    public byte UpdateSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmAttributeUI, byte>)0x0049E150)(ref this);
}

