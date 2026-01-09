namespace ACBindings;

// gmCGHeritagePage
public unsafe struct gmCGHeritagePage
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCGHeritagePage_vtbl
    public unsafe struct gmCGHeritagePage_vtbl
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
    public ACBindings.UIElement_Button* m_pAluButton;
    public ACBindings.UIElement_Button* m_pGhuButton;
    public ACBindings.UIElement_Button* m_pShoButton;
    public ACBindings.UIElement_Button* m_pViaButton;
    public ACBindings.UIElement_Button* m_pShadButton;
    public ACBindings.UIElement_Button* m_pPenButton;
    public ACBindings.UIElement_Button* m_pGearButton;
    public ACBindings.UIElement_Button* m_pUndButton;
    public ACBindings.UIElement_Button* m_pEmpButton;
    public ACBindings.UIElement_Button* m_pAunTButton;
    public ACBindings.UIElement_Button* m_pLugButton;
    public ACBindings.UIElement_Button* m_pOlthoiButton;
    public ACBindings.UIElement_Button* m_pOlthoiAcidButton;
    public ACBindings.UIElement_Text* m_pText;
    public ACBindings.UIElement* m_pBackground;

    // Methods
    // UIElement* __thiscall gmCGHeritagePage::DynamicCast(gmCGHeritagePage*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGHeritagePage, uint, ACBindings.UIElement*>)0x004834F0)(ref this, i_eType);
    // void __cdecl gmCGHeritagePage::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004835B0)();
    // void __thiscall gmCGHeritagePage::Update(gmCGHeritagePage*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGHeritagePage, void>)0x004835D0)(ref this);
    // UIElementMessageListenResult __thiscall gmCGHeritagePage::ListenToElementMessage(gmCGHeritagePage*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGHeritagePage, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00483C20)(ref this, i_rMsg);
    // void __thiscall gmCGHeritagePage::InitializePage(gmCGHeritagePage*,gmCharGenMainUI*)
    public void InitializePage(ACBindings.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGHeritagePage, ACBindings.gmCharGenMainUI*, void>)0x00483DD0)(ref this, pMain);
}

