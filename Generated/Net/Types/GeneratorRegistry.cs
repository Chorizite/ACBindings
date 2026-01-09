namespace ACBindings;

// GeneratorRegistry
public unsafe struct GeneratorRegistry
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GeneratorRegistry_vtbl
    public unsafe struct GeneratorRegistry_vtbl
    {
        // Members
        public System.IntPtr GeneratorRegistry_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__uint__GeneratorRegistryNode _registry;

    // Generated Constructor
    public GeneratorRegistry() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __thiscall GeneratorRegistry::Pack(Body*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorRegistry, void**, uint, uint>)0x005CC060)(ref this, addr, size);
    // void __thiscall GeneratorRegistry::GeneratorRegistry(GeneratorRegistry*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GeneratorRegistry, void>)0x005D15D0)(ref this);
}

