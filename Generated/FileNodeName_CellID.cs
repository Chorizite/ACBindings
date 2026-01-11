namespace ACBindings.Internal;

public unsafe struct FileNodeName_CellID
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.IDClass____tagCellID m_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065B230
    /// NodeNameType __thiscall FileNodeName_CellID::GetType(FileNodeName_CellID*)</code>
    /// </summary>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, ACBindings.Internal.NodeNameType>)0x0065B230)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B240
    /// IFileNodeName* __thiscall FileNodeName_CellID::Clone(FileNodeName_CellID*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, ACBindings.Internal.IFileNodeName*>)0x0065B240)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B6C0
    /// void __thiscall FileNodeName_CellID::Serialize(FileNodeName_CellID*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, ACBindings.Internal.Archive*, void>)0x0065B6C0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0065BBB0
    /// char __thiscall FileNodeName_CellID::FromPString(char*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, sbyte**, sbyte>)0x0065BBB0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065C1A0
    /// int* __thiscall FileNodeName_CellID::ToPString(unsigned __int16*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, int*, int*>)0x0065C1A0)(ref this, a2);
}

