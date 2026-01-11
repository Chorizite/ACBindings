namespace ACBindings.Internal.AC1Modern;

public unsafe struct PositionBase
{
    // Child Types
    public unsafe struct PositionBase_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.Vector3*> GetOrigin; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.Quaternion*> GetOrientation; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, byte> IsValid; // function pointer
        public System.IntPtr ToString;
        public System.IntPtr ToStringW;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.PFileNode*, byte*, byte> HandleFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte m_iBlockX;
    public byte m_iBlockY;
    public ACBindings.Internal.IDClass____tagCellID m_cCellID;

    // Methods
}

