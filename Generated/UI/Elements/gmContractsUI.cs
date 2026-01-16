namespace ACBindings.Internal;


/// <summary>Manages the contracts user interface component, presenting a list of active contracts, handling sorting and selection interactions, and synchronizing updates from the server.</summary>
public unsafe struct gmContractsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmContractsUI_vtbl
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
    public long m_ContractList;
    public ACBindings.Internal.UIElement_ListBox* m_pContractsBox;
    public ACBindings.Internal.UIElement_Text* m_pProgressText;
    public ACBindings.Internal.UIElement_Text* m_pContactText;
    public ACBindings.Internal.UIElement_Text* m_pAreaText;
    public ACBindings.Internal.UIElement_Text* m_pContactLocText;
    public ACBindings.Internal.UIElement_Text* m_pTimedText;
    public ACBindings.Internal.UIElement_Text* m_pNotesText;
    public ACBindings.Internal.ContractSortCriteria m_SortCriteria;
    public byte m_ReverseSort;
    public int m_LastClickIndex;
    public double m_LastClickTime;
    public double m_timeNextUpdate;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Detects whether the selected contract was clicked twice within one second.
    /// <code>Offset: 0x00497CF0
    /// bool __thiscall gmContractsUI::CheckForDoubleClick(gmContractsUI*,const int)</code>
    /// </summary>
    /// <param name="selected_index">Index of the contract that was just selected.</param>
    /// <returns>True if the selection is a double‑click; otherwise false.</returns>
    public byte CheckForDoubleClick(int selected_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, int, byte>)0x00497CF0)(ref this, selected_index);

    /// <summary>Initializes the contracts UI component by locating child elements, assigning them to internal members, registering notice handlers for contract-related events, and subscribing to global messages.
    /// <code>Offset: 0x00498120
    /// void __thiscall gmContractsUI::PostInit(gmContractsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00498120)(ref this);

    /// <summary>Produces a localized progress description for a contract and writes it into the provided wide‑character buffer.
    /// <code>Offset: 0x004990C0
    /// void __stdcall gmContractsUI::FillProgressString(wchar_t*,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the contract data structure containing state information.</param>
    /// <param name="a2">Auxiliary data or format context used when constructing the status string.</param>
    /// <param name="a3">Wide-character buffer that receives the resulting progress text.</param>
    public static void FillProgressString(System.IntPtr a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<System.IntPtr, int, int, void>)0x004990C0)(a1, a2, a3);

    /// <summary>Performs a dynamic cast from a gmContractsUI instance to a UIElement based on an integer type identifier. If the identifier matches the UIElement base type or a specific code, returns the corresponding UIElement pointer; otherwise returns nullptr.
    /// <code>Offset: 0x004993E0
    /// UIElement* __thiscall gmContractsUI::DynamicCast(gmContractsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Integer representing the desired element type for casting.</param>
    /// <returns>Pointer to the requested UIElement representation, or null if the type is unsupported.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, uint, ACBindings.Internal.UIElement*>)0x004993E0)(ref this, i_eType);

    /// <summary>Provides the unique identifier for the contracts user‑interface component.
    /// <code>Offset: 0x00499400
    /// unsigned int __thiscall gmContractsUI::GetUIElementType(gmContractsUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer (typically 268435531) that represents the UI element type of this gmContractsUI instance within the UI framework.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, uint>)0x00499400)(ref this);

    /// <summary>Cleans up the contracts UI by unregistering global events and notices, destroying the contract list, and invoking base class destructors.
    /// <code>Offset: 0x00499410
    /// void __thiscall gmContractsUI::~gmContractsUI(gmContractsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00499410)(ref this);

    /// <summary>Updates UI elements to display details of the currently selected contract, including notes, contact information, location, progress, area, and timing status.
    /// <code>Offset: 0x004994E0
    /// void __thiscall gmContractsUI::UpdateButtons(gmContractsUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x004994E0)(ref this);

    /// <summary>Adds a contract to the contracts list box, creating an entry using a predefined template and populating its fields (name, status, progress) based on the supplied ContractInfo. If the contract exists in the global table, fills in additional progress information.
    /// <code>Offset: 0x004999D0
    /// void __thiscall gmContractsUI::AddContractToListbox(gmContractsUI*,const ContractInfo*)</code>
    /// </summary>
    /// <param name="info">The contract data to display; contains name, status, and tracking details.</param>
    public void AddContractToListbox(ACBindings.Internal.ContractInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.ContractInfo*, void>)0x004999D0)(ref this, info);

    /// <summary>Synchronizes the contract list box with the current contract data, refreshing each item’s title, progress text, and status indicators, then updates related UI buttons accordingly.
    /// <code>Offset: 0x00499B10
    /// void __thiscall gmContractsUI::RefreshContractListbox(gmContractsUI*)</code>
    /// </summary>
    public void RefreshContractListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00499B10)(ref this);

    /// <summary>Registers the gmContractsUI element class with the UI system, enabling creation of contract UI components within the interface.
    /// <code>Offset: 0x00499F60
    /// void __cdecl gmContractsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00499F60)();

    /// <summary>Rebuilds the contract list box by clearing existing entries, repopulating from the internal contract list, restoring any previously selected item when it still exists, and updating related UI controls.
    /// <code>Offset: 0x00499F80
    /// void __thiscall gmContractsUI::RebuildContractListbox(gmContractsUI*)</code>
    /// </summary>
    public void RebuildContractListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00499F80)(ref this);

    /// <summary>Handles a global message, refreshing the contract list box when the specified message ID is received and the update cooldown has expired.
    /// <code>Offset: 0x0049A140
    /// void __thiscall gmContractsUI::ListenToGlobalMessage(gmContractsUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the incoming global message.</param>
    /// <param name="i_data_int">Additional integer data associated with the message (unused in this handler).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, uint, int, void>)0x0049A140)(ref this, i_messageID, i_data_int);

    /// <summary>Rebuilds the UI’s contract list by clearing any current entries and repopulating it from the player system’s active contract tracker.
    /// <code>Offset: 0x0049A190
    /// void __thiscall gmContractsUI::RebuildContractList(gmContractsUI*)</code>
    /// </summary>
    public void RebuildContractList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x0049A190)(ref this);

    /// <summary>
    /// Sorts the internal contract list according to the current sort criteria and order, then rebuilds the UI listbox to display the updated ordering.
    /// 
    /// <code>Offset: 0x0049A540
    /// void __thiscall gmContractsUI::SortContractList(gmContractsUI*)</code>
    /// </summary>
    public void SortContractList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x0049A540)(ref this);

    /// <summary>Updates the contracts UI by rebuilding and sorting the displayed contract list when a new contract tracker table arrives.
    /// <code>Offset: 0x0049A650
    /// void __thiscall gmContractsUI::RecvNotice_UpdateContractTrackerTable(gmContractsUI*,const CContractTrackerTable*)</code>
    /// </summary>
    /// <param name="contractTrackerTable">The updated contract tracker data table received from the server.</param>
    public void RecvNotice_UpdateContractTrackerTable(ACBindings.Internal.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.CContractTrackerTable*, void>)0x0049A650)(ref this, contractTrackerTable);

    /// <summary>Rebuilds and sorts the contract list displayed in the UI, reflecting any changes to contracts. The passed notice parameters are ignored; the update is based on existing internal data.
    /// <code>Offset: 0x0049A670
    /// void __thiscall gmContractsUI::RecvNotice_UpdateContractTracker(gmContractsUI*,const CContractTracker*,int)</code>
    /// </summary>
    /// <param name="contractTracker">Ignored; function does not use this value.</param>
    /// <param name="bDeleteContract">Ignored; function does not use this flag.</param>
    public void RecvNotice_UpdateContractTracker(ACBindings.Internal.CContractTracker* contractTracker, int bDeleteContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.CContractTracker*, int, void>)0x0049A670)(ref this, contractTracker, bDeleteContract);

    /// <summary>Responds to UI events in the contracts window, handling sorting by name or status, processing abandon‑contract button clicks, and detecting double‑clicks on contract entries while keeping button states current.
    /// <code>Offset: 0x0049A690
    /// UIElementMessageListenResult __thiscall gmContractsUI::ListenToElementMessage(gmContractsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">UI event data containing element ID, message type, and related parameters.</param>
    /// <returns>A <c>UIElementMessageListenResult</c> indicating whether this control handled the message (otherwise forwarded to the base class).</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0049A690)(ref this, i_rMsg);

    /// <summary>Updates the contracts UI when its visibility changes, rebuilding and sorting the contract list if it becomes visible.
    /// <code>Offset: 0x0049A7B0
    /// void __thiscall gmContractsUI::OnVisibilityChanged(gmContractsUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">Indicates whether the UI has become visible (true) or hidden (false).</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, byte, void>)0x0049A7B0)(ref this, i_bVisible);
}

