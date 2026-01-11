namespace ACBindings.Internal;

public unsafe struct CreatureExamineUI
{
    // Base Classes
    public ACBindings.Internal.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindings.Internal.BasicCreatureExamineUI

    // Child Types
    public unsafe struct CreatureExamineUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreatureExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_creatureDisplayName;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004AB920
    /// void __thiscall CreatureExamineUI::Show(CreatureExamineUI*,bool)</code>
    /// </summary>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureExamineUI, byte, void>)0x004AB920)(ref this, shown);

    /// <summary>
    /// <code>Offset: 0x004B4690
    /// void __thiscall CreatureExamineUI::SetAppraiseInfo(CreatureExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    public void SetAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreatureExamineUI, ACBindings.Internal.AppraisalProfile*, int, void>)0x004B4690)(ref this, prof, is_new);
}

