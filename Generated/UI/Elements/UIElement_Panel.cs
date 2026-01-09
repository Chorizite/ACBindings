namespace ACBindings;

// UIElement_Panel
public unsafe struct UIElement_Panel : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement BaseClass_UIElement; // ACBindings.UIElement

    // Child Types
    // UIElement_Panel_vtbl
    public unsafe struct UIElement_Panel_vtbl
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
    public ACBindings.HashTable__uint__uint m_TabPageHash;
    public ACBindings.HashTable__uint__uint m_PageTabHash;
    public uint m_OpenPageToken;
    public uint m_OpenTabToken;

    // Generated Constructor
    public UIElement_Panel(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall UIElement_Panel::InqAvailableProperties(UIElement_Panel*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, ACBindings.AvailablePropertySet*, byte>)0x0046BF60)(ref this, set);
    // void __thiscall UIElement_Panel::Update(UIElement_Panel*,unsigned int,unsigned int)
    public void Update(uint i_nNewOpenPageID, uint i_nNewOpenTabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, uint, uint, void>)0x0046BFF0)(ref this, i_nNewOpenPageID, i_nNewOpenTabID);
    // bool __thiscall UIElement_Panel::OpenTab(UIElement_Panel*,unsigned int)
    public byte OpenTab(uint tabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, uint, byte>)0x0046C110)(ref this, tabID);
    // bool __thiscall UIElement_Panel::InqTabFromPage(UIElement_Panel*,unsigned int,unsigned int*)
    public byte InqTabFromPage(uint pageToken, uint* tabToken) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, uint, uint*, byte>)0x0046C1A0)(ref this, pageToken, tabToken);
    // UIElementMessageListenResult __thiscall UIElement_Panel::ListenToElementMessage(UIElement_Panel*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0046C370)(ref this, i_rMsg);
    // void __thiscall UIElement_Panel::UIElement_Panel(UIElement_Panel*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0046C550)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_Panel::DynamicCast(UIElement_Panel*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, uint, ACBindings.UIElement*>)0x0046C5B0)(ref this, i_eType);
    // void __thiscall UIElement_Panel::~UIElement_Panel(UIElement_Panel*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, void>)0x0046C5D0)(ref this);
    // UIElement* __cdecl UIElement_Panel::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046C690)(layout, full_desc);
    // void __thiscall UIElement_Panel::SetupTabPageHash(UIElement_Panel*)
    public void SetupTabPageHash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, void>)0x0046C6C0)(ref this);
    // void __cdecl UIElement_Panel::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0046CA90)();
    // void __thiscall UIElement_Panel::OnSetAttribute(UIElement_Panel*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Panel, ACBindings.BaseProperty*, void>)0x0046CAA0)(ref this, attribute);
}

