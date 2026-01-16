namespace ACBindings.Internal;


/// <summary>Handles user interface for spell components, managing the component list box, synchronizing visual regions, responding to player description and selection changes, and updating buy rates.</summary>
/// <remarks>Interacts with the magic system, global event handler, and component tracker; registers notice handlers for component updates and maintains internal mappings of component regions.</remarks>
public unsafe struct gmSpellComponentUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmSpellComponentUI_vtbl
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
    // gmSpellComponentUI::ListBoxEntryType
    public enum ListBoxEntryType : byte
    {
        ComponentCategory_ListBoxEntryType = 0x0,
        Component_ListBoxEntryType = 0x1
    }

    // Members
    public uint selObjectID;
    public ACBindings.Internal.UIElement_ListBox* m_pComponentListBox;
    public ACBindings.Internal.SmartArray__uint m_aCategoryTitles;
    public ACBindings.Internal.HashTable___IDClass____tagDataID___SpellComponentRegion_ptr m_hashComponentRegions;
    public byte m_bBroadcastSelection;

    // Generated Constructor
    public gmSpellComponentUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Responds to a selection‑change notice by updating the spell component list box to match the current selection. If no component is selected or the player does not own it, clears the list’s selection; otherwise locates the matching item in the list and marks it as selected.
    /// <code>Offset: 0x00489F70
    /// void __thiscall gmSpellComponentUI::RecvNotice_SelectionChanged(gmSpellComponentUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, void>)0x00489F70)(ref this);

    /// <summary>Create the icon for a spell component in the specified UIRegion by retrieving its graphic from the magic system.
    /// <code>Offset: 0x0048A250
    /// void __stdcall gmSpellComponentUI::MakeIcon(unsigned int,UIRegion*)</code>
    /// </summary>
    /// <param name="a1">The ID of the spell component to display.</param>
    /// <param name="a2">The UIRegion that will receive and show the component's icon; must not be null.</param>
    public static void MakeIcon(uint a1, ACBindings.Internal.UIRegion* a2) => ((delegate* unmanaged[Stdcall]<uint, ACBindings.Internal.UIRegion*, void>)0x0048A250)(a1, a2);

    /// <summary>Updates the displayed buy rate for a specified component within the UI's component list.
    /// <code>Offset: 0x0048A310
    /// void __thiscall gmSpellComponentUI::UpdateBuyRates(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the component whose buy rate should be refreshed.</param>
    public void UpdateBuyRates(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, int, void>)0x0048A310)(ref this, a2);

    /// <summary>Initializes the spell component user interface by populating category titles, locating the component list box, registering notice handlers for relevant events, and updating buy rates if a player descriptor is available.
    /// <code>Offset: 0x0048A4C0
    /// void __thiscall gmSpellComponentUI::PostInit(gmSpellComponentUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, void>)0x0048A4C0)(ref this);

    /// <summary>Updates UI component buy rates in response to a player description notice.
    /// <code>Offset: 0x0048A650
    /// void __thiscall gmSpellComponentUI::RecvNotice_PlayerDescReceived(gmSpellComponentUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities data received from server.</param>
    /// <param name="i_playerModule">Player module containing current state information.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x0048A650)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Handles UI element messages within the spell component UI, managing selection broadcasting and updating desired component levels based on user actions.
    /// <code>Offset: 0x0048A700
    /// UIElementMessageListenResult __thiscall gmSpellComponentUI::ListenToElementMessage(gmSpellComponentUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the received message, including its ID, parameters, and originating element.</param>
    /// <returns>The result of processing the message, typically forwarded to the base UIElement listener when not handled directly.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0048A700)(ref this, i_rMsg);

    /// <summary>Synchronizes a UI component region with the supplied component data by updating its stored object ID and item count, then refreshes any displayed text child to reflect the new quantity.
    /// <code>Offset: 0x0048A900
    /// void __thiscall gmSpellComponentUI::SyncComponentRegionWithData(gmSpellComponentUI*,const UIElement*,const ComponentData*)</code>
    /// </summary>
    /// <param name="pListBoxEntry">The list box entry UI element that identifies the target component region via its DataID attribute.</param>
    /// <param name="i_pData">The component data containing updated information such as first object ID and item count.</param>
    public void SyncComponentRegionWithData(ACBindings.Internal.UIElement* pListBoxEntry, ACBindings.Internal.ComponentData* i_pData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, ACBindings.Internal.UIElement*, ACBindings.Internal.ComponentData*, void>)0x0048A900)(ref this, pListBoxEntry, i_pData);

    /// <summary>Initializes a spell component UI element with the specified layout and description, setting up internal structures and default state.
    /// <code>Offset: 0x0048AA50
    /// void __thiscall gmSpellComponentUI::gmSpellComponentUI(gmSpellComponentUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing display dimensions and element definitions for the UI.</param>
    /// <param name="full_desc">Element descriptor defining the properties and hierarchy of the UI element.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0048AA50)(ref this, layout, full_desc);

    /// <summary>Attempts a runtime type-safe cast of the current spell component UI instance to the specified element type, returning a UIElement pointer if successful.
    /// <code>Offset: 0x0048AAD0
    /// UIElement* __thiscall gmSpellComponentUI::DynamicCast(gmSpellComponentUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the element type to cast to; 3 corresponds to UIElement and 268435503 corresponds to gmSpellComponentUI itself.</param>
    /// <returns>Pointer to the requested element type if the cast matches; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, uint, ACBindings.Internal.UIElement*>)0x0048AAD0)(ref this, i_eType);

    /// <summary>Retrieves the UI element type identifier for a spell component UI instance.
    /// <code>Offset: 0x0048AAF0
    /// unsigned int __thiscall gmSpellComponentUI::GetUIElementType(gmSpellComponentUI*)</code>
    /// </summary>
    /// <returns>The element type constant identifying this UI element within the UI system.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, uint>)0x0048AAF0)(ref this);

    /// <summary>Destroys a gmSpellComponentUI object, releasing its component list box, unregistering notice handlers, clearing hash tables of component regions and category titles, and resetting internal state before base class destructors execute.
    /// <code>Offset: 0x0048AB00
    /// void __thiscall gmSpellComponentUI::~gmSpellComponentUI(gmSpellComponentUI*)</code>
    /// </summary>
    /// <param name="this">The instance to be destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, void>)0x0048AB00)(ref this);

    /// <summary>Creates a new spell component UI element initialized with the specified layout and element description.
    /// <code>Offset: 0x0048ABC0
    /// UIElement* __cdecl gmSpellComponentUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining visual dimensions and sub‑elements for the UI.</param>
    /// <param name="full_desc">Element description providing properties, states, and hierarchy for the UI element.</param>
    /// <returns>Pointer to the constructed UIElement, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0048ABC0)(layout, full_desc);

    /// <summary>Updates the spell component UI list based on changes from the player’s component tracker. Adds new entries, removes obsolete ones, and refreshes existing items—including icons and buy rates—while maintaining an internal hash table of component regions. After processing, broadcasts a notice that item attributes have changed.
    /// <code>Offset: 0x0048ABF0
    /// void __thiscall gmSpellComponentUI::UpdateComponents(gmSpellComponentUI*,ComponentTrackerUpdate)</code>
    /// </summary>
    /// <param name="change">Specifies whether components were added or removed; determines how the UI list is updated accordingly.</param>
    public void UpdateComponents(ACBindings.Internal.ComponentTrackerUpdate change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, ACBindings.Internal.ComponentTrackerUpdate, void>)0x0048ABF0)(ref this, change);

    /// <summary>Registers the Spell Component UI element type with the UI system, associating it with its creation callback.
    /// <code>Offset: 0x0048B0D0
    /// void __cdecl gmSpellComponentUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048B0D0)();

    /// <summary>Handles a notice indicating that the set of spell components has changed and forwards the change to UpdateComponents.
    /// <code>Offset: 0x0048B0F0
    /// void __thiscall gmSpellComponentUI::RecvNotice_UpdateSpellComponents(gmSpellComponentUI*,int)</code>
    /// </summary>
    /// <param name="i_change">Specifies the type of change (e.g., added, removed, or modified) for the component tracker.</param>
    public void RecvNotice_UpdateSpellComponents(int i_change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellComponentUI, int, void>)0x0048B0F0)(ref this, i_change);
}

