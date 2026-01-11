namespace ACBindings.Internal;

public unsafe struct PhysicsScriptTableData
{
    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___ScriptAndModData script_array;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00522540
    /// unsigned int* __thiscall PhysicsScriptTableData::GetScript(int*,unsigned int*,float)</code>
    /// </summary>
    public uint* GetScript(uint* a2, float a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, uint*, float, uint*>)0x00522540)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00522600
    /// unsigned int __thiscall PhysicsScriptTableData::Pack(PhysicsScriptTableData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, void**, uint, uint>)0x00522600)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00522680
    /// void __thiscall PhysicsScriptTableData::GetSubDataIDs(PhysicsScriptTableData*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00522680)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00522910
    /// int __thiscall PhysicsScriptTableData::UnPack(PhysicsScriptTableData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, void**, uint, int>)0x00522910)(ref this, addr, size);
}

