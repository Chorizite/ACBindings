namespace ACBindings.Internal;


/// <summary>Meter UI element displays a progress or status value, optionally animating between frames or sliding a child image. It manages animation timing, current frame, direction, and supports custom child imagery for visual representation.</summary>
public unsafe struct UIElement_Meter
{
    // Base Classes
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement

    // Child Types
    public unsafe struct UIElement_Meter_vtbl
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
    public byte m_framemeter;
    public byte m_animating;
    public double m_animStartTime;
    public double m_animEndTime;
    public float m_anim_start_pos;
    public float m_anim_end_pos;
    public int m_currentFrame;
    public float m_fOldPosition;
    public ACBindings.Internal.UIElement* m_pcChildImage;
    public uint m_eDirection;

    // Generated Constructor
    public UIElement_Meter(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes a new meter UI element, setting up its base UIElement with the supplied layout and full description and resetting animation and frame state to defaults.
    /// <code>Offset: 0x0046F880
    /// void __thiscall UIElement_Meter::UIElement_Meter(UIElement_Meter*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing display dimensions and child elements for the UI element.</param>
    /// <param name="full_desc">Full element description used to configure the UI element hierarchy and properties.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046F880)(ref this, layout, full_desc);

    /// <summary>Converts a UIElement_Meter instance to its base UIElement type when the requested type identifier matches meter (type 7); otherwise returns null.
    /// <code>Offset: 0x0046F900
    /// UIElement* __thiscall UIElement_Meter::DynamicCast(UIElement_Meter*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type identifier used for the dynamic cast.</param>
    /// <returns>A pointer to the UIElement if i_eType equals 7; otherwise a null pointer.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, uint, ACBindings.Internal.UIElement*>)0x0046F900)(ref this, i_eType);

    /// <summary>Creates a new UIElement_Meter instance configured with the supplied layout and element description.
    /// <code>Offset: 0x0046F920
    /// UIElement* __cdecl UIElement_Meter::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes overall layout dimensions and elements.</param>
    /// <param name="full_desc">Specifies properties of this particular meter element.</param>
    /// <returns>A pointer to the newly constructed UIElement, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046F920)(layout, full_desc);

    /// <summary>Removes a UIRegion child from the meter element's hierarchy and clears its image reference if the removed child was used as the child image.
    /// <code>Offset: 0x0046F950
    /// void __thiscall UIElement_Meter::RemoveChild(UIElement_Meter*,UIRegion*)</code>
    /// </summary>
    /// <param name="child">The UIRegion to detach from this meter.</param>
    public void RemoveChild(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, ACBindings.Internal.UIRegion*, void>)0x0046F950)(ref this, child);

    /// <summary>Starts the meter's animation if not already running by retrieving duration and position values from its attributes, setting up start and end times, and registering a global message listener to drive the animation.
    /// <code>Offset: 0x0046F980
    /// void __thiscall UIElement_Meter::StartAnimation(UIElement_Meter*)</code>
    /// </summary>
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, void>)0x0046F980)(ref this);

    /// <summary>Adjusts the child image of a meter element according to its frame‑meter setting and animation direction, or triggers a region refresh when not animating.
    /// <code>Offset: 0x0046FA20
    /// void __thiscall UIElement_Meter::UpdateChild(UIElement_Meter*)</code>
    /// </summary>
    public void UpdateChild() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, void>)0x0046FA20)(ref this);

    /// <summary>Initializes the UIElement_Meter by setting up its base properties, determining frame meter status, acquiring a child image if necessary, and configuring action callbacks and direction flags based on attributes.
    /// <code>Offset: 0x0046FB70
    /// void __thiscall UIElement_Meter::Initialize(UIElement_Meter*)</code>
    /// </summary>
    public void Initialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, void>)0x0046FB70)(ref this);

    /// <summary>Updates the meter’s displayed value while an animation is active by interpolating between start and end positions each time a global update message is received.
    /// <code>Offset: 0x0046FC30
    /// void __thiscall UIElement_Meter::ListenToGlobalMessage(UIElement_Meter*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the global message; only message ID 3 triggers animation updates during an ongoing animation.</param>
    /// <param name="data_int">Additional integer data supplied with the message (not used in this implementation).</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, uint, int, void>)0x0046FC30)(ref this, messageID, data_int);

    /// <summary>Collects all property groups available for a meter UI element and appends them to the supplied property set.
    /// <code>Offset: 0x0046FCB0
    /// bool __thiscall UIElement_Meter::InqAvailableProperties(UIElement_Meter*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The collection into which the meter’s required properties will be added.</param>
    /// <returns>True if both the base class and meter-specific property groups were successfully queried; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046FCB0)(ref this, set);

    /// <summary>Updates the meter UI element’s displayed frame based on its current value and animation state, selecting the appropriate image resource for that frame and handling reference counts for child images.
    /// <code>Offset: 0x0046FD00
    /// void __thiscall UIElement_Meter::UpdateFrame(UIElement_Meter*)</code>
    /// </summary>
    public void UpdateFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, void>)0x0046FD00)(ref this);

    /// <summary>Draws all child UI elements of the meter, applying position offsets and optional sliding animation while clipping to a specified viewport.
    /// <code>Offset: 0x0046FF90
    /// int __thiscall UIElement_Meter::DrawChildren(UIElement*,_DWORD*,Box2D*,int,int)</code>
    /// </summary>
    /// <param name="this">The UIElement_Meter instance whose children are rendered.</param>
    /// <param name="a2">An array of two integers: index 0 supplies the horizontal offset and index 1 supplies the vertical offset applied to each child element’s drawing position.</param>
    /// <param name="a3">A Box2D defining the clipping region within which child elements may be drawn.</param>
    /// <param name="a4">Additional drawing flag or depth value forwarded to each child element.</param>
    /// <param name="a5">Supplementary drawing flag or depth value forwarded to each child element.</param>
    /// <returns>Zero on successful completion of the draw operation.</returns>
    public int DrawChildren(int* a2, ACBindings.Internal.Box2D* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, int*, ACBindings.Internal.Box2D*, int, int, int>)0x0046FF90)(ref this, a2, a3, a4, a5);

    /// <summary>Invoked when a property of a meter element changes; updates animation state and visual representation based on specific attribute IDs.
    /// <code>Offset: 0x00470230
    /// void __thiscall UIElement_Meter::OnSetAttribute(UIElement_Meter*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The property to apply, containing its ID and value.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, ACBindings.Internal.BaseProperty*, void>)0x00470230)(ref this, attribute);

    /// <summary>Resizes the meter element to the given width and height, applying base class layout changes and refreshing its visual representation based on frame or child image configuration.
    /// <code>Offset: 0x00470370
    /// void __thiscall UIElement_Meter::ResizeTo(UIElement_Meter*,const int,const int)</code>
    /// </summary>
    /// <param name="width">Desired width of the meter in pixels.</param>
    /// <param name="height">Desired height of the meter in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Meter, int, int, void>)0x00470370)(ref this, width, height);
}

