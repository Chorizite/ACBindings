namespace ACBindings.Internal;

public unsafe struct ExperienceSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005C90E0
    /// unsigned __int64 __cdecl ExperienceSystem::ItemLevelToTotalXP(int,unsigned __int64,int,int)</code>
    /// </summary>
    public static ulong ItemLevelToTotalXP(int item_level, ulong base_xp, int max_level, int xp_scheme) => ((delegate* unmanaged[Cdecl]<int, ulong, int, int, ulong>)0x005C90E0)(item_level, base_xp, max_level, xp_scheme);

    /// <summary>
    /// <code>Offset: 0x005C9190
    /// int __cdecl ExperienceSystem::ItemTotalXPToLevel(unsigned __int64,unsigned __int64,int,int)</code>
    /// </summary>
    public static int ItemTotalXPToLevel(ulong gained_xp, ulong base_xp, int max_level, int xp_scheme) => ((delegate* unmanaged[Cdecl]<ulong, ulong, int, int, int>)0x005C9190)(gained_xp, base_xp, max_level, xp_scheme);

    /// <summary>
    /// <code>Offset: 0x005C92B0
    /// void __cdecl ExperienceSystem::XPToString(unsigned __int64,char*)</code>
    /// </summary>
    public static void XPToString(ulong xp, sbyte* output_str) => ((delegate* unmanaged[Cdecl]<ulong, sbyte*, void>)0x005C92B0)(xp, output_str);

    /// <summary>
    /// <code>Offset: 0x005C9330
    /// unsigned int __cdecl ExperienceSystem::ExperienceToAttributeLevel(unsigned int)</code>
    /// </summary>
    public static uint ExperienceToAttributeLevel(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C9330)(level);

    /// <summary>
    /// <code>Offset: 0x005C9370
    /// unsigned int __cdecl ExperienceSystem::ExperienceToAttribute2ndLevel(unsigned int)</code>
    /// </summary>
    public static uint ExperienceToAttribute2ndLevel(uint level) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C9370)(level);

    /// <summary>
    /// <code>Offset: 0x005C93B0
    /// unsigned int __cdecl ExperienceSystem::ExperienceToSkillLevel(SKILL_ADVANCEMENT_CLASS,unsigned int)</code>
    /// </summary>
    public static uint ExperienceToSkillLevel(ACBindings.Internal.SKILL_ADVANCEMENT_CLASS sac, uint level) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint, uint>)0x005C93B0)(sac, level);

    /// <summary>
    /// <code>Offset: 0x005C9420
    /// unsigned int __cdecl ExperienceSystem::SkillLevelFromExperience(SKILL_ADVANCEMENT_CLASS,unsigned int)</code>
    /// </summary>
    public static uint SkillLevelFromExperience(ACBindings.Internal.SKILL_ADVANCEMENT_CLASS sac, uint pp) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, uint, uint>)0x005C9420)(sac, pp);

    /// <summary>
    /// <code>Offset: 0x005C9490
    /// unsigned int __cdecl ExperienceSystem::AttributeLevelFromExperience(unsigned int)</code>
    /// </summary>
    public static uint AttributeLevelFromExperience(uint total_xp) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C9490)(total_xp);

    /// <summary>
    /// <code>Offset: 0x005C94D0
    /// unsigned int __cdecl ExperienceSystem::Attribute2ndLevelFromExperience(unsigned int)</code>
    /// </summary>
    public static uint Attribute2ndLevelFromExperience(uint total_xp) => ((delegate* unmanaged[Cdecl]<uint, uint>)0x005C94D0)(total_xp);

    /// <summary>
    /// <code>Offset: 0x005C9510
    /// unsigned __int64 __cdecl ExperienceSystem::ExperienceToLevel(unsigned int)</code>
    /// </summary>
    public static ulong ExperienceToLevel(uint level) => ((delegate* unmanaged[Cdecl]<uint, ulong>)0x005C9510)(level);

    /// <summary>
    /// <code>Offset: 0x005C9550
    /// unsigned int __cdecl ExperienceSystem::GetMaxSpecializedSkillLevel()</code>
    /// </summary>
    public static uint GetMaxSpecializedSkillLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C9550)();

    /// <summary>
    /// <code>Offset: 0x005C9580
    /// unsigned int __cdecl ExperienceSystem::GetMaxTrainedSkillLevel()</code>
    /// </summary>
    public static uint GetMaxTrainedSkillLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C9580)();

    /// <summary>
    /// <code>Offset: 0x005C95B0
    /// unsigned int __cdecl ExperienceSystem::GetMaxAttributeLevel()</code>
    /// </summary>
    public static uint GetMaxAttributeLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C95B0)();

    /// <summary>
    /// <code>Offset: 0x005C95E0
    /// unsigned int __cdecl ExperienceSystem::GetMaxAttribute2ndLevel()</code>
    /// </summary>
    public static uint GetMaxAttribute2ndLevel() => ((delegate* unmanaged[Cdecl]<uint>)0x005C95E0)();

    /// <summary>
    /// <code>Offset: 0x005C9610
    /// unsigned __int64 __cdecl ExperienceSystem::ExperienceToRaiseLevel(unsigned int,unsigned int)</code>
    /// </summary>
    public static ulong ExperienceToRaiseLevel(uint current_level, uint new_level) => ((delegate* unmanaged[Cdecl]<uint, uint, ulong>)0x005C9610)(current_level, new_level);
}

