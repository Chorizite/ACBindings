namespace ACBindings.Internal;


/// <summary>Provides a dynamic circular array for AsyncCache::CCallbackHandler pointers, enabling efficient storage and retrieval of callback handlers during asynchronous operations.</summary>
public unsafe struct TDynamicCircularArray___AsyncCache_CCallbackHandler_ptr
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.AsyncCache.CCallbackHandler** A;
    public uint first;
    public uint next;
    public uint count;
    public uint max;
    public uint growsize;

    // Methods
}

