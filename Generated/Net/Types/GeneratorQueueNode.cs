namespace ACBindings.Internal;


/// <summary>Represents a scheduled generator event, holding the target slot index and the exact time at which it should fire.</summary>
/// <remarks>Provides binary pack and unpack capabilities so that queued events can be efficiently serialized to or deserialized from a memory buffer.</remarks>
public unsafe struct GeneratorQueueNode
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorQueueNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, void> GeneratorQueueNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueueNode*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Constructs a GeneratorQueueNode instance, initializing its virtual table pointer and setting default values for slot and when.
    /// <code>Offset: 0x005D1CE0
    /// void __thiscall GeneratorQueueNode::GeneratorQueueNode(GeneratorQueueNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, void>)0x005D1CE0)(ref this);

    /// <summary>Initializes a new generator queue node by copying the slot index and scheduled time from an existing node while setting up its virtual table.
    /// <code>Offset: 0x005D1D00
    /// void __thiscall GeneratorQueueNode::GeneratorQueueNode(GeneratorQueueNode*,const GeneratorQueueNode*)</code>
    /// </summary>
    /// <param name="rhs">The source node whose data is copied into the newly constructed instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.GeneratorQueueNode* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, ACBindings.Internal.GeneratorQueueNode*, void>)0x005D1D00)(ref this, rhs);

    /// <summary>Packs the GeneratorQueueNode’s slot and timestamp into a binary buffer.
    /// <code>Offset: 0x005D1D30
    /// unsigned int __thiscall GeneratorQueueNode::Pack(GeneratorQueueNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the output buffer; updated to point after the written data.</param>
    /// <param name="size">Minimum size of the buffer in bytes required for packing.</param>
    /// <returns>Number of bytes written (12).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, void**, uint, uint>)0x005D1D30)(ref this, addr, size);

    /// <summary>Unpacks a GeneratorQueueNode from a binary buffer. Reads an unsigned int slot and a long double timestamp, advances the buffer pointer, and returns a success flag.
    /// <code>Offset: 0x005D1D60
    /// int __thiscall GeneratorQueueNode::UnPack(GeneratorQueueNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the source buffer; will be updated to point past the unpacked data.</param>
    /// <param name="size">Number of bytes remaining in the buffer. Must be at least 12 for a valid node.</param>
    /// <returns>1 if unpacking succeeded, 0 otherwise (e.g., insufficient data).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueueNode, void**, uint, int>)0x005D1D60)(ref this, addr, size);
}

