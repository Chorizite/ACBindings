namespace ACBindings.Internal;


/// <summary>
/// Manages optional header registrations and creation for network packets, allowing new header types to be added by mask and constructed from serialized buffers.
/// </summary>
public unsafe struct COptionalHeaderFactory
{
    // Statics
    public static ACBindings.Internal.COptionalHeaderFactory.CPlugin** s_FactoryPlugins = (ACBindings.Internal.COptionalHeaderFactory.CPlugin**)0x008EEFD8;
    public static int* s_nPlugins = (int*)0x008EF0DC;

    // Child Types

    /// <summary>Defines a plugin that creates optional headers from a buffer iterator, with a bitmask specifying supported header types.</summary>
    public unsafe struct CPlugin
    {
        // Members
        public uint dwMask;
        public static delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*> pAllocator; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Registers an optional header type with the specified mask and allocator, inserting it into the factory's internal registry.
    /// <code>Offset: 0x005AB820
    /// void __cdecl COptionalHeaderFactory::RegisterOptionalHeaderType(unsigned int,COptionalHeader*(__cdecl*pAllocatorFunc)(CBufferIterator*))</code>
    /// </summary>
    /// <param name="dwMask">Bitmask identifying the optional header type to register.</param>
    /// <param name="pAllocatorFunc">Pointer to a function that allocates a COptionalHeader instance from a buffer iterator.</param>
    public static void RegisterOptionalHeaderType(uint dwMask, delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*> pAllocatorFunc) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>, void>)0x005AB820)(dwMask, pAllocatorFunc);

    /// <summary>Adds optional headers to the given packet according to a bitmask, creating each header from serialized data and attaching it.
    /// <code>Offset: 0x005AB8C0
    /// bool __cdecl COptionalHeaderFactory::AddOptionalHeadersToPacket(unsigned int,NetPacket*,CBufferIterator*)</code>
    /// </summary>
    /// <param name="dwMask">Bitmask specifying which optional headers to add; each set bit corresponds to a supported plugin.</param>
    /// <param name="pPacket">The packet that will receive the new optional headers.</param>
    /// <param name="Buf">Iterator over the buffer containing serialized header data used for construction.</param>
    /// <returns>True if every requested header was created and added successfully and no unsupported mask bits remain; otherwise false.</returns>
    public static byte AddOptionalHeadersToPacket(uint dwMask, ACBindings.Internal.NetPacket* pPacket, ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.NetPacket*, ACBindings.Internal.CBufferIterator*, byte>)0x005AB8C0)(dwMask, pPacket, Buf);
}

