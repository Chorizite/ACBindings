namespace ACBindings.Internal;


/// <summary>Provides a UI region for displaying a creature’s secondary attribute, formatting the current and maximum values (optionally as a percentage) and integrating with quality‑change monitoring.</summary>
public unsafe struct Attribute2ndInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct Attribute2ndInfoRegion_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, void> Attribute2ndInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute2ndInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_CurAttribute;
    public uint m_MaxAttribute;
    public byte m_bShowPercent;

    // Generated Constructor
    public Attribute2ndInfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, sbyte a5, uint a6, sbyte a7) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7);
    }

    // Methods

    /// <summary>Retrieves the localized name for the current secondary attribute shown in this information region.
    /// <code>Offset: 0x004F1BD0
    /// char __thiscall Attribute2ndInfoRegion::GetLabel(int*,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a void* where the function stores the address of the resulting string.</param>
    /// <returns>Non‑zero if the name was successfully retrieved; zero otherwise.</returns>
    public sbyte GetLabel(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, void**, sbyte>)0x004F1BD0)(ref this, a2);

    /// <summary>Retrieves the tooltip text for the region's secondary attribute from the skill system.
    /// <code>Offset: 0x004F1BF0
    /// char __thiscall Attribute2ndInfoRegion::GetTooltip(int*,void**)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the tooltip description returned by SkillSystem::InqAttribute2ndDescription.</param>
    /// <returns>Non-zero on success; zero if the tooltip cannot be retrieved.</returns>
    public sbyte GetTooltip(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, void**, sbyte>)0x004F1BF0)(ref this, a2);

    /// <summary>Calculates how a Vitae enchantment modifies the maximum attribute for the supplied player qualities.
    /// <code>Offset: 0x004F1D90
    /// int __thiscall Attribute2ndInfoRegion::GetVitaeModifier(Attribute2ndInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality descriptor containing current attributes and enchantments.</param>
    /// <returns>Difference between the enchanted attribute value and its original value; zero if no applicable vitae or modifier already ≥ 1.0.</returns>
    public int GetVitaeModifier(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.CACQualities*, int>)0x004F1D90)(ref this, i_playerDesc);

    /// <summary>Initializes an Attribute2ndInfoRegion inside a list box, configuring its label, value display, tooltip and optional quality‑change monitoring for the specified secondary attribute.
    /// <code>Offset: 0x004F22E0
    /// int __thiscall Attribute2ndInfoRegion::Attribute2ndInfoRegion(int,UIElement_ListBox*,int,int,char,unsigned int,char)</code>
    /// </summary>
    /// <param name="parentListBox">The UIElement_ListBox that will contain this info region.</param>
    /// <param name="index">Order or index of the region within the list; forwarded to the base InfoRegion constructor.</param>
    /// <param name="maxValue">Maximum value for the displayed attribute, used for formatting and tooltip creation.</param>
    /// <param name="showPercent">If non‑zero, formats the displayed value as a percentage.</param>
    /// <param name="attributeId">Identifier of the secondary attribute to display.</param>
    /// <param name="registerQuality">When set, registers this region with QualityRegistrar, loads related formula attributes from Attribute2ndTable and establishes quality‑change callbacks.</param>
    /// <returns>Pointer to the newly constructed Attribute2ndInfoRegion instance (the same as the 'this' pointer).</returns>
    public int _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, sbyte a5, uint a6, sbyte a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, sbyte, uint, sbyte, int>)0x004F22E0)(ref this, a2, a3, a4, a5, a6, a7);

    /// <summary>Updates the value display of a second attribute in this info region based on the supplied player description.
    /// <code>Offset: 0x004F2640
    /// bool __thiscall Attribute2ndInfoRegion::Update(Attribute2ndInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="this">The Attribute2ndInfoRegion instance whose UI text element will be updated.</param>
    /// <param name="i_playerDesc">Pointer to the CACQualities object that provides current and maximum values for the attribute.</param>
    /// <returns>Always true, indicating the update succeeded.</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F2640)(ref this, i_playerDesc);

    /// <summary>Updates a secondary attribute text element using values from an appraisal profile, formatting as “current/max” (optionally with a percentage) or displaying “???” when data is missing.
    /// <code>Offset: 0x004F2AE0
    /// bool __thiscall Attribute2ndInfoRegion::Update(Attribute2ndInfoRegion*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="i_prof">Read‑only appraisal profile supplying the creature’s attributes and success status.</param>
    /// <returns>Always true; indicates that the update operation completed.</returns>
    public byte Update(ACBindings.Internal.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndInfoRegion, ACBindings.Internal.AppraisalProfile*, byte>)0x004F2AE0)(ref this, i_prof);
}

