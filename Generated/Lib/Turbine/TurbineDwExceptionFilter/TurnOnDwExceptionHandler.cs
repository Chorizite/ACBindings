namespace ACBindings.Internal.TurbineDwExceptionFilter;


/// <summary>Encapsulates configuration for installing a Watson crash‑reporting exception filter, storing the target server address, lists of DLLs and files to capture, and plugin references. When activated it registers an unhandled exception filter that prepares diagnostic data and launches Microsoft’s Watson wrapper.</summary>
/// <remarks>Fields include m_szWatsonServer (server address), m_wzExtraDllsForDataCapture and m_wzExtraFilesForDataCapture for crash‑dump enrichment, m_dwIndexIntoExtraDlls tracks DLL list usage, and m_oldFilter holds a previously installed filter. The struct is used by TurbineDwExceptionFilter to manage crash reporting behavior.</remarks>
public unsafe struct TurnOnDwExceptionHandler
{
    // Base Classes
    public ACBindings.Internal.CPluginManagerTemplate___TurbineDwExceptionFilter_WatsonCrashReportHelper BaseClass_CPluginManagerTemplate; // ACBindings.Internal.CPluginManagerTemplate___TurbineDwExceptionFilter_WatsonCrashReportHelper

    // Members
    public fixed sbyte m_szWatsonServer[261];
    public fixed ushort m_wzExtraDllsForDataCapture[261];
    public fixed ushort m_wzExtraFilesForDataCapture[1024];
    public uint m_dwIndexIntoExtraDlls;
    public int m_fInstalled;
    public static delegate* unmanaged[Stdcall]<System.IntPtr, int> m_oldFilter; // function pointer

    // Generated Constructor
    public TurnOnDwExceptionHandler(int fInstallNow, sbyte* szWatsonServer) {
        _ConstructorInternal(fInstallNow, szWatsonServer);
    }

    // Methods

    /// <summary>Adds the specified DLL name to the handler's list of extra DLLs for crash dump data capture, ensuring the list remains within its fixed-size buffer.
    /// <code>Offset: 0x006B65C0
    /// void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::AddDllToDumpCapture(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*,const unsigned __int16*)</code>
    /// </summary>
    /// <param name="wzDllReq">Pointer to a wide-character string containing the DLL name to include in future dumps.</param>
    public void AddDllToDumpCapture(ushort* wzDllReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, ushort*, void>)0x006B65C0)(ref this, wzDllReq);

    /// <summary>Configures Windows Event Log registry keys to enable Watson crash reporting for a specific application by creating the appropriate subkey under HKLM\SYSTEM\CurrentControlSet\Services\EventLog\Application and setting its EventMessageFile and TypesSupported values.
    /// <code>Offset: 0x006B6620
    /// void __cdecl TurbineDwExceptionFilter::TurnOnDwExceptionHandler::SetRegistryKeysForWatson(const char*,const wchar_t*)</code>
    /// </summary>
    /// <param name="szPathToDW">Unused in this implementation; reserved for future use or intended to specify the diagnostics wrapper path.</param>
    /// <param name="wzFormalAppName">The formal name of the application, used to construct the registry subkey path.</param>
    public static void SetRegistryKeysForWatson(sbyte* szPathToDW, System.IntPtr wzFormalAppName) => ((delegate* unmanaged[Cdecl]<sbyte*, System.IntPtr, void>)0x006B6620)(szPathToDW, wzFormalAppName);

    /// <summary>Populates the handler’s extra files array with file names obtained from each installed plugin, preparing a list of files for upload during crash reporting.
    /// <code>Offset: 0x006B66F0
    /// void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::BuildListOfFilesToUpload(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*)</code>
    /// </summary>
    public void BuildListOfFilesToUpload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, void>)0x006B66F0)(ref this);

    /// <summary>Intercepts unhandled exceptions that are not already being processed by the DW handler, prepares crash diagnostic data, launches Microsoft’s Watson error reporting tool, and forwards control to any previously installed filter if necessary.
    /// <code>Offset: 0x006B6760
    /// int __stdcall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::DwExceptionFilter(_EXCEPTION_POINTERS*)</code>
    /// </summary>
    /// <param name="pep">Pointer to an _EXCEPTION_POINTERS structure describing the exception that occurred.</param>
    /// <returns>Non‑zero if the exception was handled by this filter; zero if it was passed to a previously installed handler or unhandled.</returns>
    public static int DwExceptionFilter(System.IntPtr pep) => ((delegate* unmanaged[Stdcall]<System.IntPtr, int>)0x006B6760)(pep);

    /// <summary>Initializes a TurnOnDwExceptionHandler instance, clearing internal buffers and optionally registering an unhandled exception filter.
    /// <code>Offset: 0x006B6CF0
    /// void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::TurnOnDwExceptionHandler(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*,int,const char*)</code>
    /// </summary>
    /// <param name="fInstallNow">If non‑zero and the handler has not yet been installed, registers the DwExceptionFilter with SetUnhandledExceptionFilter.</param>
    /// <param name="szWatsonServer">Optional Watson server address; if supplied and non‑empty, copies it into the instance's internal buffer.</param>
    public void _ConstructorInternal(int fInstallNow, sbyte* szWatsonServer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, int, sbyte*, void>)0x006B6CF0)(ref this, fInstallNow, szWatsonServer);
}

