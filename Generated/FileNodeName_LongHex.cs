namespace ACBindings;

// FileNodeName_LongHex
public unsafe struct FileNodeName_LongHex
{
    // Base Classes
    public ACBindings.FileNodeName_UInt64 BaseClass_FileNodeName_UInt64; // ACBindings.FileNodeName_UInt64

    // Methods
    // NodeNameType __thiscall FileNodeName_LongHex::GetType(FileNodeName_LongHex*)
    public ACBindings.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_LongHex, ACBindings.NodeNameType>)0x0065B300)(ref this);
    // IFileNodeName* __thiscall FileNodeName_LongHex::Clone(FileNodeName_LongHex*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_LongHex, ACBindings.IFileNodeName*>)0x0065B310)(ref this);
    // int* __thiscall FileNodeName_LongHex::ToPString(_DWORD*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_LongHex, int*, int*>)0x0065C2F0)(ref this, a2);
}

