namespace ACBindings.Internal;

public unsafe struct SimplePolygon
{
    // Child Types
    public unsafe struct SimplePolygon_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SimplePolygon*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SimplePolygon*, ACBindings.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SimplePolygon*, ACBindings.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SimplePolygon*, ACBindings.Internal.SimplePolygonType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SimplePolygon*, byte> IsValid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SimplePolygon*, ACBindings.Internal.SimplePolygon*, ACBindings.Internal.Matrix4*, byte> Transform; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.SmartArray___Vector3 m_vertices;

    // Methods
}

