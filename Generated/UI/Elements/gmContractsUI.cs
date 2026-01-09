namespace ACBindings;

// gmContractsUI
public unsafe struct gmContractsUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmContractsUI_vtbl
    public unsafe struct gmContractsUI_vtbl
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
    public long m_ContractList;
    public ACBindings.UIElement_ListBox* m_pContractsBox;
    public ACBindings.UIElement_Text* m_pProgressText;
    public ACBindings.UIElement_Text* m_pContactText;
    public ACBindings.UIElement_Text* m_pAreaText;
    public ACBindings.UIElement_Text* m_pContactLocText;
    public ACBindings.UIElement_Text* m_pTimedText;
    public ACBindings.UIElement_Text* m_pNotesText;
    public ACBindings.ContractSortCriteria m_SortCriteria;
    public byte m_ReverseSort;
    public int m_LastClickIndex;
    public double m_LastClickTime;
    public double m_timeNextUpdate;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall gmContractsUI::CheckForDoubleClick(gmContractsUI*,const int)
    public byte CheckForDoubleClick(int selected_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, int, byte>)0x00497CF0)(ref this, selected_index);
    // void __thiscall gmContractsUI::PostInit(gmContractsUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x00498120)(ref this);
    // void __stdcall gmContractsUI::FillProgressString(wchar_t*,int,int)
    public static void FillProgressString(System.IntPtr a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<System.IntPtr, int, int, void>)0x004990C0)(a1, a2, a3);
    // UIElement* __thiscall gmContractsUI::DynamicCast(gmContractsUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, uint, ACBindings.UIElement*>)0x004993E0)(ref this, i_eType);
    // unsigned int __thiscall gmContractsUI::GetUIElementType(gmContractsUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, uint>)0x00499400)(ref this);
    // void __thiscall gmContractsUI::~gmContractsUI(gmContractsUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x00499410)(ref this);
    // void __thiscall gmContractsUI::UpdateButtons(gmContractsUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x004994E0)(ref this);
    // void __thiscall gmContractsUI::AddContractToListbox(gmContractsUI*,const ContractInfo*)
    public void AddContractToListbox(ACBindings.ContractInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, ACBindings.ContractInfo*, void>)0x004999D0)(ref this, info);
    // void __thiscall gmContractsUI::RefreshContractListbox(gmContractsUI*)
    public void RefreshContractListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x00499B10)(ref this);
    // void __cdecl gmContractsUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00499F60)();
    // void __thiscall gmContractsUI::RebuildContractListbox(gmContractsUI*)
    public void RebuildContractListbox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x00499F80)(ref this);
    // void __thiscall gmContractsUI::ListenToGlobalMessage(gmContractsUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, uint, int, void>)0x0049A140)(ref this, i_messageID, i_data_int);
    // void __thiscall gmContractsUI::RebuildContractList(gmContractsUI*)
    public void RebuildContractList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x0049A190)(ref this);
    // void __thiscall gmContractsUI::SortContractList(gmContractsUI*)
    public void SortContractList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, void>)0x0049A540)(ref this);
    // void __thiscall gmContractsUI::RecvNotice_UpdateContractTrackerTable(gmContractsUI*,const CContractTrackerTable*)
    public void RecvNotice_UpdateContractTrackerTable(ACBindings.CContractTrackerTable* contractTrackerTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, ACBindings.CContractTrackerTable*, void>)0x0049A650)(ref this, contractTrackerTable);
    // void __thiscall gmContractsUI::RecvNotice_UpdateContractTracker(gmContractsUI*,const CContractTracker*,int)
    public void RecvNotice_UpdateContractTracker(ACBindings.CContractTracker* contractTracker, int bDeleteContract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, ACBindings.CContractTracker*, int, void>)0x0049A670)(ref this, contractTracker, bDeleteContract);
    // UIElementMessageListenResult __thiscall gmContractsUI::ListenToElementMessage(gmContractsUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0049A690)(ref this, i_rMsg);
    // void __thiscall gmContractsUI::OnVisibilityChanged(gmContractsUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmContractsUI, byte, void>)0x0049A7B0)(ref this, i_bVisible);
}

