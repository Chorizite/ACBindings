namespace ACBindings.Internal;


/// <summary>Hierarchical node used to represent an entry in the application’s object tree, holding a menu name, identifier, and child nodes.</summary>
public unsafe struct cWObjHierNode : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.SmartArray___cWObjHierNode_ptr BaseClass_AC1Legacy_SmartArray; // ACBindings.Internal.AC1Legacy.SmartArray___cWObjHierNode_ptr

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _menu_name;
    public ACBindings.Internal.IDClass____tagDataID _wcid;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Destroys a cWObjHierNode object, recursively deleting all child nodes, releasing any associated resources such as the menu name string buffer, and freeing allocated memory.
    /// 
    /// <code>Offset: 0x004FD220
    /// void __thiscall cWObjHierNode::~cWObjHierNode(cWObjHierNode*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, void>)0x004FD220)(ref this);

    /// <summary>Packs this node and all its descendants into a binary buffer, serializing the menu name, ID, child count, and recursively each child node.
    /// <code>Offset: 0x004FD3D0
    /// unsigned int __thiscall cWObjHierNode::Pack(cWObjHierNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; after packing, points just beyond the last byte written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>The total number of bytes that would be written (the packed size). If size is insufficient, no data is written but the required size is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, void**, uint, uint>)0x004FD3D0)(ref this, addr, size);

    /// <summary>Computes the byte size needed to pack this hierarchical object, including its name and all child nodes. The result is rounded up to a multiple of four for alignment.
    /// <code>Offset: 0x004FD590
    /// unsigned int __thiscall cWObjHierNode::pack_size(cWObjHierNode*)</code>
    /// </summary>
    /// <returns>The total number of bytes required to serialize the node and its descendants.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, uint>)0x004FD590)(ref this);

    /// <summary>Deserializes a cWObjHierNode from the supplied binary buffer, restoring its menu name, ID and child hierarchy while validating bounds and aligning to 4‑byte boundaries.
    /// <code>Offset: 0x004FD600
    /// int __thiscall cWObjHierNode::UnPack(cWObjHierNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; checked against required size for successful unpacking.</param>
    /// <returns>Non‑zero if unpacking succeeds; zero otherwise (insufficient data or alignment error).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, void**, uint, int>)0x004FD600)(ref this, addr, size);
}

