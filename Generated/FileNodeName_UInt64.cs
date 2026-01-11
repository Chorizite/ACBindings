namespace ACBindings.Internal;

public unsafe struct FileNodeName_UInt64
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ulong m_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065B190
    /// NodeNameType __thiscall FileNodeName_UInt64::GetType(FileNodeName_UInt64*)</code>
    /// </summary>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, ACBindings.Internal.NodeNameType>)0x0065B190)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B1A0
    /// IFileNodeName* __thiscall FileNodeName_UInt64::Clone(FileNodeName_UInt64*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, ACBindings.Internal.IFileNodeName*>)0x0065B1A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065BA30
    /// char __thiscall FileNodeName_UInt64::FromPString(_QWORD*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, sbyte**, sbyte>)0x0065BA30)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065BFE0
    /// int* __thiscall FileNodeName_UInt64::ToPString(_QWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, int*, int*>)0x0065BFE0)(ref this, a2);
}

