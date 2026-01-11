namespace ACBindings.Internal;

public unsafe struct GeneratorRegistryNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorRegistryNode_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, void> GeneratorRegistryNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistryNode*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005D1B70
    /// void __thiscall GeneratorRegistryNode::GeneratorRegistryNode(GeneratorRegistryNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, void>)0x005D1B70)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D1BA0
    /// void __thiscall GeneratorRegistryNode::GeneratorRegistryNode(GeneratorRegistryNode*,const GeneratorRegistryNode*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.GeneratorRegistryNode* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, ACBindings.Internal.GeneratorRegistryNode*, void>)0x005D1BA0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005D1BF0
    /// unsigned int __thiscall GeneratorRegistryNode::Pack(GeneratorRegistryNode*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, void**, uint, uint>)0x005D1BF0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D1C60
    /// int __thiscall GeneratorRegistryNode::UnPack(GeneratorRegistryNode*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistryNode, void**, uint, int>)0x005D1C60)(ref this, addr, size);
}

