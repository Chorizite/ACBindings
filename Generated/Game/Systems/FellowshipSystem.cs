namespace ACBindings.Internal;

public unsafe struct FellowshipSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005BACC0
    /// unsigned int __cdecl FellowshipSystem::GetExperienceProportion(unsigned int)</code>
    /// </summary>
    public static uint GetExperienceProportion(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005BACC0)(level);

    /// <summary>
    /// <code>Offset: 0x005BACE0
    /// float __cdecl FellowshipSystem::GetEvenSplitXPPctg(unsigned int)</code>
    /// </summary>
    public static float GetEvenSplitXPPctg(uint uiNumFellows) => ((delegate* unmanaged[Cdecl]<uint, float>)0x005BACE0)(uiNumFellows);
}

