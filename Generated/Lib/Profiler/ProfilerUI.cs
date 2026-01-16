namespace ACBindings.Internal;


/// <summary>Handles in‑game profiling UI, creating and arranging QuickWindow instances for various statistic categories, rendering live data such as graphics usage and memory counters, and managing user input via IInputActionCallback.</summary>
/// <remarks>Maintains collections of windows, toolbar buttons, and category buttons while tracking graphics quality level and system resource usage to provide developers with real‑time performance insights.</remarks>
public unsafe struct ProfilerUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate
    public ACBindings.Internal.IInputActionCallback BaseClass_IInputActionCallback; // ACBindings.Internal.IInputActionCallback

    // Child Types
    public unsafe struct ProfilerUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProfilerUI*, void> ProfilerUI_dtor_0; // function pointer

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

    /// <summary>Registers the profiler UI’s input maps with the global input manager, enabling or disabling callbacks based on the object’s active state.
    /// <code>Offset: 0x005D9A60
    /// void __thiscall ProfilerUI::RegisterInputMaps(ProfilerUI*)</code>
    /// </summary>
    public void RegisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005D9A60)(ref this);

    /// <summary>Updates a budget statistic entry identified by index with a new value and assigns a status that reflects how the value compares to predefined thresholds based on graphics quality settings.
    /// <code>Offset: 0x005D9AB0
    /// void __thiscall ProfilerUI::UpdateBudgetStat(ProfilerUI*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="i_index">Index of the budget stat in the internal array.</param>
    /// <param name="i_value">New numeric value for the selected stat.</param>
    public void UpdateBudgetStat(uint i_index, uint i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, uint, uint, void>)0x005D9AB0)(ref this, i_index, i_value);

    /// <summary>Arranges all profiler windows automatically within the current display area, positioning each QuickWindow with appropriate margins and column limits.
    /// <code>Offset: 0x005D9B90
    /// void __thiscall ProfilerUI::RepositionWindows(ProfilerUI*)</code>
    /// </summary>
    public void RepositionWindows() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005D9B90)(ref this);

    /// <summary>Determines whether the left mouse button was pressed over any category button within the profiler UI.
    /// <code>Offset: 0x005D9C70
    /// bool __thiscall ProfilerUI::InputLeftMouseCategoryButtonPressed(ProfilerUI*,const int,const int)</code>
    /// </summary>
    /// <param name="X">The x-coordinate of the mouse event.</param>
    /// <param name="Y">The y-coordinate of the mouse event.</param>
    /// <returns>True if at least one category button registers a left‑mouse press; otherwise, false.</returns>
    public byte InputLeftMouseCategoryButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005D9C70)(ref this, X, Y);

    /// <summary>Determines whether a left‑mouse click at the specified screen coordinates activates any toolbar button.
    /// <code>Offset: 0x005D9CC0
    /// bool __thiscall ProfilerUI::InputLeftMouseToolbarButtonPressed(ProfilerUI*,const int,const int)</code>
    /// </summary>
    /// <param name="X">The X coordinate of the mouse click.</param>
    /// <param name="Y">The Y coordinate of the mouse click.</param>
    /// <returns>True if one of the profiler UI’s toolbar buttons reports that it was pressed; otherwise, false.</returns>
    public byte InputLeftMouseToolbarButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005D9CC0)(ref this, X, Y);

    /// <summary>Refreshes database‑object statistics for each tracked type by comparing cache counts with the stored values, updating active and free counters and recording timestamps when changes are detected.
    /// <code>Offset: 0x005D9D10
    /// void __thiscall ProfilerUI::UpdateDBObjStats(ProfilerUI*)</code>
    /// </summary>
    public void UpdateDBObjStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005D9D10)(ref this);

    /// <summary>Refreshes profiler statistics such as system memory, virtual memory, GPU resource usage, texture and mesh allocations, triangle counts, and surface changes, while also updating OS‑specific information if available.
    /// <code>Offset: 0x005DA190
    /// void __thiscall ProfilerUI::UpdateStats(ProfilerUI*)</code>
    /// </summary>
    public void UpdateStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA190)(ref this);

    /// <summary>Removes the profiler UI window identified by the specified handle, releasing its QuickWindow reference, deleting the window object, updating the windows list, and reordering remaining windows.
    /// <code>Offset: 0x005DA250
    /// void __thiscall ProfilerUI::RemoveWindow(ProfilerUI*,const unsigned int)</code>
    /// </summary>
    /// <param name="WindowHandle">The unique identifier of the window to be removed from the ProfilerUI's collection.</param>
    public void RemoveWindow(uint WindowHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, uint, void>)0x005DA250)(ref this, WindowHandle);

    /// <summary>Removes the first profiler window whose category matches the given type, unless the category is 6, which is excluded from removal.
    /// <code>Offset: 0x005DA4E0
    /// void __thiscall ProfilerUI::RemoveCategoryWindow(ProfilerUI*,const ProfilerTypes::CategoryType)</code>
    /// </summary>
    /// <param name="Category">The category of the window to remove.</param>
    public void RemoveCategoryWindow(ACBindings.Internal.ProfilerTypes.CategoryType Category) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.ProfilerTypes.CategoryType, void>)0x005DA4E0)(ref this, Category);

    /// <summary>Updates toolbar buttons to match current profiling settings, enabling or disabling each button according to configuration values such as graphics quality level, wireframe mode, delayed alpha mask, and primitive drawing options.
    /// <code>Offset: 0x005DA530
    /// void __thiscall ProfilerUI::UpdateToolbarButtonStates(ProfilerUI*)</code>
    /// </summary>
    public void UpdateToolbarButtonStates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA530)(ref this);

    /// <summary>Prints a budget statistic entry to the supplied QuickWindow, rendering its name and value formatted as MB for memory statistics or an integer otherwise, then advances the internal vertical position.
    /// <code>Offset: 0x005DA750
    /// void __thiscall ProfilerUI::PrintBudgetStat(ProfilerUI*,const unsigned int,QuickWindow*)</code>
    /// </summary>
    /// <param name="i_index">Index of the budget stat within the ProfilerUI's array to display.</param>
    /// <param name="i_pQuickWindow">The QuickWindow where the statistic text will be rendered.</param>
    public void PrintBudgetStat(uint i_index, ACBindings.Internal.QuickWindow* i_pQuickWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, uint, ACBindings.Internal.QuickWindow*, void>)0x005DA750)(ref this, i_index, i_pQuickWindow);

    /// <summary>Handles activation or deactivation requests for the profiler UI, registers input maps when necessary, and updates graphics quality level, statistics, and toolbar button states while active.
    /// <code>Offset: 0x005DA8A0
    /// void __thiscall ProfilerUI::Think(ProfilerUI*)</code>
    /// </summary>
    public void Think() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA8A0)(ref this);

    /// <summary>Renders the profiler user interface, drawing all active windows and toolbar elements with current statistics such as memory usage, rendering counts, and database object information.
    /// <code>Offset: 0x005DA8F0
    /// void __thiscall ProfilerUI::Render(ProfilerUI*)</code>
    /// </summary>
    /// <param name="this">The ProfilerUI instance to render.</param>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DA8F0)(ref this);

    /// <summary>Create a new profiler UI window with the specified category, background color, positioning flag, and geometry, then register it in the UI's window list.
    /// <code>Offset: 0x005DC7B0
    /// bool __thiscall ProfilerUI::AddWindow(ProfilerUI*,const ProfilerTypes::CategoryType,const RGBAColor*,const bool,const unsigned int,const unsigned int,const unsigned int,const unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="Category">The profiling category that determines the window’s contents or behavior.</param>
    /// <param name="BackgroundColor">Pointer to an RGBAColor struct defining the window’s background color and opacity.</param>
    /// <param name="AutoPositionWindow">If true, the window automatically positions itself relative to other windows; if false, it remains at the supplied coordinates.</param>
    /// <param name="X">Initial horizontal position of the window in pixels.</param>
    /// <param name="Y">Initial vertical position of the window in pixels.</param>
    /// <param name="Width">The width of the window in pixels.</param>
    /// <param name="Height">The height of the window in pixels.</param>
    /// <param name="o_WindowHandle">Output parameter that receives the handle assigned to the newly created window; set to 0 if creation fails.</param>
    /// <returns>True when the window is successfully created and added to the UI; otherwise false.</returns>
    public byte AddWindow(ACBindings.Internal.ProfilerTypes.CategoryType Category, ACBindings.Internal.RGBAColor* BackgroundColor, byte AutoPositionWindow, uint X, uint Y, uint Width, uint Height, uint* o_WindowHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.ProfilerTypes.CategoryType, ACBindings.Internal.RGBAColor*, byte, uint, uint, uint, uint, uint*, byte>)0x005DC7B0)(ref this, Category, BackgroundColor, AutoPositionWindow, X, Y, Width, Height, o_WindowHandle);

    /// <summary>Rebuilds the toolbar buttons for the profiler UI by clearing existing ones and creating new QuickButton instances with proper labels, positions, and visual styling.
    /// <code>Offset: 0x005DC890
    /// void __thiscall ProfilerUI::RebuildToolbarButtons(ProfilerUI*)</code>
    /// </summary>
    public void RebuildToolbarButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DC890)(ref this);

    /// <summary>Rebuilds the profiler’s category window by clearing any existing category buttons and creating a new set of buttons for each available category. The function positions the buttons within the window, applies a standard color scheme, and updates the UI’s internal state to reflect the current selection.
    /// <code>Offset: 0x005DCE40
    /// void __thiscall ProfilerUI::RebuildCategoryWindow(ProfilerUI*)</code>
    /// </summary>
    public void RebuildCategoryWindow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DCE40)(ref this);

    /// <summary>Destroys a ProfilerUI instance, releasing all owned QuickWindow and QuickButton objects, freeing dynamic arrays, deleting OS‑specific profiler data, resetting statistics buffers, and unregistering the input action callback.
    /// <code>Offset: 0x005DD3D0
    /// void __thiscall ProfilerUI::~ProfilerUI(ProfilerUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DD3D0)(ref this);

    /// <summary>Creates the toggle and stats toolbar windows, configures their colors and opacity, and rebuilds the toolbar buttons.
    /// <code>Offset: 0x005DD700
    /// bool __thiscall ProfilerUI::CreateToolbarWindows(ProfilerUI*)</code>
    /// </summary>
    /// <returns>True when both toolbar windows are created successfully; returns false if either creation fails.</returns>
    public byte CreateToolbarWindows() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte>)0x005DD700)(ref this);

    /// <summary>Create a quick window used to display profiling categories, setting its size, position, color, and then rebuilding the category list.
    /// <code>Offset: 0x005DD7D0
    /// bool __thiscall ProfilerUI::CreateCategoryWindow(ProfilerUI*)</code>
    /// </summary>
    /// <returns>True if the window was created successfully; otherwise false.</returns>
    public byte CreateCategoryWindow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte>)0x005DD7D0)(ref this);

    /// <summary>Adds a profiler window for the given category if one is not already present. The window’s appearance—background color and internal handle—is determined by whether the category value is zero or non‑zero.
    /// <code>Offset: 0x005DD850
    /// void __thiscall ProfilerUI::AddCategoryWindow(ProfilerUI*,const ProfilerTypes::CategoryType)</code>
    /// </summary>
    /// <param name="Category">The category identifier for which to add a window; zero indicates the default category.</param>
    public void AddCategoryWindow(ACBindings.Internal.ProfilerTypes.CategoryType Category) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.ProfilerTypes.CategoryType, void>)0x005DD850)(ref this, Category);

    /// <summary>Displays or removes the memory counters statistics window within the profiler UI based on the supplied flag.
    /// <code>Offset: 0x005DD8F0
    /// void __thiscall ProfilerUI::ShowMemoryCountersStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    /// <param name="Show">True to display the window; false to close and delete it.</param>
    public void ShowMemoryCountersStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DD8F0)(ref this, Show);

    /// <summary>Displays or hides the block resources statistics window, creating the window when first shown and removing it when hidden.
    /// <code>Offset: 0x005DD970
    /// void __thiscall ProfilerUI::ShowBlockResourcesStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    /// <param name="Show">True to create/show the window; false to close/remove it.</param>
    public void ShowBlockResourcesStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DD970)(ref this, Show);

    /// <summary>Shows or hides the database object statistics window within the profiler UI. When shown, creates a new window with a predefined background color if one does not already exist; when hidden, removes the existing window.
    /// <code>Offset: 0x005DD9F0
    /// void __thiscall ProfilerUI::ShowDBObjStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    /// <param name="Show">True to display the stats window; false to close and remove it.</param>
    public void ShowDBObjStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DD9F0)(ref this, Show);

    /// <summary>Shows or hides the memory probe statistics window, creating it when first requested.
    /// <code>Offset: 0x005DDA70
    /// void __thiscall ProfilerUI::ShowMemoryProbeStatsWindow(ProfilerUI*,const bool)</code>
    /// </summary>
    /// <param name="Show">Indicates whether to display the memory probe stats window.</param>
    public void ShowMemoryProbeStatsWindow(byte Show) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte, void>)0x005DDA70)(ref this, Show);

    /// <summary>Handles the left‑mouse‑button‑released event on category buttons, toggling the corresponding category window open or closed.
    /// <code>Offset: 0x005DDAF0
    /// bool __thiscall ProfilerUI::InputLeftMouseCategoryButtonReleased(ProfilerUI*,const int,const int)</code>
    /// </summary>
    /// <param name="X">The X coordinate of the mouse release.</param>
    /// <param name="Y">The Y coordinate of the mouse release.</param>
    /// <returns>True if a category button was released and processed; otherwise false.</returns>
    public byte InputLeftMouseCategoryButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005DDAF0)(ref this, X, Y);

    /// <summary>Detects left mouse release on toolbar buttons and triggers actions such as adjusting graphics quality, toggling rendering options, or showing profiler windows.
    /// <code>Offset: 0x005DDBB0
    /// bool __thiscall ProfilerUI::InputLeftMouseToolbarButtonReleased(ProfilerUI*,const int,const int)</code>
    /// </summary>
    /// <param name="X">Horizontal click position in screen coordinates.</param>
    /// <param name="Y">Vertical click position in screen coordinates.</param>
    /// <returns>True if a toolbar button handled the event; otherwise false.</returns>
    public byte InputLeftMouseToolbarButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, int, int, byte>)0x005DDBB0)(ref this, X, Y);

    /// <summary>Rebuilds the profiler’s database‑object statistics list by clearing existing entries and inserting new ones in alphabetical order based on each DB object's type name.
    /// <code>Offset: 0x005DDE50
    /// void __thiscall ProfilerUI::InitDBObjStats(ProfilerUI*)</code>
    /// </summary>
    public void InitDBObjStats() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, void>)0x005DDE50)(ref this);

    /// <summary>Processes profiler UI input events. For left‑mouse button actions (7 or 10) it forwards the mouse coordinates to category and toolbar button handlers; if a toolbar button consumes the event, the function returns true immediately. If the special action code 87 occurs, the function always accepts the event. Otherwise it returns whether a category button handled the input.
    /// <code>Offset: 0x005DE030
    /// bool __thiscall ProfilerUI::OnAction(ProfilerUI*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event containing action code, mouse position, and state flags.</param>
    /// <returns>True if the event was consumed by a toolbar button or is the special toggle action (87); otherwise returns the result of the corresponding category button handler.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.InputEvent*, byte>)0x005DE030)(ref this, i_evt);

    /// <summary>Adds a new budget statistic entry based on the supplied BudgetStatInfo, converting graphic level values to memory or GPU units as indicated by the bIsMem flag and ensuring the internal array expands when necessary.
    /// <code>Offset: 0x005DE0B0
    /// void __thiscall ProfilerUI::AddBudgetStat(ProfilerUI*,const BudgetStatInfo*)</code>
    /// </summary>
    /// <param name="i_statInfo">Information describing the budget stat to add, including its name, per‑graphic‑level values, and whether it represents a memory statistic.</param>
    public void AddBudgetStat(ACBindings.Internal.BudgetStatInfo* i_statInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, ACBindings.Internal.BudgetStatInfo*, void>)0x005DE0B0)(ref this, i_statInfo);

    /// <summary>Initializes the profiler UI by resetting activity state, recording graphics quality level, registering budget statistics, initializing database object statistics, and creating the default category and toolbar windows.
    /// <code>Offset: 0x005DE2C0
    /// bool __thiscall ProfilerUI::Init(ProfilerUI*)</code>
    /// </summary>
    /// <returns>True if both toolbar and category windows were successfully created; otherwise false.</returns>
    public byte Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProfilerUI, byte>)0x005DE2C0)(ref this);

    /// <summary>Creates and initializes a ProfilerUI instance, assigning the created object to the supplied output pointer and updating the result status.
    /// <code>Offset: 0x005DE320
    /// TResult* __cdecl ProfilerUI::Create(TResult*,ProfilerUI**)</code>
    /// </summary>
    /// <param name="result">Structure receiving operation status via its m_val field (0 on success, error code on failure).</param>
    /// <param name="pOutObject">Receives the newly constructed ProfilerUI object if creation succeeds; otherwise set to null.</param>
    /// <returns>The same TResult pointer that was passed in, with m_val indicating success or failure.</returns>
    public static ACBindings.Internal.TResult* Create(ACBindings.Internal.TResult* result, ACBindings.Internal.ProfilerUI** pOutObject) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, ACBindings.Internal.ProfilerUI**, ACBindings.Internal.TResult*>)0x005DE320)(result, pOutObject);
}

