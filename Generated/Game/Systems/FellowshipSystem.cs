namespace ACBindings;

// FellowshipSystem
public unsafe struct FellowshipSystem
{
    // Methods
    // unsigned int __cdecl FellowshipSystem::GetExperienceProportion(unsigned int)
    public static uint GetExperienceProportion(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005BACC0)(level);
    // float __cdecl FellowshipSystem::GetEvenSplitXPPctg(unsigned int)
    public static float GetEvenSplitXPPctg(uint uiNumFellows) => ((delegate* unmanaged[Cdecl]<uint, float>)0x005BACE0)(uiNumFellows);
}

