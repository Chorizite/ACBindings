namespace ACBindings.Internal;

public unsafe struct TinkeringSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005CA650
    /// int __cdecl TinkeringSystem::IsValidMaterialType(unsigned int)</code>
    /// </summary>
    public static int IsValidMaterialType(uint material) => ((delegate* unmanaged[Cdecl]<uint, int>)0x005CA650)(material);
}

