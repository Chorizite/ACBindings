namespace ACBindings.Internal;

public unsafe struct UIElement_Menu : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Button BaseClass_UIElement_Button; // ACBindings.Internal.UIElement_Button

    // Child Types
    public unsafe struct UIElement_Menu_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_popup;
    public ACBindings.Internal.UIElement_ListBox* m_listBox;
    public byte m_open;
    public uint m_uiListBoxXBorder;
    public uint m_uiListBoxYBorder;

    // Generated Constructor
    public UIElement_Menu(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0046CD70
    /// void __thiscall UIElement_Menu::UIElement_Menu(UIElement_Menu*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046CD70)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0046CDC0
    /// UIElement* __thiscall UIElement_Menu::DynamicCast(UIElement_Menu*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, uint, ACBindings.Internal.UIElement*>)0x0046CDC0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0046CDF0
    /// UIElement* __cdecl UIElement_Menu::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046CDF0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0046CE20
    /// void __thiscall UIElement_Menu::Flush(UIElement_Menu*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046CE20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046CE30
    /// UIElement* __thiscall UIElement_Menu::GetItem(UIElement_Menu*,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetItem(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, int, ACBindings.Internal.UIElement*>)0x0046CE30)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x0046CE50
    /// UIElement* __thiscall UIElement_Menu::GetSelectedItem(UIElement_Menu*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* GetSelectedItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElement*>)0x0046CE50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046CE70
    /// bool __thiscall UIElement_Menu::InsertItem(UIElement_Menu*,UIElement*,int)</code>
    /// </summary>
    public byte InsertItem(ACBindings.Internal.UIElement* insertThis, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElement*, int, byte>)0x0046CE70)(ref this, insertThis, here);

    /// <summary>
    /// <code>Offset: 0x0046CEB0
    /// void __thiscall UIElement_Menu::UpdateState(UIElement_Menu*)</code>
    /// </summary>
    public void UpdateState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046CEB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046CED0
    /// void __thiscall UIElement_Menu::RecalculatePopupSize(UIElement_Menu*)</code>
    /// </summary>
    public void RecalculatePopupSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046CED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046CFA0
    /// void __cdecl UIElement_Menu::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0046CFA0)();

    /// <summary>
    /// <code>Offset: 0x0046CFB0
    /// int __thiscall UIElement_Menu::GetNumItems(UIElement_Menu*)</code>
    /// </summary>
    public int GetNumItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, int>)0x0046CFB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046CFD0
    /// int __thiscall UIElement_Menu::GetSelectedIndex(UIElement_Menu*)</code>
    /// </summary>
    public int GetSelectedIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, int>)0x0046CFD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D010
    /// void __thiscall UIElement_Menu::Open(UIElement_Menu*)</code>
    /// </summary>
    public void Open() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D010)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D100
    /// void __thiscall UIElement_Menu::Close(UIElement_Menu*)</code>
    /// </summary>
    public void Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D100)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D140
    /// void __thiscall UIElement_Menu::NewSelection(UIElement_Menu*,bool)</code>
    /// </summary>
    public void NewSelection(byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, byte, void>)0x0046D140)(ref this, broadcast);

    /// <summary>
    /// <code>Offset: 0x0046D220
    /// void __thiscall UIElement_Menu::~UIElement_Menu(UIElement_Menu*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D220)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D2A0
    /// bool __thiscall UIElement_Menu::InqAvailableProperties(UIElement_Menu*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046D2A0)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x0046D2F0
    /// UIElement_Text* __thiscall UIElement_Menu::InsertTextItem(UIElement_Menu*,const StringInfo*,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* InsertTextItem(ACBindings.Internal.StringInfo* text, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.StringInfo*, int, ACBindings.Internal.UIElement_Text*>)0x0046D2F0)(ref this, text, here);

    /// <summary>
    /// <code>Offset: 0x0046D420
    /// UIElement_Text* __thiscall UIElement_Menu::ReplaceTextItem(UIElement_Menu*,const StringInfo*,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* ReplaceTextItem(ACBindings.Internal.StringInfo* text, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.StringInfo*, int, ACBindings.Internal.UIElement_Text*>)0x0046D420)(ref this, text, here);

    /// <summary>
    /// <code>Offset: 0x0046D4B0
    /// void __thiscall UIElement_Menu::SetSelectedItem(UIElement_Menu*,UIElement*,bool)</code>
    /// </summary>
    public void SetSelectedItem(ACBindings.Internal.UIElement* select, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElement*, byte, void>)0x0046D4B0)(ref this, select, broadcast);

    /// <summary>
    /// <code>Offset: 0x0046D4E0
    /// void __thiscall UIElement_Menu::SetVisible(UIElement_Menu*,bool)</code>
    /// </summary>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, byte, void>)0x0046D4E0)(ref this, visible);

    /// <summary>
    /// <code>Offset: 0x0046D510
    /// bool __thiscall UIElement_Menu::Deactivate(UIElement_Menu*)</code>
    /// </summary>
    public byte Deactivate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, byte>)0x0046D510)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D560
    /// UIElementMessageListenResult __thiscall UIElement_Menu::ListenToElementMessage(UIElement_Menu*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0046D560)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0046D6F0
    /// void __thiscall UIElement_Menu::MakePopup(UIElement_Menu*)</code>
    /// </summary>
    public void MakePopup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D6F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046D800
    /// UIElement_Text* __thiscall UIElement_Menu::AddTextItem(UIElement_Menu*,const StringInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_Text* AddTextItem(ACBindings.Internal.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.StringInfo*, ACBindings.Internal.UIElement_Text*>)0x0046D800)(ref this, text);

    /// <summary>
    /// <code>Offset: 0x0046D820
    /// void __thiscall UIElement_Menu::Initialize(UIElement_Menu*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527440
    /// unsigned int __thiscall UIElement_Menu::GetUIElementType(CGfxObj*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, uint>)0x00527440)(ref this);
}

