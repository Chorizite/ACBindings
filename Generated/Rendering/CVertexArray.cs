namespace ACBindings;

// CVertexArray
public unsafe struct CVertexArray
{
    // Statics
    public static uint* vertex_size = (uint*)0x0081F710;

    // Members
    public System.IntPtr vertex_memory;
    public ACBindings.BBox bbox;
    public ACBindings.VertexType vertex_type;
    public uint num_vertices;
    public ACBindings.CVertex* vertices;

    // Generated Constructor
    public CVertexArray() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CVertexArray::AllocateVertex(CVertexArray*,unsigned int,VertexType)
    public int AllocateVertex(uint size, ACBindings.VertexType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, uint, ACBindings.VertexType, int>)0x0053CB90)(ref this, size, type);
    // void __thiscall CVertexArray::DestroyVertex(CVertexArray*)
    public void DestroyVertex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, void>)0x0053CC10)(ref this);
    // void __thiscall CVertexArray::BuildBoundingBox(CVertexArray*)
    public void BuildBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, void>)0x0053CC70)(ref this);
    // unsigned int __thiscall CVertexArray::pack_size(CVertexArray*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, uint>)0x0053CCC0)(ref this);
    // void __thiscall CVertexArray::CVertexArray(CVertexArray*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, void>)0x0053CD10)(ref this);
    // unsigned int __thiscall CVertexArray::Pack(CVertexArray*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, void**, uint, uint>)0x0053CD20)(ref this, addr, size);
    // int __thiscall CVertexArray::UnPack(CVertexArray*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CVertexArray, void**, uint, int>)0x0053CD90)(ref this, addr, size);
}

