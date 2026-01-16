namespace ACBindings.Internal;


/// <summary>Maps material type enumeration values to readable string names by converting enum identifiers into strings with spaces instead of underscores.</summary>
public unsafe struct MaterialTypeEnumMapper
{
    // Methods

    /// <summary>Converts a material type enumeration value to its corresponding string representation, replacing underscores with spaces.
    /// <code>Offset: 0x005CE450
    /// char __cdecl MaterialTypeEnumMapper::MaterialTypeToString(int,int*)</code>
    /// </summary>
    /// <param name="a1">The enum identifier of the material type.</param>
    /// <param name="a2">Pointer to a string buffer where the resulting name will be stored.</param>
    /// <returns>Non‑zero if conversion succeeds; zero otherwise.</returns>
    public static sbyte MaterialTypeToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x005CE450)(a1, a2);
}

