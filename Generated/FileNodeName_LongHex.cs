namespace ACBindings.Internal;


/// <summary>Represents a file node name stored as an unsigned 64‑bit integer and presented in long hexadecimal form, identified by the type code 13.</summary>
/// <remarks>The hex string is produced with the format “0x%16x”, yielding a 16‑character field padded with spaces; leading zeros are not guaranteed.</remarks>
public unsafe struct FileNodeName_LongHex
{
    // Base Classes
    public ACBindings.Internal.FileNodeName_UInt64 BaseClass_FileNodeName_UInt64; // ACBindings.Internal.FileNodeName_UInt64

    // Methods

    /// <summary>Gets the type identifier for a long‑hexadecimal file node name.
    /// <code>Offset: 0x0065B300
    /// NodeNameType __thiscall FileNodeName_LongHex::GetType(FileNodeName_LongHex*)</code>
    /// </summary>
    /// <returns>The constant value 13, indicating the FileNodeName_LongHex type.</returns>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_LongHex, ACBindings.Internal.NodeNameType>)0x0065B300)(ref this);

    /// <summary>Create a deep copy of the current FileNodeName_LongHex instance by allocating new memory and duplicating its internal data.
    /// <code>Offset: 0x0065B310
    /// IFileNodeName* __thiscall FileNodeName_LongHex::Clone(FileNodeName_LongHex*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed IFileNodeName object that represents the clone, or nullptr if the allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_LongHex, ACBindings.Internal.IFileNodeName*>)0x0065B310)(ref this);

    /// <summary>Creates a null‑terminated string representing the lower 32 bits of this object's name as an unsigned hexadecimal value prefixed with “0x” and stores it in the buffer supplied via a2.
    /// <code>Offset: 0x0065C2F0
    /// int* __thiscall FileNodeName_LongHex::ToPString(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the newly allocated character buffer containing the formatted hex string.</param>
    /// <returns>The same pointer passed in as a2, pointing to the created string.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_LongHex, int*, int*>)0x0065C2F0)(ref this, a2);
}

