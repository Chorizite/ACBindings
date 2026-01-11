namespace ACBindings.Internal.TurbineDwExceptionFilter;

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
    public delegate* unmanaged[Stdcall]<System.IntPtr, int> m_oldFilter; // function pointer

    // Generated Constructor
    public TurnOnDwExceptionHandler(int fInstallNow, sbyte* szWatsonServer) {
        _ConstructorInternal(fInstallNow, szWatsonServer);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B65C0
    /// void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::AddDllToDumpCapture(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*,const unsigned __int16*)</code>
    /// </summary>
    public void AddDllToDumpCapture(ushort* wzDllReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, ushort*, void>)0x006B65C0)(ref this, wzDllReq);

    /// <summary>
    /// <code>Offset: 0x006B6620
    /// void __cdecl TurbineDwExceptionFilter::TurnOnDwExceptionHandler::SetRegistryKeysForWatson(const char*,const wchar_t*)</code>
    /// </summary>
    public static void SetRegistryKeysForWatson(sbyte* szPathToDW, System.IntPtr wzFormalAppName) => ((delegate* unmanaged[Cdecl]<sbyte*, System.IntPtr, void>)0x006B6620)(szPathToDW, wzFormalAppName);

    /// <summary>
    /// <code>Offset: 0x006B66F0
    /// void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::BuildListOfFilesToUpload(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*)</code>
    /// </summary>
    public void BuildListOfFilesToUpload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, void>)0x006B66F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B6760
    /// int __stdcall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::DwExceptionFilter(_EXCEPTION_POINTERS*)</code>
    /// </summary>
    public static int DwExceptionFilter(System.IntPtr pep) => ((delegate* unmanaged[Stdcall]<System.IntPtr, int>)0x006B6760)(pep);

    /// <summary>
    /// <code>Offset: 0x006B6CF0
    /// void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::TurnOnDwExceptionHandler(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*,int,const char*)</code>
    /// </summary>
    public void _ConstructorInternal(int fInstallNow, sbyte* szWatsonServer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, int, sbyte*, void>)0x006B6CF0)(ref this, fInstallNow, szWatsonServer);
}

