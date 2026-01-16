namespace ACBindings.Internal;


/// <summary>Handles a queue of generator nodes with packing and unpacking capabilities, enabling serialization of the node list for storage or transmission.</summary>
public unsafe struct GeneratorQueue
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorQueue_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, void> GeneratorQueue_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableList___GeneratorQueueNode _queue;

    // Generated Constructor
    public GeneratorQueue() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Deserializes a generator queue into the supplied buffer after verifying sufficient capacity.
    /// <code>Offset: 0x005D1660
    /// int __thiscall GeneratorQueue::UnPack(GeneratorQueue*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where unpacked data will be written.</param>
    /// <param name="size">Size of the destination buffer in bytes.</param>
    /// <returns>Non‑zero if deserialization succeeded; zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueue, void**, uint, int>)0x005D1660)(ref this, addr, size);

    /// <summary>Initializes a new GeneratorQueue instance by setting up virtual table pointers and clearing the internal queue.
    /// <code>Offset: 0x005D1870
    /// void __thiscall GeneratorQueue::GeneratorQueue(GeneratorQueue*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueue, void>)0x005D1870)(ref this);
}

