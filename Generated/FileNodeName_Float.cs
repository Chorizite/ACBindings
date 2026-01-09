namespace ACBindings;

// FileNodeName_Float
public unsafe struct FileNodeName_Float
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public float m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_Float::Clone(FileNodeName_Float*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Float, ACBindings.IFileNodeName*>)0x00425CA0)(ref this);
    // char __thiscall FileNodeName_Float::FromPString(float*,char**)
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Float, sbyte**, sbyte>)0x0065BB50)(ref this, a2);
    // int* __thiscall FileNodeName_Float::ToPString(float*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Float, int*, int*>)0x0065C130)(ref this, a2);
}

