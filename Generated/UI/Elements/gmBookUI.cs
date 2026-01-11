namespace ACBindings.Internal;

public unsafe struct gmBookUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler

    // Child Types
    public unsafe struct gmBookUI_vtbl
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
    public ACBindings.Internal.UIElement* m_nextButton;
    public ACBindings.Internal.UIElement* m_prevButton;
    public ACBindings.Internal.UIElement_Text* m_titleText;
    public ACBindings.Internal.UIElement_Text* m_pageText;
    public ACBindings.Internal.UIElement_Menu* m_pageMenu;
    public ACBindings.Internal.UIElement_Text* m_menuSelectionPageNumText;
    public uint bookID;
    public int maxNumPages;
    public ACBindings.Internal.PageDataList* pageDataList;
    public int curPage;
    public int requestPending;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte inscription;
    public uint scribeID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte scribeName;

    // Generated Constructor
    public gmBookUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004BB710
    /// void __thiscall gmBookUI::gmBookUI(gmBookUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004BB710)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004BB7E0
    /// UIElement* __thiscall gmBookUI::DynamicCast(gmBookUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, ACBindings.Internal.UIElement*>)0x004BB7E0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004BB800
    /// unsigned int __thiscall gmBookUI::GetUIElementType(gmBookUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint>)0x004BB800)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BB810
    /// void __thiscall gmBookUI::~gmBookUI(gmBookUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BB810)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BB8B0
    /// UIElement* __cdecl gmBookUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004BB8B0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004BB8E0
    /// void __thiscall gmBookUI::SetEditable(gmBookUI*,UIElement_Text*,int)</code>
    /// </summary>
    public void SetEditable(ACBindings.Internal.UIElement_Text* text, int editable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.UIElement_Text*, int, void>)0x004BB8E0)(ref this, text, editable);

    /// <summary>
    /// <code>Offset: 0x004BB9F0
    /// void __thiscall gmBookUI::PostInit(gmBookUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BB9F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BBB00
    /// void __cdecl gmBookUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BBB00)();

    /// <summary>
    /// <code>Offset: 0x004BBB20
    /// void __thiscall gmBookUI::AddPageInfo(gmBookUI*,int,const StringInfo*)</code>
    /// </summary>
    public void AddPageInfo(int pageNum, ACBindings.Internal.StringInfo* text) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, ACBindings.Internal.StringInfo*, void>)0x004BBB20)(ref this, pageNum, text);

    /// <summary>
    /// <code>Offset: 0x004BBBB0
    /// void __thiscall gmBookUI::UpdateMenuSelectionInfo(gmBookUI*,int)</code>
    /// </summary>
    public void UpdateMenuSelectionInfo(int index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, void>)0x004BBBB0)(ref this, index);

    /// <summary>
    /// <code>Offset: 0x004BBC10
    /// void __thiscall gmBookUI::UpdateMenu(gmBookUI*)</code>
    /// </summary>
    public void UpdateMenu() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BBC10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BBE70
    /// void __thiscall gmBookUI::DisplayPageData(gmBookUI*,PageData*)</code>
    /// </summary>
    public void DisplayPageData(ACBindings.Internal.PageData* pd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.PageData*, void>)0x004BBE70)(ref this, pd);

    /// <summary>
    /// <code>Offset: 0x004BBF10
    /// int __thiscall gmBookUI::PageTextBlank(gmBookUI*)</code>
    /// </summary>
    public int PageTextBlank() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int>)0x004BBF10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BBFD0
    /// int __thiscall gmBookUI::CloseCurPage(gmBookUI*)</code>
    /// </summary>
    public int CloseCurPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int>)0x004BBFD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BC190
    /// void __thiscall gmBookUI::CloseBook(gmBookUI*)</code>
    /// </summary>
    public void CloseBook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, void>)0x004BC190)(ref this);

    /// <summary>
    /// <code>Offset: 0x004BC200
    /// void __thiscall gmBookUI::SetCurPage(gmBookUI*,int)</code>
    /// </summary>
    public void SetCurPage(int curPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, void>)0x004BC200)(ref this, curPage);

    /// <summary>
    /// <code>Offset: 0x004BC4A0
    /// void __thiscall gmBookUI::RecvNotice_BookPageDataResponse(gmBookUI*,unsigned int,int,const PageData*)</code>
    /// </summary>
    public void RecvNotice_BookPageDataResponse(uint i_bookID, int i_pageNum, ACBindings.Internal.PageData* i_pageData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, int, ACBindings.Internal.PageData*, void>)0x004BC4A0)(ref this, i_bookID, i_pageNum, i_pageData);

    /// <summary>
    /// <code>Offset: 0x004BC4B0
    /// void __thiscall gmBookUI::BookAddPageResponseEvent(gmBookUI*,unsigned int,int,int)</code>
    /// </summary>
    public void BookAddPageResponseEvent(uint bookID, int pageNum, int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, int, int, void>)0x004BC4B0)(ref this, bookID, pageNum, success);

    /// <summary>
    /// <code>Offset: 0x004BC6A0
    /// UIElementMessageListenResult __thiscall gmBookUI::ListenToElementMessage(gmBookUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004BC6A0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004BC8F0
    /// void __thiscall gmBookUI::OnVisibilityChanged(gmBookUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, byte, void>)0x004BC8F0)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004BC930
    /// void __thiscall gmBookUI::OpenBook(gmBookUI*,int,int,_DWORD*,void**,unsigned int,void**)</code>
    /// </summary>
    public void OpenBook(int a2, int a3, int* a4, void** a5, uint a6, void** a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, int, int*, void**, uint, void**, void>)0x004BC930)(ref this, a2, a3, a4, a5, a6, a7);

    /// <summary>
    /// <code>Offset: 0x004BCB20
    /// void __thiscall gmBookUI::RecvNotice_BookAddPageResponse(gmBookUI*,unsigned int,int,int)</code>
    /// </summary>
    public void RecvNotice_BookAddPageResponse(uint i_bookID, int i_pageNum, int i_success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, uint, int, int, void>)0x004BCB20)(ref this, i_bookID, i_pageNum, i_success);

    /// <summary>
    /// <code>Offset: 0x004BCB30
    /// void __thiscall gmBookUI::RecvNotice_OpenBook(char*,int,int,_DWORD*,void**,unsigned int,void**)</code>
    /// </summary>
    public void RecvNotice_OpenBook(int a2, int a3, int* a4, void** a5, uint a6, void** a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBookUI, int, int, int*, void**, uint, void**, void>)0x004BCB30)(ref this, a2, a3, a4, a5, a6, a7);
}

