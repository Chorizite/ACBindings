namespace ACBindings;

// KeyStone
public unsafe struct KeyStone
{
    // Statics
    public static int* m_hAC2PluginManagerLib = (int*)0x0086F608;
    public static int* m_hAC2HelpPluginLib = (int*)0x0086F60C;
    public static int* m_hKeystoneLib = (int*)0x0086F614;
    public static ACBindings.IKeystone* m_lpKeystone = (ACBindings.IKeystone*)0x0086F618;
    public static int* m_hDummyAccel = (int*)0x0086F630;

    // Methods
    // void __cdecl KeyStone::Update()
    public static void Update() => ((delegate* unmanaged[Cdecl]<void>)0x00557840)();
    // int __cdecl KeyStone::Create()
    public static int Create() => ((delegate* unmanaged[Cdecl]<int>)0x00557850)();
    // int __cdecl KeyStone::Init()
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x00557930)();
    // int __cdecl KeyStone::DispatchMessageA(unsigned int,unsigned int,int,int*)
    public static int DispatchMessageA(uint msg, uint wparam, int lparam, int* boola) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int*, int>)0x005579F0)(msg, wparam, lparam, boola);
    // int __cdecl KeyStone::IsHelpFocused()
    public static int IsHelpFocused() => ((delegate* unmanaged[Cdecl]<int>)0x00557A30)();
    // int __cdecl KeyStone::IsOverKeystoneWindow(tagPOINT)
    public static int IsOverKeystoneWindow(ACBindings.tagPOINT ptMouse) => ((delegate* unmanaged[Cdecl]<ACBindings.tagPOINT, int>)0x00557A60)(ptMouse);
    // int __cdecl KeyStone::TranslateAcceleratorA(HWND__*,HACCEL__*,tagMSG*)
    public static int TranslateAcceleratorA(int* hWnd, int* hAccel, System.IntPtr pMsg) => ((delegate* unmanaged[Cdecl]<int*, int*, System.IntPtr, int>)0x00557A90)(hWnd, hAccel, pMsg);
    // int __cdecl KeyStone::LoseFocus()
    public static int LoseFocus() => ((delegate* unmanaged[Cdecl]<int>)0x00557AC0)();
    // int __cdecl KeyStone::ClosePluginManager()
    public static int ClosePluginManager() => ((delegate* unmanaged[Cdecl]<int>)0x00557AF0)();
    // int __cdecl KeyStone::OpenPluginManager()
    public static int OpenPluginManager() => ((delegate* unmanaged[Cdecl]<int>)0x00557B10)();
    // int __cdecl KeyStone::Release()
    public static int Release() => ((delegate* unmanaged[Cdecl]<int>)0x00557B50)();
    // int __cdecl KeyStone::Cleanup()
    public static int Cleanup() => ((delegate* unmanaged[Cdecl]<int>)0x00557BA0)();
    // int __cdecl KeyStone::OpenHelp(const unsigned int,const int)
    public static int OpenHelp(uint token, int table) => ((delegate* unmanaged[Cdecl]<uint, int, int>)0x00557C50)(token, table);
    // int __cdecl KeyStone::IsPluginManagerOpen()
    public static int IsPluginManagerOpen() => ((delegate* unmanaged[Cdecl]<int>)0x00557D80)();
}

