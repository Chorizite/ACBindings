namespace ACBindings;

// gmPageListUI
public unsafe struct gmPageListUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmPageListUI_vtbl
    public unsafe struct gmPageListUI_vtbl
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
    public long m_PageListPages;
    public ACBindings.UIElement_ListBox* m_pPageListBox;
    public ACBindings.UIElement_Text* m_pSearchEditBox;
    public ACBindings.JournalSortCriteria m_SortCriteria;
    public byte m_ReverseSort;
    public int m_LastClickIndex;
    public double m_LastClickTime;
    public double m_timeNextUpdate;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall gmPageListUI::CheckForDoubleClick(gmPageListUI*,const int)
    public byte CheckForDoubleClick(int selected_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, int, byte>)0x00493420)(ref this, selected_index);
    // void __thiscall gmPageListUI::PostInit(gmPageListUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, void>)0x00493680)(ref this);
    // void __thiscall gmPageListUI::RefreshPageListbox(gmPageListUI*)
    public void RefreshPageListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, void>)0x004936F0)(ref this);
    // void __thiscall gmPageListUI::AddPageToListbox(gmPageListUI*,const PageInfo*)
    public void AddPageToListbox(ACBindings.PageInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, ACBindings.PageInfo*, void>)0x00493960)(ref this, info);
    // void __thiscall gmPageListUI::ListenToGlobalMessage(gmPageListUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, uint, int, void>)0x00493D80)(ref this, i_messageID, i_data_int);
    // void __thiscall gmPageListUI::RebuildPageListbox(gmPageListUI*)
    public void RebuildPageListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, void>)0x00493DD0)(ref this);
    // char __stdcall gmPageListUI::PageContainsString(int,wchar_t*)
    public static sbyte PageContainsString(int a1, System.IntPtr a2) => ((delegate* unmanaged[Stdcall]<int, System.IntPtr, sbyte>)0x00493E40)(a1, a2);
    // UIElement* __thiscall gmPageListUI::DynamicCast(gmPageListUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, uint, ACBindings.UIElement*>)0x00494350)(ref this, i_eType);
    // unsigned int __thiscall gmPageListUI::GetUIElementType(gmPageListUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, uint>)0x00494370)(ref this);
    // void __thiscall gmPageListUI::~gmPageListUI(gmPageListUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, void>)0x00494380)(ref this);
    // UIElement* __cdecl gmPageListUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x00494410)(layout, full_desc);
    // void __cdecl gmPageListUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004945A0)();
    // void __thiscall gmPageListUI::RebuildPageList(gmPageListUI*,const bool)
    public void RebuildPageList(byte i_search) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, byte, void>)0x00494790)(ref this, i_search);
    // void __thiscall gmPageListUI::SortPageList(gmPageListUI*)
    public void SortPageList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, void>)0x00494940)(ref this);
    // UIElementMessageListenResult __thiscall gmPageListUI::ListenToElementMessage(gmPageListUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00494AA0)(ref this, i_rMsg);
    // void __thiscall gmPageListUI::OnVisibilityChanged(gmPageListUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmPageListUI, byte, void>)0x00494C60)(ref this, i_bVisible);
}

