namespace ACBindings;

// TinkeringSystem
public unsafe struct TinkeringSystem
{
    // Methods
    // int __cdecl TinkeringSystem::IsValidMaterialType(unsigned int)
    public static int IsValidMaterialType(uint material) => ((delegate* unmanaged[Cdecl]<uint, int>)0x005CA650)(material);
}

