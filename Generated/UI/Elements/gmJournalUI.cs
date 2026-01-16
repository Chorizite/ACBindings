namespace ACBindings.Internal;


/// <summary>Manages the in‑game journal UI, handling page navigation, text entry, timers, location tracking, and persistence.</summary>
public unsafe struct gmJournalUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmJournalUI_vtbl
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
    public ACBindings.Internal.UIElement_Button* m_pStartTimerButton;
    public ACBindings.Internal.UIElement_Text* m_pLabelEditBox;
    public ACBindings.Internal.UIElement_Text* m_pTitleEditBox;
    public ACBindings.Internal.UIElement_Text* m_pNotesEditBox;
    public ACBindings.Internal.UIElement_Text* m_pDaysEditBox;
    public ACBindings.Internal.UIElement_Text* m_pHoursEditBox;
    public ACBindings.Internal.UIElement_Text* m_pMinutesEditBox;
    public ACBindings.Internal.UIElement_Text* m_pLocationStaticText;
    public ACBindings.Internal.UIElement_Text* m_pTimerStaticText;
    public ACBindings.Internal.UIElement_Text* m_pDaysStaticText;
    public ACBindings.Internal.UIElement_Text* m_pHoursStaticText;
    public ACBindings.Internal.UIElement_Text* m_pMinutesStaticText;
    public ACBindings.Internal.UIElement_Text* m_pPageNumberStaticText;
    public byte m_Loaded;
    public uint m_CurrentPage;
    public ACBindings.Internal.PageInfo m_Info;
    public double m_timeNextUpdate;

    // Generated Constructor
    public gmJournalUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Resets the journal timer state and clears all displayed timer values.
    /// <code>Offset: 0x00494DC0
    /// void __thiscall gmJournalUI::ClearTimerText(gmJournalUI*)</code>
    /// </summary>
    public void ClearTimerText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00494DC0)(ref this);

    /// <summary>Constructs a journal UI element using the supplied layout and element description, initializing all internal UI components and state to default values.
    /// <code>Offset: 0x00495050
    /// void __thiscall gmJournalUI::gmJournalUI(gmJournalUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Description of the layout dimensions and elements for the UI.</param>
    /// <param name="full_desc">Full descriptor of the root UI element defining its structure and properties.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00495050)(ref this, layout, full_desc);

    /// <summary>Attempts a dynamic cast of the gmJournalUI instance to the specified UI element type and returns a pointer to the corresponding UIElement base if the requested type matches, or nullptr otherwise.
    /// <code>Offset: 0x00495100
    /// UIElement* __thiscall gmJournalUI::DynamicCast(gmJournalUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the UI element type to cast to (e.g., 268435528 for UIElement).</param>
    /// <returns>Pointer to the UIElement base when the cast succeeds; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, ACBindings.Internal.UIElement*>)0x00495100)(ref this, i_eType);

    /// <summary>Provides the unique identifier for the journal UI element type.
    /// <code>Offset: 0x00495120
    /// unsigned int __thiscall gmJournalUI::GetUIElementType(gmJournalUI*)</code>
    /// </summary>
    /// <returns>The numeric ID used to identify this UI element type (268435528).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint>)0x00495120)(ref this);

    /// <summary>Destroys a gmJournalUI instance, unregistering it from global event handlers, destroying its page information structure, and invoking the destructors of its base classes.
    /// <code>Offset: 0x00495130
    /// void __thiscall gmJournalUI::~gmJournalUI(gmJournalUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495130)(ref this);

    /// <summary>Registers the journal UI element class with the UI framework using its layout and element descriptors.
    /// <code>Offset: 0x00495410
    /// void __cdecl gmJournalUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00495410)();

    /// <summary>Resets the journal timer by reading days, hours and minutes from the corresponding UI fields, updating internal state, computing the total duration, and starting the countdown based on current time.
    /// <code>Offset: 0x00495430
    /// int __thiscall gmJournalUI::ResetTimer(gmJournalUI*)</code>
    /// </summary>
    /// <returns>Zero indicates successful reset.</returns>
    public int ResetTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, int>)0x00495430)(ref this);

    /// <summary>Copies the current journal entry’s label, title, notes and time fields into the page’s data structure and updates the global journal pages list.
    /// <code>Offset: 0x00495640
    /// void __thiscall gmJournalUI::SaveThisPage(gmJournalUI*)</code>
    /// </summary>
    public void SaveThisPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495640)(ref this);

    /// <summary>Prepares the journal UI for editing a timer by resetting its state, clearing input fields, and updating labels such as setting the start button text to 'Start'.
    /// <code>Offset: 0x00495A50
    /// void __thiscall gmJournalUI::ShowEditableTimer(gmJournalUI*)</code>
    /// </summary>
    public void ShowEditableTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495A50)(ref this);

    /// <summary>Refreshes the journal's running timer display to match the current elapsed time.
    /// <code>Offset: 0x00495B70
    /// void __thiscall gmJournalUI::UpdateRunningTimer(gmJournalUI*)</code>
    /// </summary>
    public void UpdateRunningTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495B70)(ref this);

    /// <summary>Updates the journal UI’s location label using stored coordinates. If a valid location exists, it formats the latitude and longitude with N/S and E/W directional markers; otherwise, it displays “None”.
    /// <code>Offset: 0x00495BD0
    /// void __thiscall gmJournalUI::UpdateLocation(gmJournalUI*)</code>
    /// </summary>
    public void UpdateLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495BD0)(ref this);

    /// <summary>
    /// Updates the page number display in the journal UI, formatting the current or default page number and setting it to the static text element.
    /// 
    /// <code>Offset: 0x00495D50
    /// void __thiscall gmJournalUI::UpdatePageNumber(gmJournalUI*)</code>
    /// </summary>
    public void UpdatePageNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495D50)(ref this);

    /// <summary>Initializes journal UI components by locating child elements, assigning them to member pointers, configuring the editable timer display, registering for relevant global messages, and storing a global reference to the panel.
    /// <code>Offset: 0x00496250
    /// void __thiscall gmJournalUI::PostInit(gmJournalUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496250)(ref this);

    /// <summary>Starts the journal timer, updates UI elements to reflect a running state, disables editable fields, and sets the start button text to “Reset”.
    /// <code>Offset: 0x00496470
    /// void __thiscall gmJournalUI::ShowRunningTimer(gmJournalUI*)</code>
    /// </summary>
    public void ShowRunningTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496470)(ref this);

    /// <summary>Resets stored coordinates to zero, queries the current player position via CPlayerSystem, updates m_Info with these values and the result flag, then refreshes the journal UI to reflect the new location.
    /// <code>Offset: 0x00496540
    /// void __thiscall gmJournalUI::ResetLocation(gmJournalUI*)</code>
    /// </summary>
    public void ResetLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496540)(ref this);

    /// <summary>Clears the data of the currently displayed journal page and refreshes all related UI elements, including title, notes, time fields, location, and page number. Updates the running timer display based on whether a timer is active.
    /// <code>Offset: 0x004965C0
    /// void __thiscall gmJournalUI::ClearCurrentPage(gmJournalUI*)</code>
    /// </summary>
    public void ClearCurrentPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x004965C0)(ref this);

    /// <summary>Navigates the journal UI to the specified page index, updating labels, notes, time fields, and visual indicators accordingly.
    /// <code>Offset: 0x00496710
    /// void __thiscall gmJournalUI::GotoPage(gmJournalUI*,const unsigned int)</code>
    /// </summary>
    /// <param name="page_index">The 1‑based index of the page to display; updates are performed only if the journal has finished loading.</param>
    public void GotoPage(uint page_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, void>)0x00496710)(ref this, page_index);

    /// <summary>Refreshes journal UI elements such as the running timer, location text, and current page number when the interface is loaded. Updates the timer display mode based on whether a timer is active.
    /// <code>Offset: 0x00496870
    /// void __thiscall gmJournalUI::Update(gmJournalUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496870)(ref this);

    /// <summary>Removes the journal entry at the specified 1‑based index, renumbers subsequent pages, and updates the UI—navigating to the first page when any remain or clearing the current view when all are deleted.
    /// <code>Offset: 0x004968B0
    /// void __thiscall gmJournalUI::DeletePage(gmJournalUI*,const unsigned int)</code>
    /// </summary>
    /// <param name="page_index">The 1‑based position of the page to delete from the journal.</param>
    public void DeletePage(uint page_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, void>)0x004968B0)(ref this, page_index);

    /// <summary>Creates a journal file name by combining the base directory, client ID, object name, and supplied prefix, then writes it into an output string buffer.
    /// <code>Offset: 0x00496940
    /// LONG __stdcall gmJournalUI::CreateJournalPath(const char*,volatile LONG*)</code>
    /// </summary>
    /// <param name="a1">Prefix or base part of the filename to be appended between the directory path and identifiers.</param>
    /// <param name="ArgList">Pointer to a string buffer that receives the constructed file path; the function updates this buffer’s reference count.</param>
    /// <returns>Reference count for the input string after it has been decremented; zero when no references remain.</returns>
    public static int CreateJournalPath(sbyte* a1, int* ArgList) => ((delegate* unmanaged[Stdcall]<sbyte*, int*, int>)0x00496940)(a1, ArgList);

    /// <summary>Reports a text message to the journal scroll UI element, converting from ANSI to wide characters and handling memory cleanup.
    /// <code>Offset: 0x00496AE0
    /// LONG __stdcall gmJournalUI::ReportInScroll(const char*,unsigned int)</code>
    /// </summary>
    /// <param name="a1">The ANSI string containing the message to display.</param>
    /// <param name="a2">Length or count of characters to add to the scroll.</param>
    /// <returns>Reference count after decrementing; zero indicates the original string has been released.</returns>
    public static int ReportInScroll(sbyte* a1, uint a2) => ((delegate* unmanaged[Stdcall]<sbyte*, uint, int>)0x00496AE0)(a1, a2);

    /// <summary>Creates a new journal page when the UI is loaded, assigning it the next sequential page number and inserting it into the global pages list.
    /// <code>Offset: 0x00496B60
    /// void __thiscall gmJournalUI::NewPage(gmJournalUI*)</code>
    /// </summary>
    public void NewPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496B60)(ref this);

    /// <summary>Handles messages for the journal UI, executing actions such as navigating pages, saving content, and controlling timers in response to button clicks or other UI events. If the UI has not finished loading, forwards the message to the base UI element handler.
    /// <code>Offset: 0x00496BB0
    /// UIElementMessageListenResult __thiscall gmJournalUI::ListenToElementMessage(gmJournalUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element event being processed.</param>
    /// <returns>Result of handling the message as returned by the base UI element listener.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00496BB0)(ref this, i_rMsg);

    /// <summary>Loads journal pages from a specified file, parsing custom markup tags to populate page data and update UI elements.
    /// <code>Offset: 0x00496DA0
    /// int __thiscall gmJournalUI::LoadPages(gmJournalUI*,const char*)</code>
    /// </summary>
    /// <param name="this">The gmJournalUI instance whose pages are being loaded.</param>
    /// <param name="a2">File system path to the journal data file.</param>
    /// <returns>The updated reference count of the internal string buffer after it is decremented; a value of zero indicates that the buffer was released.</returns>
    public int LoadPages(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, sbyte*, int>)0x00496DA0)(ref this, a2);

    /// <summary>Saves all journal pages to a file specified by the given path, writing each page in an XML‑style format.
    /// <code>Offset: 0x00497550
    /// int __thiscall gmJournalUI::SavePages(_BYTE*,const char*)</code>
    /// </summary>
    /// <param name="this">The gmJournalUI instance whose pages are being serialized.</param>
    /// <param name="a2">Path or base filename for the output file.</param>
    /// <returns>Integer value representing the object's reference count after the operation; callers should not use it as a success indicator.</returns>
    public int SavePages(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, sbyte*, int>)0x00497550)(ref this, a2);

    /// <summary>Responds to global messages for the journal UI. When message 3 arrives, updates the running timer if a delay threshold has elapsed; when message 11 arrives and the UI is not yet loaded, loads journal pages, initializes the first page or creates a new one.
    /// <code>Offset: 0x00497AC0
    /// void __thiscall gmJournalUI::ListenToGlobalMessage(gmJournalUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the received global message.</param>
    /// <param name="i_data_int">Optional integer data accompanying the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, int, void>)0x00497AC0)(ref this, i_messageID, i_data_int);

    /// <summary>Updates visibility of the journal UI and, if already loaded, sorts pages by number when shown, saves the current page, then persists all pages to a file named “Journal”.
    /// <code>Offset: 0x00497BD0
    /// void __thiscall gmJournalUI::OnVisibilityChanged(gmJournalUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True to display the journal; false to hide it.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, byte, void>)0x00497BD0)(ref this, i_bVisible);
}

