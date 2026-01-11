namespace ACBindings.Internal.AC1Legacy;

public unsafe struct Resource
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x00555A60
    /// int __cdecl AC1Legacy::Resource::LoadData(char*)</code>
    /// </summary>
    public static int LoadData(sbyte* fpFileName) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555A60)(fpFileName);

    /// <summary>
    /// <code>Offset: 0x00555AA0
    /// int __cdecl AC1Legacy::Resource::Init(const char*)</code>
    /// </summary>
    public static int Init(sbyte* fname) => ((delegate* unmanaged[Cdecl]<sbyte*, int>)0x00555AA0)(fname);

    /// <summary>
    /// <code>Offset: 0x00555C90
    /// void __cdecl AC1Legacy::Resource::Cleanup()</code>
    /// </summary>
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00555C90)();

    /// <summary>
    /// <code>Offset: 0x00555CB0
    /// char* __cdecl AC1Legacy::Resource::GetComments()</code>
    /// </summary>
    public static sbyte* GetComments() => ((delegate* unmanaged[Cdecl]<sbyte*>)0x00555CB0)();

    /// <summary>
    /// <code>Offset: 0x00555D10
    /// int __cdecl AC1Legacy::Resource::GetVersion(AC1Legacy::VERSION_NO_t*)</code>
    /// </summary>
    public static int GetVersion(ACBindings.Internal.AC1Legacy.VERSION_NO_t* version) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.VERSION_NO_t*, int>)0x00555D10)(version);
}

