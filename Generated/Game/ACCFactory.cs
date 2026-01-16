namespace ACBindings.Internal;


/// <summary>Provides factory methods for creating and initializing core components of the ACC subsystem, including communication systems, client caches, weenie objects, command interpreters, global event handlers, and smart boxes.</summary>
/// <remarks>Derived from CFactory, it registers itself with the InterfaceSystem during Init() and stores a global reference for subsequent component creation.</remarks>
public unsafe struct ACCFactory
{
    // Base Classes
    public ACBindings.Internal.CFactory BaseClass_CFactory; // ACBindings.Internal.CFactory

    // Child Types
    public unsafe struct ACCFactory_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, void> ACCFactory_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.CommandInterpreter*> MakeCommandInterpreter_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.CLCache*> Make_Client_Cache_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, uint, ACBindings.Internal.CWeenieObject*> MakeCWeenieObject_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.GlobalEventHandler*> MakeGlobalEventHandler_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.QualityRegistrar*> MakeQualityRegistrar_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.CCommunicationSystem*> MakeCCommunicationSystem_Internal; // function pointer
        public System.IntPtr MakeSmartBox_Internal;

        // Methods
    }

    // Methods

    /// <summary>Creates and initializes a new CommandInterpreter object, setting up its internal structures and registering it with the global event handler.
    /// <code>Offset: 0x00557F60
    /// CommandInterpreter* __thiscall ACCFactory::MakeCommandInterpreter_Internal(ACCFactory*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed CommandInterpreter, or null if memory allocation fails.</returns>
    public ACBindings.Internal.CommandInterpreter* MakeCommandInterpreter_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.CommandInterpreter*>)0x00557F60)(ref this);

    /// <summary>Create and initialize a new client cache instance.
    /// <code>Offset: 0x00557F80
    /// CLCache* __thiscall ACCFactory::Make_Client_Cache_Internal(ACCFactory*)</code>
    /// </summary>
    /// <returns>A pointer to the freshly allocated CLCache object, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.CLCache* Make_Client_Cache_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.CLCache*>)0x00557F80)(ref this);

    /// <summary>Creates a new ACCWeenieObject with the specified identifier, allocating memory and invoking its constructor.
    /// <code>Offset: 0x00557FA0
    /// CWeenieObject* __thiscall ACCFactory::MakeCWeenieObject_Internal(ACCFactory*,unsigned int)</code>
    /// </summary>
    /// <param name="iid">Identifier for the newly created Weenie object.</param>
    /// <returns>A pointer to the constructed CWeenieObject, or null if memory allocation fails.</returns>
    public ACBindings.Internal.CWeenieObject* MakeCWeenieObject_Internal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, uint, ACBindings.Internal.CWeenieObject*>)0x00557FA0)(ref this, iid);

    /// <summary>Creates a new GlobalEventHandler instance, initializing its base NoticeRegistrar vtable and preparing it for use.
    /// <code>Offset: 0x00557FC0
    /// GlobalEventHandler* __thiscall ACCFactory::MakeGlobalEventHandler_Internal(ACCFactory*)</code>
    /// </summary>
    /// <param name="this">Reference to the ACCFactory creating the handler.</param>
    /// <returns>A pointer to the newly constructed GlobalEventHandler, or null if memory allocation fails.</returns>
    public ACBindings.Internal.GlobalEventHandler* MakeGlobalEventHandler_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.GlobalEventHandler*>)0x00557FC0)(ref this);

    /// <summary>Creates a new communication system instance for the factory by allocating memory and initializing its components.
    /// <code>Offset: 0x00557FE0
    /// CCommunicationSystem* __thiscall ACCFactory::MakeCCommunicationSystem_Internal(ACCFactory*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created CCommunicationSystem object, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.CCommunicationSystem* MakeCCommunicationSystem_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.CCommunicationSystem*>)0x00557FE0)(ref this);

    /// <summary>Create a SmartBox instance with specified configuration and return its pointer.
    /// <code>Offset: 0x00558000
    /// char* __stdcall ACCFactory::MakeSmartBox_Internal(int)</code>
    /// </summary>
    /// <param name="a1">Parameter forwarded to the SmartBox constructor; determines the object's configuration.</param>
    /// <returns>A pointer to the newly constructed SmartBox, or null if memory allocation fails.</returns>
    public static sbyte* MakeSmartBox_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte*>)0x00558000)(a1);

    /// <summary>Initializes the ACCFactory by registering its interface with the InterfaceSystem and storing its vftable in the global factory reference.
    /// <code>Offset: 0x00558230
    /// void __cdecl ACCFactory::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x00558230)();
}

