namespace ACBindings;

// GlobalRegistryInstance
public unsafe struct GlobalRegistryInstance : System.IDisposable
{
    // Members
    public ACBindings.CircularArray__sbyte m_Characters;
    public ACBindings.HashTable__PStringBase__sbyte__GRPCommand_ptr m_CommandHash;
    public ACBindings.HashTable__PStringBase__sbyte__GRPObject_ptr m_ObjectHash;
    public ACBindings.SmartArray__IConsoleCallbackObject_ptr m_ConsoleCallbackObjects;

    // Generated Constructor
    public GlobalRegistryInstance() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall GlobalRegistryInstance::IsEmpty(GlobalRegistryInstance*)
    public byte IsEmpty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryInstance, byte>)0x00432FA0)(ref this);
    // void __thiscall GlobalRegistryInstance::CheckForLeakedData(GlobalRegistryInstance*)
    public void CheckForLeakedData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryInstance, void>)0x00433020)(ref this);
    // char __thiscall GlobalRegistryInstance::FindCommandByName(_DWORD*,volatile LONG**,volatile LONG*)
    public sbyte FindCommandByName(int** a2, int* String) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryInstance, int**, int*, sbyte>)0x00433660)(ref this, a2, String);
    // char __thiscall GlobalRegistryInstance::FindObjectByName(_DWORD*,volatile LONG**,volatile LONG*)
    public sbyte FindObjectByName(int** a2, int* String) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryInstance, int**, int*, sbyte>)0x00433710)(ref this, a2, String);
    // void __thiscall GlobalRegistryInstance::GlobalRegistryInstance(GlobalRegistryInstance*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryInstance, void>)0x00433D20)(ref this);
    // void __thiscall GlobalRegistryInstance::~GlobalRegistryInstance(GlobalRegistryInstance*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryInstance, void>)0x00433D80)(ref this);
    // char __cdecl GlobalRegistryInstance::ConsoleCommand_Dump(volatile LONG***)
    public static sbyte ConsoleCommand_Dump(int*** String) => ((delegate* unmanaged[Cdecl]<int***, sbyte>)0x00434180)(String);
    // char __cdecl GlobalRegistryInstance::ConsoleCommand_Set(const char***)
    public static sbyte ConsoleCommand_Set(sbyte*** String) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x004342D0)(String);
    // char __cdecl GlobalRegistryInstance::ConsoleCommand_Toggle(volatile LONG***)
    public static sbyte ConsoleCommand_Toggle(int*** String) => ((delegate* unmanaged[Cdecl]<int***, sbyte>)0x00434560)(String);
    // bool __cdecl GlobalRegistryInstance::ConsoleCommand_ListCommands()
    public static byte ConsoleCommand_ListCommands() => ((delegate* unmanaged[Cdecl]<byte>)0x004346F0)();
    // bool __cdecl GlobalRegistryInstance::ConsoleCommand_ListObjects()
    public static byte ConsoleCommand_ListObjects() => ((delegate* unmanaged[Cdecl]<byte>)0x004349D0)();
    // bool __cdecl GlobalRegistryInstance::ConsoleCommand_Help(volatile LONG***)
    public static byte ConsoleCommand_Help(int*** m_charbuffer) => ((delegate* unmanaged[Cdecl]<int***, byte>)0x00434CB0)(m_charbuffer);
}

