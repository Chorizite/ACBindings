namespace ACBindings.Internal;


/// <summary>Central hub for all experience calculations, converting raw points into character levels, attribute tiers, and skill progressions using the game's experience table database.</summary>
public unsafe struct ExperienceSystem
{
    // Methods

    /// <summary>Calculates the cumulative experience points needed to reach a specified item level using one of several scaling schemes.
    /// <code>Offset: 0x005C90E0
    /// unsigned __int64 __cdecl ExperienceSystem::ItemLevelToTotalXP(int,unsigned __int64,int,int)</code>
    /// </summary>
    /// <param name="item_level">Target level for which total XP is calculated; values less than 1 return zero, and values above <paramref name="max_level"/> are capped at <paramref name="max_level"/>.</param>
    /// <param name="base_xp">Base experience awarded per level used as the multiplier in each scheme.</param>
    /// <param name="max_level">Maximum allowable item level; levels exceeding this value are treated as equal to <paramref name="max_level"/>.</param>
    /// <param name="xp_scheme">
    /// Specifies the growth pattern for XP accumulation:<br/>
    /// 1 – Linear: total = level × base_xp.<br/>
    /// 2 – Exponential doubling: each additional level doubles the previous increment; total = base_xp × (2^level – 1).<br/>
    /// 3 – Quadratic triangular: incremental XP equals the sum of all prior levels plus base_xp; total = base_xp × level × (level + 1)/2.<br/>
    /// Any other value yields zero.</param>
    /// <returns>Total experience points required for the (possibly capped) level, or zero if <paramref name="item_level"/> is below 1 or an unsupported <paramref name="xp_scheme"/> is specified.</returns>
    public static ulong ItemLevelToTotalXP(int item_level, ulong base_xp, int max_level, int xp_scheme) => ((delegate* unmanaged[Cdecl]<int, ulong, int, int, ulong>)0x005C90E0)(item_level, base_xp, max_level, xp_scheme);

    /// <summary>Computes the experience level achieved from a total amount of gained XP using one of several conversion schemes and caps it at a specified maximum level.
    /// <code>Offset: 0x005C9190
    /// int __cdecl ExperienceSystem::ItemTotalXPToLevel(unsigned __int64,unsigned __int64,int,int)</code>
    /// </summary>
    /// <param name="gained_xp">Total experience points accumulated.</param>
    /// <param name="base_xp">Base experience value used for calculating each level's requirement.</param>
    /// <param name="max_level">Highest level that may be returned; any computed level above this is capped to max_level.</param>
    /// <param name="xp_scheme">Algorithm selector: 1 = simple division, 2 = exponential threshold doubling, 3 = linear incremental addition.</param>
    /// <returns>The calculated level, not exceeding max_level.</returns>
    public static int ItemTotalXPToLevel(ulong gained_xp, ulong base_xp, int max_level, int xp_scheme) => ((delegate* unmanaged[Cdecl]<ulong, ulong, int, int, int>)0x005C9190)(gained_xp, base_xp, max_level, xp_scheme);

    /// <summary>Converts an XP value into a locale‑formatted string using thousand separators and writes the result into the supplied buffer.
    /// <code>Offset: 0x005C92B0
    /// void __cdecl ExperienceSystem::XPToString(unsigned __int64,char*)</code>
    /// </summary>
    /// <param name="xp">The experience points to format.</param>
    /// <param name="output_str">Pointer to a 32‑byte buffer that receives the formatted string.</param>
    public static void XPToString(ulong xp, sbyte* output_str) => ((delegate* unmanaged[Cdecl]<ulong, sbyte*, void>)0x005C92B0)(xp, output_str);

    /// <summary>Retrieves the experience points required for a given attribute level from the database table, returning 0 if the data is unavailable.
    /// <code>Offset: 0x005C9330
    /// unsigned int __cdecl ExperienceSystem::ExperienceToAttributeLevel(unsigned int)</code>
    /// </summary>
    /// <param name="level">The target attribute level to query.</param>
    /// <returns>The total experience needed to reach the specified level; zero when no matching entry exists.</returns>
    public static uint ExperienceToAttributeLevel(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C9330)(level);

    /// <summary>Calculates the experience required for a character's second-level attribute at a given level by querying the experience table database and retrieving the corresponding value.
    /// <code>Offset: 0x005C9370
    /// unsigned int __cdecl ExperienceSystem::ExperienceToAttribute2ndLevel(unsigned int)</code>
    /// </summary>
    /// <param name="level">The current character level to determine the needed experience for advancing to the next second-level attribute tier.</param>
    /// <returns>The amount of experience points required for that advancement; returns 0 if the necessary data cannot be found.</returns>
    public static uint ExperienceToAttribute2ndLevel(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C9370)(level);

    /// <summary>Computes the total experience required to reach a specific skill level for trained or specialized skills by querying the experience table database.
    /// <code>Offset: 0x005C93B0
    /// unsigned int __cdecl ExperienceSystem::ExperienceToSkillLevel(SKILL_ADVANCEMENT_CLASS,unsigned int)</code>
    /// </summary>
    /// <param name="sac">The advancement class indicating whether the skill is trained or specialized.</param>
    /// <param name="level">Desired skill level (1‑based index).</param>
    /// <returns>Experience points needed to attain the specified level; returns 0 if no data is available, otherwise -1 for an unsupported advancement class.</returns>
    public static uint ExperienceToSkillLevel(ACBindings.Internal.SKILL_ADVANCEMENT_CLASS sac, uint level) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint, uint>)0x005C93B0)(sac, level);

    /// <summary>Calculates the skill level for a given advancement class using experience points. Retrieves an ExperienceTable instance and obtains the appropriate level for trained or specialized skills, returning zero when the class is unsupported.
    /// <code>Offset: 0x005C9420
    /// unsigned int __cdecl ExperienceSystem::SkillLevelFromExperience(SKILL_ADVANCEMENT_CLASS,unsigned int)</code>
    /// </summary>
    /// <param name="sac">Specifies whether the skill uses trained or specialized advancement rules.</param>
    /// <param name="pp">Experience points to evaluate against the table.</param>
    /// <returns>Unsigned integer representing the calculated skill level; 0 if the table could not be found or the class is unsupported.</returns>
    public static uint SkillLevelFromExperience(ACBindings.Internal.SKILL_ADVANCEMENT_CLASS sac, uint pp) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint, uint>)0x005C9420)(sac, pp);

    /// <summary>Calculates the attribute level corresponding to a given amount of experience points.
    /// <code>Offset: 0x005C9490
    /// unsigned int __cdecl ExperienceSystem::AttributeLevelFromExperience(unsigned int)</code>
    /// </summary>
    /// <param name="total_xp">The cumulative experience points to evaluate.</param>
    /// <returns>The attribute level that matches the provided experience points, or zero if no matching entry is found.</returns>
    public static uint AttributeLevelFromExperience(uint total_xp) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C9490)(total_xp);

    /// <summary>Computes the secondary attribute level for a specified experience value using the configured experience table.
    /// <code>Offset: 0x005C94D0
    /// unsigned int __cdecl ExperienceSystem::Attribute2ndLevelFromExperience(unsigned int)</code>
    /// </summary>
    /// <param name="total_xp">Total experience points to translate into an attribute level.</param>
    /// <returns>The resulting second-level attribute value, or zero when no configuration is found.</returns>
    public static uint Attribute2ndLevelFromExperience(uint total_xp) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C94D0)(total_xp);

    /// <summary>Calculates the cumulative experience required to reach the specified level using the game's experience table.
    /// <code>Offset: 0x005C9510
    /// unsigned __int64 __cdecl ExperienceSystem::ExperienceToLevel(unsigned int)</code>
    /// </summary>
    /// <param name="level">Target player level for which to compute the experience threshold.</param>
    /// <returns>The total experience points needed to attain that level; returns 0 if the experience table cannot be retrieved.</returns>
    public static ulong ExperienceToLevel(uint level) => ((delegate* unmanaged[Cdecl]<uint, ulong>)0x005C9510)(level);

    /// <summary>Retrieves the maximum level for specialized skills from a database entry identified by enum values 3, 2, 0x10000009. Returns zero if no entry is found.
    /// <code>Offset: 0x005C9550
    /// unsigned int __cdecl ExperienceSystem::GetMaxSpecializedSkillLevel()</code>
    /// </summary>
    /// <returns>The configured maximum skill level as an unsigned integer.</returns>
    public static uint GetMaxSpecializedSkillLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C9550)();

    /// <summary>Retrieves the configured maximum level for trained skills from the experience system database.
    /// <code>Offset: 0x005C9580
    /// unsigned int __cdecl ExperienceSystem::GetMaxTrainedSkillLevel()</code>
    /// </summary>
    /// <returns>The maximum skill level defined in the configuration; returns 0 when no configuration entry is found.</returns>
    public static uint GetMaxTrainedSkillLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C9580)();

    /// <summary>Returns the maximum level that can be attained by a player's attributes in the experience system.
    /// <code>Offset: 0x005C95B0
    /// unsigned int __cdecl ExperienceSystem::GetMaxAttributeLevel()</code>
    /// </summary>
    /// <returns>The highest attribute level, or 0 if unavailable.</returns>
    public static uint GetMaxAttributeLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C95B0)();

    /// <summary>Retrieves the maximum value for a second‑level attribute from the database, returning zero when no entry is available.
    /// <code>Offset: 0x005C95E0
    /// unsigned int __cdecl ExperienceSystem::GetMaxAttribute2ndLevel()</code>
    /// </summary>
    /// <returns>An unsigned integer indicating the maximum attribute value at second level, or 0 if the corresponding database record cannot be located.</returns>
    public static uint GetMaxAttribute2ndLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C95E0)();

    /// <summary>Calculates the additional experience required to advance from the current level to a higher target level, returning zero if no advancement is requested.
    /// <code>Offset: 0x005C9610
    /// unsigned __int64 __cdecl ExperienceSystem::ExperienceToRaiseLevel(unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="current_level">The character's present level.</param>
    /// <param name="new_level">The desired level to reach; must be greater than current_level.</param>
    /// <returns>The number of experience points needed to progress from current_level to new_level, or 0 if new_level is not higher.</returns>
    public static ulong ExperienceToRaiseLevel(uint current_level, uint new_level) => ((delegate* unmanaged[Cdecl]<uint, uint, ulong>)0x005C9610)(current_level, new_level);
}

