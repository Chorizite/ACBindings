namespace ACBindings.Internal;


/// <summary>Central repository for runtime commands, variables and console callbacks, enabling registration, lookup, and execution throughout the application.</summary>
public unsafe struct GlobalRegistry
{
    // Statics
    public static ACBindings.Internal.GlobalRegistryInstance** s_pcGlobalRegistry = (ACBindings.Internal.GlobalRegistryInstance**)0x008380C8;

    // Methods

    /// <summary>Creates a global registry instance on first call, ensuring a single shared registry exists for the lifetime of the application.
    /// <code>Offset: 0x00401750
    /// void __cdecl GlobalRegistry::GetRegistry()</code>
    /// </summary>
    public static void GetRegistry() => ((delegate* unmanaged[Cdecl]<void>)0x00401750)();

    /// <summary>Removes the specified console callback object from the global registry so that it no longer receives console notifications.
    /// <code>Offset: 0x004352E0
    /// void __cdecl GlobalRegistry::UnregisterConsoleCallbackObject(IConsoleCallbackObject*)</code>
    /// </summary>
    /// <param name="io_pConsoleCallbackObject">The console callback object to unregister.</param>
    public static void UnregisterConsoleCallbackObject(ACBindings.Internal.IConsoleCallbackObject* io_pConsoleCallbackObject) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IConsoleCallbackObject*, void>)0x004352E0)(io_pConsoleCallbackObject);

    /// <summary>Writes the supplied text into the global registry’s circular buffer and triggers registered callbacks with the original data pointer.
    /// <code>Offset: 0x004355A0
    /// void __cdecl GlobalRegistry::OutputText(_DWORD*)</code>
    /// </summary>
    /// <param name="a1">A pointer to a data block containing the text to output; the first element points to the character array, and four bytes immediately before that address store its length.</param>
    public static void OutputText(int* a1) => ((delegate* unmanaged[Cdecl]<int*, void>)0x004355A0)(a1);

    /// <summary>Registers an IConsoleCallbackObject with the global console callback registry, creating the registry instance if it does not yet exist and allocating storage for the new entry as needed.
    /// <code>Offset: 0x00436120
    /// void __cdecl GlobalRegistry::RegisterConsoleCallbackObject(IConsoleCallbackObject*)</code>
    /// </summary>
    /// <param name="io_pConsoleCallbackObject">The console callback object to add to the registry.</param>
    public static void RegisterConsoleCallbackObject(ACBindings.Internal.IConsoleCallbackObject* io_pConsoleCallbackObject) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IConsoleCallbackObject*, void>)0x00436120)(io_pConsoleCallbackObject);

    /// <summary>
    /// Parses a reference‑counted string buffer into command arguments, looks up the command in the global registry, and executes it if available. On failure or an unknown command, writes an error message into the supplied buffer.
    /// 
    /// <code>Offset: 0x00436190
    /// LONG __cdecl GlobalRegistry::ProcessCommand(volatile LONG**)</code>
    /// </summary>
    /// <param name="m_charbuffer">Pointer to a volatile LONG* that references a reference‑counted command string buffer; may be updated with new output text during processing.</param>
    /// <returns>A LONG value representing the outcome of the operation (typically the resulting reference count after decrementing); zero indicates the buffer was freed.</returns>
    public static int ProcessCommand(int** m_charbuffer) => ((delegate* unmanaged[Cdecl]<int**, int>)0x00436190)(m_charbuffer);

    /// <summary>Registers a no‑argument command in the global registry using the specified name and associated data.
    /// <code>Offset: 0x00436580
    /// void __cdecl GlobalRegistry::RegisterCommand(int,const char**,int*)</code>
    /// </summary>
    /// <param name="a1">Command type or flag that determines how the command should be handled.</param>
    /// <param name="a2">Pointer to a C‑string containing the command's name. The function searches for an existing entry before creating a new one.</param>
    /// <param name="a3">Pointer to an integer value (or data structure) associated with the command, which is stored in the registry entry.</param>
    public static void RegisterCommand(int a1, sbyte** a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, sbyte**, int*, void>)0x00436580)(a1, a2, a3);

    /// <summary>Registers a new command into the global registry using the supplied name and argument descriptors. The command name is converted to lowercase before storage, and registration occurs only if the command does not already exist.
    /// <code>Offset: 0x004366D0
    /// void __cdecl GlobalRegistry::RegisterCommand(int,const char**,int*,int*)</code>
    /// </summary>
    /// <param name="a1">Identifier or type for the command, stored in the command record.</param>
    /// <param name="a2">Pointer to a string containing the command name (may be an array of strings).</param>
    /// <param name="a3">Pointer to an integer used as part of the command's argument descriptor.</param>
    /// <param name="a4">Pointer to another integer used as part of the command's argument descriptor.</param>
    public static void RegisterCommand(int a1, sbyte** a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<int, sbyte**, int*, int*, void>)0x004366D0)(a1, a2, a3, a4);

    /// <summary>Removes a registered command by its name from the global registry, updating reference counts and freeing associated resources. If the registry becomes empty after removal, destroys the singleton instance.
    /// <code>Offset: 0x00436830
    /// void __cdecl GlobalRegistry::UnregisterCommand(char**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a string that holds the command name to be unregistered.</param>
    public static void UnregisterCommand(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x00436830)(a1);

    /// <summary>Registers a variable or command in the global registry using the supplied name, type information, data pointers, and optional argument list. Handles duplicate registrations by removing existing entries, normalizes names to lowercase, and manages reference counting for allocated resources.
    /// <code>Offset: 0x004369A0
    /// LONG __cdecl GlobalRegistry::RegisterVariableInternal(void*,void*,const char**,int*,void*,char*,int,int)</code>
    /// </summary>
    /// <param name="a1">Primary data pointer associated with the registration (e.g., value or object).</param>
    /// <param name="a2">Secondary data pointer (often a default value or related object).</param>
    /// <param name="a3">Pointer to the null‑terminated string that serves as the registry key.</param>
    /// <param name="a4">Pointer to an array of integers providing type or flag information for the variable.</param>
    /// <param name="a5">Additional user data or callback pointer associated with the registration.</param>
    /// <param name="SubStr">Delimiter string used when parsing the name; defaults to a single space if null.</param>
    /// <param name="a7">Base address of an integer array containing argument values, or zero if no arguments are supplied.</param>
    /// <param name="a8">Number of elements in the argument array referenced by a7.</param>
    /// <returns>Zero on success; non‑zero error code otherwise.</returns>
    public static int RegisterVariableInternal(System.IntPtr a1, System.IntPtr a2, sbyte** a3, int* a4, System.IntPtr a5, sbyte* SubStr, int a7, int a8) => ((delegate* unmanaged[Cdecl]<System.IntPtr, System.IntPtr, sbyte**, int*, System.IntPtr, sbyte*, int, int, int>)0x004369A0)(a1, a2, a3, a4, a5, SubStr, a7, a8);

    /// <summary>Unregisters a variable from the global registry using the provided name pointer, removing associated commands and cleaning up resources. If the registry becomes empty after removal, it is destroyed.
    /// <code>Offset: 0x00436CF0
    /// void __cdecl GlobalRegistry::UnregisterVariable(char**)</code>
    /// </summary>
    /// <param name="a1">Pointer to the C-style string containing the name of the variable to be unregistered.</param>
    public static void UnregisterVariable(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, void>)0x00436CF0)(a1);

    /// <summary>Retrieves a byte‑valued variable from the global registry by searching for an object identified through the first parameter and stores it at the address supplied by the second parameter.
    /// <code>Offset: 0x005D9DD0
    /// char __thiscall GlobalRegistry::InqTypedVariable(volatile LONG**,_BYTE*)</code>
    /// </summary>
    /// <param name="this">Pointer to the identifier (typically a string or ID) used to locate the desired object within the global registry.</param>
    /// <param name="a2">Address where the retrieved byte value will be written if the object is found and its type matches the expected format.</param>
    /// <returns>Zero if no matching object is found, the object's data type does not match, or another lookup failure occurs; non‑zero otherwise (does not guarantee that a2 has been updated).</returns>
    public sbyte InqTypedVariable(byte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistry, byte*, sbyte>)0x005D9DD0)(ref this, a2);

    /// <summary>Retrieves a DWORD value from the global registry using the supplied variable name, indicating success via the return value and writing the result to the provided out parameter.
    /// <code>Offset: 0x005D9E40
    /// char __thiscall GlobalRegistry::InqTypedVariable(volatile LONG**,_DWORD*)</code>
    /// </summary>
    /// <param name="variableName">Pointer to the variable name used as key in the registry lookup.</param>
    /// <param name="valueOut">Output location where the retrieved DWORD will be stored on successful lookup.</param>
    /// <returns>Non‑zero if the variable was found and successfully read; zero otherwise.</returns>
    public sbyte InqTypedVariable(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistry, int*, sbyte>)0x005D9E40)(ref this, a2);
}

