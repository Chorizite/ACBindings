namespace ACBindings.Internal;

public unsafe struct GraphicsOptions
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x00455D50
    /// bool __cdecl GraphicsOptions::HandleRenderOption(int,char**,const char**,const char**)</code>
    /// </summary>
    public static byte HandleRenderOption(int argc, sbyte** argv, sbyte** status_string, sbyte** usage_string) => ((delegate* unmanaged[Cdecl]<int, sbyte**, sbyte**, sbyte**, byte>)0x00455D50)(argc, argv, status_string, usage_string);
}

