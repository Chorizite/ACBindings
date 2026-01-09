namespace ACBindings;

// GlobalRegistry
public unsafe struct GlobalRegistry
{
    // Statics
    public static ACBindings.GlobalRegistryInstance* s_pcGlobalRegistry = (ACBindings.GlobalRegistryInstance*)0x008380C8;

    // Methods
    // void __cdecl GlobalRegistry::GetRegistry()
    public static void GetRegistry() => ((delegate* unmanaged[Cdecl]<void>)0x00401750)();
    // void __cdecl GlobalRegistry::UnregisterConsoleCallbackObject(IConsoleCallbackObject*)
    public static void UnregisterConsoleCallbackObject(ACBindings.IConsoleCallbackObject* io_pConsoleCallbackObject) => ((delegate* unmanaged[Cdecl]<ACBindings.IConsoleCallbackObject*, void>)0x004352E0)(io_pConsoleCallbackObject);
    // void __cdecl GlobalRegistry::OutputText(_DWORD*)
    public static void OutputText(int* a1) => ((delegate* unmanaged[Cdecl]<int*, void>)0x004355A0)(a1);
    // void __cdecl GlobalRegistry::RegisterConsoleCallbackObject(IConsoleCallbackObject*)
    public static void RegisterConsoleCallbackObject(ACBindings.IConsoleCallbackObject* io_pConsoleCallbackObject) => ((delegate* unmanaged[Cdecl]<ACBindings.IConsoleCallbackObject*, void>)0x00436120)(io_pConsoleCallbackObject);
    // LONG __cdecl GlobalRegistry::ProcessCommand(volatile LONG**)
    public static int ProcessCommand(int** m_charbuffer) => ((delegate* unmanaged[Cdecl]<int**, int>)0x00436190)(m_charbuffer);
    // void __cdecl GlobalRegistry::RegisterCommand(int,const char**,int*)
    public static void RegisterCommand(int a1, sbyte** a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, sbyte**, int*, void>)0x00436580)(a1, a2, a3);
    // void __cdecl GlobalRegistry::RegisterCommand(int,const char**,int*,int*)
    public static void RegisterCommand(int a1, sbyte** a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<int, sbyte**, int*, int*, void>)0x004366D0)(a1, a2, a3, a4);
    // void __cdecl GlobalRegistry::UnregisterCommand(char**)
    public static void UnregisterCommand(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x00436830)(a1);
    // LONG __cdecl GlobalRegistry::RegisterVariableInternal(void*,void*,const char**,int*,void*,char*,int,int)
    public static int RegisterVariableInternal(System.IntPtr a1, System.IntPtr a2, sbyte** a3, int* a4, System.IntPtr a5, sbyte* SubStr, int a7, int a8) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, sbyte**, int*, System.IntPtr, sbyte*, int, int, int>)0x004369A0)(a1, a2, a3, a4, a5, SubStr, a7, a8);
    // void __cdecl GlobalRegistry::UnregisterVariable(char**)
    public static void UnregisterVariable(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x00436CF0)(a1);
    // char __thiscall GlobalRegistry::InqTypedVariable(volatile LONG**,_BYTE*)
    public sbyte InqTypedVariable(byte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistry, byte*, sbyte>)0x005D9DD0)(ref this, a2);
    // char __thiscall GlobalRegistry::InqTypedVariable(volatile LONG**,_DWORD*)
    public sbyte InqTypedVariable(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistry, int*, sbyte>)0x005D9E40)(ref this, a2);
}

