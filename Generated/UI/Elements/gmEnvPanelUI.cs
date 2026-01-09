namespace ACBindings;

// gmEnvPanelUI
public unsafe struct gmEnvPanelUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmEnvPanelUI_vtbl
    public unsafe struct gmEnvPanelUI_vtbl
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
    // gmEnvPanelUI::PanelChildInfo
    public unsafe struct PanelChildInfo
    {
        // Members
        public ACBindings.UIElement* child;
        public uint panelID;
        public byte bShouldBeDefault;

        // Methods
    }

    // Members
    public ACBindings.SmartArray__gmEnvPanelUI_PanelChildInfo m_childrenInfoArray;
    public ACBindings.UIElement* m_currentlyShownPanel;
    public ACBindings.UIElement* m_pDefaultPanel;

    // Generated Constructor
    public gmEnvPanelUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmEnvPanelUI::RecvNotice_SetPanelVisibility(gmEnvPanelUI*,unsigned int,unsigned int)
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, uint i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, uint, uint, void>)0x004CD350)(ref this, i_ePanelID, i_bVisible);
    // void __thiscall gmEnvPanelUI::gmEnvPanelUI(gmEnvPanelUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004CD540)(ref this, layout, full_desc);
    // UIElement* __thiscall gmEnvPanelUI::DynamicCast(gmEnvPanelUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, uint, ACBindings.UIElement*>)0x004CD5A0)(ref this, i_eType);
    // unsigned int __thiscall gmEnvPanelUI::GetUIElementType(gmEnvPanelUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, uint>)0x004CD5C0)(ref this);
    // UIElement* __cdecl gmEnvPanelUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004CD5D0)(layout, full_desc);
    // void __thiscall gmEnvPanelUI::~gmEnvPanelUI(gmEnvPanelUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, void>)0x004CD600)(ref this);
    // void __cdecl gmEnvPanelUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CD670)();
    // void __thiscall gmEnvPanelUI::SetupChildren(gmEnvPanelUI*)
    public void SetupChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, void>)0x004CD6B0)(ref this);
    // void __thiscall gmEnvPanelUI::PostInit(gmEnvPanelUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, void>)0x004CD7F0)(ref this);
    // void __thiscall gmEnvPanelUI::RecvNotice_SetCombatMode(gmEnvPanelUI*,COMBAT_MODE)
    public void RecvNotice_SetCombatMode(ACBindings.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEnvPanelUI, ACBindings.COMBAT_MODE, void>)0x004F64D0)(ref this, i_eCombatMode);
}

