namespace ACBindings.Internal;


/// <summary>Central factory responsible for constructing system components—communication systems, client caches, command interpreters, event handlers, and quality registrars—and exposing a global instance to the application.</summary>
public unsafe struct CFactory
{
    // Statics
    public static ACBindings.Internal.CFactory** global_cfactory = (ACBindings.Internal.CFactory**)0x00846FD4;

    // Child Types

    /// <summary>Defines the virtual function table for the CFactory object, exposing methods to create internal components such as command interpreters, caches, weenie objects, event handlers, quality registrars, and communication systems.</summary>
    public unsafe struct CFactory_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, void> CFactory_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.CommandInterpreter*> MakeCommandInterpreter_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.CLCache*> Make_Client_Cache_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, uint, ACBindings.Internal.CWeenieObject*> MakeCWeenieObject_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.GlobalEventHandler*> MakeGlobalEventHandler_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.QualityRegistrar*> MakeQualityRegistrar_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CFactory*, ACBindings.Internal.CCommunicationSystem*> MakeCCommunicationSystem_Internal; // function pointer
        public System.IntPtr MakeSmartBox_Internal;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Releases resources associated with the global CFactory instance by invoking its internal cleanup routine and resetting the global reference to null.
    /// <code>Offset: 0x0054BA90
    /// void __cdecl CFactory::CleanUp()</code>
    /// </summary>
    public static void CleanUp() => ((delegate* unmanaged[Cdecl]<void>)0x0054BA90)();

    /// <summary>Allocates memory for a new CommandInterpreter and invokes its constructor.
    /// <code>Offset: 0x0054BAB0
    /// CommandInterpreter* __thiscall CFactory::MakeCommandInterpreter_Internal(CFactory*)</code>
    /// </summary>
    /// <param name="this">The CFactory instance requesting creation of a command interpreter.</param>
    /// <returns>A pointer to the newly constructed CommandInterpreter, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.CommandInterpreter* MakeCommandInterpreter_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.CommandInterpreter*>)0x0054BAB0)(ref this);

    /// <summary>Creates a CommandInterpreter by delegating to the global CFactory instance. Returns null when no factory is configured.
    /// <code>Offset: 0x0054BAD0
    /// CommandInterpreter* __cdecl CFactory::MakeCommandInterpreter()</code>
    /// </summary>
    /// <returns>A pointer to a new or existing CommandInterpreter, or nullptr if the global factory is unavailable.</returns>
    public static ACBindings.Internal.CommandInterpreter* MakeCommandInterpreter() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CommandInterpreter*>)0x0054BAD0)();

    /// <summary>Creates and returns a new client cache instance via the global factory.
    /// <code>Offset: 0x0054BAF0
    /// CLCache* __cdecl CFactory::Make_Client_Cache()</code>
    /// </summary>
    /// <returns>A pointer to the initialized CLCache object, or nullptr when no factory is available.</returns>
    public static ACBindings.Internal.CLCache* Make_Client_Cache() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLCache*>)0x0054BAF0)();

    /// <summary>Create and initialize a client cache instance for the factory.
    /// <code>Offset: 0x0054BB10
    /// CLCache* __thiscall CFactory::Make_Client_Cache_Internal(CFactory*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed CLCache object; returns nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.CLCache* Make_Client_Cache_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.CLCache*>)0x0054BB10)(ref this);

    /// <summary>Creates a new CWeenieObject instance for the specified identifier using the global factory, or returns null if no factory exists.
    /// <code>Offset: 0x0054BB30
    /// CWeenieObject* __cdecl CFactory::MakeCWeenieObject(unsigned int)</code>
    /// </summary>
    /// <param name="iid">Identifier specifying which type of object to create.</param>
    /// <returns>Pointer to the created CWeenieObject; null if creation fails or the global factory is unavailable.</returns>
    public static ACBindings.Internal.CWeenieObject* MakeCWeenieObject(uint iid) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CWeenieObject*>)0x0054BB30)(iid);

    /// <summary>Retrieves the GlobalEventHandler from the globally stored CFactory instance, returning nullptr when none exists.
    /// <code>Offset: 0x0054BB50
    /// GlobalEventHandler* __cdecl CFactory::MakeGlobalEventHandler()</code>
    /// </summary>
    /// <returns>A pointer to a GlobalEventHandler or null if no global factory is configured.</returns>
    public static ACBindings.Internal.GlobalEventHandler* MakeGlobalEventHandler() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GlobalEventHandler*>)0x0054BB50)();

    /// <summary>Retrieves a QualityRegistrar via the global CFactory instance, returning nullptr if none is present.
    /// <code>Offset: 0x0054BB70
    /// QualityRegistrar* __cdecl CFactory::MakeQualityRegistrar()</code>
    /// </summary>
    /// <returns>Pointer to a QualityRegistrar provided by the global factory, or null when the global factory is unset.</returns>
    public static ACBindings.Internal.QualityRegistrar* MakeQualityRegistrar() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.QualityRegistrar*>)0x0054BB70)();

    /// <summary>Creates a new QualityRegistrar, initializing its internal handler tables and registering the instance as the global registrar.
    /// <code>Offset: 0x0054BB90
    /// QualityRegistrar* __thiscall CFactory::MakeQualityRegistrar_Internal(CFactory*)</code>
    /// </summary>
    /// <param name="this">Pointer to the CFactory instance that invoked this creation routine.</param>
    /// <returns>Pointer to the freshly constructed QualityRegistrar or null if memory allocation fails.</returns>
    public ACBindings.Internal.QualityRegistrar* MakeQualityRegistrar_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.QualityRegistrar*>)0x0054BB90)(ref this);

    /// <summary>Obtains a communication system instance through the global factory; returns nullptr when the factory is unavailable.
    /// <code>Offset: 0x0054BBB0
    /// CCommunicationSystem* __cdecl CFactory::MakeCCommunicationSystem()</code>
    /// </summary>
    /// <returns>A pointer to a CCommunicationSystem object, or null if no global factory exists.</returns>
    public static ACBindings.Internal.CCommunicationSystem* MakeCCommunicationSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CCommunicationSystem*>)0x0054BBB0)();

    /// <summary>Creates a new communication system instance using the factory's internal construction logic.
    /// <code>Offset: 0x0054BBD0
    /// CCommunicationSystem* __thiscall CFactory::MakeCCommunicationSystem_Internal(CFactory*)</code>
    /// </summary>
    /// <returns>A pointer to the freshly constructed CCommunicationSystem, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.CCommunicationSystem* MakeCCommunicationSystem_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CFactory, ACBindings.Internal.CCommunicationSystem*>)0x0054BBD0)(ref this);

    /// <summary>Creates a smart box using the global CFactory instance; returns an integer handle or zero on failure.
    /// <code>Offset: 0x0054BBF0
    /// int __cdecl CFactory::MakeSmartBox(int)</code>
    /// </summary>
    /// <param name="a1">Identifier specifying which smart box to create.</param>
    /// <returns>An integer identifier of the created smart box, or 0 if no factory is available.</returns>
    public static int MakeSmartBox(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0054BBF0)(a1);

    /// <summary>Allocates 280 bytes of memory and constructs a SmartBox with the supplied argument; returns a pointer to the created object or null if allocation fails.
    /// <code>Offset: 0x0054BC10
    /// char* __stdcall CFactory::MakeSmartBox_Internal(int)</code>
    /// </summary>
    /// <param name="a1">Identifier or configuration value passed to the SmartBox constructor.</param>
    /// <returns>A pointer to the newly created SmartBox instance, or null when memory allocation cannot be satisfied.</returns>
    public static sbyte* MakeSmartBox_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte*>)0x0054BC10)(a1);
}

