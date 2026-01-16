namespace ACBindings.Internal;


/// <summary>Represents a 16‑bit cell identifier used in the file node naming hierarchy, providing parsing from numeric strings, hex formatting, and binary serialization support.</summary>
/// <remarks>Implements IFileNodeName; identified by type code 5 within the system.</remarks>
public unsafe struct FileNodeName_CellID
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.IDClass____tagCellID m_name;

    // Methods

    /// <summary>Retrieves the file node name type, which corresponds to a CellID identifier.
    /// <code>Offset: 0x0065B230
    /// NodeNameType __thiscall FileNodeName_CellID::GetType(FileNodeName_CellID*)</code>
    /// </summary>
    /// <returns>The constant NodeNameType value representing the CellID type.</returns>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, ACBindings.Internal.NodeNameType>)0x0065B230)(ref this);

    /// <summary>Creates a new IFileNodeName object that encapsulates the same cell ID as this FileNodeName_CellID instance.
    /// <code>Offset: 0x0065B240
    /// IFileNodeName* __thiscall FileNodeName_CellID::Clone(FileNodeName_CellID*)</code>
    /// </summary>
    /// <returns>A pointer to the cloned IFileNodeName, or null if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, ACBindings.Internal.IFileNodeName*>)0x0065B240)(ref this);

    /// <summary>Serializes or deserializes the CellID value to or from a binary archive, ensuring 2‑byte alignment and handling read/write mode based on the archive flags.
    /// <code>Offset: 0x0065B6C0
    /// void __thiscall FileNodeName_CellID::Serialize(FileNodeName_CellID*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; writes the current ID when in write mode or reads an ID into the object when in read mode.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, ACBindings.Internal.Archive*, void>)0x0065B6C0)(ref this, io_archive);

    /// <summary>Parses a numeric cell ID from the supplied string and stores it into the FileNodeName_CellID instance if valid.
    /// <code>Offset: 0x0065BBB0
    /// char __thiscall FileNodeName_CellID::FromPString(char*,char**)</code>
    /// </summary>
    /// <param name="String">Pointer to the FileNodeName_CellID object where the parsed 16‑bit ID will be written.</param>
    /// <param name="a2">Address of a reference‑counted C‑string containing the cell ID; its reference count is incremented before parsing.</param>
    /// <returns>Returns 1 when the string represents an unsigned integer that fits within 0–65535 and the value has been stored; otherwise returns 0 and leaves the object unchanged.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, sbyte**, sbyte>)0x0065BBB0)(ref this, a2);

    /// <summary>Converts the cell identifier stored in this object to a hexadecimal string prefixed with "0x" and writes the resulting pointer into the supplied buffer.
    /// <code>Offset: 0x0065C1A0
    /// int* __thiscall FileNodeName_CellID::ToPString(unsigned __int16*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer that will receive the address of the formatted string; the function returns this value.</param>
    /// <returns>The same pointer passed as <c>a2</c>, pointing to the newly created hex string.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_CellID, int*, int*>)0x0065C1A0)(ref this, a2);
}

