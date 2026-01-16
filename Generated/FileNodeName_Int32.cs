namespace ACBindings.Internal;


/// <summary>Represents a file node name identified by a 32‑bit integer, enabling lookup and serialization within the file system.</summary>
/// <remarks>Implements IFileNodeName, providing cloning, parsing from strings, formatting to strings, and archive serialization support.</remarks>
public unsafe struct FileNodeName_Int32
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public int m_name;

    // Methods

    /// <summary>Creates a new IFileNodeName instance that copies the current FileNodeName_Int32, preserving its name value.
    /// <code>Offset: 0x00425E30
    /// IFileNodeName* __thiscall FileNodeName_Int32::Clone(FileNodeName_Int32*)</code>
    /// </summary>
    /// <returns>A pointer to the freshly allocated clone, or nullptr when memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int32, ACBindings.Internal.IFileNodeName*>)0x00425E30)(ref this);

    /// <summary>Serializes the integer name stored in this <c>FileNodeName_Int32</c> instance to or from the specified <c>Archive</c>.
    /// <code>Offset: 0x00425E80
    /// void __thiscall FileNodeName_Int32::Serialize(FileNodeName_Int32*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization operations.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int32, ACBindings.Internal.Archive*, void>)0x00425E80)(ref this, io_archive);

    /// <summary>Parses an integer from a reference‑counted C-string and writes the value into the supplied buffer.
    /// <code>Offset: 0x0065B9D0
    /// char __thiscall FileNodeName_Int32::FromPString(char*,char**)</code>
    /// </summary>
    /// <param name="String">Pointer to a buffer where the parsed 32‑bit integer will be stored as its second dword.</param>
    /// <param name="a2">Pointer to a reference‑counted string; the function increments its reference count before parsing.</param>
    /// <returns>Nonzero if the string contains a valid 32‑bit integer, otherwise zero.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int32, sbyte**, sbyte>)0x0065B9D0)(ref this, a2);

    /// <summary>Converts the node's integer identifier to a string representation using standard formatting, storing the result in the supplied PString buffer.
    /// <code>Offset: 0x0065BF70
    /// int* __thiscall FileNodeName_Int32::ToPString(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to store the resulting PString buffer.</param>
    /// <returns>The same pointer provided as a2 after it has been assigned the formatted string.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int32, int*, int*>)0x0065BF70)(ref this, a2);
}

