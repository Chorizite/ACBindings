namespace ACBindings;

// UIElement_Scrollable
public unsafe struct UIElement_Scrollable
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement

    // Child Types
    // UIElement_Scrollable_vtbl
    public unsafe struct UIElement_Scrollable_vtbl
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
        public System.IntPtr AdjustToScrollableXYChange; // function pointer
        public System.IntPtr InqScrollDelta; // function pointer

        // Methods
    }

    // Members
    public uint m_eHorizonalScrollbarID;
    public uint m_eVerticalScrollbarID;
    public int m_iScrollableX;
    public int m_iScrollableY;
    public int m_iScrollableWidth;
    public int m_iScrollableHeight;

    // Generated Constructor
    public UIElement_Scrollable(ACBindings.LayoutDesc* i_rcLayout, ACBindings.ElementDesc* i_rcFullDesc) {
        _ConstructorInternal(i_rcLayout, i_rcFullDesc);
    }

    // Methods
    // void __thiscall UIElement_Scrollable::UIElement_Scrollable(UIElement_Scrollable*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* i_rcLayout, ACBindings.ElementDesc* i_rcFullDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00474150)(ref this, i_rcLayout, i_rcFullDesc);
    // UIElement* __thiscall UIElement_Scrollable::DynamicCast(UIElement_Scrollable*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, uint, ACBindings.UIElement*>)0x004741A0)(ref this, i_eType);
    // void __thiscall UIElement_Scrollable::MouseDown(UIElement_Scrollable*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint i_xWindow, uint i_yWindow, uint i_eButton) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, uint, uint, uint, void>)0x004741C0)(ref this, i_xWindow, i_yWindow, i_eButton);
    // bool __thiscall UIElement_Scrollable::RegisterInputMaps(UIElement_Scrollable*,int)
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, int, byte>)0x00474210)(ref this, i_nPriority);
    // bool __thiscall UIElement_Scrollable::UnregisterInputMaps(UIElement_Scrollable*)
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, byte>)0x00474250)(ref this);
    // UIElement_Scrollbar* __thiscall UIElement_Scrollable::GetScrollbarPointer_(UIElement_Scrollable*,bool)
    public ACBindings.UIElement_Scrollbar* GetScrollbarPointer_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, byte, ACBindings.UIElement_Scrollbar*>)0x00474280)(ref this, i_bHorizontal);
    // void __thiscall UIElement_Scrollable::UpdateScrollbarPosition_(UIElement_Scrollable*,bool)
    public void UpdateScrollbarPosition_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, byte, void>)0x004742E0)(ref this, i_bHorizontal);
    // bool __thiscall UIElement_Scrollable::InqAvailableProperties(UIElement_Scrollable*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* o_rcSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, ACBindings.AvailablePropertySet*, byte>)0x00474430)(ref this, o_rcSet);
    // void __thiscall UIElement_Scrollable::SetScrollableXY(UIElement_Scrollable*,int,int,bool)
    public void SetScrollableXY(int i_iX, int i_iY, byte i_bForce) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, int, int, byte, void>)0x00474480)(ref this, i_iX, i_iY, i_bForce);
    // void __thiscall UIElement_Scrollable::UpdateScrollbarSize_(UIElement_Scrollable*,bool)
    public void UpdateScrollbarSize_(byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, byte, void>)0x00474560)(ref this, i_bHorizontal);
    // void __thiscall UIElement_Scrollable::HandleScrollbarMessage_(UIElement_Scrollable*,bool,const unsigned int,UIElement_Scrollbar*)
    public void HandleScrollbarMessage_(byte i_bHorizontal, uint i_eMessageID, ACBindings.UIElement_Scrollbar* i_pcScrollbar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, byte, uint, ACBindings.UIElement_Scrollbar*, void>)0x00474730)(ref this, i_bHorizontal, i_eMessageID, i_pcScrollbar);
    // void __thiscall UIElement_Scrollable::PostInit(UIElement_Scrollable*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, void>)0x00474870)(ref this);
    // UIElementMessageListenResult __thiscall UIElement_Scrollable::ListenToElementMessage(UIElement_Scrollable*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00474920)(ref this, i_rMsg);
    // void __thiscall UIElement_Scrollable::OnSetAttribute(UIElement_Scrollable*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* i_rcProperty) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, ACBindings.BaseProperty*, void>)0x004749F0)(ref this, i_rcProperty);
    // void __thiscall UIElement_Scrollable::ResizeTo(UIElement_Scrollable*,const int,const int)
    public void ResizeTo(int i_iWidth, int i_iHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, int, int, void>)0x00474A80)(ref this, i_iWidth, i_iHeight);
    // void __thiscall UIElement_Scrollable::ResizeScrollableArea(UIElement_Scrollable*,int,int)
    public void ResizeScrollableArea(int i_iWidth, int i_iHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Scrollable, int, int, void>)0x00474AF0)(ref this, i_iWidth, i_iHeight);
}

