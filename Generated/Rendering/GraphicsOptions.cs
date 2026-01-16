namespace ACBindings.Internal;


/// <summary>
/// Manages rendering options such as landscape radius and field of view, processing command‑line arguments to adjust settings or display usage information.
/// </summary>
public unsafe struct GraphicsOptions
{
    // Methods

    /// <summary>Handles rendering options passed via command line, allowing adjustment of landscape radius and field of view, or displaying usage information.
    /// <code>Offset: 0x00455D50
    /// bool __cdecl GraphicsOptions::HandleRenderOption(int,char**,const char**,const char**)</code>
    /// </summary>
    /// <param name="argc">The number of arguments supplied by the caller.</param>
    /// <param name="argv">Array of argument strings; argv[0] is the command name, followed by option and value.</param>
    /// <param name="status_string">Pointer to a string that receives a message describing the result or any error encountered during processing.</param>
    /// <param name="usage_string">Pointer to a string that receives usage instructions when insufficient arguments are supplied or the user requests help.</param>
    /// <returns>True if an option was successfully processed; false otherwise (e.g., not enough arguments, or help requested).</returns>
    public static byte HandleRenderOption(int argc, sbyte** argv, sbyte** status_string, sbyte** usage_string) => ((delegate* unmanaged[Cdecl]<int, sbyte**, sbyte**, sbyte**, byte>)0x00455D50)(argc, argv, status_string, usage_string);
}

