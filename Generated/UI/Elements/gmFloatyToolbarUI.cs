namespace ACBindings.Internal;


/// <summary>Floaty toolbar UI element that can be moved freely on screen, providing draggable borders and corners, updating its position to the player module, handling visibility, lock status, and resizing behavior.</summary>
public unsafe struct gmFloatyToolbarUI
{
    // Base Classes
    public ACBindings.Internal.gmToolbarUI BaseClass_gmToolbarUI; // ACBindings.Internal.gmToolbarUI

    // Child Types
    public unsafe struct gmFloatyToolbarUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmFloatyToolbarUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public uint m_eWindowID;
    public ACBindings.Internal.UIElement* m_pTopBorder;
    public ACBindings.Internal.UIElement* m_pLeftBorder;
    public ACBindings.Internal.UIElement* m_pBottomBorder;
    public ACBindings.Internal.UIElement* m_pRightBorder;
    public ACBindings.Internal.UIElement* m_pTopLeftCorner;
    public ACBindings.Internal.UIElement* m_pTopRightCorner;
    public ACBindings.Internal.UIElement* m_pBottomLeftCorner;
    public ACBindings.Internal.UIElement* m_pBottomRightCorner;
    public ACBindings.Internal.UIElement* m_pTopBorder_Locked;
    public ACBindings.Internal.UIElement* m_pLeftBorder_Locked;
    public ACBindings.Internal.UIElement* m_pBottomBorder_Locked;
    public ACBindings.Internal.UIElement* m_pRightBorder_Locked;
    public ACBindings.Internal.UIElement* m_pTopLeftCorner_Locked;
    public ACBindings.Internal.UIElement* m_pTopRightCorner_Locked;
    public ACBindings.Internal.UIElement* m_pBottomLeftCorner_Locked;
    public ACBindings.Internal.UIElement* m_pBottomRightCorner_Locked;

    // Methods

    /// <summary>Performs a runtime cast from gmFloatyToolbarUI to the requested UI element type, returning the appropriate base pointer if the type matches.
    /// <code>Offset: 0x004D01A0
    /// UIElement* __thiscall gmFloatyToolbarUI::DynamicCast(gmFloatyToolbarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The identifier of the desired UI element type.</param>
    /// <returns>A UIElement pointer for the requested type when conversion is possible; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, uint, ACBindings.Internal.UIElement*>)0x004D01A0)(ref this, i_eType);

    /// <summary>Returns the unique identifier for this floaty toolbar UI element.
    /// <code>Offset: 0x004D01D0
    /// unsigned int __thiscall gmFloatyToolbarUI::GetUIElementType(gmFloatyToolbarUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the UI element type code.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, uint>)0x004D01D0)(ref this);

    /// <summary>Creates a floaty toolbar UI element using the specified layout and element descriptors.
    /// <code>Offset: 0x004D01E0
    /// UIElement* __cdecl gmFloatyToolbarUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description defining display properties and contained elements.</param>
    /// <param name="full_desc">Full element descriptor containing state and child information for the toolbar.</param>
    /// <returns>Pointer to the newly created UIElement if successful; otherwise null when memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004D01E0)(layout, full_desc);

    /// <summary>Updates the visual lock status of the floaty toolbar, showing or hiding locked borders and enabling or disabling input callbacks based on the current player module lock state.
    /// <code>Offset: 0x004D0210
    /// void __thiscall gmFloatyToolbarUI::UpdateLockedStatus(gmFloatyToolbarUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, void>)0x004D0210)(ref this);

    /// <summary>Updates the floaty toolbar UI when a new player description is received, refreshing graphical components and forwarding the notice to the base toolbar handler.
    /// <code>Offset: 0x004D03E0
    /// void __thiscall gmFloatyToolbarUI::RecvNotice_PlayerDescReceived(gmFloatyToolbarUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player qualities descriptor containing attributes and statistics used to update UI elements.</param>
    /// <param name="i_playerModule">The module providing additional player state information such as dirtiness and timestamps.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004D03E0)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Registers the floaty toolbar UI element type with the UI framework, allowing instances to be created via its class identifier.
    /// <code>Offset: 0x004D0450
    /// void __cdecl gmFloatyToolbarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D0450)();

    /// <summary>Initializes the floaty toolbar user interface by locating and storing references to its border and corner elements, registering notice handlers for window state changes, and subscribing to relevant global messages.
    /// <code>Offset: 0x004D0470
    /// void __thiscall gmFloatyToolbarUI::PostInit(gmFloatyToolbarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, void>)0x004D0470)(ref this);

    /// <summary>Handles global messages sent to the floaty toolbar UI. When it receives a message with ID 13, it updates its lock status; otherwise, it forwards the message to the base toolbar class.
    /// <code>Offset: 0x004D0800
    /// void __thiscall gmFloatyToolbarUI::ListenToGlobalMessage(gmFloatyToolbarUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">The identifier of the global message.</param>
    /// <param name="i_data_int">Optional integer data accompanying the message.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, uint, int, void>)0x004D0800)(ref this, i_messageID, i_data_int);

    /// <summary>Updates the floaty toolbar UI according to the current player module settings, retrieving chat window options and adjusting focus, input callbacks, and lock status as needed.
    /// <code>Offset: 0x004D0830
    /// void __thiscall gmFloatyToolbarUI::UpdateFromPlayerModule(gmFloatyToolbarUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, void>)0x004D0830)(ref this);

    /// <summary>Resizes this floaty toolbar to the given dimensions and synchronizes the chat window size for the associated window ID in the player module, if one exists.
    /// <code>Offset: 0x004D0A90
    /// void __thiscall gmFloatyToolbarUI::ResizeTo(gmFloatyToolbarUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_width">Target width of the toolbar.</param>
    /// <param name="i_height">Target height of the toolbar.</param>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, int, int, void>)0x004D0A90)(ref this, i_width, i_height);

    /// <summary>Moves the floaty toolbar to the specified screen coordinates, clamping the position within the visible region and updating the player's stored window location if necessary.
    /// <code>Offset: 0x004D0C00
    /// void __thiscall gmFloatyToolbarUI::MoveTo(gmFloatyToolbarUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_x">Target X coordinate in pixels.</param>
    /// <param name="i_y">Target Y coordinate in pixels.</param>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, int, int, void>)0x004D0C00)(ref this, i_x, i_y);

    /// <summary>Sets the toolbar’s visibility and updates the associated chat window setting in the player module.
    /// <code>Offset: 0x004D0E00
    /// void __thiscall gmFloatyToolbarUI::SetVisible(gmFloatyToolbarUI*,bool)</code>
    /// </summary>
    /// <param name="i_fVisible">True to make the toolbar visible; false to hide it.</param>
    public void SetVisible(byte i_fVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFloatyToolbarUI, byte, void>)0x004D0E00)(ref this, i_fVisible);
}

