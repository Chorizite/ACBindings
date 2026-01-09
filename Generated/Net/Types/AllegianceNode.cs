namespace ACBindings;

// AllegianceNode
public unsafe struct AllegianceNode
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AllegianceNode_vtbl
    public unsafe struct AllegianceNode_vtbl
    {
        // Members
        public System.IntPtr AllegianceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AllegianceNode* _patron;
    public ACBindings.AllegianceNode* _peer;
    public ACBindings.AllegianceNode* _vassal;
    public ACBindings.AllegianceData _data;

    // Generated Constructor
    public AllegianceNode(ACBindings.AllegianceData* data) {
        _ConstructorInternal(data);
    }

    // Methods
    // unsigned int __thiscall AllegianceNode::Pack(AllegianceNode*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceNode, void**, uint, uint>)0x005BA130)(ref this, addr, size);
    // int __thiscall AllegianceNode::UnPack(AllegianceNode*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceNode, void**, uint, int>)0x005BA140)(ref this, addr, size);
    // void __thiscall AllegianceNode::AllegianceNode(AllegianceNode*,const AllegianceData*)
    public void _ConstructorInternal(ACBindings.AllegianceData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceNode, ACBindings.AllegianceData*, void>)0x005BA150)(ref this, data);
}

