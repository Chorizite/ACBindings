namespace ACBindings.Internal;

public unsafe struct FileNodeName_Hex
{
    // Base Classes
    public ACBindings.Internal.FileNodeName_UInt32 BaseClass_FileNodeName_UInt32; // ACBindings.Internal.FileNodeName_UInt32

    // Methods

    /// <summary>Creates a duplicate of the current FileNodeName_Hex instance as an IFileNodeName object.
    /// <code>Offset: 0x00425D50
    /// IFileNodeName* __thiscall FileNodeName_Hex::Clone(FileNodeName_Hex*)</code>
    /// </summary>
    /// <returns>A newly allocated IFileNodeName containing a copy of this hex node name, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Hex, ACBindings.Internal.IFileNodeName*>)0x00425D50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065C280
    /// int* __thiscall FileNodeName_Hex::ToPString(_DWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Hex, int*, int*>)0x0065C280)(ref this, a2);
}

