namespace ACBindings.Internal;


/// <summary>Calculates experience distributions among fellowship members, providing split percentages based on group size. Determines the experience required for a character to advance from one level to the next.</summary>
public unsafe struct FellowshipSystem
{
    // Methods

    /// <summary>Computes the experience needed to raise a character from the given level to the following level.
    /// <code>Offset: 0x005BACC0
    /// unsigned int __cdecl FellowshipSystem::GetExperienceProportion(unsigned int)</code>
    /// </summary>
    /// <param name="level">Current level for which the required experience is calculated.</param>
    /// <returns>The amount of experience points necessary to reach the next level.</returns>
    public static uint GetExperienceProportion(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005BACC0)(level);

    /// <summary>Computes the proportion of experience points each fellow receives when XP is divided evenly among a group.
    /// <code>Offset: 0x005BACE0
    /// float __cdecl FellowshipSystem::GetEvenSplitXPPctg(unsigned int)</code>
    /// </summary>
    /// <param name="uiNumFellows">The total number of fellows sharing the experience.</param>
    /// <returns>The fraction of the original experience that one fellow obtains; returns 0 for unsupported counts.</returns>
    public static float GetEvenSplitXPPctg(uint uiNumFellows) => ((delegate* unmanaged[Cdecl]<uint, float>)0x005BACE0)(uiNumFellows);
}

