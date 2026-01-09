namespace ACBindings;

// CreatureExamineUI
public unsafe struct CreatureExamineUI
{
    // Base Classes
    public ACBindings.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindings.BasicCreatureExamineUI

    // Child Types
    // CreatureExamineUI_vtbl
    public unsafe struct CreatureExamineUI_vtbl
    {
        // Members
        public System.IntPtr Init; // function pointer
        public System.IntPtr SetAppraiseInfo; // function pointer
        public System.IntPtr Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement_Text* m_creatureDisplayName;

    // Methods
    // void __thiscall CreatureExamineUI::Show(CreatureExamineUI*,bool)
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureExamineUI, byte, void>)0x004AB920)(ref this, shown);
    // void __thiscall CreatureExamineUI::SetAppraiseInfo(CreatureExamineUI*,const AppraisalProfile*,int)
    public void SetAppraiseInfo(ACBindings.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreatureExamineUI, ACBindings.AppraisalProfile*, int, void>)0x004B4690)(ref this, prof, is_new);
}

