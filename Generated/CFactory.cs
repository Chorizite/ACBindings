namespace ACBindings.Internal;

public unsafe struct CFactory
{
    // Statics
    public static ACBindings.Internal.CFactory* global_cfactory = (ACBindings.Internal.CFactory*)0x00846FD4;

    // Child Types
    public unsafe struct CFactory_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, void> CFactory_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.CommandInterpreter*> MakeCommandInterpreter_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.CLCache*> Make_Client_Cache_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, uint, ACBindings.Internal.CWeenieObject*> MakeCWeenieObject_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.GlobalEventHandler*> MakeGlobalEventHandler_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.QualityRegistrar*> MakeQualityRegistrar_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.CCommunicationSystem*> MakeCCommunicationSystem_Internal; // function pointer
        public System.IntPtr MakeSmartBox_Internal;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>
    /// <code>Offset: 0x0054BA90
    /// void __cdecl CFactory::CleanUp()</code>
    /// </summary>
    public static void CleanUp() => ((delegate* unmanaged[Cdecl]<void>)0x0054BA90)();

    /// <summary>
    /// <code>Offset: 0x0054BAB0
    /// CommandInterpreter* __thiscall CFactory::MakeCommandInterpreter_Internal(CFactory*)</code>
    /// </summary>
    public ACBindings.Internal.CommandInterpreter* MakeCommandInterpreter_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.CommandInterpreter*>)0x0054BAB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054BAD0
    /// CommandInterpreter* __cdecl CFactory::MakeCommandInterpreter()</code>
    /// </summary>
    public static ACBindings.Internal.CommandInterpreter* MakeCommandInterpreter() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CommandInterpreter*>)0x0054BAD0)();

    /// <summary>
    /// <code>Offset: 0x0054BAF0
    /// CLCache* __cdecl CFactory::Make_Client_Cache()</code>
    /// </summary>
    public static ACBindings.Internal.CLCache* Make_Client_Cache() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLCache*>)0x0054BAF0)();

    /// <summary>
    /// <code>Offset: 0x0054BB10
    /// CLCache* __thiscall CFactory::Make_Client_Cache_Internal(CFactory*)</code>
    /// </summary>
    public ACBindings.Internal.CLCache* Make_Client_Cache_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.CLCache*>)0x0054BB10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054BB30
    /// CWeenieObject* __cdecl CFactory::MakeCWeenieObject(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CWeenieObject* MakeCWeenieObject(uint iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CWeenieObject*>)0x0054BB30)(iid);

    /// <summary>
    /// <code>Offset: 0x0054BB50
    /// GlobalEventHandler* __cdecl CFactory::MakeGlobalEventHandler()</code>
    /// </summary>
    public static ACBindings.Internal.GlobalEventHandler* MakeGlobalEventHandler() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GlobalEventHandler*>)0x0054BB50)();

    /// <summary>
    /// <code>Offset: 0x0054BB70
    /// QualityRegistrar* __cdecl CFactory::MakeQualityRegistrar()</code>
    /// </summary>
    public static ACBindings.Internal.QualityRegistrar* MakeQualityRegistrar() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.QualityRegistrar*>)0x0054BB70)();

    /// <summary>
    /// <code>Offset: 0x0054BB90
    /// QualityRegistrar* __thiscall CFactory::MakeQualityRegistrar_Internal(CFactory*)</code>
    /// </summary>
    public ACBindings.Internal.QualityRegistrar* MakeQualityRegistrar_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.QualityRegistrar*>)0x0054BB90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054BBB0
    /// CCommunicationSystem* __cdecl CFactory::MakeCCommunicationSystem()</code>
    /// </summary>
    public static ACBindings.Internal.CCommunicationSystem* MakeCCommunicationSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CCommunicationSystem*>)0x0054BBB0)();

    /// <summary>
    /// <code>Offset: 0x0054BBD0
    /// CCommunicationSystem* __thiscall CFactory::MakeCCommunicationSystem_Internal(CFactory*)</code>
    /// </summary>
    public ACBindings.Internal.CCommunicationSystem* MakeCCommunicationSystem_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.CCommunicationSystem*>)0x0054BBD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0054BBF0
    /// int __cdecl CFactory::MakeSmartBox(int)</code>
    /// </summary>
    public static int MakeSmartBox(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0054BBF0)(a1);

    /// <summary>
    /// <code>Offset: 0x0054BC10
    /// char* __stdcall CFactory::MakeSmartBox_Internal(int)</code>
    /// </summary>
    public static sbyte* MakeSmartBox_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte*>)0x0054BC10)(a1);
}

