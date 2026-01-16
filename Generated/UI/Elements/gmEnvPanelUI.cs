namespace ACBindings.Internal;


/// <summary>Handles the game’s environment panel UI, coordinating child panels, visibility states, and combat mode transitions while integrating with the global UI and event systems. Provides dynamic casting, registration, and notice handling for environment‑specific UI elements.</summary>
public unsafe struct gmEnvPanelUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmEnvPanelUI_vtbl
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

    /// <summary>Associates a child UI element with its parent panel, providing the panel identifier and indicating whether the child should be displayed by default.</summary>
    public unsafe struct PanelChildInfo
    {
        // Members
        public ACBindings.Internal.UIElement* child;
        public uint panelID;
        public byte bShouldBeDefault;

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___gmEnvPanelUI_PanelChildInfo m_childrenInfoArray;
    public ACBindings.Internal.UIElement* m_currentlyShownPanel;
    public ACBindings.Internal.UIElement* m_pDefaultPanel;

    // Generated Constructor
    public gmEnvPanelUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Changes the visibility state of a panel identified by its ID within the environment panel UI, updating internal references and layout accordingly.
    /// <code>Offset: 0x004CD350
    /// void __thiscall gmEnvPanelUI::RecvNotice_SetPanelVisibility(gmEnvPanelUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_ePanelID">The unique identifier of the target panel to show or hide.</param>
    /// <param name="i_bVisible">Non‑zero to make the panel visible; zero to hide it.</param>
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, uint i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, uint, uint, void>)0x004CD350)(ref this, i_ePanelID, i_bVisible);

    /// <summary>Initializes a gmEnvPanelUI instance with the specified layout and element descriptors, setting up the UI element base, notice handling, child info array, and default panel pointers.
    /// <code>Offset: 0x004CD540
    /// void __thiscall gmEnvPanelUI::gmEnvPanelUI(gmEnvPanelUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Pointer to the LayoutDesc defining display dimensions and elements.</param>
    /// <param name="full_desc">Pointer to the ElementDesc describing this UI element's properties and children.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CD540)(ref this, layout, full_desc);

    /// <summary>Performs a runtime check on the requested type identifier and returns a pointer to the corresponding UIElement interface of this panel, or nullptr if the identifier does not match.
    /// <code>Offset: 0x004CD5A0
    /// UIElement* __thiscall gmEnvPanelUI::DynamicCast(gmEnvPanelUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type identifier to cast to; 268435507 requests the base UIElement, 3 requests the gmEnvPanelUI itself.</param>
    /// <returns>A UIElement pointer representing either the base element or the panel object, or nullptr when the requested type is unsupported.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, uint, ACBindings.Internal.UIElement*>)0x004CD5A0)(ref this, i_eType);

    /// <summary>Returns the unique identifier for the gmEnvPanelUI element type.
    /// <code>Offset: 0x004CD5C0
    /// unsigned int __thiscall gmEnvPanelUI::GetUIElementType(gmEnvPanelUI*)</code>
    /// </summary>
    /// <returns>The UI element type constant (268435507) used to distinguish this panel within the UI system.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, uint>)0x004CD5C0)(ref this);

    /// <summary>Create a new environment panel UI object from the specified layout and element description.
    /// <code>Offset: 0x004CD5D0
    /// UIElement* __cdecl gmEnvPanelUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing display dimensions and element tables used to build the panel.</param>
    /// <param name="full_desc">Element descriptor that defines the root element’s properties, state, and child hierarchy for the panel.</param>
    /// <returns>Pointer to the newly constructed UIElement representing the panel, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004CD5D0)(layout, full_desc);

    /// <summary>Destroys a gmEnvPanelUI instance by cleaning up child panel data, unregistering notice handlers from the global event system, deallocating any dynamically allocated memory, and invoking base class destructors.
    /// <code>Offset: 0x004CD600
    /// void __thiscall gmEnvPanelUI::~gmEnvPanelUI(gmEnvPanelUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, void>)0x004CD600)(ref this);

    /// <summary>Registers the environment panel UI element class with the UI system using a unique identifier and factory method.
    /// <code>Offset: 0x004CD670
    /// void __cdecl gmEnvPanelUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CD670)();

    /// <summary>Initializes the panel’s child elements by locating specific UI components, storing them in an internal array, and clearing any existing input callbacks for each child.
    /// <code>Offset: 0x004CD6B0
    /// void __thiscall gmEnvPanelUI::SetupChildren(gmEnvPanelUI*)</code>
    /// </summary>
    public void SetupChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, void>)0x004CD6B0)(ref this);

    /// <summary>Initializes the environment panel UI by performing base class setup, registering required notice handlers with the global event handler, and configuring child panels.
    /// <code>Offset: 0x004CD7F0
    /// void __thiscall gmEnvPanelUI::PostInit(gmEnvPanelUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, void>)0x004CD7F0)(ref this);

    /// <summary>Updates the environment panel UI state in response to a combat mode change notice; clears a specific listener registration when switching to non‑combat mode.
    /// <code>Offset: 0x004F64D0
    /// void __thiscall gmEnvPanelUI::RecvNotice_SetCombatMode(gmEnvPanelUI*,COMBAT_MODE)</code>
    /// </summary>
    /// <param name="i_eCombatMode">The new combat mode value.</param>
    public void RecvNotice_SetCombatMode(ACBindings.Internal.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEnvPanelUI, ACBindings.Internal.COMBAT_MODE, void>)0x004F64D0)(ref this, i_eCombatMode);
}

