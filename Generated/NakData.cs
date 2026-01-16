namespace ACBindings.Internal;


/// <summary>
/// Represents a packet containing negative acknowledgment information used by the communication subsystem. Stores up to 116 NAK identifiers, along with metadata such as data length and header flags.
/// </summary>
public unsafe struct NakData
{
    // Child Types
    public unsafe struct NakData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NakData*, void> NakData_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public fixed uint naks_[116];
    public int datalength_;
    public uint header_;

    // Methods
}

