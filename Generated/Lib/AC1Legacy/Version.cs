namespace ACBindings.Internal.AC1Legacy;


/// <summary>Manages application version information, providing formatted build, file, and verbose strings while handling resource initialization and cleanup.</summary>
public unsafe struct Version
{
    // Statics
    public static sbyte** FileVersion_ = (sbyte**)0x00870AD8;
    public static sbyte** BuildVersion_ = (sbyte**)0x00870ADC;
    public static sbyte** VerboseVersionString_ = (sbyte**)0x00870AE0;

    // Methods

    /// <summary>Allocates a 16‑byte buffer and formats a VERSION_NO_t into a null‑terminated string. The resulting representation follows “rr.sc.bb.mmdd.debug” with each numeric field zero‑padded to two digits and the mm/dd arrays contributing four characters plus one debug character.
    /// <code>Offset: 0x005558F0
    /// char* __cdecl AC1Legacy::Version::StringFromVersion(AC1Legacy::VERSION_NO_t*)</code>
    /// </summary>
    /// <param name="version">The version structure containing fields rr, sc, bb, mm[2], dd[2] and debug used for formatting.</param>
    /// <returns>Pointer to a heap‑allocated string; caller is responsible for freeing it.</returns>
    public static sbyte* StringFromVersion(ACBindings.Internal.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.VERSION_NO_t*, sbyte*>)0x005558F0)(version);

    /// <summary>Creates a null‑terminated string that encodes the supplied version structure in the form "RR.SS.BB.MMDD".
    /// <code>Offset: 0x00555940
    /// char* __cdecl AC1Legacy::Version::FileVersionStringFromVersion(AC1Legacy::VERSION_NO_t*)</code>
    /// </summary>
    /// <param name="version">Structure containing major (rr), minor (sc), build (bb) numbers and two characters each for month (mm) and day (dd).</param>
    /// <returns>Pointer to a heap‑allocated buffer holding the formatted string; caller is responsible for freeing the memory when it is no longer needed.</returns>
    public static sbyte* FileVersionStringFromVersion(ACBindings.Internal.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.VERSION_NO_t*, sbyte*>)0x00555940)(version);

    /// <summary>Initializes version information by loading data from the specified resource file and preparing build, file, and verbose version strings.
    /// <code>Offset: 0x00555990
    /// int __cdecl AC1Legacy::Version::Init(const char*)</code>
    /// </summary>
    /// <param name="fname">Path to the resource file containing version data.</param>
    /// <returns>1 if initialization succeeds; 0 if loading the resource fails.</returns>
    public static int Init(sbyte* fname) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555990)(fname);

    /// <summary>Releases allocated memory for verbose, build, and file version strings while performing related resource cleanup.
    /// <code>Offset: 0x00555A20
    /// void __cdecl AC1Legacy::Version::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00555A20)();
}

