namespace ACBindings.Internal;


/// <summary>Provides the character generation summary page UI element, managing name input, displaying character attributes, and rendering a 3‑D preview of the selected template.</summary>
public unsafe struct gmCGSummaryPage
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGSummaryPage_vtbl
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
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.Internal.UIElement_ListBox* m_pSummaryListbix;
    public ACBindings.Internal.UIElement_Text* m_pNameText;
    public ACBindings.Internal.UIElement_Text* m_pHowToText;
    public ACBindings.Internal.UIElement_Scrollbar* m_pScoll;
    public ACBindings.Internal.UIElement_Viewport* m_pViewport;
    public ACBindings.Internal.gmCG3DView* m_p3DView;
    public byte m_bNameEntered;
    public uint m_uiErrorMessageContext;

    // Generated Constructor
    public gmCGSummaryPage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Creates a character generation summary page UI element, initializing its base class and setting all member pointers to null.
    /// <code>Offset: 0x0047B030
    /// void __thiscall gmCGSummaryPage::gmCGSummaryPage(gmCGSummaryPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout definition used by the UI element.</param>
    /// <param name="full_desc">Full element description providing properties and states for initialization.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0047B030)(ref this, layout, full_desc);

    /// <summary>Performs an RTTI-style dynamic cast, returning a pointer to the requested UIElement subtype or null if incompatible.
    /// <code>Offset: 0x0047B0A0
    /// UIElement* __thiscall gmCGSummaryPage::DynamicCast(gmCGSummaryPage*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired component type for casting.</param>
    /// <returns>A pointer to the casted element on success; otherwise, nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, uint, ACBindings.Internal.UIElement*>)0x0047B0A0)(ref this, i_eType);

    /// <summary>Returns the unique identifier representing the UI element type for a character generation summary page.
    /// <code>Offset: 0x0047B0C0
    /// unsigned int __thiscall gmCGSummaryPage::GetUIElementType(gmCGSummaryPage*)</code>
    /// </summary>
    /// <returns>The unsigned integer constant 268435518 which identifies this UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, uint>)0x0047B0C0)(ref this);

    /// <summary>Initializes UI elements for the summary page and registers its notice handler with the global event system to receive notification 100004.
    /// <code>Offset: 0x0047B0D0
    /// void __thiscall gmCGSummaryPage::PostInit(gmCGSummaryPage*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, void>)0x0047B0D0)(ref this);

    /// <summary>Create a gmCGSummaryPage instance from the specified layout and element description, initializing its internal UI elements.
    /// <code>Offset: 0x0047B110
    /// UIElement* __cdecl gmCGSummaryPage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes the overall page geometry and header strings used to build the UI hierarchy.</param>
    /// <param name="full_desc">Provides detailed state, child relationships, and appearance data for individual UI components.</param>
    /// <returns>Pointer to the newly constructed UIElement representing the summary page; returns nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0047B110)(layout, full_desc);

    /// <summary>Unregisters the UI element associated with a closed notice dialog when its context matches the stored element.
    /// <code>Offset: 0x0047B140
    /// void __thiscall gmCGSummaryPage::RecvNotice_CloseDialog(gmCGSummaryPage*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="this">The gmCGSummaryPage instance handling the notice.</param>
    /// <param name="context">Identifier for the notice dialog, used to match the registered element.</param>
    /// <param name="data">Additional properties supplied with the notice (unused in this handler).</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, uint, ACBindings.Internal.PropertyCollection*, void>)0x0047B140)(ref this, context, data);

    /// <summary>Updates the summary page's how-to text by selecting appropriate localized strings based on the current character generation state (gender and heritage group) and concatenating them into a single instructional message.
    /// <code>Offset: 0x0047B1E0
    /// void __thiscall gmCGSummaryPage::SetHowToText(gmCGSummaryPage*)</code>
    /// </summary>
    public void SetHowToText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, void>)0x0047B1E0)(ref this);

    /// <summary>Refreshes the summary page by clearing existing items and repopulating it with the character's profession, gender, heritage, starting town, attribute values, and skill details.
    /// <code>Offset: 0x0047B590
    /// void __thiscall gmCGSummaryPage::SetSummaryText(gmCGSummaryPage*)</code>
    /// </summary>
    public void SetSummaryText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, void>)0x0047B590)(ref this);

    /// <summary>Updates the character generation summary page, adjusting camera positioning based on heritage group, fitting the template to the current character, refreshing summary and instructions text, updating the 3D view, and ensuring the name input prompt is displayed if a name has not yet been entered.
    /// <code>Offset: 0x0047BE60
    /// void __thiscall gmCGSummaryPage::Update(gmCGSummaryPage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, void>)0x0047BE60)(ref this);

    /// <summary>Initializes the character summary page by locating UI elements, creating a 3D preview view, and setting up initial camera parameters.
    /// <code>Offset: 0x0047BFB0
    /// void __thiscall gmCGSummaryPage::InitializePage(gmCGSummaryPage*,gmCharGenMainUI*)</code>
    /// </summary>
    /// <param name="pMain">Reference to the main character generation UI framework used to resolve child components.</param>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, ACBindings.Internal.gmCharGenMainUI*, void>)0x0047BFB0)(ref this, pMain);

    /// <summary>Displays an error dialog indicating the character name exceeds the allowed length, but only if no other name‑limit dialog is currently shown.
    /// <code>Offset: 0x0047C140
    /// void __thiscall gmCGSummaryPage::DoNameLimitDialog(gmCGSummaryPage*)</code>
    /// </summary>
    public void DoNameLimitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, void>)0x0047C140)(ref this);

    /// <summary>Processes UI element messages for the character generation summary page. Handles completion of name entry (messages 18 or 68), validates the entered name length, updates the player system with the new name, refreshes the displayed text, and triggers a limit dialog if the name exceeds allowed characters.
    /// <code>Offset: 0x0047C300
    /// UIElementMessageListenResult __thiscall gmCGSummaryPage::ListenToElementMessage(gmCGSummaryPage*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Pointer to UIElementMessageInfo containing the message ID and associated element data.</param>
    /// <returns>Result of UIElement::ListenToElementMessage indicating whether the message was handled.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGSummaryPage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0047C300)(ref this, i_rMsg);
}

