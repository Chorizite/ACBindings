namespace ACBindings;

// FileNodeName_Int64
public unsafe struct FileNodeName_Int64
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public long m_name;

    // Methods
    // NodeNameType __thiscall FileNodeName_Int64::GetType(FileNodeName_Int64*)
    public ACBindings.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int64, ACBindings.NodeNameType>)0x0065B1F0)(ref this);
    // IFileNodeName* __thiscall FileNodeName_Int64::Clone(FileNodeName_Int64*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int64, ACBindings.IFileNodeName*>)0x0065B200)(ref this);
    // void __thiscall FileNodeName_Int64::Serialize(FileNodeName_InstanceID*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int64, ACBindings.Archive*, void>)0x0065B700)(ref this, io_archive);
    // char __thiscall FileNodeName_Int64::FromPString(_QWORD*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int64, sbyte**, sbyte>)0x0065BA90)(ref this, a2);
    // int* __thiscall FileNodeName_Int64::ToPString(_QWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int64, int*, int*>)0x0065C050)(ref this, a2);
}

