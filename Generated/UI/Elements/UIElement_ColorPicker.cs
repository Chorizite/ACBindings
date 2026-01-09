namespace ACBindings;

// UIElement_ColorPicker
public unsafe struct UIElement_ColorPicker
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement

    // Child Types
    // UIElement_ColorPicker_vtbl
    public unsafe struct UIElement_ColorPicker_vtbl
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
    public byte m_bDisplaySelection;
    public ACBindings.RGBAColor m_rgbaCurrentSelected;
    public uint m_nCurrentSelection;

    // Generated Constructor
    public UIElement_ColorPicker(ACBindings.LayoutDesc* i_layout, ACBindings.ElementDesc* i_full_desc) {
        _ConstructorInternal(i_layout, i_full_desc);
    }

    // Methods
    // void __thiscall UIElement_ColorPicker::UIElement_ColorPicker(UIElement_ColorPicker*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* i_layout, ACBindings.ElementDesc* i_full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0046B0C0)(ref this, i_layout, i_full_desc);
    // UIElement* __thiscall UIElement_ColorPicker::DynamicCast(UIElement_ColorPicker*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, uint, ACBindings.UIElement*>)0x0046B120)(ref this, i_eType);
    // UIElement* __cdecl UIElement_ColorPicker::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046B140)(layout, full_desc);
    // bool __thiscall UIElement_ColorPicker::SetCurrentSelectedColor(UIElement_ColorPicker*,const RGBAColor*)
    public byte SetCurrentSelectedColor(ACBindings.RGBAColor* i_rgba) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.RGBAColor*, byte>)0x0046B170)(ref this, i_rgba);
    // bool __thiscall UIElement_ColorPicker::IndexToRGBA(UIElement_ColorPicker*,const unsigned int*,RGBAColor*)
    public byte IndexToRGBA(uint* i_index, ACBindings.RGBAColor* o_rgbaVal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, uint*, ACBindings.RGBAColor*, byte>)0x0046B220)(ref this, i_index, o_rgbaVal);
    // void __thiscall UIElement_ColorPicker::HandleMouseClick(UIElement_ColorPicker*,const tagPOINT*)
    public void HandleMouseClick(ACBindings.tagPOINT* i_ptElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.tagPOINT*, void>)0x0046B280)(ref this, i_ptElement);
    // bool __thiscall UIElement_ColorPicker::GetShouldBeMouseVisible(UIElement_ColorPicker*)
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, byte>)0x0046B300)(ref this);
    // void __thiscall UIElement_ColorPicker::DrawSelf(_DWORD*,Box2D*,int,_DWORD*,UISurface*)
    public void DrawSelf(ACBindings.Box2D* a2, int a3, int* a4, ACBindings.UISurface* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.Box2D*, int, int*, ACBindings.UISurface*, void>)0x0046B320)(ref this, a2, a3, a4, a5);
    // void __thiscall UIElement_ColorPicker::OnSetAttribute(UIElement_ColorPicker*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* i_attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.BaseProperty*, void>)0x0046B440)(ref this, i_attribute);
    // UIElementMessageListenResult __thiscall UIElement_ColorPicker::ListenToElementMessage(UIElement_ColorPicker*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0046B4E0)(ref this, i_rMsg);
    // bool __thiscall UIElement_ColorPicker::InqAvailableProperties(UIElement_ColorPicker*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* o_set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ColorPicker, ACBindings.AvailablePropertySet*, byte>)0x0046B510)(ref this, o_set);
}

