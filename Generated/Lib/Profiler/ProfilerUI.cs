namespace ACBindings;

// ProfilerUI
public unsafe struct ProfilerUI : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate
    public ACBindings.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.IInputActionCallback

    // Child Types
    // ProfilerUI_vtbl
    public unsafe struct ProfilerUI_vtbl
    {
        // Members
        public System.IntPtr ProfilerUI_dtor_0; // function pointer

        // Methods
    }

    // Members
    public byte m_IsActive;
    public byte m_WantActivate;
    public byte m_WantDeactivate;
    public ACBindings.SmartArray__ProfilerUIWindow_ptr m_Windows;
    public uint m_MemoryCountersStatsWindowHandle;
    public uint m_BlockResourcesStatsWindowHandle;
    public uint m_DBObjStatsWindowHandle;
    public uint m_DPVSStatsWindowHandle;
    public uint m_MemoryProbeStatsWindowHandle;
    public ACBindings.QuickWindow* m_pToggleToolbarWindow;
    public ACBindings.QuickWindow* m_pStatsToolbarWindow;
    public ACBindings.QuickWindow* m_pCategoryWindow;
    public ACBindings.SmartArray__QuickButton_ptr m_ToolbarButtons;
    public ACBindings.SmartArray__QuickButton_ptr m_CategoryButtons;
    public uint m_nGraphicsQualityLevel;
    public ACBindings.SmartArray__BudgetStatItem m_budgetStatArray;
    public uint m_CurrentYPixel;
    public uint m_nSystemMemoryAllocated;
    public uint m_nPeakSystemMemoryAllocated;
    public uint m_nVirtualMemoryReserved;
    public uint m_nPeakVirtualMemoryReserved;
    public ACBindings.SmartArray__ProfilerDBObjStat m_DBObjStats;
    public ACBindings.OSSpecificProfilerUIInfo* m_pOSSpecificProfiler;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ProfilerUI::RegisterInputMaps(ProfilerUI*)
    public void RegisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005D9A60)(ref this);
    // void __thiscall ProfilerUI::UpdateBudgetStat(ProfilerUI*,const unsigned int,const unsigned int)
    public void UpdateBudgetStat(uint i_index, uint i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, uint, uint, void>)0x005D9AB0)(ref this, i_index, i_value);
    // void __thiscall ProfilerUI::RepositionWindows(ProfilerUI*)
    public void RepositionWindows() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005D9B90)(ref this);
    // bool __thiscall ProfilerUI::InputLeftMouseCategoryButtonPressed(ProfilerUI*,const int,const int)
    public byte InputLeftMouseCategoryButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, int, int, byte>)0x005D9C70)(ref this, X, Y);
    // bool __thiscall ProfilerUI::InputLeftMouseToolbarButtonPressed(ProfilerUI*,const int,const int)
    public byte InputLeftMouseToolbarButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, int, int, byte>)0x005D9CC0)(ref this, X, Y);
    // void __thiscall ProfilerUI::UpdateDBObjStats(ProfilerUI*)
    public void UpdateDBObjStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005D9D10)(ref this);
    // void __thiscall ProfilerUI::UpdateStats(ProfilerUI*)
    public void UpdateStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DA190)(ref this);
    // void __thiscall ProfilerUI::RemoveWindow(ProfilerUI*,const unsigned int)
    public void RemoveWindow(uint WindowHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, uint, void>)0x005DA250)(ref this, WindowHandle);
    // void __thiscall ProfilerUI::RemoveCategoryWindow(ProfilerUI*,const ProfilerTypes::CategoryType)
    public void RemoveCategoryWindow(ACBindings.ProfilerTypes.CategoryType Category) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, ACBindings.ProfilerTypes.CategoryType, void>)0x005DA4E0)(ref this, Category);
    // void __thiscall ProfilerUI::UpdateToolbarButtonStates(ProfilerUI*)
    public void UpdateToolbarButtonStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DA530)(ref this);
    // void __thiscall ProfilerUI::PrintBudgetStat(ProfilerUI*,const unsigned int,QuickWindow*)
    public void PrintBudgetStat(uint i_index, ACBindings.QuickWindow* i_pQuickWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, uint, ACBindings.QuickWindow*, void>)0x005DA750)(ref this, i_index, i_pQuickWindow);
    // void __thiscall ProfilerUI::Think(ProfilerUI*)
    public void Think() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DA8A0)(ref this);
    // void __thiscall ProfilerUI::Render(ProfilerUI*)
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DA8F0)(ref this);
    // bool __thiscall ProfilerUI::AddWindow(ProfilerUI*,const ProfilerTypes::CategoryType,const RGBAColor*,const bool,const unsigned int,const unsigned int,const unsigned int,const unsigned int,unsigned int*)
    public byte AddWindow(ACBindings.ProfilerTypes.CategoryType Category, ACBindings.RGBAColor* BackgroundColor, byte AutoPositionWindow, uint X, uint Y, uint Width, uint Height, uint* o_WindowHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, ACBindings.ProfilerTypes.CategoryType, ACBindings.RGBAColor*, byte, uint, uint, uint, uint, uint*, byte>)0x005DC7B0)(ref this, Category, BackgroundColor, AutoPositionWindow, X, Y, Width, Height, o_WindowHandle);
    // void __thiscall ProfilerUI::RebuildToolbarButtons(ProfilerUI*)
    public void RebuildToolbarButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DC890)(ref this);
    // void __thiscall ProfilerUI::RebuildCategoryWindow(ProfilerUI*)
    public void RebuildCategoryWindow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DCE40)(ref this);
    // void __thiscall ProfilerUI::~ProfilerUI(ProfilerUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DD3D0)(ref this);
    // bool __thiscall ProfilerUI::CreateToolbarWindows(ProfilerUI*)
    public byte CreateToolbarWindows() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte>)0x005DD700)(ref this);
    // bool __thiscall ProfilerUI::CreateCategoryWindow(ProfilerUI*)
    public byte CreateCategoryWindow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte>)0x005DD7D0)(ref this);
    // void __thiscall ProfilerUI::AddCategoryWindow(ProfilerUI*,const ProfilerTypes::CategoryType)
    public void AddCategoryWindow(ACBindings.ProfilerTypes.CategoryType Category) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, ACBindings.ProfilerTypes.CategoryType, void>)0x005DD850)(ref this, Category);
    // void __thiscall ProfilerUI::ShowMemoryCountersStatsWindow(ProfilerUI*,const bool)
    public void ShowMemoryCountersStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte, void>)0x005DD8F0)(ref this, Show);
    // void __thiscall ProfilerUI::ShowBlockResourcesStatsWindow(ProfilerUI*,const bool)
    public void ShowBlockResourcesStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte, void>)0x005DD970)(ref this, Show);
    // void __thiscall ProfilerUI::ShowDBObjStatsWindow(ProfilerUI*,const bool)
    public void ShowDBObjStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte, void>)0x005DD9F0)(ref this, Show);
    // void __thiscall ProfilerUI::ShowMemoryProbeStatsWindow(ProfilerUI*,const bool)
    public void ShowMemoryProbeStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte, void>)0x005DDA70)(ref this, Show);
    // bool __thiscall ProfilerUI::InputLeftMouseCategoryButtonReleased(ProfilerUI*,const int,const int)
    public byte InputLeftMouseCategoryButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, int, int, byte>)0x005DDAF0)(ref this, X, Y);
    // bool __thiscall ProfilerUI::InputLeftMouseToolbarButtonReleased(ProfilerUI*,const int,const int)
    public byte InputLeftMouseToolbarButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, int, int, byte>)0x005DDBB0)(ref this, X, Y);
    // void __thiscall ProfilerUI::InitDBObjStats(ProfilerUI*)
    public void InitDBObjStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, void>)0x005DDE50)(ref this);
    // bool __thiscall ProfilerUI::OnAction(ProfilerUI*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, ACBindings.InputEvent*, byte>)0x005DE030)(ref this, i_evt);
    // void __thiscall ProfilerUI::AddBudgetStat(ProfilerUI*,const BudgetStatInfo*)
    public void AddBudgetStat(ACBindings.BudgetStatInfo* i_statInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, ACBindings.BudgetStatInfo*, void>)0x005DE0B0)(ref this, i_statInfo);
    // bool __thiscall ProfilerUI::Init(ProfilerUI*)
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProfilerUI, byte>)0x005DE2C0)(ref this);
    // TResult* __cdecl ProfilerUI::Create(TResult*,ProfilerUI**)
    public static ACBindings.TResult* Create(ACBindings.TResult* result, ACBindings.ProfilerUI** pOutObject) => ((delegate* unmanaged[Cdecl]<ACBindings.TResult*, ACBindings.ProfilerUI**, ACBindings.TResult*>)0x005DE320)(result, pOutObject);
}

