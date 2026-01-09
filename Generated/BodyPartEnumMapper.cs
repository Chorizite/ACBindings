namespace ACBindings;

// BodyPartEnumMapper
public unsafe struct BodyPartEnumMapper
{
    // Methods
    // unsigned int __cdecl BodyPartEnumMapper::BodyPartToString(const int,char*,const unsigned int)
    public static uint BodyPartToString(int bp, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<int, sbyte*, uint, uint>)0x005D1EA0)(bp, buf, size);
}

