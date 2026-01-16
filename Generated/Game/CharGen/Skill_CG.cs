namespace ACBindings.Internal;


/// <summary>Represents a skill configuration, storing its identifier and associated costs.</summary>
public unsafe struct Skill_CG
{
    // Child Types

    /// <summary>Defines the virtual function table layout for Skill_CG, exposing a Serialize method that serializes skill data into an Archive.</summary>
    public unsafe struct Skill_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>Initializes a new Skill_CG instance with default values for skill number and costs.
    /// <code>Offset: 0x005BE4F0
    /// void __thiscall Skill_CG::Skill_CG(Skill_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill_CG, void>)0x005BE4F0)(ref this);

    /// <summary>Serializes or deserializes the Skill_CG's fields (skillNum, normalCost, primaryCost) using the provided Archive instance.
    /// <code>Offset: 0x005BEA90
    /// void __thiscall Skill_CG::Serialize(Skill_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive to read from or write to during serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill_CG, ACBindings.Internal.Archive*, void>)0x005BEA90)(ref this, io_archive);
}

