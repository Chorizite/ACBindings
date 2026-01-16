namespace ACBindings.Internal;


/// <summary>Extends a button element to provide menu functionality, managing a popup window that hosts a selectable list box of items.</summary>
public unsafe struct UIElement_Menu : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Button BaseClass_UIElement_Button; // ACBindings.Internal.UIElement_Button

    // Child Types
    public unsafe struct UIElement_Menu_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

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

    /// <summary>Initializes a UI menu element with the specified layout and description, setting up default state and member variables.
    /// <code>Offset: 0x0046CD70
    /// void __thiscall UIElement_Menu::UIElement_Menu(UIElement_Menu*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The layout descriptor defining visual properties for the menu.</param>
    /// <param name="full_desc">Full element description containing identifiers, types, and child elements for the menu.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046CD70)(ref this, layout, full_desc);

    /// <summary>Attempts to cast the menu element to a UIElement pointer based on a requested type ID, returning the corresponding base class pointer or null when no match exists.
    /// <code>Offset: 0x0046CDC0
    /// UIElement* __thiscall UIElement_Menu::DynamicCast(UIElement_Menu*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The element type identifier used to determine which base class pointer to return.</param>
    /// <returns>A UIElement* pointing to the appropriate base subobject if the type matches; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, uint, ACBindings.Internal.UIElement*>)0x0046CDC0)(ref this, i_eType);

    /// <summary>Creates a new UIElement_Menu instance initialized with the specified layout and element description.
    /// <code>Offset: 0x0046CDF0
    /// UIElement* __cdecl UIElement_Menu::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes the overall UI layout for which the menu is being constructed.</param>
    /// <param name="full_desc">Provides detailed properties for the menu element, including its state and child elements.</param>
    /// <returns>Pointer to the newly created menu element, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046CDF0)(layout, full_desc);

    /// <summary>Clears all entries from the menu’s internal list box if one exists.
    /// <code>Offset: 0x0046CE20
    /// void __thiscall UIElement_Menu::Flush(UIElement_Menu*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046CE20)(ref this);

    /// <summary>Retrieves the UI element located at the specified index within the menu's internal list box, returning nullptr when no list box exists.
    /// <code>Offset: 0x0046CE30
    /// UIElement* __thiscall UIElement_Menu::GetItem(UIElement_Menu*,int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position of the desired item.</param>
    /// <returns>The UIElement at that index or null if unavailable.</returns>
    public ACBindings.Internal.UIElement* GetItem(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, int, ACBindings.Internal.UIElement*>)0x0046CE30)(ref this, index);

    /// <summary>Retrieves the currently selected item from the menu's list box.
    /// <code>Offset: 0x0046CE50
    /// UIElement* __thiscall UIElement_Menu::GetSelectedItem(UIElement_Menu*)</code>
    /// </summary>
    /// <returns>Pointer to the selected UIElement, or nullptr if no list box is present or no item is selected.</returns>
    public ACBindings.Internal.UIElement* GetSelectedItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElement*>)0x0046CE50)(ref this);

    /// <summary>Inserts a UIElement into the menu’s internal ListBox at the specified position, first clearing focus on that element.
    /// <code>Offset: 0x0046CE70
    /// bool __thiscall UIElement_Menu::InsertItem(UIElement_Menu*,UIElement*,int)</code>
    /// </summary>
    /// <param name="insertThis">The UIElement to add to the menu.</param>
    /// <param name="here">Zero‑based index indicating where in the list the element should be inserted.</param>
    /// <returns>True if the element was successfully inserted; false if the ListBox is not available or insertion fails.</returns>
    public byte InsertItem(ACBindings.Internal.UIElement* insertThis, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElement*, int, byte>)0x0046CE70)(ref this, insertThis, here);

    /// <summary>Synchronizes the underlying UI element with the menu's current open state by setting the corresponding boolean attribute.
    /// <code>Offset: 0x0046CEB0
    /// void __thiscall UIElement_Menu::UpdateState(UIElement_Menu*)</code>
    /// </summary>
    public void UpdateState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046CEB0)(ref this);

    /// <summary>Recalculates the dimensions of the menu's popup element using its list box size and configured borders, then applies the new width and height to the popup.
    /// <code>Offset: 0x0046CED0
    /// void __thiscall UIElement_Menu::RecalculatePopupSize(UIElement_Menu*)</code>
    /// </summary>
    public void RecalculatePopupSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046CED0)(ref this);

    /// <summary>Associates the menu UI element type with its creation routine in the UI system.
    /// <code>Offset: 0x0046CFA0
    /// void __cdecl UIElement_Menu::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0046CFA0)();

    /// <summary>Retrieves the current item count from the menu's internal list box, returning zero when the list is absent.
    /// <code>Offset: 0x0046CFB0
    /// int __thiscall UIElement_Menu::GetNumItems(UIElement_Menu*)</code>
    /// </summary>
    /// <returns>The number of items in the menu; 0 if no ListBox exists.</returns>
    public int GetNumItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, int>)0x0046CFB0)(ref this);

    /// <summary>Retrieves the index of the selected item in the menu's list box, returning -1 if the list is missing, empty, or has no selection.
    /// <code>Offset: 0x0046CFD0
    /// int __thiscall UIElement_Menu::GetSelectedIndex(UIElement_Menu*)</code>
    /// </summary>
    /// <returns>The zero‑based index of the selected item, or –1 when none exists.</returns>
    public int GetSelectedIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, int>)0x0046CFD0)(ref this);

    /// <summary>Opens the menu’s popup element if it is currently closed, positioning it relative to its parent based on configured attributes, marking the menu as open and broadcasting an open event.
    /// <code>Offset: 0x0046D010
    /// void __thiscall UIElement_Menu::Open(UIElement_Menu*)</code>
    /// </summary>
    public void Open() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D010)(ref this);

    /// <summary>Closes the menu if it is currently open by destroying its popup element and updating the menu’s internal state.
    /// <code>Offset: 0x0046D100
    /// void __thiscall UIElement_Menu::Close(UIElement_Menu*)</code>
    /// </summary>
    public void Close() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D100)(ref this);

    /// <summary>Updates the linked text element with the currently selected item's label and optionally broadcasts a selection change event.
    /// <code>Offset: 0x0046D140
    /// void __thiscall UIElement_Menu::NewSelection(UIElement_Menu*,bool)</code>
    /// </summary>
    /// <param name="broadcast">If true, sends a broadcast message to notify listeners of the new selection.</param>
    public void NewSelection(byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, byte, void>)0x0046D140)(ref this, broadcast);

    /// <summary>Releases the menu's popup element, unregisters message listeners, closes an active popup if open, broadcasts a close notification, and performs cleanup of internal UI components.
    /// <code>Offset: 0x0046D220
    /// void __thiscall UIElement_Menu::~UIElement_Menu(UIElement_Menu*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D220)(ref this);

    /// <summary>Collects all UI‑exposable properties for a menu element by combining inherited properties with those defined in its own property group.
    /// <code>Offset: 0x0046D2A0
    /// bool __thiscall UIElement_Menu::InqAvailableProperties(UIElement_Menu*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The property set to receive the results; may be null, in which case the function fails and returns false.</param>
    /// <returns>True when both the base class query and the menu‑specific property‑group query succeed; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046D2A0)(ref this, set);

    /// <summary>Inserts a new menu item displaying the supplied string at the requested position.
    /// <code>Offset: 0x0046D2F0
    /// UIElement_Text* __thiscall UIElement_Menu::InsertTextItem(UIElement_Menu*,const StringInfo*,int)</code>
    /// </summary>
    /// <param name="text">String data used to populate the item's label.</param>
    /// <param name="here">Index within the menu where the new item should be inserted.</param>
    /// <returns>Pointer to the created UIElement_Text on success; null if creation or insertion fails.</returns>
    public ACBindings.Internal.UIElement_Text* InsertTextItem(ACBindings.Internal.StringInfo* text, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.StringInfo*, int, ACBindings.Internal.UIElement_Text*>)0x0046D2F0)(ref this, text, here);

    /// <summary>Replaces the menu entry at a given index with new text, deleting any existing item and preserving its selection status if it was already selected.
    /// <code>Offset: 0x0046D420
    /// UIElement_Text* __thiscall UIElement_Menu::ReplaceTextItem(UIElement_Menu*,const StringInfo*,int)</code>
    /// </summary>
    /// <param name="text">Text data for the new menu item.</param>
    /// <param name="here">Zero-based position of the item to replace; if no item exists at that index, a new one is inserted.</param>
    /// <returns>Pointer to the newly inserted UIElement_Text instance.</returns>
    public ACBindings.Internal.UIElement_Text* ReplaceTextItem(ACBindings.Internal.StringInfo* text, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.StringInfo*, int, ACBindings.Internal.UIElement_Text*>)0x0046D420)(ref this, text, here);

    /// <summary>Sets the selected item in the menu’s list box and triggers any related selection handling.
    /// <code>Offset: 0x0046D4B0
    /// void __thiscall UIElement_Menu::SetSelectedItem(UIElement_Menu*,UIElement*,bool)</code>
    /// </summary>
    /// <param name="select">The UI element to mark as selected.</param>
    /// <param name="broadcast">If true, broadcasts the selection change to listeners.</param>
    public void SetSelectedItem(ACBindings.Internal.UIElement* select, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElement*, byte, void>)0x0046D4B0)(ref this, select, broadcast);

    /// <summary>Sets the visibility of the menu element. When the menu is made invisible while it is currently open, it automatically closes.
    /// <code>Offset: 0x0046D4E0
    /// void __thiscall UIElement_Menu::SetVisible(UIElement_Menu*,bool)</code>
    /// </summary>
    /// <param name="visible">True to make the menu visible; false to hide it.</param>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, byte, void>)0x0046D4E0)(ref this, visible);

    /// <summary>Deactivates the menu element, closing its popup if currently open and updating internal state.
    /// <code>Offset: 0x0046D510
    /// bool __thiscall UIElement_Menu::Deactivate(UIElement_Menu*)</code>
    /// </summary>
    /// <returns>True if the base deactivation succeeded; otherwise false.</returns>
    public byte Deactivate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, byte>)0x0046D510)(ref this);

    /// <summary>Handles messages sent to a menu UI element, managing its open/close state, updating selections in the associated listbox, recalculating popup size, and forwarding unhandled events to the underlying button implementation.
    /// <code>Offset: 0x0046D560
    /// UIElementMessageListenResult __thiscall UIElement_Menu::ListenToElementMessage(UIElement_Menu*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information, including source element, message ID, and additional parameters that dictate how the menu should react.</param>
    /// <returns>UIElementMessageListenResult value indicating that the message has been processed.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0046D560)(ref this, i_rMsg);

    /// <summary>Replaces the menu’s current popup with a new UI element loaded from a layout descriptor; removes any existing popup before creating and registering the new one.
    /// <code>Offset: 0x0046D6F0
    /// void __thiscall UIElement_Menu::MakePopup(UIElement_Menu*)</code>
    /// </summary>
    public void MakePopup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D6F0)(ref this);

    /// <summary>Adds a new menu entry by inserting a text item at the end of the list box using the supplied StringInfo and returns the created UIElement_Text.
    /// <code>Offset: 0x0046D800
    /// UIElement_Text* __thiscall UIElement_Menu::AddTextItem(UIElement_Menu*,const StringInfo*)</code>
    /// </summary>
    /// <param name="text">The string information defining the content and properties of the new menu item.</param>
    /// <returns>Pointer to the newly inserted UIElement_Text representing the menu entry.</returns>
    public ACBindings.Internal.UIElement_Text* AddTextItem(ACBindings.Internal.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, ACBindings.Internal.StringInfo*, ACBindings.Internal.UIElement_Text*>)0x0046D800)(ref this, text);

    /// <summary>Initializes a menu element by creating its popup interface, locating and configuring the embedded list box based on attributes, setting an initial selection if specified, then computing horizontal and vertical borders between the popup and list box for layout purposes.
    /// <code>Offset: 0x0046D820
    /// void __thiscall UIElement_Menu::Initialize(UIElement_Menu*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, void>)0x0046D820)(ref this);

    /// <summary>Returns the numeric identifier for this UI element’s type, indicating it is a menu.
    /// <code>Offset: 0x00527440
    /// unsigned int __thiscall UIElement_Menu::GetUIElementType(CGfxObj*)</code>
    /// </summary>
    /// <returns>An unsigned integer value of 6 that represents the menu type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Menu, uint>)0x00527440)(ref this);
}

