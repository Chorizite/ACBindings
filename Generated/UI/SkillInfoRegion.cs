namespace ACBindings;

// SkillInfoRegion
public unsafe struct SkillInfoRegion
{
    // Base Classes
    public ACBindings.InfoRegion BaseClass_InfoRegion; // ACBindings.InfoRegion

    // Child Types
    // SkillInfoRegion_vtbl
    public unsafe struct SkillInfoRegion_vtbl
    {
        // Members
        public System.IntPtr OnQualityChanged; // function pointer
        public System.IntPtr OnQualityRemoved; // function pointer
        public System.IntPtr SkillInfoRegion_dtor_8; // function pointer
        public System.IntPtr GetLabel;
        public System.IntPtr GetTooltip;
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetStat; // function pointer
        public fixed byte gap1C[8];
        public System.IntPtr Update; // function pointer
        public System.IntPtr GetVitaeModifier; // function pointer
        public System.IntPtr SetState; // function pointer

        // Methods
    }

    // Members
    public uint m_Skill;
    public ACBindings.SKILL_ADVANCEMENT_CLASS m_AdvancementClass;

    // Generated Constructor
    public SkillInfoRegion(ACBindings.UIElement_ListBox* a2, int a3, int a4, int a5, uint a6, sbyte a7) {
        _ConstructorInternal(a2, a3, a4, a5, a6, a7);
    }

    // Methods
    // char __thiscall SkillInfoRegion::GetLabel(volatile LONG**,wchar_t**)
    public sbyte GetLabel(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillInfoRegion, System.IntPtr, sbyte>)0x004F1C10)(ref this, a2);
    // int __thiscall SkillInfoRegion::GetVitaeModifier(SkillInfoRegion*,const CACQualities*)
    public int GetVitaeModifier(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillInfoRegion, ACBindings.CACQualities*, int>)0x004F1C30)(ref this, i_playerDesc);
    // bool __thiscall SkillInfoRegion::Update(SkillInfoRegion*,const CACQualities*)
    public byte Update(ACBindings.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillInfoRegion, ACBindings.CACQualities*, byte>)0x004F2740)(ref this, i_playerDesc);
    // char __thiscall SkillInfoRegion::GetTooltip(unsigned int*,wchar_t**)
    public sbyte GetTooltip(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillInfoRegion, System.IntPtr, sbyte>)0x004F2C40)(ref this, a2);
    // int __thiscall SkillInfoRegion::SkillInfoRegion(int,UIElement_ListBox*,int,int,int,unsigned int,char)
    public int _ConstructorInternal(ACBindings.UIElement_ListBox* a2, int a3, int a4, int a5, uint a6, sbyte a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillInfoRegion, ACBindings.UIElement_ListBox*, int, int, int, uint, sbyte, int>)0x004F2DA0)(ref this, a2, a3, a4, a5, a6, a7);
}

