namespace ACBindings.Internal;

public unsafe struct MaterialTypeEnumMapper
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005CE450
    /// char __cdecl MaterialTypeEnumMapper::MaterialTypeToString(int,int*)</code>
    /// </summary>
    public static sbyte MaterialTypeToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x005CE450)(a1, a2);
}

