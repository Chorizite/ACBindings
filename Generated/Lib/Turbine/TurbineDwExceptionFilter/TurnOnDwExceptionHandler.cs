namespace ACBindings.TurbineDwExceptionFilter;

// TurbineDwExceptionFilter::TurnOnDwExceptionHandler
public unsafe struct TurnOnDwExceptionHandler
{
    // Base Classes
    public ACBindings.CPluginManagerTemplate__TurbineDwExceptionFilter_WatsonCrashReportHelper BaseClass_CPluginManagerTemplate; // ACBindings.CPluginManagerTemplate__TurbineDwExceptionFilter_WatsonCrashReportHelper

    // Members
    public fixed sbyte m_szWatsonServer[261];
    public fixed ushort m_wzExtraDllsForDataCapture[261];
    public fixed ushort m_wzExtraFilesForDataCapture[1024];
    public uint m_dwIndexIntoExtraDlls;
    public int m_fInstalled;
    public System.IntPtr m_oldFilter; // function pointer

    // Generated Constructor
    public TurnOnDwExceptionHandler(int fInstallNow, sbyte* szWatsonServer) {
        _ConstructorInternal(fInstallNow, szWatsonServer);
    }

    // Methods
    // void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::AddDllToDumpCapture(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*,const unsigned __int16*)
    public void AddDllToDumpCapture(ushort* wzDllReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, ushort*, void>)0x006B65C0)(ref this, wzDllReq);
    // void __cdecl TurbineDwExceptionFilter::TurnOnDwExceptionHandler::SetRegistryKeysForWatson(const char*,const wchar_t*)
    public static void SetRegistryKeysForWatson(sbyte* szPathToDW, System.IntPtr wzFormalAppName) => ((delegate* unmanaged[Cdecl]<sbyte*, System.IntPtr, void>)0x006B6620)(szPathToDW, wzFormalAppName);
    // void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::BuildListOfFilesToUpload(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*)
    public void BuildListOfFilesToUpload() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, void>)0x006B66F0)(ref this);
    // int __stdcall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::DwExceptionFilter(_EXCEPTION_POINTERS*)
    public static int DwExceptionFilter(System.IntPtr pep) => ((delegate* unmanaged[Stdcall]<System.IntPtr, int>)0x006B6760)(pep);
    // void __thiscall TurbineDwExceptionFilter::TurnOnDwExceptionHandler::TurnOnDwExceptionHandler(TurbineDwExceptionFilter::TurnOnDwExceptionHandler*,int,const char*)
    public void _ConstructorInternal(int fInstallNow, sbyte* szWatsonServer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TurbineDwExceptionFilter.TurnOnDwExceptionHandler, int, sbyte*, void>)0x006B6CF0)(ref this, fInstallNow, szWatsonServer);
}

