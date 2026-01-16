namespace ACBindings.Internal;


/// <summary>Represents a node in an allegiance hierarchy, linking to patron, peer, and vassal relationships while storing allegiance data.</summary>
public unsafe struct AllegianceNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, void> AllegianceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceNode*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Packages the AllegianceNode’s data into a memory buffer using its base class pack routine.
    /// <code>Offset: 0x005BA130
    /// unsigned int __thiscall AllegianceNode::Pack(AllegianceNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where packed data will be written.</param>
    /// <param name="size">Maximum number of bytes that can be written to the buffer.</param>
    /// <returns>The number of bytes actually written during packing.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceNode, void**, uint, uint>)0x005BA130)(ref this, addr, size);

    /// <summary>Deserializes this AllegianceNode’s data from a binary buffer by delegating to its base PackObj implementation.
    /// <code>Offset: 0x005BA140
    /// int __thiscall AllegianceNode::UnPack(AllegianceNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer containing serialized data.</param>
    /// <param name="size">Size of the buffer in bytes.</param>
    /// <returns>Result code returned by the underlying PackObj::UnPack method, typically 0 on success.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceNode, void**, uint, int>)0x005BA140)(ref this, addr, size);

    /// <summary>Constructs an AllegianceNode using supplied AllegianceData and initializes relation pointers to null.
    /// <code>Offset: 0x005BA150
    /// void __thiscall AllegianceNode::AllegianceNode(AllegianceNode*,const AllegianceData*)</code>
    /// </summary>
    /// <param name="data">The AllegianceData containing identity, name and other attributes for the new node.</param>
    public void _ConstructorInternal(ACBindings.Internal.AllegianceData* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceNode, ACBindings.Internal.AllegianceData*, void>)0x005BA150)(ref this, data);
}

