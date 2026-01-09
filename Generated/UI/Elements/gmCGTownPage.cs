namespace ACBindings;

// gmCGTownPage
public unsafe struct gmCGTownPage
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCGTownPage_vtbl
    public unsafe struct gmCGTownPage_vtbl
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
    // gmCGTownPage::ETown
    public enum ETown : byte
    {
        ECG_TOWN_INVALID = 0x0,
        ECG_TOWN_HOLTBURG = 0x1,
        ECG_TOWN_SHOUSHI = 0x2,
        ECG_TOWN_YARAQ = 0x3,
        ECG_TOWN_SANAMAR = 0x4
    }

    // Members
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.UIElement_Button* m_pSanamarButton;
    public ACBindings.UIElement_Button* m_pHoltButton;
    public ACBindings.UIElement_Button* m_pYaraqButton;
    public ACBindings.UIElement_Button* m_pShoushiButton;
    public ACBindings.UIElement_Text* m_pTextBox;
    public ACBindings.gmCGTownPage.ETown m_eCurTown;

    // Methods
    // UIElement* __thiscall gmCGTownPage::DynamicCast(gmCGTownPage*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, uint, ACBindings.UIElement*>)0x0047C490)(ref this, i_eType);
    // unsigned int __thiscall gmCGTownPage::GetUIElementType(gmCGTownPage*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, uint>)0x0047C4B0)(ref this);
    // UIElement* __cdecl gmCGTownPage::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0047C4C0)(layout, full_desc);
    // void __cdecl gmCGTownPage::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0047C580)();
    // void __thiscall gmCGTownPage::SetTownString(gmCGTownPage*,gmCGTownPage::ETown)
    public void SetTownString(ACBindings.gmCGTownPage.ETown eTown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, ACBindings.gmCGTownPage.ETown, void>)0x0047C5A0)(ref this, eTown);
    // void __thiscall gmCGTownPage::SetTown(gmCGTownPage*,gmCGTownPage::ETown)
    public void SetTown(ACBindings.gmCGTownPage.ETown eTown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, ACBindings.gmCGTownPage.ETown, void>)0x0047C710)(ref this, eTown);
    // void __thiscall gmCGTownPage::Update(gmCGTownPage*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, void>)0x0047C810)(ref this);
    // UIElementMessageListenResult __thiscall gmCGTownPage::ListenToElementMessage(gmCGTownPage*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0047C830)(ref this, i_rMsg);
    // void __thiscall gmCGTownPage::InitializePage(gmCGTownPage*,gmCharGenMainUI*)
    public void InitializePage(ACBindings.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGTownPage, ACBindings.gmCharGenMainUI*, void>)0x0047CA80)(ref this, pMain);
}

