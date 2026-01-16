namespace ACBindings.Internal;


/// <summary>
/// Validates material identifiers for tinkering operations, ensuring only supported types are used within the crafting subsystem.
/// </summary>
public unsafe struct TinkeringSystem
{
    // Methods

    /// <summary>Checks whether a given material type ID is valid for tinkering operations.
    /// <code>Offset: 0x005CA650
    /// int __cdecl TinkeringSystem::IsValidMaterialType(unsigned int)</code>
    /// </summary>
    /// <param name="material">Identifier of the material to validate.</param>
    /// <returns>1 if the material type is supported; otherwise 0.</returns>
    public static int IsValidMaterialType(uint material) => ((delegate* unmanaged[Cdecl]<uint, int>)0x005CA650)(material);
}

