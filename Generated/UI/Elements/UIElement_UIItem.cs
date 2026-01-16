namespace ACBindings.Internal;


/// <summary>Represents an interactive UI element that displays items or spells within the game’s inventory system, managing icon rendering, state transitions, and user interactions such as dragging and shortcut assignment.</summary>
public unsafe struct UIElement_UIItem
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIElement_UIItem_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_UIItem*, void> DoHeartbeat; // function pointer

        // Methods
    }

    // Members
    public uint itemID;
    public uint spellID;
    public int containerDisplay;
    public ACBindings.Internal.ACCWeenieObject* weenObj;
    public uint effects;
    public int waiting;
    public int selected;
    public int isOpenable;
    public int isContainer;
    public int isContainerHolder;
    public int valid;
    public int dragOverState;
    public int unghostable;
    public int isSlot;
    public int shortcutState;
    public int m_sellState;
    public int m_tradeState;
    public byte m_selectable;
    public int m_shortcutNum;
    public int m_delayedShortcutNum;
    public byte m_shortcutGhosted;
    public int m_quantity;
    public int openState;
    public double m_heartbeatInterval;
    public double m_lastHeartbeat;
    public ACBindings.Internal.UIElement* m_elem_Icon;
    public ACBindings.Internal.UIElement* m_elem_Icon_Overlays;
    public ACBindings.Internal.UIElement* m_elem_Icon_Selected;
    public ACBindings.Internal.UIElement* m_elem_Icon_Ghosted;
    public ACBindings.Internal.UIElement* m_elem_Icon_ShortcutNum;
    public ACBindings.Internal.UIElement* m_elem_Icon_SellState;
    public ACBindings.Internal.UIElement* m_elem_Icon_TradeState;
    public ACBindings.Internal.UIElement* m_elem_Icon_OpenContainer;
    public ACBindings.Internal.UIElement* m_elem_Icon_DragAccept;
    public ACBindings.Internal.UIElement_Meter* m_elem_Icon_CapacityBar;
    public ACBindings.Internal.UIElement_Meter* m_elem_Icon_StructureBar;
    public ACBindings.Internal.UIElement_Text* m_elem_Icon_Quantity;
    public ACBindings.Internal.UIElement_Text* m_elem_Text;
    public ACBindings.Internal.UIElement* m_dragIcon;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_10;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_20;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_30;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_40;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_50;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_60;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_70;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_80;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_90;
    public ACBindings.Internal.UIElement* m_elem_Icon_Cooldown_100;

    // Generated Constructor
    public UIElement_UIItem(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes a UI item element with the provided layout and element description, setting up base classes, event handlers, and default state fields.
    /// <code>Offset: 0x004E1BD0
    /// void __thiscall UIElement_UIItem::UIElement_UIItem(UIElement_UIItem*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing size and child elements for this UI item.</param>
    /// <param name="full_desc">Full element description defining visual states and properties of the UI item.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004E1BD0)(ref this, layout, full_desc);

    /// <summary>Attempts to cast the current UIElement_UIItem instance to a specified UIElement type based on an integer type identifier. Returns a pointer to the appropriate UIElement subobject or nullptr if the requested type is unsupported.
    /// <code>Offset: 0x004E1D40
    /// UIElement* __thiscall UIElement_UIItem::DynamicCast(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Numeric identifier of the desired UIElement type; for example, 3 represents UIElement_UIItem itself and 268435506 represents its base UIElement class.</param>
    /// <returns>Pointer to the requested UIElement representation, or nullptr when the cast fails.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, ACBindings.Internal.UIElement*>)0x004E1D40)(ref this, i_eType);

    /// <summary>Retrieves the numeric identifier that represents the type of this UI item.
    /// <code>Offset: 0x004E1D60
    /// unsigned int __thiscall UIElement_UIItem::GetUIElementType(UIElement_UIItem*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant identifying the UI element type (currently 268435506).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint>)0x004E1D60)(ref this);

    /// <summary>Creates a new UIElement_UIItem instance using the specified layout description and element descriptor.
    /// <code>Offset: 0x004E1D70
    /// UIElement* __cdecl UIElement_UIItem::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information for the UI element.</param>
    /// <param name="full_desc">Detailed element descriptor used to initialize the item.</param>
    /// <returns>Pointer to the constructed UIElement, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004E1D70)(layout, full_desc);

    /// <summary>Initializes the UI item with the specified identifier and container visibility settings, resetting associated spell and object references.
    /// <code>Offset: 0x004E1DA0
    /// void __thiscall UIElement_UIItem::Init_UIItem(UIElement_UIItem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="itemID">Unique identifier of the item represented by this UI element.</param>
    /// <param name="containerDisplay">Flag indicating whether the item's container should be displayed.</param>
    public void Init_UIItem(uint itemID, int containerDisplay) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, int, void>)0x004E1DA0)(ref this, itemID, containerDisplay);

    /// <summary>Sets up a UI item to represent a spell shortcut by clearing its item ID and container state, storing the supplied spell identifier, and resetting any linked weenie object.
    /// <code>Offset: 0x004E1DD0
    /// void __thiscall UIElement_UIItem::Init_UIItem_Spell_Shortcut(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell that will be displayed in the UI slot.</param>
    public void Init_UIItem_Spell_Shortcut(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, void>)0x004E1DD0)(ref this, spellID);

    /// <summary>Resets the UI item to an empty state, clearing identifiers and object references.
    /// <code>Offset: 0x004E1E00
    /// void __thiscall UIElement_UIItem::Clear_UIItem(UIElement_UIItem*)</code>
    /// </summary>
    public void Clear_UIItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E1E00)(ref this);

    /// <summary>Retrieves the state of the item’s icon element, returning 0 when the icon is absent.
    /// <code>Offset: 0x004E1E20
    /// unsigned int __thiscall UIElement_UIItem::UIItem_GetState(UIElement_UIItem*)</code>
    /// </summary>
    /// <returns>The current state value of the icon element, or zero if no icon exists.</returns>
    public uint UIItem_GetState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint>)0x004E1E20)(ref this);

    /// <summary>Sets the waiting status of the UI item’s underlying game object and updates its ghosted icon when applicable.
    /// <code>Offset: 0x004E1E40
    /// void __thiscall UIElement_UIItem::SetWaitingState(UIElement_UIItem*,int)</code>
    /// </summary>
    /// <param name="waiting">Non‑zero to enable waiting; zero to disable.</param>
    public void SetWaitingState(int waiting) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1E40)(ref this, waiting);

    /// <summary>Sets the visibility of the icon that indicates an open container.
    /// <code>Offset: 0x004E1E90
    /// void __thiscall UIElement_UIItem::SetOpenContainerState(UIElement_UIItem*,bool)</code>
    /// </summary>
    /// <param name="open">If true, the icon is made visible; if false, it is hidden.</param>
    public void SetOpenContainerState(byte open) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, byte, void>)0x004E1E90)(ref this, open);

    /// <summary>Assigns a delayed shortcut number to this UI element.
    /// <code>Offset: 0x004E1EC0
    /// void __thiscall UIElement_UIItem::SetDelayedShortcutNum(UIElement_UIItem*,int)</code>
    /// </summary>
    /// <param name="shortcutNum">The shortcut number to set for delayed execution.</param>
    public void SetDelayedShortcutNum(int shortcutNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1EC0)(ref this, shortcutNum);

    /// <summary>Sets the item's selected status and updates its visual selection indicator when applicable.
    /// <code>Offset: 0x004E1ED0
    /// void __thiscall UIElement_UIItem::SetSelectedState(UIElement_UIItem*,int)</code>
    /// </summary>
    /// <param name="selected">Non‑zero to select the item; zero to deselect it.</param>
    public void SetSelectedState(int selected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1ED0)(ref this, selected);

    /// <summary>Sets whether the UI element item can be selected by the user.
    /// <code>Offset: 0x004E1F10
    /// void __thiscall UIElement_UIItem::SetSelectableState(UIElement_UIItem*,bool)</code>
    /// </summary>
    /// <param name="selectable">True to allow selection; false to prevent it.</param>
    public void SetSelectableState(byte selectable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, byte, void>)0x004E1F10)(ref this, selectable);

    /// <summary>Updates the item's drag‑acceptance indicator to the supplied state, changing the visual representation only if the state differs from the current one.
    /// <code>Offset: 0x004E1F20
    /// void __thiscall UIElement_UIItem::SetDragAcceptState(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    /// <param name="state">The desired state value for the drag‑accept icon.</param>
    public void SetDragAcceptState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, void>)0x004E1F20)(ref this, state);

    /// <summary>Updates the item's quantity displayed in the UI.
    /// <code>Offset: 0x004E1F50
    /// void __thiscall UIElement_UIItem::SetQuantity(UIElement_UIItem*,int)</code>
    /// </summary>
    /// <param name="quantity">The new quantity value to assign to the item.</param>
    public void SetQuantity(int quantity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, void>)0x004E1F50)(ref this, quantity);

    /// <summary>Responds to a global message by performing a heartbeat check for message ID 3 and, when the interval has elapsed, updates the timestamp and triggers the associated callback.
    /// <code>Offset: 0x004E1F60
    /// void __thiscall UIElement_UIItem::ListenToGlobalMessage(UIElement_UIItem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">The identifier of the received global message.</param>
    /// <param name="i_data_int">An integer payload supplied with the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, int, void>)0x004E1F60)(ref this, i_messageID, i_data_int);

    /// <summary>Registers the UIElement_UIItem class with the UI system, associating a unique class identifier with its factory method for creating instances.
    /// <code>Offset: 0x004E2000
    /// void __cdecl UIElement_UIItem::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E2000)();

    /// <summary>Handles incoming UI element messages for item UI elements, performing actions such as drag‑and‑drop, initiating waiting states, and updating icon visibility based on the message type.
    /// <code>Offset: 0x004E2020
    /// UIElementMessageListenResult __thiscall UIElement_UIItem::ListenToElementMessage(UIElement_UIItem*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the UIElement_UIItem instance receiving the message.</param>
    /// <param name="i_rMsg">Message information containing identifiers, parameters, and coordinates for processing.</param>
    /// <returns>Result of processing the message, indicating whether it was handled successfully.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004E2020)(ref this, i_rMsg);

    /// <summary>Updates the visual and interaction state of an item’s icon, text, overlays, and selection indicator by propagating the supplied state value to each component. When the state equals 268435484, it clears container flags, removes tooltips, and deselects the item.
    /// <code>Offset: 0x004E2190
    /// bool __thiscall UIElement_UIItem::UIItem_SetState(UIElement_UIItem*,unsigned int)</code>
    /// </summary>
    /// <param name="state">The new state to apply to the UI elements; special handling occurs for state = 268435484.</param>
    /// <returns>True if the base icon element exists and the state was applied; otherwise false.</returns>
    public byte UIItem_SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, uint, byte>)0x004E2190)(ref this, state);

    /// <summary>Assigns the specified shortcut number to this item, updating its visual icon and internal state. When negative, clears the shortcut display; otherwise displays the new number, optionally as a ghosted overlay.
    /// <code>Offset: 0x004E2220
    /// void __thiscall UIElement_UIItem::SetShortcutNum(UIElement_UIItem*,int,bool)</code>
    /// </summary>
    /// <param name="shortcutNum">The shortcut key index to set for the item. A value of zero or greater assigns that number; a negative value removes any existing shortcut assignment.</param>
    /// <param name="ghosted">If true, the shortcut is shown in a temporary, ghosted style rather than as a permanent icon. If false, the shortcut is displayed normally.</param>
    public void SetShortcutNum(int shortcutNum, byte ghosted) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, int, byte, void>)0x004E2220)(ref this, shortcutNum, ghosted);

    /// <summary>Updates the capacity bar for an item’s UI representation, displaying the proportion of items contained if the item is a container with defined capacity; otherwise hides the bar.
    /// <code>Offset: 0x004E2370
    /// void __thiscall UIElement_UIItem::UpdateCapacityDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateCapacityDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2370)(ref this);

    /// <summary>Updates the UI structure meter to reflect an item's current structural integrity, hiding it when fully restored or unknown, otherwise displaying a proportionate fill value.
    /// <code>Offset: 0x004E2430
    /// void __thiscall UIElement_UIItem::UpdateStructureDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateStructureDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2430)(ref this);

    /// <summary>Initializes child UI elements of an item by locating them via identifiers, setting up meters and text fields, creating a drag icon, configuring properties, and registering for global messages.
    /// <code>Offset: 0x004E2500
    /// void __thiscall UIElement_UIItem::PostInit(UIElement_UIItem*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2500)(ref this);

    /// <summary>Retrieves all UI element properties applicable to this item, populating the supplied AvailablePropertySet with those properties and any global master properties.
    /// <code>Offset: 0x004E2900
    /// bool __thiscall UIElement_UIItem::InqAvailableProperties(UIElement_UIItem*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The property set to fill with available properties for this item.</param>
    /// <returns>True if the base class reported at least one property; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, ACBindings.Internal.AvailablePropertySet*, byte>)0x004E2900)(ref this, set);

    /// <summary>Updates the UI item's tooltip to display its name and stack count based on the current item ID.
    /// <code>Offset: 0x004E2940
    /// void __thiscall UIElement_UIItem::UpdateTooltip(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2940)(ref this);

    /// <summary>Updates the quantity label of the item icon, clearing it when the quantity is negative or displaying the formatted number otherwise.
    /// <code>Offset: 0x004E2A30
    /// void __thiscall UIElement_UIItem::UpdateQuantityDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateQuantityDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2A30)(ref this);

    /// <summary>Updates the item's cooldown display, showing the correct percentage overlay icon (10 %‑to‑100 %) based on the enchantment's remaining cooldown time.
    /// <code>Offset: 0x004E2AB0
    /// void __thiscall UIElement_UIItem::UpdateCooldownDisplay(UIElement_UIItem*)</code>
    /// </summary>
    public void UpdateCooldownDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2AB0)(ref this);

    /// <summary>Sets the UI element's icon image and optional text based on its spell or item identifier, updating visual appearance. Returns true upon success, false if no icon component exists or required resources cannot be retrieved.
    /// <code>Offset: 0x004E2D10
    /// bool __thiscall UIElement_UIItem::UIItem_SetIcon(UIElement_UIItem*)</code>
    /// </summary>
    /// <returns>true when the icon (and text, if applicable) is successfully updated; false otherwise.</returns>
    public byte UIItem_SetIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, byte>)0x004E2D10)(ref this);

    /// <summary>Updates the visual state of a UI item element by synchronizing its icon, selection status, effects, container properties, capacity, structure, quantity, cooldown, waiting and shortcut states, sell/trade indicators, and tooltip with the underlying game object or spell information. If no associated object exists but a spell ID is present, applies a predefined state and icon; otherwise clears tooltip and sets default state.
    /// <code>Offset: 0x004E2E60
    /// void __thiscall UIElement_UIItem::UIItem_Update(UIElement_UIItem*)</code>
    /// </summary>
    public void UIItem_Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_UIItem, void>)0x004E2E60)(ref this);
}

