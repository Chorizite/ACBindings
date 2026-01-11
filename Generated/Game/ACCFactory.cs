namespace ACBindings.Internal;

public unsafe struct ACCFactory
{
    // Base Classes
    public ACBindings.Internal.CFactory BaseClass_CFactory; // ACBindings.Internal.CFactory

    // Child Types
    public unsafe struct ACCFactory_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, void> ACCFactory_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.CommandInterpreter*> MakeCommandInterpreter_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.CLCache*> Make_Client_Cache_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, uint, ACBindings.Internal.CWeenieObject*> MakeCWeenieObject_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.GlobalEventHandler*> MakeGlobalEventHandler_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.QualityRegistrar*> MakeQualityRegistrar_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCFactory*, ACBindings.Internal.CCommunicationSystem*> MakeCCommunicationSystem_Internal; // function pointer
        public System.IntPtr MakeSmartBox_Internal;

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00557F60
    /// CommandInterpreter* __thiscall ACCFactory::MakeCommandInterpreter_Internal(ACCFactory*)</code>
    /// </summary>
    public ACBindings.Internal.CommandInterpreter* MakeCommandInterpreter_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.CommandInterpreter*>)0x00557F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00557F80
    /// CLCache* __thiscall ACCFactory::Make_Client_Cache_Internal(ACCFactory*)</code>
    /// </summary>
    public ACBindings.Internal.CLCache* Make_Client_Cache_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.CLCache*>)0x00557F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00557FA0
    /// CWeenieObject* __thiscall ACCFactory::MakeCWeenieObject_Internal(ACCFactory*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CWeenieObject* MakeCWeenieObject_Internal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, uint, ACBindings.Internal.CWeenieObject*>)0x00557FA0)(ref this, iid);

    /// <summary>
    /// <code>Offset: 0x00557FC0
    /// GlobalEventHandler* __thiscall ACCFactory::MakeGlobalEventHandler_Internal(ACCFactory*)</code>
    /// </summary>
    public ACBindings.Internal.GlobalEventHandler* MakeGlobalEventHandler_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.GlobalEventHandler*>)0x00557FC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00557FE0
    /// CCommunicationSystem* __thiscall ACCFactory::MakeCCommunicationSystem_Internal(ACCFactory*)</code>
    /// </summary>
    public ACBindings.Internal.CCommunicationSystem* MakeCCommunicationSystem_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCFactory, ACBindings.Internal.CCommunicationSystem*>)0x00557FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00558000
    /// char* __stdcall ACCFactory::MakeSmartBox_Internal(int)</code>
    /// </summary>
    public static sbyte* MakeSmartBox_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte*>)0x00558000)(a1);

    /// <summary>
    /// <code>Offset: 0x00558230
    /// void __cdecl ACCFactory::Init()</code>
    /// </summary>
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x00558230)();
}

