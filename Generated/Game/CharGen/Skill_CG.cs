namespace ACBindings;

// Skill_CG
public unsafe struct Skill_CG
{
    // Child Types
    // Skill_CG_vtbl
    public unsafe struct Skill_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

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
    // void __thiscall Skill_CG::Skill_CG(Skill_CG*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill_CG, void>)0x005BE4F0)(ref this);
    // void __thiscall Skill_CG::Serialize(Skill_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill_CG, ACBindings.Archive*, void>)0x005BEA90)(ref this, io_archive);
}

