namespace ACBindings.Internal;

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
    /// <code>Offset: 0x004FD220
    /// void __thiscall cWObjHierNode::~cWObjHierNode(cWObjHierNode*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, void>)0x004FD220)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD3D0
    /// unsigned int __thiscall cWObjHierNode::Pack(cWObjHierNode*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, void**, uint, uint>)0x004FD3D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FD590
    /// unsigned int __thiscall cWObjHierNode::pack_size(cWObjHierNode*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, uint>)0x004FD590)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FD600
    /// int __thiscall cWObjHierNode::UnPack(cWObjHierNode*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.cWObjHierNode, void**, uint, int>)0x004FD600)(ref this, addr, size);
}

