namespace ACBindings;

// gmBookUI
public unsafe struct gmBookUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.ObjectRangeHandler

    // Child Types
    // gmBookUI_vtbl
    public unsafe struct gmBookUI_vtbl
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
    public ACBindings.UIElement* m_nextButton;
    public ACBindings.UIElement* m_prevButton;
    public ACBindings.UIElement_Text* m_titleText;
    public ACBindings.UIElement_Text* m_pageText;
    public ACBindings.UIElement_Menu* m_pageMenu;
    public ACBindings.UIElement_Text* m_menuSelectionPageNumText;
    public uint bookID;
    public int maxNumPages;
    public ACBindings.PageDataList* pageDataList;
    public int curPage;
    public int requestPending;
    public ACBindings.AC1Legacy.PStringBase__sbyte inscription;
    public uint scribeID;
    public ACBindings.AC1Legacy.PStringBase__sbyte scribeName;

    // Generated Constructor
    public gmBookUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmBookUI::gmBookUI(gmBookUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004BB710)(ref this, layout, full_desc);
    // UIElement* __thiscall gmBookUI::DynamicCast(gmBookUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, uint, ACBindings.UIElement*>)0x004BB7E0)(ref this, i_eType);
    // unsigned int __thiscall gmBookUI::GetUIElementType(gmBookUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, uint>)0x004BB800)(ref this);
    // void __thiscall gmBookUI::~gmBookUI(gmBookUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, void>)0x004BB810)(ref this);
    // UIElement* __cdecl gmBookUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004BB8B0)(layout, full_desc);
    // void __thiscall gmBookUI::SetEditable(gmBookUI*,UIElement_Text*,int)
    public void SetEditable(ACBindings.UIElement_Text* text, int editable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, ACBindings.UIElement_Text*, int, void>)0x004BB8E0)(ref this, text, editable);
    // void __thiscall gmBookUI::PostInit(gmBookUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, void>)0x004BB9F0)(ref this);
    // void __cdecl gmBookUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BBB00)();
    // void __thiscall gmBookUI::AddPageInfo(gmBookUI*,int,const StringInfo*)
    public void AddPageInfo(int pageNum, ACBindings.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int, ACBindings.StringInfo*, void>)0x004BBB20)(ref this, pageNum, text);
    // void __thiscall gmBookUI::UpdateMenuSelectionInfo(gmBookUI*,int)
    public void UpdateMenuSelectionInfo(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int, void>)0x004BBBB0)(ref this, index);
    // void __thiscall gmBookUI::UpdateMenu(gmBookUI*)
    public void UpdateMenu() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, void>)0x004BBC10)(ref this);
    // void __thiscall gmBookUI::DisplayPageData(gmBookUI*,PageData*)
    public void DisplayPageData(ACBindings.PageData* pd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, ACBindings.PageData*, void>)0x004BBE70)(ref this, pd);
    // int __thiscall gmBookUI::PageTextBlank(gmBookUI*)
    public int PageTextBlank() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int>)0x004BBF10)(ref this);
    // int __thiscall gmBookUI::CloseCurPage(gmBookUI*)
    public int CloseCurPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int>)0x004BBFD0)(ref this);
    // void __thiscall gmBookUI::CloseBook(gmBookUI*)
    public void CloseBook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, void>)0x004BC190)(ref this);
    // void __thiscall gmBookUI::SetCurPage(gmBookUI*,int)
    public void SetCurPage(int curPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int, void>)0x004BC200)(ref this, curPage);
    // void __thiscall gmBookUI::RecvNotice_BookPageDataResponse(gmBookUI*,unsigned int,int,const PageData*)
    public void RecvNotice_BookPageDataResponse(uint i_bookID, int i_pageNum, ACBindings.PageData* i_pageData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, uint, int, ACBindings.PageData*, void>)0x004BC4A0)(ref this, i_bookID, i_pageNum, i_pageData);
    // void __thiscall gmBookUI::BookAddPageResponseEvent(gmBookUI*,unsigned int,int,int)
    public void BookAddPageResponseEvent(uint bookID, int pageNum, int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, uint, int, int, void>)0x004BC4B0)(ref this, bookID, pageNum, success);
    // UIElementMessageListenResult __thiscall gmBookUI::ListenToElementMessage(gmBookUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004BC6A0)(ref this, i_rMsg);
    // void __thiscall gmBookUI::OnVisibilityChanged(gmBookUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, byte, void>)0x004BC8F0)(ref this, i_bVisible);
    // void __thiscall gmBookUI::OpenBook(gmBookUI*,int,int,_DWORD*,void**,unsigned int,void**)
    public void OpenBook(int a2, int a3, int* a4, void** a5, uint a6, void** a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int, int, int*, void**, uint, void**, void>)0x004BC930)(ref this, a2, a3, a4, a5, a6, a7);
    // void __thiscall gmBookUI::RecvNotice_BookAddPageResponse(gmBookUI*,unsigned int,int,int)
    public void RecvNotice_BookAddPageResponse(uint i_bookID, int i_pageNum, int i_success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, uint, int, int, void>)0x004BCB20)(ref this, i_bookID, i_pageNum, i_success);
    // void __thiscall gmBookUI::RecvNotice_OpenBook(char*,int,int,_DWORD*,void**,unsigned int,void**)
    public void RecvNotice_OpenBook(int a2, int a3, int* a4, void** a5, uint a6, void** a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBookUI, int, int, int*, void**, uint, void**, void>)0x004BCB30)(ref this, a2, a3, a4, a5, a6, a7);
}

