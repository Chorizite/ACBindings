namespace ACBindings.Internal;

public unsafe struct CVertexArray
{
    // Statics
    public static uint* vertex_size = (uint*)0x0081F710;

    // Members
    public System.IntPtr vertex_memory;
    public ACBindings.Internal.BBox bbox;
    public ACBindings.Internal.VertexType vertex_type;
    public uint num_vertices;
    public ACBindings.Internal.CVertex* vertices;

    // Generated Constructor
    public CVertexArray() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053CB90
    /// int __thiscall CVertexArray::AllocateVertex(CVertexArray*,unsigned int,VertexType)</code>
    /// </summary>
    public int AllocateVertex(uint size, ACBindings.Internal.VertexType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, uint, ACBindings.Internal.VertexType, int>)0x0053CB90)(ref this, size, type);

    /// <summary>
    /// <code>Offset: 0x0053CC10
    /// void __thiscall CVertexArray::DestroyVertex(CVertexArray*)</code>
    /// </summary>
    public void DestroyVertex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void>)0x0053CC10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CC70
    /// void __thiscall CVertexArray::BuildBoundingBox(CVertexArray*)</code>
    /// </summary>
    public void BuildBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void>)0x0053CC70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CCC0
    /// unsigned int __thiscall CVertexArray::pack_size(CVertexArray*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, uint>)0x0053CCC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CD10
    /// void __thiscall CVertexArray::CVertexArray(CVertexArray*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void>)0x0053CD10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CD20
    /// unsigned int __thiscall CVertexArray::Pack(CVertexArray*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void**, uint, uint>)0x0053CD20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053CD90
    /// int __thiscall CVertexArray::UnPack(CVertexArray*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CVertexArray, void**, uint, int>)0x0053CD90)(ref this, addr, size);
}

