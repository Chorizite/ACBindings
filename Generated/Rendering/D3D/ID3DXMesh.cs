namespace ACBindings;

// ID3DXMesh
public unsafe struct ID3DXMesh
{
    // Base Classes
    public ACBindings.ID3DXBaseMesh BaseClass_ID3DXBaseMesh; // ACBindings.ID3DXBaseMesh

    // Child Types
    // ID3DXMesh_vtbl
    public unsafe struct ID3DXMesh_vtbl
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
        public System.IntPtr LockAttributeBuffer; // function pointer
        public System.IntPtr UnlockAttributeBuffer; // function pointer
        public System.IntPtr Optimize; // function pointer
        public System.IntPtr OptimizeInplace; // function pointer
        public System.IntPtr SetAttributeTable;

        // Methods
    }

    // Methods
}

