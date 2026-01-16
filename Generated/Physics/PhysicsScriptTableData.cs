namespace ACBindings.Internal;


/// <summary>Contains a dynamic list of physics scripts with corresponding modifiers, enabling runtime selection based on temporal conditions.</summary>
public unsafe struct PhysicsScriptTableData
{
    // Members
    public ACBindings.Internal.AC1Legacy.SmartArray___ScriptAndModData script_array;

    // Methods

    /// <summary>Retrieves the script identifier associated with the specified time from the object's script table.
    /// <code>Offset: 0x00522540
    /// unsigned int* __thiscall PhysicsScriptTableData::GetScript(int*,unsigned int*,float)</code>
    /// </summary>
    /// <param name="a2">Output parameter that receives the found script ID; set to INVALID_DID_234.baseclass_0.id when no matching entry exists.</param>
    /// <param name="a3">Time value used to select the appropriate script entry.</param>
    /// <returns>Pointer to the output script identifier (the same pointer passed in as a2).</returns>
    public uint* GetScript(uint* a2, float a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, uint*, float, uint*>)0x00522540)(ref this, a2, a3);

    /// <summary>Packs the script array into a binary format, writing a 4‑byte count followed by an 8‑byte record for each script.
    /// <code>Offset: 0x00522600
    /// unsigned int __thiscall PhysicsScriptTableData::Pack(PhysicsScriptTableData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the start of a writable memory block; after packing, *addr points just past the data written.</param>
    /// <param name="size">Number of bytes available at the buffer location pointed to by *addr.</param>
    /// <returns>Required total number of bytes (4 + 8 × scriptCount). If size is large enough, this value equals the number of bytes actually written; otherwise no data is written but the required size is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, void**, uint, uint>)0x00522600)(ref this, addr, size);

    /// <summary>Collects the qualified identifiers of all scripts stored in this table and appends them to the supplied array.
    /// <code>Offset: 0x00522680
    /// void __thiscall PhysicsScriptTableData::GetSubDataIDs(PhysicsScriptTableData*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">Array to receive the collected QualifiedDataID entries.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00522680)(ref this, id_array);

    /// <summary>Unpacks a sequence of script and mod values from binary input into the object's script array, resizing the container as necessary.
    /// <code>Offset: 0x00522910
    /// int __thiscall PhysicsScriptTableData::UnPack(PhysicsScriptTableData*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the serialized data buffer; updated to point after the processed block.</param>
    /// <param name="size">Size of the data block (unused by this implementation).</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTableData, void**, uint, int>)0x00522910)(ref this, addr, size);
}

