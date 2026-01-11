namespace ACBindings.Internal;

public unsafe struct COptionalHeaderFactory
{
    // Statics
    public static ACBindings.Internal.COptionalHeaderFactory.CPlugin* s_FactoryPlugins = (ACBindings.Internal.COptionalHeaderFactory.CPlugin*)0x008EEFD8;
    public static int* s_nPlugins = (int*)0x008EF0DC;

    // Child Types
    public unsafe struct CPlugin
    {
        // Members
        public uint dwMask;
        public delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*> pAllocator; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AB820
    /// void __cdecl COptionalHeaderFactory::RegisterOptionalHeaderType(unsigned int,COptionalHeader*(__cdecl*pAllocatorFunc)(CBufferIterator*))</code>
    /// </summary>
    public static void RegisterOptionalHeaderType(uint dwMask, delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*> pAllocatorFunc) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.Internal.CBufferIterator*, ACBindings.Internal.COptionalHeader*>, void>)0x005AB820)(dwMask, pAllocatorFunc);

    /// <summary>
    /// <code>Offset: 0x005AB8C0
    /// bool __cdecl COptionalHeaderFactory::AddOptionalHeadersToPacket(unsigned int,NetPacket*,CBufferIterator*)</code>
    /// </summary>
    public static byte AddOptionalHeadersToPacket(uint dwMask, ACBindings.Internal.NetPacket* pPacket, ACBindings.Internal.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.NetPacket*, ACBindings.Internal.CBufferIterator*, byte>)0x005AB8C0)(dwMask, pPacket, Buf);
}

