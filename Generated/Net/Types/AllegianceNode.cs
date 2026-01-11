namespace ACBindings.Internal;

public unsafe struct AllegianceNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceNode_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, void> AllegianceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AllegianceNode* _patron;
    public ACBindings.Internal.AllegianceNode* _peer;
    public ACBindings.Internal.AllegianceNode* _vassal;
    public ACBindings.Internal.AllegianceData _data;

    // Generated Constructor
    public AllegianceNode(ACBindings.Internal.AllegianceData* data) {
        _ConstructorInternal(data);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BA130
    /// unsigned int __thiscall AllegianceNode::Pack(AllegianceNode*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceNode, void**, uint, uint>)0x005BA130)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BA140
    /// int __thiscall AllegianceNode::UnPack(AllegianceNode*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceNode, void**, uint, int>)0x005BA140)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BA150
    /// void __thiscall AllegianceNode::AllegianceNode(AllegianceNode*,const AllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.AllegianceData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceNode, ACBindings.Internal.AllegianceData*, void>)0x005BA150)(ref this, data);
}

