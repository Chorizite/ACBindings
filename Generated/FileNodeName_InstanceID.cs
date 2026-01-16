namespace ACBindings.Internal;


/// <summary>Encapsulates a unique instance identifier used as a file node name, providing cloning, type identification, and string conversion functionality.</summary>
public unsafe struct FileNodeName_InstanceID
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.InstanceID m_name;

    // Methods

    /// <summary>Retrieves the enumeration value representing the specific file node name type.
    /// <code>Offset: 0x0065B270
    /// NodeNameType __thiscall FileNodeName_InstanceID::GetType(FileNodeName_InstanceID*)</code>
    /// </summary>
    /// <returns>The NodeNameType value for this instance, which is 6 (InstanceID).</returns>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_InstanceID, ACBindings.Internal.NodeNameType>)0x0065B270)(ref this);

    /// <summary>Creates a duplicate of the current FileNodeName_InstanceID, allocating a new IFileNodeName object and copying its InstanceID data into the clone.
    /// <code>Offset: 0x0065B280
    /// IFileNodeName* __thiscall FileNodeName_InstanceID::Clone(FileNodeName_InstanceID*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated cloned object; returns nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_InstanceID, ACBindings.Internal.IFileNodeName*>)0x0065B280)(ref this);

    /// <summary>Creates a PString holding the hexadecimal representation of this FileNodeName_InstanceID's m_name field prefixed with “0x” and stores its address in the supplied output pointer.
    /// <code>Offset: 0x0065C210
    /// int* __thiscall FileNodeName_InstanceID::ToPString(_QWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Receives the address of the newly allocated string that contains the formatted hex value.</param>
    /// <returns>The same pointer stored in a2, pointing to the created PString object.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_InstanceID, int*, int*>)0x0065C210)(ref this, a2);
}

