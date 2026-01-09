namespace ACBindings.AC1Legacy;

// AC1Legacy::Resource
public unsafe struct Resource
{
    // Statics
    public static byte* abData = (byte*)0x0086F70C;

    // Methods
    // int __cdecl AC1Legacy::Resource::LoadData(char*)
    public static int LoadData(sbyte* fpFileName) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555A60)(fpFileName);
    // int __cdecl AC1Legacy::Resource::Init(const char*)
    public static int Init(sbyte* fname) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555AA0)(fname);
    // void __cdecl AC1Legacy::Resource::Cleanup()
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00555C90)();
    // char* __cdecl AC1Legacy::Resource::GetComments()
    public static sbyte* GetComments() => ((delegate* unmanaged[Cdecl]<sbyte*>)0x00555CB0)();
    // int __cdecl AC1Legacy::Resource::GetVersion(AC1Legacy::VERSION_NO_t*)
    public static int GetVersion(ACBindings.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.VERSION_NO_t*, int>)0x00555D10)(version);
}

