namespace ACBindings.Internal;


/// <summary>Map UI component handling map display, player/house markers, and periodic updates.</summary>
/// <remarks>Inherits from UIElement_Field and implements gmNoticeHandler to receive global events related to housing and teleportation.</remarks>
public unsafe struct gmMapUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmMapUI_vtbl
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

    /// <summary>Represents a rectangular region on the map UI that displays rollover information, including its top‑left position (X, Y), dimensions (Width, Height) and an associated name string.</summary>
    public unsafe struct LocationRolloverInfo
    {
        // Members
        public uint X;
        public uint Y;
        public uint Width;
        public uint Height;
        public System.IntPtr Name;

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_pDateTimeText;
    public ACBindings.Internal.UIElement_Text* m_pCoordinateText;
    public ACBindings.Internal.UIElement* m_pPlayerLocationIcon;
    public ACBindings.Internal.UIElement* m_pHouseLocationIcon;
    public ACBindings.Internal.UIElement* m_pMap;
    public ACBindings.Internal.Box2D m_boxMapMarkerArea;
    public double m_nextUpdate;
    public ACBindings.Internal.Position m_HousePosition;

    // Generated Constructor
    public gmMapUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the map UI's internal registration of a house using its HouseData. For non‑type‑4 houses, stores the cell ID and frame information; for type 4 houses, clears the corresponding bucket.
    /// <code>Offset: 0x004A1BA0
    /// void __thiscall gmMapUI::RecvNotice_UpdateHouseData(gmMapUI*,const HouseData*)</code>
    /// </summary>
    /// <param name="i_houseData">House data containing type, position, and frame information used to update the map UI registration.</param>
    public void RecvNotice_UpdateHouseData(ACBindings.Internal.HouseData* i_houseData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, ACBindings.Internal.HouseData*, void>)0x004A1BA0)(ref this, i_houseData);

    /// <summary>Handles a failed house transaction notice by clearing a specific element registration bucket used for UI listeners.
    /// <code>Offset: 0x004A1BD0
    /// void __thiscall gmMapUI::RecvNotice_FailedHouseTransaction(gmMapUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the failure type (unused in current implementation).</param>
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, uint, void>)0x004A1BD0)(ref this, i_eType);

    /// <summary>Places a UI element marker onto the map at the specified logical map coordinates and moves it to the corresponding screen position.
    /// <code>Offset: 0x004A1BE0
    /// bool __thiscall gmMapUI::PlaceMarkerOnMap(gmMapUI*,UIElement*,long double,long double)</code>
    /// </summary>
    /// <param name="i_pMarker">The UIElement representing the marker; placement fails if this is null.</param>
    /// <param name="i_x">X coordinate in the map’s logical space (typically 0–1024).</param>
    /// <param name="i_y">Y coordinate in the map’s logical space (typically 0–1024).</param>
    /// <returns>True when the marker is positioned successfully; false if i_pMarker is null.</returns>
    public byte PlaceMarkerOnMap(ACBindings.Internal.UIElement* i_pMarker, double i_x, double i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, ACBindings.Internal.UIElement*, double, double, byte>)0x004A1BE0)(ref this, i_pMarker, i_x, i_y);

    /// <summary>Constructs a GM map user interface component from layout and element descriptors, initializing all internal pointers, event handlers, and state to their default values.
    /// <code>Offset: 0x004A1D20
    /// void __thiscall gmMapUI::gmMapUI(gmMapUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing display parameters for the UI.</param>
    /// <param name="full_desc">Full element description used by the base class constructor.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004A1D20)(ref this, layout, full_desc);

    /// <summary>Returns a UIElement pointer for this gmMapUI instance when the requested type ID matches either the gmMapUI type (268435494) or the generic UIElement type (3); otherwise returns null.
    /// <code>Offset: 0x004A1DD0
    /// UIElement* __thiscall gmMapUI::DynamicCast(gmMapUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The element type identifier to cast to. 268435494 represents gmMapUI, while 3 corresponds to a generic UIElement.</param>
    /// <returns>Pointer to the appropriate UIElement if the requested type matches; nullptr if it does not.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, uint, ACBindings.Internal.UIElement*>)0x004A1DD0)(ref this, i_eType);

    /// <summary>Provides the unique identifier for this UI element type.
    /// <code>Offset: 0x004A1DF0
    /// unsigned int __thiscall gmMapUI::GetUIElementType(gmMapUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer value representing the UI element type (268435494).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, uint>)0x004A1DF0)(ref this);

    /// <summary>Destroys a gmMapUI instance, freeing its internal UI components and unregistering it from the global event system.
    /// <code>Offset: 0x004A1E00
    /// void __thiscall gmMapUI::~gmMapUI(gmMapUI*)</code>
    /// </summary>
    /// <param name="this">Pointer to the object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, void>)0x004A1E00)(ref this);

    /// <summary>Creates and initializes a gmMapUI instance using the supplied layout and element description, returning it as a UIElement pointer.
    /// <code>Offset: 0x004A1E70
    /// UIElement* __cdecl gmMapUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display size and contained elements.</param>
    /// <param name="full_desc">Full element description for the root UI element.</param>
    /// <returns>A pointer to the newly created UIElement (gmMapUI) or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004A1E70)(layout, full_desc);

    /// <summary>Registers the gmMapUI class with the UI system, enabling creation of map UI elements through its registered factory method.
    /// <code>Offset: 0x004A1EC0
    /// void __cdecl gmMapUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A1EC0)();

    /// <summary>Adds a map note to the specified map element, creating a child UIElement with layout idNote, positioning it using the provided coordinates and size from lri, and setting its tooltip text to the name supplied in lri.
    /// <code>Offset: 0x004A1EE0
    /// void __thiscall gmMapUI::AddMapNote(gmMapUI*,UIElement*,unsigned int,const LayoutDesc*,const gmMapUI::LocationRolloverInfo*)</code>
    /// </summary>
    /// <param name="pMap">The UIElement representing the map onto which the note will be added.</param>
    /// <param name="idNote">Identifier used when creating the child element for the note.</param>
    /// <param name="pLayout">Layout descriptor that defines the visual structure of the note element.</param>
    /// <param name="lri">Structure containing X and Y coordinates, width and height for positioning, and a name string used as the tooltip text.</param>
    public void AddMapNote(ACBindings.Internal.UIElement* pMap, uint idNote, ACBindings.Internal.LayoutDesc* pLayout, ACBindings.Internal.gmMapUI.LocationRolloverInfo* lri) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, ACBindings.Internal.UIElement*, uint, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.gmMapUI.LocationRolloverInfo*, void>)0x004A1EE0)(ref this, pMap, idNote, pLayout, lri);

    /// <summary>Initializes map UI components by locating child elements such as date/time text, coordinate display, player and house icons, and the map itself. Configures the marker area using attributes from the map element and attaches notes based on layout data. Registers global notice handlers for map‑related events.
    /// <code>Offset: 0x004A1FA0
    /// void __thiscall gmMapUI::PostInit(gmMapUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, void>)0x004A1FA0)(ref this);

    /// <summary>Refreshes the map UI elements—date/time text, player coordinates when outside, and house location marker if defined—and schedules the next update for five seconds later.
    /// <code>Offset: 0x004A21E0
    /// bool __thiscall gmMapUI::Update(gmMapUI*)</code>
    /// </summary>
    /// <returns>True if the update was performed successfully; returns false only when a required player system cannot be obtained.</returns>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, byte>)0x004A21E0)(ref this);

    /// <summary>Updates the map interface when a specific global message arrives after its scheduled interval.
    /// <code>Offset: 0x004A2650
    /// void __thiscall gmMapUI::ListenToGlobalMessage(gmMapUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message to process.</param>
    /// <param name="i_data_int">Additional integer data supplied with the message (not used in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, uint, int, void>)0x004A2650)(ref this, i_messageID, i_data_int);

    /// <summary>Handles map UI element messages, toggling global listener registration on activation and processing click events to trigger teleport when appropriate.
    /// <code>Offset: 0x004A2680
    /// UIElementMessageListenResult __thiscall gmMapUI::ListenToElementMessage(gmMapUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>The result of handling the message, normally forwarded from the base implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmMapUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004A2680)(ref this, i_rMsg);
}

