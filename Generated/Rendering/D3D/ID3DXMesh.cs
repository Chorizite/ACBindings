namespace ACBindings.Internal;

public unsafe struct ID3DXMesh
{
    // Base Classes
    public ACBindings.Internal.ID3DXBaseMesh BaseClass_ID3DXBaseMesh; // ACBindings.Internal.ID3DXBaseMesh

    // Child Types
    public unsafe struct ID3DXMesh_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint, int> DrawSubset; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint> GetNumFaces; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint> GetNumVertices; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint> GetFVF; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, System.IntPtr, int> GetDeclaration; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint> GetNumBytesPerVertex; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint> GetOptions; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, System.IntPtr, int> GetDevice; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint, uint, System.IntPtr, ACBindings.Internal.ID3DXMesh**, int> CloneMeshFVF; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint, System.IntPtr, System.IntPtr, ACBindings.Internal.ID3DXMesh**, int> CloneMesh; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, System.IntPtr, int> GetVertexBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, System.IntPtr, int> GetIndexBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint, void**, int> LockVertexBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, int> UnlockVertexBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint, void**, int> LockIndexBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, int> UnlockIndexBuffer; // function pointer
        public System.IntPtr GetAttributeTable;
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint*, uint*, int> ConvertPointRepsToAdjacency; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, uint*, uint*, int> ConvertAdjacencyToPointReps; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, float, uint*, int> GenerateAdjacency; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXBaseMesh*, System.IntPtr, int> UpdateSemantics; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXMesh*, uint, uint**, int> LockAttributeBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXMesh*, int> UnlockAttributeBuffer; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXMesh*, uint, uint*, uint*, uint*, ACBindings.Internal.ID3DXBuffer**, ACBindings.Internal.ID3DXMesh**, int> Optimize; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.ID3DXMesh*, uint, uint*, uint*, uint*, ACBindings.Internal.ID3DXBuffer**, int> OptimizeInplace; // function pointer
        public System.IntPtr SetAttributeTable;

        // Methods
    }

    // Methods
}

