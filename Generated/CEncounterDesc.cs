namespace ACBindings.Internal;

public unsafe struct CEncounterDesc
{
    // Members
    public uint num_encounter_type;
    public ACBindings.Internal.EncounterType** encounter_table;
    public byte* encounter_map;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00503440
    /// void __thiscall CEncounterDesc::Destroy(CEncounterDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEncounterDesc, void>)0x00503440)(ref this);
}

