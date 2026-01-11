namespace ACBindings.Internal;

public unsafe struct ExamineSubUI
{
    // Child Types
    public unsafe struct ExamineSubUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ExamineSubUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ExamineSubUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ExamineSubUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint cur_objid;
    public ACBindings.Internal.ACCWeenieObject* cur_weenobj;
    public ACBindings.Internal.AppraisalProfile cur_prof;
    public ACBindings.Internal.gmExaminationUI* m_pParentElement;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004AB530
    /// void __thiscall ExamineSubUI::Init(ExamineSubUI*,unsigned int,ACCWeenieObject*)</code>
    /// </summary>
    public void Init(uint objid, ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExamineSubUI, uint, ACBindings.Internal.ACCWeenieObject*, void>)0x004AB530)(ref this, objid, weenObj);
}

