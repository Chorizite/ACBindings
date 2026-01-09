namespace ACBindings;

// gmSquelchUI
public unsafe struct gmSquelchUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmSquelchUI_vtbl
    public unsafe struct gmSquelchUI_vtbl
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
    public ACBindings.UIElement_Button* m_pSquelchCharacterButton;
    public ACBindings.UIElement_Button* m_pSquelchAccountButton;
    public ACBindings.UIElement_Button* m_pRemoveButton;
    public ACBindings.UIElement_ListBox* m_pSquelchListBox;
    public ACBindings.UIElement_Text* m_pSquelchNameEditBox;
    public ACBindings.FriendDataList m_squelchList;

    // Generated Constructor
    public gmSquelchUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmSquelchUI::PostInit(gmSquelchUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, void>)0x0048C440)(ref this);
    // void __thiscall gmSquelchUI::UpdateButtons(gmSquelchUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, void>)0x0048C520)(ref this);
    // UIElement* __thiscall gmSquelchUI::FindSortedInsertPosition(_DWORD*,const wchar_t**,int)
    public ACBindings.UIElement* FindSortedInsertPosition(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, System.IntPtr, int, ACBindings.UIElement*>)0x0048C5E0)(ref this, a2, a3);
    // char __thiscall gmSquelchUI::AddSquelchDisplay(int,const wchar_t**,unsigned int,int)
    public sbyte AddSquelchDisplay(System.IntPtr a2, uint val, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, System.IntPtr, uint, int, sbyte>)0x0048C6C0)(ref this, a2, val, a4);
    // bool __thiscall gmSquelchUI::RefreshSquelchDisplay(gmSquelchUI*)
    public byte RefreshSquelchDisplay() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, byte>)0x0048C9F0)(ref this);
    // UIElementMessageListenResult __thiscall gmSquelchUI::ListenToElementMessage(gmSquelchUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0048CB40)(ref this, i_rMsg);
    // void __thiscall gmSquelchUI::RecvNotice_UpdateSquelchPanel(gmSquelchUI*)
    public void RecvNotice_UpdateSquelchPanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, void>)0x0048CE40)(ref this);
    // void __thiscall gmSquelchUI::gmSquelchUI(gmSquelchUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0048D1B0)(ref this, layout, full_desc);
    // UIElement* __thiscall gmSquelchUI::DynamicCast(gmSquelchUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, uint, ACBindings.UIElement*>)0x0048D240)(ref this, i_eType);
    // unsigned int __thiscall gmSquelchUI::GetUIElementType(gmSquelchUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, uint>)0x0048D260)(ref this);
    // void __thiscall gmSquelchUI::~gmSquelchUI(gmSquelchUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSquelchUI, void>)0x0048D270)(ref this);
    // void __cdecl gmSquelchUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048D320)();
}

