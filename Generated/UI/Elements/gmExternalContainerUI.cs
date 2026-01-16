namespace ACBindings.Internal;


/// <summary>Interactive UI component displaying items contained in a ground object. Manages item lists, handles drag‑and‑drop interactions, visibility changes, and server notifications for item movement.</summary>
public unsafe struct gmExternalContainerUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmExternalContainerUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_ItemList* m_topContainer;
    public ACBindings.Internal.UIElement_ItemList* m_containerList;
    public ACBindings.Internal.UIElement_ItemList* m_itemList;
    public uint groundObjectID;

    // Generated Constructor
    public gmExternalContainerUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destructs a gmExternalContainerUI instance by unregistering its item list drag handler, deregistering object‑range and notice handlers from the player and global systems, and destroying base class components.
    /// <code>Offset: 0x004CC610
    /// void __thiscall gmExternalContainerUI::~gmExternalContainerUI(gmExternalContainerUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, void>)0x004CC610)(ref this);

    /// <summary>Attempts a safe cast of this external container UI object to the requested element type, yielding a pointer to the underlying UIElement or nullptr when the conversion is invalid.
    /// <code>Offset: 0x004CC690
    /// UIElement* __thiscall gmExternalContainerUI::DynamicCast(gmExternalContainerUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired element type for casting (e.g., 3 for the full object, 268435469 for its base UIElement).</param>
    /// <returns>Pointer to UIElement if the cast matches; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, uint, ACBindings.Internal.UIElement*>)0x004CC690)(ref this, i_eType);

    /// <summary>Retrieves the UI element type identifier for a combat maneuver table instance.
    /// <code>Offset: 0x004CC6B0
    /// unsigned int __thiscall gmExternalContainerUI::GetUIElementType(CombatManeuverTable*)</code>
    /// </summary>
    /// <param name="this">The CombatManeuverTable object to query.</param>
    /// <returns>The unsigned integer value 268435469, which represents the UI element type ID for combat maneuver tables.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, uint>)0x004CC6B0)(ref this);

    /// <summary>Processes an element message, performing a special cleanup for a particular element ID before delegating to the base UIElement handler.
    /// <code>Offset: 0x004CC6C0
    /// UIElementMessageListenResult __thiscall gmExternalContainerUI::ListenToElementMessage(gmExternalContainerUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the message being processed, including source element and message type.</param>
    /// <returns>The result of listening to the element message as returned by the base UIElement implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CC6C0)(ref this, i_rMsg);

    /// <summary>Handles a notification that the user has ceased viewing the object with the specified ID, updating internal state accordingly.
    /// <code>Offset: 0x004CC6F0
    /// void __thiscall gmExternalContainerUI::RecvNotice_StopViewingObject(gmExternalContainerUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_objid">The identifier of the object whose viewing status has been stopped.</param>
    public void RecvNotice_StopViewingObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, uint, void>)0x004CC6F0)(ref this, i_objid);

    /// <summary>Responds to a server notification indicating an item has moved. If the notified item matches the UI’s tracked element and the destination container differs from the current one, it opens the top‑level container so the user can view the new location.
    /// <code>Offset: 0x004CC720
    /// void __thiscall gmExternalContainerUI::RecvNotice_ServerSaysMoveItem(gmExternalContainerUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the moved item.</param>
    /// <param name="oldContainer">Identifier of the container the item was previously in (unused).</param>
    /// <param name="oldWielder">Identifier of the previous wielder (unused).</param>
    /// <param name="oldLocation">Previous location flag (unused).</param>
    /// <param name="newContainer">Identifier of the new container the item moved to.</param>
    /// <param name="place">The position within the new container (unused).</param>
    /// <param name="newWielder">Identifier of the new wielder (unused).</param>
    /// <param name="newLocation">New location flag (unused).</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CC720)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Determines whether a dragged item can be dropped onto this external container.
    /// <code>Offset: 0x004CC750
    /// bool __thiscall gmExternalContainerUI::DragItemAcceptable(gmExternalContainerUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item being dragged.</param>
    /// <param name="silent">Flag reserved for future use; currently ignored.</param>
    /// <returns>True if the drop is acceptable; otherwise false.</returns>
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, uint, byte, byte>)0x004CC750)(ref this, itemID, silent);

    /// <summary>Closes the currently active external container by releasing its ground object, unregistering any associated range handler, clearing the top item list, and resetting parent references.
    /// <code>Offset: 0x004CC8A0
    /// void __thiscall gmExternalContainerUI::CloseCurrentContainer(gmExternalContainerUI*)</code>
    /// </summary>
    public void CloseCurrentContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, void>)0x004CC8A0)(ref this);

    /// <summary>Initializes a new external container UI element with specified layout and full description, setting up internal state and event handlers for notice, object range, and item list drag operations.
    /// <code>Offset: 0x004CC930
    /// void __thiscall gmExternalContainerUI::gmExternalContainerUI(gmExternalContainerUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing dimensions and element headers used by the UI element.</param>
    /// <param name="full_desc">Full element descriptor defining properties, states, and child elements of the container.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CC930)(ref this, layout, full_desc);

    /// <summary>Initializes the external container UI by setting up child item lists, registering notice handlers with the global event system, and linking drag‑handling functionality to the item list.
    /// <code>Offset: 0x004CC9D0
    /// void __thiscall gmExternalContainerUI::PostInit(gmExternalContainerUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, void>)0x004CC9D0)(ref this);

    /// <summary>Handles visibility changes for an external container UI, forwarding the change to its base UIElement and closing any active container when it becomes hidden.
    /// <code>Offset: 0x004CCB40
    /// void __thiscall gmExternalContainerUI::OnVisibilityChanged(gmExternalContainerUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the element is now visible; false if it has been hidden.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, byte, void>)0x004CCB40)(ref this, i_bVisible);

    /// <summary>
    /// Sets the container UI to display the specified ground object, refreshing its item list and configuring range-based updates.
    /// 
    /// <code>Offset: 0x004CCBC0
    /// void __thiscall gmExternalContainerUI::RecvNotice_SetGroundObject(gmExternalContainerUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_objid">
    /// The identifier of the ground object to display; zero clears any current selection.
    /// </param>
    public void RecvNotice_SetGroundObject(uint i_objid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmExternalContainerUI, uint, void>)0x004CCBC0)(ref this, i_objid);

    /// <summary>Registers the external container UI component class with the UI framework by assigning it a unique identifier and linking its constructor function.
    /// <code>Offset: 0x004CCBD0
    /// void __cdecl gmExternalContainerUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CCBD0)();
}

