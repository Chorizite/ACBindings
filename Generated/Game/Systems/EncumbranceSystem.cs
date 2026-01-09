namespace ACBindings;

// EncumbranceSystem
public unsafe struct EncumbranceSystem
{
    // Methods
    // int __cdecl EncumbranceSystem::EncumbranceCapacity(const int,const int)
    public static int EncumbranceCapacity(int strength, int encumb_augmentations) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x004FD7A0)(strength, encumb_augmentations);
    // float __cdecl EncumbranceSystem::Load(const int,const int)
    public static float Load(int encumb_capacity, int encumb_val) => ((delegate* unmanaged[Cdecl]<int, int, float>)0x004FD7E0)(encumb_capacity, encumb_val);
    // float __cdecl EncumbranceSystem::LoadMod(const float)
    public static float LoadMod(float load) => ((delegate* unmanaged[Cdecl]<float, float>)0x004FD810)(load);
}

