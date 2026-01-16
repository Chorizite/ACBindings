namespace ACBindings.Internal;


/// <summary>Stores generator nodes in a hash table, enabling efficient lookup and serialization of generator data.</summary>
/// <remarks>Inherits from PackObj and maintains an internal hash table mapping unsigned long keys to GeneratorRegistryNode objects.</remarks>
public unsafe struct GeneratorRegistry
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GeneratorRegistry_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, void> GeneratorRegistry_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GeneratorRegistry*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___GeneratorRegistryNode _registry;

    // Generated Constructor
    public GeneratorRegistry() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Computes the size required to serialize a body's part hash table and, when given a buffer large enough, writes the serialized data into it.
    /// <code>Offset: 0x005CC060
    /// unsigned int __thiscall GeneratorRegistry::Pack(Body*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory area where packed data will be written if the provided buffer is sufficient.</param>
    /// <param name="size">Size of the buffer pointed to by <c>addr</c>.</param>
    /// <returns>The total number of bytes needed to pack the body part hash table.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistry, void**, uint, uint>)0x005CC060)(ref this, addr, size);

    /// <summary>Initializes a new GeneratorRegistry instance, configuring its PackObj base class and preparing an empty packable hash table for generator nodes.
    /// <code>Offset: 0x005D15D0
    /// void __thiscall GeneratorRegistry::GeneratorRegistry(GeneratorRegistry*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GeneratorRegistry, void>)0x005D15D0)(ref this);
}

