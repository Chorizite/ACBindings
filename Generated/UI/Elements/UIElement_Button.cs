namespace ACBindings;

// UIElement_Button
public unsafe struct UIElement_Button : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Text BaseClass_UIElement_Text; // ACBindings.UIElement_Text

    // Child Types
    // UIElement_Button_vtbl
    public unsafe struct UIElement_Button_vtbl
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
    public byte mousePressedOnButton;
    public byte hotClickingInProgress;
    public double nextHotClickTime;

    // Generated Constructor
    public UIElement_Button(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIElement_Button::UIElement_Button(UIElement_Button*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00471F10)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_Button::DynamicCast(UIElement_Button*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, uint, ACBindings.UIElement*>)0x00471F60)(ref this, i_eType);
    // void __thiscall UIElement_Button::~UIElement_Button(UIElement_Button*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, void>)0x00471F80)(ref this);
    // UIElement* __cdecl UIElement_Button::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00471FC0)(layout, full_desc);
    // void __thiscall UIElement_Button::ListenToGlobalMessage(UIElement_Button*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, uint, int, void>)0x00472020)(ref this, messageID, data_int);
    // void __thiscall UIElement_Button::UpdateState_(UIElement_Button*)
    public void UpdateState_() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, void>)0x004720B0)(ref this);
    // bool __thiscall UIElement_Button::SetState(UIElement_Button*,unsigned int)
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, uint, byte>)0x00472160)(ref this, state);
    // bool __thiscall UIElement_Button::HandleButtonClick(UIElement_Button*,const UIElementMessageInfo*)
    public byte HandleButtonClick(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, ACBindings.UIElementMessageInfo*, byte>)0x00472210)(ref this, i_rMsg);
    // void __cdecl UIElement_Button::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004722E0)();
    // void __thiscall UIElement_Button::PostInit(UIElement_Button*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, void>)0x004722F0)(ref this);
    // void __thiscall UIElement_Button::OnSetAttribute(UIElement_Button*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, ACBindings.BaseProperty*, void>)0x00472300)(ref this, attribute);
    // void __thiscall UIElement_Button::MouseDown(UIElement_Button*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, uint, uint, uint, void>)0x004723B0)(ref this, xWindow, yWindow, button);
    // void __thiscall UIElement_Button::MouseUp(UIElement_Button*,unsigned int,unsigned int,unsigned int)
    public void MouseUp(uint xElement, uint yElement, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, uint, uint, uint, void>)0x004724A0)(ref this, xElement, yElement, button);
    // void __thiscall UIElement_Button::MouseOverTop(UIElement_Button*,bool)
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, byte, void>)0x004725B0)(ref this, overTop);
    // UIElementMessageListenResult __thiscall UIElement_Button::ListenToElementMessage(UIElement_Button*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004725D0)(ref this, i_rMsg);
    // bool __thiscall UIElement_Button::InqAvailableProperties(UIElement_Button*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Button, ACBindings.AvailablePropertySet*, byte>)0x00472620)(ref this, set);
}

