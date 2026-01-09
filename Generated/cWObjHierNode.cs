namespace ACBindings;

// cWObjHierNode
public unsafe struct cWObjHierNode : System.IDisposable
{
    // Base Classes
    public ACBindings.AC1Legacy.SmartArray__cWObjHierNode_ptr BaseClass_AC1Legacy_SmartArray; // ACBindings.AC1Legacy.SmartArray__cWObjHierNode_ptr

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _menu_name;
    public ACBindings.IDClass___tagDataID _wcid;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall cWObjHierNode::~cWObjHierNode(cWObjHierNode*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierNode, void>)0x004FD220)(ref this);
    // unsigned int __thiscall cWObjHierNode::Pack(cWObjHierNode*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierNode, void**, uint, uint>)0x004FD3D0)(ref this, addr, size);
    // unsigned int __thiscall cWObjHierNode::pack_size(cWObjHierNode*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierNode, uint>)0x004FD590)(ref this);
    // int __thiscall cWObjHierNode::UnPack(cWObjHierNode*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.cWObjHierNode, void**, uint, int>)0x004FD600)(ref this, addr, size);
}

