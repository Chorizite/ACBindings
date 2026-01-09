namespace ACBindings;

// gmJournalUI
public unsafe struct gmJournalUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmJournalUI_vtbl
    public unsafe struct gmJournalUI_vtbl
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
    public ACBindings.UIElement_Button* m_pStartTimerButton;
    public ACBindings.UIElement_Text* m_pLabelEditBox;
    public ACBindings.UIElement_Text* m_pTitleEditBox;
    public ACBindings.UIElement_Text* m_pNotesEditBox;
    public ACBindings.UIElement_Text* m_pDaysEditBox;
    public ACBindings.UIElement_Text* m_pHoursEditBox;
    public ACBindings.UIElement_Text* m_pMinutesEditBox;
    public ACBindings.UIElement_Text* m_pLocationStaticText;
    public ACBindings.UIElement_Text* m_pTimerStaticText;
    public ACBindings.UIElement_Text* m_pDaysStaticText;
    public ACBindings.UIElement_Text* m_pHoursStaticText;
    public ACBindings.UIElement_Text* m_pMinutesStaticText;
    public ACBindings.UIElement_Text* m_pPageNumberStaticText;
    public byte m_Loaded;
    public uint m_CurrentPage;
    public ACBindings.PageInfo m_Info;
    public double m_timeNextUpdate;

    // Generated Constructor
    public gmJournalUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmJournalUI::ClearTimerText(gmJournalUI*)
    public void ClearTimerText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00494DC0)(ref this);
    // void __thiscall gmJournalUI::gmJournalUI(gmJournalUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00495050)(ref this, layout, full_desc);
    // UIElement* __thiscall gmJournalUI::DynamicCast(gmJournalUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, uint, ACBindings.UIElement*>)0x00495100)(ref this, i_eType);
    // unsigned int __thiscall gmJournalUI::GetUIElementType(gmJournalUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, uint>)0x00495120)(ref this);
    // void __thiscall gmJournalUI::~gmJournalUI(gmJournalUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00495130)(ref this);
    // void __cdecl gmJournalUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00495410)();
    // int __thiscall gmJournalUI::ResetTimer(gmJournalUI*)
    public int ResetTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, int>)0x00495430)(ref this);
    // void __thiscall gmJournalUI::SaveThisPage(gmJournalUI*)
    public void SaveThisPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00495640)(ref this);
    // void __thiscall gmJournalUI::ShowEditableTimer(gmJournalUI*)
    public void ShowEditableTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00495A50)(ref this);
    // void __thiscall gmJournalUI::UpdateRunningTimer(gmJournalUI*)
    public void UpdateRunningTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00495B70)(ref this);
    // void __thiscall gmJournalUI::UpdateLocation(gmJournalUI*)
    public void UpdateLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00495BD0)(ref this);
    // void __thiscall gmJournalUI::UpdatePageNumber(gmJournalUI*)
    public void UpdatePageNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00495D50)(ref this);
    // void __thiscall gmJournalUI::PostInit(gmJournalUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00496250)(ref this);
    // void __thiscall gmJournalUI::ShowRunningTimer(gmJournalUI*)
    public void ShowRunningTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00496470)(ref this);
    // void __thiscall gmJournalUI::ResetLocation(gmJournalUI*)
    public void ResetLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00496540)(ref this);
    // void __thiscall gmJournalUI::ClearCurrentPage(gmJournalUI*)
    public void ClearCurrentPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x004965C0)(ref this);
    // void __thiscall gmJournalUI::GotoPage(gmJournalUI*,const unsigned int)
    public void GotoPage(uint page_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, uint, void>)0x00496710)(ref this, page_index);
    // void __thiscall gmJournalUI::Update(gmJournalUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00496870)(ref this);
    // void __thiscall gmJournalUI::DeletePage(gmJournalUI*,const unsigned int)
    public void DeletePage(uint page_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, uint, void>)0x004968B0)(ref this, page_index);
    // LONG __stdcall gmJournalUI::CreateJournalPath(const char*,volatile LONG*)
    public static int CreateJournalPath(sbyte* a1, int* ArgList) => ((delegate* unmanaged[Stdcall]<sbyte*, int*, int>)0x00496940)(a1, ArgList);
    // LONG __stdcall gmJournalUI::ReportInScroll(const char*,unsigned int)
    public static int ReportInScroll(sbyte* a1, uint a2) => ((delegate* unmanaged[Stdcall]<sbyte*, uint, int>)0x00496AE0)(a1, a2);
    // void __thiscall gmJournalUI::NewPage(gmJournalUI*)
    public void NewPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, void>)0x00496B60)(ref this);
    // UIElementMessageListenResult __thiscall gmJournalUI::ListenToElementMessage(gmJournalUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00496BB0)(ref this, i_rMsg);
    // int __thiscall gmJournalUI::LoadPages(gmJournalUI*,const char*)
    public int LoadPages(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, sbyte*, int>)0x00496DA0)(ref this, a2);
    // int __thiscall gmJournalUI::SavePages(_BYTE*,const char*)
    public int SavePages(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, sbyte*, int>)0x00497550)(ref this, a2);
    // void __thiscall gmJournalUI::ListenToGlobalMessage(gmJournalUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, uint, int, void>)0x00497AC0)(ref this, i_messageID, i_data_int);
    // void __thiscall gmJournalUI::OnVisibilityChanged(gmJournalUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmJournalUI, byte, void>)0x00497BD0)(ref this, i_bVisible);
}

