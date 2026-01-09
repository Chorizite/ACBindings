namespace ACBindings;

// gmFriendsUI
public unsafe struct gmFriendsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmFriendsUI_vtbl
    public unsafe struct gmFriendsUI_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_Button* m_pAddButton;
    public ACBindings.UIElement_Button* m_pRemoveButton;
    public ACBindings.UIElement_Button* m_pTellButton;
    public ACBindings.UIElement_ListBox* m_pFriendsListBox;
    public ACBindings.UIElement_Text* m_pFriendNameEditBox;
    public ACBindings.FriendDataList m_friendsList;

    // Generated Constructor
    public gmFriendsUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall gmFriendsUI::RemoveFriendDisplay(gmFriendsUI*,unsigned int)
    public byte RemoveFriendDisplay(uint friendID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, uint, byte>)0x0048D340)(ref this, friendID);
    // void __thiscall gmFriendsUI::PostInit(gmFriendsUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, void>)0x0048D3D0)(ref this);
    // char __thiscall gmFriendsUI::Request_AddFriend(_DWORD*,int)
    public sbyte Request_AddFriend(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, int, sbyte>)0x0048D520)(ref this, a2);
    // void __thiscall gmFriendsUI::UpdateButtons(gmFriendsUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, void>)0x0048D580)(ref this);
    // UIElement* __thiscall gmFriendsUI::FindSortedInsertPosition(_DWORD*,const wchar_t**,char)
    public ACBindings.UIElement* FindSortedInsertPosition(System.IntPtr a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, System.IntPtr, sbyte, ACBindings.UIElement*>)0x0048D650)(ref this, a2, a3);
    // char __thiscall gmFriendsUI::RecvNotice_ChatCommand_AddFriend(_DWORD*,int)
    public sbyte RecvNotice_ChatCommand_AddFriend(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, int, sbyte>)0x0048D750)(ref this, a2);
    // char __thiscall gmFriendsUI::AddFriendDisplay(int,const wchar_t**,unsigned int,char)
    public sbyte AddFriendDisplay(System.IntPtr a2, uint val, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, System.IntPtr, uint, sbyte, sbyte>)0x0048D760)(ref this, a2, val, a4);
    // UIElementMessageListenResult __thiscall gmFriendsUI::ListenToElementMessage(gmFriendsUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0048D800)(ref this, i_rMsg);
    // void __thiscall gmFriendsUI::RecvNotice_ChatCommand_DisplayFriends(gmFriendsUI*,bool)
    public void RecvNotice_ChatCommand_DisplayFriends(byte i_onlineOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, byte, void>)0x0048DA40)(ref this, i_onlineOnly);
    // void __thiscall gmFriendsUI::RecvNotice_ChatCommand_RemoveFriend(int,const char**)
    public void RecvNotice_ChatCommand_RemoveFriend(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, sbyte**, void>)0x0048DDA0)(ref this, a2);
    // bool __thiscall gmFriendsUI::RefreshFriendsDisplay(gmFriendsUI*)
    public byte RefreshFriendsDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, byte>)0x0048DF20)(ref this);
    // bool __thiscall gmFriendsUI::ServerSays_UpdateFriend(gmFriendsUI*,const FriendDataList*)
    public byte ServerSays_UpdateFriend(ACBindings.FriendDataList* i_friendDataList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, ACBindings.FriendDataList*, byte>)0x0048DFB0)(ref this, i_friendDataList);
    // bool __thiscall gmFriendsUI::ServerSays_AddFriend(gmFriendsUI*,const FriendDataList*)
    public byte ServerSays_AddFriend(ACBindings.FriendDataList* i_friendDataList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, ACBindings.FriendDataList*, byte>)0x0048E1D0)(ref this, i_friendDataList);
    // bool __thiscall gmFriendsUI::ServerSays_RemoveFriend(gmFriendsUI*,const FriendDataList*,bool)
    public byte ServerSays_RemoveFriend(ACBindings.FriendDataList* i_friendDataList, byte i_bSilent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, ACBindings.FriendDataList*, byte, byte>)0x0048E290)(ref this, i_friendDataList, i_bSilent);
    // void __thiscall gmFriendsUI::RecvNotice_ChatCommand_RemoveAllFriends(gmFriendsUI*)
    public void RecvNotice_ChatCommand_RemoveAllFriends() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, void>)0x0048E300)(ref this);
    // void __thiscall gmFriendsUI::gmFriendsUI(gmFriendsUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0048E380)(ref this, layout, full_desc);
    // UIElement* __thiscall gmFriendsUI::DynamicCast(gmFriendsUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, uint, ACBindings.UIElement*>)0x0048E410)(ref this, i_eType);
    // unsigned int __thiscall gmFriendsUI::GetUIElementType(gmFriendsUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, uint>)0x0048E430)(ref this);
    // void __thiscall gmFriendsUI::~gmFriendsUI(gmFriendsUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, void>)0x0048E440)(ref this);
    // void __cdecl gmFriendsUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048E4F0)();
    // void __thiscall gmFriendsUI::RecvNotice_UpdateFriendsList(gmFriendsUI*,const FriendDataList*,int)
    public void RecvNotice_UpdateFriendsList(ACBindings.FriendDataList* i_friendDataList, int i_updateType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmFriendsUI, ACBindings.FriendDataList*, int, void>)0x0048E550)(ref this, i_friendDataList, i_updateType);
}

