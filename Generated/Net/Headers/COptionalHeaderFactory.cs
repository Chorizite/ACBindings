namespace ACBindings;

// COptionalHeaderFactory
public unsafe struct COptionalHeaderFactory
{
    // Statics
    public static ACBindings.COptionalHeaderFactory.CPlugin* s_FactoryPlugins = (ACBindings.COptionalHeaderFactory.CPlugin*)0x008EEFD8;
    public static int* s_nPlugins = (int*)0x008EF0DC;

    // Child Types
    // COptionalHeaderFactory::CPlugin
    public unsafe struct CPlugin
    {
        // Members
        public uint dwMask;
        public System.IntPtr pAllocator; // function pointer

        // Methods
    }

    // Methods
    // void __cdecl COptionalHeaderFactory::RegisterOptionalHeaderType(unsigned int,COptionalHeader*(__cdecl*pAllocatorFunc)(CBufferIterator*))
    public static void RegisterOptionalHeaderType(uint dwMask, delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*> pAllocatorFunc) => ((delegate* unmanaged[Cdecl]<uint, delegate* unmanaged[Cdecl]<ACBindings.CBufferIterator*, ACBindings.COptionalHeader*>, void>)0x005AB820)(dwMask, pAllocatorFunc);
    // bool __cdecl COptionalHeaderFactory::AddOptionalHeadersToPacket(unsigned int,NetPacket*,CBufferIterator*)
    public static byte AddOptionalHeadersToPacket(uint dwMask, ACBindings.NetPacket* pPacket, ACBindings.CBufferIterator* Buf) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.NetPacket*, ACBindings.CBufferIterator*, byte>)0x005AB8C0)(dwMask, pPacket, Buf);
}

