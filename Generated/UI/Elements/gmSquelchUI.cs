namespace ACBindings.Internal;


/// <summary>Manages the UI panel that displays and edits the player’s squelch list, handling account and character blocking actions and coordinating with the communication system.</summary>
public unsafe struct gmSquelchUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmSquelchUI_vtbl
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
    public ACBindings.Internal.UIElement_Button* m_pSquelchCharacterButton;
    public ACBindings.Internal.UIElement_Button* m_pSquelchAccountButton;
    public ACBindings.Internal.UIElement_Button* m_pRemoveButton;
    public ACBindings.Internal.UIElement_ListBox* m_pSquelchListBox;
    public ACBindings.Internal.UIElement_Text* m_pSquelchNameEditBox;
    public ACBindings.Internal.FriendDataList m_squelchList;

    // Generated Constructor
    public gmSquelchUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes UI elements of the squelch interface by locating child components via their IDs, storing references to buttons, list boxes, and edit boxes, and registers a global notice handler for handling squelch-related events.
    /// <code>Offset: 0x0048C440
    /// void __thiscall gmSquelchUI::PostInit(gmSquelchUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, void>)0x0048C440)(ref this);

    /// <summary>Updates the enabled state of the remove, character, and account buttons according to the currently selected item in the squelch list and the total number of entries.
    /// <code>Offset: 0x0048C520
    /// void __thiscall gmSquelchUI::UpdateButtons(gmSquelchUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, void>)0x0048C520)(ref this);

    /// <summary>Finds the listbox entry that should precede a new item to keep the entries sorted alphabetically by text.
    /// <code>Offset: 0x0048C5E0
    /// UIElement* __thiscall gmSquelchUI::FindSortedInsertPosition(_DWORD*,const wchar_t**,int)</code>
    /// </summary>
    /// <param name="a2">The wide‑string name of the item to insert; its reference count is decremented after use.</param>
    /// <param name="a3">Unused parameter retained for API compatibility.</param>
    /// <returns>Pointer to the UIElement representing the list entry that should come before the new item, or null if the new item belongs at the end of the list.</returns>
    public ACBindings.Internal.UIElement* FindSortedInsertPosition(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, System.IntPtr, int, ACBindings.Internal.UIElement*>)0x0048C5E0)(ref this, a2, a3);

    /// <summary>Adds a new squelch entry to the UI list, inserting it in sorted order, setting its display text and instance ID, and configuring action callbacks based on the supplied flag.
    /// <code>Offset: 0x0048C6C0
    /// char __thiscall gmSquelchUI::AddSquelchDisplay(int,const wchar_t**,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">The wide‑character string used as the display text for the new entry.</param>
    /// <param name="val">Identifier value assigned to the entry via the InstanceID attribute.</param>
    /// <param name="a4">Boolean flag determining which input action callback is applied to the entry.</param>
    /// <returns>1 if the entry was added successfully; 0 otherwise.</returns>
    public sbyte AddSquelchDisplay(System.IntPtr a2, uint val, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, System.IntPtr, uint, int, sbyte>)0x0048C6C0)(ref this, a2, val, a4);

    /// <summary>Refreshes the squelch list display by clearing existing items, iterating over all current squelches via the communication system, adding each entry to the UI listbox, and updating button states.
    /// <code>Offset: 0x0048C9F0
    /// bool __thiscall gmSquelchUI::RefreshSquelchDisplay(gmSquelchUI*)</code>
    /// </summary>
    /// <returns>True after successfully refreshing the display.</returns>
    public byte RefreshSquelchDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, byte>)0x0048C9F0)(ref this);

    /// <summary>Handles UI element messages for the squelch interface, updating the squelch list, sending modify events to the server, and refreshing button states based on user interaction.
    /// <code>Offset: 0x0048CB40
    /// UIElementMessageListenResult __thiscall gmSquelchUI::ListenToElementMessage(gmSquelchUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI message being processed, including the target element ID and message type.</param>
    /// <returns>Result of processing the message, typically indicating whether the event was consumed or should be passed to base handlers.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0048CB40)(ref this, i_rMsg);

    /// <summary>Updates the squelch UI panel to reflect changes in the current squelched list.
    /// <code>Offset: 0x0048CE40
    /// void __thiscall gmSquelchUI::RecvNotice_UpdateSquelchPanel(gmSquelchUI*)</code>
    /// </summary>
    public void RecvNotice_UpdateSquelchPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, void>)0x0048CE40)(ref this);

    /// <summary>Initializes the squelch user interface component, setting up base UI fields, notice handling, and preparing internal controls and data structures.
    /// <code>Offset: 0x0048D1B0
    /// void __thiscall gmSquelchUI::gmSquelchUI(gmSquelchUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Descriptor containing display dimensions and element mappings for constructing the UI layout.</param>
    /// <param name="full_desc">Full descriptor of the UI element hierarchy used to initialize this instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0048D1B0)(ref this, layout, full_desc);

    /// <summary>Returns a UIElement pointer representing the requested base type of this gmSquelchUI instance. If the type identifier matches the UIElement base or the gmSquelchUI type itself, a valid pointer is returned; otherwise nullptr is returned.
    /// <code>Offset: 0x0048D240
    /// UIElement* __thiscall gmSquelchUI::DynamicCast(gmSquelchUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier specifying which UIElement-derived type to cast to.</param>
    /// <returns>Pointer to the appropriate UIElement subobject if the requested type is supported; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, uint, ACBindings.Internal.UIElement*>)0x0048D240)(ref this, i_eType);

    /// <summary>Retrieves the unique identifier for the Squelch UI component type.
    /// <code>Offset: 0x0048D260
    /// unsigned int __thiscall gmSquelchUI::GetUIElementType(gmSquelchUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer that identifies the UI element type within the UI framework.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, uint>)0x0048D260)(ref this);

    /// <summary>Destroys the gmSquelchUI instance, unregisters notice handlers, clears the squelch list, and releases UI resources.
    /// <code>Offset: 0x0048D270
    /// void __thiscall gmSquelchUI::~gmSquelchUI(gmSquelchUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSquelchUI, void>)0x0048D270)(ref this);

    /// <summary>Registers the Squelch UI element class with the UI system, enabling creation of Squelch UI instances.
    /// <code>Offset: 0x0048D320
    /// void __cdecl gmSquelchUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048D320)();
}

