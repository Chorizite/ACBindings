namespace ACBindings;

// ID3DXBaseMesh
public unsafe struct ID3DXBaseMesh
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // ID3DXBaseMesh_vtbl
    public unsafe struct ID3DXBaseMesh_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DrawSubset; // function pointer
        public System.IntPtr GetNumFaces; // function pointer
        public System.IntPtr GetNumVertices; // function pointer
        public System.IntPtr GetFVF; // function pointer
        public System.IntPtr GetDeclaration; // function pointer
        public System.IntPtr GetNumBytesPerVertex; // function pointer
        public System.IntPtr GetOptions; // function pointer
        public System.IntPtr GetDevice; // function pointer
        public System.IntPtr CloneMeshFVF; // function pointer
        public System.IntPtr CloneMesh; // function pointer
        public System.IntPtr GetVertexBuffer; // function pointer
        public System.IntPtr GetIndexBuffer; // function pointer
        public System.IntPtr LockVertexBuffer; // function pointer
        public System.IntPtr UnlockVertexBuffer; // function pointer
        public System.IntPtr LockIndexBuffer; // function pointer
        public System.IntPtr UnlockIndexBuffer; // function pointer
        public System.IntPtr GetAttributeTable;
        public System.IntPtr ConvertPointRepsToAdjacency; // function pointer
        public System.IntPtr ConvertAdjacencyToPointReps; // function pointer
        public System.IntPtr GenerateAdjacency; // function pointer
        public System.IntPtr UpdateSemantics; // function pointer

        // Methods
    }

    // Methods
}

