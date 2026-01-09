namespace ACBindings;

// gmCGSummaryPage
public unsafe struct gmCGSummaryPage
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCGSummaryPage_vtbl
    public unsafe struct gmCGSummaryPage_vtbl
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
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.UIElement_ListBox* m_pSummaryListbix;
    public ACBindings.UIElement_Text* m_pNameText;
    public ACBindings.UIElement_Text* m_pHowToText;
    public ACBindings.UIElement_Scrollbar* m_pScoll;
    public ACBindings.UIElement_Viewport* m_pViewport;
    public ACBindings.gmCG3DView* m_p3DView;
    public byte m_bNameEntered;
    public uint m_uiErrorMessageContext;

    // Generated Constructor
    public gmCGSummaryPage(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmCGSummaryPage::gmCGSummaryPage(gmCGSummaryPage*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0047B030)(ref this, layout, full_desc);
    // UIElement* __thiscall gmCGSummaryPage::DynamicCast(gmCGSummaryPage*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, uint, ACBindings.UIElement*>)0x0047B0A0)(ref this, i_eType);
    // unsigned int __thiscall gmCGSummaryPage::GetUIElementType(gmCGSummaryPage*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, uint>)0x0047B0C0)(ref this);
    // void __thiscall gmCGSummaryPage::PostInit(gmCGSummaryPage*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, void>)0x0047B0D0)(ref this);
    // UIElement* __cdecl gmCGSummaryPage::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0047B110)(layout, full_desc);
    // void __thiscall gmCGSummaryPage::RecvNotice_CloseDialog(gmCGSummaryPage*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, uint, ACBindings.PropertyCollection*, void>)0x0047B140)(ref this, context, data);
    // void __thiscall gmCGSummaryPage::SetHowToText(gmCGSummaryPage*)
    public void SetHowToText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, void>)0x0047B1E0)(ref this);
    // void __thiscall gmCGSummaryPage::SetSummaryText(gmCGSummaryPage*)
    public void SetSummaryText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, void>)0x0047B590)(ref this);
    // void __thiscall gmCGSummaryPage::Update(gmCGSummaryPage*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, void>)0x0047BE60)(ref this);
    // void __thiscall gmCGSummaryPage::InitializePage(gmCGSummaryPage*,gmCharGenMainUI*)
    public void InitializePage(ACBindings.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, ACBindings.gmCharGenMainUI*, void>)0x0047BFB0)(ref this, pMain);
    // void __thiscall gmCGSummaryPage::DoNameLimitDialog(gmCGSummaryPage*)
    public void DoNameLimitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, void>)0x0047C140)(ref this);
    // UIElementMessageListenResult __thiscall gmCGSummaryPage::ListenToElementMessage(gmCGSummaryPage*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGSummaryPage, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0047C300)(ref this, i_rMsg);
}

