namespace ACBindings;

// ACCFactory
public unsafe struct ACCFactory
{
    // Base Classes
    public ACBindings.CFactory BaseClass_CFactory; // ACBindings.CFactory

    // Child Types
    // ACCFactory_vtbl
    public unsafe struct ACCFactory_vtbl
    {
        // Members
        public System.IntPtr ACCFactory_dtor_0; // function pointer
        public System.IntPtr MakeCommandInterpreter_Internal; // function pointer
        public System.IntPtr Make_Client_Cache_Internal; // function pointer
        public System.IntPtr MakeCWeenieObject_Internal; // function pointer
        public System.IntPtr MakeGlobalEventHandler_Internal; // function pointer
        public System.IntPtr MakeQualityRegistrar_Internal; // function pointer
        public System.IntPtr MakeCCommunicationSystem_Internal; // function pointer
        public System.IntPtr MakeSmartBox_Internal;

        // Methods
    }

    // Methods
    // CommandInterpreter* __thiscall ACCFactory::MakeCommandInterpreter_Internal(ACCFactory*)
    public ACBindings.CommandInterpreter* MakeCommandInterpreter_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCFactory, ACBindings.CommandInterpreter*>)0x00557F60)(ref this);
    // CLCache* __thiscall ACCFactory::Make_Client_Cache_Internal(ACCFactory*)
    public ACBindings.CLCache* Make_Client_Cache_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCFactory, ACBindings.CLCache*>)0x00557F80)(ref this);
    // CWeenieObject* __thiscall ACCFactory::MakeCWeenieObject_Internal(ACCFactory*,unsigned int)
    public ACBindings.CWeenieObject* MakeCWeenieObject_Internal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCFactory, uint, ACBindings.CWeenieObject*>)0x00557FA0)(ref this, iid);
    // GlobalEventHandler* __thiscall ACCFactory::MakeGlobalEventHandler_Internal(ACCFactory*)
    public ACBindings.GlobalEventHandler* MakeGlobalEventHandler_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCFactory, ACBindings.GlobalEventHandler*>)0x00557FC0)(ref this);
    // CCommunicationSystem* __thiscall ACCFactory::MakeCCommunicationSystem_Internal(ACCFactory*)
    public ACBindings.CCommunicationSystem* MakeCCommunicationSystem_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCFactory, ACBindings.CCommunicationSystem*>)0x00557FE0)(ref this);
    // char* __stdcall ACCFactory::MakeSmartBox_Internal(int)
    public static sbyte* MakeSmartBox_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte*>)0x00558000)(a1);
    // void __cdecl ACCFactory::Init()
    public static void Init() => ((delegate* unmanaged[Cdecl]<void>)0x00558230)();
}

