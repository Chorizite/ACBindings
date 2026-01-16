namespace ACBindings.Internal;


/// <summary>Represents a region in the UI that displays a specific attribute value, updating it from appraisal data or player qualities. Provides label and tooltip information for the attribute.</summary>
public unsafe struct AttributeInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct AttributeInfoRegion_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, void> AttributeInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, byte> Update; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeInfoRegion*, uint, byte> SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Attribute;

    // Generated Constructor
    public AttributeInfoRegion(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, uint a5, sbyte a6) {
        _ConstructorInternal(a2, a3, a4, a5, a6);
    }

    // Methods

    /// <summary>Retrieves the display label for the attribute stored in this region and writes it into the supplied buffer.
    /// <code>Offset: 0x004F1B90
    /// char __thiscall AttributeInfoRegion::GetLabel(int*,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a location where the resulting attribute name will be stored.</param>
    /// <returns>Status code returned by SkillSystem::InqAttributeName (typically 0 on success).</returns>
    public sbyte GetLabel(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, void**, sbyte>)0x004F1B90)(ref this, a2);

    /// <summary>Retrieves the tooltip text for the attribute represented by this region.
    /// <code>Offset: 0x004F1BB0
    /// char __thiscall AttributeInfoRegion::GetTooltip(int*,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer that receives the attribute description string.</param>
    /// <returns>Non‑zero if the description was obtained successfully; otherwise zero.</returns>
    public sbyte GetTooltip(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, void**, sbyte>)0x004F1BB0)(ref this, a2);

    /// <summary>Initializes an AttributeInfoRegion instance with attribute information, displaying its name and description within a list box and optionally registering it for quality updates.
    /// <code>Offset: 0x004F2190
    /// int __thiscall AttributeInfoRegion::AttributeInfoRegion(int,UIElement_ListBox*,int,int,unsigned int,char)</code>
    /// </summary>
    /// <param name="a2">UIElement_ListBox element linked to this region.</param>
    /// <param name="a3">Additional layout or index parameter used by the base InfoRegion constructor.</param>
    /// <param name="a4">Attribute identifier whose name and description are retrieved and shown.</param>
    /// <param name="a5">Flags influencing display or behavior of the region.</param>
    /// <param name="a6">When non-zero, registers the region with QualityRegistrar to receive quality change callbacks.</param>
    /// <returns>Pointer to the initialized AttributeInfoRegion object.</returns>
    public int _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, uint a5, sbyte a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, uint, sbyte, int>)0x004F2190)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Updates the displayed value of this attribute region by querying the supplied player qualities and formatting the result as an integer string.
    /// <code>Offset: 0x004F2570
    /// bool __thiscall AttributeInfoRegion::Update(AttributeInfoRegion*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player's quality information from which the attribute value is retrieved.</param>
    /// <returns>True if the update succeeded; always true in the current implementation.</returns>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F2570)(ref this, i_playerDesc);

    /// <summary>Updates the displayed attribute value in the UI using information from the supplied appraisal profile, formatting the number or a placeholder as needed and applying visual cues for enchantment status.
    /// <code>Offset: 0x004F29F0
    /// bool __thiscall AttributeInfoRegion::Update(AttributeInfoRegion*,const AppraisalProfile*)</code>
    /// </summary>
    /// <param name="i_prof">The appraisal profile containing creature, hook, weapon, or armor data used to retrieve the attribute value.</param>
    /// <returns>True if the update succeeded (always true in this implementation).</returns>
    public byte Update(ACBindings.Internal.AppraisalProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeInfoRegion, ACBindings.Internal.AppraisalProfile*, byte>)0x004F29F0)(ref this, i_prof);
}

