namespace ACBindings;

// GeneratorRegistryNode
public unsafe struct GeneratorRegistryNode
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GeneratorRegistryNode_vtbl
    public unsafe struct GeneratorRegistryNode_vtbl
    {
        // Members
        public System.IntPtr GeneratorRegistryNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID m_wcidOrTtype;
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
    public GeneratorRegistryNode(ACBindings.GeneratorRegistryNode* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall GeneratorRegistryNode::GeneratorRegistryNode(GeneratorRegistryNode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorRegistryNode, void>)0x005D1B70)(ref this);
    // void __thiscall GeneratorRegistryNode::GeneratorRegistryNode(GeneratorRegistryNode*,const GeneratorRegistryNode*)
    public void _ConstructorInternal(ACBindings.GeneratorRegistryNode* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorRegistryNode, ACBindings.GeneratorRegistryNode*, void>)0x005D1BA0)(ref this, rhs);
    // unsigned int __thiscall GeneratorRegistryNode::Pack(GeneratorRegistryNode*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorRegistryNode, void**, uint, uint>)0x005D1BF0)(ref this, addr, size);
    // int __thiscall GeneratorRegistryNode::UnPack(GeneratorRegistryNode*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorRegistryNode, void**, uint, int>)0x005D1C60)(ref this, addr, size);
}

