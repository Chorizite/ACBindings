namespace ACBindings.Internal;

public unsafe struct CharExamineUI
{
    // Base Classes
    public ACBindings.Internal.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindings.Internal.BasicCreatureExamineUI

    // Child Types
    public unsafe struct CharExamineUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CharExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_displayText_Heritage;
    public ACBindings.Internal.UIElement_Text* m_displayText_Profession;
    public ACBindings.Internal.UIElement_Text* m_displayText_PlayerKiller;
    public ACBindings.Internal.UIElement_Text* m_displayText_AllegianceName;

    // Generated Constructor
    public CharExamineUI(ACBindings.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004AB950
    /// void __thiscall CharExamineUI::Show(CharExamineUI*,bool)</code>
    /// </summary>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharExamineUI, byte, void>)0x004AB950)(ref this, shown);

    /// <summary>
    /// <code>Offset: 0x004AD740
    /// void __thiscall CharExamineUI::CharExamineUI(CharExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharExamineUI, ACBindings.Internal.gmExaminationUI*, void>)0x004AD740)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004B4EF0
    /// void __thiscall CharExamineUI::SetAppraiseInfo(CharExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    public void SetAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CharExamineUI, ACBindings.Internal.AppraisalProfile*, int, void>)0x004B4EF0)(ref this, prof, is_new);
}

