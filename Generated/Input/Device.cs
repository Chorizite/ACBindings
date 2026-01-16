namespace ACBindings.Internal;


/// <summary>Manages the application’s window and rendering pipeline, processes user input, handles fullscreen toggles and display preferences, and provides utilities such as screenshot capture and cursor management.</summary>
public unsafe struct Device
{
    // Statics
    public static byte* m_bSysKeysEnabled = (byte*)0x00818B01;
    public static byte* m_bAllowFullScreenMode = (byte*)0x00818B02;
    public static uint* m_nForcedWidth = (uint*)0x00818B04;
    public static uint* m_nForcedHeight = (uint*)0x00818B08;
    public static byte* m_fMouseIsShown = (byte*)0x00818B0C;
    public static ACBindings.Internal.DisplayPrefs* m_DisplayPrefs = (ACBindings.Internal.DisplayPrefs*)0x00818B64;
    public static byte* m_bIsDone = (byte*)0x00838194;
    public static byte* m_bIsReady = (byte*)0x00838195;
    public static byte* m_bIsInitialized = (byte*)0x00838196;
    public static byte* m_bIsActiveApp = (byte*)0x00838197;
    public static byte* m_bIsWithinEventLoop = (byte*)0x00838198;
    public static byte* m_bToggleFullScreenMode = (byte*)0x00838199;
    public static uint* m_nOSVersion = (uint*)0x0083819C;
    public static byte* m_bUseForcedResolution = (byte*)0x008381A0;
    public static int** m_hWnd = (int**)0x008381A4;
    public static byte* m_bIsChildWnd = (byte*)0x008381A8;
    public static ACBindings.Internal.Device.DeviceDialogBoxGateway** sm_pDeviceDialogGateway = (ACBindings.Internal.Device.DeviceDialogBoxGateway**)0x008381AC;

    // Child Types

    /// <summary>Represents a gateway that extends DialogBoxGateway to manage dialog box reporting threads within the Device system, handling the initiation and completion of dialog interactions through native window messages.</summary>
    public unsafe struct DeviceDialogBoxGateway
    {
        // Base Classes
        public ACBindings.Internal.DialogBoxGateway BaseClass_DialogBoxGateway; // ACBindings.Internal.DialogBoxGateway

        // Child Types
        public unsafe struct DeviceDialogBoxGateway_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, void> Device; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxBegin; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxEnd; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte> ReportThread_OnDialogBoxBegin; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte, void> ReportThread_OnDialogBoxEnd; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte> DialogThread_OnDialogBoxBegin; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte, void> DialogThread_OnDialogBoxEnd; // function pointer

            // Methods
        }

        // Generated Constructor
        public DeviceDialogBoxGateway() {
            _ConstructorInternal();
        }

        // Methods

        /// <summary>Sends a minimize system command to the device window when rendering is ready, signalling that the dialog box has started.
        /// <code>Offset: 0x004391A0
        /// bool __thiscall Device::DeviceDialogBoxGateway::ReportThread_OnDialogBoxBegin(Device::DeviceDialogBoxGateway*)</code>
        /// </summary>
        /// <returns>True if the message was sent (i.e., rendering device and flag were set); otherwise false.</returns>
        public byte ReportThread_OnDialogBoxBegin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Device.DeviceDialogBoxGateway, byte>)0x004391A0)(ref this);

        /// <summary>Restores the device's main window when the reporting thread ends, if the context flag is true.
        /// <code>Offset: 0x004391E0
        /// void __thiscall Device::DeviceDialogBoxGateway::ReportThread_OnDialogBoxEnd(Device::DeviceDialogBoxGateway*,bool)</code>
        /// </summary>
        /// <param name="context">True to send a WM_SYSCOMMAND/SC_RESTORE message; false results in no action.</param>
        public void ReportThread_OnDialogBoxEnd(byte context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Device.DeviceDialogBoxGateway, byte, void>)0x004391E0)(ref this, context);

        /// <summary>Initializes a new DeviceDialogBoxGateway instance by invoking the base DialogBoxGateway constructor and assigning the correct virtual function table.
        /// <code>Offset: 0x00439210
        /// void __thiscall Device::DeviceDialogBoxGateway::DeviceDialogBoxGateway(Device::DeviceDialogBoxGateway*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Device.DeviceDialogBoxGateway, void>)0x00439210)(ref this);
    }

    // Methods

    /// <summary>Flags the device as finished so subsequent operations recognize completion.
    /// <code>Offset: 0x00439230
    /// void __cdecl Device::Done()</code>
    /// </summary>
    public static void Done() => ((delegate* unmanaged[Cdecl]<void>)0x00439230)();

    /// <summary>Forwards a Windows message to the global input manager if it is initialized, indicating whether the message was processed.
    /// <code>Offset: 0x00439240
    /// int __cdecl Device::ForwardToInputManager(HWND__*,unsigned int,unsigned int,int,bool*)</code>
    /// </summary>
    /// <param name="hWindow">Handle to the window receiving the message.</param>
    /// <param name="message">Identifier of the Windows message.</param>
    /// <param name="wParam">Additional message information typically used for message-specific data.</param>
    /// <param name="lParam">Message parameter containing low-order and high-order words with message data.</param>
    /// <param name="o_fHandled">Output flag set to true if the input manager handled the message; otherwise false.</param>
    /// <returns>Result code from the input manager, or zero when forwarding is not performed because the system is uninitialized.</returns>
    public static int ForwardToInputManager(int* hWindow, uint message, uint wParam, int lParam, byte* o_fHandled) => ((delegate* unmanaged[Cdecl]<int*, uint, uint, int, byte*, int>)0x00439240)(hWindow, message, wParam, lParam, o_fHandled);

    /// <summary>Ensures the application consumes minimal CPU while inactive by sleeping until a 100‑millisecond frame interval has elapsed, then updates the timestamp.
    /// <code>Offset: 0x004392B0
    /// void __cdecl Device::DoFrameSleep()</code>
    /// </summary>
    public static void DoFrameSleep() => ((delegate* unmanaged[Cdecl]<void>)0x004392B0)();

    /// <summary>Activates the device application by setting its active flag and notifying the ICIDM subsystem when not already active.
    /// <code>Offset: 0x004392F0
    /// void __cdecl Device::Activate()</code>
    /// </summary>
    public static void Activate() => ((delegate* unmanaged[Cdecl]<void>)0x004392F0)();

    /// <summary>Deactivates the current application mode, clearing the active flag, notifying any registered ICIDM handler, and resetting the mouse cursor to default when rendering is unavailable.
    /// <code>Offset: 0x00439320
    /// void __cdecl Device::Deactivate()</code>
    /// </summary>
    public static void Deactivate() => ((delegate* unmanaged[Cdecl]<void>)0x00439320)();

    /// <summary>Loads the device's stored display preferences into a RenderDevicePresentation structure, applying any forced resolution or fullscreen constraints.
    /// <code>Offset: 0x00439370
    /// bool __cdecl Device::LoadDisplayPreferences(RenderDevicePresentation*)</code>
    /// </summary>
    /// <param name="Presentation">Structure to receive width, height, fullscreen flag, refresh rate, triple buffering, sync-to-refresh, and antialiasing settings. May be overridden by forced resolution or full-screen restrictions.</param>
    /// <returns>True if the display preferences were successfully loaded; false if the stored resolution is too low for a valid display mode.</returns>
    public static byte LoadDisplayPreferences(ACBindings.Internal.RenderDevicePresentation* Presentation) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderDevicePresentation*, byte>)0x00439370)(Presentation);

    /// <summary>Shuts down the graphics subsystem, clearing active application state and restoring the default cursor when necessary. Calls SceneTool::Shutdown() and Render::ShutdownRenderingSystem(). Returns true on completion.
    /// <code>Offset: 0x00439400
    /// bool __cdecl Device::ShutdownGraphicsEngine()</code>
    /// </summary>
    /// <returns>true upon successful shutdown.</returns>
    public static byte ShutdownGraphicsEngine() => ((delegate* unmanaged[Cdecl]<byte>)0x00439400)();

    /// <summary>Returns a RenderSurface representing a screenshot of the device's client area, creating a new surface if necessary.
    /// <code>Offset: 0x00439460
    /// RenderSurface* __cdecl Device::GetScreenshotSurface()</code>
    /// </summary>
    /// <returns>A pointer to the captured RenderSurface, or null if rendering is unavailable.</returns>
    public static ACBindings.Internal.RenderSurface* GetScreenshotSurface() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderSurface*>)0x00439460)();

    /// <summary>Reports an error message and optionally marks the device as finished when the error is fatal.
    /// <code>Offset: 0x00439590
    /// int __cdecl Device::Error(const char**,const char**,char)</code>
    /// </summary>
    /// <param name="a1">Pointer to a string containing the detailed error description.</param>
    /// <param name="a2">Pointer to a string identifying the error type or context.</param>
    /// <param name="a3">Non‑zero if the error is fatal; zero indicates non‑fatal.</param>
    /// <returns>Always returns 0 as a status code.</returns>
    public static int Error(sbyte** a1, sbyte** a2, sbyte a3) => ((delegate* unmanaged[Cdecl]<sbyte**, sbyte**, sbyte, int>)0x00439590)(a1, a2, a3);

    /// <summary>Sets the device window's cursor to the supplied icon, falling back to the standard arrow cursor when none is given.
    /// <code>Offset: 0x004395D0
    /// bool __cdecl Device::SetCursorFromIcon(HICON__*)</code>
    /// </summary>
    /// <param name="hNewIcon">Handle to an icon structure used as the new cursor; if null, the default system arrow cursor is employed.</param>
    /// <returns>True after updating the cursor. The function always returns true in its current implementation.</returns>
    public static byte SetCursorFromIcon(int* hNewIcon) => ((delegate* unmanaged[Cdecl]<int*, byte>)0x004395D0)(hNewIcon);

    /// <summary>Sets the visibility of the mouse cursor, updating internal state only when a change occurs.
    /// <code>Offset: 0x00439620
    /// void __cdecl Device::ShowCursor(bool)</code>
    /// </summary>
    /// <param name="show">True to display the cursor; false to hide it.</param>
    public static void ShowCursor(byte show) => ((delegate* unmanaged[Cdecl]<byte, void>)0x00439620)(show);

    /// <summary>Handles window messages for the device, managing focus, activation, fullscreen mode, keyboard and mouse events, and dispatching input to internal managers or the default procedure.
    /// <code>Offset: 0x00439860
    /// int __stdcall Device::WndProc(HWND__*,unsigned int,unsigned int,int)</code>
    /// </summary>
    /// <param name="hWindow">Handle of the window that received the message.</param>
    /// <param name="message">Identifier of the Windows message being processed.</param>
    /// <param name="wParam">Additional message information supplied by the operating system.</param>
    /// <param name="lParam">Further data associated with the message.</param>
    /// <returns>Result returned from internal handling if the message was processed; otherwise the result returned by DefWindowProcA.</returns>
    public static int WndProc(int* hWindow, uint message, uint wParam, int lParam) => ((delegate* unmanaged[Stdcall]<int*, uint, uint, int, int>)0x00439860)(hWindow, message, wParam, lParam);

    /// <summary>Copies a string from the provided memory block into the system clipboard, handling Unicode or ANSI formats based on OS version, and manages the reference count of the memory block.
    /// <code>Offset: 0x00439D50
    /// LONG __cdecl Device::SendStringToClipboard(char*)</code>
    /// </summary>
    /// <param name="hMem">Pointer to the memory block containing the string; the block includes a length header and a reference counter preceding the data.</param>
    /// <returns>Returns the updated reference count after decrementing. If the count reaches zero, the memory block is released through its destructor callback.</returns>
    public static int SendStringToClipboard(sbyte* hMem) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00439D50)(hMem);

    /// <summary>Processes pending window messages, translating accelerators and dispatching them to the appropriate handlers. If a fullscreen toggle flag is set, updates the display mode accordingly before clearing the flag.
    /// <code>Offset: 0x00439E50
    /// bool __cdecl Device::DoEventLoop()</code>
    /// </summary>
    /// <returns>True when the device has been marked as finished; otherwise false.</returns>
    public static byte DoEventLoop() => ((delegate* unmanaged[Cdecl]<byte>)0x00439E50)();

    /// <summary>Sets the current cursor to an icon created from a RenderSurface image at the specified hotspot coordinates.
    /// <code>Offset: 0x00439F30
    /// bool __cdecl Device::SetCursorFromImage(const unsigned int,const unsigned int,const RenderSurface*)</code>
    /// </summary>
    /// <param name="xHotSpot">The horizontal pixel offset of the cursor's active point relative to the image.</param>
    /// <param name="yHotSpot">The vertical pixel offset of the cursor's active point relative to the image.</param>
    /// <param name="image">Pointer to a RenderSurface that provides the bitmap data for the cursor icon.</param>
    /// <returns>True if the cursor was successfully created and set; otherwise false.</returns>
    public static byte SetCursorFromImage(uint xHotSpot, uint yHotSpot, ACBindings.Internal.RenderSurface* image) => ((delegate* unmanaged[Cdecl]<uint, uint, ACBindings.Internal.RenderSurface*, byte>)0x00439F30)(xHotSpot, yHotSpot, image);

    /// <summary>Shuts down the device, unregistering commands, releasing graphics resources, destroying the main window, and resetting internal state.
    /// <code>Offset: 0x0043A370
    /// void __cdecl Device::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x0043A370)();

    /// <summary>Updates the device's presentation settings by loading user preferences, restarting the rendering system with new configuration, and repositioning the window accordingly.
    /// <code>Offset: 0x0043A510
    /// bool __cdecl Device::ChangePresentation()</code>
    /// </summary>
    /// <returns>True if the rendering system was successfully restarted; otherwise false (e.g., missing renderer or failed to load preferences).</returns>
    public static byte ChangePresentation() => ((delegate* unmanaged[Cdecl]<byte>)0x0043A510)();

    /// <summary>Saves the current render surface to disk as a JPG and returns the filename through an output argument.
    /// <code>Offset: 0x0043A780
    /// char __cdecl Device::SaveScreenshot(int*)</code>
    /// </summary>
    /// <param name="a1">Pointer to receive the full path of the saved screenshot file when the operation succeeds.</param>
    /// <returns>Non‑zero value if the screenshot was successfully written; zero otherwise.</returns>
    public static sbyte SaveScreenshot(int* a1) => ((delegate* unmanaged[Cdecl]<int*, sbyte>)0x0043A780)(a1);

    /// <summary>Displays a warning dialog indicating that a 16‑bit device is being used and may not be supported fully.
    /// <code>Offset: 0x0043A8F0
    /// void __cdecl Device::Show16BitWarning()</code>
    /// </summary>
    public static void Show16BitWarning() => ((delegate* unmanaged[Cdecl]<void>)0x0043A8F0)();

    /// <summary>Enables or disables a forced display resolution, updating internal settings and applying changes through the rendering system.
    /// <code>Offset: 0x0043A990
    /// void __cdecl Device::ForceDisplayResolution(const bool,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="bEnable">Whether to enable forced resolution; if false, restores default preferences.</param>
    /// <param name="nWidth">The desired width in pixels for forced resolution.</param>
    /// <param name="nHeight">The desired height in pixels for forced resolution.</param>
    public static void ForceDisplayResolution(byte bEnable, uint nWidth, uint nHeight) => ((delegate* unmanaged[Cdecl]<byte, uint, uint, void>)0x0043A990)(bEnable, nWidth, nHeight);

    /// <summary>Forces the display resolution through a console command, optionally setting new width and height or restoring previous forced values.
    /// <code>Offset: 0x0043AA70
    /// char __cdecl Device::ConsoleCommand_ForceDisplayResolution(char***)</code>
    /// </summary>
    /// <param name="a1">Array of argument strings provided by the console; if two numeric arguments are supplied they are interpreted as width and height.</param>
    /// <returns>Non‑zero on success, zero on failure (e.g., invalid arguments).</returns>
    public static sbyte ConsoleCommand_ForceDisplayResolution(sbyte*** a1) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x0043AA70)(a1);

    /// <summary>Sets the device's allowance of full‑screen mode and updates rendering configuration when disabling it under certain conditions.
    /// <code>Offset: 0x0043AB10
    /// void __cdecl Device::AllowFullScreenMode(const bool)</code>
    /// </summary>
    /// <param name="Allow">True to enable full‑screen support; false to disable it.</param>
    public static void AllowFullScreenMode(byte Allow) => ((delegate* unmanaged[Cdecl]<byte, void>)0x0043AB10)(Allow);

    /// <summary>Retrieves a UTF‑16 string from the system clipboard and stores it in the device’s internal string buffer.
    /// <code>Offset: 0x0043AB50
    /// bool Device::GetStringFromClipboard()</code>
    /// </summary>
    /// <returns>True if text data was present on the clipboard and was successfully extracted; otherwise, false.</returns>
    public static byte GetStringFromClipboard() => ((delegate* unmanaged[Cdecl]<byte>)0x0043AB50)();

    /// <summary>Initializes the graphics engine with the specified screen size and mode, loading display preferences and configuring the rendering device.
    /// <code>Offset: 0x0043AC60
    /// bool __cdecl Device::StartupGraphicsEngine(int,int,bool)</code>
    /// </summary>
    /// <param name="nWidth">The desired width of the render window in pixels.</param>
    /// <param name="nHeight">The desired height of the render window in pixels.</param>
    /// <param name="bWindowed">True to run in a windowed mode; false for full‑screen.</param>
    /// <returns>True if initialization succeeds; otherwise, false (or exits if an unsupported color depth is detected).</returns>
    public static byte StartupGraphicsEngine(int nWidth, int nHeight, byte bWindowed) => ((delegate* unmanaged[Cdecl]<int, int, byte, byte>)0x0043AC60)(nWidth, nHeight, bWindowed);

    /// <summary>Initializes the device’s rendering window with specified width, height and mode.
    /// <code>Offset: 0x0043AD90
    /// bool __cdecl Device::InitWindow(int,int,bool)</code>
    /// </summary>
    /// <param name="width">The desired width of the window in pixels.</param>
    /// <param name="height">The desired height of the window in pixels.</param>
    /// <param name="bWindowed">If true creates a windowed mode; otherwise full‑screen.</param>
    /// <returns>True if graphics engine startup succeeded and the device is ready; false on failure.</returns>
    public static byte InitWindow(int width, int height, byte bWindowed) => ((delegate* unmanaged[Cdecl]<int, int, byte, byte>)0x0043AD90)(width, height, bWindowed);

    /// <summary>Initializes display preferences by querying the renderer for supported modes, building lists for resolution, full‑screen mode, refresh rate, and vertical sync, then registers these variables with a global registry.
    /// <code>Offset: 0x0043B2D0
    /// bool __cdecl Device::InitializeDisplayPreferences()</code>
    /// </summary>
    /// <returns>True if initialization succeeded; otherwise false (e.g., when no renderer is available).</returns>
    public static byte InitializeDisplayPreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x0043B2D0)();

    /// <summary>Initializes Direct3D rendering, creates the main application window in either windowed or full‑screen mode, and registers console commands for quitting and presentation updates.
    /// <code>Offset: 0x0043BA60
    /// char __cdecl Device::Init(bool,const char**,int,int,char,LPCSTR*)</code>
    /// </summary>
    /// <param name="bWindowed">True to create a windowed application; false selects full‑screen mode if allowed by preferences.</param>
    /// <param name="a2">Pointer to the menu resource name used when registering the window class.</param>
    /// <param name="a3">Reserved for future use; currently ignored.</param>
    /// <param name="a4">Reserved for future use; currently ignored.</param>
    /// <param name="a5">Non‑zero causes the created window to be shown immediately after creation.</param>
    /// <param name="a6">Array of strings that provides the module instance handle, usually containing the executable name.</param>
    /// <returns>1 on success; 0 if initialization fails at any step.</returns>
    public static sbyte Init(byte bWindowed, sbyte** a2, int a3, int a4, sbyte a5, sbyte** a6) => ((delegate* unmanaged[Cdecl]<byte, sbyte**, int, int, sbyte, sbyte**, sbyte>)0x0043BA60)(bWindowed, a2, a3, a4, a5, a6);
}

