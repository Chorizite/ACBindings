namespace ACBindings;

// UIElement_Browser
public unsafe struct UIElement_Browser
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement
    public ACBindings.IAlternateDCProvider BaseClass_IAlternateDCProvider; // ACBindings.IAlternateDCProvider
    public ACBindings.IBrowserCallback BaseClass_IBrowserCallback; // ACBindings.IBrowserCallback

    // Statics
    public static uint* sm_cVisibleWindows = (uint*)0x0083E40C;

    // Child Types
    // UIElement_Browser_vtbl
    public unsafe struct UIElement_Browser_vtbl
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
    public ACBindings.IBrowserControl* m_pWebBrowser;
    public byte m_fFullScreen;
    public byte m_fLastTrueVisibility;
    public byte m_fAllowFullscreenBrowser;

    // Generated Constructor
    public UIElement_Browser(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall UIElement_Browser::UIElement_Browser(UIElement_Browser*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0046B5B0)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_Browser::DynamicCast(UIElement_Browser*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, uint, ACBindings.UIElement*>)0x0046B650)(ref this, i_eType);
    // UIElement* __cdecl UIElement_Browser::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046B670)(layout, full_desc);
    // void __thiscall UIElement_Browser::SetVisible(UIElement_Browser*,bool)
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, byte, void>)0x0046B6A0)(ref this, visible);
    // void __thiscall UIElement_Browser::UpdateForScreenPositionChange(UIElement_Browser*)
    public void UpdateForScreenPositionChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, void>)0x0046B720)(ref this);
    // void __thiscall UIElement_Browser::PostBlit(UIElement_Browser*,const Box2D*,UISurface*)
    public void PostBlit(ACBindings.Box2D* i_boxDest, ACBindings.UISurface* i_pTargetSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, ACBindings.Box2D*, ACBindings.UISurface*, void>)0x0046B760)(ref this, i_boxDest, i_pTargetSurface);
    // bool __thiscall UIElement_Browser::CreateWindowHelper(UIElement_Browser*)
    public byte CreateWindowHelper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, byte>)0x0046B790)(ref this);
    // bool __thiscall UIElement_Browser::ReleaseDC(UIElement_Browser*,HDC__*,int*)
    public byte ReleaseDC(System.IntPtr i_hdc, int* o_iResult) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, System.IntPtr, int*, byte>)0x0046B830)(ref this, i_hdc, o_iResult);
    // void __thiscall UIElement_Browser::Initialize(UIElement_Browser*)
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, void>)0x0046B8D0)(ref this);
    // void __thiscall UIElement_Browser::ResizeTo(UIElement_Browser*,const int,const int)
    public void ResizeTo(int cx, int cy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, int, int, void>)0x0046B8F0)(ref this, cx, cy);
    // bool __thiscall UIElement_Browser::InqAvailableProperties(UIElement_Browser*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* o_set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, ACBindings.AvailablePropertySet*, byte>)0x0046B940)(ref this, o_set);
    // void __thiscall UIElement_Browser::OnSetAttribute(UIElement_Browser*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* i_attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Browser, ACBindings.BaseProperty*, void>)0x0046B990)(ref this, i_attribute);
}

