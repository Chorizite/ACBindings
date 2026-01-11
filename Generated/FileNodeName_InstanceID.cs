namespace ACBindings.Internal;

public unsafe struct FileNodeName_InstanceID
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.InstanceID m_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065B270
    /// NodeNameType __thiscall FileNodeName_InstanceID::GetType(FileNodeName_InstanceID*)</code>
    /// </summary>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_InstanceID, ACBindings.Internal.NodeNameType>)0x0065B270)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B280
    /// IFileNodeName* __thiscall FileNodeName_InstanceID::Clone(FileNodeName_InstanceID*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_InstanceID, ACBindings.Internal.IFileNodeName*>)0x0065B280)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065C210
    /// int* __thiscall FileNodeName_InstanceID::ToPString(_QWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_InstanceID, int*, int*>)0x0065C210)(ref this, a2);
}

