namespace ACBindings.Internal;


/// <summary>Manages the runtime lifecycle of a chat client for the AC1 application, loading the necessary DLL, maintaining handles to both the client instance and its library, and integrating with exception filtering infrastructure.</summary>
/// <remarks>Inherits from WatsonCrashReportHelper to automatically attach relevant logs during crash reporting.</remarks>
public unsafe struct AC1ClientChatManager
{
    // Base Classes
    public ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper BaseClass_TurbineDwExceptionFilter_WatsonCrashReportHelper; // ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper

    // Child Types

    /// <summary>Virtual function table for AC1ClientChatManager, containing pointers for destructor, plug‑in integration callback, and Watson upload file inclusion logic.</summary>
    /// <remarks>Facilitates dynamic dispatch of chat manager methods within the game client.</remarks>
    public unsafe struct AC1ClientChatManager_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1ClientChatManager*, void> AC1ClientChatManager_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1ClientChatManager*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1ClientChatManager*, ushort*, uint, int> IncludeFileInWatsonUpload; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IChatClient* m_pChatClient;
    public int* m_hChatClientLib;

    // Methods

    /// <summary>Retrieves the active chat client instance managed by AC1ClientChatManager.
    /// <code>Offset: 0x00557440
    /// IChatClient* __cdecl AC1ClientChatManager::GetIChatClient()</code>
    /// </summary>
    /// <returns>A pointer to the current IChatClient, or null if no chat client is available.</returns>
    public static ACBindings.Internal.IChatClient* GetIChatClient() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IChatClient*>)0x00557440)();

    /// <summary>Generates the full path to the log file associated with the current executable and writes it into the supplied wide-character buffer if there is sufficient space.
    /// <code>Offset: 0x005574B0
    /// int __thiscall AC1ClientChatManager::IncludeFileInWatsonUpload(AC1ClientChatManager*,unsigned __int16*,unsigned int)</code>
    /// </summary>
    /// <param name="o_swzFilename">Buffer that receives the fully-qualified log filename; must contain enough wchar_t elements for the string plus a terminating null character.</param>
    /// <param name="dwCharsAvailable">Number of wchar_t slots available in o_swzFilename, including space for the terminating null.</param>
    /// <returns>Non‑zero if the filename was written successfully; zero otherwise (e.g., insufficient buffer size).</returns>
    public int IncludeFileInWatsonUpload(ushort* o_swzFilename, uint dwCharsAvailable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1ClientChatManager, ushort*, uint, int>)0x005574B0)(ref this, o_swzFilename, dwCharsAvailable);

    /// <summary>Initializes the chat manager by loading the specified DLL, creating a chat client instance, and configuring it with optional parameters.
    /// <code>Offset: 0x00557620
    /// int __thiscall AC1ClientChatManager::Init(_DWORD*,LPCSTR,int,_DWORD*)</code>
    /// </summary>
    /// <param name="lpLibFileName">Path to the chat client library to load.</param>
    /// <param name="a3">Optional configuration value passed to the chat client during initialization; zero indicates default behavior.</param>
    /// <param name="a4">Pointer to a structure containing additional initialization data used by the chat client.</param>
    /// <returns>Non‑zero if initialization succeeded, otherwise zero.</returns>
    public int Init(sbyte* lpLibFileName, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1ClientChatManager, sbyte*, int, int*, int>)0x00557620)(ref this, lpLibFileName, a3, a4);
}

