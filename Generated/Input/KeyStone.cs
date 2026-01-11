namespace ACBindings.Internal;

public unsafe struct KeyStone
{
    // Statics
    public static ACBindings.Internal.IKeystone* m_lpKeystone = (ACBindings.Internal.IKeystone*)0x00870C2C;
    public static int* m_hAC2HelpPluginLib = (int*)0x00870C38;
    public static int* m_hAC2PluginManagerLib = (int*)0x00870C3C;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00557840
    /// void __cdecl KeyStone::Update()</code>
    /// </summary>
    public static void Update() => ((delegate* unmanaged[Cdecl]<void>)0x00557840)();

    /// <summary>
    /// <code>Offset: 0x00557850
    /// int __cdecl KeyStone::Create()</code>
    /// </summary>
    public static int Create() => ((delegate* unmanaged[Cdecl]<int>)0x00557850)();

    /// <summary>
    /// <code>Offset: 0x00557930
    /// int __cdecl KeyStone::Init()</code>
    /// </summary>
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x00557930)();

    /// <summary>
    /// <code>Offset: 0x005579F0
    /// int __cdecl KeyStone::DispatchMessageA(unsigned int,unsigned int,int,int*)</code>
    /// </summary>
    public static int DispatchMessageA(uint msg, uint wparam, int lparam, int* boola) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int*, int>)0x005579F0)(msg, wparam, lparam, boola);

    /// <summary>
    /// <code>Offset: 0x00557A30
    /// int __cdecl KeyStone::IsHelpFocused()</code>
    /// </summary>
    public static int IsHelpFocused() => ((delegate* unmanaged[Cdecl]<int>)0x00557A30)();

    /// <summary>
    /// <code>Offset: 0x00557A60
    /// int __cdecl KeyStone::IsOverKeystoneWindow(tagPOINT)</code>
    /// </summary>
    public static int IsOverKeystoneWindow(ACBindings.Internal.tagPOINT ptMouse) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.tagPOINT, int>)0x00557A60)(ptMouse);

    /// <summary>
    /// <code>Offset: 0x00557A90
    /// int __cdecl KeyStone::TranslateAcceleratorA(HWND__*,HACCEL__*,tagMSG*)</code>
    /// </summary>
    public static int TranslateAcceleratorA(int* hWnd, int* hAccel, System.IntPtr pMsg) => ((delegate* unmanaged[Cdecl]<int*, int*, System.IntPtr, int>)0x00557A90)(hWnd, hAccel, pMsg);

    /// <summary>
    /// <code>Offset: 0x00557AC0
    /// int __cdecl KeyStone::LoseFocus()</code>
    /// </summary>
    public static int LoseFocus() => ((delegate* unmanaged[Cdecl]<int>)0x00557AC0)();

    /// <summary>
    /// <code>Offset: 0x00557AF0
    /// int __cdecl KeyStone::ClosePluginManager()</code>
    /// </summary>
    public static int ClosePluginManager() => ((delegate* unmanaged[Cdecl]<int>)0x00557AF0)();

    /// <summary>
    /// <code>Offset: 0x00557B10
    /// int __cdecl KeyStone::OpenPluginManager()</code>
    /// </summary>
    public static int OpenPluginManager() => ((delegate* unmanaged[Cdecl]<int>)0x00557B10)();

    /// <summary>
    /// <code>Offset: 0x00557B50
    /// int __cdecl KeyStone::Release()</code>
    /// </summary>
    public static int Release() => ((delegate* unmanaged[Cdecl]<int>)0x00557B50)();

    /// <summary>
    /// <code>Offset: 0x00557BA0
    /// int __cdecl KeyStone::Cleanup()</code>
    /// </summary>
    public static int Cleanup() => ((delegate* unmanaged[Cdecl]<int>)0x00557BA0)();

    /// <summary>
    /// <code>Offset: 0x00557C50
    /// int __cdecl KeyStone::OpenHelp(const unsigned int,const int)</code>
    /// </summary>
    public static int OpenHelp(uint token, int table) => ((delegate* unmanaged[Cdecl]<uint, int, int>)0x00557C50)(token, table);

    /// <summary>
    /// <code>Offset: 0x00557D80
    /// int __cdecl KeyStone::IsPluginManagerOpen()</code>
    /// </summary>
    public static int IsPluginManagerOpen() => ((delegate* unmanaged[Cdecl]<int>)0x00557D80)();
}

