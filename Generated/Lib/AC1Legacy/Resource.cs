namespace ACBindings.Internal.AC1Legacy;


/// <summary>Facilitates loading and querying embedded Windows version information from executables, storing it in a shared static buffer.</summary>
/// <remarks>Provides methods to retrieve comment text, parse Turbine build version into a structured format, initialize resources by locating files via PATH or quoted paths, load raw data, and clean up allocated memory.</remarks>
public unsafe struct Resource
{
    // Statics
    public static byte** abData = (byte**)0x00870AE4;

    // Methods

    /// <summary>Loads the contents of a specified file into a static buffer and returns the number of bytes read.
    /// <code>Offset: 0x00555A60
    /// int __cdecl AC1Legacy::Resource::LoadData(char*)</code>
    /// </summary>
    /// <param name="fpFileName">Path to the target file whose data is loaded.</param>
    /// <returns>The number of bytes successfully read, or zero if the file does not exist or cannot be accessed.</returns>
    public static int LoadData(sbyte* fpFileName) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555A60)(fpFileName);

    /// <summary>Loads the version information of an executable file into a static data buffer. If the filename is quoted, the quotes are stripped and the file is loaded directly; otherwise the function first attempts to locate the file in the current working directory, then in directories listed in PATH, adding a .exe extension if missing.
    /// <code>Offset: 0x00555AA0
    /// int __cdecl AC1Legacy::Resource::Init(const char*)</code>
    /// </summary>
    /// <param name="fname">Path of the executable to load, optionally surrounded by double quotes and without an explicit .exe suffix.</param>
    /// <returns>An integer indicating success: when loading via a quoted path it returns the size in bytes of the retrieved version data; when locating the file relative to the current directory it returns 1 on success; if the file is found through PATH or LoadData, that function’s return value is propagated; otherwise 0 indicates failure.</returns>
    public static int Init(sbyte* fname) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555AA0)(fname);

    /// <summary>Releases the memory associated with the shared resource data when present.
    /// <code>Offset: 0x00555C90
    /// void __cdecl AC1Legacy::Resource::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00555C90)();

    /// <summary>Retrieves the “Comments” entry from the embedded Windows version information block and returns it as a newly allocated C string.
    /// <code>Offset: 0x00555CB0
    /// char* __cdecl AC1Legacy::Resource::GetComments()</code>
    /// </summary>
    /// <returns>A pointer to a 45‑byte buffer containing the comment text if found; otherwise the returned memory holds uninitialized data. If no resource data is available, null is returned. The caller must deallocate the buffer with delete[].</returns>
    public static sbyte* GetComments() => ((delegate* unmanaged[Cdecl]<sbyte*>)0x00555CB0)();

    /// <summary>Retrieves the Turbine build version from embedded resource data and parses it into a VERSION_NO_t structure.
    /// <code>Offset: 0x00555D10
    /// int __cdecl AC1Legacy::Resource::GetVersion(AC1Legacy::VERSION_NO_t*)</code>
    /// </summary>
    /// <param name="version">Pointer to a VERSION_NO_t structure where parsed version components are stored.</param>
    /// <returns>Non-zero if the version was successfully retrieved and parsed; zero otherwise.</returns>
    public static int GetVersion(ACBindings.Internal.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.VERSION_NO_t*, int>)0x00555D10)(version);
}

