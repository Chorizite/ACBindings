namespace ACBindings.Internal;


/// <summary>Represents a file node name that stores an unsigned 32‑bit integer, providing IFileNodeName interface implementations for cloning, string parsing, and formatted output.</summary>
public unsafe struct FileNodeName_UInt32
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public uint m_name;

    // Methods

    /// <summary>Creates a duplicate of the current FileNodeName_UInt32 as an IFileNodeName instance.
    /// <code>Offset: 0x00425D80
    /// IFileNodeName* __thiscall FileNodeName_UInt32::Clone(FileNodeName_UInt32*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated clone, or null if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt32, ACBindings.Internal.IFileNodeName*>)0x00425D80)(ref this);

    /// <summary>Parses an unsigned 32‑bit value from the provided reference-counted string and stores it in the FileNodeName_UInt32 instance.
    /// <code>Offset: 0x0065B970
    /// char __thiscall FileNodeName_UInt32::FromPString(char*,char**)</code>
    /// </summary>
    /// <param name="String">Pointer to the FileNodeName_UInt32 structure where the parsed value is written.</param>
    /// <param name="a2">Reference to a pointer of a reference-counted C-string containing the numeric representation; its reference count is incremented before parsing.</param>
    /// <returns>Non‑zero if the string represents a valid unsigned 32‑bit integer; otherwise zero, leaving the instance unchanged.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt32, sbyte**, sbyte>)0x0065B970)(ref this, a2);

    /// <summary>Converts the node's unsigned integer name into its decimal representation and places it in a newly allocated string buffer.
    /// <code>Offset: 0x0065BF00
    /// int* __thiscall FileNodeName_UInt32::ToPString(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an int where the address of the created string buffer will be stored.</param>
    /// <returns>The same pointer supplied via a2, now pointing to the formatted number string.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt32, int*, int*>)0x0065BF00)(ref this, a2);
}

