namespace ACBindings.Internal;

public unsafe struct GeneratorQueue
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorQueue_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, void> GeneratorQueue_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorQueue*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableList___GeneratorQueueNode _queue;

    // Generated Constructor
    public GeneratorQueue() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D1660
    /// int __thiscall GeneratorQueue::UnPack(GeneratorQueue*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueue, void**, uint, int>)0x005D1660)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D1870
    /// void __thiscall GeneratorQueue::GeneratorQueue(GeneratorQueue*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorQueue, void>)0x005D1870)(ref this);
}

