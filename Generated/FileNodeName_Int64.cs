namespace ACBindings.Internal;

public unsafe struct FileNodeName_Int64
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public long m_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065B1F0
    /// NodeNameType __thiscall FileNodeName_Int64::GetType(FileNodeName_Int64*)</code>
    /// </summary>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, ACBindings.Internal.NodeNameType>)0x0065B1F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B200
    /// IFileNodeName* __thiscall FileNodeName_Int64::Clone(FileNodeName_Int64*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, ACBindings.Internal.IFileNodeName*>)0x0065B200)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B700
    /// void __thiscall FileNodeName_Int64::Serialize(FileNodeName_InstanceID*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, ACBindings.Internal.Archive*, void>)0x0065B700)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0065BA90
    /// char __thiscall FileNodeName_Int64::FromPString(_QWORD*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, sbyte**, sbyte>)0x0065BA90)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065C050
    /// int* __thiscall FileNodeName_Int64::ToPString(_QWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, int*, int*>)0x0065C050)(ref this, a2);
}

