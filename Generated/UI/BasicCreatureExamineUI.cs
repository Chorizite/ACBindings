namespace ACBindings.Internal;

public unsafe struct BasicCreatureExamineUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.Internal.ExamineSubUI

    // Child Types
    public unsafe struct BasicCreatureExamineUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BasicCreatureExamineUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BasicCreatureExamineUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BasicCreatureExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_basicCreatureExamineBaseField;
    public ACBindings.Internal.UIElement* m_creatureInfoSubPanel;
    public ACBindings.Internal.UIElement* m_characterInfoSubPanel;
    public ACBindings.Internal.UIElement_Text* m_levelValueText;
    public ACBindings.Internal.UIElement_Viewport* m_pPaperDoll;
    public ACBindings.Internal.CPhysicsObj* m_p3DObj;
    public ACBindings.Internal.UIElement_ListBox* m_extraInfoList;

    // Generated Constructor
    public BasicCreatureExamineUI(ACBindings.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004ABD40
    /// void __thiscall BasicCreatureExamineUI::Init(BasicCreatureExamineUI*,unsigned int,ACCWeenieObject*)</code>
    /// </summary>
    public void Init(uint objid, ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasicCreatureExamineUI, uint, ACBindings.Internal.ACCWeenieObject*, void>)0x004ABD40)(ref this, objid, weenObj);

    /// <summary>
    /// <code>Offset: 0x004ABF30
    /// void __thiscall BasicCreatureExamineUI::AddLineToMiscInfo(_DWORD*,int*,int*,int)</code>
    /// </summary>
    public void AddLineToMiscInfo(int* a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasicCreatureExamineUI, int*, int*, int, void>)0x004ABF30)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x004AD0B0
    /// void __thiscall BasicCreatureExamineUI::BasicCreatureExamineUI(BasicCreatureExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasicCreatureExamineUI, ACBindings.Internal.gmExaminationUI*, void>)0x004AD0B0)(ref this, parentElement);

    /// <summary>
    /// <code>Offset: 0x004AD660
    /// void __thiscall BasicCreatureExamineUI::~BasicCreatureExamineUI(BasicCreatureExamineUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasicCreatureExamineUI, void>)0x004AD660)(ref this);

    /// <summary>
    /// <code>Offset: 0x004B4510
    /// void __thiscall BasicCreatureExamineUI::SetLevelValueText(BasicCreatureExamineUI*,int)</code>
    /// </summary>
    public void SetLevelValueText(int level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasicCreatureExamineUI, int, void>)0x004B4510)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x004B4610
    /// void __thiscall BasicCreatureExamineUI::SetAppraiseInfo(BasicCreatureExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    public void SetAppraiseInfo(ACBindings.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BasicCreatureExamineUI, ACBindings.Internal.AppraisalProfile*, int, void>)0x004B4610)(ref this, prof, is_new);
}

