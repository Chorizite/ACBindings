namespace ACBindings.Internal;


/// <summary>
/// Represents a file node identifier stored as an unsigned 64‑bit integer.
/// Implements the IFileNodeName interface, supporting cloning, parsing from decimal text, and conversion back to string representation.
/// </summary>
public unsafe struct FileNodeName_UInt64
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ulong m_name;

    // Methods

    /// <summary>Returns the type identifier for a file node name represented as an unsigned 64-bit integer.
    /// <code>Offset: 0x0065B190
    /// NodeNameType __thiscall FileNodeName_UInt64::GetType(FileNodeName_UInt64*)</code>
    /// </summary>
    /// <returns>The NodeNameType value associated with this FileNodeName_UInt64 instance, which is always 11.</returns>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, ACBindings.Internal.NodeNameType>)0x0065B190)(ref this);

    /// <summary>Create a duplicate of the current FileNodeName_UInt64 instance.
    /// <code>Offset: 0x0065B1A0
    /// IFileNodeName* __thiscall FileNodeName_UInt64::Clone(FileNodeName_UInt64*)</code>
    /// </summary>
    /// <returns>A newly allocated IFileNodeName that contains a copy of this node's name, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, ACBindings.Internal.IFileNodeName*>)0x0065B1A0)(ref this);

    /// <summary>Parses a decimal string into an unsigned 64‑bit integer and stores the value in the FileNodeName_UInt64 object after incrementing the reference count of the supplied string pointer. Returns 1 on success or 0 if the input is invalid.
    /// <code>Offset: 0x0065BA30
    /// char __thiscall FileNodeName_UInt64::FromPString(_QWORD*,char**)</code>
    /// </summary>
    /// <param name="a2">Address of a null-terminated string containing the numeric value; the function increments its reference count before use.</param>
    /// <returns>1 if parsing succeeded; 0 otherwise.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, sbyte**, sbyte>)0x0065BA30)(ref this, a2);

    /// <summary>Converts the 64‑bit name stored in this object into its decimal string representation and writes it to the buffer supplied via the second argument.
    /// <code>Offset: 0x0065BFE0
    /// int* __thiscall FileNodeName_UInt64::ToPString(_QWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer that will receive the address of the newly allocated string containing the numeric name.</param>
    /// <returns>The same pointer passed as <paramref name="a2"/> after assignment; contains the resulting string.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt64, int*, int*>)0x0065BFE0)(ref this, a2);
}

