namespace ACBindings;

// EventFilter
public unsafe struct EventFilter
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // EventFilter_vtbl
    public unsafe struct EventFilter_vtbl
    {
        // Members
        public System.IntPtr EventFilter_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint num_events;
    public uint* event_filter;

    // Methods
    // unsigned int __thiscall EventFilter::Pack(EventFilter*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EventFilter, void**, uint, uint>)0x006B2C60)(ref this, addr, size);
    // int __thiscall EventFilter::UnPack(EventFilter*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EventFilter, void**, uint, int>)0x006B2CB0)(ref this, addr, size);
}

