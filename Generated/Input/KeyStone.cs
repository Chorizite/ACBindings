namespace ACBindings.Internal;


/// <summary>Manages the lifecycle of the Keystone engine, handling DLL loading, instance creation, plugin execution, message dispatching, and cleanup. Provides static methods for initializing, creating, and releasing the engine while coordinating help and plugin manager components.</summary>
public unsafe struct KeyStone
{
    // Statics
    public static ACBindings.Internal.IKeystone** m_lpKeystone = (ACBindings.Internal.IKeystone**)0x00870C2C;
    public static int** m_hKeystoneLib = (int**)0x00870C30;
    public static int** m_hAC2HelpPluginLib = (int**)0x00870C38;
    public static int** m_hAC2PluginManagerLib = (int**)0x00870C3C;
    public static int** m_hDummyAccel = (int**)0x00870C54;

    // Methods

    /// <summary>Calls the internal Keystone object's update routine if present.
    /// <code>Offset: 0x00557840
    /// void __cdecl KeyStone::Update()</code>
    /// </summary>
    public static void Update() => ((delegate* unmanaged[Cdecl]<void>)0x00557840)();

    /// <summary>Creates and initializes a Keystone engine instance tied to the current render window.
    /// <code>Offset: 0x00557850
    /// int __cdecl KeyStone::Create()</code>
    /// </summary>
    /// <returns>Non‑zero if initialization succeeded; otherwise zero.</returns>
    public static int Create() => ((delegate* unmanaged[Cdecl]<int>)0x00557850)();

    /// <summary>Initializes the Keystone system by loading required DLLs and retrieving entry points for core and plugin functions, returning success if already initialized or after a successful load sequence.
    /// <code>Offset: 0x00557930
    /// int __cdecl KeyStone::Init()</code>
    /// </summary>
    /// <returns>Non‑zero on successful initialization or when the library is already loaded; zero otherwise.</returns>
    public static int Init() => ((delegate* unmanaged[Cdecl]<int>)0x00557930)();

    /// <summary>Dispatches a message to the Keystone system and reports whether handling succeeded.
    /// <code>Offset: 0x005579F0
    /// int __cdecl KeyStone::DispatchMessageA(unsigned int,unsigned int,int,int*)</code>
    /// </summary>
    /// <param name="msg">Identifier of the message to be dispatched.</param>
    /// <param name="wparam">Unsigned parameter associated with the message.</param>
    /// <param name="lparam">Signed parameter associated with the message.</param>
    /// <param name="boola">Pointer to an integer that receives additional status information from the dispatch routine.</param>
    /// <returns>1 if the message was processed successfully; otherwise 0.</returns>
    public static int DispatchMessageA(uint msg, uint wparam, int lparam, int* boola) => ((delegate* unmanaged[Cdecl]<uint, uint, int, int*, int>)0x005579F0)(msg, wparam, lparam, boola);

    /// <summary>Determines whether a help component exists in the current Keystone context and activates it if found.
    /// <code>Offset: 0x00557A30
    /// int __cdecl KeyStone::IsHelpFocused()</code>
    /// </summary>
    /// <returns>Non‑zero when a help object is present and has been activated; zero otherwise.</returns>
    public static int IsHelpFocused() => ((delegate* unmanaged[Cdecl]<int>)0x00557A30)();

    /// <summary>Determines whether a given screen coordinate lies within the active Keystone window.
    /// <code>Offset: 0x00557A60
    /// int __cdecl KeyStone::IsOverKeystoneWindow(tagPOINT)</code>
    /// </summary>
    /// <param name="ptMouse">The point to test, expressed in screen coordinates.</param>
    /// <returns>Non‑zero if the point is inside the Keystone window; zero otherwise.</returns>
    public static int IsOverKeystoneWindow(ACBindings.Internal.tagPOINT ptMouse) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.tagPOINT, int>)0x00557A60)(ptMouse);

    /// <summary>
    /// Translates accelerator keystrokes into command messages for the specified window, using a supplied accelerator table or a default one if none is provided.
    /// Returns non‑zero when the message has been translated and removed; otherwise returns zero.
    /// 
    /// <code>Offset: 0x00557A90
    /// int __cdecl KeyStone::TranslateAcceleratorA(HWND__*,HACCEL__*,tagMSG*)</code>
    /// </summary>
    /// <param name="hWnd">Handle to the target window that will receive the translated message.</param>
    /// <param name="hAccel">Optional handle to an accelerator table; if null, a default dummy table is used.</param>
    /// <param name="pMsg">Pointer to the MSG structure containing the keystroke to translate.</param>
    /// <returns>Non‑zero if the translation succeeded and the message was processed; zero otherwise.</returns>
    public static int TranslateAcceleratorA(int* hWnd, int* hAccel, System.IntPtr pMsg) => ((delegate* unmanaged[Cdecl]<int*, int*, System.IntPtr, int>)0x00557A90)(hWnd, hAccel, pMsg);

    /// <summary>Causes the current Keystone object to relinquish focus, clearing the stored focus reference.
    /// <code>Offset: 0x00557AC0
    /// int __cdecl KeyStone::LoseFocus()</code>
    /// </summary>
    /// <returns>Non‑zero if focus was successfully cleared; zero if no Keystone is active or focus cannot be released.</returns>
    public static int LoseFocus() => ((delegate* unmanaged[Cdecl]<int>)0x00557AC0)();

    /// <summary>Cleans up the plugin manager resources, invoking the termination callback if available.
    /// <code>Offset: 0x00557AF0
    /// int __cdecl KeyStone::ClosePluginManager()</code>
    /// </summary>
    /// <returns>Zero when the plugin manager was not initialized or already closed; non‑zero (1) upon successful shutdown.</returns>
    public static int ClosePluginManager() => ((delegate* unmanaged[Cdecl]<int>)0x00557AF0)();

    /// <summary>Opens the Keystone plugin manager by terminating any existing instance and invoking the engine’s execute routine if available.
    /// <code>Offset: 0x00557B10
    /// int __cdecl KeyStone::OpenPluginManager()</code>
    /// </summary>
    /// <returns>Returns 1 on successful opening of the plugin manager; returns 0 if no Keystone handle is present or the execute function pointer is missing, indicating failure.</returns>
    public static int OpenPluginManager() => ((delegate* unmanaged[Cdecl]<int>)0x00557B10)();

    /// <summary>Releases the Keystone plugin, terminating help and manager components and freeing resources.
    /// <code>Offset: 0x00557B50
    /// int __cdecl KeyStone::Release()</code>
    /// </summary>
    /// <returns>Indicates successful release (always returns 1).</returns>
    public static int Release() => ((delegate* unmanaged[Cdecl]<int>)0x00557B50)();

    /// <summary>Cleans up all Keystone‑related resources by terminating active plugins, releasing loaded libraries, and destroying accelerator tables.
    /// <code>Offset: 0x00557BA0
    /// int __cdecl KeyStone::Cleanup()</code>
    /// </summary>
    /// <returns>Always 1 to signal successful cleanup.</returns>
    public static int Cleanup() => ((delegate* unmanaged[Cdecl]<int>)0x00557BA0)();

    /// <summary>Opens a help entry identified by the supplied string ID and table enumeration, or closes all help if the ID is zero.
    /// <code>Offset: 0x00557C50
    /// int __cdecl KeyStone::OpenHelp(const unsigned int,const int)</code>
    /// </summary>
    /// <param name="token">The identifier of the help string to display; zero indicates closing all help.</param>
    /// <param name="table">Enumeration value specifying which help table contains the string.</param>
    /// <returns>Non-zero on success; zero if the plugin interface is unavailable or execution fails.</returns>
    public static int OpenHelp(uint token, int table) => ((delegate* unmanaged[Cdecl]<uint, int, int>)0x00557C50)(token, table);

    /// <summary>Determines whether the Keystone plugin manager is active within the system.
    /// <code>Offset: 0x00557D80
    /// int __cdecl KeyStone::IsPluginManagerOpen()</code>
    /// </summary>
    /// <returns>Non‑zero value if the plugin manager is open, zero otherwise.</returns>
    public static int IsPluginManagerOpen() => ((delegate* unmanaged[Cdecl]<int>)0x00557D80)();
}

