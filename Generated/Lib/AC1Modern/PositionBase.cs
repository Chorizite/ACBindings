namespace ACBindings.Internal.AC1Modern;


/// <summary>Represents a position in the game world, storing 8‑bit block X/Y coordinates and a unique cell identifier for efficient spatial lookup.</summary>
public unsafe struct PositionBase
{
    // Child Types

    /// <summary>Defines the virtual function table for position‑based objects, offering access to spatial origin, orientation, validity status, string conversion, and file node serialization within AC1Modern's entity system.</summary>
    public unsafe struct PositionBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.Vector3*> GetOrigin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.Quaternion*> GetOrientation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, byte> IsValid; // function pointer
        public System.IntPtr ToString;
        public System.IntPtr ToStringW;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Modern.PositionBase*, ACBindings.Internal.PFileNode*, byte*, byte> HandleFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte m_iBlockX;
    public byte m_iBlockY;
    public ACBindings.Internal.IDClass____tagCellID m_cCellID;

    // Methods
}

