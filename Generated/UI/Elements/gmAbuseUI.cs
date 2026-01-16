namespace ACBindings.Internal;


/// <summary>Provides the user interface for reporting in‑game abuse, managing name entry, complaint text, result display, and submission controls.</summary>
public unsafe struct gmAbuseUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmAbuseUI_vtbl
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
    public ACBindings.Internal.UIElement_Text* m_pNameBox;
    public ACBindings.Internal.UIElement_Text* m_pEntryBox;
    public ACBindings.Internal.UIElement_Text* m_pResultText;
    public ACBindings.Internal.UIElement_Button* m_pContinueButton;

    // Generated Constructor
    public gmAbuseUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a UI element for the abuse reporting system, configuring its layout and element hierarchy from the provided descriptors while setting up necessary notice handling callbacks.
    /// <code>Offset: 0x004BCB40
    /// void __thiscall gmAbuseUI::gmAbuseUI(gmAbuseUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information defining screen dimensions and base elements.</param>
    /// <param name="full_desc">Full element description containing state, child elements, and properties to be applied to the UI instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004BCB40)(ref this, layout, full_desc);

    /// <summary>Attempts to cast a gmAbuseUI instance to the specified UIElement-derived type based on an integer identifier.
    /// <code>Offset: 0x004BCB90
    /// UIElement* __thiscall gmAbuseUI::DynamicCast(gmAbuseUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">An identifier indicating the target type for casting; recognised values include 268435480 for the base UIElement and 3 for the derived gmAbuseUI itself.</param>
    /// <returns>A pointer to the requested UIElement if the cast is valid, or null when the requested type does not match.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, uint, ACBindings.Internal.UIElement*>)0x004BCB90)(ref this, i_eType);

    /// <summary>Retrieves the unique numeric identifier for the UI element type of this abuse UI component.
    /// <code>Offset: 0x004BCBB0
    /// unsigned int __thiscall gmAbuseUI::GetUIElementType(gmAbuseUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the UI element type, currently fixed at 268435480.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, uint>)0x004BCBB0)(ref this);

    /// <summary>Initializes abuse UI controls by locating child text boxes and continue button, then registers a notice handler with the global event system.
    /// <code>Offset: 0x004BCBC0
    /// void __thiscall gmAbuseUI::PostInit(gmAbuseUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, void>)0x004BCBC0)(ref this);

    /// <summary>Destroys the gmAbuseUI object, releasing its UI components and unregistering from global event handling.
    /// <code>Offset: 0x004BCC30
    /// void __thiscall gmAbuseUI::~gmAbuseUI(gmAbuseUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, void>)0x004BCC30)(ref this);

    /// <summary>Creates a new abuse UI element using the provided layout and element descriptor.
    /// <code>Offset: 0x004BCC90
    /// UIElement* __cdecl gmAbuseUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information that defines display size, elements, and state headers for the UI.</param>
    /// <param name="full_desc">Full description of the root element to be constructed within the UI hierarchy.</param>
    /// <returns>Pointer to the initialized UIElement instance, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004BCC90)(layout, full_desc);

    /// <summary>Registers the abuse UI element class with the UI system, linking it to its unique identifier and creation callback.
    /// <code>Offset: 0x004BCCE0
    /// void __cdecl gmAbuseUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BCCE0)();

    /// <summary>Validates the name and entry text boxes in the abuse UI, enabling or disabling the continue button based on whether input has been entered.
    /// <code>Offset: 0x004BCD00
    /// bool __thiscall gmAbuseUI::HandleTextEntry(gmAbuseUI*)</code>
    /// </summary>
    /// <returns>Always true to indicate processing completed successfully.</returns>
    public byte HandleTextEntry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, byte>)0x004BCD00)(ref this);

    /// <summary>Updates the result text UI element with the localized string corresponding to the provided token.
    /// <code>Offset: 0x004BCDC0
    /// bool __thiscall gmAbuseUI::SetPageThreeText(gmAbuseUI*,const unsigned int)</code>
    /// </summary>
    /// <param name="token">Identifier of the string in the localization table.</param>
    /// <returns>Always true after setting the text.</returns>
    public byte SetPageThreeText(uint token) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, uint, byte>)0x004BCDC0)(ref this, token);

    /// <summary>Displays a result message following an abuse report submission based on server response code.
    /// <code>Offset: 0x004BCE40
    /// void __thiscall gmAbuseUI::RecvNotice_AbuseReportResponse(gmAbuseUI*,unsigned int)</code>
    /// </summary>
    /// <param name="error">Error or status code returned by the server for the abuse report operation.</param>
    public void RecvNotice_AbuseReportResponse(uint error) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, uint, void>)0x004BCE40)(ref this, error);

    /// <summary>Resets the abuse UI to its default state by clearing the name and entry text boxes, restoring the continue button’s action callback, and cleaning up related resources.
    /// <code>Offset: 0x004BCE90
    /// bool __thiscall gmAbuseUI::Reset(gmAbuseUI*)</code>
    /// </summary>
    /// <returns>Returns true when the reset is complete.</returns>
    public byte Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, byte>)0x004BCE90)(ref this);

    /// <summary>Updates the abuse UI's name field to display the currently selected object's name when a new object is chosen.
    /// <code>Offset: 0x004BCF50
    /// bool __thiscall gmAbuseUI::HandleSelection(gmAbuseUI*)</code>
    /// </summary>
    /// <returns>True if the name was successfully set; always returns true in this implementation.</returns>
    public byte HandleSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, byte>)0x004BCF50)(ref this);

    /// <summary>Submits an abuse report with the specified character name and complaint text, displaying a notice if either field is empty.
    /// <code>Offset: 0x004BD010
    /// bool __thiscall gmAbuseUI::ReportAbuse(gmAbuseUI*)</code>
    /// </summary>
    /// <returns>True when the report is successfully queued; false if required information is missing.</returns>
    public byte ReportAbuse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, byte>)0x004BD010)(ref this);

    /// <summary>Processes UI element messages for the abuse reporting interface, handling reset, selection, report actions, and text entry events before delegating unhandled messages to the base class.
    /// <code>Offset: 0x004BD250
    /// UIElementMessageListenResult __thiscall gmAbuseUI::ListenToElementMessage(gmAbuseUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing the element ID and message type.</param>
    /// <returns>Result indicating whether the message was handled by this function or forwarded to the base class.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmAbuseUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004BD250)(ref this, i_rMsg);
}

