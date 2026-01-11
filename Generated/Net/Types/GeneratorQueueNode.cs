namespace ACBindings.Internal;

public unsafe struct GeneratorQueueNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorQueueNode_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, void> GeneratorQueueNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint slot;
    public double when;

    // Generated Constructor
    public GeneratorQueueNode() {
        _ConstructorInternal();
    }
    public GeneratorQueueNode(ACBindings.Internal.GeneratorQueueNode* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D1CE0
    /// void __thiscall GeneratorQueueNode::GeneratorQueueNode(GeneratorQueueNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, void>)0x005D1CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D1D00
    /// void __thiscall GeneratorQueueNode::GeneratorQueueNode(GeneratorQueueNode*,const GeneratorQueueNode*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.GeneratorQueueNode* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, ACBindings.Internal.GeneratorQueueNode*, void>)0x005D1D00)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005D1D30
    /// unsigned int __thiscall GeneratorQueueNode::Pack(GeneratorQueueNode*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, void**, uint, uint>)0x005D1D30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D1D60
    /// int __thiscall GeneratorQueueNode::UnPack(GeneratorQueueNode*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, void**, uint, int>)0x005D1D60)(ref this, addr, size);
}

