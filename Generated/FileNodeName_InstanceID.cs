namespace ACBindings;

// FileNodeName_InstanceID
public unsafe struct FileNodeName_InstanceID
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public ACBindings.InstanceID m_name;

    // Methods
    // NodeNameType __thiscall FileNodeName_InstanceID::GetType(FileNodeName_InstanceID*)
    public ACBindings.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_InstanceID, ACBindings.NodeNameType>)0x0065B270)(ref this);
    // IFileNodeName* __thiscall FileNodeName_InstanceID::Clone(FileNodeName_InstanceID*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_InstanceID, ACBindings.IFileNodeName*>)0x0065B280)(ref this);
    // int* __thiscall FileNodeName_InstanceID::ToPString(_QWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_InstanceID, int*, int*>)0x0065C210)(ref this, a2);
}

