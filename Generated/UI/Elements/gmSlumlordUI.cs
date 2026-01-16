namespace ACBindings.Internal;


/// <summary>
/// Provides the user interface for buying, renting, and managing house transactions in the game.
/// Tracks the current owner, selected house profile, item lists, and handles dialogs and payment processing.
/// </summary>
public unsafe struct gmSlumlordUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Panel BaseClass_UIElement_Panel; // ACBindings.Internal.UIElement_Panel
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmSlumlordUI_vtbl
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
    public uint m_iidOwner;
    public ACBindings.Internal.HouseProfile* m_pHouseProfile;
    public ACBindings.Internal.HouseProfile* m_pBackupHouseProfile;
    public ACBindings.Internal.HouseOp m_eCurrentHouseOp;
    public ACBindings.Internal.UIElement_ItemList* m_pCurItemList;
    public ACBindings.Internal.UIElement_Text* m_pBuyRequirementsText;
    public ACBindings.Internal.UIElement_Text* m_pBuyHouseOwnerText;
    public ACBindings.Internal.UIElement_ItemList* m_pBuyItemList;
    public ACBindings.Internal.UIElement_Button* m_pBuyButton;
    public ACBindings.Internal.UIElement_Text* m_pRentRequirementsText;
    public ACBindings.Internal.UIElement_Text* m_pRentHouseOwnerText;
    public ACBindings.Internal.UIElement_ItemList* m_pRentItemList;
    public ACBindings.Internal.UIElement_Button* m_pRentButton;
    public uint m_uiHousePurchaseDialogContext;
    public uint m_uiRentPaymentByProxyDialogContext;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the Slumlord UI visibility state; when hidden, it unregisters its object range handlers to stop processing related events.
    /// <code>Offset: 0x004C8860
    /// void __thiscall gmSlumlordUI::OnVisibilityChanged(gmSlumlordUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">The new visibility status of the UI panel.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte, void>)0x004C8860)(ref this, i_bVisible);

    /// <summary>Detaches an element from internal tracking when it exits the monitored range.
    /// <code>Offset: 0x004C88A0
    /// void __thiscall gmSlumlordUI::OnObjectRangeExit(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    /// <param name="objectID">Identifier of the element that has left the range.</param>
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, void>)0x004C88A0)(ref this, objectID);

    /// <summary>Creates or updates a backup copy of the current house profile stored in m_pHouseProfile.
    /// <code>Offset: 0x004C88D0
    /// bool __thiscall gmSlumlordUI::BackupHouseProfile(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True if the backup was successfully created or updated; false if no current profile is set or memory allocation fails.</returns>
    public byte BackupHouseProfile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C88D0)(ref this);

    /// <summary>Determines whether the house associated with this UI instance belongs to the current player.
    /// <code>Offset: 0x004C8920
    /// bool __thiscall gmSlumlordUI::AmIHouseOwner(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True if a house profile is present and its owner ID matches the player’s ID (using the smartbox context when available), otherwise false.</returns>
    public byte AmIHouseOwner() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C8920)(ref this);

    /// <summary>Determines whether a payment can proceed for the current house operation based on ownership status.
    /// <code>Offset: 0x004C8950
    /// bool __thiscall gmSlumlordUI::IsPaymentAllowed(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True if payment is allowed; otherwise, false.</returns>
    public byte IsPaymentAllowed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C8950)(ref this);

    /// <summary>Attempts to cast this instance to a requested UI element type based on an identifier and returns the corresponding pointer or null.
    /// <code>Offset: 0x004C8AA0
    /// UIElement* __thiscall gmSlumlordUI::DynamicCast(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the UI element type to cast to; specific values trigger different casts.</param>
    /// <returns>Pointer to the requested UIElement subtype, or null if the cast is unsupported.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.UIElement*>)0x004C8AA0)(ref this, i_eType);

    /// <summary>Returns the unique identifier for the Slumlord UI element type.
    /// <code>Offset: 0x004C8AC0
    /// unsigned int __thiscall gmSlumlordUI::GetUIElementType(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant that identifies this UI component within the system (e.g., 268435475).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint>)0x004C8AC0)(ref this);

    /// <summary>Destroys the gmSlumlordUI instance by unregistering object range and notice handlers, removing drag handlers from buy and rent item lists, closing any open purchase or rental dialogs, resetting dialog context identifiers, and cleaning up base class components.
    /// <code>Offset: 0x004C8AD0
    /// void __thiscall gmSlumlordUI::~gmSlumlordUI(gmSlumlordUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8AD0)(ref this);

    /// <summary>Responds to a failed house transaction notice by querying the current lord if an element is registered.
    /// <code>Offset: 0x004C8BB0
    /// void __thiscall gmSlumlordUI::RecvNotice_FailedHouseTransaction(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmSlumlordUI instance handling the notice.</param>
    /// <param name="i_eType">Identifier of the failure type (currently unused).</param>
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, void>)0x004C8BB0)(ref this, i_eType);

    /// <summary>Adjusts the enabled state of the buy and rent buttons according to the current house operation, ownership, payment status, and available items. When no operation is active, both buttons are disabled. If a house can be purchased or rented, its corresponding button becomes enabled; otherwise it remains disabled.
    /// <code>Offset: 0x004C8BD0
    /// void __thiscall gmSlumlordUI::UpdateButtons(gmSlumlordUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8BD0)(ref this);

    /// <summary>Cleans the buy and rent item lists by clearing trade states, flushing list contents, resetting button callbacks, and clearing associated house payment data when a profile exists.
    /// <code>Offset: 0x004C8C70
    /// void __thiscall gmSlumlordUI::CleanItemLists(gmSlumlordUI*)</code>
    /// </summary>
    public void CleanItemLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8C70)(ref this);

    /// <summary>Adds an item to the current list if it is eligible for trade, processes its house payment, and registers a notice handler. The operation fails when the item is null, contains sub-items, already exists in the current list, or payment processing fails.
    /// <code>Offset: 0x004C8CE0
    /// bool __thiscall gmSlumlordUI::AddItem(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pItem">The item to add. Must not be null, contain other items, and must not already exist in the current list.</param>
    /// <returns>True if the item was successfully added; otherwise false.</returns>
    public byte AddItem(ACBindings.Internal.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004C8CE0)(ref this, i_pItem);

    /// <summary>Removes the specified inventory object from the UI’s current item list, clears its trade state, unregisters notice handlers, deletes it from the list, and updates the house payment associated with that item.
    /// <code>Offset: 0x004C8DA0
    /// void __thiscall gmSlumlordUI::RemoveItem(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pItem">The ACCWeenieObject to be removed. If null or if no active item list exists, the function exits without performing any action.</param>
    public void RemoveItem(ACBindings.Internal.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004C8DA0)(ref this, i_pItem);

    /// <summary>Initializes the Slumlord UI by registering event handlers, locating child components, configuring item list drag handling, and updating button states.
    /// <code>Offset: 0x004C8EB0
    /// void __thiscall gmSlumlordUI::PostInit(gmSlumlordUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8EB0)(ref this);

    /// <summary>Registers the Slumlord UI component with the UI framework to enable instantiation by its unique identifier.
    /// <code>Offset: 0x004C90C0
    /// void __cdecl gmSlumlordUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C90C0)();

    /// <summary>Begins a drag action on an item in the specified list, removing the item from the UI and refreshing relevant controls.
    /// <code>Offset: 0x004C90E0
    /// void __thiscall gmSlumlordUI::RecvNotice_ItemListBeginDrag(gmSlumlordUI*,const UIElement*,int)</code>
    /// </summary>
    /// <param name="i_itemList">The item list UI element that initiated the drag.</param>
    /// <param name="i_slotNum">The index of the item within the list to be dragged.</param>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.UIElement*, int, void>)0x004C90E0)(ref this, i_itemList, i_slotNum);

    /// <summary>Handles a server notification that an item has moved, removing it from the UI list if it is not owned by a player and updating related action buttons accordingly.
    /// <code>Offset: 0x004C9140
    /// void __thiscall gmSlumlordUI::RecvNotice_ServerSaysMoveItem(gmSlumlordUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Unique identifier of the item involved in the move.</param>
    /// <param name="oldContainer">Identifier of the container from which the item was removed.</param>
    /// <param name="oldWielder">Identifier of the wielder previously holding the item.</param>
    /// <param name="oldLocation">Previous location index of the item within its container.</param>
    /// <param name="newContainer">Identifier of the destination container for the moved item.</param>
    /// <param name="place">Target position index in the new container.</param>
    /// <param name="newWielder">Identifier of the wielder who will hold the item after moving.</param>
    /// <param name="newLocation">Destination location index of the item within its new container.</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C9140)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Removes an item from the UI when a deletion notice is received.
    /// <code>Offset: 0x004C9190
    /// void __thiscall gmSlumlordUI::RecvNotice_BeingDeleted(gmSlumlordUI*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="i_obj">The object being deleted, identified by its CWeenieObject instance.</param>
    public void RecvNotice_BeingDeleted(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.CWeenieObject*, void>)0x004C9190)(ref this, i_obj);

    /// <summary>Adds the specified object to the UI, delegating to container or item handlers as appropriate.
    /// <code>Offset: 0x004C91A0
    /// bool __thiscall gmSlumlordUI::AddObject(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pObject">The object to add; can be a container with contained items or a single item.</param>
    /// <returns>True if the object was added successfully; false if the pointer is null or addition fails.</returns>
    public byte AddObject(ACBindings.Internal.ACCWeenieObject* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004C91A0)(ref this, i_pObject);

    /// <summary>Checks whether a dragged item can be placed in the slumlord UI list, enforcing ownership, duplicate prevention, payment rules, and requiring that the item contains sub‑items or satisfies a special condition.
    /// <code>Offset: 0x004C91E0
    /// bool __thiscall gmSlumlordUI::DragItemAcceptable(gmSlumlordUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_iidItem">The ID of the item being dragged.</param>
    /// <param name="silent">If true, suppresses the warning notice when the player does not own the item; otherwise a message is shown.</param>
    /// <returns>True if the item meets all criteria and may be accepted; false otherwise.</returns>
    public byte DragItemAcceptable(uint i_iidItem, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, byte, byte>)0x004C91E0)(ref this, i_iidItem, silent);

    /// <summary>Adds each item from the specified container into the Slumlord UI, provided the item can be dragged and is available in the client system.
    /// <code>Offset: 0x004C92D0
    /// bool __thiscall gmSlumlordUI::AddContainer(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pContainer">The container object whose contents are processed for addition to the interface.</param>
    /// <returns>True if the container was non‑null, contained at least one item, and all acceptable items were processed; otherwise false (container null or empty).</returns>
    public byte AddContainer(ACBindings.Internal.ACCWeenieObject* i_pContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004C92D0)(ref this, i_pContainer);

    /// <summary>Checks whether a dragged item can be added to the Slumlord UI, splits the stack if needed, and updates the interface when successful.
    /// <code>Offset: 0x004C93B0
    /// bool __thiscall gmSlumlordUI::AcceptDragObject(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">Unique identifier of the item being dragged.</param>
    /// <returns>True if the item was accepted and processed; otherwise false.</returns>
    public byte AcceptDragObject(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, byte>)0x004C93B0)(ref this, i_iidItem);

    /// <summary>Processes a purchase or rental transaction for a house by collecting selected items from the UI list, validating prerequisites, updating interface elements, and triggering the corresponding house event.
    /// <code>Offset: 0x004C9530
    /// bool __thiscall gmSlumlordUI::MakePayment(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True if the payment is processed successfully; returns false when the operation is not buy/rent, the owner ID or item list is missing, or no items are selected.</returns>
    public byte MakePayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9530)(ref this);

    /// <summary>Processes a drag‑drop release event in the Slumlord UI, validating the target list (buy or rent) before accepting the dropped item.
    /// <code>Offset: 0x004C9670
    /// void __thiscall gmSlumlordUI::HandleDropRelease(gmSlumlordUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information about the drop event, including references to source and destination elements.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C9670)(ref this, i_rMsg);

    /// <summary>Refreshes the UI for the current house profile by updating purchase/rent requirement texts, owner labels, cleaning item lists, and enabling or disabling relevant buttons.
    /// <code>Offset: 0x004C9710
    /// bool __thiscall gmSlumlordUI::RefreshHouse(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True if a HouseProfile is present and the UI was updated; otherwise false.</returns>
    public byte RefreshHouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9710)(ref this);

    /// <summary>Closes the buy‑house confirmation dialog, handling payment processing when confirmed and cleaning up UI state otherwise.
    /// <code>Offset: 0x004C9980
    /// bool __thiscall gmSlumlordUI::CloseBuyHouseConfirmationDialog(gmSlumlordUI*,bool)</code>
    /// </summary>
    /// <param name="i_bConfirm">True if the user confirmed the purchase; false to cancel.</param>
    /// <returns>False if no house profile was selected; true once the dialog has been closed (either after a successful or cancelled transaction).</returns>
    public byte CloseBuyHouseConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte, byte>)0x004C9980)(ref this, i_bConfirm);

    /// <summary>Closes the rent‑by‑proxy confirmation dialog, clearing its context and optionally performing the payment if the user confirmed and items remain.
    /// <code>Offset: 0x004C99E0
    /// bool __thiscall gmSlumlordUI::CloseRentPaymentByProxyConfirmationDialog(gmSlumlordUI*,bool)</code>
    /// </summary>
    /// <param name="i_bConfirm">True when the user accepts the dialog; false to cancel.</param>
    /// <returns>Returns true unless the rent item list is unavailable.</returns>
    public byte CloseRentPaymentByProxyConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte, byte>)0x004C99E0)(ref this, i_bConfirm);

    /// <summary>Closes a specific dialog in the Slumlord UI, such as the buy house confirmation or rent payment by proxy dialogs, based on the provided context identifier and property collection data.
    /// <code>Offset: 0x004C9A30
    /// void __thiscall gmSlumlordUI::RecvNotice_CloseDialog(gmSlumlordUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier specifying which dialog to close.</param>
    /// <param name="data">PropertyCollection containing closure information (e.g., result flag).</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004C9A30)(ref this, context, data);

    /// <summary>Updates the UI’s house profile and owner information, then backs up the profile and refreshes the display.
    /// <code>Offset: 0x004C9BC0
    /// bool __thiscall gmSlumlordUI::UpdateHouse(gmSlumlordUI*,unsigned int,const HouseProfile*)</code>
    /// </summary>
    /// <param name="i_iidOwner">The identifier of the new house owner.</param>
    /// <param name="houseProfile">Pointer to the HouseProfile structure containing updated data for the house.</param>
    /// <returns>True if the profile was successfully copied or allocated; false if memory allocation failed.</returns>
    public byte UpdateHouse(uint i_iidOwner, ACBindings.Internal.HouseProfile* houseProfile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.HouseProfile*, byte>)0x004C9BC0)(ref this, i_iidOwner, houseProfile);

    /// <summary>Updates the slumlord UI for a specified owner using the provided house profile, refreshes visual components, and registers an object range handler to monitor related UI elements.
    /// <code>Offset: 0x004C9C30
    /// void __thiscall gmSlumlordUI::RecvNotice_UpdateHouseProfile(gmSlumlordUI*,unsigned int,const HouseProfile*)</code>
    /// </summary>
    /// <param name="i_iidOwner">The identifier of the owner whose house information is being updated.</param>
    /// <param name="i_prof">Pointer to the HouseProfile containing new data for the owner's house.</param>
    public void RecvNotice_UpdateHouseProfile(uint i_iidOwner, ACBindings.Internal.HouseProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.HouseProfile*, void>)0x004C9C30)(ref this, i_iidOwner, i_prof);

    /// <summary>Creates a confirmation dialog that warns the player about restrictions when purchasing a landscape house and asks for confirmation.
    /// <code>Offset: 0x004C9CA0
    /// bool __thiscall gmSlumlordUI::MakeBuyHouseConfirmationDialog(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True if the dialog was successfully created; otherwise false.</returns>
    public byte MakeBuyHouseConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9CA0)(ref this);

    /// <summary>Shows a confirmation dialog asking the player whether they wish to pay maintenance on another player's house, creating it only if no dialog currently exists and storing its context identifier.
    /// <code>Offset: 0x004C9EA0
    /// bool __thiscall gmSlumlordUI::MakeRentPaymentByProxyConfirmationDialog(gmSlumlordUI*)</code>
    /// </summary>
    /// <returns>True when the dialog is created successfully; false if a dialog already exists or creation fails.</returns>
    public byte MakeRentPaymentByProxyConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9EA0)(ref this);

    /// <summary>
    /// Handles UI element messages for the Slumlord interface, executing actions such as initiating buy or rent operations, showing confirmation dialogs, processing payments, managing item drag/drop releases, and updating UI elements accordingly.
    /// 
    /// <code>Offset: 0x004CA0A0
    /// UIElementMessageListenResult __thiscall gmSlumlordUI::ListenToElementMessage(gmSlumlordUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmSlumlordUI instance.</param>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>Result indicating whether the message was handled or should be forwarded to the base panel handler.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CA0A0)(ref this, i_rMsg);
}

