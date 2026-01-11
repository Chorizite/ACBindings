namespace ACBindings.Internal;

public unsafe struct GeneratorRegistry
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorRegistry_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, void> GeneratorRegistry_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___GeneratorRegistryNode _registry;

    // Generated Constructor
    public GeneratorRegistry() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CC060
    /// unsigned int __thiscall GeneratorRegistry::Pack(Body*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistry, void**, uint, uint>)0x005CC060)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D15D0
    /// void __thiscall GeneratorRegistry::GeneratorRegistry(GeneratorRegistry*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistry, void>)0x005D15D0)(ref this);
}

