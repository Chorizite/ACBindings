namespace ACBindings;

// CFactory
public unsafe struct CFactory
{
    // Statics
    public static ACBindings.CFactory* global_cfactory = (ACBindings.CFactory*)0x00846FD4;

    // Child Types
    // CFactory_vtbl
    public unsafe struct CFactory_vtbl
    {
        // Members
        public System.IntPtr CFactory_dtor_0; // function pointer
        public System.IntPtr MakeCommandInterpreter_Internal; // function pointer
        public System.IntPtr Make_Client_Cache_Internal; // function pointer
        public System.IntPtr MakeCWeenieObject_Internal; // function pointer
        public System.IntPtr MakeGlobalEventHandler_Internal; // function pointer
        public System.IntPtr MakeQualityRegistrar_Internal; // function pointer
        public System.IntPtr MakeCCommunicationSystem_Internal; // function pointer
        public System.IntPtr MakeSmartBox_Internal;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
    // void __cdecl CFactory::CleanUp()
    public static void CleanUp() => ((delegate* unmanaged[Cdecl]<void>)0x0054BA90)();
    // CommandInterpreter* __thiscall CFactory::MakeCommandInterpreter_Internal(CFactory*)
    public ACBindings.CommandInterpreter* MakeCommandInterpreter_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CFactory, ACBindings.CommandInterpreter*>)0x0054BAB0)(ref this);
    // CommandInterpreter* __cdecl CFactory::MakeCommandInterpreter()
    public static ACBindings.CommandInterpreter* MakeCommandInterpreter() => ((delegate* unmanaged[Cdecl]<ACBindings.CommandInterpreter*>)0x0054BAD0)();
    // CLCache* __cdecl CFactory::Make_Client_Cache()
    public static ACBindings.CLCache* Make_Client_Cache() => ((delegate* unmanaged[Cdecl]<ACBindings.CLCache*>)0x0054BAF0)();
    // CLCache* __thiscall CFactory::Make_Client_Cache_Internal(CFactory*)
    public ACBindings.CLCache* Make_Client_Cache_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CFactory, ACBindings.CLCache*>)0x0054BB10)(ref this);
    // CWeenieObject* __cdecl CFactory::MakeCWeenieObject(unsigned int)
    public static ACBindings.CWeenieObject* MakeCWeenieObject(uint iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CWeenieObject*>)0x0054BB30)(iid);
    // GlobalEventHandler* __cdecl CFactory::MakeGlobalEventHandler()
    public static ACBindings.GlobalEventHandler* MakeGlobalEventHandler() => ((delegate* unmanaged[Cdecl]<ACBindings.GlobalEventHandler*>)0x0054BB50)();
    // QualityRegistrar* __cdecl CFactory::MakeQualityRegistrar()
    public static ACBindings.QualityRegistrar* MakeQualityRegistrar() => ((delegate* unmanaged[Cdecl]<ACBindings.QualityRegistrar*>)0x0054BB70)();
    // QualityRegistrar* __thiscall CFactory::MakeQualityRegistrar_Internal(CFactory*)
    public ACBindings.QualityRegistrar* MakeQualityRegistrar_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CFactory, ACBindings.QualityRegistrar*>)0x0054BB90)(ref this);
    // CCommunicationSystem* __cdecl CFactory::MakeCCommunicationSystem()
    public static ACBindings.CCommunicationSystem* MakeCCommunicationSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.CCommunicationSystem*>)0x0054BBB0)();
    // CCommunicationSystem* __thiscall CFactory::MakeCCommunicationSystem_Internal(CFactory*)
    public ACBindings.CCommunicationSystem* MakeCCommunicationSystem_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CFactory, ACBindings.CCommunicationSystem*>)0x0054BBD0)(ref this);
    // int __cdecl CFactory::MakeSmartBox(int)
    public static int MakeSmartBox(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0054BBF0)(a1);
    // char* __stdcall CFactory::MakeSmartBox_Internal(int)
    public static sbyte* MakeSmartBox_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte*>)0x0054BC10)(a1);
}

