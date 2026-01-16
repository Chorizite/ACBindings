namespace ACBindings.Internal;


/// <summary>Represents a node in the generator registry, holding information about generated items including type ID, timestamp, treasure type, slot number, checkpoint status, shop association, and quantity. Used to serialize and deserialize entries for persistence or network communication within the application’s pack system.</summary>
public unsafe struct GeneratorRegistryNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorRegistryNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, void> GeneratorRegistryNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_wcidOrTtype;
    public double ts;
    public int m_bTreasureType;
    public uint slot;
    public int checkpointed;
    public int shop;
    public int amount;

    // Generated Constructor
    public GeneratorRegistryNode() {
        _ConstructorInternal();
    }
    public GeneratorRegistryNode(ACBindings.Internal.GeneratorRegistryNode* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Initializes a new GeneratorRegistryNode instance with default values, assigning the vftable pointer and resetting all member fields to zero or an invalid identifier.
    /// <code>Offset: 0x005D1B70
    /// void __thiscall GeneratorRegistryNode::GeneratorRegistryNode(GeneratorRegistryNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, void>)0x005D1B70)(ref this);

    /// <summary>Creates a new GeneratorRegistryNode by copying the state from another instance.
    /// <code>Offset: 0x005D1BA0
    /// void __thiscall GeneratorRegistryNode::GeneratorRegistryNode(GeneratorRegistryNode*,const GeneratorRegistryNode*)</code>
    /// </summary>
    /// <param name="rhs">The source node to duplicate.</param>
    public void _ConstructorInternal(ACBindings.Internal.GeneratorRegistryNode* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, ACBindings.Internal.GeneratorRegistryNode*, void>)0x005D1BA0)(ref this, rhs);

    /// <summary>Packs the node's data into a contiguous block of memory at the supplied address, advancing the pointer past the written fields.
    /// <code>Offset: 0x005D1BF0
    /// unsigned int __thiscall GeneratorRegistryNode::Pack(GeneratorRegistryNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point after the packed data.</param>
    /// <param name="size">Number of bytes remaining in the destination buffer; packing occurs only if at least 32 bytes are available.</param>
    /// <returns>The number of bytes written into the buffer, always 32 when a full pack occurs.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, void**, uint, uint>)0x005D1BF0)(ref this, addr, size);

    /// <summary>Deserializes a GeneratorRegistryNode from the provided byte buffer, advancing the buffer pointer as data is consumed.
    /// <code>Offset: 0x005D1C60
    /// int __thiscall GeneratorRegistryNode::UnPack(GeneratorRegistryNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input buffer; will be advanced past the unpacked data upon return.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the time of call.</param>
    /// <returns>Non‑zero if the node was successfully populated, zero when the supplied size is insufficient for a full record.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, void**, uint, int>)0x005D1C60)(ref this, addr, size);
}

