namespace ACBindings;

// FileNodeName_Int32
public unsafe struct FileNodeName_Int32
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public int m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_Int32::Clone(FileNodeName_Int32*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int32, ACBindings.IFileNodeName*>)0x00425E30)(ref this);
    // void __thiscall FileNodeName_Int32::Serialize(FileNodeName_Int32*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int32, ACBindings.Archive*, void>)0x00425E80)(ref this, io_archive);
    // char __thiscall FileNodeName_Int32::FromPString(char*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int32, sbyte**, sbyte>)0x0065B9D0)(ref this, a2);
    // int* __thiscall FileNodeName_Int32::ToPString(_DWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Int32, int*, int*>)0x0065BF70)(ref this, a2);
}

