namespace ACBindings.Internal;


/// <summary>Manages user interface elements, orchestrating their creation, input handling, focus management, drag‑and‑drop operations, tooltips, cursor changes, and message broadcasting within the UI subsystem.</summary>
public unsafe struct UIElementManager : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Statics
    public static ACBindings.Internal.UIElementManager** s_pInstance = (ACBindings.Internal.UIElementManager**)0x0083E03C;

    // Child Types
    public unsafe struct UIElementManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, ACBindings.Internal.InputEvent*, void> ActionHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, int, int, void> MouseMoveHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, int, int, void> MouseLookHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, byte, int, void> FocusSwitchHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, System.Char, void> CharacterHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElementManager*, ACBindings.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___UIElement_ptr m_deleteQueue;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_elementList;
    public ACBindings.Internal.HashTable__uint__void_ptr m_classCreateMethodTable;
    public ACBindings.Internal.LayoutDesc* m_pHollowLayoutDesc;
    public ACBindings.Internal.ElementDesc* m_pHollowElementDesc;
    public ACBindings.Internal.UIElement* m_pRootElement;
    public ACBindings.Internal.Vector3 m_vGlobalScale;
    public ACBindings.Internal.AutoGrowHashTable__uint___AutoGrowHashTable__uint___SmartArray___UIMessageData m_elementListenerTable;
    public ACBindings.Internal.AutoGrowHashTable__uint___SmartArray___UIMessageData m_globalMessageListenerTable;
    public ACBindings.Internal.SmartArray___UIMessageRemovalData m_aUIMessageRemovalData;
    public ACBindings.Internal.AutoGrowHashTable__uint___SmartArray___UIElement_ptr m_elementInputActionListenerTable;
    public ACBindings.Internal.List___UIElementMessageInfo m_listQueuedElementMessages;
    public byte m_bBroadcastingMessage;
    public ACBindings.Internal.IDClass____tagDataID m_defaultCursorDID;
    public int m_defaultCursorHotX;
    public int m_defaultCursorHotY;
    public ACBindings.Internal.IDClass____tagDataID m_lastCursorDID;
    public int m_lastCursorHotX;
    public int m_lastCursorHotY;
    public byte m_bPerformMouseHitTest;
    public ACBindings.Internal.UIElement* m_pElementLastOver;
    public ACBindings.Internal.UIElement* m_pElementLastEntered;
    public ACBindings.Internal.UIElement* m_pElementWithMouseCapture;
    public ACBindings.Internal.UIElement* m_pElementLastDragCursorOver;
    public ACBindings.Internal.HashSet__uint m_setActionsTriggeringCapture;
    public uint m_nMouseCapture;
    public byte m_bDoVisualMouseDebugging;
    public ACBindings.Internal.IDClass____tagDataID m_debugFontDID;
    public byte m_bMouseHasLeftTheWindow;
    public double m_lastMouseMoveTime;
    public double m_tooltipStart;
    public byte m_tooltipEnable;
    public float m_tooltipDelay;
    public float m_tooltipDuration;
    public ACBindings.Internal.UIElement* m_pTooltipOwner;
    public ACBindings.Internal.UIElement* m_pTooltipElement;
    public double m_buttonDownTime;
    public int m_dragX;
    public int m_dragY;
    public int m_dragBaseX;
    public int m_dragBaseY;
    public ACBindings.Internal.UIElement* m_pcPotentialDragElement;
    public ACBindings.Internal.UIElement* m_dragElement;
    public ACBindings.Internal.UIElement* m_dragOwner;
    public byte m_bDragStarted;
    public byte m_bHoverStarted;
    public ACBindings.Internal.UIElement* m_focusElement;
    public ACBindings.Internal.UIElement* m_activeElement;
    public ACBindings.Internal.SmartArray___UIElement_ptr m_activatableElements;
    public ACBindings.Internal.ContextMenu* m_pCSM;

    // Generated Constructor
    public UIElementManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys the global UI element manager instance, freeing resources and resetting its reference.
    /// <code>Offset: 0x00459310
    /// void __cdecl UIElementManager::DestroyUIElementManager()</code>
    /// </summary>
    public static void DestroyUIElementManager() => ((delegate* unmanaged[Cdecl]<void>)0x00459310)();

    /// <summary>Initiates a hover action on the UI element currently under the mouse pointer using the supplied window coordinates, setting an internal flag when the hover starts successfully.
    /// <code>Offset: 0x00459370
    /// void __thiscall UIElementManager::StartHover(UIElementManager*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">The X coordinate of the cursor within the application window.</param>
    /// <param name="i_yWindow">The Y coordinate of the cursor within the application window.</param>
    public void StartHover(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x00459370)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// Stops the current hover state by clearing the hovered element, invoking its OnLoseFocus handler if applicable, and removing any active tooltip from the deletion queue.
    /// 
    /// <code>Offset: 0x004593A0
    /// void __thiscall UIElementManager::StopHover(UIElementManager*)</code>
    /// </summary>
    public void StopHover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x004593A0)(ref this);

    /// <summary>Recalculates the start time for the active tooltip to adjust its display duration.
    /// <code>Offset: 0x004593E0
    /// void __thiscall UIElementManager::SetDurationForCurrentTooltip(UIElementManager*,float)</code>
    /// </summary>
    /// <param name="i_secCustomDuration">The desired length of the tooltip in seconds.</param>
    public void SetDurationForCurrentTooltip(float i_secCustomDuration) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, float, void>)0x004593E0)(ref this, i_secCustomDuration);

    /// <summary>Ends any active drag‑and‑drop session by clearing drag state, scheduling deletion of the dragged UI element if it is flagged for removal, and resetting related member variables.
    /// <code>Offset: 0x00459400
    /// bool __thiscall UIElementManager::ClearDragandDrop(UIElementManager*)</code>
    /// </summary>
    /// <returns>Always true to signal that the clear operation completed successfully.</returns>
    public byte ClearDragandDrop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte>)0x00459400)(ref this);

    /// <summary>Sets the visibility of this UIElementManager and its associated components such as the context menu and tooltip.
    /// <code>Offset: 0x00459440
    /// void __thiscall UIElementManager::SetVisible(UIElementManager*,bool)</code>
    /// </summary>
    /// <param name="visible">True to show all components; false to hide them.</param>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte, void>)0x00459440)(ref this, visible);

    /// <summary>Processes queued UI message removals, updating listener arrays to remove specified listeners and clearing the removal queue.
    /// <code>Offset: 0x004596B0
    /// void __thiscall UIElementManager::ProcessUIMessageRemovalData(UIElementManager*)</code>
    /// </summary>
    public void ProcessUIMessageRemovalData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x004596B0)(ref this);

    /// <summary>Displays a tooltip UI element for the specified owner, positioning it within screen bounds and recording its start time.
    /// <code>Offset: 0x00459770
    /// void __thiscall UIElementManager::StartTooltip(UIElementManager*,UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pElementOwner">The UI element that owns or triggers the tooltip.</param>
    /// <param name="i_pElementTooltip">The tooltip UI element to be displayed.</param>
    public void StartTooltip(ACBindings.Internal.UIElement* i_pElementOwner, ACBindings.Internal.UIElement* i_pElementTooltip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void>)0x00459770)(ref this, i_pElementOwner, i_pElementTooltip);

    /// <summary>Terminates an active drag‑and‑drop session, notifying the source and target elements, releasing focus from the owner, and clearing internal state. If the dragged element is marked for deletion, it is queued for removal.
    /// <code>Offset: 0x00459880
    /// void __thiscall UIElementManager::StopDragandDrop(UIElementManager*)</code>
    /// </summary>
    public void StopDragandDrop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x00459880)(ref this);

    /// <summary>Removes the specified UIElement from the manager’s activatable element collection when it is non‑null.
    /// <code>Offset: 0x00459960
    /// void __thiscall UIElementManager::UnregisterActivatable(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="element">The UIElement to unregister as activatable.</param>
    public void UnregisterActivatable(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x00459960)(ref this, element);

    /// <summary>Searches the list of activatable UI elements in reverse order and deactivates the input‑action callback of the first visible element found; the boolean flag is currently ignored.
    /// <code>Offset: 0x00459980
    /// void __thiscall UIElementManager::ActivateNext(UIElementManager*,bool)</code>
    /// </summary>
    /// <param name="backwards">Specifies whether to search the list backwards; this argument is not used by the current implementation.</param>
    public void ActivateNext(byte backwards) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte, void>)0x00459980)(ref this, backwards);

    /// <summary>Retrieves the UI element whose element ID matches the supplied identifier from the manager's internal list.
    /// <code>Offset: 0x00459A00
    /// UIElement* __thiscall UIElementManager::GetElement(UIElementManager*,unsigned int)</code>
    /// </summary>
    /// <param name="ID">The unique element identifier to look up.</param>
    /// <returns>A pointer to the matching UIElement instance, or null if no match exists.</returns>
    public ACBindings.Internal.UIElement* GetElement(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.UIElement*>)0x00459A00)(ref this, ID);

    /// <summary>Removes all UI elements queued for deletion from the manager by invoking their OnLoseFocus callbacks and destroying them before clearing the queue.
    /// <code>Offset: 0x0045A350
    /// void __thiscall UIElementManager::CleanDeleteQueue(UIElementManager*)</code>
    /// </summary>
    public void CleanDeleteQueue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045A350)(ref this);

    /// <summary>Sets the UI cursor image and hotspot based on a data identifier. Optionally updates stored default cursor values when the flag is set.
    /// <code>Offset: 0x0045A910
    /// const RenderSurface* __thiscall UIElementManager::SetCursor(_DWORD*,int,unsigned int,unsigned int,char)</code>
    /// </summary>
    /// <param name="a2">Data ID of the cursor image to load; if it equals INVALID_DID_52.baseclass_0.id, no change occurs.</param>
    /// <param name="xHotSpot">Horizontal coordinate of the cursor hotspot.</param>
    /// <param name="yHotSpot">Vertical coordinate of the cursor hotspot.</param>
    /// <param name="a5">When non‑zero, updates the manager’s default cursor ID and hotspot to the supplied values.</param>
    /// <returns>Pointer to the RenderSurface used for the cursor image, or nullptr if the surface could not be loaded. The returned surface has been released before being returned.</returns>
    public ACBindings.Internal.RenderSurface* SetCursor(int a2, uint xHotSpot, uint yHotSpot, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, uint, uint, sbyte, ACBindings.Internal.RenderSurface*>)0x0045A910)(ref this, a2, xHotSpot, yHotSpot, a5);

    /// <summary>Broadcasts a UI element message to the target element, or queues it if another broadcast is already in progress.
    /// <code>Offset: 0x0045AC50
    /// bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message data containing the target element, message ID, parameters, and point coordinates.</param>
    /// <returns>True if the target element processed the message; otherwise false.</returns>
    public byte BroadcastElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElementMessageInfo*, byte>)0x0045AC50)(ref this, i_rMsg);

    /// <summary>Updates the UI cursor by evaluating elements that currently have mouse capture or were last entered. If either element can relinquish focus, its custom cursor is applied; otherwise the default cursor is restored.
    /// <code>Offset: 0x0045AD00
    /// void __thiscall UIElementManager::CheckCursor(UIElementManager*)</code>
    /// </summary>
    public void CheckCursor() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045AD00)(ref this);

    /// <summary>Draws a UI element by linking its associated UIObject into the rendering list after the preceding object, triggering any pending actions and processing dirty regions.
    /// <code>Offset: 0x0045AD80
    /// void __thiscall UIElementManager::DrawRegionWithObject(UIElementManager*,UIElement*,UIObject**)</code>
    /// </summary>
    /// <param name="this">Manager instance handling drawing of UI elements.</param>
    /// <param name="i_pElementWithObject">The UI element whose visual representation is to be drawn.</param>
    /// <param name="io_pPrevObject">Reference to the previous UIObject in the render order; updated to the newly linked object after drawing.</param>
    public void DrawRegionWithObject(ACBindings.Internal.UIElement* i_pElementWithObject, ACBindings.Internal.UIObject** io_pPrevObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, void>)0x0045AD80)(ref this, i_pElementWithObject, io_pPrevObject);

    /// <summary>Creates a UI element and its child hierarchy from the provided layout and element descriptors, selecting the appropriate constructor based on type or engine identifier and registering event listeners.
    /// <code>Offset: 0x0045B1A0
    /// UIElement* __thiscall UIElementManager::CreateElementRecursiveFromFullDesc(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="this">The UIElementManager instance used to create and manage elements.</param>
    /// <param name="layout">Layout descriptor containing global layout information.</param>
    /// <param name="full_desc">Full element description defining the element’s properties, children, and behavior.</param>
    /// <returns>Pointer to the newly created UIElement or null if creation fails.</returns>
    public ACBindings.Internal.UIElement* CreateElementRecursiveFromFullDesc(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045B1A0)(ref this, layout, full_desc);

    /// <summary>Adds the specified UIElement to the delete queue, then triggers its IInputActionCallback destructor, clears ownership if set, and signals it has lost focus.
    /// <code>Offset: 0x0045B350
    /// void __thiscall UIElementManager::AddElementToDeleteQueue(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="element">The UIElement to enqueue for deletion; ignored if null or already queued.</param>
    public void AddElementToDeleteQueue(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045B350)(ref this, element);

    /// <summary>Broadcasts a UI message to all listeners registered for a specific element ID and message ID. Invokes each listener's callback with the supplied integer data and returns true if at least one callback handled the message.
    /// <code>Offset: 0x0045B3A0
    /// bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,unsigned int,UIElement*,unsigned int,int)</code>
    /// </summary>
    /// <param name="elementID">Identifier of the target UI element.</param>
    /// <param name="element">Pointer to the UIElement instance associated with the message.</param>
    /// <param name="messageID">Identifier of the UI message to broadcast.</param>
    /// <param name="data_int">Integer data passed to each listener callback.</param>
    /// <returns>True if any registered listener handled the message; otherwise false.</returns>
    public byte BroadcastElementMessage(uint elementID, ACBindings.Internal.UIElement* element, uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.UIElement*, uint, int, byte>)0x0045B3A0)(ref this, elementID, element, messageID, data_int);

    /// <summary>Broadcasts a UI message from the specified element to registered listeners and returns whether the broadcast succeeded.
    /// <code>Offset: 0x0045B450
    /// bool __thiscall UIElementManager::BroadcastElementMessage(UIElementManager*,UIElement*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">Reference to the UIElementManager instance handling the broadcast.</param>
    /// <param name="i_pElement">The source element that initiates the message; if null, broadcasting fails.</param>
    /// <param name="i_idMessage">Identifier of the message to send.</param>
    /// <param name="i_dwParam1">First custom parameter for the message payload.</param>
    /// <param name="i_dwParam2">Second custom parameter for the message payload.</param>
    /// <returns>True if the broadcast was performed; otherwise false when the element is null or broadcasting fails.</returns>
    public byte BroadcastElementMessage(ACBindings.Internal.UIElement* i_pElement, uint i_idMessage, uint i_dwParam1, uint i_dwParam2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, uint, uint, uint, byte>)0x0045B450)(ref this, i_pElement, i_idMessage, i_dwParam1, i_dwParam2);

    /// <summary>Broadcasts a global UI event identified by <paramref name="messageID"/> and delivers <paramref name="data_int"/> to all registered listeners for that event.
    /// <code>Offset: 0x0045B4C0
    /// void __thiscall UIElementManager::BroadcastGlobalMessage(UIElementManager*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">The unique identifier of the global message to broadcast.</param>
    /// <param name="data_int">An integer payload associated with the message, passed to each listener's callback.</param>
    public void BroadcastGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, int, void>)0x0045B4C0)(ref this, messageID, data_int);

    /// <summary>Unregisters an element’s listener for a specific message type, decreasing the reference count and scheduling cleanup when the last registration is removed.
    /// <code>Offset: 0x0045B540
    /// void __thiscall UIElementManager::UnRegisterForMessageInternal(int*,int,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the element whose listener should be unregistered.</param>
    /// <param name="a3">Pointer to the hash table containing message listeners for that message type.</param>
    /// <param name="a4">Key used to locate the appropriate entry within the hash table.</param>
    public void UnRegisterForMessageInternal(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int*, int, void>)0x0045B540)(ref this, a2, a3, a4);

    /// <summary>Unregisters a UI element from a specific message listener entry, marking it inactive and queuing its removal for later processing.
    /// <code>Offset: 0x0045B5D0
    /// void __thiscall UIElementManager::UnRegisterForAllMessagesInternal(int*,int,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the UI element to unregister.</param>
    /// <param name="a3">Pointer to the internal listener table entry (an array containing the element ID and a flag) associated with the message type from which the element should be removed.</param>
    public void UnRegisterForAllMessagesInternal(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x0045B5D0)(ref this, a2, a3);

    /// <summary>Switches the current mouse‑over element, updating internal tracking, notifying elements of enter/exit events, managing hover and capture behavior, and handling drag cursor transitions.
    /// <code>Offset: 0x0045B640
    /// void __thiscall UIElementManager::SwitchMouseOver(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="this">The UIElementManager instance that manages input state for all UI elements.</param>
    /// <param name="pCurMouseOver">The new UIElement currently under the mouse pointer; may be null if no element is hovered.</param>
    public void SwitchMouseOver(ACBindings.Internal.UIElement* pCurMouseOver) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045B640)(ref this, pCurMouseOver);

    /// <summary>Broadcasts a visibility‑toggle message to all UI elements that have registered for the specified input action.
    /// <code>Offset: 0x0045B740
    /// bool __thiscall UIElementManager::DoVisibilityToggleAction(UIElementManager*,unsigned int)</code>
    /// </summary>
    /// <param name="action">The identifier of the input action whose listeners should receive the toggle notification.</param>
    /// <returns>True if the action exists in the listener table (even if no elements are present); otherwise, false.</returns>
    public byte DoVisibilityToggleAction(uint action) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, byte>)0x0045B740)(ref this, action);

    /// <summary>Checks tooltip visibility for the UI element under the cursor, hiding it after the configured duration or starting hover when the mouse remains over an element beyond its delay threshold.
    /// <code>Offset: 0x0045B7C0
    /// void __thiscall UIElementManager::CheckTooltip(UIElementManager*)</code>
    /// </summary>
    public void CheckTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045B7C0)(ref this);

    /// <summary>Draws the specified UI element and its children when the element’s internal flag is set, optionally delegating to DrawRegionWithObject if another flag is present.
    /// <code>Offset: 0x0045B8A0
    /// void __thiscall UIElementManager::DrawRegion(UIElementManager*,UIElement*,UIObject**)</code>
    /// </summary>
    /// <param name="i_pElement">The UI element whose region should be drawn.</param>
    /// <param name="io_pPrevObject">Reference to a UIObject pointer used by DrawRegionWithObject; may be updated during the call.</param>
    public void DrawRegion(ACBindings.Internal.UIElement* i_pElement, ACBindings.Internal.UIObject** io_pPrevObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, void>)0x0045B8A0)(ref this, i_pElement, io_pPrevObject);

    /// <summary>Draws dirty regions for all child UI elements starting from the root element by invoking DrawRegion on each marked element.
    /// <code>Offset: 0x0045B900
    /// void __thiscall UIElementManager::DrawDirtyRegions(UIElementManager*)</code>
    /// </summary>
    public void DrawDirtyRegions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045B900)(ref this);

    /// <summary>Assigns a new UI element as the current focus, notifying the previous element that it has lost focus and invoking its cleanup routine. The new element receives a focus‑gained message and is prepared to handle input.
    /// <code>Offset: 0x0045B970
    /// void __thiscall UIElementManager::SetFocusElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="this">The UIElementManager instance managing the UI hierarchy.</param>
    /// <param name="focusElement">The UI element to become focused; passing null clears the current focus.</param>
    public void SetFocusElement(ACBindings.Internal.UIElement* focusElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045B970)(ref this, focusElement);

    /// <summary>Creates a UI element from a partial description by expanding it into a full definition and delegating to the full‑description creation routine.
    /// <code>Offset: 0x0045C090
    /// UIElement* __thiscall UIElementManager::CreateElementRecursiveFromPartialDesc(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="this">The UIElementManager instance performing the creation.</param>
    /// <param name="layout">Layout context used for positioning and resources.</param>
    /// <param name="desc">Partial element description to be expanded.</param>
    /// <returns>Pointer to the newly created UIElement, or null if expansion fails.</returns>
    public ACBindings.Internal.UIElement* CreateElementRecursiveFromPartialDesc(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045C090)(ref this, layout, desc);

    /// <summary>Destroys the specified UIElement, clears its ownership flag if set, and triggers a lose‑focus notification.
    /// <code>Offset: 0x0045C160
    /// void __thiscall UIElementManager::RemoveAndDeleteRootElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="element">The UIElement instance to delete.</param>
    public void RemoveAndDeleteRootElement(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045C160)(ref this, element);

    /// <summary>Removes a listener from receiving messages of a specific type on a designated UI element.
    /// <code>Offset: 0x0045C1B0
    /// void __thiscall UIElementManager::UnRegisterForElementMessage(UIElementManager*,UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="listener">The UIListener to be unregistered; may be null.</param>
    /// <param name="elementID">Identifier of the UI element whose listeners are being modified.</param>
    /// <param name="messageID">Message identifier that should no longer trigger callbacks for this listener on the specified element.</param>
    public void UnRegisterForElementMessage(ACBindings.Internal.UIListener* listener, uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, uint, void>)0x0045C1B0)(ref this, listener, elementID, messageID);

    /// <summary>Removes a listener's registration for a specific global message, so it no longer receives that notification.
    /// <code>Offset: 0x0045C1F0
    /// void __thiscall UIElementManager::UnRegisterForGlobalMessage(UIElementManager*,UIListener*,unsigned int)</code>
    /// </summary>
    /// <param name="listener">The UIListener to unregister from the global message system.</param>
    /// <param name="messageID">Identifier of the global message type to stop listening for.</param>
    public void UnRegisterForGlobalMessage(ACBindings.Internal.UIListener* listener, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, void>)0x0045C1F0)(ref this, listener, messageID);

    /// <summary>Removes a listener from all element‑specific and global message registration tables managed by this UIElementManager.
    /// <code>Offset: 0x0045C210
    /// void __thiscall UIElementManager::UnRegisterForAllMessages(UIElementManager*,UIListener*)</code>
    /// </summary>
    /// <param name="listener">The UIListener whose registrations are removed. If null, the method exits without action.</param>
    public void UnRegisterForAllMessages(ACBindings.Internal.UIListener* listener) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, void>)0x0045C210)(ref this, listener);

    /// <summary>Responds to the mouse exiting the application window, clears any current mouse‑over element and records that the cursor has left the UI area.
    /// <code>Offset: 0x0045C380
    /// void __thiscall UIElementManager::MouseLeaveEvent(UIElementManager*)</code>
    /// </summary>
    public void MouseLeaveEvent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045C380)(ref this);

    /// <summary>Updates which UI element is currently under the mouse cursor by performing a hit test at the specified window coordinates unless the mouse has left the window, then switches internal state accordingly.
    /// <code>Offset: 0x0045C390
    /// void __thiscall UIElementManager::UpdateMouseOver(UIElementManager*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">The x coordinate of the mouse within the application window.</param>
    /// <param name="i_yWindow">The y coordinate of the mouse within the application window.</param>
    public void UpdateMouseOver(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x0045C390)(ref this, i_xWindow, i_yWindow);

    /// <summary>Processes a key press event by routing it to the focused UI element, falling back to the active element if no focus is set, and broadcasting globally when neither handles it. Also triggers visibility toggle actions for specific input codes.
    /// <code>Offset: 0x0045C3E0
    /// void __thiscall UIElementManager::KeyPressEvent(UIElementManager*,unsigned int,float)</code>
    /// </summary>
    /// <param name="action">Identifier of the input action (e.g., key code or command).</param>
    /// <param name="extent">Magnitude or repeat count associated with the action.</param>
    public void KeyPressEvent(uint action, float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, float, void>)0x0045C3E0)(ref this, action, extent);

    /// <summary>Resets the current tooltip state by removing any existing tooltip element, clearing hover status, notifying the last hovered element of focus loss, and then determining whether a new tooltip should be displayed.
    /// <code>Offset: 0x0045C440
    /// void __thiscall UIElementManager::ResetTooltip(UIElementManager*)</code>
    /// </summary>
    public void ResetTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045C440)(ref this);

    /// <summary>Registers a UIElement as activatable, ensuring it is present only once in the manager’s activatableElements list.
    /// <code>Offset: 0x0045C4A0
    /// void __thiscall UIElementManager::RegisterActivatable(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="element">The UIElement to register as activatable.</param>
    public void RegisterActivatable(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045C4A0)(ref this, element);

    /// <summary>Activates or deactivates a UI element, updating the manager’s active state and notifying affected elements via callbacks.
    /// <code>Offset: 0x0045C540
    /// void __thiscall UIElementManager::ActivationAlert(UIElementManager*,UIElement*,bool)</code>
    /// </summary>
    /// <param name="element">The UIElement to activate or deactivate.</param>
    /// <param name="active">True activates the element; false deactivates it when it is currently active.</param>
    public void ActivationAlert(ACBindings.Internal.UIElement* element, byte active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, byte, void>)0x0045C540)(ref this, element, active);

    /// <summary>Creates a UIElement from the supplied layout and element description, then invokes its focus loss handler before returning.
    /// <code>Offset: 0x0045CCF0
    /// UIElement* __thiscall UIElementManager::CreateElement(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Descriptor of the overall UI layout including dimensions and child elements.</param>
    /// <param name="desc">Specific element definition that defines appearance and behavior for the new UI element.</param>
    /// <returns>A pointer to the newly created UIElement, or null if creation fails.</returns>
    public ACBindings.Internal.UIElement* CreateElement(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045CCF0)(ref this, layout, desc);

    /// <summary>Responds to tooltip-related preference changes by updating UI settings accordingly.
    /// <code>Offset: 0x0045CD20
    /// void __cdecl UIElementManager::HandlePreferenceCallback(const char**)</code>
    /// </summary>
    /// <param name="a1">Array of strings where the first element is the key of the changed preference (e.g., tooltip delay or enable).</param>
    public static void HandlePreferenceCallback(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x0045CD20)(a1);

    /// <summary>Updates the current mouse‑over element by performing a hit test on UI elements while the cursor stays within the application window and switches to the detected element.
    /// <code>Offset: 0x0045CDE0
    /// void __thiscall UIElementManager::DoMouseUpdate(UIElementManager*)</code>
    /// </summary>
    public void DoMouseUpdate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045CDE0)(ref this);

    /// <summary>Performs a single UI update cycle, handling pending deletions, message removal, mouse hit testing, tooltip logic, broadcasting global events, invoking an external callback if present, and rendering dirty regions.
    /// <code>Offset: 0x0045D0B0
    /// void __thiscall UIElementManager::UseTime(UIElementManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045D0B0)(ref this);

    /// <summary>Creates a root UIElement from the supplied layout and element description, initializing focus handling, ownership flags, and visibility behavior.
    /// <code>Offset: 0x0045D100
    /// UIElement* __thiscall UIElementManager::CreateRootElement(UIElementManager*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="this">The UIElementManager instance performing the creation.</param>
    /// <param name="layout">Layout descriptor defining display properties and contained elements.</param>
    /// <param name="full_desc">Element descriptor containing information for the root element to be instantiated.</param>
    /// <returns>Pointer to the created root UIElement, or nullptr if creation fails.</returns>
    public ACBindings.Internal.UIElement* CreateRootElement(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045D100)(ref this, layout, full_desc);

    /// <summary>Creates a new UI element based on the supplied layout and description, attaching it as a child to the specified parent. The element is initialized recursively through CreateElementRecursiveFromPartialDesc and receives focus-related callbacks before being returned.
    /// <code>Offset: 0x0045D160
    /// UIElement* __thiscall UIElementManager::CreateChildElement(UIElementManager*,UIElement*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="i_pParent">The parent UI element to which the new element will be attached; may be null if no parent is desired.</param>
    /// <param name="layout">Layout descriptor providing sizing and layout information for the element.</param>
    /// <param name="full_desc">Full element description containing properties, states, and child definitions.</param>
    /// <returns>Pointer to the created UIElement instance, or nullptr if creation failed.</returns>
    public ACBindings.Internal.UIElement* CreateChildElement(ACBindings.Internal.UIElement* i_pParent, ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0045D160)(ref this, i_pParent, layout, full_desc);

    /// <summary>Creates a full‑screen hollow UI element that spans the current display resolution, initializing shared layout and element description resources on first use.
    /// <code>Offset: 0x0045D1C0
    /// UIElement* __thiscall UIElementManager::CreateHollowElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pParent">The parent UIElement under which the new hollow element will be added; if null, creation proceeds without an explicit parent.</param>
    /// <returns>A pointer to the newly created UIElement instance, or nullptr if resource initialization fails.</returns>
    public ACBindings.Internal.UIElement* CreateHollowElement(ACBindings.Internal.UIElement* i_pParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0045D1C0)(ref this, i_pParent);

    /// <summary>Registers a factory method that creates UI elements of the specified type within the manager.
    /// <code>Offset: 0x0045D310
    /// void __thiscall UIElementManager::RegisterElementClass(UIElementManager*,unsigned int,UIElement*(__cdecl*createMethod)(const LayoutDesc*, const ElementDesc*))</code>
    /// </summary>
    /// <param name="type">Numeric identifier representing the element class to register.</param>
    /// <param name="createMethod">Pointer to a function that constructs a UIElement given layout and element descriptions.</param>
    public void RegisterElementClass(uint type, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*> createMethod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>, void>)0x0045D310)(ref this, type, createMethod);

    /// <summary>Designates the specified UI element to receive all subsequent mouse messages, resetting capture state if it differs from the current element.
    /// <code>Offset: 0x0045D350
    /// void __thiscall UIElementManager::SetMouseCapture(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pElementToGetAllMouseMessages">The UI element that should capture mouse input.</param>
    public void SetMouseCapture(ACBindings.Internal.UIElement* i_pElementToGetAllMouseMessages) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045D350)(ref this, i_pElementToGetAllMouseMessages);

    /// <summary>Releases the current mouse capture held by the specified UI element if it is currently captured.
    /// <code>Offset: 0x0045D390
    /// void __thiscall UIElementManager::ReleaseMouseCapture(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pElement">The UI element from which to release mouse capture.</param>
    public void ReleaseMouseCapture(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045D390)(ref this, i_pElement);

    /// <summary>Creates the root UIElement from a layout's specified element ID.
    /// <code>Offset: 0x0045D880
    /// UIElement* __thiscall UIElementManager::CreateRootElement(UIElementManager*,const LayoutDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="layout">The layout description containing the elements to create.</param>
    /// <param name="elementID">Identifier of the element within the layout that will become the root.</param>
    /// <returns>A pointer to the created root UIElement, or nullptr if no matching element is found in the layout.</returns>
    public ACBindings.Internal.UIElement* CreateRootElement(ACBindings.Internal.LayoutDesc* layout, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.LayoutDesc*, uint, ACBindings.Internal.UIElement*>)0x0045D880)(ref this, layout, elementID);

    /// <summary>Creates a child UI element under the specified parent using an element ID from a layout descriptor.
    /// <code>Offset: 0x0045D8B0
    /// UIElement* __thiscall UIElementManager::CreateChildElement(UIElementManager*,UIElement*,const LayoutDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="i_pParent">The UIElement that will become the parent of the new child.</param>
    /// <param name="i_layout">Layout description containing elements to instantiate.</param>
    /// <param name="i_elementID">Identifier of the element within the layout to create.</param>
    /// <returns>Pointer to the newly created UIElement, or nullptr if no matching element is found in the layout.</returns>
    public ACBindings.Internal.UIElement* CreateChildElement(ACBindings.Internal.UIElement* i_pParent, ACBindings.Internal.LayoutDesc* i_layout, uint i_elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, ACBindings.Internal.LayoutDesc*, uint, ACBindings.Internal.UIElement*>)0x0045D8B0)(ref this, i_pParent, i_layout, i_elementID);

    /// <summary>Adds the specified UI element as a listener for the given input action, ensuring it is registered only once per action.
    /// <code>Offset: 0x0045D8E0
    /// void __thiscall UIElementManager::RegisterElementForInputAction(UIElementManager*,unsigned int,UIElement*)</code>
    /// </summary>
    /// <param name="i_eInputAction">The identifier of the input action to register the element for.</param>
    /// <param name="i_pElement">The UI element that should receive notifications for the action.</param>
    public void RegisterElementForInputAction(uint i_eInputAction, ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.UIElement*, void>)0x0045D8E0)(ref this, i_eInputAction, i_pElement);

    /// <summary>Removes the specified UI element from every input‑action listener registered with this manager, updating internal tables and freeing any allocated resources.
    /// <code>Offset: 0x0045D970
    /// void __thiscall UIElementManager::UnRegisterElementForAllInputActions(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pElement">The UI element to unregister from all input actions.</param>
    public void UnRegisterElementForAllInputActions(ACBindings.Internal.UIElement* i_pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045D970)(ref this, i_pElement);

    /// <summary>Registers a UI element to receive messages of a specified type. If the element is already listening for the message, its reference count is increased; otherwise a new listener record is created.
    /// <code>Offset: 0x0045DBA0
    /// void __stdcall UIElementManager::RegisterForMessageInternal(int,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the UI element to register.</param>
    /// <param name="a2">Pointer to the hash table that stores listeners for message types.</param>
    /// <param name="a3">Message identifier that the element will observe.</param>
    public static void RegisterForMessageInternal(int a1, int* a2, int a3) => ((delegate* unmanaged[Stdcall]<int, int*, int, void>)0x0045DBA0)(a1, a2, a3);

    /// <summary>Handles a mouse button press event within the UI system, performing hit testing, updating mouse‑over state, managing mouse capture and drag initiation, and dispatching appropriate input callbacks to the focused or captured UI element.
    /// <code>Offset: 0x0045DC40
    /// void __thiscall UIElementManager::MouseDownEvent(UIElementManager*,unsigned int,float)</code>
    /// </summary>
    /// <param name="action">Identifier of the input action (e.g., mouse button code).</param>
    /// <param name="extent">Additional parameter for action magnitude; currently unused.</param>
    public void MouseDownEvent(uint action, float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, float, void>)0x0045DC40)(ref this, action, extent);

    /// <summary>Processes a mouse button release event, releasing any captured element, performing hit testing to determine which UI element is under the cursor, ending drag‑and‑drop operations if active, and notifying the relevant elements of the MouseUp event.
    /// <code>Offset: 0x0045DE30
    /// void __thiscall UIElementManager::MouseUpEvent(UIElementManager*,unsigned int,IInputActionCallback*)</code>
    /// </summary>
    /// <param name="action">The input action identifier for the released mouse button (e.g., left or right click).</param>
    /// <param name="i_pcCallback">A callback interface for input actions; currently unused in this implementation.</param>
    public void MouseUpEvent(uint action, ACBindings.Internal.IInputActionCallback* i_pcCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, uint, ACBindings.Internal.IInputActionCallback*, void>)0x0045DE30)(ref this, action, i_pcCallback);

    /// <summary>Starts a tooltip associated with an element, using a layout template and string information. If another tooltip is active it is removed first. The tooltip is positioned relative to the owner element based on the supplied offset values.
    /// <code>Offset: 0x0045DF70
    /// void __userpurge UIElementManager::StartTooltip(UIElementManager*this@&lt;ecx&gt;,int a2@&lt;ebx&gt;,StringInfo*,UIElement*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="a2">Horizontal or vertical offset used when positioning the tooltip relative to its owner.</param>
    /// <param name="info">StringInfo containing the text that will be displayed in the tooltip.</param>
    /// <param name="i_pElementOwner">UI element that owns the tooltip, typically the element being hovered over.</param>
    /// <param name="elementID">Identifier of the layout element within the layout description to use as the root of the tooltip.</param>
    /// <param name="a6">Layout table ID from which to load the LayoutDesc used for the tooltip's visual structure.</param>
    /// <param name="a7">Optional child index or attribute value specifying a sub-element inside the layout template.</param>
//     public static ACBindings.Internal.void __userpurge StartTooltip(ACBindings.Internal.UIElementManager*this@___ecx __param1, ACBindings.Internal.int a2@___ebx __param2, ACBindings.Internal.StringInfo* info, ACBindings.Internal.UIElement* i_pElementOwner, uint elementID, int a6, int a7) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIElementManager*this@___ecx, ACBindings.Internal.int a2@___ebx, ACBindings.Internal.StringInfo*, ACBindings.Internal.UIElement*, uint, int, int, ACBindings.Internal.void __userpurge>)0x0045DF70)(__param1, __param2, info, i_pElementOwner, elementID, a6, a7);

    /// <summary>Initiates a drag‑and‑drop operation for the specified UI element at the given screen coordinates. Validates that an action is in progress, the click lies within display bounds, then clears any existing drag state and records the element to be dragged.
    /// <code>Offset: 0x0045E120
    /// bool __thiscall UIElementManager::StartDragandDrop(UIElementManager*,UIElement*,int,int)</code>
    /// </summary>
    /// <param name="elem">The UI element that should become the source of a drag operation.</param>
    /// <param name="i_iClickX">The X coordinate of the initial mouse click relative to the window.</param>
    /// <param name="i_iClickY">The Y coordinate of the initial mouse click relative to the window.</param>
    /// <returns>True if a drag‑and‑drop was successfully started; otherwise false (e.g., element is null, not draggable, or preconditions fail).</returns>
    public byte StartDragandDrop(ACBindings.Internal.UIElement* elem, int i_iClickX, int i_iClickY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, int, int, byte>)0x0045E120)(ref this, elem, i_iClickX, i_iClickY);

    /// <summary>
    /// Creates a root UI element from a layout specified by the given data ID and element identifier. Loads the layout, retrieves the element description, constructs the root element, and releases the layout reference.
    /// 
    /// <code>Offset: 0x0045E4B0
    /// UIElement* __thiscall UIElementManager::CreateRootElementByDataID(UIElementManager*,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Identifier used to locate the desired layout resource.</param>
    /// <param name="elementID">Unique identifier of the specific UI element within the layout.</param>
    /// <returns>A pointer to the newly created root UIElement, or null if the layout or element description cannot be found.</returns>
    public ACBindings.Internal.UIElement* CreateRootElementByDataID(int a2, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, uint, ACBindings.Internal.UIElement*>)0x0045E4B0)(ref this, a2, elementID);

    /// <summary>Creates a child UIElement from the specified layout enum and element ID and attaches it to the given parent.
    /// <code>Offset: 0x0045E520
    /// UIElement* __thiscall UIElementManager::CreateChildElementByEnum(UIElementManager*,UIElement*,const unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_pParent">The parent UI element under which the new child is created.</param>
    /// <param name="layoutEnum">Identifier of the layout descriptor that defines the visual and behavioral template for the child.</param>
    /// <param name="elementID">Index or identifier of the specific element within the selected layout to instantiate.</param>
    /// <returns>Pointer to the newly created UIElement, or nullptr if the layout or element could not be found.</returns>
    public ACBindings.Internal.UIElement* CreateChildElementByEnum(ACBindings.Internal.UIElement* i_pParent, uint layoutEnum, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, uint, uint, ACBindings.Internal.UIElement*>)0x0045E520)(ref this, i_pParent, layoutEnum, elementID);

    /// <summary>Creates a child UI element under the specified parent using a layout descriptor identified by the provided data ID and element ID, returning the new element or nullptr if creation fails.
    /// <code>Offset: 0x0045E580
    /// LayoutDesc* __thiscall UIElementManager::CreateChildElementByDid(UIElementManager*,UIElement*,int,unsigned int)</code>
    /// </summary>
    /// <param name="i_pParent">The parent UIElement to which the new child will be attached.</param>
    /// <param name="a3">Data identifier used to locate the layout descriptor containing the desired element.</param>
    /// <param name="elementID">Identifier of the element within the layout descriptor to instantiate.</param>
    /// <returns>Pointer to the newly created child UIElement, or nullptr if the layout or element could not be found.</returns>
    public ACBindings.Internal.LayoutDesc* CreateChildElementByDid(ACBindings.Internal.UIElement* i_pParent, int a3, uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, int, uint, ACBindings.Internal.LayoutDesc*>)0x0045E580)(ref this, i_pParent, a3, elementID);

    /// <summary>Detaches an element from the UI system, unregistering input callbacks, removing it from internal lists, clearing focus or capture state, and purging any queued messages referring to it.
    /// <code>Offset: 0x0045E600
    /// void __thiscall UIElementManager::DeletingElement(UIElementManager*,UIElement*)</code>
    /// </summary>
    /// <p><param name="element">The UI element to delete.</param></p>
    public void DeletingElement(ACBindings.Internal.UIElement* element) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIElement*, void>)0x0045E600)(ref this, element);

    /// <summary>Registers the given listener to receive global messages identified by the specified message ID.
    /// <code>Offset: 0x0045E760
    /// void __thiscall UIElementManager::RegisterForGlobalMessage(UIElementManager*,UIListener*,unsigned int)</code>
    /// </summary>
    /// <param name="listener">The UIListener that will receive the notification.</param>
    /// <param name="messageID">Identifier of the global message type to listen for.</param>
    public void RegisterForGlobalMessage(ACBindings.Internal.UIListener* listener, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, void>)0x0045E760)(ref this, listener, messageID);

    /// <summary>Processes input events by mapping mouse button actions to internal handlers and indicating whether the event was handled.
    /// <code>Offset: 0x0045E780
    /// bool __thiscall UIElementManager::OnAction(UIElementManager*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event containing an action code, start flag, extent value, and callback information used to determine handling logic.</param>
    /// <returns>True if the event corresponds to a recognized mouse button press or release that is processed; otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.InputEvent*, byte>)0x0045E780)(ref this, i_evt);

    /// <summary>Tracks mouse movement across UI elements, performing hit tests, updating hovered element, handling drag‑start logic, moving captured objects, and notifying any element that currently has mouse capture.
    /// <code>Offset: 0x0045E7F0
    /// void __thiscall UIElementManager::MouseMoveHandler(UIElementManager*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">Horizontal position of the mouse cursor in window coordinates.</param>
    /// <param name="i_yWindow">Vertical position of the mouse cursor in window coordinates.</param>
    public void MouseMoveHandler(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, int, int, void>)0x0045E7F0)(ref this, i_xWindow, i_yWindow);

    /// <summary>Prints detailed usage statistics for all UI surfaces in the current UI element hierarchy, including size and memory consumption, to the console or log.
    /// <code>Offset: 0x0045E930
    /// bool __cdecl UIElementManager::ConsoleCommand_PrintUISurfaceUsage()</code>
    /// </summary>
    /// <returns>True when the command executed successfully; otherwise false if no UIElementManager instance exists.</returns>
    public static byte ConsoleCommand_PrintUISurfaceUsage() => ((delegate* unmanaged[Cdecl]<byte>)0x0045E930)();

    /// <summary>Initializes the UI element manager by registering user preferences, setting up rendering callbacks and timers, registering UI component types, creating the root UI element, configuring input actions, and registering console commands for surface usage. The method returns a boolean indicating whether initialization completed successfully.
    /// <code>Offset: 0x0045EEF0
    /// bool __thiscall UIElementManager::Init(UIElementManager*)</code>
    /// </summary>
    /// <returns>true if initialization succeeded; false otherwise.</returns>
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, byte>)0x0045EEF0)(ref this);

    /// <summary>Releases all UI elements managed by the instance, including any active context menu, drag or tooltip elements, and the root element. Clears internal message listener tables, deletes queued elements, unregisters global registry variables and commands, and resets dragging‑related fields.
    /// <code>Offset: 0x0045F200
    /// void __thiscall UIElementManager::Cleanup(UIElementManager*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045F200)(ref this);

    /// <summary>Registers a UIListener to receive messages from a specified UI element; creates the element’s message table when first used and notifies existing elements of focus changes for certain message types.
    /// <code>Offset: 0x0045F380
    /// void __thiscall UIElementManager::RegisterForElementMessage(UIElementManager*,UIListener*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="listener">The listener instance that will process the element's messages.</param>
    /// <param name="elementID">Identifier of the UI element whose messages are targeted.</param>
    /// <param name="messageID">Type of message to subscribe to.</param>
    public void RegisterForElementMessage(ACBindings.Internal.UIListener* listener, uint elementID, uint messageID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, ACBindings.Internal.UIListener*, uint, uint, void>)0x0045F380)(ref this, listener, elementID, messageID);

    /// <summary>Cleans up all internal data structures of UIElementManager, freeing allocated memory for UI elements, listeners, and hash tables. Resets vftable pointers to base classes and unregisters the manager from the global input system if registered.
    /// <code>Offset: 0x0045F4C0
    /// void __thiscall UIElementManager::~UIElementManager(UIElementManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045F4C0)(ref this);

    /// <summary>Initializes the UI element manager, setting up input handling structures, cursor defaults, mouse interaction flags, tooltip parameters, and internal collections for managing UI elements.
    /// <code>Offset: 0x0045F6B0
    /// void __thiscall UIElementManager::UIElementManager(UIElementManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElementManager, void>)0x0045F6B0)(ref this);

    /// <summary>Initialises the global UIElementManager instance when none exists.
    /// <code>Offset: 0x0045F900
    /// void __cdecl UIElementManager::CreateUIElementManager()</code>
    /// </summary>
    public static void CreateUIElementManager() => ((delegate* unmanaged[Cdecl]<void>)0x0045F900)();
}

