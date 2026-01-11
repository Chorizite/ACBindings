namespace ACBindings.Internal;

public unsafe struct gmContractsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmContractsUI_vtbl
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
    public long m_ContractList;
    public ACBindings.Internal.UIElement_ListBox* m_pContractsBox;
    public ACBindings.Internal.UIElement_Text* m_pProgressText;
    public ACBindings.Internal.UIElement_Text* m_pContactText;
    public ACBindings.Internal.UIElement_Text* m_pAreaText;
    public ACBindings.Internal.UIElement_Text* m_pContactLocText;
    public ACBindings.Internal.UIElement_Text* m_pTimedText;
    public ACBindings.Internal.UIElement_Text* m_pNotesText;
    public ACBindings.Internal.ContractSortCriteria m_SortCriteria;
    public byte m_ReverseSort;
    public int m_LastClickIndex;
    public double m_LastClickTime;
    public double m_timeNextUpdate;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00497CF0
    /// bool __thiscall gmContractsUI::CheckForDoubleClick(gmContractsUI*,const int)</code>
    /// </summary>
    public byte CheckForDoubleClick(int selected_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, int, byte>)0x00497CF0)(ref this, selected_index);

    /// <summary>
    /// <code>Offset: 0x00498120
    /// void __thiscall gmContractsUI::PostInit(gmContractsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00498120)(ref this);

    /// <summary>
    /// <code>Offset: 0x004990C0
    /// void __stdcall gmContractsUI::FillProgressString(wchar_t*,int,int)</code>
    /// </summary>
    public static void FillProgressString(System.IntPtr a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<System.IntPtr, int, int, void>)0x004990C0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004993E0
    /// UIElement* __thiscall gmContractsUI::DynamicCast(gmContractsUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, uint, ACBindings.Internal.UIElement*>)0x004993E0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00499400
    /// unsigned int __thiscall gmContractsUI::GetUIElementType(gmContractsUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, uint>)0x00499400)(ref this);

    /// <summary>
    /// <code>Offset: 0x00499410
    /// void __thiscall gmContractsUI::~gmContractsUI(gmContractsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00499410)(ref this);

    /// <summary>
    /// <code>Offset: 0x004994E0
    /// void __thiscall gmContractsUI::UpdateButtons(gmContractsUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x004994E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004999D0
    /// void __thiscall gmContractsUI::AddContractToListbox(gmContractsUI*,const ContractInfo*)</code>
    /// </summary>
    public void AddContractToListbox(ACBindings.Internal.ContractInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.ContractInfo*, void>)0x004999D0)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x00499B10
    /// void __thiscall gmContractsUI::RefreshContractListbox(gmContractsUI*)</code>
    /// </summary>
    public void RefreshContractListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00499B10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00499F60
    /// void __cdecl gmContractsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00499F60)();

    /// <summary>
    /// <code>Offset: 0x00499F80
    /// void __thiscall gmContractsUI::RebuildContractListbox(gmContractsUI*)</code>
    /// </summary>
    public void RebuildContractListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x00499F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049A140
    /// void __thiscall gmContractsUI::ListenToGlobalMessage(gmContractsUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, uint, int, void>)0x0049A140)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x0049A190
    /// void __thiscall gmContractsUI::RebuildContractList(gmContractsUI*)</code>
    /// </summary>
    public void RebuildContractList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x0049A190)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049A540
    /// void __thiscall gmContractsUI::SortContractList(gmContractsUI*)</code>
    /// </summary>
    public void SortContractList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, void>)0x0049A540)(ref this);

    /// <summary>
    /// <code>Offset: 0x0049A650
    /// void __thiscall gmContractsUI::RecvNotice_UpdateContractTrackerTable(gmContractsUI*,const CContractTrackerTable*)</code>
    /// </summary>
    public void RecvNotice_UpdateContractTrackerTable(ACBindings.Internal.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.CContractTrackerTable*, void>)0x0049A650)(ref this, contractTrackerTable);

    /// <summary>
    /// <code>Offset: 0x0049A670
    /// void __thiscall gmContractsUI::RecvNotice_UpdateContractTracker(gmContractsUI*,const CContractTracker*,int)</code>
    /// </summary>
    public void RecvNotice_UpdateContractTracker(ACBindings.Internal.CContractTracker* contractTracker, int bDeleteContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.CContractTracker*, int, void>)0x0049A670)(ref this, contractTracker, bDeleteContract);

    /// <summary>
    /// <code>Offset: 0x0049A690
    /// UIElementMessageListenResult __thiscall gmContractsUI::ListenToElementMessage(gmContractsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0049A690)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x0049A7B0
    /// void __thiscall gmContractsUI::OnVisibilityChanged(gmContractsUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmContractsUI, byte, void>)0x0049A7B0)(ref this, i_bVisible);
}

