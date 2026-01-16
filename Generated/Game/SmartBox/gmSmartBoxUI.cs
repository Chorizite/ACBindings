namespace ACBindings.Internal;


/// <summary>Controls the in‑game smart box interface, handling teleportation state, portal rendering, and optional FPS display within a UI region.</summary>
public unsafe struct gmSmartBoxUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_SmartBoxWrapper BaseClass_UIElement_SmartBoxWrapper; // ACBindings.Internal.UIElement_SmartBoxWrapper

    // Child Types
    public unsafe struct gmSmartBoxUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmSmartBoxUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartBox* m_pSmartBox;
    public ACBindings.Internal.CPhysicsObj* teleportObj;
    public double gameVDist;
    public ACBindings.Internal.TeleportAnimState teleportAnimState;
    public double teleportRotationStartTime;
    public double teleportRotationDuration;
    public double teleportRotationStartAngle;
    public double teleportRotationEndAngle;
    public double teleportTransitionStartTime;
    public double teleportRotationCurAngle;
    public float teleportCurVDist;
    public ACBindings.Internal.UIElement_Text* m_pFPSDisplay;
    public ACBindings.Internal.UIElement_Viewport* m_pPortalSpace;
    public ACBindings.Internal.VividTargetIndicator m_vti;
    public uint m_eWindowID;
    public ACBindings.Internal.UIElement* m_pTopBorder;
    public ACBindings.Internal.UIElement* m_pLeftBorder;
    public ACBindings.Internal.UIElement* m_pBottomBorder;
    public ACBindings.Internal.UIElement* m_pRightBorder;
    public ACBindings.Internal.UIElement* m_pTopLeftCorner;
    public ACBindings.Internal.UIElement* m_pTopRightCorner;
    public ACBindings.Internal.UIElement* m_pBottomLeftCorner;
    public ACBindings.Internal.UIElement* m_pBottomRightCorner;

    // Generated Constructor
    public gmSmartBoxUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes a gmSmartBoxUI object with the given layout and element descriptions, setting up internal UI components and default state for teleportation and display.
    /// <code>Offset: 0x004D6D20
    /// void __thiscall gmSmartBoxUI::gmSmartBoxUI(gmSmartBoxUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing display dimensions and element references.</param>
    /// <param name="full_desc">Element description containing state, geometry, and child information for the smart box.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004D6D20)(ref this, layout, full_desc);

    /// <summary>Attempts to cast the gmSmartBoxUI instance to a requested UI element type identified by an integer identifier.
    /// <code>Offset: 0x004D6E10
    /// UIElement* __thiscall gmSmartBoxUI::DynamicCast(gmSmartBoxUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The identifier of the desired UI element type; specific values correspond to supported base classes such as UIElement.</param>
    /// <returns>If the specified type matches one of the supported identifiers, returns a pointer to that base class within the object; otherwise, returns null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint, ACBindings.Internal.UIElement*>)0x004D6E10)(ref this, i_eType);

    /// <summary>Retrieves the unique identifier for this UI element type.
    /// <code>Offset: 0x004D6E40
    /// unsigned int __thiscall gmSmartBoxUI::GetUIElementType(gmSmartBoxUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer that represents the UI element's type ID.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint>)0x004D6E40)(ref this);

    /// <summary>Updates the rendering viewport so that the game view matches the current SmartBox UI region.
    /// <code>Offset: 0x004D6F20
    /// void __thiscall gmSmartBoxUI::RecvNotice_UpdateGameView(gmSmartBoxUI*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_cxScreen">The width of the screen area for the update (unused directly in this implementation).</param>
    /// <param name="i_cyScreen">The height of the screen area for the update (unused directly in this implementation).</param>
    /// <param name="i_cxWidth">Desired view width in pixels (ignored; viewport size is taken from the UI region). </param>
    /// <param name="i_cyHeight">Desired view height in pixels (ignored; viewport size is taken from the UI region). </param>
    public void RecvNotice_UpdateGameView(uint i_cxScreen, uint i_cyScreen, uint i_cxWidth, uint i_cyHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint, uint, uint, uint, void>)0x004D6F20)(ref this, i_cxScreen, i_cyScreen, i_cxWidth, i_cyHeight);

    /// <summary>Begins a teleport animation for the smart box UI, resetting timing and angle values while optionally updating view distance before playing the portal entry sound.
    /// <code>Offset: 0x004D6F60
    /// void __thiscall gmSmartBoxUI::BeginTeleportAnimation(gmSmartBoxUI*,TeleportAnimState)</code>
    /// </summary>
    /// <param name="animState">The desired teleport animation state to activate.</param>
    public void BeginTeleportAnimation(ACBindings.Internal.TeleportAnimState animState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, ACBindings.Internal.TeleportAnimState, void>)0x004D6F60)(ref this, animState);

    /// <summary>Refreshes the FPS display element with the current frame rate and degrade multiplier.
    /// <code>Offset: 0x004D7000
    /// void __thiscall gmSmartBoxUI::UpdateFPSMeter(gmSmartBoxUI*)</code>
    /// </summary>
    public void UpdateFPSMeter() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7000)(ref this);

    /// <summary>Adjusts the smart box UI borders and corners to indicate whether the interface is locked, enabling or disabling input callbacks based on the current player module state.
    /// <code>Offset: 0x004D70A0
    /// void __thiscall gmSmartBoxUI::UpdateLockedStatus(gmSmartBoxUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D70A0)(ref this);

    /// <summary>Registers the SmartBox UI element type with the UI system, enabling layout descriptors to create SmartBox instances.
    /// <code>Offset: 0x004D71E0
    /// void __cdecl gmSmartBoxUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D71E0)();

    /// <summary>Ends a teleport animation by transitioning to continue mode, recording the start time of the transition, and resetting the smart box’s field‑of‑view override.
    /// <code>Offset: 0x004D7200
    /// void __thiscall gmSmartBoxUI::EndTeleportAnimation(gmSmartBoxUI*)</code>
    /// </summary>
    public void EndTeleportAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7200)(ref this);

    /// <summary>Enables or disables the FPS display in the SmartBox UI, refreshing the counter when shown.
    /// <code>Offset: 0x004D7240
    /// void __thiscall gmSmartBoxUI::RecvNotice_SetFramerateDisplay(gmSmartBoxUI*,bool)</code>
    /// </summary>
    /// <param name="i_fShow">True to show the framerate display; false to hide it.</param>
    public void RecvNotice_SetFramerateDisplay(byte i_fShow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, byte, void>)0x004D7240)(ref this, i_fShow);

    /// <summary>Resizes the smart box UI to the given dimensions, ensuring the width does not fall below 80% of the height. If a chat window ID is assigned, propagates the new size to the player's chat window settings.
    /// <code>Offset: 0x004D72B0
    /// void __thiscall gmSmartBoxUI::ResizeTo(gmSmartBoxUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_width">Desired width in pixels.</param>
    /// <param name="i_height">Desired height in pixels.</param>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, int, int, void>)0x004D72B0)(ref this, i_width, i_height);

    /// <summary>Moves the smart box UI element to the specified coordinates, clamping it within its parent region bounds and updating related player chat window options when applicable.
    /// <code>Offset: 0x004D7440
    /// void __thiscall gmSmartBoxUI::MoveTo(gmSmartBoxUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_x">Desired horizontal position for the UI element.</param>
    /// <param name="i_y">Desired vertical position for the UI element.</param>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, int, int, void>)0x004D7440)(ref this, i_x, i_y);

    /// <summary>Updates the smart box UI based on current player module chat window settings, applying focus changes and refreshing its locked state.
    /// <code>Offset: 0x004D7640
    /// void __thiscall gmSmartBoxUI::UpdateFromPlayerModule(gmSmartBoxUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7640)(ref this);

    /// <summary>Initializes the SmartBox UI by locating border and corner elements, configuring the portal viewport with lighting and camera settings, creating a teleport physics object, registering global event handlers, and recalculating layout positions.
    /// <code>Offset: 0x004D77C0
    /// void __thiscall gmSmartBoxUI::PostInit(gmSmartBoxUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D77C0)(ref this);

    /// <summary>Handles teleportation logic and camera transitions for the smart‑box UI, updating animations, portal effects, and FPS display each frame.
    /// <code>Offset: 0x004D7A90
    /// void __thiscall gmSmartBoxUI::UseTime(gmSmartBoxUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, void>)0x004D7A90)(ref this);

    /// <summary>Handles global messages for the smart‑box UI, performing special actions for selected IDs and delegating all others to its SmartBox wrapper.
    /// <code>Offset: 0x004D8140
    /// void __thiscall gmSmartBoxUI::ListenToGlobalMessage(gmSmartBoxUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the message received.</param>
    /// <param name="i_data_int">Associated integer data supplied with the message.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSmartBoxUI, uint, int, void>)0x004D8140)(ref this, i_messageID, i_data_int);
}

