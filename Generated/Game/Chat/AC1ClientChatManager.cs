namespace ACBindings;

// AC1ClientChatManager
public unsafe struct AC1ClientChatManager
{
    // Base Classes
    public ACBindings.TurbineDwExceptionFilter.WatsonCrashReportHelper BaseClass_TurbineDwExceptionFilter_WatsonCrashReportHelper; // ACBindings.TurbineDwExceptionFilter.WatsonCrashReportHelper

    // Child Types
    // AC1ClientChatManager_vtbl
    public unsafe struct AC1ClientChatManager_vtbl
    {
        // Members
        public System.IntPtr AC1ClientChatManager_dtor_0; // function pointer
        public System.IntPtr OnPluggedIn; // function pointer
        public System.IntPtr IncludeFileInWatsonUpload; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IChatClient* m_pChatClient;
    public int* m_hChatClientLib;

    // Methods
    // IChatClient* __cdecl AC1ClientChatManager::GetIChatClient()
    public static ACBindings.IChatClient* GetIChatClient() => ((delegate* unmanaged[Cdecl]<ACBindings.IChatClient*>)0x00557440)();
    // int __thiscall AC1ClientChatManager::IncludeFileInWatsonUpload(AC1ClientChatManager*,unsigned __int16*,unsigned int)
    public int IncludeFileInWatsonUpload(ushort* o_swzFilename, uint dwCharsAvailable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1ClientChatManager, ushort*, uint, int>)0x005574B0)(ref this, o_swzFilename, dwCharsAvailable);
    // int __thiscall AC1ClientChatManager::Init(_DWORD*,LPCSTR,int,_DWORD*)
    public int Init(sbyte* lpLibFileName, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1ClientChatManager, sbyte*, int, int*, int>)0x00557620)(ref this, lpLibFileName, a3, a4);
}

