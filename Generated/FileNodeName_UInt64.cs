namespace ACBindings;

// FileNodeName_UInt64
public unsafe struct FileNodeName_UInt64
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public ulong m_name;

    // Methods
    // NodeNameType __thiscall FileNodeName_UInt64::GetType(FileNodeName_UInt64*)
    public ACBindings.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt64, ACBindings.NodeNameType>)0x0065B190)(ref this);
    // IFileNodeName* __thiscall FileNodeName_UInt64::Clone(FileNodeName_UInt64*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt64, ACBindings.IFileNodeName*>)0x0065B1A0)(ref this);
    // char __thiscall FileNodeName_UInt64::FromPString(_QWORD*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt64, sbyte**, sbyte>)0x0065BA30)(ref this, a2);
    // int* __thiscall FileNodeName_UInt64::ToPString(_QWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt64, int*, int*>)0x0065BFE0)(ref this, a2);
}

