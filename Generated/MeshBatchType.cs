namespace ACBindings.Internal;


/// <summary>Specifies the range of triangles and vertices used by a single draw call, tracking the first triangle index, the number of triangles in the batch, the current processing triangle index, and the start and end vertex indices.</summary>
public unsafe struct MeshBatchType
{
    // Members
    public uint m_FirstTriangleIndex;
    public uint m_NumTriangles;
    public uint m_CurTriangleIndex;
    public uint m_FirstVertexIndex;
    public uint m_LastVertexIndex;

    // Methods
}

