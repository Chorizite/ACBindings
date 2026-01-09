namespace ACBindings;

// Device
public unsafe struct Device
{
    // Statics
    public static byte* m_bSysKeysEnabled = (byte*)0x00818B01;
    public static byte* m_bAllowFullScreenMode = (byte*)0x00818B02;
    public static uint* m_nForcedWidth = (uint*)0x00818B04;
    public static uint* m_nForcedHeight = (uint*)0x00818B08;
    public static byte* m_fMouseIsShown = (byte*)0x00818B0C;
    public static ACBindings.DisplayPrefs* m_DisplayPrefs = (ACBindings.DisplayPrefs*)0x00818B64;
    public static byte* m_bIsDone = (byte*)0x00838194;
    public static byte* m_bIsReady = (byte*)0x00838195;
    public static byte* m_bIsInitialized = (byte*)0x00838196;
    public static byte* m_bIsActiveApp = (byte*)0x00838197;
    public static byte* m_bIsWithinEventLoop = (byte*)0x00838198;
    public static byte* m_bToggleFullScreenMode = (byte*)0x00838199;
    public static uint* m_nOSVersion = (uint*)0x0083819C;
    public static byte* m_bUseForcedResolution = (byte*)0x008381A0;
    public static int* m_hWnd = (int*)0x008381A4;
    public static byte* m_bIsChildWnd = (byte*)0x008381A8;
    public static ACBindings.Device.DeviceDialogBoxGateway* sm_pDeviceDialogGateway = (ACBindings.Device.DeviceDialogBoxGateway*)0x008381AC;

    // Child Types
    // Device::DeviceDialogBoxGateway_vtbl
    public unsafe struct DeviceDialogBoxGateway_vtbl
    {
        // Members
        public System.IntPtr Device; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr OnDialogBoxBegin; // function pointer
        public System.IntPtr OnDialogBoxEnd; // function pointer
        public System.IntPtr ReportThread_OnDialogBoxBegin; // function pointer
        public System.IntPtr ReportThread_OnDialogBoxEnd; // function pointer
        public System.IntPtr DialogThread_OnDialogBoxBegin; // function pointer
        public System.IntPtr DialogThread_OnDialogBoxEnd; // function pointer

        // Methods
    }
    // Device::DeviceDialogBoxGateway
    public unsafe struct DeviceDialogBoxGateway
    {
        // Base Classes
        public ACBindings.DialogBoxGateway BaseClass_DialogBoxGateway; // ACBindings.DialogBoxGateway

        // Generated Constructor
        public DeviceDialogBoxGateway() {
            _ConstructorInternal();
        }

        // Methods
        // bool __thiscall Device::DeviceDialogBoxGateway::ReportThread_OnDialogBoxBegin(Device::DeviceDialogBoxGateway*)
        public byte ReportThread_OnDialogBoxBegin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Device.DeviceDialogBoxGateway, byte>)0x004391A0)(ref this);
        // void __thiscall Device::DeviceDialogBoxGateway::ReportThread_OnDialogBoxEnd(Device::DeviceDialogBoxGateway*,bool)
        public void ReportThread_OnDialogBoxEnd(byte context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Device.DeviceDialogBoxGateway, byte, void>)0x004391E0)(ref this, context);
        // void __thiscall Device::DeviceDialogBoxGateway::DeviceDialogBoxGateway(Device::DeviceDialogBoxGateway*)
        public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Device.DeviceDialogBoxGateway, void>)0x00439210)(ref this);
    }

    // Methods
    // void __cdecl Device::Done()
    public static void Done() => ((delegate* unmanaged[Cdecl]<void>)0x00439230)();
    // int __cdecl Device::ForwardToInputManager(HWND__*,unsigned int,unsigned int,int,bool*)
    public static int ForwardToInputManager(int* hWindow, uint message, uint wParam, int lParam, byte* o_fHandled) => ((delegate* unmanaged[Cdecl]<int*, uint, uint, int, byte*, int>)0x00439240)(hWindow, message, wParam, lParam, o_fHandled);
    // void __cdecl Device::DoFrameSleep()
    public static void DoFrameSleep() => ((delegate* unmanaged[Cdecl]<void>)0x004392B0)();
    // void __cdecl Device::Activate()
    public static void Activate() => ((delegate* unmanaged[Cdecl]<void>)0x004392F0)();
    // void __cdecl Device::Deactivate()
    public static void Deactivate() => ((delegate* unmanaged[Cdecl]<void>)0x00439320)();
    // bool __cdecl Device::LoadDisplayPreferences(RenderDevicePresentation*)
    public static byte LoadDisplayPreferences(ACBindings.RenderDevicePresentation* Presentation) => ((delegate* unmanaged[Cdecl]<ACBindings.RenderDevicePresentation*, byte>)0x00439370)(Presentation);
    // bool __cdecl Device::ShutdownGraphicsEngine()
    public static byte ShutdownGraphicsEngine() => ((delegate* unmanaged[Cdecl]<byte>)0x00439400)();
    // RenderSurface* __cdecl Device::GetScreenshotSurface()
    public static ACBindings.RenderSurface* GetScreenshotSurface() => ((delegate* unmanaged[Cdecl]<ACBindings.RenderSurface*>)0x00439460)();
    // int __cdecl Device::Error(const char**,const char**,char)
    public static int Error(sbyte** a1, sbyte** a2, sbyte a3) => ((delegate* unmanaged[Cdecl]<sbyte**, sbyte**, sbyte, int>)0x00439590)(a1, a2, a3);
    // bool __cdecl Device::SetCursorFromIcon(HICON__*)
    public static byte SetCursorFromIcon(int* hNewIcon) => ((delegate* unmanaged[Cdecl]<int*, byte>)0x004395D0)(hNewIcon);
    // void __cdecl Device::ShowCursor(bool)
    public static void ShowCursor(byte show) => ((delegate* unmanaged[Cdecl]<byte, void>)0x00439620)(show);
    // int __stdcall Device::WndProc(HWND__*,unsigned int,unsigned int,int)
    public static int WndProc(int* hWindow, uint message, uint wParam, int lParam) => ((delegate* unmanaged[Stdcall]<int*, uint, uint, int, int>)0x00439860)(hWindow, message, wParam, lParam);
    // LONG __cdecl Device::SendStringToClipboard(char*)
    public static int SendStringToClipboard(sbyte* hMem) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00439D50)(hMem);
    // bool __cdecl Device::DoEventLoop()
    public static byte DoEventLoop() => ((delegate* unmanaged[Cdecl]<byte>)0x00439E50)();
    // bool __cdecl Device::SetCursorFromImage(const unsigned int,const unsigned int,const RenderSurface*)
    public static byte SetCursorFromImage(uint xHotSpot, uint yHotSpot, ACBindings.RenderSurface* image) => ((delegate* unmanaged[Cdecl]<uint, uint, ACBindings.RenderSurface*, byte>)0x00439F30)(xHotSpot, yHotSpot, image);
    // void __cdecl Device::Cleanup()
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x0043A370)();
    // bool __cdecl Device::ChangePresentation()
    public static byte ChangePresentation() => ((delegate* unmanaged[Cdecl]<byte>)0x0043A510)();
    // char __cdecl Device::SaveScreenshot(int*)
    public static sbyte SaveScreenshot(int* a1) => ((delegate* unmanaged[Cdecl]<int*, sbyte>)0x0043A780)(a1);
    // void __cdecl Device::Show16BitWarning()
    public static void Show16BitWarning() => ((delegate* unmanaged[Cdecl]<void>)0x0043A8F0)();
    // void __cdecl Device::ForceDisplayResolution(const bool,const unsigned int,const unsigned int)
    public static void ForceDisplayResolution(byte bEnable, uint nWidth, uint nHeight) => ((delegate* unmanaged[Cdecl]<byte, uint, uint, void>)0x0043A990)(bEnable, nWidth, nHeight);
    // char __cdecl Device::ConsoleCommand_ForceDisplayResolution(char***)
    public static sbyte ConsoleCommand_ForceDisplayResolution(sbyte*** a1) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x0043AA70)(a1);
    // void __cdecl Device::AllowFullScreenMode(const bool)
    public static void AllowFullScreenMode(byte Allow) => ((delegate* unmanaged[Cdecl]<byte, void>)0x0043AB10)(Allow);
    // bool Device::GetStringFromClipboard()
    public static byte GetStringFromClipboard() => ((delegate* unmanaged[Cdecl]<byte>)0x0043AB50)();
    // bool __cdecl Device::StartupGraphicsEngine(int,int,bool)
    public static byte StartupGraphicsEngine(int nWidth, int nHeight, byte bWindowed) => ((delegate* unmanaged[Cdecl]<int, int, byte, byte>)0x0043AC60)(nWidth, nHeight, bWindowed);
    // bool __cdecl Device::InitWindow(int,int,bool)
    public static byte InitWindow(int width, int height, byte bWindowed) => ((delegate* unmanaged[Cdecl]<int, int, byte, byte>)0x0043AD90)(width, height, bWindowed);
    // bool __cdecl Device::InitializeDisplayPreferences()
    public static byte InitializeDisplayPreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x0043B2D0)();
    // char __cdecl Device::Init(bool,const char**,int,int,char,LPCSTR*)
    public static sbyte Init(byte bWindowed, sbyte** a2, int a3, int a4, sbyte a5, sbyte** a6) => ((delegate* unmanaged[Cdecl]<byte, sbyte**, int, int, sbyte, sbyte**, sbyte>)0x0043BA60)(bWindowed, a2, a3, a4, a5, a6);
}

