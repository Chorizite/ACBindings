namespace ACBindings.Internal;


/// <summary>Keeps essential data for a skill, containing its name and numeric identifier.</summary>
public unsafe struct SkillRecord
{
    // Members
    public fixed sbyte name[30];
    public uint id;

    // Methods
}

