namespace ACBindings.AC1Modern;

// AC1Modern::PositionBase
public unsafe struct PositionBase
{
    // Child Types
    // AC1Modern::PositionBase_vtbl
    public unsafe struct PositionBase_vtbl
    {
        // Members
        public System.IntPtr GetOrigin; // function pointer
        public System.IntPtr GetOrientation; // function pointer
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr ToString;
        public System.IntPtr ToStringW;
        public System.IntPtr ToFileNode; // function pointer
        public System.IntPtr HandleFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte m_iBlockX;
    public byte m_iBlockY;
    public ACBindings.IDClass___tagCellID m_cCellID;

    // Methods
}

