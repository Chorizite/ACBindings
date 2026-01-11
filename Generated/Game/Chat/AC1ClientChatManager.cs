namespace ACBindings.Internal;

public unsafe struct AC1ClientChatManager
{
    // Base Classes
    public ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper BaseClass_TurbineDwExceptionFilter_WatsonCrashReportHelper; // ACBindings.Internal.TurbineDwExceptionFilter.WatsonCrashReportHelper

    // Child Types
    public unsafe struct AC1ClientChatManager_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1ClientChatManager*, void> AC1ClientChatManager_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1ClientChatManager*, ACBindings.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1ClientChatManager*, ushort*, uint, int> IncludeFileInWatsonUpload; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IChatClient* m_pChatClient;
    public int* m_hChatClientLib;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00557440
    /// IChatClient* __cdecl AC1ClientChatManager::GetIChatClient()</code>
    /// </summary>
    public static ACBindings.Internal.IChatClient* GetIChatClient() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IChatClient*>)0x00557440)();

    /// <summary>
    /// <code>Offset: 0x005574B0
    /// int __thiscall AC1ClientChatManager::IncludeFileInWatsonUpload(AC1ClientChatManager*,unsigned __int16*,unsigned int)</code>
    /// </summary>
    public int IncludeFileInWatsonUpload(ushort* o_swzFilename, uint dwCharsAvailable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1ClientChatManager, ushort*, uint, int>)0x005574B0)(ref this, o_swzFilename, dwCharsAvailable);

    /// <summary>
    /// <code>Offset: 0x00557620
    /// int __thiscall AC1ClientChatManager::Init(_DWORD*,LPCSTR,int,_DWORD*)</code>
    /// </summary>
    public int Init(sbyte* lpLibFileName, int a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1ClientChatManager, sbyte*, int, int*, int>)0x00557620)(ref this, lpLibFileName, a3, a4);
}

