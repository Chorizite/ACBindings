namespace ACBindings;

// PhysicsScriptTableData
public unsafe struct PhysicsScriptTableData
{
    // Members
    public ACBindings.AC1Legacy.SmartArray__ScriptAndModData script_array;

    // Methods
    // unsigned int* __thiscall PhysicsScriptTableData::GetScript(int*,unsigned int*,float)
    public uint* GetScript(uint* a2, float a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTableData, uint*, float, uint*>)0x00522540)(ref this, a2, a3);
    // unsigned int __thiscall PhysicsScriptTableData::Pack(PhysicsScriptTableData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTableData, void**, uint, uint>)0x00522600)(ref this, addr, size);
    // void __thiscall PhysicsScriptTableData::GetSubDataIDs(PhysicsScriptTableData*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTableData, ACBindings.QualifiedDataIDArray*, void>)0x00522680)(ref this, id_array);
    // int __thiscall PhysicsScriptTableData::UnPack(PhysicsScriptTableData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTableData, void**, uint, int>)0x00522910)(ref this, addr, size);
}

