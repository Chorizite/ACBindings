namespace ACBindings.Internal;


/// <summary>
/// Represents a scrollable UI element that manages scrolling behavior, animation, and widget interaction.
/// Handles increment/decrement buttons, drag operations, and communicates with attached widgets to adjust view positions.
/// </summary>
public unsafe struct UIElement_Scrollbar : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Button BaseClass_UIElement_Button; // ACBindings.Internal.UIElement_Button

    // Child Types
    public unsafe struct UIElement_Scrollbar_vtbl
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
    // UIElement_Scrollbar::UIScrollBar_Flag
    public enum UIScrollBar_Flag : uint
    {
        UISB_NONE = 0x0,
        UISB_HORIZONTAL = 0x1,
        UISB_PROPORTIONAL = 0x2,
        UISB_DISABLED = 0x4,
        UISB_HIDE_DISABLED = 0x8,
        UISB_SMOOTH_MOVEMENT = 0x10,
        UISB_DISALLOW_UPDATING = 0x20,
        UISB_MOVE_TO_TOUCHED = 0x40,
        UISB_BUTTONS_INTERACT = 0x80,
        UISB_HAS_STOP_LOCATIONS = 0x100,
        UISB_MOUSE_PRESSED = 0x8000,
        UISB_OVER_WIDGET = 0x10000,
        UISB_OVER_BAR_LEFT = 0x20000,
        UISB_OVER_BAR_RIGHT = 0x40000,
        UISB_OVER_BAR_TOP = 0x80000,
        UISB_OVER_BAR_BOTTOM = 0x100000,
        UISB_RCV_MOUSEMOVE = 0x200000,
        UISB_ANIMATING = 0x400000,
        UISB_NEED_TO_KIDNAP_BUTTONS = 0x800000,
        UISB_GHOST_WHEN_DISABLED = 0x1000000,
        UISB_FORCEDWORD = 0xFFFFFFFF
    }

    // Members
    public ACBindings.Internal.UIElement* m_pWidget;
    public double m_tAnimStartTime;
    public double m_tAnimEndTime;
    public float m_fAnimStartPos;
    public float m_fAnimEndPos;
    public int m_nMouseWidgetXOffset;
    public int m_nMouseWidgetYOffset;
    public double m_nNextPageTime;
    public ACBindings.Internal.tagPOINT m_ptDragStart;
    public float m_fResetPosition;
    public byte m_bWidgetDragActive;
    public ACBindings.Internal.tagRECT m_rectScrollingArea;
    public uint m_eIncrementButtonID;
    public uint m_eDecrementButtonID;
    public uint m_bitField;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Attempts to cast the scrollbar object to a requested UI element type based on its identifier; for specific identifiers it returns the underlying UIElement base or the scrollbar instance itself, otherwise nullptr.
    /// <code>Offset: 0x00470440
    /// UIElement* __thiscall UIElement_Scrollbar::DynamicCast(UIElement_Scrollbar*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The identifier of the desired UI element type for casting.</param>
    /// <returns>A pointer to the requested UIElement if the conversion is valid; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, ACBindings.Internal.UIElement*>)0x00470440)(ref this, i_eType);

    /// <summary>Creates a scrollbar UI element from the provided layout and element descriptions.
    /// <code>Offset: 0x00470470
    /// UIElement* __cdecl UIElement_Scrollbar::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The layout descriptor containing display dimensions and other global settings.</param>
    /// <param name="full_desc">The element description detailing properties of this specific scrollbar.</param>
    /// <returns>A pointer to the newly created UIElement, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00470470)(layout, full_desc);

    /// <summary>Registers input mappings for the scrollbar, delegating to its text base and invoking a specific input registration routine.
    /// <code>Offset: 0x004704A0
    /// bool __thiscall UIElement_Scrollbar::RegisterInputMaps(UIElement_Scrollbar*,int)</code>
    /// </summary>
    /// <param name="i_nPriority">Determines the priority order of the registered input maps.</param>
    /// <returns>True if at least one mapping was successfully registered; otherwise false.</returns>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, byte>)0x004704A0)(ref this, i_nPriority);

    /// <summary>Detaches input maps associated with this scrollbar from the global input system, ensuring that related UI components no longer receive input events.
    /// <code>Offset: 0x004704E0
    /// bool __thiscall UIElement_Scrollbar::UnregisterInputMaps(UIElement_Scrollbar*)</code>
    /// </summary>
    /// <returns>True if either the underlying text element or the central input manager reported successful unregistration; otherwise false.</returns>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte>)0x004704E0)(ref this);

    /// <summary>Configures the supplied UI element as the default hot‑click target for this scrollbar. Enables hot clicking and sets default timing attributes when they are not already defined.
    /// <code>Offset: 0x00470510
    /// void __thiscall UIElement_Scrollbar::SetupDefaultHotClick(UIElement_Scrollbar*,UIElement*)</code>
    /// </summary>
    /// <param name="pElement">The UI element to configure for hot‑click behavior.</param>
    public void SetupDefaultHotClick(ACBindings.Internal.UIElement* pElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElement*, void>)0x00470510)(ref this, pElement);

    /// <summary>Converts a scroll position into an integer stop index using the scrollbar’s configured stop count and mode.
    /// <code>Offset: 0x00470580
    /// int __thiscall UIElement_Scrollbar::PositionToStop(UIElement_Scrollbar*,float)</code>
    /// </summary>
    /// <param name="i_fNewPosition">The current scroll position as a float value.</param>
    /// <returns>The index of the nearest stop, or –1 if no stops are defined for the scrollbar.</returns>
    public int PositionToStop(float i_fNewPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float, int>)0x00470580)(ref this, i_fNewPosition);

    /// <summary>Prepares a UIElementMessageInfo structure for a scrollbar event by updating its element ID and widget pointer based on the scrollbar’s internal state.
    /// <code>Offset: 0x00470620
    /// tagPOINT __thiscall UIElement_Scrollbar::GetScrollbarPositionFromMessage(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The scrollbar instance.</param>
    /// <param name="i_rMsg">Message information to populate with the scrollbar’s element ID and widget pointer.</param>
    /// <returns>The point whose x component is the original message pointer value, used as an identifier for the event source.</returns>
    public ACBindings.Internal.tagPOINT GetScrollbarPositionFromMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.tagPOINT>)0x00470620)(ref this, i_rMsg);

    /// <summary>Calculates the effective size of a scrollbar's active region by considering its scrolling area and any attached widget.
    /// <code>Offset: 0x00470660
    /// tagPOINT __thiscall UIElement_Scrollbar::ComputeActiveSize(UIElement_Scrollbar*)</code>
    /// </summary>
    /// <returns>A tagPOINT where .x contains the computed horizontal dimension and .y contains the vertical dimension of that active region.</returns>
    public ACBindings.Internal.tagPOINT ComputeActiveSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT>)0x00470660)(ref this);

    /// <summary>Sets or clears selected bits in the scrollbar's internal bit field according to a flag.
    /// <code>Offset: 0x004706F0
    /// void __thiscall UIElement_Scrollbar::SetBitMask(UIElement_Scrollbar*,const bool,const unsigned int)</code>
    /// </summary>
    /// <param name="i_bVal">True to set the specified bits, false to clear them.</param>
    /// <param name="i_nMask">Bitmask indicating which bits should be modified.</param>
    public void SetBitMask(byte i_bVal, uint i_nMask) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, uint, void>)0x004706F0)(ref this, i_bVal, i_nMask);

    /// <summary>Configures the scrollbar's orientation based on the supplied flag, enabling horizontal scrolling when true and reverting to vertical when false.
    /// <code>Offset: 0x00470730
    /// void __thiscall UIElement_Scrollbar::SetHorizontal(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">True to set the scrollbar as horizontal; false to set it as vertical.</param>
    public void SetHorizontal(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470730)(ref this, b);

    /// <summary>Enables or disables proportional scrolling on the scrollbar.
    /// <code>Offset: 0x00470760
    /// void __thiscall UIElement_Scrollbar::SetProportional(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">True to activate proportional mode; false to deactivate.</param>
    public void SetProportional(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470760)(ref this, b);

    /// <summary>Enables or disables the scrollbar by updating its internal disabled flag.
    /// <code>Offset: 0x00470790
    /// void __thiscall UIElement_Scrollbar::SetDisabled(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">When true, the scrollbar is set to disabled; when false, it is enabled.</param>
    public void SetDisabled(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470790)(ref this, b);

    /// <summary>Configures visibility of the disabled state for the scrollbar.
    /// <code>Offset: 0x004707C0
    /// void __thiscall UIElement_Scrollbar::SetHideDisabled(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">Set to true to hide the disabled appearance; set to false to display it normally.</param>
    public void SetHideDisabled(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x004707C0)(ref this, b);

    /// <summary>Enables or disables smooth movement for the scrollbar by updating an internal flag.
    /// <code>Offset: 0x004707F0
    /// void __thiscall UIElement_Scrollbar::SetSmoothMovement(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">True to enable smooth movement; false to disable.</param>
    public void SetSmoothMovement(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x004707F0)(ref this, b);

    /// <summary>Enables or disables the scrollbar’s automatic updating by setting the corresponding bit in its internal state field.
    /// <code>Offset: 0x00470820
    /// void __thiscall UIElement_Scrollbar::SetDisallowUpdating(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">When true, disallow updates; when false, allow updates.</param>
    public void SetDisallowUpdating(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470820)(ref this, b);

    /// <summary>Enables or disables automatic scrolling when the scrollbar is touched.
    /// <code>Offset: 0x00470850
    /// void __thiscall UIElement_Scrollbar::SetMoveToTouched(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">True to enable move‑to‑touched behavior; false to disable it.</param>
    public void SetMoveToTouched(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470850)(ref this, b);

    /// <summary>Configures the scrollbar to include stop locations when scrolling.
    /// <code>Offset: 0x00470880
    /// void __thiscall UIElement_Scrollbar::SetHasStopLocations(UIElement_Scrollbar*,const bool)</code>
    /// </summary>
    /// <param name="b">True to enable stop locations; false to disable them.</param>
    public void SetHasStopLocations(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, void>)0x00470880)(ref this, b);

    /// <summary>Retrieves the secondary coordinate (x or y) of a point based on the scrollbar’s orientation.
    /// <code>Offset: 0x004708B0
    /// int __thiscall UIElement_Scrollbar::GetSecondaryCoordinate(UIElement_Scrollbar*,const tagPOINT*)</code>
    /// </summary>
    /// <param name="i_pt">The point whose coordinate is to be returned.</param>
    /// <returns>An integer representing either the x‑coordinate if the scrollbar is horizontal, or the y‑coordinate if it is vertical.</returns>
    public int GetSecondaryCoordinate(ACBindings.Internal.tagPOINT* i_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT*, int>)0x004708B0)(ref this, i_pt);

    /// <summary>Initializes the scrollbar element by invoking its base class initialization, checks a designated boolean attribute, and if that attribute indicates default behavior, configures the scrollbar’s hot‑click handling accordingly.
    /// <code>Offset: 0x004708E0
    /// void __thiscall UIElement_Scrollbar::Initialize(UIElement_Scrollbar*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x004708E0)(ref this);

    /// <summary>Starts a scrollbar animation using attribute values, initializing start and end positions along with timing information. If the scrollbar was not previously animating, it registers for global messages to receive updates.
    /// <code>Offset: 0x00470910
    /// void __thiscall UIElement_Scrollbar::StartAnimation(UIElement_Scrollbar*)</code>
    /// </summary>
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00470910)(ref this);

    /// <summary>Retrieves the increment or decrement button associated with the scrollbar, verifying that it is a child of this scrollbar.
    /// <code>Offset: 0x004709E0
    /// UIElement_Button* __thiscall UIElement_Scrollbar::GetButtonPointer_(UIElement_Scrollbar*,bool)</code>
    /// </summary>
    /// <param name="i_bIncrement">If true selects the increment button; otherwise selects the decrement button.</param>
    /// <returns>A pointer to the matching UIElement_Button if found and validated, or null if no such button exists or validation fails.</returns>
    public ACBindings.Internal.UIElement_Button* GetButtonPointer_(byte i_bIncrement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, ACBindings.Internal.UIElement_Button*>)0x004709E0)(ref this, i_bIncrement);

    /// <summary>Updates the scrollbar’s increment or decrement button ID, associates the corresponding UI element as a hot‑click target when it exists, and otherwise registers the scrollbar for activation messages.
    /// <code>Offset: 0x00470A40
    /// void __thiscall UIElement_Scrollbar::UpdateButtonID_(UIElement_Scrollbar*,bool,unsigned int)</code>
    /// </summary>
    /// <param name="i_bIncrement">True to update the increment button ID; false updates the decrement button ID.</param>
    /// <param name="i_eNewID">The new identifier of the button to assign to the scrollbar.</param>
    public void UpdateButtonID_(byte i_bIncrement, uint i_eNewID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, byte, uint, void>)0x00470A40)(ref this, i_bIncrement, i_eNewID);

    /// <summary>Handles a click on the scrollbar’s track area outside the thumb by determining whether the click is before or after the widget start coordinate and broadcasting a page‑up or page‑down message to the linked widget.
    /// <code>Offset: 0x00470A90
    /// void __thiscall UIElement_Scrollbar::HandlePageClick(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message containing the element coordinates of the click event.</param>
    public void HandlePageClick(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, void>)0x00470A90)(ref this, i_rMsg);

    /// <summary>Converts a stop index into a normalized scroll position for the scrollbar.
    /// <code>Offset: 0x00470B40
    /// float __thiscall UIElement_Scrollbar::StopToPosition(UIElement_Scrollbar*,int)</code>
    /// </summary>
    /// <param name="i_nNewStop">The zero‑based index of the desired stop.</param>
    /// <returns>A float between 0 and 1 representing the scroll position; returns -1.0 if the scrollbar has no defined number of stops.</returns>
    public float StopToPosition(int i_nNewStop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, float>)0x00470B40)(ref this, i_nNewStop);

    /// <summary>Sets the scrollbar’s target position based on a specified stop index and updates associated attributes and events.
    /// <code>Offset: 0x00470BF0
    /// void __thiscall UIElement_Scrollbar::SetScrollbarStop(UIElement_Scrollbar*,int,bool)</code>
    /// </summary>
    /// <param name="i_nNewStop">The new stop index to move the scrollbar to.</param>
    /// <param name="i_bAllowSmoothMovement">If true, allows smooth movement during transition (currently not used).</param>
    public void SetScrollbarStop(int i_nNewStop, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, byte, void>)0x00470BF0)(ref this, i_nNewStop, i_bAllowSmoothMovement);

    /// <summary>Translates a point within the scrollbar's coordinate space into a normalized position along its active scrolling range.
    /// <code>Offset: 0x00470C50
    /// float __thiscall UIElement_Scrollbar::PointToPosition(UIElement_Scrollbar*,const tagPOINT*)</code>
    /// </summary>
    /// <param name="i_ptElement">The point to convert, expressed in element coordinates.</param>
    /// <returns>A value between 0 and 1 representing the relative location of the point on the scrollbar; returns 0 if the point is outside the valid area or no widget is attached.</returns>
    public float PointToPosition(ACBindings.Internal.tagPOINT* i_ptElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT*, float>)0x00470C50)(ref this, i_ptElement);

    /// <summary>Converts a scrollbar position into the corresponding X or Y coordinate for its attached widget, taking scrolling area bounds and optional centering into account.
    /// <code>Offset: 0x00470D60
    /// tagPOINT __thiscall UIElement_Scrollbar::PositionToWidgetX0Y0(UIElement_Scrollbar*,float)</code>
    /// </summary>
    /// <param name="i_fPosition">Normalized scroll position along the active axis (0.0 to 1.0).</param>
    /// <returns>A tagPOINT whose x or y component represents the widget’s offset; the unused component is zero.</returns>
    public ACBindings.Internal.tagPOINT PositionToWidgetX0Y0(float i_fPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float, ACBindings.Internal.tagPOINT>)0x00470D60)(ref this, i_fPosition);

    /// <summary>Recalculates the scrollbar's scrolling area rectangle based on its base region and any increment or decrement buttons, then informs those button regions of their new positions.
    /// <code>Offset: 0x00470E60
    /// void __thiscall UIElement_Scrollbar::UpdateScrollingArea(UIElement_Scrollbar*)</code>
    /// </summary>
    public void UpdateScrollingArea() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00470E60)(ref this);

    /// <summary>Clamps the scrollbar position between 0 and 1, snapping it to the nearest stop if the stop‑mode flag is set.
    /// <code>Offset: 0x00470F20
    /// void __thiscall UIElement_Scrollbar::ValidatePosition(UIElement_Scrollbar*,float*)</code>
    /// </summary>
    /// <param name="io_fPosition">Reference to the current position; modified in place to satisfy bounds and stop constraints.</param>
    public void ValidatePosition(float* io_fPosition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float*, void>)0x00470F20)(ref this, io_fPosition);

    /// <summary>Destroys a UIElement_Scrollbar, resetting button identifiers and registering the element for global hot‑click handling if required. Cleans up base class resources before completing destruction.
    /// <code>Offset: 0x00470F80
    /// void __thiscall UIElement_Scrollbar::~UIElement_Scrollbar(UIElement_Scrollbar*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00470F80)(ref this);

    /// <summary>Populates the supplied AvailablePropertySet with all properties applicable to this scrollbar element, including those inherited from its button base class and the scrollbar‑specific property group.
    /// <code>Offset: 0x00471010
    /// bool __thiscall UIElement_Scrollbar::InqAvailableProperties(UIElement_Scrollbar*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The property set that will receive the available properties.</param>
    /// <returns>True if any properties were successfully added; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.AvailablePropertySet*, byte>)0x00471010)(ref this, set);

    /// <summary>Performs a frame‑time update for a scrollbar, handling button activation, hot‑click focus changes, scrolling area recalculation, and animating the widget position until completion.
    /// <code>Offset: 0x00471060
    /// void __thiscall UIElement_Scrollbar::Global_Loop(UIElement_Scrollbar*)</code>
    /// </summary>
    /// <param name="this">Pointer to the scrollbar instance being updated.</param>
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00471060)(ref this);

    /// <summary>Listens for global events and forwards them to the underlying button component, invoking scrollbar loop logic when message ID 3 is received.
    /// <code>Offset: 0x004711C0
    /// void __thiscall UIElement_Scrollbar::ListenToGlobalMessage(UIElement_Scrollbar*,unsigned int,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the scrollbar instance receiving the event.</param>
    /// <param name="messageID">Identifier of the global message to handle.</param>
    /// <param name="data_int">Additional integer data associated with the message.</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, int, void>)0x004711C0)(ref this, messageID, data_int);

    /// <summary>Moves the scrollbar by a specified number of steps. If an internal integer attribute (ID 0x87) exists on the element, updates the scroll position directly; otherwise broadcasts a message indicating the movement direction and magnitude.
    /// <code>Offset: 0x004711F0
    /// void __thiscall UIElement_Scrollbar::HandleMoveSteps(UIElement_Scrollbar*,const unsigned int,const int)</code>
    /// </summary>
    /// <param name="attributeID">Ignored; the method uses a fixed internal attribute ID instead.</param>
    /// <param name="nSteps">Number of steps to move; positive values advance forward, negative values reverse.</param>
    public void HandleMoveSteps(uint attributeID, int nSteps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, int, void>)0x004711F0)(ref this, attributeID, nSteps);

    /// <summary>Responds to a scrollbar button click by moving the view one step in the appropriate direction.
    /// <code>Offset: 0x00471250
    /// void __thiscall UIElement_Scrollbar::HandleButtonClick(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information identifying which increment or decrement button was activated.</param>
    public void HandleButtonClick(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, void>)0x00471250)(ref this, i_rMsg);

    /// <summary>Sets the scrollbar’s position within the valid range, clamping values outside [0, 1] to the nearest bound. If a corresponding stop exists, moves the widget to that stop optionally using smooth animation; otherwise updates the internal attribute and broadcasts a change message.
    /// <code>Offset: 0x00471280
    /// void __thiscall UIElement_Scrollbar::SetScrollbarPosition(UIElement_Scrollbar*,float,bool)</code>
    /// </summary>
    /// <param name="i_fNewPosition">Desired scroll position as a normalized value between 0 and 1.</param>
    /// <param name="i_bAllowSmoothMovement">True to animate movement toward the nearest stop, false for an instant jump.</param>
    public void SetScrollbarPosition(float i_fNewPosition, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, float, byte, void>)0x00471280)(ref this, i_fNewPosition, i_bAllowSmoothMovement);

    /// <summary>Scrolls the scrollbar so that its thumb aligns with a point supplied in i_rMsg. The point is converted from widget coordinates into scrollbar space and the position is set, optionally animating smoothly.
    /// <code>Offset: 0x00471310
    /// void __thiscall UIElement_Scrollbar::ScrollToPoint(UIElement_Scrollbar*,const UIElementMessageInfo*,bool)</code>
    /// </summary>
    /// <param name="i_rMsg">Message containing the target point and element context used to calculate the new scroll position.</param>
    /// <param name="i_bAllowSmoothMovement">When true, the scrollbar moves smoothly; otherwise it jumps directly to the new position.</param>
    public void ScrollToPoint(ACBindings.Internal.UIElementMessageInfo* i_rMsg, byte i_bAllowSmoothMovement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, byte, void>)0x00471310)(ref this, i_rMsg, i_bAllowSmoothMovement);

    /// <summary>Begins a widget‑drag operation for the scrollbar. Records the initial cursor position relative to the element, resolves absolute coordinates when the dragged element forwards its action to this scrollbar, fetches the reset scroll offset attribute, and marks the drag as active.
    /// <code>Offset: 0x00471370
    /// void __thiscall UIElement_Scrollbar::StartWidgetDrag(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message containing the source UIElement, action information, and cursor location for initiating the drag.</param>
    public void StartWidgetDrag(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, void>)0x00471370)(ref this, i_rMsg);

    /// <summary>Adjusts the scrollbar's position relative to its reset point, optionally applying animation when a non‑null POINT pointer is supplied.
    /// <code>Offset: 0x004713E0
    /// void __thiscall UIElement_Scrollbar::ScrollNPixelsFromReset(UIElement_Scrollbar*,const tagPOINT*,bool)</code>
    /// </summary>
    /// <param name="i_ptDelta">Pointer used as an indicator; if not null, the new position will be animated.</param>
    /// <param name="i_bAllowSmoothScrolling">Unused flag reserved for future smooth‑scrolling support.</param>
    public void ScrollNPixelsFromReset(ACBindings.Internal.tagPOINT* i_ptDelta, byte i_bAllowSmoothScrolling) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.tagPOINT*, byte, void>)0x004713E0)(ref this, i_ptDelta, i_bAllowSmoothScrolling);

    /// <summary>Recalculates the layout of a scrollbar element, initializing its child widget if necessary and positioning the scroll handle, increment/decrement buttons, and draggable area according to defined attributes such as size, position, and visibility flags.
    /// <code>Offset: 0x00471490
    /// void __thiscall UIElement_Scrollbar::UpdateLayout(UIElement_Scrollbar*)</code>
    /// </summary>
    public void UpdateLayout() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, void>)0x00471490)(ref this);

    /// <summary>Resizes the scrollbar to the specified width and height, updating all child elements.
    /// <code>Offset: 0x004717F0
    /// void __thiscall UIElement_Scrollbar::ResizeTo(UIElement_Scrollbar*,const int,const int)</code>
    /// </summary>
    /// <param name="width">The desired width in pixels.</param>
    /// <param name="height">The desired height in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, int, int, void>)0x004717F0)(ref this, width, height);

    /// <summary>Handles mouse‑wheel input on a scrollbar by either moving the widget directly or broadcasting a scroll message, depending on its configuration flags.
    /// <code>Offset: 0x00471810
    /// void __thiscall UIElement_Scrollbar::HandleMouseWheel(UIElement_Scrollbar*,unsigned int)</code>
    /// </summary>
    /// <param name="buttonID">Identifier of the wheel button (typically 5 for upward scrolling and 4 for downward scrolling).</param>
    public void HandleMouseWheel(uint buttonID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint, void>)0x00471810)(ref this, buttonID);

    /// <summary>Updates the scrollbar’s configuration based on a given property, applying changes such as enabling/disabling, orientation, animation settings, or visual attributes, then recalculates layout if required.
    /// <code>Offset: 0x00471890
    /// void __thiscall UIElement_Scrollbar::OnSetAttribute(UIElement_Scrollbar*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">A pointer to the BaseProperty describing the attribute to apply to this scrollbar element.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.BaseProperty*, void>)0x00471890)(ref this, attribute);

    /// <summary>Processes messages sent to a scrollbar UI element, handling button presses, page clicks, and drag operations to adjust the scroll position. Delegates unhandled events to the base button class and returns the resulting listen result.
    /// <code>Offset: 0x00471C30
    /// UIElementMessageListenResult __thiscall UIElement_Scrollbar::ListenToElementMessage(UIElement_Scrollbar*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the scrollbar instance receiving the message.</param>
    /// <param name="i_rMsg">Message information containing event type, element IDs, parameters, and screen coordinates.</param>
    /// <returns>Result of processing the message, indicating whether it was handled or forwarded.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00471C30)(ref this, i_rMsg);

    /// <summary>Retrieves the type identifier for this scrollbar UI element.
    /// <code>Offset: 0x00527480
    /// unsigned int __thiscall UIElement_Scrollbar::GetUIElementType(ImgTex*)</code>
    /// </summary>
    /// <returns>The constant value 11 indicating a scrollbar element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Scrollbar, uint>)0x00527480)(ref this);
}

