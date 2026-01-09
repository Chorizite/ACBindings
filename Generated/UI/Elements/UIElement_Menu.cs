namespace ACBindings;

// UIElement_Menu
public unsafe struct UIElement_Menu : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Button BaseClass_UIElement_Button; // ACBindings.UIElement_Button

    // Child Types
    // UIElement_Menu_vtbl
    public unsafe struct UIElement_Menu_vtbl
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
    public ACBindings.UIElement* m_popup;
    public ACBindings.UIElement_ListBox* m_listBox;
    public byte m_open;
    public uint m_uiListBoxXBorder;
    public uint m_uiListBoxYBorder;

    // Generated Constructor
    public UIElement_Menu(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIElement_Menu::UIElement_Menu(UIElement_Menu*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0046CD70)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_Menu::DynamicCast(UIElement_Menu*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, uint, ACBindings.UIElement*>)0x0046CDC0)(ref this, i_eType);
    // UIElement* __cdecl UIElement_Menu::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0046CDF0)(layout, full_desc);
    // void __thiscall UIElement_Menu::Flush(UIElement_Menu*)
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046CE20)(ref this);
    // UIElement* __thiscall UIElement_Menu::GetItem(UIElement_Menu*,int)
    public ACBindings.UIElement* GetItem(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, int, ACBindings.UIElement*>)0x0046CE30)(ref this, index);
    // UIElement* __thiscall UIElement_Menu::GetSelectedItem(UIElement_Menu*)
    public ACBindings.UIElement* GetSelectedItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.UIElement*>)0x0046CE50)(ref this);
    // bool __thiscall UIElement_Menu::InsertItem(UIElement_Menu*,UIElement*,int)
    public byte InsertItem(ACBindings.UIElement* insertThis, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.UIElement*, int, byte>)0x0046CE70)(ref this, insertThis, here);
    // void __thiscall UIElement_Menu::UpdateState(UIElement_Menu*)
    public void UpdateState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046CEB0)(ref this);
    // void __thiscall UIElement_Menu::RecalculatePopupSize(UIElement_Menu*)
    public void RecalculatePopupSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046CED0)(ref this);
    // void __cdecl UIElement_Menu::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0046CFA0)();
    // int __thiscall UIElement_Menu::GetNumItems(UIElement_Menu*)
    public int GetNumItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, int>)0x0046CFB0)(ref this);
    // int __thiscall UIElement_Menu::GetSelectedIndex(UIElement_Menu*)
    public int GetSelectedIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, int>)0x0046CFD0)(ref this);
    // void __thiscall UIElement_Menu::Open(UIElement_Menu*)
    public void Open() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046D010)(ref this);
    // void __thiscall UIElement_Menu::Close(UIElement_Menu*)
    public void Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046D100)(ref this);
    // void __thiscall UIElement_Menu::NewSelection(UIElement_Menu*,bool)
    public void NewSelection(byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, byte, void>)0x0046D140)(ref this, broadcast);
    // void __thiscall UIElement_Menu::~UIElement_Menu(UIElement_Menu*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046D220)(ref this);
    // bool __thiscall UIElement_Menu::InqAvailableProperties(UIElement_Menu*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.AvailablePropertySet*, byte>)0x0046D2A0)(ref this, set);
    // UIElement_Text* __thiscall UIElement_Menu::InsertTextItem(UIElement_Menu*,const StringInfo*,int)
    public ACBindings.UIElement_Text* InsertTextItem(ACBindings.StringInfo* text, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.StringInfo*, int, ACBindings.UIElement_Text*>)0x0046D2F0)(ref this, text, here);
    // UIElement_Text* __thiscall UIElement_Menu::ReplaceTextItem(UIElement_Menu*,const StringInfo*,int)
    public ACBindings.UIElement_Text* ReplaceTextItem(ACBindings.StringInfo* text, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.StringInfo*, int, ACBindings.UIElement_Text*>)0x0046D420)(ref this, text, here);
    // void __thiscall UIElement_Menu::SetSelectedItem(UIElement_Menu*,UIElement*,bool)
    public void SetSelectedItem(ACBindings.UIElement* select, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.UIElement*, byte, void>)0x0046D4B0)(ref this, select, broadcast);
    // void __thiscall UIElement_Menu::SetVisible(UIElement_Menu*,bool)
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, byte, void>)0x0046D4E0)(ref this, visible);
    // bool __thiscall UIElement_Menu::Deactivate(UIElement_Menu*)
    public byte Deactivate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, byte>)0x0046D510)(ref this);
    // UIElementMessageListenResult __thiscall UIElement_Menu::ListenToElementMessage(UIElement_Menu*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0046D560)(ref this, i_rMsg);
    // void __thiscall UIElement_Menu::MakePopup(UIElement_Menu*)
    public void MakePopup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046D6F0)(ref this);
    // UIElement_Text* __thiscall UIElement_Menu::AddTextItem(UIElement_Menu*,const StringInfo*)
    public ACBindings.UIElement_Text* AddTextItem(ACBindings.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, ACBindings.StringInfo*, ACBindings.UIElement_Text*>)0x0046D800)(ref this, text);
    // void __thiscall UIElement_Menu::Initialize(UIElement_Menu*)
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, void>)0x0046D820)(ref this);
    // unsigned int __thiscall UIElement_Menu::GetUIElementType(CGfxObj*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Menu, uint>)0x00527440)(ref this);
}

