namespace ACBindings.Internal;


/// <summary>Provides a UI component that displays and manages a journal page list, handling sorting, searching, and user actions such as delete or navigation.</summary>
/// <remarks>Integrates with global message notifications to keep the list current and interacts with gmJournalUI for page operations.</remarks>
public unsafe struct gmPageListUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmPageListUI_vtbl
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
    public long m_PageListPages;
    public ACBindings.Internal.UIElement_ListBox* m_pPageListBox;
    public ACBindings.Internal.UIElement_Text* m_pSearchEditBox;
    public ACBindings.Internal.JournalSortCriteria m_SortCriteria;
    public byte m_ReverseSort;
    public int m_LastClickIndex;
    public double m_LastClickTime;
    public double m_timeNextUpdate;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Detects a double‑click on a page list item by comparing the current click index and time to the last recorded values.
    /// <code>Offset: 0x00493420
    /// bool __thiscall gmPageListUI::CheckForDoubleClick(gmPageListUI*,const int)</code>
    /// </summary>
    /// <param name="selected_index">Index of the item that was just clicked.</param>
    /// <returns>True if the same item was clicked again within one second; otherwise, false.</returns>
    public byte CheckForDoubleClick(int selected_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, int, byte>)0x00493420)(ref this, selected_index);

    /// <summary>Initializes the page list UI after construction by locating the listbox and search edit box child controls and registering for global message notifications.
    /// <code>Offset: 0x00493680
    /// void __thiscall gmPageListUI::PostInit(gmPageListUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, void>)0x00493680)(ref this);

    /// <summary>Updates all list box entries for the page list to match current page data, including timer displays.
    /// <code>Offset: 0x004936F0
    /// void __thiscall gmPageListUI::RefreshPageListbox(gmPageListUI*)</code>
    /// </summary>
    public void RefreshPageListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, void>)0x004936F0)(ref this);

    /// <summary>Adds a page entry to the page list UI using the provided page information.
    /// <code>Offset: 0x00493960
    /// void __thiscall gmPageListUI::AddPageToListbox(gmPageListUI*,const PageInfo*)</code>
    /// </summary>
    /// <param name="info">Page data containing number, title, timer status, and notes to populate the list item.</param>
    public void AddPageToListbox(ACBindings.Internal.PageInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, ACBindings.Internal.PageInfo*, void>)0x00493960)(ref this, info);

    /// <summary>Refreshes the page list box when a global message with ID 3 is received, provided the UI element is active and the cooldown period has elapsed.
    /// <code>Offset: 0x00493D80
    /// void __thiscall gmPageListUI::ListenToGlobalMessage(gmPageListUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message to process.</param>
    /// <param name="i_data_int">Integer data accompanying the message (not used in this routine).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, uint, int, void>)0x00493D80)(ref this, i_messageID, i_data_int);

    /// <summary>Rebuilds the page listbox by clearing existing items and repopulating it with entries from the current page list.
    /// <code>Offset: 0x00493DD0
    /// void __thiscall gmPageListUI::RebuildPageListbox(gmPageListUI*)</code>
    /// </summary>
    public void RebuildPageListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, void>)0x00493DD0)(ref this);

    /// <summary>Determines whether any of a page’s text fields contain the supplied search string, using case‑insensitive matching.
    /// <code>Offset: 0x00493E40
    /// char __stdcall gmPageListUI::PageContainsString(int,wchar_t*)</code>
    /// </summary>
    /// <param name="a1">Pointer to the structure holding the page’s primary, secondary and tertiary strings.</param>
    /// <param name="a2">Null‑terminated wide string to search for within those text fields.</param>
    /// <returns>Non‑zero if the search string is found in any of the page’s strings; zero otherwise.</returns>
    public static sbyte PageContainsString(int a1, System.IntPtr a2) => ((delegate* unmanaged[Stdcall]<int, System.IntPtr, sbyte>)0x00493E40)(a1, a2);

    /// <summary>Attempts a dynamic cast of this gmPageListUI instance to the UIElement type indicated by i_eType, returning a pointer when compatible or null otherwise.
    /// <code>Offset: 0x00494350
    /// UIElement* __thiscall gmPageListUI::DynamicCast(gmPageListUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The element type identifier for which the cast should be attempted.</param>
    /// <returns>A pointer to the requested UIElement if the object matches that type; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, uint, ACBindings.Internal.UIElement*>)0x00494350)(ref this, i_eType);

    /// <summary>Returns the unique UI element type identifier for gmPageListUI instances.
    /// <code>Offset: 0x00494370
    /// unsigned int __thiscall gmPageListUI::GetUIElementType(gmPageListUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer (268435529) identifying this UI element class within the framework.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, uint>)0x00494370)(ref this);

    /// <summary>Destroys the gmPageListUI object by deregistering from global event handlers, freeing all stored page information, deallocating its vector storage, and invoking the destructors of base classes.
    /// <code>Offset: 0x00494380
    /// void __thiscall gmPageListUI::~gmPageListUI(gmPageListUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, void>)0x00494380)(ref this);

    /// <summary>Creates a UI element using the specified layout and element descriptors.
    /// <code>Offset: 0x00494410
    /// UIElement* __cdecl gmPageListUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description providing dimensions, elements, and header strings.</param>
    /// <param name="full_desc">Element descriptor defining properties such as ID, type, position, and child hierarchy.</param>
    /// <returns>A pointer to the newly constructed UIElement on success; otherwise null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x00494410)(layout, full_desc);

    /// <summary>Registers the gmPageListUI element class with the UI system, enabling instantiation of this UI component via the engine’s factory mechanism.
    /// <code>Offset: 0x004945A0
    /// void __cdecl gmPageListUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004945A0)();

    /// <summary>Rebuilds the page list UI component, clearing any existing entries and repopulating the internal vector with journal pages. When a search filter is active, only pages containing the current query are included.
    /// <code>Offset: 0x00494790
    /// void __thiscall gmPageListUI::RebuildPageList(gmPageListUI*,const bool)</code>
    /// </summary>
    /// <param name="i_search">If true, applies the current text from the search edit box to filter pages; if false, rebuilds the list without filtering.</param>
    public void RebuildPageList(byte i_search) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, byte, void>)0x00494790)(ref this, i_search);

    /// <summary>Reorders the internal page list according to the chosen sort criteria and reverse flag, then rebuilds the UI list box to show the updated ordering.
    /// <code>Offset: 0x00494940
    /// void __thiscall gmPageListUI::SortPageList(gmPageListUI*)</code>
    /// </summary>
    public void SortPageList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, void>)0x00494940)(ref this);

    /// <summary>Processes user interactions with the journal page list, updating sorting, rebuilding the list, deleting pages, or navigating to a selected page.
    /// <code>Offset: 0x00494AA0
    /// UIElementMessageListenResult __thiscall gmPageListUI::ListenToElementMessage(gmPageListUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The page list UI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the UI element event being handled.</param>
    /// <returns>Result indicating whether the message was consumed and any further processing required.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00494AA0)(ref this, i_rMsg);

    /// <summary>Handles visibility changes for the page list UI, rebuilding and sorting pages when shown.
    /// <code>Offset: 0x00494C60
    /// void __thiscall gmPageListUI::OnVisibilityChanged(gmPageListUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">Specifies whether the UI element is now visible; true triggers rebuild and sort, false performs no action beyond base handling.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmPageListUI, byte, void>)0x00494C60)(ref this, i_bVisible);
}

