namespace ACBindings.Internal;

public unsafe struct GlobalRegistryInstance : System.IDisposable
{
    // Members
    public ACBindings.Internal.CircularArray__sbyte m_Characters;
    public ACBindings.Internal.HashTable___PStringBase__sbyte___GRPCommand_ptr m_CommandHash;
    public ACBindings.Internal.HashTable___PStringBase__sbyte___GRPObject_ptr m_ObjectHash;
    public ACBindings.Internal.SmartArray___IConsoleCallbackObject_ptr m_ConsoleCallbackObjects;

    // Generated Constructor
    public GlobalRegistryInstance() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether the global registry contains any registered commands or non‑empty objects.
    /// <code>Offset: 0x00432FA0
    /// bool __thiscall GlobalRegistryInstance::IsEmpty(GlobalRegistryInstance*)</code>
    /// </summary>
    /// <returns>True if the command hash table is empty and every stored object reports an empty state; otherwise false.</returns>
    public byte IsEmpty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryInstance, byte>)0x00432FA0)(ref this);

    /// <summary>Iterates over the registry’s command table and then scans its object hash table for entries that are no longer referenced, invoking each such object's cleanup method to free resources.
    /// <code>Offset: 0x00433020
    /// void __thiscall GlobalRegistryInstance::CheckForLeakedData(GlobalRegistryInstance*)</code>
    /// </summary>
    public void CheckForLeakedData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryInstance, void>)0x00433020)(ref this);

    /// <summary>Searches the global registry for a command matching the supplied name (case‑insensitive) and writes the resulting command pointer into an output parameter.
    /// <code>Offset: 0x00433660
    /// char __thiscall GlobalRegistryInstance::FindCommandByName(_DWORD*,volatile LONG**,volatile LONG*)</code>
    /// </summary>
    /// <param name="a2">Reference to a reference‑counted string that holds the command name to look up; the function temporarily increments its reference count during the search.</param>
    /// <param name="String">Output location where the found command’s address will be stored. It is set to zero if no matching command exists.</param>
    /// <returns>Non‑zero when a matching command is located, otherwise zero.</returns>
    public sbyte FindCommandByName(int** a2, int* String) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryInstance, int**, int*, sbyte>)0x00433660)(ref this, a2, String);

    /// <summary>Finds an object in the global registry by name, storing a pointer to the found object in the supplied output parameter and returning whether the search succeeded.
    /// <code>Offset: 0x00433710
    /// char __thiscall GlobalRegistryInstance::FindObjectByName(_DWORD*,volatile LONG**,volatile LONG*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string containing the object's name to look up; the function normalizes this string to lowercase before searching.</param>
    /// <param name="String">Output parameter that receives the found object's pointer. It is set to null if no matching object exists.</param>
    /// <returns>1 if an object with the specified name is present in the registry, otherwise 0.</returns>
    public sbyte FindObjectByName(int** a2, int* String) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryInstance, int**, int*, sbyte>)0x00433710)(ref this, a2, String);

    /// <summary>Initializes a GlobalRegistryInstance by clearing its character buffer, command and object hash tables, and console callback array, preparing it for use.
    /// <code>Offset: 0x00433D20
    /// void __thiscall GlobalRegistryInstance::GlobalRegistryInstance(GlobalRegistryInstance*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryInstance, void>)0x00433D20)(ref this);

    /// <summary>Destroys a GlobalRegistryInstance, freeing all registered objects, commands, and console callback objects while resetting internal hash tables.
    /// <code>Offset: 0x00433D80
    /// void __thiscall GlobalRegistryInstance::~GlobalRegistryInstance(GlobalRegistryInstance*)</code>
    /// </summary>
    /// <param name="this">The instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryInstance, void>)0x00433D80)(ref this);

    /// <summary>Outputs detailed information about a registry object specified by its name to the console, or reports an error if the name is unrecognized.
    /// <code>Offset: 0x00434180
    /// char __cdecl GlobalRegistryInstance::ConsoleCommand_Dump(volatile LONG***)</code>
    /// </summary>
    /// <param name="String">Array of arguments supplied to the command; the first element must contain the object's name.</param>
    /// <returns>1 when the object was found and dumped successfully; 0 otherwise.</returns>
    public static sbyte ConsoleCommand_Dump(int*** String) => ((delegate* unmanaged[Cdecl]<int***, sbyte>)0x00434180)(String);

    /// <summary>Sets a global registry variable identified by the first argument to the value supplied in subsequent arguments, or dumps its state when a special flag is provided.
    /// <code>Offset: 0x004342D0
    /// char __cdecl GlobalRegistryInstance::ConsoleCommand_Set(const char***)</code>
    /// </summary>
    /// <param name="String">Array of strings containing console command arguments; the first element specifies the target object, and following elements provide the new value(s).</param>
    /// <returns>Non‑zero if the operation succeeded; zero otherwise.</returns>
    public static sbyte ConsoleCommand_Set(sbyte*** String) => ((delegate* unmanaged[Cdecl]<sbyte***, sbyte>)0x004342D0)(String);

    /// <summary>Toggles a boolean variable on a specified object within the global registry. The command accepts an argument list, locates the target object, flips its boolean state, and outputs the new value.
    /// <code>Offset: 0x00434560
    /// char __cdecl GlobalRegistryInstance::ConsoleCommand_Toggle(volatile LONG***)</code>
    /// </summary>
    /// <param name="String">An array of strings containing the command arguments; the first element is used to identify the target object, and subsequent elements reference the variable to toggle.</param>
    /// <returns>Non‑zero if the operation succeeded (the variable was toggled); zero if the object or variable could not be found or the data type is unsupported.</returns>
    public static sbyte ConsoleCommand_Toggle(int*** String) => ((delegate* unmanaged[Cdecl]<int***, sbyte>)0x00434560)(String);

    /// <summary>Lists all registered console commands by printing each command’s name and description in alphabetical order.
    /// <code>Offset: 0x004346F0
    /// bool __cdecl GlobalRegistryInstance::ConsoleCommand_ListCommands()</code>
    /// </summary>
    /// <returns>True after displaying the list of commands.</returns>
    public static byte ConsoleCommand_ListCommands() => ((delegate* unmanaged[Cdecl]<byte>)0x004346F0)();

    /// <summary>Lists all registered objects by printing their names and descriptions in alphabetical order.
    /// <code>Offset: 0x004349D0
    /// bool __cdecl GlobalRegistryInstance::ConsoleCommand_ListObjects()</code>
    /// </summary>
    /// <returns>True to indicate successful execution of the command.</returns>
    public static byte ConsoleCommand_ListObjects() => ((delegate* unmanaged[Cdecl]<byte>)0x004349D0)();

    /// <summary>Displays help for a specified console command or lists all commands and objects when invoked without arguments.
    /// <code>Offset: 0x00434CB0
    /// bool __cdecl GlobalRegistryInstance::ConsoleCommand_Help(volatile LONG***)</code>
    /// </summary>
    /// <param name="m_charbuffer">Pointer to the parsed argument buffer containing the command name; if null or empty, triggers listing of available commands and objects.</param>
    /// <returns>True when help or listings are successfully displayed; false if the requested command cannot be found.</returns>
    public static byte ConsoleCommand_Help(int*** m_charbuffer) => ((delegate* unmanaged[Cdecl]<int***, byte>)0x00434CB0)(m_charbuffer);
}

