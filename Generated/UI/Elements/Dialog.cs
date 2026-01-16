namespace ACBindings.Internal;


/// <summary>Represents a UI dialog, encapsulating context information, property collection, timing data, and references to pending display elements.</summary>
public unsafe struct Dialog : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field

    // Child Types
    public unsafe struct Dialog_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Dialog*, uint, void> SetContext; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Dialog*, ACBindings.Internal.PropertyCollection*, void> SetData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Dialog*, void> CancelDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Dialog*, void> UpdatePopupSizeAndPosition; // function pointer

        // Methods
    }

    // Members
    public uint m_nContext;
    public ACBindings.Internal.PropertyCollection m_cData;
    public double m_tNow;
    public double m_tExpiration;
    public ACBindings.Internal.UIElement* m_pcPendingDisplay;
    public ACBindings.Internal.UIElement_Text* m_pcPendingDisplayText;

    // Generated Constructor
    public Dialog(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Sets the current context identifier for the dialog.
    /// <code>Offset: 0x00475020
    /// void __thiscall Dialog::SetContext(Dialog*,unsigned int)</code>
    /// </summary>
    /// <param name="i_nContext">The new context value to assign to the dialog.</param>
    public void SetContext(uint i_nContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, uint, void>)0x00475020)(ref this, i_nContext);

    /// <summary>Initializes a Dialog instance with the supplied layout and element description, preparing its internal UI state and timing fields.
    /// <code>Offset: 0x00476BF0
    /// void __thiscall Dialog::Dialog(Dialog*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor that defines dialog dimensions and element mapping.</param>
    /// <param name="full_desc">Element description detailing visual properties and child elements for the dialog.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00476BF0)(ref this, layout, full_desc);

    /// <summary>Destroys a Dialog instance, freeing its property collection and cleaning up embedded UI components.
    /// <code>Offset: 0x00476C60
    /// void __thiscall Dialog::~Dialog(Dialog*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, void>)0x00476C60)(ref this);

    /// <summary>Processes messages directed at the dialog, performing cleanup when message ID 36 arrives for this dialog before delegating to the base UIElement handler.
    /// <code>Offset: 0x00476C80
    /// UIElementMessageListenResult __thiscall Dialog::ListenToElementMessage(Dialog*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>The result of handling the message as determined by the base UIElement implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00476C80)(ref this, i_rMsg);

    /// <summary>Caches UI elements for a pending dialog if they are not yet cached, then triggers an input action on the display element to update its state according to the current number of pending items.
    /// <code>Offset: 0x00476CF0
    /// void __thiscall Dialog::UpdatePendingDialogDisplay(Dialog*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iNumPending">The count of pending dialog items affecting the input action performed.</param>
    public void UpdatePendingDialogDisplay(uint i_iNumPending) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, uint, void>)0x00476CF0)(ref this, i_iNumPending);

    /// <summary>Adjusts popup dimensions and position based on embedded text content, resizing the background region to fit and centering it within the dialog.
    /// <code>Offset: 0x00476D70
    /// void __thiscall Dialog::UpdatePopupSizeAndPosition(Dialog*)</code>
    /// </summary>
    /// <param name="this">The dialog whose popup is being updated.</param>
    public void UpdatePopupSizeAndPosition() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, void>)0x00476D70)(ref this);

    /// <summary>Updates the dialog’s displayed text element to reflect current data, inserting the remaining time until expiration into the string content.
    /// <code>Offset: 0x00476E10
    /// void __thiscall Dialog::UpdateDialogText(Dialog*)</code>
    /// </summary>
    public void UpdateDialogText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, void>)0x00476E10)(ref this);

    /// <summary>Handles global messages sent to a dialog, updating its state when message ID 3 is received and the timer has advanced beyond the current time, potentially refreshing text or causing loss of focus on expiration.
    /// <code>Offset: 0x00476F50
    /// void __thiscall Dialog::ListenToGlobalMessage(Dialog*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_eMessageID">Identifier for the global message being processed; only message ID 3 triggers dialog‑specific actions.</param>
    public void ListenToGlobalMessage(uint i_eMessageID, int i_nData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, uint, int, void>)0x00476F50)(ref this, i_eMessageID, i_nData);

    /// <summary>Updates the dialog's internal data from a given PropertyCollection, applying specific properties such as visibility and expiration time, then refreshes its display.
    /// <code>Offset: 0x00476FA0
    /// void __thiscall Dialog::SetData(Dialog*,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="this">The Dialog instance to update.</param>
    /// <param name="i_cData">Source collection containing property values to copy into the dialog.</param>
    public void SetData(ACBindings.Internal.PropertyCollection* i_cData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Dialog, ACBindings.Internal.PropertyCollection*, void>)0x00476FA0)(ref this, i_cData);
}

