namespace ACBindings.Internal;

public unsafe struct Skill_CG
{
    // Child Types
    public unsafe struct Skill_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int skillNum;
    public int normalCost;
    public int primaryCost;

    // Generated Constructor
    public Skill_CG() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BE4F0
    /// void __thiscall Skill_CG::Skill_CG(Skill_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill_CG, void>)0x005BE4F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BEA90
    /// void __thiscall Skill_CG::Serialize(Skill_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill_CG, ACBindings.Internal.Archive*, void>)0x005BEA90)(ref this, io_archive);
}

