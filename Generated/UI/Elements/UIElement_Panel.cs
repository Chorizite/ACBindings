namespace ACBindings.Internal;


/// <summary>
/// Represents a panel UI element that manages tabbed pages, maintaining mappings between tabs and pages and tracking the currently open page and tab.
/// </summary>
public unsafe struct UIElement_Panel : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement BaseClass_UIElement; // ACBindings.Internal.UIElement

    // Child Types
    public unsafe struct UIElement_Panel_vtbl
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
    public ACBindings.Internal.HashTable__uint__uint m_TabPageHash;
    public ACBindings.Internal.HashTable__uint__uint m_PageTabHash;
    public uint m_OpenPageToken;
    public uint m_OpenTabToken;

    // Generated Constructor
    public UIElement_Panel(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Queries and populates an AvailablePropertySet with properties applicable to this panel, combining information from its base UIElement and the master property database (group 15).
    /// <code>Offset: 0x0046BF60
    /// bool __thiscall UIElement_Panel::InqAvailableProperties(UIElement_Panel*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">A non‑null pointer to an Existing AvailablePropertySet that will receive the available properties.</param>
    /// <returns>True if both the base class and master property queries succeed; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, ACBindings.Internal.AvailablePropertySet*, byte>)0x0046BF60)(ref this, set);

    /// <summary>Updates the panel’s active page and tab identifiers, notifying child elements of any changes and broadcasting a state‑change event.
    /// <code>Offset: 0x0046BFF0
    /// void __thiscall UIElement_Panel::Update(UIElement_Panel*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_nNewOpenPageID">The identifier for the new open page token.</param>
    /// <param name="i_nNewOpenTabID">The identifier for the new open tab token.</param>
    public void Update(uint i_nNewOpenPageID, uint i_nNewOpenTabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, uint, uint, void>)0x0046BFF0)(ref this, i_nNewOpenPageID, i_nNewOpenTabID);

    /// <summary>Opens a tab identified by the supplied tab ID, ensuring it maps correctly to a page before updating the panel’s state.
    /// <code>Offset: 0x0046C110
    /// bool __thiscall UIElement_Panel::OpenTab(UIElement_Panel*,unsigned int)</code>
    /// </summary>
    /// <param name="tabID">The identifier of the tab to open.</param>
    /// <returns>True if the tab exists and the panel was successfully updated; otherwise, false.</returns>
    public byte OpenTab(uint tabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, uint, byte>)0x0046C110)(ref this, tabID);

    /// <summary>Retrieves the tab identifier corresponding to a given page token, storing it through an output parameter.
    /// <code>Offset: 0x0046C1A0
    /// bool __thiscall UIElement_Panel::InqTabFromPage(UIElement_Panel*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="pageToken">The unique token identifying a page within the panel.</param>
    /// <param name="tabToken">Pointer to receive the associated tab token when found.</param>
    /// <returns>True if the mapping exists and the tab token was returned; otherwise, false.</returns>
    public byte InqTabFromPage(uint pageToken, uint* tabToken) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, uint, uint*, byte>)0x0046C1A0)(ref this, pageToken, tabToken);

    /// <summary>Handles panel-specific element messages, such as opening and closing tabs or pages, updating internal state, and then delegating to base UIElement processing.
    /// <code>Offset: 0x0046C370
    /// UIElementMessageListenResult __thiscall UIElement_Panel::ListenToElementMessage(UIElement_Panel*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing sender element, message ID, parameters, and coordinates.</param>
    /// <returns>Result of handling the message (e.g., whether it was consumed).</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0046C370)(ref this, i_rMsg);

    /// <summary>Initializes a UI panel element using the specified layout and element descriptors, setting up internal tab and page mappings.
    /// <code>Offset: 0x0046C550
    /// void __thiscall UIElement_Panel::UIElement_Panel(UIElement_Panel*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The LayoutDesc describing display size and contained elements for the panel.</param>
    /// <param name="full_desc">The ElementDesc defining the panel's visual and behavioral characteristics.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0046C550)(ref this, layout, full_desc);

    /// <summary>Attempts to cast the current panel instance to the requested UI element type. Returns the panel pointer when the type identifier equals the panel's type ID; otherwise returns null.
    /// <code>Offset: 0x0046C5B0
    /// UIElement* __thiscall UIElement_Panel::DynamicCast(UIElement_Panel*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The panel instance being cast.</param>
    /// <param name="i_eType">Identifier of the desired UI element type.</param>
    /// <returns>Pointer to this panel as a UIElement if the requested type matches, or nullptr if it does not.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, uint, ACBindings.Internal.UIElement*>)0x0046C5B0)(ref this, i_eType);

    /// <summary>Destroys a UIElement_Panel by clearing its tab‑page association tables, resetting open page and tab tokens, freeing any dynamically allocated bucket memory, and invoking the base UIElement destructor.
    /// <code>Offset: 0x0046C5D0
    /// void __thiscall UIElement_Panel::~UIElement_Panel(UIElement_Panel*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, void>)0x0046C5D0)(ref this);

    /// <summary>Create a new panel UI element by allocating memory and initializing it with the given layout descriptor and element description.
    /// <code>Offset: 0x0046C690
    /// UIElement* __cdecl UIElement_Panel::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor that defines display dimensions and child elements for the panel.</param>
    /// <param name="full_desc">Detailed element description used to configure the panel’s properties and behavior.</param>
    /// <returns>Pointer to the newly created UIElement representing the panel, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0046C690)(layout, full_desc);

    /// <summary>Configures tab‑to‑page mappings by clearing existing hash tables, interpreting the panel’s tab‑page property (action code 46), populating m_TabPageHash and m_PageTabHash, updating open page/tab tokens if a default is specified, and focusing the child element for that page. The method then calls Update with the resulting page identifier.
    /// <code>Offset: 0x0046C6C0
    /// void __thiscall UIElement_Panel::SetupTabPageHash(UIElement_Panel*)</code>
    /// </summary>
    public void SetupTabPageHash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, void>)0x0046C6C0)(ref this);

    /// <summary>Registers the panel element type within the UI framework, linking the element’s unique identifier to its factory method.
    /// <code>Offset: 0x0046CA90
    /// void __cdecl UIElement_Panel::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0046CA90)();

    /// <summary>Handles setting of a BaseProperty on a UI panel element; forwards the call to the base class and updates internal tab page hash when the attribute corresponds to the panel's tab-page configuration.
    /// <code>Offset: 0x0046CAA0
    /// void __thiscall UIElement_Panel::OnSetAttribute(UIElement_Panel*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The property being applied to the panel, which may trigger updates to tab-page structures if its name matches the expected identifier.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Panel, ACBindings.Internal.BaseProperty*, void>)0x0046CAA0)(ref this, attribute);
}

