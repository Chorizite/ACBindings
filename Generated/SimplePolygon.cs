namespace ACBindings;

// SimplePolygon
public unsafe struct SimplePolygon
{
    // Child Types
    // SimplePolygon_vtbl
    public unsafe struct SimplePolygon_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr FromFileNode; // function pointer
        public System.IntPtr ToFileNode; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Transform; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.SmartArray__Vector3 m_vertices;

    // Methods
}

