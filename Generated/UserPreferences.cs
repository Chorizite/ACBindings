namespace ACBindings.Internal;


/// <summary>Manages user configuration data, loading from and saving to an INI file. Registers console commands for preference operations and interacts with a global registry of settings. Provides helper functions to query and modify individual preferences.</summary>
public unsafe struct UserPreferences
{
    // Statics
    public static byte* sm_bTools = (byte*)0x00818AFC;
    public static byte* sm_bPrefsLoadedOK = (byte*)0x00818AFD;
    public static ACBindings.Internal.PStringBase__sbyte* sm_strDefaultFile = (ACBindings.Internal.PStringBase__sbyte*)0x00838188;

    // Methods

    /// <summary>Registers a new user preference variable in the global registry, initializing the registry if necessary and marking the variable as active when found.
    /// <code>Offset: 0x004020E0
    /// char __thiscall UserPreferences::RegisterPreference(void*,volatile LONG**,int*,void*,char*,int,int)</code>
    /// </summary>
    /// <param name="String">Pointer to the preference name string used for lookup and registration.</param>
    /// <param name="a3">Optional type or metadata information associated with the preference.</param>
    /// <param name="a4">Pointer to a default value or additional data for the preference.</param>
    /// <param name="SubStr">Supplementary description or sub‑string related to the preference.</param>
    /// <param name="a6">First flag controlling registration behavior (e.g., visibility).</param>
    /// <param name="a7">Second flag influencing how the variable is stored or accessed.</param>
    /// <returns>Non‑zero if the preference was successfully registered and marked active; zero otherwise.</returns>
    public sbyte RegisterPreference(int** String, int* a3, System.IntPtr a4, sbyte* SubStr, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UserPreferences, int**, int*, System.IntPtr, sbyte*, int, int, sbyte>)0x004020E0)(ref this, String, a3, a4, SubStr, a6, a7);

    /// <summary>Registers a user preference in the global registry and returns whether the registration succeeded.
    /// <code>Offset: 0x00402160
    /// char __thiscall UserPreferences::RegisterPreference_1(void*,volatile LONG**,int*,void*,char*,int,int)</code>
    /// </summary>
    /// <param name="String">Pointer to the name of the preference being registered.</param>
    /// <param name="a3">Additional data or flags associated with the preference.</param>
    /// <param name="a4">Initial value or context for the preference.</param>
    /// <param name="SubStr">Substring used when searching for an existing registry entry.</param>
    /// <param name="a6">Optional parameter influencing registration behavior (e.g., priority).</param>
    /// <param name="a7">Optional parameter influencing registration behavior (e.g., scope).</param>
    /// <returns>Non‑zero if the preference was successfully registered; otherwise zero.</returns>
    public sbyte RegisterPreference_1(int** String, int* a3, System.IntPtr a4, sbyte* SubStr, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UserPreferences, int**, int*, System.IntPtr, sbyte*, int, int, sbyte>)0x00402160)(ref this, String, a3, a4, SubStr, a6, a7);

    /// <summary>Registers a user preference variable into the global registry, creating the registry instance if needed and setting an active flag on the newly registered object.
    /// <code>Offset: 0x00411D90
    /// char __thiscall UserPreferences::RegisterPreference_2(void*,volatile LONG**,int*,void*,char*,int,int)</code>
    /// </summary>
    /// <param name="String">Pointer to the preference name string used for registration and lookup.</param>
    /// <param name="a3">Pointer to additional integer data or default value associated with the preference.</param>
    /// <param name="a4">Optional context pointer passed to the registry during registration.</param>
    /// <param name="SubStr">Substring used as a filter or secondary identifier when registering the preference.</param>
    /// <param name="a6">First flag controlling registration behavior or variable attributes.</param>
    /// <param name="a7">Second flag controlling registration behavior or variable attributes.</param>
    /// <returns>Non‑zero if the preference was successfully registered and located; zero otherwise.</returns>
    public sbyte RegisterPreference_2(int** String, int* a3, System.IntPtr a4, sbyte* SubStr, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UserPreferences, int**, int*, System.IntPtr, sbyte*, int, int, sbyte>)0x00411D90)(ref this, String, a3, a4, SubStr, a6, a7);

    /// <summary>Registers a user preference variable with the global registry, ensuring the registry exists and marking the variable as modified when applicable.
    /// <code>Offset: 0x00431090
    /// char __thiscall UserPreferences::RegisterPreference_3(void*,volatile LONG**,int*,void*,char*,int,int)</code>
    /// </summary>
    /// <param name="this">The UserPreferences instance performing the registration.</param>
    /// <param name="String">Pointer to the preference name used for lookup and registration.</param>
    /// <param name="a3">Additional data or configuration associated with the preference.</param>
    /// <param name="a4">Optional context object related to the preference.</param>
    /// <param name="SubStr">Substring or qualifier appended to the preference key.</param>
    /// <param name="a6">Numeric flag influencing registration behavior.</param>
    /// <param name="a7">Additional numeric flag or mode setting.</param>
    /// <returns>Non‑zero if the preference was found and marked as modified; zero otherwise.</returns>
    public sbyte RegisterPreference_3(int** String, int* a3, System.IntPtr a4, sbyte* SubStr, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UserPreferences, int**, int*, System.IntPtr, sbyte*, int, int, sbyte>)0x00431090)(ref this, String, a3, a4, SubStr, a6, a7);

    /// <summary>Checks if a user preference identified by the provided key exists in the global registry and is enabled or registered, optionally verifying its identifier matches a supplied value.
    /// <code>Offset: 0x004370C0
    /// bool __cdecl UserPreferences::IsPreferenceRegistered(volatile LONG**,int)</code>
    /// </summary>
    /// <param name="a1">A pointer to the sequence of LONG values that encode the preference's key.</param>
    /// <param name="a2">An optional expected identifier for the preference. If zero, only existence and registration status are verified; otherwise the function also checks that the found preference's ID equals this value.</param>
    /// <returns>True when the preference exists, passes the enabled/registered check, and (if a2 is non‑zero) its identifier matches a2; otherwise false.</returns>
    public static byte IsPreferenceRegistered(int** a1, int a2) => ((delegate* unmanaged[Cdecl]<int**, int, byte>)0x004370C0)(a1, a2);

    /// <summary>Attempts to locate a user preference identified by the supplied key within the global registry, storing its internal identifier in the provided output parameter when successful.
    /// <code>Offset: 0x00437140
    /// char __cdecl UserPreferences::FindPreference(volatile LONG**,int*)</code>
    /// </summary>
    /// <param name="a1">The reference or identifier used to search for the desired preference.</param>
    /// <param name="String">Output parameter that receives the located preference's internal handle; also utilized during lookup.</param>
    /// <returns>Nonzero if the preference is found and valid, otherwise zero.</returns>
    public static sbyte FindPreference(int** a1, int* String) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00437140)(a1, String);

    /// <summary>Retrieves a user preference byte from the global registry using the supplied key; stores it through the provided pointer if found and of the expected type.
    /// <code>Offset: 0x004371C0
    /// char __cdecl UserPreferences::InqValue(volatile LONG**,_BYTE*)</code>
    /// </summary>
    /// <param name="a1">Reference to the key (name) used to locate the preference in the global registry.</param>
    /// <param name="a2">Pointer that receives the retrieved byte value when a matching preference is found.</param>
    /// <returns>Non‑zero if the preference was successfully located and its value stored; zero otherwise.</returns>
    public static sbyte InqValue(int** a1, byte* a2) => ((delegate* unmanaged[Cdecl]<int**, byte*, sbyte>)0x004371C0)(a1, a2);

    /// <summary>Retrieves the value of a user preference identified by a1 and stores it into the integer referenced by a2 if found.
    /// <code>Offset: 0x00437280
    /// char __cdecl UserPreferences::InqValue(volatile LONG**,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to a long identifier for the desired preference.</param>
    /// <param name="a2">Output pointer where the retrieved value will be stored.</param>
    /// <returns>Non-zero if the preference was successfully located and returned; otherwise zero.</returns>
    public static sbyte InqValue(int** a1, int* a2) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00437280)(a1, a2);

    /// <summary>Sets a user preference identified by the given key, updating its associated variable with the supplied integer value. Returns true when the preference is found and updated successfully; otherwise false.
    /// <code>Offset: 0x00437D20
    /// char __cdecl UserPreferences::SetValue(volatile LONG**,int*)</code>
    /// </summary>
    /// <param name="a1">Reference to the identifier of the preference to set.</param>
    /// <param name="a2">Pointer to the new integer value for the preference.</param>
    /// <returns>Non‑zero if the preference was located and updated, zero otherwise.</returns>
    public static sbyte SetValue(int** a1, int* a2) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00437D20)(a1, a2);

    /// <summary>Unregisters the “LoadPreferences” and “SavePreferences” commands from GlobalRegistry, ensuring that any associated command objects are properly released when no longer referenced.
    /// <code>Offset: 0x00437F60
    /// void __cdecl UserPreferences::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00437F60)();

    /// <summary>Finds the full pathname of the default UserPreferences.ini file, writes it into the supplied string reference, and reports whether the file is accessible.
    /// <code>Offset: 0x00437FE0
    /// bool __cdecl UserPreferences::FindDefaultFile(int*)</code>
    /// </summary>
    /// <param name="a1">Receives the resolved file path as a PStringBase (or equivalent) value.</param>
    /// <returns>True if the file can be accessed; otherwise false.</returns>
    public static byte FindDefaultFile(int* a1) => ((delegate* unmanaged[Cdecl]<int*, byte>)0x00437FE0)(a1);

    /// <summary>Saves user preferences to an INI configuration file, ensuring the target directory exists and writing all relevant registry entries.
    /// <code>Offset: 0x00438230
    /// bool __cdecl UserPreferences::Save()</code>
    /// </summary>
    /// <returns>True if a default preference file was found and used for saving; otherwise false.</returns>
    public static byte Save() => ((delegate* unmanaged[Cdecl]<byte>)0x00438230)();

    /// <summary>Saves user preferences to persistent storage, printing status messages to the console during the process.
    /// <code>Offset: 0x004386C0
    /// bool __cdecl UserPreferences::ConsoleCommand_SavePreferences()</code>
    /// </summary>
    /// <returns>True after attempting the save operation; a failure triggers an error message but still returns true.</returns>
    public static byte ConsoleCommand_SavePreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x004386C0)();

    /// <summary>Retrieves the list of UI child frameworks that represent the available choices for a given user preference and stores them in the supplied SmartArray.
    /// <code>Offset: 0x00438750
    /// char __cdecl UserPreferences::InqChoiceValues(volatile LONG**,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to the preference identifier string or key used to locate the preference object.</param>
    /// <param name="a2">SmartArray into which pointers to the choice UI child framework objects are appended.</param>
    /// <returns>Non‑zero if the preference was found and the array was populated; zero otherwise.</returns>
    public static sbyte InqChoiceValues(int** a1, int* a2) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00438750)(a1, a2);

    /// <summary>Retrieves the list of choice strings associated with a user preference identified by <paramref name="a1"/> and appends them to the supplied array <paramref name="a2"/>.
    /// <code>Offset: 0x00438860
    /// char __cdecl UserPreferences::InqChoiceStrings(volatile LONG**,int)</code>
    /// </summary>
    /// <param name="a1">Reference to the identifier or key for the desired preference.</param>
    /// <param name="a2">SmartArray that will receive the preference's available choice strings.</param>
    /// <returns>Non‑zero if the preference was found and its choices were added; otherwise zero.</returns>
    public static sbyte InqChoiceStrings(int** a1, int a2) => ((delegate* unmanaged[Cdecl]<int**, int, sbyte>)0x00438860)(a1, a2);

    /// <summary>Loads user preference settings from a configuration file into internal data structures, handling default files and parsing profile sections.
    /// <code>Offset: 0x00438940
    /// bool __cdecl UserPreferences::Load()</code>
    /// </summary>
    /// <returns>True if the preferences were loaded successfully; otherwise, false.</returns>
    public static byte Load() => ((delegate* unmanaged[Cdecl]<byte>)0x00438940)();

    /// <summary>Loads user preference settings from persistent storage and reports any errors via the global registry output.
    /// <code>Offset: 0x00438F50
    /// bool __cdecl UserPreferences::ConsoleCommand_LoadPreferences()</code>
    /// </summary>
    /// <returns>Always returns true.</returns>
    public static byte ConsoleCommand_LoadPreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x00438F50)();

    /// <summary>Sets up user preferences handling by registering console commands, configuring internal flags, resolving the default preferences file, and returning a status indicator.
    /// <code>Offset: 0x00438FE0
    /// char __cdecl UserPreferences::Initialize(volatile LONG*,volatile LONG**)</code>
    /// </summary>
    /// <param name="a1">Pointer whose value is used to set an internal tool‑mode flag.</param>
    /// <param name="a2">Reference to a reference‑counted object that may provide context for locating the default preference file.</param>
    /// <returns>Non‑zero if setting the default file succeeded; zero otherwise.</returns>
    public static sbyte Initialize(int* a1, int** a2) => ((delegate* unmanaged[Cdecl]<int*, int**, sbyte>)0x00438FE0)(a1, a2);
}

