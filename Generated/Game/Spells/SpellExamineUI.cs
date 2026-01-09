namespace ACBindings;

// SpellExamineUI
public unsafe struct SpellExamineUI
{
    // Base Classes
    public ACBindings.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.ExamineSubUI

    // Child Types
    // SpellExamineUI_vtbl
    public unsafe struct SpellExamineUI_vtbl
    {
        // Members
        public System.IntPtr Init; // function pointer
        public System.IntPtr SetAppraiseInfo; // function pointer
        public System.IntPtr Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement* m_spellExamineBaseField;
    public ACBindings.UIElement_Text* m_magicSchoolText;
    public ACBindings.UIElement_Text* m_spellManaText;
    public ACBindings.UIElement_Text* m_spellRangeText;
    public ACBindings.UIElement_Text* m_spellDurationText;
    public ACBindings.UIElement_Text* m_spellDisplayText;
    public ACBindings.UIElement* m_spellIcon;
    public ACBindings.UIElement_ListBox* m_formulaListBox;
    public uint cur_spellid;
    public int m_componentListX;
    public int m_componentListW;

    // Generated Constructor
    public SpellExamineUI(ACBindings.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods
    // void __thiscall SpellExamineUI::SpellExamineUI(SpellExamineUI*,gmExaminationUI*)
    public void _ConstructorInternal(ACBindings.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, ACBindings.gmExaminationUI*, void>)0x004ABFD0)(ref this, parentElement);
    // void __thiscall SpellExamineUI::ClearIcons(SpellExamineUI*)
    public void ClearIcons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, void>)0x004AC170)(ref this);
    // void __thiscall SpellExamineUI::UpdateComponents(SpellExamineUI*,ComponentTrackerUpdate)
    public void UpdateComponents(ACBindings.ComponentTrackerUpdate change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, ACBindings.ComponentTrackerUpdate, void>)0x004AC1A0)(ref this, change);
    // unsigned int __thiscall SpellExamineUI::GetComponentObjectID(SpellExamineUI*,unsigned int)
    public uint GetComponentObjectID(uint scid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, uint, uint>)0x004AC2E0)(ref this, scid);
    // float __thiscall SpellExamineUI::DetermineSpellRange(SpellExamineUI*,CSpellBase*)
    public float DetermineSpellRange(ACBindings.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, ACBindings.CSpellBase*, float>)0x004AD7D0)(ref this, spellBase);
    // void __thiscall SpellExamineUI::SetManaText(SpellExamineUI*,wchar_t*,int)
    public void SetManaText(System.IntPtr baseMana, int manaMod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, System.IntPtr, int, void>)0x004B6A60)(ref this, baseMana, manaMod);
    // void __thiscall SpellExamineUI::AddItemInfo(SpellExamineUI*,const char*)
    public void AddItemInfo(sbyte* txt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, sbyte*, void>)0x004B6C20)(ref this, txt);
    // int __thiscall SpellExamineUI::ExamineSpell(SpellExamineUI*,const unsigned int)
    public int ExamineSpell(uint spellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellExamineUI, uint, int>)0x004B6E30)(ref this, spellid);
}

