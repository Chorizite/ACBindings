namespace ACBindings;

// FileNodeName_Hex
public unsafe struct FileNodeName_Hex
{
    // Base Classes
    public ACBindings.FileNodeName_UInt32 BaseClass_FileNodeName_UInt32; // ACBindings.FileNodeName_UInt32

    // Methods
    // IFileNodeName* __thiscall FileNodeName_Hex::Clone(FileNodeName_Hex*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Hex, ACBindings.IFileNodeName*>)0x00425D50)(ref this);
    // int* __thiscall FileNodeName_Hex::ToPString(_DWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Hex, int*, int*>)0x0065C280)(ref this, a2);
}

