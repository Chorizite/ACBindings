namespace ACBindings.Internal;

public unsafe struct NakData
{
    // Child Types
    public unsafe struct NakData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NakData*, void> NakData_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed uint naks_[116];
    public int datalength_;
    public uint header_;

    // Methods
}

