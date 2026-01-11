namespace ACBindings.Internal;

public unsafe struct ProfilerUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct ProfilerUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProfilerUI*, void> ProfilerUI_dtor_0; // function pointer

        // Methods
    }

    // Members
    public byte m_IsActive;
    public byte m_WantActivate;
    public byte m_WantDeactivate;
    public ACBindings.Internal.SmartArray___ProfilerUIWindow_ptr m_Windows;
    public uint m_MemoryCountersStatsWindowHandle;
    public uint m_BlockResourcesStatsWindowHandle;
    public uint m_DBObjStatsWindowHandle;
    public uint m_DPVSStatsWindowHandle;
    public uint m_MemoryProbeStatsWindowHandle;
    public ACBindings.Internal.QuickWindow* m_pToggleToolbarWindow;
    public ACBindings.Internal.QuickWindow* m_pStatsToolbarWindow;
    public ACBindings.Internal.QuickWindow* m_pCategoryWindow;
    public ACBindings.Internal.SmartArray___QuickButton_ptr m_ToolbarButtons;
    public ACBindings.Internal.SmartArray___QuickButton_ptr m_CategoryButtons;
    public uint m_nGraphicsQualityLevel;
    public ACBindings.Internal.SmartArray___BudgetStatItem m_budgetStatArray;
    public uint m_CurrentYPixel;
    public uint m_nSystemMemoryAllocated;
    public uint m_nPeakSystemMemoryAllocated;
    public uint m_nVirtualMemoryReserved;
    public uint m_nPeakVirtualMemoryReserved;
    public ACBindings.Internal.SmartArray___ProfilerDBObjStat m_DBObjStats;
    public ACBindings.Internal.OSSpecificProfilerUIInfo* m_pOSSpecificProfiler;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D9A60
    /// void __thiscall ProfilerUI::RegisterInputMaps(ProfilerUI*)</code>
    /// </summary>
    public void RegisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005D9A60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D9AB0
    /// void __thiscall ProfilerUI::UpdateBudgetStat(ProfilerUI*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void UpdateBudgetStat(uint i_index, uint i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, uint, uint, void>)0x005D9AB0)(ref this, i_index, i_value);

    /// <summary>
    /// <code>Offset: 0x005D9B90
    /// void __thiscall ProfilerUI::RepositionWindows(ProfilerUI*)</code>
    /// </summary>
    public void RepositionWindows() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005D9B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D9C70
    /// bool __thiscall ProfilerUI::InputLeftMouseCategoryButtonPressed(ProfilerUI*,const int,const int)</code>
    /// </summary>
    public byte InputLeftMouseCategoryButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005D9C70)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x005D9CC0
    /// bool __thiscall ProfilerUI::InputLeftMouseToolbarButtonPressed(ProfilerUI*,const int,const int)</code>
    /// </summary>
    public byte InputLeftMouseToolbarButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005D9CC0)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x005D9D10
    /// void __thiscall ProfilerUI::UpdateDBObjStats(ProfilerUI*)</code>
    /// </summary>
    public void UpdateDBObjStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005D9D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DA190
    /// void __thiscall ProfilerUI::UpdateStats(ProfilerUI*)</code>
    /// </summary>
    public void UpdateStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA190)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DA250
    /// void __thiscall ProfilerUI::RemoveWindow(ProfilerUI*,const unsigned int)</code>
    /// </summary>
    public void RemoveWindow(uint WindowHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, uint, void>)0x005DA250)(ref this, WindowHandle);

    /// <summary>
    /// <code>Offset: 0x005DA4E0
    /// void __thiscall ProfilerUI::RemoveCategoryWindow(ProfilerUI*,const ProfilerTypes::CategoryType)</code>
    /// </summary>
    public void RemoveCategoryWindow(ACBindings.Internal.ProfilerTypes.CategoryType Category) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.ProfilerTypes.CategoryType, void>)0x005DA4E0)(ref this, Category);

    /// <summary>
    /// <code>Offset: 0x005DA530
    /// void __thiscall ProfilerUI::UpdateToolbarButtonStates(ProfilerUI*)</code>
    /// </summary>
    public void UpdateToolbarButtonStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA530)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DA750
    /// void __thiscall ProfilerUI::PrintBudgetStat(ProfilerUI*,const unsigned int,QuickWindow*)</code>
    /// </summary>
    public void PrintBudgetStat(uint i_index, ACBindings.Internal.QuickWindow* i_pQuickWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, uint, ACBindings.Internal.QuickWindow*, void>)0x005DA750)(ref this, i_index, i_pQuickWindow);

    /// <summary>
    /// <code>Offset: 0x005DA8A0
    /// void __thiscall ProfilerUI::Think(ProfilerUI*)</code>
    /// </summary>
    public void Think() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA8A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DA8F0
    /// void __thiscall ProfilerUI::Render(ProfilerUI*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA8F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DC7B0
    /// bool __thiscall ProfilerUI::AddWindow(ProfilerUI*,const ProfilerTypes::CategoryType,const RGBAColor*,const bool,const unsigned int,const unsigned int,const unsigned int,const unsigned int,unsigned int*)</code>
    /// </summary>
    public byte AddWindow(ACBindings.Internal.ProfilerTypes.CategoryType Category, ACBindings.Internal.RGBAColor* BackgroundColor, byte AutoPositionWindow, uint X, uint Y, uint Width, uint Height, uint* o_WindowHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.ProfilerTypes.CategoryType, ACBindings.Internal.RGBAColor*, byte, uint, uint, uint, uint, uint*, byte>)0x005DC7B0)(ref this, Category, BackgroundColor, AutoPositionWindow, X, Y, Width, Height, o_WindowHandle);

    /// <summary>
    /// <code>Offset: 0x005DC890
    /// void __thiscall ProfilerUI::RebuildToolbarButtons(ProfilerUI*)</code>
    /// </summary>
    public void RebuildToolbarButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DC890)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DCE40
    /// void __thiscall ProfilerUI::RebuildCategoryWindow(ProfilerUI*)</code>
    /// </summary>
    public void RebuildCategoryWindow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DCE40)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DD3D0
    /// void __thiscall ProfilerUI::~ProfilerUI(ProfilerUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DD3D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DD700
    /// bool __thiscall ProfilerUI::CreateToolbarWindows(ProfilerUI*)</code>
    /// </summary>
    public byte CreateToolbarWindows() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte>)0x005DD700)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DD7D0
    /// bool __thiscall ProfilerUI::CreateCategoryWindow(ProfilerUI*)</code>
    /// </summary>
    public byte CreateCategoryWindow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte>)0x005DD7D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DD850
    /// void __thiscall ProfilerUI::AddCategoryWindow(ProfilerUI*,const ProfilerTypes::CategoryType)</code>
    /// </summary>
    public void AddCategoryWindow(ACBindings.Internal.ProfilerTypes.CategoryType Category) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.ProfilerTypes.CategoryType, void>)0x005DD850)(ref this, Category);

    /// <summary>
    /// <code>Offset: 0x005DD8F0
    /// void __thiscall ProfilerUI::ShowMemoryCountersStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    public void ShowMemoryCountersStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DD8F0)(ref this, Show);

    /// <summary>
    /// <code>Offset: 0x005DD970
    /// void __thiscall ProfilerUI::ShowBlockResourcesStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    public void ShowBlockResourcesStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DD970)(ref this, Show);

    /// <summary>
    /// <code>Offset: 0x005DD9F0
    /// void __thiscall ProfilerUI::ShowDBObjStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    public void ShowDBObjStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DD9F0)(ref this, Show);

    /// <summary>
    /// <code>Offset: 0x005DDA70
    /// void __thiscall ProfilerUI::ShowMemoryProbeStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    public void ShowMemoryProbeStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DDA70)(ref this, Show);

    /// <summary>
    /// <code>Offset: 0x005DDAF0
    /// bool __thiscall ProfilerUI::InputLeftMouseCategoryButtonReleased(ProfilerUI*,const int,const int)</code>
    /// </summary>
    public byte InputLeftMouseCategoryButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005DDAF0)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x005DDBB0
    /// bool __thiscall ProfilerUI::InputLeftMouseToolbarButtonReleased(ProfilerUI*,const int,const int)</code>
    /// </summary>
    public byte InputLeftMouseToolbarButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005DDBB0)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x005DDE50
    /// void __thiscall ProfilerUI::InitDBObjStats(ProfilerUI*)</code>
    /// </summary>
    public void InitDBObjStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DDE50)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE030
    /// bool __thiscall ProfilerUI::OnAction(ProfilerUI*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.InputEvent*, byte>)0x005DE030)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x005DE0B0
    /// void __thiscall ProfilerUI::AddBudgetStat(ProfilerUI*,const BudgetStatInfo*)</code>
    /// </summary>
    public void AddBudgetStat(ACBindings.Internal.BudgetStatInfo* i_statInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.BudgetStatInfo*, void>)0x005DE0B0)(ref this, i_statInfo);

    /// <summary>
    /// <code>Offset: 0x005DE2C0
    /// bool __thiscall ProfilerUI::Init(ProfilerUI*)</code>
    /// </summary>
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte>)0x005DE2C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE320
    /// TResult* __cdecl ProfilerUI::Create(TResult*,ProfilerUI**)</code>
    /// </summary>
    public static ACBindings.Internal.TResult* Create(ACBindings.Internal.TResult* result, ACBindings.Internal.ProfilerUI** pOutObject) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, ACBindings.Internal.ProfilerUI**, ACBindings.Internal.TResult*>)0x005DE320)(result, pOutObject);
}

