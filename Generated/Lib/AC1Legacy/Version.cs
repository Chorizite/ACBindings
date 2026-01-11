namespace ACBindings.Internal.AC1Legacy;

public unsafe struct Version
{
    // Statics
    public static sbyte* FileVersion_ = (sbyte*)0x00870AD8;
    public static sbyte* BuildVersion_ = (sbyte*)0x00870ADC;
    public static sbyte* VerboseVersionString_ = (sbyte*)0x00870AE0;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005558F0
    /// char* __cdecl AC1Legacy::Version::StringFromVersion(AC1Legacy::VERSION_NO_t*)</code>
    /// </summary>
    public static sbyte* StringFromVersion(ACBindings.Internal.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.VERSION_NO_t*, sbyte*>)0x005558F0)(version);

    /// <summary>
    /// <code>Offset: 0x00555940
    /// char* __cdecl AC1Legacy::Version::FileVersionStringFromVersion(AC1Legacy::VERSION_NO_t*)</code>
    /// </summary>
    public static sbyte* FileVersionStringFromVersion(ACBindings.Internal.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.VERSION_NO_t*, sbyte*>)0x00555940)(version);

    /// <summary>
    /// <code>Offset: 0x00555990
    /// int __cdecl AC1Legacy::Version::Init(const char*)</code>
    /// </summary>
    public static int Init(sbyte* fname) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555990)(fname);

    /// <summary>
    /// <code>Offset: 0x00555A20
    /// void __cdecl AC1Legacy::Version::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00555A20)();
}

