namespace ACBindings.Internal;


/// <summary>Represents a binary‑encoded file node name stored in a smart buffer, providing cloning and serialization capabilities.</summary>
/// <remarks>Implements IFileNodeName, enabling conversion to/from wrapped strings while managing reference counts for the underlying data.</remarks>
public unsafe struct FileNodeName_Binary
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.SmartBuffer m_name;

    // Methods

    /// <summary>Creates a copy of this FileNodeName_Binary object and returns it as an IFileNodeName instance.
    /// <code>Offset: 0x00444820
    /// IFileNodeName* __thiscall FileNodeName_Binary::Clone(FileNodeName_Binary*)</code>
    /// </summary>
    /// <returns>A newly allocated IFileNodeName that duplicates the current node’s name buffer; nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, ACBindings.Internal.IFileNodeName*>)0x00444820)(ref this);

    /// <summary>Serializes this object's name buffer to or from the specified archive.
    /// <code>Offset: 0x004448E0
    /// void __thiscall FileNodeName_Binary::Serialize(FileNodeName_Binary*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization of the name buffer.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, ACBindings.Internal.Archive*, void>)0x004448E0)(ref this, io_archive);

    /// <summary>Parse a PString containing binary data into this object's name buffer, handling reference counting and cleanup.
    /// <code>Offset: 0x0065BC90
    /// char __thiscall FileNodeName_Binary::FromPString(_DWORD*,volatile LONG*)</code>
    /// </summary>
    /// <param name="EndPtr">Reference counter for the string buffer whose lifetime is managed during parsing.</param>
    /// <returns>Success indicator (always returns 1).</returns>
    public sbyte FromPString(int* EndPtr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, int*, sbyte>)0x0065BC90)(ref this, EndPtr);

    /// <summary>Converts the binary file node name into a wrapped PString, stores its address in the supplied output parameter, and returns that pointer.
    /// <code>Offset: 0x0065BD10
    /// _DWORD* __thiscall FileNodeName_Binary::ToPString(int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the resulting PString address.</param>
    /// <returns>The same pointer provided as a2, now pointing to the constructed string.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, int*, int*>)0x0065BD10)(ref this, a2);
}

