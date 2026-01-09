namespace ACBindings;

// GeneratorQueue
public unsafe struct GeneratorQueue
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GeneratorQueue_vtbl
    public unsafe struct GeneratorQueue_vtbl
    {
        // Members
        public System.IntPtr GeneratorQueue_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableList__GeneratorQueueNode _queue;

    // Generated Constructor
    public GeneratorQueue() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall GeneratorQueue::UnPack(GeneratorQueue*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorQueue, void**, uint, int>)0x005D1660)(ref this, addr, size);
    // void __thiscall GeneratorQueue::GeneratorQueue(GeneratorQueue*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorQueue, void>)0x005D1870)(ref this);
}

