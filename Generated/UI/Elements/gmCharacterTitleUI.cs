namespace ACBindings;

// gmCharacterTitleUI
public unsafe struct gmCharacterTitleUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCharacterTitleUI_vtbl
    public unsafe struct gmCharacterTitleUI_vtbl
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
    public ACBindings.UIElement_Text* m_pDisplayTitleText;
    public ACBindings.UIElement_Button* m_pDisplayButton;
    public ACBindings.UIElement_ListBox* m_pTitleListBox;
    public ACBindings.CharacterTitleTable m_characterTitleTable;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmCharacterTitleUI::UpdateButtons(gmCharacterTitleUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, void>)0x0049A7E0)(ref this);
    // void __thiscall gmCharacterTitleUI::PostInit(gmCharacterTitleUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, void>)0x0049A8F0)(ref this);
    // UIElementMessageListenResult __thiscall gmCharacterTitleUI::ListenToElementMessage(gmCharacterTitleUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0049A9B0)(ref this, i_rMsg);
    // UIElement* __thiscall gmCharacterTitleUI::FindSortedInsertPosition(_DWORD*,const wchar_t**)
    public ACBindings.UIElement* FindSortedInsertPosition(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, System.IntPtr, ACBindings.UIElement*>)0x0049AA40)(ref this, a2);
    // bool __thiscall gmCharacterTitleUI::AddTitleToList(gmCharacterTitleUI*,unsigned int)
    public byte AddTitleToList(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, uint, byte>)0x0049AB20)(ref this, i_title);
    // void __thiscall gmCharacterTitleUI::RecvNotice_AddCharacterTitle(gmCharacterTitleUI*,unsigned int)
    public void RecvNotice_AddCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, uint, void>)0x0049AC00)(ref this, i_title);
    // UIElement* __thiscall gmCharacterTitleUI::DynamicCast(gmCharacterTitleUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, uint, ACBindings.UIElement*>)0x0049AD20)(ref this, i_eType);
    // unsigned int __thiscall gmCharacterTitleUI::GetUIElementType(gmCharacterTitleUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, uint>)0x0049AD40)(ref this);
    // void __thiscall gmCharacterTitleUI::~gmCharacterTitleUI(gmCharacterTitleUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, void>)0x0049AD50)(ref this);
    // void __cdecl gmCharacterTitleUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049AE10)();
    // bool __thiscall gmCharacterTitleUI::Refresh(gmCharacterTitleUI*)
    public byte Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, byte>)0x0049AE30)(ref this);
    // void __thiscall gmCharacterTitleUI::RecvNotice_UpdateCharacterTitleTable(gmCharacterTitleUI*,const CharacterTitleTable*)
    public void RecvNotice_UpdateCharacterTitleTable(ACBindings.CharacterTitleTable* i_titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, ACBindings.CharacterTitleTable*, void>)0x0049AFA0)(ref this, i_titleTable);
    // void __thiscall gmCharacterTitleUI::RecvNotice_SetDisplayCharacterTitle(gmCharacterTitleUI*,unsigned int)
    public void RecvNotice_SetDisplayCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterTitleUI, uint, void>)0x0049AFC0)(ref this, i_title);
}

