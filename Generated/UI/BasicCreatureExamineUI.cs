namespace ACBindings;

// BasicCreatureExamineUI
public unsafe struct BasicCreatureExamineUI : System.IDisposable
{
    // Base Classes
    public ACBindings.ExamineSubUI BaseClass_ExamineSubUI; // ACBindings.ExamineSubUI

    // Statics
    public static ACBindings.SmartArray__InfoRegion_ptr* m_rgTokens = (ACBindings.SmartArray__InfoRegion_ptr*)0x00840124;

    // Child Types
    // BasicCreatureExamineUI_vtbl
    public unsafe struct BasicCreatureExamineUI_vtbl
    {
        // Members
        public System.IntPtr Init; // function pointer
        public System.IntPtr SetAppraiseInfo; // function pointer
        public System.IntPtr Show; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement* m_basicCreatureExamineBaseField;
    public ACBindings.UIElement* m_creatureInfoSubPanel;
    public ACBindings.UIElement* m_characterInfoSubPanel;
    public ACBindings.UIElement_Text* m_levelValueText;
    public ACBindings.UIElement_Viewport* m_pPaperDoll;
    public ACBindings.CPhysicsObj* m_p3DObj;
    public ACBindings.UIElement_ListBox* m_extraInfoList;

    // Generated Constructor
    public BasicCreatureExamineUI(ACBindings.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall BasicCreatureExamineUI::Init(BasicCreatureExamineUI*,unsigned int,ACCWeenieObject*)
    public void Init(uint objid, ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasicCreatureExamineUI, uint, ACBindings.ACCWeenieObject*, void>)0x004ABD40)(ref this, objid, weenObj);
    // void __thiscall BasicCreatureExamineUI::AddLineToMiscInfo(_DWORD*,int*,int*,int)
    public void AddLineToMiscInfo(int* a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasicCreatureExamineUI, int*, int*, int, void>)0x004ABF30)(ref this, a2, a3, a4);
    // void __thiscall BasicCreatureExamineUI::BasicCreatureExamineUI(BasicCreatureExamineUI*,gmExaminationUI*)
    public void _ConstructorInternal(ACBindings.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasicCreatureExamineUI, ACBindings.gmExaminationUI*, void>)0x004AD0B0)(ref this, parentElement);
    // void __thiscall BasicCreatureExamineUI::~BasicCreatureExamineUI(BasicCreatureExamineUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasicCreatureExamineUI, void>)0x004AD660)(ref this);
    // void __thiscall BasicCreatureExamineUI::SetLevelValueText(BasicCreatureExamineUI*,int)
    public void SetLevelValueText(int level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasicCreatureExamineUI, int, void>)0x004B4510)(ref this, level);
    // void __thiscall BasicCreatureExamineUI::SetAppraiseInfo(BasicCreatureExamineUI*,const AppraisalProfile*,int)
    public void SetAppraiseInfo(ACBindings.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BasicCreatureExamineUI, ACBindings.AppraisalProfile*, int, void>)0x004B4610)(ref this, prof, is_new);
}

