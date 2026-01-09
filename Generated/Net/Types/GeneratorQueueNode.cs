namespace ACBindings;

// GeneratorQueueNode
public unsafe struct GeneratorQueueNode
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GeneratorQueueNode_vtbl
    public unsafe struct GeneratorQueueNode_vtbl
    {
        // Members
        public System.IntPtr GeneratorQueueNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint slot;
    public double when;

    // Generated Constructor
    public GeneratorQueueNode() {
        _ConstructorInternal();
    }
    public GeneratorQueueNode(ACBindings.GeneratorQueueNode* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall GeneratorQueueNode::GeneratorQueueNode(GeneratorQueueNode*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorQueueNode, void>)0x005D1CE0)(ref this);
    // void __thiscall GeneratorQueueNode::GeneratorQueueNode(GeneratorQueueNode*,const GeneratorQueueNode*)
    public void _ConstructorInternal(ACBindings.GeneratorQueueNode* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorQueueNode, ACBindings.GeneratorQueueNode*, void>)0x005D1D00)(ref this, rhs);
    // unsigned int __thiscall GeneratorQueueNode::Pack(GeneratorQueueNode*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorQueueNode, void**, uint, uint>)0x005D1D30)(ref this, addr, size);
    // int __thiscall GeneratorQueueNode::UnPack(GeneratorQueueNode*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorQueueNode, void**, uint, int>)0x005D1D60)(ref this, addr, size);
}

