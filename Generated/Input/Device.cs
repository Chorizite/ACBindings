namespace ACBindings.Internal;

public unsafe struct Device
{
    // Statics
    public static uint* m_nForcedWidth = (uint*)0x00818B04;
    public static uint* m_nForcedHeight = (uint*)0x00818B08;
    public static ACBindings.Internal.DisplayPrefs* m_DisplayPrefs = (ACBindings.Internal.DisplayPrefs*)0x00818B64;
    public static uint* m_nOSVersion = (uint*)0x0083819C;
    public static ACBindings.Internal.Device.DeviceDialogBoxGateway* sm_pDeviceDialogGateway = (ACBindings.Internal.Device.DeviceDialogBoxGateway*)0x008381AC;

    // Child Types
    public unsafe struct DeviceDialogBoxGateway
    {
        // Base Classes
        public ACBindings.Internal.DialogBoxGateway BaseClass_DialogBoxGateway; // ACBindings.Internal.DialogBoxGateway

        // Child Types
        public unsafe struct DeviceDialogBoxGateway_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, void> Device; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxBegin; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte, ACBindings.Internal.DialogBoxGateway.ThisFunctionHasBeenRenamed> OnDialogBoxEnd; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte> ReportThread_OnDialogBoxBegin; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte, void> ReportThread_OnDialogBoxEnd; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte> DialogThread_OnDialogBoxBegin; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.Device.DeviceDialogBoxGateway*, byte, void> DialogThread_OnDialogBoxEnd; // function pointer

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

        /// <summary>
        /// <code>Offset: 0x004391E0
        /// void __thiscall Device::DeviceDialogBoxGateway::ReportThread_OnDialogBoxEnd(Device::DeviceDialogBoxGateway*,bool)</code>
        /// </summary>
        public void ReportThread_OnDialogBoxEnd(byte context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Device.DeviceDialogBoxGateway, byte, void>)0x004391E0)(ref this, context);

        /// <summary>
        /// <code>Offset: 0x00439210
        /// void __thiscall Device::DeviceDialogBoxGateway::DeviceDialogBoxGateway(Device::DeviceDialogBoxGateway*)</code>
        /// </summary>
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Device.DeviceDialogBoxGateway, void>)0x00439210)(ref this);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00439230
    /// void __cdecl Device::Done()</code>
    /// </summary>
    public static void Done() => ((delegate* unmanaged[Cdecl]<void>)0x00439230)();

    /// <summary>
    /// <code>Offset: 0x00439240
    /// int __cdecl Device::ForwardToInputManager(HWND__*,unsigned int,unsigned int,int,bool*)</code>
    /// </summary>
    public static int ForwardToInputManager(int* hWindow, uint message, uint wParam, int lParam, byte* o_fHandled) => ((delegate* unmanaged[Cdecl]<int*, uint, uint, int, byte*, int>)0x00439240)(hWindow, message, wParam, lParam, o_fHandled);

    /// <summary>
    /// <code>Offset: 0x004392B0
    /// void __cdecl Device::DoFrameSleep()</code>
    /// </summary>
    public static void DoFrameSleep() => ((delegate* unmanaged[Cdecl]<void>)0x004392B0)();

    /// <summary>
    /// <code>Offset: 0x004392F0
    /// void __cdecl Device::Activate()</code>
    /// </summary>
    public static void Activate() => ((delegate* unmanaged[Cdecl]<void>)0x004392F0)();

    /// <summary>
    /// <code>Offset: 0x00439320
    /// void __cdecl Device::Deactivate()</code>
    /// </summary>
    public static void Deactivate() => ((delegate* unmanaged[Cdecl]<void>)0x00439320)();

    /// <summary>
    /// <code>Offset: 0x00439370
    /// bool __cdecl Device::LoadDisplayPreferences(RenderDevicePresentation*)</code>
    /// </summary>
    public static byte LoadDisplayPreferences(ACBindings.Internal.RenderDevicePresentation* Presentation) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderDevicePresentation*, byte>)0x00439370)(Presentation);

    /// <summary>
    /// <code>Offset: 0x00439400
    /// bool __cdecl Device::ShutdownGraphicsEngine()</code>
    /// </summary>
    public static byte ShutdownGraphicsEngine() => ((delegate* unmanaged[Cdecl]<byte>)0x00439400)();

    /// <summary>
    /// <code>Offset: 0x00439460
    /// RenderSurface* __cdecl Device::GetScreenshotSurface()</code>
    /// </summary>
    public static ACBindings.Internal.RenderSurface* GetScreenshotSurface() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderSurface*>)0x00439460)();

    /// <summary>
    /// <code>Offset: 0x00439590
    /// int __cdecl Device::Error(const char**,const char**,char)</code>
    /// </summary>
    public static int Error(sbyte** a1, sbyte** a2, sbyte a3) => ((delegate* unmanaged[Cdecl]<sbyte**, sbyte**, sbyte, int>)0x00439590)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004395D0
    /// bool __cdecl Device::SetCursorFromIcon(HICON__*)</code>
    /// </summary>
    public static byte SetCursorFromIcon(int* hNewIcon) => ((delegate* unmanaged[Cdecl]<int*, byte>)0x004395D0)(hNewIcon);

    /// <summary>
    /// <code>Offset: 0x00439620
    /// void __cdecl Device::ShowCursor(bool)</code>
    /// </summary>
    public static void ShowCursor(byte show) => ((delegate* unmanaged[Cdecl]<byte, void>)0x00439620)(show);

    /// <summary>
    /// <code>Offset: 0x00439860
    /// int __stdcall Device::WndProc(HWND__*,unsigned int,unsigned int,int)</code>
    /// </summary>
    public static int WndProc(int* hWindow, uint message, uint wParam, int lParam) => ((delegate* unmanaged[Stdcall]<int*, uint, uint, int, int>)0x00439860)(hWindow, message, wParam, lParam);

    /// <summary>
    /// <code>Offset: 0x00439D50
    /// LONG __cdecl Device::SendStringToClipboard(char*)</code>
    /// </summary>
    public static int SendStringToClipboard(sbyte* hMem) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00439D50)(hMem);

    /// <summary>
    /// <code>Offset: 0x00439E50
    /// bool __cdecl Device::DoEventLoop()</code>
    /// </summary>
    public static byte DoEventLoop() => ((delegate* unmanaged[Cdecl]<byte>)0x00439E50)();

    /// <summary>
    /// <code>Offset: 0x00439F30
    /// bool __cdecl Device::SetCursorFromImage(const unsigned int,const unsigned int,const RenderSurface*)</code>
    /// </summary>
    public static byte SetCursorFromImage(uint xHotSpot, uint yHotSpot, ACBindings.Internal.RenderSurface* image) => ((delegate* unmanaged[Cdecl]<uint, uint, ACBindings.Internal.RenderSurface*, byte>)0x00439F30)(xHotSpot, yHotSpot, image);

    /// <summary>
    /// <code>Offset: 0x0043A370
    /// void __cdecl Device::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x0043A370)();

    /// <summary>
    /// <code>Offset: 0x0043A510
    /// bool __cdecl Device::ChangePresentation()</code>
    /// </summary>
    public static byte ChangePresentation() => ((delegate* unmanaged[Cdecl]<byte>)0x0043A510)();

    /// <summary>
    /// <code>Offset: 0x0043A780
    /// char __cdecl Device::SaveScreenshot(int*)</code>
    /// </summary>
    public static sbyte SaveScreenshot(int* a1) => ((delegate* unmanaged[Cdecl]<int*, sbyte>)0x0043A780)(a1);

    /// <summary>
    /// <code>Offset: 0x0043A8F0
    /// void __cdecl Device::Show16BitWarning()</code>
    /// </summary>
    public static void Show16BitWarning() => ((delegate* unmanaged[Cdecl]<void>)0x0043A8F0)();

    /// <summary>
    /// <code>Offset: 0x0043A990
    /// void __cdecl Device::ForceDisplayResolution(const bool,const unsigned int,const unsigned int)</code>
    /// </summary>
    public static void ForceDisplayResolution(byte bEnable, uint nWidth, uint nHeight) => ((delegate* unmanaged[Cdecl]<byte, uint, uint, void>)0x0043A990)(bEnable, nWidth, nHeight);

    /// <summary>
    /// <code>Offset: 0x0043AA70
    /// char __cdecl Device::ConsoleCommand_ForceDisplayResolution(char***)</code>
    /// </summary>
    public static sbyte ConsoleCommand_ForceDisplayResolution(sbyte*** a1) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x0043AA70)(a1);

    /// <summary>
    /// <code>Offset: 0x0043AB10
    /// void __cdecl Device::AllowFullScreenMode(const bool)</code>
    /// </summary>
    public static void AllowFullScreenMode(byte Allow) => ((delegate* unmanaged[Cdecl]<byte, void>)0x0043AB10)(Allow);

    /// <summary>
    /// <code>Offset: 0x0043AB50
    /// bool Device::GetStringFromClipboard()</code>
    /// </summary>
    public static byte GetStringFromClipboard() => ((delegate* unmanaged[Cdecl]<byte>)0x0043AB50)();

    /// <summary>
    /// <code>Offset: 0x0043AC60
    /// bool __cdecl Device::StartupGraphicsEngine(int,int,bool)</code>
    /// </summary>
    public static byte StartupGraphicsEngine(int nWidth, int nHeight, byte bWindowed) => ((delegate* unmanaged[Cdecl]<int, int, byte, byte>)0x0043AC60)(nWidth, nHeight, bWindowed);

    /// <summary>
    /// <code>Offset: 0x0043AD90
    /// bool __cdecl Device::InitWindow(int,int,bool)</code>
    /// </summary>
    public static byte InitWindow(int width, int height, byte bWindowed) => ((delegate* unmanaged[Cdecl]<int, int, byte, byte>)0x0043AD90)(width, height, bWindowed);

    /// <summary>
    /// <code>Offset: 0x0043B2D0
    /// bool __cdecl Device::InitializeDisplayPreferences()</code>
    /// </summary>
    public static byte InitializeDisplayPreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x0043B2D0)();

    /// <summary>
    /// <code>Offset: 0x0043BA60
    /// char __cdecl Device::Init(bool,const char**,int,int,char,LPCSTR*)</code>
    /// </summary>
    public static sbyte Init(byte bWindowed, sbyte** a2, int a3, int a4, sbyte a5, sbyte** a6) => ((delegate* unmanaged[Cdecl]<byte, sbyte**, int, int, sbyte, sbyte**, sbyte>)0x0043BA60)(bWindowed, a2, a3, a4, a5, a6);
}

