namespace ACBindings.Internal;


/// <summary>Represents a UI region dedicated to displaying a specific skill’s value and progression within the player interface.</summary>
/// <remarks>Holds the skill identifier, its current advancement class, and inherits layout and state handling from InfoRegion.</remarks>
public unsafe struct SkillInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct SkillInfoRegion_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, void> SkillInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Skill;
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS m_AdvancementClass;

    // Generated Constructor
    public SkillInfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, int a5, uint a6, sbyte a7) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7);
    }

    // Methods

    /// <summary>Retrieves the localized name of the skill represented by this region and stores it in the supplied buffer.
    /// <code>Offset: 0x004F1C10
    /// char __thiscall SkillInfoRegion::GetLabel(volatile LONG**,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wchar_t* that will receive the retrieved skill name; the function allocates or assigns the string.</param>
    /// <returns>Non‑zero if the skill name was successfully obtained, otherwise zero.</returns>
    public sbyte GetLabel(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, System.IntPtr, sbyte>)0x004F1C10)(ref this, a2);

    /// <summary>Determines how much a player's vitae enchantment increases the skill value represented by this region. If the player lacks a qualifying vitae or its modifier is already 1.0 or greater, no change occurs.
    /// <code>Offset: 0x004F1C30
    /// int __thiscall SkillInfoRegion::GetVitaeModifier(SkillInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The quality descriptor from which to query the player's vitae and skill level for this skill region.</param>
    /// <returns>Integer amount added to the base skill by the vitae enchantment; zero if no qualifying vitae applies.</returns>
    public int GetVitaeModifier(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, ACBindings.Internal.CACQualities*, int>)0x004F1C30)(ref this, i_playerDesc);

    /// <summary>Refreshes the skill information displayed in this region from the supplied player qualities, updating values and sending a notice when the advancement class changes.
    /// <code>Offset: 0x004F2740
    /// bool __thiscall SkillInfoRegion::Update(SkillInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality description containing current skill data.</param>
    /// <returns>True if the update succeeded (always true).</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F2740)(ref this, i_playerDesc);

    /// <summary>Retrieves the formatted tooltip text for the skill represented by this SkillInfoRegion and stores it in the supplied string pointer.
    /// <code>Offset: 0x004F2C40
    /// char __thiscall SkillInfoRegion::GetTooltip(unsigned int*,wchar_t**)</code>
    /// </summary>
    /// <param name="this">Pointer to the SkillInfoRegion instance.</param>
    /// <param name="a2">Reference to a wchar_t* that will be set to point at the newly constructed tooltip string; any previously referenced string is properly released.</param>
    /// <returns>Non‑zero if the tooltip was successfully generated, otherwise zero.</returns>
    public sbyte GetTooltip(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, System.IntPtr, sbyte>)0x004F2C40)(ref this, a2);

    /// <summary>Constructs a UI region that displays the name and tooltip for a specified skill, optionally registers associated quality data and queries the player’s advancement class.
    /// <code>Offset: 0x004F2DA0
    /// int __thiscall SkillInfoRegion::SkillInfoRegion(int,UIElement_ListBox*,int,int,int,unsigned int,char)</code>
    /// </summary>
    /// <param name="a2">The parent list box into which this skill information region is inserted.</param>
    /// <param name="a3">Row or index position within the parent list box.</param>
    /// <param name="a4">Column or offset used for layout placement of the region.</param>
    /// <param name="a5">Identifier of the skill whose data will be shown by this region.</param>
    /// <param name="a6">Flags that modify UI element behavior such as style or visibility.</param>
    /// <param name="a7">When non‑zero, registers quality information for the skill and retrieves the player’s advancement class.</param>
    /// <returns>Pointer to the initialized SkillInfoRegion instance.</returns>
    public int _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, int a5, uint a6, sbyte a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, int, uint, sbyte, int>)0x004F2DA0)(ref this, a2, a3, a4, a5, a6, a7);
}

