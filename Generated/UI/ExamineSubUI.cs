namespace ACBindings;

// ExamineSubUI
public unsafe struct ExamineSubUI
{
    // Child Types
    // ExamineSubUI_vtbl
    public unsafe struct ExamineSubUI_vtbl
    {
        // Members
        public System.IntPtr Init; // function pointer
        public System.IntPtr SetAppraiseInfo; // function pointer
        public System.IntPtr Show; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint cur_objid;
    public ACBindings.ACCWeenieObject* cur_weenobj;
    public ACBindings.AppraisalProfile cur_prof;
    public ACBindings.gmExaminationUI* m_pParentElement;

    // Methods
    // void __thiscall ExamineSubUI::Init(ExamineSubUI*,unsigned int,ACCWeenieObject*)
    public void Init(uint objid, ACBindings.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ExamineSubUI, uint, ACBindings.ACCWeenieObject*, void>)0x004AB530)(ref this, objid, weenObj);
}

