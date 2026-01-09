namespace ACBindings.AC1Legacy;

// AC1Legacy::Version
public unsafe struct Version
{
    // Statics
    public static sbyte* FileVersion_ = (sbyte*)0x0086F6FC;

    // Methods
    // char* __cdecl AC1Legacy::Version::StringFromVersion(AC1Legacy::VERSION_NO_t*)
    public static sbyte* StringFromVersion(ACBindings.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.VERSION_NO_t*, sbyte*>)0x005558F0)(version);
    // char* __cdecl AC1Legacy::Version::FileVersionStringFromVersion(AC1Legacy::VERSION_NO_t*)
    public static sbyte* FileVersionStringFromVersion(ACBindings.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.VERSION_NO_t*, sbyte*>)0x00555940)(version);
    // int __cdecl AC1Legacy::Version::Init(const char*)
    public static int Init(sbyte* fname) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555990)(fname);
    // void __cdecl AC1Legacy::Version::Cleanup()
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00555A20)();
}

