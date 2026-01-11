namespace ACBindings.Internal;

public unsafe struct BodyPartEnumMapper
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005D1EA0
    /// unsigned int __cdecl BodyPartEnumMapper::BodyPartToString(const int,char*,const unsigned int)</code>
    /// </summary>
    public static uint BodyPartToString(int bp, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<int, sbyte*, uint, uint>)0x005D1EA0)(bp, buf, size);
}

