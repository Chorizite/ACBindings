namespace ACBindings.Internal;


/// <summary>
/// Manages a scrollable list of UI elements, providing item insertion, removal, selection tracking, drag‑selection, and scrolling control for display within the UI framework. 
/// </summary>
public unsafe struct UIElement_ListBox : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Scrollable BaseClass_UIElement_Scrollable; // ACBindings.Internal.UIElement_Scrollable

    // Child Types
    public unsafe struct UIElement_ListBox_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartUpActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndUpActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartDownActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndDownActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartLeftActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndLeftActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartRightActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndRightActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, void> UpdateLayout; // function pointer

        // Methods
    }
    // UIElement_ListBox::UIListBox_Flag
    public enum UIListBox_Flag : ushort
    {
        UILB_NONE = 0x0,
        UILB_HORIZONTAL = 0x1,
        UILB_CLICK_SELECT = 0x2,
        UILB_DRAG_SELECT = 0x4,
        UILB_DRAG_ROLLOVER = 0x8,
        UILB_ALLOW_UPDATING = 0x10,
        UILB_SELECTED_ITEM_STATE_CHANGE = 0x20,
        UILB_DRAG_SELECTING = 0x40,
        UILB_SET_VIEW_STOP = 0x80,
        UILB_ROLLING_OVER = 0x100,
        UILB_DIRTY = 0x200
    }

    // Members
    public ACBindings.Internal.SmartArray___UIElement_ptr m_listItems;
    public ACBindings.Internal.UIElement* m_pSelectedItem;
    public ACBindings.Internal.UIElement* m_dragLastOver;
    public uint m_lastDragOverState;
    public int m_nCols;
    public int m_nRows;
    public ACBindings.Internal.SmartArray__int m_nItemHeights;
    public ACBindings.Internal.SmartArray__int m_nItemWidths;
    public double m_nAnimStartTime;
    public double m_nAnimEndTime;
    public int m_nAnimStartX;
    public int m_nAnimStartY;
    public int m_nAnimEndX;
    public int m_nAnimEndY;
    public uint m_bitField;

    // Generated Constructor
    public UIElement_ListBox(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves zero‑based index of the selected item in the list box, or -1 when nothing is selected.
    /// <code>Offset: 0x0046CF60
    /// int __thiscall UIElement_ListBox::GetSelectedIndex(UIElement_ListBox*)</code>
    /// </summary>
    /// <returns>An integer representing the selected item's index, or -1 if no item is selected.</returns>
    public int GetSelectedIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int>)0x0046CF60)(ref this);

    /// <summary>Sets the list box's state, invoking its OnAction handler and notifying the previous focused element via OnLoseFocus.
    /// <code>Offset: 0x0046D8F0
    /// bool __thiscall UIElement_ListBox::SetState(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    /// <param name="state">The new state value to apply to the list box.</param>
    /// <returns>True if the state was set successfully; otherwise false.</returns>
    public byte SetState(uint state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, byte>)0x0046D8F0)(ref this, state);

    /// <summary>Initiates the drawing process for the list box by invoking its base class's action handler.
    /// <code>Offset: 0x0046D920
    /// void __thiscall UIElement_ListBox::DrawStart(UIElement_ListBox*)</code>
    /// </summary>
    public void DrawStart() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046D920)(ref this);

    /// <summary>Moves the list box's vertical scroll position to the specified value.
    /// <code>Offset: 0x0046D930
    /// void __thiscall UIElement_ListBox::ScrollToY(UIElement_ListBox*,int)</code>
    /// </summary>
    /// <param name="i_iY">The desired Y offset for scrolling (in pixels).</param>
    public void ScrollToY(int i_iY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046D930)(ref this, i_iY);

    /// <summary>Adjusts the list box's horizontal scroll position to a specified X value.
    /// <code>Offset: 0x0046D950
    /// void __thiscall UIElement_ListBox::ScrollToX(UIElement_ListBox*,int)</code>
    /// </summary>
    /// <param name="i_iX">The target horizontal offset in pixels for the scrollable area.</param>
    public void ScrollToX(int i_iX) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046D950)(ref this, i_iX);

    /// <summary>Configures the list box to display items in a horizontal arrangement when set to true, or revert to vertical layout when false.
    /// <code>Offset: 0x0046D970
    /// void __thiscall UIElement_ListBox::SetHorizontal(UIElement_ListBox*,const bool)</code>
    /// </summary>
    /// <param name="b">True to enable horizontal item arrangement; false for vertical layout.</param>
    public void SetHorizontal(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046D970)(ref this, b);

    /// <summary>Enables or disables click‑selection of items in a UI list box.
    /// <code>Offset: 0x0046D9A0
    /// void __thiscall UIElement_ListBox::SetClickSelect(UIElement_ListBox*,const bool)</code>
    /// </summary>
    /// <param name="b">True to enable click selection; false to disable it.</param>
    public void SetClickSelect(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046D9A0)(ref this, b);

    /// <summary>Enables or disables drag‑selection functionality within the list box.
    /// <code>Offset: 0x0046D9D0
    /// void __thiscall UIElement_ListBox::SetDragSelect(UIElement_ListBox*,const bool)</code>
    /// </summary>
    /// <param name="b">True to activate drag selection; false to deactivate it.</param>
    public void SetDragSelect(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046D9D0)(ref this, b);

    /// <summary>Enables or disables drag‑rollover behavior for the list box.
    /// <code>Offset: 0x0046DA00
    /// void __thiscall UIElement_ListBox::SetDragRollover(UIElement_ListBox*,const bool)</code>
    /// </summary>
    /// <param name="b">If true, drag rollover is activated; if false, it is deactivated.</param>
    public void SetDragRollover(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046DA00)(ref this, b);

    /// <summary>Enables or disables automatic state change for the currently selected item in the list box.
    /// <code>Offset: 0x0046DA30
    /// void __thiscall UIElement_ListBox::SetSelectedItemStateChange(UIElement_ListBox*,const bool)</code>
    /// </summary>
    /// <param name="b">True to enable state changes; false to disable them.</param>
    public void SetSelectedItemStateChange(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046DA30)(ref this, b);

    /// <summary>Sets custom attributes on a list box element, delegating to the base class and handling properties such as click selection, drag behavior, horizontal layout, and state changes.
    /// <code>Offset: 0x0046DA60
    /// void __thiscall UIElement_ListBox::OnSetAttribute(UIElement_ListBox*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The property to apply to the list box.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.BaseProperty*, void>)0x0046DA60)(ref this, attribute);

    /// <summary>Resizes the list box to the specified width and height, updating its scrollable base class and marking the region dirty when dimensions change.
    /// <code>Offset: 0x0046DB70
    /// void __thiscall UIElement_ListBox::ResizeTo(UIElement_ListBox*,const int,const int)</code>
    /// </summary>
    /// <param name="width">Target width in pixels.</param>
    /// <param name="height">Target height in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, void>)0x0046DB70)(ref this, width, height);

    /// <summary>
    /// Handles a change in the size of a child UIElement within the list box by updating internal state and marking its root region dirty so layout can be recomputed.
    /// 
    /// <code>Offset: 0x0046DBD0
    /// void __thiscall UIElement_ListBox::UpdateForChildSizeChange(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pcChild">The UIElement whose size has changed.</param>
    public void UpdateForChildSizeChange(ACBindings.Internal.UIElement* i_pcChild) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, void>)0x0046DBD0)(ref this, i_pcChild);

    /// <summary>Calculates the cumulative width or height of list box items based on a column or row limit.
    /// <code>Offset: 0x0046DBF0
    /// int __thiscall UIElement_ListBox::CalculatePaperSize(UIElement_ListBox*,bool,int)</code>
    /// </summary>
    /// <param name="i_bWidth">If true, sums item widths; if false, sums item heights.</param>
    /// <param name="i_iMax">Maximum number of columns (if i_bWidth) or rows (if !i_bWidth) to include in the calculation. A value of -1 indicates all items.</param>
    /// <returns>Sum of the selected dimensions in pixels.</returns>
    public int CalculatePaperSize(byte i_bWidth, int i_iMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, int, int>)0x0046DBF0)(ref this, i_bWidth, i_iMax);

    /// <summary>Retrieves the item at the specified zero‑based position in the list box, or null if the index exceeds the number of items.
    /// <code>Offset: 0x0046DC50
    /// UIElement* __thiscall UIElement_ListBox::GetItem(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position of the desired item within the list.</param>
    /// <returns>A pointer to the UIElement at the requested position; returns null if the index is out of bounds.</returns>
    public ACBindings.Internal.UIElement* GetItem(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*>)0x0046DC50)(ref this, index);

    /// <summary>
    /// Sets the selected item in the list box to the specified element, clearing the previous selection if it differs, and optionally broadcasting a selection change event.
    /// 
    /// <code>Offset: 0x0046DC70
    /// void __thiscall UIElement_ListBox::SetSelectedItem(UIElement_ListBox*,UIElement*,bool)</code>
    /// </summary>
    /// <param name="pNewSelected">
    /// The UIElement to be set as the new selection; if this is null or not part of the list, the current selection is cleared.
    /// </param>
    /// <param name="bBroadcast">
    /// If true, a message indicating the selection change (or lack thereof) is broadcast after updating the internal state.
    /// </param>
    public void SetSelectedItem(ACBindings.Internal.UIElement* pNewSelected, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, byte, void>)0x0046DC70)(ref this, pNewSelected, bBroadcast);

    /// <summary>Determines the listbox item located at a given client‑space coordinate.
    /// <code>Offset: 0x0046DD60
    /// bool __thiscall UIElement_ListBox::InqItemIndexAtPoint(UIElement_ListBox*,int,int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_iX">Horizontal offset within the listbox's client area.</param>
    /// <param name="i_iY">Vertical offset within the listbox's client area.</param>
    /// <param name="o_iIndex">Receives the zero‑based index of the item at the specified point; undefined if the function returns false.</param>
    /// <returns>True when the coordinates map to a valid item and the index is written; otherwise false, leaving o_iIndex unchanged.</returns>
    public byte InqItemIndexAtPoint(int i_iX, int i_iY, uint* o_iIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, uint*, byte>)0x0046DD60)(ref this, i_iX, i_iY, o_iIndex);

    /// <summary>Removes the element at the given zero‑based index from the list box’s internal array, updating selection and drag state accordingly.
    /// <code>Offset: 0x0046DE80
    /// UIElement* __thiscall UIElement_ListBox::RemoveItem(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    /// <param name="itemIndex">Zero‑based index of the item to remove.</param>
    /// <returns>Pointer to the removed UIElement, or nullptr if the index is out of range or no element exists at that position.</returns>
    public ACBindings.Internal.UIElement* RemoveItem(uint itemIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*>)0x0046DE80)(ref this, itemIndex);

    /// <summary>Initiates a drag‑select mode for the list box, capturing mouse input and marking the element as actively dragging when the appropriate input action is in progress.
    /// <code>Offset: 0x0046DF10
    /// void __thiscall UIElement_ListBox::StartDragSelect(UIElement_ListBox*)</code>
    /// </summary>
    public void StartDragSelect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DF10)(ref this);

    /// <summary>Begins rollover processing for the list box by setting the rollover flag when the control is currently hovered but has not yet entered a rollover state.
    /// <code>Offset: 0x0046DF50
    /// void __thiscall UIElement_ListBox::StartRollover(UIElement_ListBox*)</code>
    /// </summary>
    public void StartRollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DF50)(ref this);

    /// <summary>Ends an active rollover or drag‑over state by clearing the corresponding flag and notifying any element that was last under the cursor.
    /// <code>Offset: 0x0046DF70
    /// void __thiscall UIElement_ListBox::EndRollover(UIElement_ListBox*)</code>
    /// </summary>
    public void EndRollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DF70)(ref this);

    /// <summary>Marks the list box for layout update following changes to its scrollable X/Y state, ensuring the visual representation is refreshed.
    /// <code>Offset: 0x0046DFC0
    /// void __thiscall UIElement_ListBox::AdjustToScrollableXYChange(UIElement_ListBox*)</code>
    /// </summary>
    public void AdjustToScrollableXYChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046DFC0)(ref this);

    /// <summary>Calculates the scroll distance for a list box based on orientation, page or incremental mode.
    /// <code>Offset: 0x0046DFD0
    /// int __thiscall UIElement_ListBox::InqScrollDelta(UIElement_ListBox*,bool,bool,bool)</code>
    /// </summary>
    /// <param name="i_bHorizontal">True to compute horizontal scrolling; false for vertical.</param>
    /// <param name="i_bIncrement">If true, returns the negative of the computed delta (used for decrementing).</param>
    /// <param name="i_bPage">When true, returns the full width or height of the list box as a page scroll amount.</param>
    /// <returns>The pixel offset to move along the chosen axis; positive indicates forward scrolling.</returns>
    public int InqScrollDelta(byte i_bHorizontal, byte i_bIncrement, byte i_bPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, byte, byte, int>)0x0046DFD0)(ref this, i_bHorizontal, i_bIncrement, i_bPage);

    /// <summary>Constructs a list-box UI element by initializing its scrollable base class with the supplied layout and element description, then sets up internal structures for items, selection, drag handling, and animation.
    /// <code>Offset: 0x0046E070
    /// void __thiscall UIElement_ListBox::UIElement_ListBox(UIElement_ListBox*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing dimensions and sub-element information for the UI.</param>
    /// <param name="full_desc">Element descriptor containing appearance and behavior configuration used to set up the list box.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046E070)(ref this, layout, full_desc);

    /// <summary>Obtains a typed reference to the current UI element when requested by type identifier.
    /// <code>Offset: 0x0046E120
    /// UIElement* __thiscall UIElement_ListBox::DynamicCast(UIElement_ListBox*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier specifying the desired UIElement subclass (e.g., 5 for base UIElement, 10 for UIElement_ListBox).</param>
    /// <returns>Pointer to the element cast to the requested type if compatible; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*>)0x0046E120)(ref this, i_eType);

    /// <summary>Releases all resources owned by a UIElement_ListBox instance, clearing item lists, deallocating width/height buffers, resetting drag state, and restoring base class vtables before delegating to the UIElement destructor.
    /// <code>Offset: 0x0046E140
    /// void __thiscall UIElement_ListBox::~UIElement_ListBox(UIElement_ListBox*)</code>
    /// </summary>
    /// <param name="this">Pointer to the UIElement_ListBox object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E140)(ref this);

    /// <summary>Creates a new list‑box UI element using the supplied layout and element description.
    /// <code>Offset: 0x0046E210
    /// UIElement* __cdecl UIElement_ListBox::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes overall layout dimensions and contained elements for the UI.</param>
    /// <param name="full_desc">Provides detailed properties and configuration of the list box element.</param>
    /// <returns>A pointer to the newly constructed UIElement, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046E210)(layout, full_desc);

    /// <summary>Collects all available properties for a list‑box element, combining those inherited from its scrollable base with additional master property group 0xC entries.
    /// <code>Offset: 0x0046E240
    /// bool __thiscall UIElement_ListBox::InqAvailableProperties(UIElement_ListBox*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The set to receive the identified available properties; may be null, in which case the function reports failure.</param>
    /// <returns>True if at least one property was added successfully; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046E240)(ref this, set);

    /// <summary>Handles the mouse‑over event for the top area of a list box, initiating a rollover animation when enabled and conditions are satisfied.
    /// <code>Offset: 0x0046E290
    /// void __thiscall UIElement_ListBox::MouseOverTop(UIElement_ListBox*,bool)</code>
    /// </summary>
    /// <param name="bOverTop">Indicates whether the mouse cursor is currently over the top region of the list box; if true, a rollover may be started.</param>
    public void MouseOverTop(byte bOverTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046E290)(ref this, bOverTop);

    /// <summary>Finalizes a mouse‑up event for the list box, clearing any active drag flags and invoking the drop callback on the last dragged item if one exists.
    /// <code>Offset: 0x0046E2F0
    /// void __thiscall UIElement_ListBox::MouseUp(UIElement_ListBox*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">X coordinate of the mouse pointer in window space at release time.</param>
    /// <param name="yWindow">Y coordinate of the mouse pointer in window space at release time.</param>
    /// <param name="button">Identifier of the mouse button that was released.</param>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, uint, uint, void>)0x0046E2F0)(ref this, xWindow, yWindow, button);

    /// <summary>Retrieves the list element positioned at a specific screen coordinate within a ListBox.
    /// <code>Offset: 0x0046E360
    /// UIElement* __thiscall UIElement_ListBox::GetItemAtPoint(UIElement_ListBox*,int,int)</code>
    /// </summary>
    /// <param name="scrX">Screen X coordinate of the query point.</param>
    /// <param name="scrY">Screen Y coordinate of the query point.</param>
    /// <returns>The UIElement located at the specified coordinates, or null if no item is present there.</returns>
    public ACBindings.Internal.UIElement* GetItemAtPoint(int scrX, int scrY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, ACBindings.Internal.UIElement*>)0x0046E360)(ref this, scrX, scrY);

    /// <summary>Removes a specified UIElement from the list box's collection, returning the removed element or null if not present.
    /// <code>Offset: 0x0046E3A0
    /// UIElement* __thiscall UIElement_ListBox::RemoveItem(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    /// <param name="item">The UIElement to remove from the list.</param>
    /// <returns>The removed UIElement, or nullptr if the item was null or not found in the list.</returns>
    public ACBindings.Internal.UIElement* RemoveItem(ACBindings.Internal.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046E3A0)(ref this, item);

    /// <summary>Removes an existing UIElement from the list box and queues it for deletion.
    /// <code>Offset: 0x0046E3E0
    /// bool __thiscall UIElement_ListBox::DeleteItem(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    /// <param name="pItem">The item to remove from the list.</param>
    /// <returns>True if the item was found, removed, and queued; otherwise false.</returns>
    public byte DeleteItem(ACBindings.Internal.UIElement* pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, byte>)0x0046E3E0)(ref this, pItem);

    /// <summary>Removes the item at the specified index from the list box.
    /// <code>Offset: 0x0046E430
    /// bool __thiscall UIElement_ListBox::DeleteItem(UIElement_ListBox*,int)</code>
    /// </summary>
    /// <param name="itemIndex">The zero‑based position of the item to delete.</param>
    /// <returns>True when an item was successfully removed; otherwise false if the index is out of range or no item exists at that position.</returns>
    public byte DeleteItem(int itemIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, byte>)0x0046E430)(ref this, itemIndex);

    /// <summary>Clears all items from the listbox, enqueuing each element for deletion, resetting selection and drag state, clearing internal storage, updating the state flag, and marking the region dirty to trigger a redraw.
    /// <code>Offset: 0x0046E460
    /// void __thiscall UIElement_ListBox::Flush(UIElement_ListBox*)</code>
    /// </summary>
    public void Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E460)(ref this);

    /// <summary>Initializes or resizes the internal width or height array of a ListBox to match its current column or row count, clearing all entries.
    /// <code>Offset: 0x0046E550
    /// void __thiscall UIElement_ListBox::InitializeWidthHeightArray(UIElement_ListBox*,bool)</code>
    /// </summary>
    /// <param name="i_bWidth">If true, operates on the width array; if false, operates on the height array.</param>
    public void InitializeWidthHeightArray(byte i_bWidth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte, void>)0x0046E550)(ref this, i_bWidth);

    /// <summary>Retrieves the list item located at the current mouse position within the ListBox, or null if the cursor is not over an item.
    /// <code>Offset: 0x0046E5E0
    /// UIElement* __thiscall UIElement_ListBox::GetItemUnderMouse(UIElement_ListBox*)</code>
    /// </summary>
    /// <returns>A pointer to the UIElement representing the item under the mouse; null when no item is hovered or the ListBox is hidden.</returns>
    public ACBindings.Internal.UIElement* GetItemUnderMouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*>)0x0046E5E0)(ref this);

    /// <summary>Updates the rollover state of list‑box items according to the current mouse position, applying hover states while respecting an attribute flag and the list box’s drag‑drop callback.
    /// <code>Offset: 0x0046E650
    /// void __thiscall UIElement_ListBox::Rollover(UIElement_ListBox*)</code>
    /// </summary>
    public void Rollover() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E650)(ref this);

    /// <summary>Handles mouse input to select list box items and start drag‑select operations, then delegates remaining processing to the base scrollable element.
    /// <code>Offset: 0x0046E710
    /// UIElementMessageListenResult __thiscall UIElement_ListBox::ListenToElementMessage(UIElement_ListBox*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI message being processed.</param>
    /// <returns>The listening result returned by the base scrollable implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0046E710)(ref this, i_rMsg);

    /// <summary>Handles a mouse‑down event on the list box, forwarding to the base scrollable implementation and performing item selection or drag‑select initiation when conditions are met.
    /// <code>Offset: 0x0046E760
    /// void __thiscall UIElement_ListBox::MouseDown(UIElement_ListBox*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="x">X coordinate of the mouse click relative to the list box.</param>
    /// <param name="y">Y coordinate of the mouse click relative to the list box.</param>
    /// <param name="button">Button code indicating which mouse button was pressed (e.g., 7 or 10 for selection).</param>
    public void MouseDown(uint x, uint y, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, uint, uint, void>)0x0046E760)(ref this, x, y, button);

    /// <summary>Handles mouse movement over a listbox element, updating item selection and rollover effects based on internal flags.
    /// <code>Offset: 0x0046E7D0
    /// void __thiscall UIElement_ListBox::MouseMove(UIElement_ListBox*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">X coordinate of the mouse within the window.</param>
    /// <param name="i_yWindow">Y coordinate of the mouse within the window.</param>
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, int, void>)0x0046E7D0)(ref this, i_xWindow, i_yWindow);

    /// <summary>Recomputes the layout of a list box’s items: determines column and row counts from attributes or defaults, measures maximum width and height per cell, updates the scrollable area accordingly, and repositions each child element relative to current scroll offsets.
    /// <code>Offset: 0x0046E820
    /// void __thiscall UIElement_ListBox::UpdateLayout(UIElement_ListBox*)</code>
    /// </summary>
    public void UpdateLayout() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0046E820)(ref this);

    /// <summary>Inserts a UIElement into the list box at the specified position unless it is already in the list. The element loses focus before insertion.
    /// <code>Offset: 0x0046EB20
    /// bool __thiscall UIElement_ListBox::InsertItem(UIElement_ListBox*,UIElement*,int)</code>
    /// </summary>
    /// <param name="insertThis">The UIElement to add.</param>
    /// <param name="here">Zero‑based index where the element should be inserted.</param>
    /// <returns>True if insertThis is non‑null; otherwise, false.</returns>
    public byte InsertItem(ACBindings.Internal.UIElement* insertThis, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, int, byte>)0x0046EB20)(ref this, insertThis, here);

    /// <summary>Brings the list item at index <paramref name="i_iItemNum"/> into view by adjusting scroll offsets; if the index is out of range, the function performs no action.
    /// <code>Offset: 0x0046ED00
    /// void __thiscall UIElement_ListBox::ScrollToShow(UIElement_ListBox*,int)</code>
    /// </summary>
    /// <param name="i_iItemNum">Zero‑based index of the list item to display.</param>
    public void ScrollToShow(int i_iItemNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046ED00)(ref this, i_iItemNum);

    /// <summary>Brings the item at the given index into view within the list box by adjusting its scroll position.
    /// <code>Offset: 0x0046EDB0
    /// void __thiscall UIElement_ListBox::ScrollToView(UIElement_ListBox*,int)</code>
    /// </summary>
    /// <param name="i_iItemNum">Index of the target item to display; must be between 0 and the number of items minus one.</param>
    public void ScrollToView(int i_iItemNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, void>)0x0046EDB0)(ref this, i_iItemNum);

    /// <summary>Scrolls the list box so that the specified item becomes visible by adjusting its scroll position.
    /// <code>Offset: 0x0046EF20
    /// void __thiscall UIElement_ListBox::ScrollToShow(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    /// <param name="i_pcItem">The UIElement to bring into view; if the element is present in the list, the control scrolls to display it.</param>
    public void ScrollToShow(ACBindings.Internal.UIElement* i_pcItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, void>)0x0046EF20)(ref this, i_pcItem);

    /// <summary>Sets the list box's current selection to the item at the specified zero‑based index. If the index is outside the bounds of the item array, clears the selection.
    /// <code>Offset: 0x0046EF60
    /// void __thiscall UIElement_ListBox::SetSelectedIndex(UIElement_ListBox*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="selectedIndex">Zero‑based position of the desired item in the list.</param>
    /// <param name="bBroadcast">True to notify listeners that the selection has changed; false suppresses broadcasting.</param>
    public void SetSelectedIndex(uint selectedIndex, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, byte, void>)0x0046EF60)(ref this, selectedIndex, bBroadcast);

    /// <summary>Inserts a UIElement into the list before a specified reference element.
    /// <code>Offset: 0x0046EFC0
    /// bool __thiscall UIElement_ListBox::InsertItem(UIElement_ListBox*,UIElement*,UIElement*)</code>
    /// </summary>
    /// <param name="insertThis">The element to be inserted.</param>
    /// <param name="here">Reference element indicating the position before which the new element should appear; must not be null.</param>
    /// <returns>True if the insertion succeeds; otherwise false.</returns>
    public byte InsertItem(ACBindings.Internal.UIElement* insertThis, ACBindings.Internal.UIElement* here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte>)0x0046EFC0)(ref this, insertThis, here);

    /// <summary>Moves the current selection in the list by a specified offset, wrapping around if necessary, updates the selected item, and scrolls it into view.
    /// <code>Offset: 0x0046F010
    /// bool __thiscall UIElement_ListBox::StartActive(UIElement_ListBox*,const int*)</code>
    /// </summary>
    /// <param name="nDelta">Relative index change applied to the currently selected item; negative values move upward, positive downward.</param>
    /// <returns>True after updating the selection state.</returns>
    public byte StartActive(int* nDelta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int*, byte>)0x0046F010)(ref this, nDelta);

    /// <summary>Selects the list item with the specified element ID, updating the current selection and scrolling to make it visible. If no matching item is found, clears the selection.
    /// <code>Offset: 0x0046F0A0
    /// void __thiscall UIElement_ListBox::SetSelectedItemByID(UIElement_ListBox*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the UI element to select.</param>
    /// <param name="bBroadcast">If true, notifies listeners about the selection change; otherwise suppresses notifications.</param>
    public void SetSelectedItemByID(uint itemID, byte bBroadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, byte, void>)0x0046F0A0)(ref this, itemID, bBroadcast);

    /// <summary>Adds a UIElement to the list box, handling focus loss and marking the region dirty when the item is newly inserted.
    /// <code>Offset: 0x0046F130
    /// bool __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    /// <param name="item">The UIElement to add; if null the operation fails.</param>
    /// <returns>True when the supplied item is non‑null; otherwise false.</returns>
    public byte AddItem(ACBindings.Internal.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, byte>)0x0046F130)(ref this, item);

    /// <summary>Adds a new child element to the ListBox by its identifier, optionally inserting it before a specified existing item.
    /// <code>Offset: 0x0046F180
    /// UIElement* __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,int,unsigned int,UIElement*)</code>
    /// </summary>
    /// <param name="a2">The element ID used to create the child element via UIElementManager.</param>
    /// <param name="a3">Flags or properties applied when creating the child element.</param>
    /// <param name="here">If non‑null, the new element is inserted before this existing item; otherwise it is appended to the list.</param>
    /// <returns>Pointer to the created UIElement on success; null if creation fails or insertion into the ListBox cannot be performed.</returns>
    public ACBindings.Internal.UIElement* AddItem(int a2, uint a3, ACBindings.Internal.UIElement* here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, int, uint, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F180)(ref this, a2, a3, here);

    /// <summary>Starts the list box in an active state, initializing the starting delta based on internal flags and column count.
    /// <code>Offset: 0x0046F1E0
    /// bool __thiscall UIElement_ListBox::StartUpActive(UIElement_ListBox*)</code>
    /// </summary>
    /// <returns>True if activation succeeds; otherwise false.</returns>
    public byte StartUpActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F1E0)(ref this);

    /// <summary>Begins the active state for a list box, determining how many columns it uses before delegating to StartActive.
    /// <code>Offset: 0x0046F220
    /// bool __thiscall UIElement_ListBox::StartDownActive(UIElement_ListBox*)</code>
    /// </summary>
    /// <returns>True if the list box entered its active state successfully; otherwise false.</returns>
    public byte StartDownActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F220)(ref this);

    /// <summary>Starts the list box’s active selection from the left side, selecting items based on the current orientation flag.
    /// <code>Offset: 0x0046F250
    /// bool __thiscall UIElement_ListBox::StartLeftActive(UIElement_ListBox*)</code>
    /// </summary>
    /// <returns>True if the activation sequence was successfully initiated; otherwise false.</returns>
    public byte StartLeftActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F250)(ref this);

    /// <summary>Initiates an active state on the list box by determining its row count and delegating to <c>StartActive</c>.
    /// <code>Offset: 0x0046F290
    /// bool __thiscall UIElement_ListBox::StartRightActive(UIElement_ListBox*)</code>
    /// </summary>
    /// <returns>True if the operation succeeds, otherwise false.</returns>
    public byte StartRightActive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, byte>)0x0046F290)(ref this);

    /// <summary>Adds an element from the list box's template collection identified by <paramref name="i_item"/>, inserting it before <paramref name="i_pInsertBefore"/> if supplied.
    /// <code>Offset: 0x0046F2C0
    /// UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateListByID(UIElement_ListBox*,unsigned int,UIElement*)</code>
    /// </summary>
    /// <param name="i_item">The identifier of the template item to add.</param>
    /// <param name="i_pInsertBefore">The UIElement before which the new item should be inserted; pass null to append at the end.</param>
    /// <returns>Pointer to the newly created UIElement, or null if no matching template was found.</returns>
    public ACBindings.Internal.UIElement* AddItemFromTemplateListByID(uint i_item, ACBindings.Internal.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F2C0)(ref this, i_item, i_pInsertBefore);

    /// <summary>Adds a UIElement to the ListBox based on information supplied by a BaseProperty entry, inserting it before an optional element if provided.
    /// <code>Offset: 0x0046F530
    /// UIElement* __thiscall UIElement_ListBox::AddItem(UIElement_ListBox*,const BaseProperty*,UIElement*)</code>
    /// </summary>
    /// <param name="propEntryStruct">The property data that describes the item to be added.</param>
    /// <param name="i_pInsertBefore">An optional UIElement; if non‑null, the new item is inserted immediately before this element, otherwise it is appended at the end of the list.</param>
    /// <returns>A pointer to the newly created UIElement, or nullptr if the addition fails.</returns>
    public ACBindings.Internal.UIElement* AddItem(ACBindings.Internal.BaseProperty* propEntryStruct, ACBindings.Internal.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.BaseProperty*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F530)(ref this, propEntryStruct, i_pInsertBefore);

    /// <summary>Adds an item from the list box's template collection at the specified index, optionally inserting it before a given element.
    /// <code>Offset: 0x0046F670
    /// UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateList(UIElement_ListBox*,unsigned int,UIElement*)</code>
    /// </summary>
    /// <param name="i_itemIndex">Index of the template to add to the list box.</param>
    /// <param name="i_pInsertBefore">Element before which the new item should be inserted; if null, the item is appended to the end.</param>
    /// <returns>Pointer to the newly created UIElement, or nullptr if the item could not be added.</returns>
    public ACBindings.Internal.UIElement* AddItemFromTemplateList(uint i_itemIndex, ACBindings.Internal.UIElement* i_pInsertBefore) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*>)0x0046F670)(ref this, i_itemIndex, i_pInsertBefore);

    /// <summary>Adds an item from a template list into the ListBox at the specified position.
    /// <code>Offset: 0x0046F770
    /// UIElement* __thiscall UIElement_ListBox::AddItemFromTemplateList(UIElement_ListBox*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_itemIndex">Index of the template to be added.</param>
    /// <param name="here">Desired insertion index; if greater than or equal to the current number of items, the new element is appended.</param>
    /// <returns>Pointer to the newly inserted UIElement, or null if the item could not be created.</returns>
    public ACBindings.Internal.UIElement* AddItemFromTemplateList(uint i_itemIndex, int here) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, uint, int, ACBindings.Internal.UIElement*>)0x0046F770)(ref this, i_itemIndex, here);

    /// <summary>Returns the zero‑based position of a specified item in the listbox; returns –1 when the item is absent.
    /// <code>Offset: 0x00480780
    /// int __thiscall UIElement_ListBox::WhatNum(UIElement_ListBox*,UIElement*)</code>
    /// </summary>
    /// <param name="item">The UIElement instance to locate within the listbox.</param>
    /// <returns>The index of the element, or –1 if it cannot be found.</returns>
    public int WhatNum(ACBindings.Internal.UIElement* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, ACBindings.Internal.UIElement*, int>)0x00480780)(ref this, item);

    /// <summary>Scrolls the listbox to display its first item if any items are present.
    /// <code>Offset: 0x0048B400
    /// void __thiscall UIElement_ListBox::ScrollToHome(UIElement_ListBox*)</code>
    /// </summary>
    public void ScrollToHome() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ListBox, void>)0x0048B400)(ref this);
}

