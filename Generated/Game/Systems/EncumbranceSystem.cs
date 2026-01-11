namespace ACBindings.Internal;

public unsafe struct EncumbranceSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x004FD7A0
    /// int __cdecl EncumbranceSystem::EncumbranceCapacity(const int,const int)</code>
    /// </summary>
    public static int EncumbranceCapacity(int strength, int encumb_augmentations) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x004FD7A0)(strength, encumb_augmentations);

    /// <summary>
    /// <code>Offset: 0x004FD7E0
    /// float __cdecl EncumbranceSystem::Load(const int,const int)</code>
    /// </summary>
    public static float Load(int encumb_capacity, int encumb_val) => ((delegate* unmanaged[Cdecl]<int, int, float>)0x004FD7E0)(encumb_capacity, encumb_val);

    /// <summary>
    /// <code>Offset: 0x004FD810
    /// float __cdecl EncumbranceSystem::LoadMod(const float)</code>
    /// </summary>
    public static float LoadMod(float load) => ((delegate* unmanaged[Cdecl]<float, float>)0x004FD810)(load);
}

