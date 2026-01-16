namespace ACBindings.Internal;


/// <summary>Manages the state of an item examination UI, tracking the object being examined, its Weenie representation, appraisal data, and parent element linkage.</summary>
public unsafe struct ExamineSubUI
{
    // Child Types
    public unsafe struct ExamineSubUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ExamineSubUI*, uint, ACBindings.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ExamineSubUI*, ACBindings.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ExamineSubUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint cur_objid;
    public ACBindings.Internal.ACCWeenieObject* cur_weenobj;
    public ACBindings.Internal.AppraisalProfile cur_prof;
    public ACBindings.Internal.gmExaminationUI* m_pParentElement;

    // Methods

    /// <summary>Initializes the Examination Sub‑UI with a specific object ID and its associated Weenie object.
    /// <code>Offset: 0x004AB530
    /// void __thiscall ExamineSubUI::Init(ExamineSubUI*,unsigned int,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="objid">The unique identifier of the examined object.</param>
    /// <param name="weenObj">Pointer to the ACCWeenieObject representing the examined item or entity.</param>
    public void Init(uint objid, ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ExamineSubUI, uint, ACBindings.Internal.ACCWeenieObject*, void>)0x004AB530)(ref this, objid, weenObj);
}

