namespace ACBindings.Internal;

public unsafe struct SkillInfoRegion
{
    // Base Classes
    public ACBindings.Internal.InfoRegion BaseClass_InfoRegion; // ACBindings.Internal.InfoRegion

    // Child Types
    public unsafe struct SkillInfoRegion_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void> OnQualityRemoved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, void> SkillInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.StatType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, uint> GetStat; // function pointer
        public fixed byte gap1C[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, byte> Update; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, ACBindings.Internal.CACQualities*, int> GetVitaeModifier; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillInfoRegion*, uint, byte> SetState; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004F1C10
    /// char __thiscall SkillInfoRegion::GetLabel(volatile LONG**,wchar_t**)</code>
    /// </summary>
    public sbyte GetLabel(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, System.IntPtr, sbyte>)0x004F1C10)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F1C30
    /// int __thiscall SkillInfoRegion::GetVitaeModifier(SkillInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public int GetVitaeModifier(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, ACBindings.Internal.CACQualities*, int>)0x004F1C30)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F2740
    /// bool __thiscall SkillInfoRegion::Update(SkillInfoRegion*,const CACQualities*)</code>
    /// </summary>
    public byte Update(ACBindings.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, ACBindings.Internal.CACQualities*, byte>)0x004F2740)(ref this, i_playerDesc);

    /// <summary>
    /// <code>Offset: 0x004F2C40
    /// char __thiscall SkillInfoRegion::GetTooltip(unsigned int*,wchar_t**)</code>
    /// </summary>
    public sbyte GetTooltip(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, System.IntPtr, sbyte>)0x004F2C40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F2DA0
    /// int __thiscall SkillInfoRegion::SkillInfoRegion(int,UIElement_ListBox*,int,int,int,unsigned int,char)</code>
    /// </summary>
    public int _ConstructorInternal(ACBindings.Internal.UIElement_ListBox* a2, int a3, int a4, int a5, uint a6, sbyte a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillInfoRegion, ACBindings.Internal.UIElement_ListBox*, int, int, int, uint, sbyte, int>)0x004F2DA0)(ref this, a2, a3, a4, a5, a6, a7);
}

