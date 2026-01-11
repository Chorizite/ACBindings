namespace ACBindings.Internal;

public unsafe struct gmJournalUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmJournalUI_vtbl
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
    public ACBindings.Internal.UIElement_Button* m_pStartTimerButton;
    public ACBindings.Internal.UIElement_Text* m_pLabelEditBox;
    public ACBindings.Internal.UIElement_Text* m_pTitleEditBox;
    public ACBindings.Internal.UIElement_Text* m_pNotesEditBox;
    public ACBindings.Internal.UIElement_Text* m_pDaysEditBox;
    public ACBindings.Internal.UIElement_Text* m_pHoursEditBox;
    public ACBindings.Internal.UIElement_Text* m_pMinutesEditBox;
    public ACBindings.Internal.UIElement_Text* m_pLocationStaticText;
    public ACBindings.Internal.UIElement_Text* m_pTimerStaticText;
    public ACBindings.Internal.UIElement_Text* m_pDaysStaticText;
    public ACBindings.Internal.UIElement_Text* m_pHoursStaticText;
    public ACBindings.Internal.UIElement_Text* m_pMinutesStaticText;
    public ACBindings.Internal.UIElement_Text* m_pPageNumberStaticText;
    public byte m_Loaded;
    public uint m_CurrentPage;
    public ACBindings.Internal.PageInfo m_Info;
    public double m_timeNextUpdate;

    // Generated Constructor
    public gmJournalUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00494DC0
    /// void __thiscall gmJournalUI::ClearTimerText(gmJournalUI*)</code>
    /// </summary>
    public void ClearTimerText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00494DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495050
    /// void __thiscall gmJournalUI::gmJournalUI(gmJournalUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00495050)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00495100
    /// UIElement* __thiscall gmJournalUI::DynamicCast(gmJournalUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, ACBindings.Internal.UIElement*>)0x00495100)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00495120
    /// unsigned int __thiscall gmJournalUI::GetUIElementType(gmJournalUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint>)0x00495120)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495130
    /// void __thiscall gmJournalUI::~gmJournalUI(gmJournalUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495130)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495410
    /// void __cdecl gmJournalUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00495410)();

    /// <summary>
    /// <code>Offset: 0x00495430
    /// int __thiscall gmJournalUI::ResetTimer(gmJournalUI*)</code>
    /// </summary>
    public int ResetTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, int>)0x00495430)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495640
    /// void __thiscall gmJournalUI::SaveThisPage(gmJournalUI*)</code>
    /// </summary>
    public void SaveThisPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495640)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495A50
    /// void __thiscall gmJournalUI::ShowEditableTimer(gmJournalUI*)</code>
    /// </summary>
    public void ShowEditableTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495A50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495B70
    /// void __thiscall gmJournalUI::UpdateRunningTimer(gmJournalUI*)</code>
    /// </summary>
    public void UpdateRunningTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495B70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495BD0
    /// void __thiscall gmJournalUI::UpdateLocation(gmJournalUI*)</code>
    /// </summary>
    public void UpdateLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00495D50
    /// void __thiscall gmJournalUI::UpdatePageNumber(gmJournalUI*)</code>
    /// </summary>
    public void UpdatePageNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00495D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00496250
    /// void __thiscall gmJournalUI::PostInit(gmJournalUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496250)(ref this);

    /// <summary>
    /// <code>Offset: 0x00496470
    /// void __thiscall gmJournalUI::ShowRunningTimer(gmJournalUI*)</code>
    /// </summary>
    public void ShowRunningTimer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496470)(ref this);

    /// <summary>
    /// <code>Offset: 0x00496540
    /// void __thiscall gmJournalUI::ResetLocation(gmJournalUI*)</code>
    /// </summary>
    public void ResetLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496540)(ref this);

    /// <summary>
    /// <code>Offset: 0x004965C0
    /// void __thiscall gmJournalUI::ClearCurrentPage(gmJournalUI*)</code>
    /// </summary>
    public void ClearCurrentPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x004965C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00496710
    /// void __thiscall gmJournalUI::GotoPage(gmJournalUI*,const unsigned int)</code>
    /// </summary>
    public void GotoPage(uint page_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, void>)0x00496710)(ref this, page_index);

    /// <summary>
    /// <code>Offset: 0x00496870
    /// void __thiscall gmJournalUI::Update(gmJournalUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496870)(ref this);

    /// <summary>
    /// <code>Offset: 0x004968B0
    /// void __thiscall gmJournalUI::DeletePage(gmJournalUI*,const unsigned int)</code>
    /// </summary>
    public void DeletePage(uint page_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, void>)0x004968B0)(ref this, page_index);

    /// <summary>
    /// <code>Offset: 0x00496940
    /// LONG __stdcall gmJournalUI::CreateJournalPath(const char*,volatile LONG*)</code>
    /// </summary>
    public static int CreateJournalPath(sbyte* a1, int* ArgList) => ((delegate* unmanaged[Stdcall]<sbyte*, int*, int>)0x00496940)(a1, ArgList);

    /// <summary>
    /// <code>Offset: 0x00496AE0
    /// LONG __stdcall gmJournalUI::ReportInScroll(const char*,unsigned int)</code>
    /// </summary>
    public static int ReportInScroll(sbyte* a1, uint a2) => ((delegate* unmanaged[Stdcall]<sbyte*, uint, int>)0x00496AE0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00496B60
    /// void __thiscall gmJournalUI::NewPage(gmJournalUI*)</code>
    /// </summary>
    public void NewPage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, void>)0x00496B60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00496BB0
    /// UIElementMessageListenResult __thiscall gmJournalUI::ListenToElementMessage(gmJournalUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00496BB0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00496DA0
    /// int __thiscall gmJournalUI::LoadPages(gmJournalUI*,const char*)</code>
    /// </summary>
    public int LoadPages(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, sbyte*, int>)0x00496DA0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00497550
    /// int __thiscall gmJournalUI::SavePages(_BYTE*,const char*)</code>
    /// </summary>
    public int SavePages(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, sbyte*, int>)0x00497550)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00497AC0
    /// void __thiscall gmJournalUI::ListenToGlobalMessage(gmJournalUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, uint, int, void>)0x00497AC0)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x00497BD0
    /// void __thiscall gmJournalUI::OnVisibilityChanged(gmJournalUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmJournalUI, byte, void>)0x00497BD0)(ref this, i_bVisible);
}

