namespace ACBindings;

// FileNodeName_CellID
public unsafe struct FileNodeName_CellID
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public ACBindings.IDClass___tagCellID m_name;

    // Methods
    // NodeNameType __thiscall FileNodeName_CellID::GetType(FileNodeName_CellID*)
    public ACBindings.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_CellID, ACBindings.NodeNameType>)0x0065B230)(ref this);
    // IFileNodeName* __thiscall FileNodeName_CellID::Clone(FileNodeName_CellID*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_CellID, ACBindings.IFileNodeName*>)0x0065B240)(ref this);
    // void __thiscall FileNodeName_CellID::Serialize(FileNodeName_CellID*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_CellID, ACBindings.Archive*, void>)0x0065B6C0)(ref this, io_archive);
    // char __thiscall FileNodeName_CellID::FromPString(char*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_CellID, sbyte**, sbyte>)0x0065BBB0)(ref this, a2);
    // int* __thiscall FileNodeName_CellID::ToPString(unsigned __int16*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_CellID, int*, int*>)0x0065C1A0)(ref this, a2);
}

