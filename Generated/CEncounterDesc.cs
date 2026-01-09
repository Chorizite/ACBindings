namespace ACBindings;

// CEncounterDesc
public unsafe struct CEncounterDesc
{
    // Members
    public uint num_encounter_type;
    public ACBindings.EncounterType** encounter_table;
    public byte* encounter_map;

    // Methods
    // void __thiscall CEncounterDesc::Destroy(CEncounterDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEncounterDesc, void>)0x00503440)(ref this);
}

