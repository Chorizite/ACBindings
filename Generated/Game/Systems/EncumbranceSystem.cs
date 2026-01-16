namespace ACBindings.Internal;


/// <summary>Provides operations for calculating encumbrance load ratios, modifier factors, and maximum capacity based on strength and augmentations.</summary>
public unsafe struct EncumbranceSystem
{
    // Methods

    /// <summary>Calculates maximum encumbrance capacity based on a character's strength and optional augmentation modifiers.
    /// <code>Offset: 0x004FD7A0
    /// int __cdecl EncumbranceSystem::EncumbranceCapacity(const int,const int)</code>
    /// </summary>
    /// <param name="strength">Base strength used to compute capacity; non‑positive values yield zero capacity.</param>
    /// <param name="encumb_augmentations">Number of augmentations applied, each contributing up to 30 units per strength but capped at a total contribution of 150.</param>
    /// <returns>Integer representing the resulting encumbrance capacity, computed as 150 × strength plus strength times the capped augmentation factor, with safety checks against overflow and negative results.</returns>
    public static int EncumbranceCapacity(int strength, int encumb_augmentations) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x004FD7A0)(strength, encumb_augmentations);

    /// <summary>Calculates the load fraction from current encumbrance and capacity, returning 3.0 when capacity is non‑positive or 0.0 when the encumbrance value is negative.
    /// <code>Offset: 0x004FD7E0
    /// float __cdecl EncumbranceSystem::Load(const int,const int)</code>
    /// </summary>
    /// <param name="encumb_capacity">Maximum allowable encumbrance; must be positive for a valid calculation.</param>
    /// <param name="encumb_val">Current encumbrance amount; if negative, the function returns 0.0 as an error indicator.</param>
    /// <returns>The load fraction (encumb_val / encumb_capacity) for valid inputs, or sentinel values 3.0 or 0.0 to indicate invalid conditions.</returns>
    public static float Load(int encumb_capacity, int encumb_val) => ((delegate* unmanaged[Cdecl]<int, int, float>)0x004FD7E0)(encumb_capacity, encumb_val);

    /// <summary>Computes a modifier factor based on the current load, yielding 1.0 when load is below 1.0, linearly decreasing to 0.0 as load approaches 2.0, and returning 0.0 for loads of 2.0 or higher.
    /// <code>Offset: 0x004FD810
    /// float __cdecl EncumbranceSystem::LoadMod(const float)</code>
    /// </summary>
    /// <param name="load">The current encumbrance load value.</param>
    /// <returns>A float modifier in the range [0,1] reflecting how heavily loaded the system is.</returns>
    public static float LoadMod(float load) => ((delegate* unmanaged[Cdecl]<float, float>)0x004FD810)(load);
}

