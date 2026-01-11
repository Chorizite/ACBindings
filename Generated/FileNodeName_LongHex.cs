namespace ACBindings.Internal;

public unsafe struct FileNodeName_LongHex
{
    // Base Classes
    public ACBindings.Internal.FileNodeName_UInt64 BaseClass_FileNodeName_UInt64; // ACBindings.Internal.FileNodeName_UInt64

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065B300
    /// NodeNameType __thiscall FileNodeName_LongHex::GetType(FileNodeName_LongHex*)</code>
    /// </summary>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_LongHex, ACBindings.Internal.NodeNameType>)0x0065B300)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B310
    /// IFileNodeName* __thiscall FileNodeName_LongHex::Clone(FileNodeName_LongHex*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_LongHex, ACBindings.Internal.IFileNodeName*>)0x0065B310)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065C2F0
    /// int* __thiscall FileNodeName_LongHex::ToPString(_DWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_LongHex, int*, int*>)0x0065C2F0)(ref this, a2);
}

