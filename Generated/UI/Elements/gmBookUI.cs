namespace ACBindings.Internal;


/// <summary>
/// Encapsulates the user interface logic for book objects, managing page navigation, text editing, and presentation of title, inscription, and scribe information.
/// </summary>
public unsafe struct gmBookUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler

    // Child Types
    public unsafe struct gmBookUI_vtbl
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
    public ACBindings.Internal.UIElement* m_nextButton;
    public ACBindings.Internal.UIElement* m_prevButton;
    public ACBindings.Internal.UIElement_Text* m_titleText;
    public ACBindings.Internal.UIElement_Text* m_pageText;
    public ACBindings.Internal.UIElement_Menu* m_pageMenu;
    public ACBindings.Internal.UIElement_Text* m_menuSelectionPageNumText;
    public uint bookID;
    public int maxNumPages;
    public ACBindings.Internal.PageDataList* pageDataList;
    public int curPage;
    public int requestPending;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte inscription;
    public uint scribeID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte scribeName;

    // Generated Constructor
    public gmBookUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new instance of the book UI component, setting up its visual layout and internal state to defaults.
    /// <code>Offset: 0x004BB710
    /// void __thiscall gmBookUI::gmBookUI(gmBookUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing display dimensions and element mappings for the UI.</param>
    /// <param name="full_desc">Element description that defines the root UI element used by the base constructor.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004BB710)(ref this, layout, full_desc);

    /// <summary>Returns a pointer to the UIElement subobject of this gmBookUI instance when requested by type identifier; otherwise returns null.
    /// <code>Offset: 0x004BB7E0
    /// UIElement* __thiscall gmBookUI::DynamicCast(gmBookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Numeric identifier specifying which UIElement subtype is desired. Values 268435481 and 3 are recognized, mapping to the base UIElement interface and the gmBookUI instance itself respectively.</param>
    /// <returns>A UIElement pointer when i_eType matches a supported value; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, ACBindings.Internal.UIElement*>)0x004BB7E0)(ref this, i_eType);

    /// <summary>Identifies the UI element type for this book interface component.
    /// <code>Offset: 0x004BB800
    /// unsigned int __thiscall gmBookUI::GetUIElementType(gmBookUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant representing the UI element type (e.g., 268435481).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint>)0x004BB800)(ref this);

    /// <summary>
    /// Destructs a gmBookUI object, cleaning up its UI elements, unregistering it from global event handlers, releasing string buffers for the inscription and scribe name, and invoking base class destructors.
    /// 
    /// <code>Offset: 0x004BB810
    /// void __thiscall gmBookUI::~gmBookUI(gmBookUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BB810)(ref this);

    /// <summary>Creates a new gmBookUI instance configured by the supplied layout and element descriptor.
    /// <code>Offset: 0x004BB8B0
    /// UIElement* __cdecl gmBookUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout information defining display size and elements for the book UI.</param>
    /// <param name="full_desc">Full element descriptor containing properties such as ID, type, and geometry.</param>
    /// <returns>A pointer to the initialized UIElement representing the book UI, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004BB8B0)(layout, full_desc);

    /// <summary>Sets the editable state of a UIElement_Text instance for this book UI.
    /// <code>Offset: 0x004BB8E0
    /// void __thiscall gmBookUI::SetEditable(gmBookUI*,UIElement_Text*,int)</code>
    /// </summary>
    /// <param name="text">Text control whose editability is being set.</param>
    /// <param name="editable">Non‑zero value enables editing; zero disables it.</param>
    public void SetEditable(ACBindings.Internal.UIElement_Text* text, int editable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.UIElement_Text*, int, void>)0x004BB8E0)(ref this, text, editable);

    /// <summary>Initializes the book UI by locating its child components—including title and page text elements, navigation buttons, and the page selection menu—and registering global event handlers for book‑related notices.
    /// <code>Offset: 0x004BB9F0
    /// void __thiscall gmBookUI::PostInit(gmBookUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BB9F0)(ref this);

    /// <summary>Registers the gmBookUI element type with the UI system, associating it with its factory method.
    /// <code>Offset: 0x004BBB00
    /// void __cdecl gmBookUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BBB00)();

    /// <summary>Adds or updates a page entry in the book UI’s menu with the supplied text and configures the corresponding page number display.
    /// <code>Offset: 0x004BBB20
    /// void __thiscall gmBookUI::AddPageInfo(gmBookUI*,int,const StringInfo*)</code>
    /// </summary>
    /// <param name="pageNum">Zero‑based index of the page to add or update.</param>
    /// <param name="text">Text information for the new page item, used as the menu label.</param>
    public void AddPageInfo(int pageNum, ACBindings.Internal.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, ACBindings.Internal.StringInfo*, void>)0x004BBB20)(ref this, pageNum, text);

    /// <summary>Refreshes the book menu selection display to show the current page number and invokes an associated callback once the reference counter for the given index depletes.
    /// <code>Offset: 0x004BBBB0
    /// void __thiscall gmBookUI::UpdateMenuSelectionInfo(gmBookUI*,int)</code>
    /// </summary>
    /// <param name="this">The gmBookUI instance whose UI elements are updated.</param>
    /// <param name="index">Zero‑based page index used to update the displayed text and manage a reference count.</param>
    public void UpdateMenuSelectionInfo(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, void>)0x004BBBB0)(ref this, index);

    /// <summary>Refreshes the book UI's page selection menu by clearing existing entries and repopulating them from the current page data list, adding a blank entry if necessary and ensuring the total number of items matches the maximum allowed pages.
    /// <code>Offset: 0x004BBC10
    /// void __thiscall gmBookUI::UpdateMenu(gmBookUI*)</code>
    /// </summary>
    public void UpdateMenu() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BBC10)(ref this);

    /// <summary>Displays a page's contents in the book UI, updating the page text field and setting its editable state based on the author ID and ignore counters.
    /// <code>Offset: 0x004BBE70
    /// void __thiscall gmBookUI::DisplayPageData(gmBookUI*,PageData*)</code>
    /// </summary>
    /// <param name="pd">The PageData structure containing the text to display along with author metadata used to determine editability.</param>
    public void DisplayPageData(ACBindings.Internal.PageData* pd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.PageData*, void>)0x004BBE70)(ref this, pd);

    /// <summary>Determines whether the current page contains only whitespace or no text. Returns 1 when the page is blank; otherwise returns 0.
    /// <code>Offset: 0x004BBF10
    /// int __thiscall gmBookUI::PageTextBlank(gmBookUI*)</code>
    /// </summary>
    /// <returns>1 if the page text is empty or consists solely of spaces and newlines; 0 if it contains any other character.</returns>
    public int PageTextBlank() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int>)0x004BBF10)(ref this);

    /// <summary>Finalizes edits to the current book page. If the page is empty and authored by the player, deletes it from the book; otherwise saves any text changes back to the book data.
    /// <code>Offset: 0x004BBFD0
    /// int __thiscall gmBookUI::CloseCurPage(gmBookUI*)</code>
    /// </summary>
    /// <returns>Returns 1 if the page was deleted, or 0 if only the text was updated (or no action taken).</returns>
    public int CloseCurPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int>)0x004BBFD0)(ref this);

    /// <summary>Closes the currently opened book, releasing its page data and resetting all related identifiers, titles, and UI elements to an empty state.
    /// <code>Offset: 0x004BC190
    /// void __thiscall gmBookUI::CloseBook(gmBookUI*)</code>
    /// </summary>
    public void CloseBook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BC190)(ref this);

    /// <summary>Sets the displayed page of the book UI to the specified index when allowed, updating text content, editability, navigation buttons, and menu selection.
    /// <code>Offset: 0x004BC200
    /// void __thiscall gmBookUI::SetCurPage(gmBookUI*,int)</code>
    /// </summary>
    /// <param name="curPage">The zero‑based page number to display.</param>
    public void SetCurPage(int curPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, void>)0x004BC200)(ref this, curPage);

    /// <summary>Updates the internal page data for a requested book, replaces any existing entry for the specified page, inserts fresh data into the list, and refreshes the displayed page if it matches the current view.
    /// <code>Offset: 0x004BC4A0
    /// void __thiscall gmBookUI::RecvNotice_BookPageDataResponse(gmBookUI*,unsigned int,int,const PageData*)</code>
    /// </summary>
    /// <param name="i_bookID">Identifier of the book whose page data was received.</param>
    /// <param name="i_pageNum">Page number within the book that the data corresponds to.</param>
    /// <param name="i_pageData">Pointer to the PageData object containing author, text and related metadata for the page.</param>
    public void RecvNotice_BookPageDataResponse(uint i_bookID, int i_pageNum, ACBindings.Internal.PageData* i_pageData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, int, ACBindings.Internal.PageData*, void>)0x004BC4A0)(ref this, i_bookID, i_pageNum, i_pageData);

    /// <summary>Processes the result of an attempt to add a page to the current book UI. On failure or mismatched book ID it triggers a book data event; on success it updates the internal page list, displays new content if appropriate, and clears pending requests.
    /// <code>Offset: 0x004BC4B0
    /// void __thiscall gmBookUI::BookAddPageResponseEvent(gmBookUI*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="bookID">The identifier of the book that was targeted for the update.</param>
    /// <param name="pageNum">The zero‑based index of the page that was added or requested.</param>
    /// <param name="success">Nonzero if the add operation succeeded; otherwise zero.</param>
    public void BookAddPageResponseEvent(uint bookID, int pageNum, int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, int, int, void>)0x004BC4B0)(ref this, bookID, pageNum, success);

    /// <summary>Processes UI element messages for a book interface, updating navigation and editability based on button or menu actions and page data properties.
    /// <code>Offset: 0x004BC6A0
    /// UIElementMessageListenResult __thiscall gmBookUI::ListenToElementMessage(gmBookUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing the element ID, message type, and additional parameters used to determine the appropriate response.</param>
    /// <returns>Result of handling the message as returned by the base UIElement listener.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004BC6A0)(ref this, i_rMsg);

    /// <summary>Updates the book UI's visibility state and performs cleanup when it becomes invisible.
    /// <code>Offset: 0x004BC8F0
    /// void __thiscall gmBookUI::OnVisibilityChanged(gmBookUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the UI is being shown; false if it is being hidden.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, byte, void>)0x004BC8F0)(ref this, i_bVisible);

    /// <summary>Opens a new book in the UI, initializing its ID, page count, page data list, title inscription, and scribe information; then refreshes menus, sets the current page, updates text fields, and registers object range handling as needed.
    /// <code>Offset: 0x004BC930
    /// void __thiscall gmBookUI::OpenBook(gmBookUI*,int,int,_DWORD*,void**,unsigned int,void**)</code>
    /// </summary>
    /// <param name="a2">The identifier of the book to open.</param>
    /// <param name="a3">The maximum number of pages that the book contains.</param>
    /// <param name="a4">Pointer to a PageDataList structure holding page data for the book.</param>
    /// <param name="a5">Pointer to a buffer containing the book’s inscription or title string.</param>
    /// <param name="a6">Identifier of the scribe who authored the book.</param>
    /// <param name="a7">Pointer to a buffer containing the scribe’s name string.</param>
    public void OpenBook(int a2, int a3, int* a4, void** a5, uint a6, void** a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, int, int*, void**, uint, void**, void>)0x004BC930)(ref this, a2, a3, a4, a5, a6, a7);

    /// <summary>Handles the result of a request to add a page to a specified book, updating UI elements and state based on success or failure.
    /// <code>Offset: 0x004BCB20
    /// void __thiscall gmBookUI::RecvNotice_BookAddPageResponse(gmBookUI*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="i_bookID">Identifier of the target book.</param>
    /// <param name="i_pageNum">Page number affected by the add operation.</param>
    /// <param name="i_success">Non‑zero if the page was added successfully; zero indicates failure.</param>
    public void RecvNotice_BookAddPageResponse(uint i_bookID, int i_pageNum, int i_success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, int, int, void>)0x004BCB20)(ref this, i_bookID, i_pageNum, i_success);

    /// <summary>Handles a request to open a book by forwarding the supplied arguments to gmBookUI::OpenBook.
    /// <code>Offset: 0x004BCB30
    /// void __thiscall gmBookUI::RecvNotice_OpenBook(char*,int,int,_DWORD*,void**,unsigned int,void**)</code>
    /// </summary>
    /// <param name="a2">Forwarded argument passed to OpenBook.</param>
    /// <param name="a3">Forwarded argument passed to OpenBook.</param>
    /// <param name="a4">Forwarded array of DWORD values passed to OpenBook.</param>
    /// <param name="a5">Forwarded array of context pointers passed to OpenBook.</param>
    /// <param name="a6">Forwarded unsigned integer (size or count) passed to OpenBook.</param>
    /// <param name="a7">Forwarded context pointer passed to OpenBook.</param>
    public void RecvNotice_OpenBook(int a2, int a3, int* a4, void** a5, uint a6, void** a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, int, int*, void**, uint, void**, void>)0x004BCB30)(ref this, a2, a3, a4, a5, a6, a7);
}

