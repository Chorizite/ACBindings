namespace ACBindings.Internal;

public unsafe struct EventFilter
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct EventFilter_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, void> EventFilter_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint num_events;
    public uint* event_filter;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006B2C60
    /// unsigned int __thiscall EventFilter::Pack(EventFilter*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EventFilter, void**, uint, uint>)0x006B2C60)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B2CB0
    /// int __thiscall EventFilter::UnPack(EventFilter*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EventFilter, void**, uint, int>)0x006B2CB0)(ref this, addr, size);
}

