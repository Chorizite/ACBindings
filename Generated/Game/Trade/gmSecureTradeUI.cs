namespace ACBindings.Internal;


/// <summary>
/// Handles the secure trade user interface, coordinating player and partner item lists, trade button states, drag‑and‑drop of trade items, and interaction with the client trade system during a secure trade session.
/// </summary>
public unsafe struct gmSecureTradeUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmSecureTradeUI_vtbl
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
    public ACBindings.Internal.UIElement_Button* m_pTradeButton;
    public ACBindings.Internal.UIElement_Text* m_pSelfPlayerName;
    public ACBindings.Internal.UIElement_Text* m_pSelfTotalItemsLabel;
    public ACBindings.Internal.UIElement_ItemList* m_pSelfItemsList;
    public ACBindings.Internal.UIElement* m_pOtherTradeStatusIndicator;
    public ACBindings.Internal.UIElement_Text* m_pOtherPlayerName;
    public ACBindings.Internal.UIElement_Text* m_pOtherTotalItemsLabel;
    public ACBindings.Internal.UIElement_ItemList* m_pOtherItemsList;
    public ACBindings.Internal.UIElement_Button* m_pClearAllItemsButton;
    public uint splitItemID;
    public ACBindings.Internal.IDClass____tagDataID splitItemClassID;
    public uint splitItemStackSize;

    // Generated Constructor
    public gmSecureTradeUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys the Secure Trade UI component, unregistering its item list drag handler, object range handlers, and notice handlers, then cleans up internal references before releasing resources.
    /// <code>Offset: 0x004CA240
    /// void __thiscall gmSecureTradeUI::~gmSecureTradeUI(gmSecureTradeUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA240)(ref this);

    /// <summary>Dynamic casts a gmSecureTradeUI instance to the requested element type.
    /// <code>Offset: 0x004CA2C0
    /// UIElement* __thiscall gmSecureTradeUI::DynamicCast(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Numeric identifier of the desired type; 268435474 selects the base UIElement, 3 selects the gmSecureTradeUI itself.</param>
    /// <returns>A pointer to the corresponding UIElement if the cast matches, otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, ACBindings.Internal.UIElement*>)0x004CA2C0)(ref this, i_eType);

    /// <summary>Retrieves the unique identifier for the secure trade UI component.
    /// <code>Offset: 0x004CA2E0
    /// unsigned int __thiscall gmSecureTradeUI::GetUIElementType(gmSecureTradeUI*)</code>
    /// </summary>
    /// <returns>The numeric ID that identifies this UI element type within the system.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint>)0x004CA2E0)(ref this);

    /// <summary>Adjusts the trade button's state based on the combined item count in the player's and partner's item lists, disabling it when empty and enabling it when items are present.
    /// <code>Offset: 0x004CA2F0
    /// void __thiscall gmSecureTradeUI::UpdateTradeButtonState(gmSecureTradeUI*)</code>
    /// </summary>
    /// <param name="this">The gmSecureTradeUI instance whose trade button is being updated.</param>
    public void UpdateTradeButtonState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA2F0)(ref this);

    /// <summary>Initializes a secure trade user interface component by configuring its base element, setting up notification, object range, and drag handlers, clearing child element pointers, and preparing split‑item state.
    /// <code>Offset: 0x004CA3B0
    /// void __thiscall gmSecureTradeUI::gmSecureTradeUI(gmSecureTradeUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="this">Pointer to the new gmSecureTradeUI instance.</param>
    /// <param name="layout">Layout descriptor defining display dimensions and layout structure.</param>
    /// <param name="full_desc">Full element description used to initialize the UI hierarchy.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CA3B0)(ref this, layout, full_desc);

    /// <summary>Processes a server notice indicating that a secure trade attempt has failed for a specified item.
    /// <code>Offset: 0x004CA4B0
    /// void __thiscall gmSecureTradeUI::RecvNotice_ServerSaysAttemptFailed(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">Identifier of the item whose trade attempt was unsuccessful.</param>
    public void RecvNotice_ServerSaysAttemptFailed(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA4B0)(ref this, i_iidItem);

    /// <summary>Updates the label displaying the user's total item count in the secure trade interface by retrieving the current number of items from the list and formatting the text accordingly.
    /// <code>Offset: 0x004CA4C0
    /// void __thiscall gmSecureTradeUI::SetMyItemNumber(gmSecureTradeUI*)</code>
    /// </summary>
    public void SetMyItemNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA4C0)(ref this);

    /// <summary>Updates the other participant’s total items label by retrieving the current number of UI items from the trade list and formatting it into a localized string.
    /// <code>Offset: 0x004CA560
    /// void __thiscall gmSecureTradeUI::SetOtherItemNumber(gmSecureTradeUI*)</code>
    /// </summary>
    public void SetOtherItemNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA560)(ref this);

    /// <summary>Validates that the number of items displayed in the UI matches the server‑side counts; if they match, accepts the trade, otherwise notifies the server that the trade data is out of sync. Afterward disables the trade button and updates its visual state.
    /// <code>Offset: 0x004CA600
    /// void __thiscall gmSecureTradeUI::AcceptTheTrade(gmSecureTradeUI*)</code>
    /// </summary>
    public void AcceptTheTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA600)(ref this);

    /// <summary>Declines the current secure trade by notifying the server and updating the trade UI state.
    /// <code>Offset: 0x004CA680
    /// void __thiscall gmSecureTradeUI::DeclineTheTrade(gmSecureTradeUI*)</code>
    /// </summary>
    public void DeclineTheTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA680)(ref this);

    /// <summary>Flushes the self and other item lists in the secure trade UI, resetting the trade state of locally listed items and removing non-player-owned items from the remote list when conditions allow.
    /// <code>Offset: 0x004CA6B0
    /// void __thiscall gmSecureTradeUI::FlushTradeLists(gmSecureTradeUI*)</code>
    /// </summary>
    public void FlushTradeLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA6B0)(ref this);

    /// <summary>Removes the specified item from the secure trade interface, updating internal lists, trade state, and button status accordingly.
    /// <code>Offset: 0x004CA7D0
    /// void __thiscall gmSecureTradeUI::RemoveItem(gmSecureTradeUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="i_pItem">The item to remove from the trade session.</param>
    public void RemoveItem(ACBindings.Internal.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004CA7D0)(ref this, i_pItem);

    /// <summary>Registers the secure trade UI element type with its associated layout descriptor and constructor callback, enabling creation of instances via the UI system.
    /// <code>Offset: 0x004CA8B0
    /// void __cdecl gmSecureTradeUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CA8B0)();

    /// <summary>Handles a received trade acceptance notice, updating the UI status indicator and refreshing the trade button state based on the source identifier.
    /// <code>Offset: 0x004CA8D0
    /// void __thiscall gmSecureTradeUI::RecvNotice_AcceptTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidSource">Identifier of the entity that sent the accept trade notice; zero indicates the local player, otherwise represents another participant.</param>
    public void RecvNotice_AcceptTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA8D0)(ref this, i_iidSource);

    /// <summary>Responds to a decline trade notice, verifying the source against the active SmartBox ID before adjusting UI elements and updating the trade button state.
    /// <code>Offset: 0x004CA960
    /// void __thiscall gmSecureTradeUI::RecvNotice_DeclineTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidSource">Identifier of the notice source; used to determine if the decline applies to the current trade session.</param>
    public void RecvNotice_DeclineTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA960)(ref this, i_iidSource);

    /// <summary>Updates the secure trade UI to display the trade partner’s name corresponding to the provided identifier, or clears the name when the ID is zero.
    /// <code>Offset: 0x004CA9C0
    /// void __thiscall gmSecureTradeUI::SetTradePartner(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidPartner">The unique identifier of the trade partner; a value of zero indicates no partner and causes the displayed name to be cleared.</param>
    public void SetTradePartner(uint i_iidPartner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA9C0)(ref this, i_iidPartner);

    /// <summary>Adds an item to the secure trade UI's own item list at a specified position. If the item is already present, clears its waiting state; otherwise marks it for trading and inserts it into the list.
    /// <code>Offset: 0x004CAA70
    /// bool __thiscall gmSecureTradeUI::AddMyItem(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">The unique identifier of the item to add.</param>
    /// <param name="i_uiPos">The index within the item list where the new item should be inserted.</param>
    /// <returns>True if the item was successfully added or updated; false if the self items list is unavailable.</returns>
    public byte AddMyItem(uint i_iidItem, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, byte>)0x004CAA70)(ref this, i_iidItem, i_uiPos);

    /// <summary>Adds an item to the partner’s trade list at the specified position. If the item already exists, it clears its waiting flag; otherwise it inserts the item and refreshes the UI elements that display the partner’s items and trade status.
    /// <code>Offset: 0x004CAB20
    /// bool __thiscall gmSecureTradeUI::AddPartnerItem(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">The identifier of the item to add or update in the partner’s list.</param>
    /// <param name="i_uiPos">The index at which to insert a new item if it is not already present.</param>
    /// <returns>True when the operation succeeds; false if the partner’s items list is unavailable.</returns>
    public byte AddPartnerItem(uint i_iidItem, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, byte>)0x004CAB20)(ref this, i_iidItem, i_uiPos);

    /// <summary>Removes an item added by the player from the secure trade UI and updates related controls.
    /// <code>Offset: 0x004CABB0
    /// bool __thiscall gmSecureTradeUI::RemoveAddedItem(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item to remove from the player's list.</param>
    /// <returns>True if the item was found and removed; otherwise false.</returns>
    public byte RemoveAddedItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CABB0)(ref this, itemID);

    /// <summary>Removes an item from the other player’s trade list, updating UI elements and the trade button state.
    /// <code>Offset: 0x004CAC50
    /// bool __thiscall gmSecureTradeUI::RemovePartnerItem(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the partner’s item to remove.</param>
    /// <returns>True if the item was successfully removed; otherwise false.</returns>
    public byte RemovePartnerItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CAC50)(ref this, itemID);

    /// <summary>Resets the secure trade interface to reflect a new or existing partner by clearing lists, updating item counts, and refreshing the trade button state.
    /// <code>Offset: 0x004CACF0
    /// void __thiscall gmSecureTradeUI::Reset(gmSecureTradeUI*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CACF0)(ref this);

    /// <summary>Initializes secure trade UI by registering notice handlers, retrieving child components such as buttons, labels, and item lists, and configuring drag handling for the item list.
    /// <code>Offset: 0x004CAD50
    /// void __thiscall gmSecureTradeUI::PostInit(gmSecureTradeUI*)</code>
    /// </summary>
    /// <param name="this">The gmSecureTradeUI instance to set up.</param>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CAD50)(ref this);

    /// <summary>Handles changes to the secure trade interface's visibility. When the UI is hidden it removes object‑range listeners, terminates active trade negotiations and resets the UI to its default state.
    /// <code>Offset: 0x004CB060
    /// void __thiscall gmSecureTradeUI::OnVisibilityChanged(gmSecureTradeUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the UI should be shown; false when it becomes hidden.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, byte, void>)0x004CB060)(ref this, i_bVisible);

    /// <summary>Adds an item to the correct side of the secure trade UI by invoking the appropriate internal method based on the trade list identifier.
    /// <code>Offset: 0x004CB0F0
    /// void __thiscall gmSecureTradeUI::RecvNotice_AddItemToTrade(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">Unique identifier of the item to be added.</param>
    /// <param name="i_eTradeListID">Indicates which trade list receives the item (1 for the player’s list, 2 for the partner’s list).</param>
    /// <param name="i_uiPos">Index position within the selected trade list where the item should appear.</param>
    public void RecvNotice_AddItemToTrade(uint i_iidItem, uint i_eTradeListID, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, uint, void>)0x004CB0F0)(ref this, i_iidItem, i_eTradeListID, i_uiPos);

    /// <summary>Clears all trade acceptance information, resetting the secure trade UI to its default state.
    /// <code>Offset: 0x004CB130
    /// void __thiscall gmSecureTradeUI::RecvNotice_ClearTradeAcceptance(gmSecureTradeUI*)</code>
    /// </summary>
    public void RecvNotice_ClearTradeAcceptance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CB130)(ref this);

    /// <summary>Closes an active secure trade session, resetting the UI to its default state and clearing any displayed error message.
    /// <code>Offset: 0x004CB140
    /// void __thiscall gmSecureTradeUI::RecvNotice_CloseTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eError">Error code indicating why the trade was closed.</param>
    public void RecvNotice_CloseTrade(uint i_eError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CB140)(ref this, i_eError);

    /// <summary>Processes a trade registration notice by recording the partner ID and setting up an object range handler for proximity monitoring.
    /// <code>Offset: 0x004CB1B0
    /// void __thiscall gmSecureTradeUI::RecvNotice_RegisterTrade(gmSecureTradeUI*,unsigned int,unsigned int,long double)</code>
    /// </summary>
    /// <param name="i_iidInitiator">Identifier of the player who initiated the trade.</param>
    /// <param name="i_iidPartner">Identifier of the trade partner.</param>
    /// <param name="i_ttStamp">Timestamp of the trade notice (currently unused).</param>
    public void RecvNotice_RegisterTrade(uint i_iidInitiator, uint i_iidPartner, double i_ttStamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, double, void>)0x004CB1B0)(ref this, i_iidInitiator, i_iidPartner, i_ttStamp);

    /// <summary>Removes an item from the secure trade UI based on a received notice.
    /// <code>Offset: 0x004CB220
    /// void __thiscall gmSecureTradeUI::RecvNotice_RemoveItemFromTrade(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">Unique identifier of the item to remove.</param>
    /// <param name="i_eTradeListID">Identifier for which trade list contains the item: 1 for the local player’s added items, 2 for the partner’s items.</param>
    public void RecvNotice_RemoveItemFromTrade(uint i_iidItem, uint i_eTradeListID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, void>)0x004CB220)(ref this, i_iidItem, i_eTradeListID);

    /// <summary>Resets the secure trade interface, clearing all pending trade items and restoring its default UI state for a new transaction.
    /// <code>Offset: 0x004CB260
    /// void __thiscall gmSecureTradeUI::RecvNotice_ResetTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidSource">Identifier of the notice source; this value is ignored during reset.</param>
    public void RecvNotice_ResetTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CB260)(ref this, i_iidSource);

    /// <summary>Handles a trade failure notification by removing the failed item from the trading UI.
    /// <code>Offset: 0x004CB270
    /// void __thiscall gmSecureTradeUI::RecvNotice_TradeFailure(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">Identifier of the item that could not be traded.</param>
    /// <param name="i_eError">Code indicating reason for failure (currently unused).</param>
    public void RecvNotice_TradeFailure(uint i_iidItem, uint i_eError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, void>)0x004CB270)(ref this, i_iidItem, i_eError);

    /// <summary>Determines whether a specified item can be added to the secure trade interface by checking its existence, ownership, and that it is not already selected for trading.
    /// <code>Offset: 0x004CB290
    /// bool __thiscall gmSecureTradeUI::DragItemAcceptable(gmSecureTradeUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_iidItem">The unique identifier of the item to evaluate.</param>
    /// <param name="silent">If true, suppresses error notices when the item cannot be traded; otherwise an informative notice may be displayed.</param>
    /// <returns>True if the item is eligible for dragging into the trade list; otherwise false.</returns>
    public byte DragItemAcceptable(uint i_iidItem, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte, byte>)0x004CB290)(ref this, i_iidItem, silent);

    /// <summary>Adds a specified item to the current player's secure‑trade list. If the item is a container and <paramref name="addContents"/> is true, each contained item is added recursively as a separate entry; otherwise containers with contents are not added.
    /// <code>Offset: 0x004CB370
    /// int __thiscall gmSecureTradeUI::AddItem(gmSecureTradeUI*,unsigned int,int,bool,bool,bool)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item to add.</param>
    /// <param name="position">Zero‑based index at which to insert the item in the list. The underlying list insertion logic determines placement if the value is out of range.</param>
    /// <param name="removeDuplicates">Ignored; duplicates are prevented by checking if the item already exists in the list.</param>
    /// <param name="addContents">When true and the item contains other items, each contained item is added recursively. When false, only non‑container items are added.</param>
    /// <param name="excludeIfUnacceptable">Ignored; has no effect on the operation.</param>
    /// <returns>Zero‑based index of the inserted item if successful, or –1 if the item could not be added (e.g., duplicate, missing UI list, or a container with contents when <paramref name="addContents"/> is false).</returns>
    public int AddItem(uint itemID, int position, byte removeDuplicates, byte addContents, byte excludeIfUnacceptable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, int, byte, byte, byte, int>)0x004CB370)(ref this, itemID, position, removeDuplicates, addContents, excludeIfUnacceptable);

    /// <summary>Accepts a dragged item into the secure trade UI, handling stack splitting or direct addition, and displays notifications about the action.
    /// <code>Offset: 0x004CB630
    /// bool __thiscall gmSecureTradeUI::AcceptDragObject(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidObject">The unique identifier of the object being dragged.</param>
    /// <returns>True if the object was successfully accepted and processed; otherwise false.</returns>
    public byte AcceptDragObject(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CB630)(ref this, i_iidObject);

    /// <summary>Processes a server notification that the trade partner has moved an item into their offer, adding the item to the partner’s list and updating UI elements such as item counts and the trade button state.
    /// <code>Offset: 0x004CB810
    /// void __thiscall gmSecureTradeUI::ServerSaysMoveItem(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item moved by the partner.</param>
    /// <param name="oldContainer">Previous container identifier of the item (unused in this routine).</param>
    /// <param name="oldWielder">Previous wielder identifier of the item (unused in this routine).</param>
    /// <param name="oldLocation">Previous slot index within its container (unused in this routine).</param>
    /// <param name="newContainer">Identifier for the partner’s trade system; must match current trade partner to process.</param>
    /// <param name="place">Desired slot position within the partner’s trade list (ignored by implementation).</param>
    /// <param name="newWielder">Current wielder identifier after move (unused in this routine).</param>
    /// <param name="newLocation">New slot index within its container after move (unused in this routine).</param>
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CB810)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Handles a server notification indicating an item has been moved from one container/location to another within the secure trade UI, forwarding the information to the underlying handler for processing.
    /// <code>Offset: 0x004CB920
    /// void __thiscall gmSecureTradeUI::RecvNotice_ServerSaysMoveItem(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">Unique identifier of the item being transferred.</param>
    /// <param name="i_oldContainer">Identifier of the container where the item was originally located.</param>
    /// <param name="i_oldWielder">Entity ID that owned the item prior to the move.</param>
    /// <param name="i_oldLocation">Slot or location index of the item within its original container.</param>
    /// <param name="i_newContainer">Identifier of the destination container where the item will reside after the move.</param>
    /// <param name="i_place">Index specifying the item's position within the new container.</param>
    /// <param name="i_newWielder">Entity ID that will own the item following the transfer.</param>
    /// <param name="i_newLocation">Slot or location index of the item in its destination container.</param>
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CB920)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);

    /// <summary>Responds to an item attribute change notice during a secure trade session by verifying if the affected item matches the currently split item; if so, adds the item back to the trade UI and resets split state.
    /// <code>Offset: 0x004CB930
    /// void __thiscall gmSecureTradeUI::RecvNotice_ItemAttributesChanged(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidObject">The instance ID of the item whose attributes changed.</param>
    /// <param name="i_attrib">Bitmask indicating which attributes were altered (flag 1 denotes a relevant change).</param>
    public void RecvNotice_ItemAttributesChanged(uint i_iidObject, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, void>)0x004CB930)(ref this, i_iidObject, i_attrib);

    /// <summary>Attempts to add an item to the secure trade UI after performing validation checks. The item is rejected if it already appears in the trade list or if it is a splitable selected stack that has not been divided, and a notice informs the player when the item cannot be traded.
    /// <code>Offset: 0x004CB940
    /// bool __thiscall gmSecureTradeUI::TradeAnItemForDummies(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItemToTrade">The ID of the item to add to the trade list.</param>
    /// <returns>True if the item was added successfully; otherwise false.</returns>
    public byte TradeAnItemForDummies(uint i_iidItemToTrade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CB940)(ref this, i_iidItemToTrade);

    /// <summary>Processes a drop release event in the secure trade interface, validating the dragged item and target location before adding the item to the trade list when permissible.
    /// <code>Offset: 0x004CBA00
    /// void __thiscall gmSecureTradeUI::HandleDropRelease(gmSecureTradeUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message that triggered the drop release.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004CBA00)(ref this, i_rMsg);

    /// <summary>Handles element messages for the secure trade interface, processing button actions such as accepting or declining a trade, resetting trades, performing cleanup after trade completion, and handling item drop releases.
    /// <code>Offset: 0x004CBA70
    /// UIElementMessageListenResult __thiscall gmSecureTradeUI::ListenToElementMessage(gmSecureTradeUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmSecureTradeUI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the UI element event to process.</param>
    /// <returns>Result from the base UIElement processing indicating whether the message was handled.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CBA70)(ref this, i_rMsg);

    /// <summary>Processes a trade notice by initiating the trade of an item identified by its object ID within the secure trade UI.
    /// <code>Offset: 0x004CBB20
    /// void __thiscall gmSecureTradeUI::RecvNotice_TradeAnItemForDummies(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidObject">The unique identifier of the item to be traded.</param>
    public void RecvNotice_TradeAnItemForDummies(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CBB20)(ref this, i_iidObject);
}

