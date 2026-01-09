namespace ACBindings;

// FileNodeName_UInt32
public unsafe struct FileNodeName_UInt32
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public uint m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_UInt32::Clone(FileNodeName_UInt32*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt32, ACBindings.IFileNodeName*>)0x00425D80)(ref this);
    // char __thiscall FileNodeName_UInt32::FromPString(char*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt32, sbyte**, sbyte>)0x0065B970)(ref this, a2);
    // int* __thiscall FileNodeName_UInt32::ToPString(_DWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_UInt32, int*, int*>)0x0065BF00)(ref this, a2);
}

