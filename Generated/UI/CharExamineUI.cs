namespace ACBindings;

// CharExamineUI
public unsafe struct CharExamineUI
{
    // Base Classes
    public ACBindings.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindings.BasicCreatureExamineUI

    // Child Types
    // CharExamineUI_vtbl
    public unsafe struct CharExamineUI_vtbl
    {
        // Members
        public System.IntPtr Init; // function pointer
        public System.IntPtr SetAppraiseInfo; // function pointer
        public System.IntPtr Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_Text* m_displayText_Heritage;
    public ACBindings.UIElement_Text* m_displayText_Profession;
    public ACBindings.UIElement_Text* m_displayText_PlayerKiller;
    public ACBindings.UIElement_Text* m_displayText_AllegianceName;

    // Generated Constructor
    public CharExamineUI(ACBindings.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods
    // void __thiscall CharExamineUI::Show(CharExamineUI*,bool)
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharExamineUI, byte, void>)0x004AB950)(ref this, shown);
    // void __thiscall CharExamineUI::CharExamineUI(CharExamineUI*,gmExaminationUI*)
    public void _ConstructorInternal(ACBindings.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharExamineUI, ACBindings.gmExaminationUI*, void>)0x004AD740)(ref this, parentElement);
    // void __thiscall CharExamineUI::SetAppraiseInfo(CharExamineUI*,const AppraisalProfile*,int)
    public void SetAppraiseInfo(ACBindings.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CharExamineUI, ACBindings.AppraisalProfile*, int, void>)0x004B4EF0)(ref this, prof, is_new);
}

