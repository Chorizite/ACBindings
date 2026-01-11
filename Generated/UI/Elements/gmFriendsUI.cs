namespace ACBindings.Internal;

public unsafe struct gmFriendsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmFriendsUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0048D340
    /// bool __thiscall gmFriendsUI::RemoveFriendDisplay(gmFriendsUI*,unsigned int)</code>
    /// </summary>
    public byte RemoveFriendDisplay(uint friendID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, uint, byte>)0x0048D340)(ref this, friendID);

    /// <summary>
    /// <code>Offset: 0x0048D3D0
    /// void __thiscall gmFriendsUI::PostInit(gmFriendsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048D3D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048D520
    /// char __thiscall gmFriendsUI::Request_AddFriend(_DWORD*,int)</code>
    /// </summary>
    public sbyte Request_AddFriend(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, int, sbyte>)0x0048D520)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0048D580
    /// void __thiscall gmFriendsUI::UpdateButtons(gmFriendsUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048D580)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048D650
    /// UIElement* __thiscall gmFriendsUI::FindSortedInsertPosition(_DWORD*,const wchar_t**,char)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* FindSortedInsertPosition(System.IntPtr a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, System.IntPtr, sbyte, ACBindings.Internal.UIElement*>)0x0048D650)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0048D750
    /// char __thiscall gmFriendsUI::RecvNotice_ChatCommand_AddFriend(_DWORD*,int)</code>
    /// </summary>
    public sbyte RecvNotice_ChatCommand_AddFriend(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, int, sbyte>)0x0048D750)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0048D760
    /// char __thiscall gmFriendsUI::AddFriendDisplay(int,const wchar_t**,unsigned int,char)</code>
    /// </summary>
    public sbyte AddFriendDisplay(System.IntPtr a2, uint val, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, System.IntPtr, uint, sbyte, sbyte>)0x0048D760)(ref this, a2, val, a4);

    /// <summary>
    /// <code>Offset: 0x0048D800
    /// UIElementMessageListenResult __thiscall gmFriendsUI::ListenToElementMessage(gmFriendsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0048D800)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0048DA40
    /// void __thiscall gmFriendsUI::RecvNotice_ChatCommand_DisplayFriends(gmFriendsUI*,bool)</code>
    /// </summary>
    public void RecvNotice_ChatCommand_DisplayFriends(byte i_onlineOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, byte, void>)0x0048DA40)(ref this, i_onlineOnly);

    /// <summary>
    /// <code>Offset: 0x0048DDA0
    /// void __thiscall gmFriendsUI::RecvNotice_ChatCommand_RemoveFriend(int,const char**)</code>
    /// </summary>
    public void RecvNotice_ChatCommand_RemoveFriend(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, sbyte**, void>)0x0048DDA0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0048DF20
    /// bool __thiscall gmFriendsUI::RefreshFriendsDisplay(gmFriendsUI*)</code>
    /// </summary>
    public byte RefreshFriendsDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, byte>)0x0048DF20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048DFB0
    /// bool __thiscall gmFriendsUI::ServerSays_UpdateFriend(gmFriendsUI*,const FriendDataList*)</code>
    /// </summary>
    public byte ServerSays_UpdateFriend(ACBindings.Internal.FriendDataList* i_friendDataList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, byte>)0x0048DFB0)(ref this, i_friendDataList);

    /// <summary>
    /// <code>Offset: 0x0048E1D0
    /// bool __thiscall gmFriendsUI::ServerSays_AddFriend(gmFriendsUI*,const FriendDataList*)</code>
    /// </summary>
    public byte ServerSays_AddFriend(ACBindings.Internal.FriendDataList* i_friendDataList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, byte>)0x0048E1D0)(ref this, i_friendDataList);

    /// <summary>
    /// <code>Offset: 0x0048E290
    /// bool __thiscall gmFriendsUI::ServerSays_RemoveFriend(gmFriendsUI*,const FriendDataList*,bool)</code>
    /// </summary>
    public byte ServerSays_RemoveFriend(ACBindings.Internal.FriendDataList* i_friendDataList, byte i_bSilent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, byte, byte>)0x0048E290)(ref this, i_friendDataList, i_bSilent);

    /// <summary>
    /// <code>Offset: 0x0048E300
    /// void __thiscall gmFriendsUI::RecvNotice_ChatCommand_RemoveAllFriends(gmFriendsUI*)</code>
    /// </summary>
    public void RecvNotice_ChatCommand_RemoveAllFriends() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048E300)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048E380
    /// void __thiscall gmFriendsUI::gmFriendsUI(gmFriendsUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0048E380)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0048E410
    /// UIElement* __thiscall gmFriendsUI::DynamicCast(gmFriendsUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, uint, ACBindings.Internal.UIElement*>)0x0048E410)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0048E430
    /// unsigned int __thiscall gmFriendsUI::GetUIElementType(gmFriendsUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, uint>)0x0048E430)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048E440
    /// void __thiscall gmFriendsUI::~gmFriendsUI(gmFriendsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, void>)0x0048E440)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048E4F0
    /// void __cdecl gmFriendsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048E4F0)();

    /// <summary>
    /// <code>Offset: 0x0048E550
    /// void __thiscall gmFriendsUI::RecvNotice_UpdateFriendsList(gmFriendsUI*,const FriendDataList*,int)</code>
    /// </summary>
    public void RecvNotice_UpdateFriendsList(ACBindings.Internal.FriendDataList* i_friendDataList, int i_updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmFriendsUI, ACBindings.Internal.FriendDataList*, int, void>)0x0048E550)(ref this, i_friendDataList, i_updateType);
}

