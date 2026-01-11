namespace ACBindings.Internal;

public unsafe struct SpellExamineUI
{
    // Base Classes
    public ACBindings.Internal.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.Internal.ExamineSubUI

    // Child Types
    public unsafe struct SpellExamineUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_spellExamineBaseField;
    public ACBindings.Internal.UIElement_Text* m_magicSchoolText;
    public ACBindings.Internal.UIElement_Text* m_spellManaText;
    public ACBindings.Internal.UIElement_Text* m_spellRangeText;
    public ACBindings.Internal.UIElement_Text* m_spellDurationText;
    public ACBindings.Internal.UIElement_Text* m_spellDisplayText;
    public ACBindings.Internal.UIElement* m_spellIcon;
    public ACBindings.Internal.UIElement_ListBox* m_formulaListBox;
    public uint cur_spellid;
    public int m_componentListX;
    public int m_componentListW;

    // Generated Constructor
    public SpellExamineUI(ACBindings.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004ABFD0
    /// void __thiscall SpellExamineUI::SpellExamineUI(SpellExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, ACBindings.Internal.gmExaminationUI*, void>)0x004ABFD0)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004AC170
    /// void __thiscall SpellExamineUI::ClearIcons(SpellExamineUI*)</code>
    /// </summary>
    public void ClearIcons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, void>)0x004AC170)(ref this);

    /// <summary>
    /// <code>Offset: 0x004AC1A0
    /// void __thiscall SpellExamineUI::UpdateComponents(SpellExamineUI*,ComponentTrackerUpdate)</code>
    /// </summary>
    public void UpdateComponents(ACBindings.Internal.ComponentTrackerUpdate change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, ACBindings.Internal.ComponentTrackerUpdate, void>)0x004AC1A0)(ref this, change);

    /// <summary>
    /// <code>Offset: 0x004AC2E0
    /// unsigned int __thiscall SpellExamineUI::GetComponentObjectID(SpellExamineUI*,unsigned int)</code>
    /// </summary>
    public uint GetComponentObjectID(uint scid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, uint, uint>)0x004AC2E0)(ref this, scid);

    /// <summary>
    /// <code>Offset: 0x004AD7D0
    /// float __thiscall SpellExamineUI::DetermineSpellRange(SpellExamineUI*,CSpellBase*)</code>
    /// </summary>
    public float DetermineSpellRange(ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, ACBindings.Internal.CSpellBase*, float>)0x004AD7D0)(ref this, spellBase);

    /// <summary>
    /// <code>Offset: 0x004B6A60
    /// void __thiscall SpellExamineUI::SetManaText(SpellExamineUI*,wchar_t*,int)</code>
    /// </summary>
    public void SetManaText(System.IntPtr baseMana, int manaMod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, System.IntPtr, int, void>)0x004B6A60)(ref this, baseMana, manaMod);

    /// <summary>
    /// <code>Offset: 0x004B6C20
    /// void __thiscall SpellExamineUI::AddItemInfo(SpellExamineUI*,const char*)</code>
    /// </summary>
    public void AddItemInfo(sbyte* txt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, sbyte*, void>)0x004B6C20)(ref this, txt);

    /// <summary>
    /// <code>Offset: 0x004B6E30
    /// int __thiscall SpellExamineUI::ExamineSpell(SpellExamineUI*,const unsigned int)</code>
    /// </summary>
    public int ExamineSpell(uint spellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellExamineUI, uint, int>)0x004B6E30)(ref this, spellid);
}

