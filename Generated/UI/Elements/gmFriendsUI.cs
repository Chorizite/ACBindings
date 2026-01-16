namespace ACBindings.Internal;


/// <summary>
/// Handles the friends list user interface, managing friend addition, removal, chat initiation, and display refreshes while maintaining an internal list of friend data synchronized with server updates.
/// </summary>
public unsafe struct gmFriendsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmFriendsUI_vtbl
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
    public ACBindings.Internal.UIElement_Button* m_pAddButton;
    public ACBindings.Internal.UIElement_Button* m_pRemoveButton;
    public ACBindings.Internal.UIElement_Button* m_pTellButton;
    public ACBindings.Internal.UIElement_ListBox* m_pFriendsListBox;
    public ACBindings.Internal.UIElement_Text* m_pFriendNameEditBox;
    public ACBindings.Internal.FriendDataList m_friendsList;

    // Generated Constructor
    public gmFriendsUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Removes the display entry for the specified friend from the friends list UI. Returns true when the item is found and removed; otherwise returns false.
    /// <code>Offset: 0x0048D340
    /// bool __thiscall gmFriendsUI::RemoveFriendDisplay(gmFriendsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="friendID">The unique identifier of the friend whose UI entry should be removed.</param>
    /// <returns>True if the friend was successfully removed; otherwise, false.</returns>
    public byte RemoveFriendDisplay(uint friendID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, uint, byte>)0x0048D340)(ref this, friendID);

    /// <summary>Initializes the friends UI component by locating sub‑elements such as add, remove, and tell buttons, the friends list box, and the name edit field; it also configures the offline appearance checkbox and registers relevant event handlers.
    /// <code>Offset: 0x0048D3D0
    /// void __thiscall gmFriendsUI::PostInit(gmFriendsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048D3D0)(ref this);

    /// <summary>Attempts to add a friend by name, notifying the social system and handling reference counting of the input string. If the user already has 100 friends, shows an error notice instead.
    /// <code>Offset: 0x0048D520
    /// char __thiscall gmFriendsUI::Request_AddFriend(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated string containing the name of the friend to add.</param>
    /// <returns>Non‑zero on success; zero if the maximum number of friends is reached.</returns>
    public sbyte Request_AddFriend(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, int, sbyte>)0x0048D520)(ref this, a2);

    /// <summary>Updates the enabled/disabled state of the Add, Remove, and Tell buttons in the Friends UI according to the current selection in the friends list and the total number of friends.
    /// <code>Offset: 0x0048D580
    /// void __thiscall gmFriendsUI::UpdateButtons(gmFriendsUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048D580)(ref this);

    /// <summary>Searches the friends list for the insertion point that keeps items sorted alphabetically by name; optionally honors specific item states based on a flag.
    /// <code>Offset: 0x0048D650
    /// UIElement* __thiscall gmFriendsUI::FindSortedInsertPosition(_DWORD*,const wchar_t**,char)</code>
    /// </summary>
    /// <param name="a2">Pointer to the wide‑character string of the friend name to be inserted. The function may decrement its reference count when finished.</param>
    /// <param name="a3">Flag that influences handling of list items with particular state IDs (268435540 or 268435541). When non‑zero, returns an item whose state matches 268435541; when zero, skips items with state 268435540 during the search.</param>
    /// <returns>Pointer to the UIElement representing the listbox entry where the new item should be inserted, or null if no suitable position exists.</returns>
    public ACBindings.Internal.UIElement* FindSortedInsertPosition(System.IntPtr a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, System.IntPtr, sbyte, ACBindings.Internal.UIElement*>)0x0048D650)(ref this, a2, a3);

    /// <summary>Handles the “add friend” chat command by requesting the addition of the player identified by <paramref name="a2"/>.
    /// <code>Offset: 0x0048D750
    /// char __thiscall gmFriendsUI::RecvNotice_ChatCommand_AddFriend(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the target player to add as a friend.</param>
    /// <returns>A status byte: non‑zero if the request was successfully queued, zero otherwise.</returns>
    public sbyte RecvNotice_ChatCommand_AddFriend(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, int, sbyte>)0x0048D750)(ref this, a2);

    /// <summary>Adds a friend to the UI list, inserting it in sorted order and configuring its display text and instance ID. If the flag is set, attaches an online action callback; otherwise attaches an offline callback.
    /// <code>Offset: 0x0048D760
    /// char __thiscall gmFriendsUI::AddFriendDisplay(int,const wchar_t**,unsigned int,char)</code>
    /// </summary>
    /// <param name="friendName">The friend's name as a wide-character string.</param>
    /// <param name="instanceId">Unique identifier assigned to the new list item.</param>
    /// <param name="flag">Determines which input-action callback is applied (online vs. offline).</param>
    /// <returns>True if the friend was added successfully; otherwise false.</returns>
    public sbyte AddFriendDisplay(System.IntPtr a2, uint val, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, System.IntPtr, uint, sbyte, sbyte>)0x0048D760)(ref this, a2, val, a4);

    /// <summary>Handles messages sent to the friends user interface, routing them to specific actions such as adding or removing a friend, initiating a chat, and updating button states on hover. The handler performs validation checks (e.g., maximum friend list size) before delegating to base class processing.
    /// <code>Offset: 0x0048D800
    /// UIElementMessageListenResult __thiscall gmFriendsUI::ListenToElementMessage(gmFriendsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The instance of gmFriendsUI receiving the message.</param>
    /// <param name="i_rMsg">Information about the UI element event being processed, including the element ID and message type.</param>
    /// <returns>The result of handling the message, indicating whether it was consumed or further processing is required.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0048D800)(ref this, i_rMsg);

    /// <summary>Displays the user's friends list in the chat interface, optionally showing only those who are currently online.
    /// <code>Offset: 0x0048DA40
    /// void __thiscall gmFriendsUI::RecvNotice_ChatCommand_DisplayFriends(gmFriendsUI*,bool)</code>
    /// </summary>
    /// <param name="i_onlineOnly">When true, lists only friends that are online; when false, lists all friends.</param>
    public void RecvNotice_ChatCommand_DisplayFriends(byte i_onlineOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, byte, void>)0x0048DA40)(ref this, i_onlineOnly);

    /// <summary>Removes a friend identified by the first argument of a chat command from the current user's friends list, triggering a social event and notifying if the target is absent.
    /// <code>Offset: 0x0048DDA0
    /// void __thiscall gmFriendsUI::RecvNotice_ChatCommand_RemoveFriend(int,const char**)</code>
    /// </summary>
    /// <param name="a2">Array of C‑style strings containing the parsed chat command arguments; index 0 holds the friend's name to remove.</param>
    public void RecvNotice_ChatCommand_RemoveFriend(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, sbyte**, void>)0x0048DDA0)(ref this, a2);

    /// <summary>Refreshes the friends list display by clearing the current entries, repopulating it from the internal friend data, and updating button states accordingly.
    /// <code>Offset: 0x0048DF20
    /// bool __thiscall gmFriendsUI::RefreshFriendsDisplay(gmFriendsUI*)</code>
    /// </summary>
    /// <returns>True if the refresh completed successfully (always).</returns>
    public byte RefreshFriendsDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, byte>)0x0048DF20)(ref this);

    /// <summary>Updates a friend’s UI entry with the latest server information, preserving the current selection state.
    /// <code>Offset: 0x0048DFB0
    /// bool __thiscall gmFriendsUI::ServerSays_UpdateFriend(gmFriendsUI*,const FriendDataList*)</code>
    /// </summary>
    /// <param name="i_friendDataList">The list containing updated friend data to apply to the display.</param>
    /// <returns>True if the list contains at least one entry and the UI was refreshed; otherwise false.</returns>
    public byte ServerSays_UpdateFriend(ACBindings.Internal.FriendDataList* i_friendDataList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, byte>)0x0048DFB0)(ref this, i_friendDataList);

    /// <summary>Adds a friend reported by the server to the UI's internal friends list. The function copies the first entry from the supplied FriendDataList, inserts it into the local list, updates display elements and button states, then decrements the reference count of the input list. It returns true when a friend was added; otherwise false.
    /// <code>Offset: 0x0048E1D0
    /// bool __thiscall gmFriendsUI::ServerSays_AddFriend(gmFriendsUI*,const FriendDataList*)</code>
    /// </summary>
    /// <param name="i_friendDataList">A reference‑counted list containing one or more FriendData entries supplied by the server; only the first entry is used.</param>
    /// <returns>True if a friend was added to the UI; false when the input list is empty.</returns>
    public byte ServerSays_AddFriend(ACBindings.Internal.FriendDataList* i_friendDataList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, byte>)0x0048E1D0)(ref this, i_friendDataList);

    /// <summary>Removes a friend from the UI's friend list using information supplied by the server, updating display and button states accordingly.
    /// <code>Offset: 0x0048E290
    /// bool __thiscall gmFriendsUI::ServerSays_RemoveFriend(gmFriendsUI*,const FriendDataList*,bool)</code>
    /// </summary>
    /// <param name="i_friendDataList">Pointer to a FriendDataList containing the data of the friend to remove.</param>
    /// <param name="i_bSilent">Flag indicating whether the removal should be silent; currently not used.</param>
    /// <returns>True if the friend was removed from the list; otherwise false.</returns>
    public byte ServerSays_RemoveFriend(ACBindings.Internal.FriendDataList* i_friendDataList, byte i_bSilent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, byte, byte>)0x0048E290)(ref this, i_friendDataList, i_bSilent);

    /// <summary>Clears the user’s entire friend list, updates the friends list UI to show it as empty, and displays a “Your friends list has been cleared.” notification.
    /// <code>Offset: 0x0048E300
    /// void __thiscall gmFriendsUI::RecvNotice_ChatCommand_RemoveAllFriends(gmFriendsUI*)</code>
    /// </summary>
    public void RecvNotice_ChatCommand_RemoveAllFriends() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048E300)(ref this);

    /// <summary>Initializes the Friends UI component by configuring its base UI elements, registering notice handling callbacks, and resetting all child controls and friend lists to a clean state.
    /// <code>Offset: 0x0048E380
    /// void __thiscall gmFriendsUI::gmFriendsUI(gmFriendsUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes display dimensions and layout metadata for the UI.</param>
    /// <param name="full_desc">Full element description used to configure the root UI element's properties and children.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0048E380)(ref this, layout, full_desc);

    /// <summary>Performs a dynamic cast of the current <c>gmFriendsUI</c> instance to a <c>UIElement</c> based on the supplied type identifier, returning the appropriate base‑class pointer or <c>nullptr</c> if the cast is not valid.
    /// <code>Offset: 0x0048E410
    /// UIElement* __thiscall gmFriendsUI::DynamicCast(gmFriendsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric type identifier indicating which interface or class to cast to.</param>
    /// <returns>A pointer to the requested <c>UIElement</c> representation of this object, or <c>nullptr</c> when the cast cannot be performed.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, uint, ACBindings.Internal.UIElement*>)0x0048E410)(ref this, i_eType);

    /// <summary>Returns the unique identifier for the Friends UI component used by the UI system.
    /// <code>Offset: 0x0048E430
    /// unsigned int __thiscall gmFriendsUI::GetUIElementType(gmFriendsUI*)</code>
    /// </summary>
    /// <returns>The constant value 268435525 representing the gmFriendsUI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, uint>)0x0048E430)(ref this);

    /// <summary>Destroys a gmFriendsUI instance by unregistering global notice handlers, clearing the friend list, and invoking the destructors of its base UI components.
    /// <code>Offset: 0x0048E440
    /// void __thiscall gmFriendsUI::~gmFriendsUI(gmFriendsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048E440)(ref this);

    /// <summary>Registers the Friends UI element class with the UI framework to enable its creation through layout descriptors.
    /// <code>Offset: 0x0048E4F0
    /// void __cdecl gmFriendsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048E4F0)();

    /// <summary>Processes a server notice to update the friends list using the supplied data and type, modifying the internal list and refreshing UI elements accordingly.
    /// <code>Offset: 0x0048E550
    /// void __thiscall gmFriendsUI::RecvNotice_UpdateFriendsList(gmFriendsUI*,const FriendDataList*,int)</code>
    /// </summary>
    /// <param name="i_friendDataList">The friend data payload from the server.</param>
    /// <param name="i_updateType">Numeric code indicating the operation: 0=refresh full list, 1=add friend, 2=remove friend (soft), 3=remove friend (hard), 4=update existing friend.</param>
    public void RecvNotice_UpdateFriendsList(ACBindings.Internal.FriendDataList* i_friendDataList, int i_updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, int, void>)0x0048E550)(ref this, i_friendDataList, i_updateType);
}

