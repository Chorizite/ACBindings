namespace ACBindings.Internal;


/// <summary>Represents a file node name that stores its identifier as a floating‑point value, enabling numeric naming schemes within the file system abstraction.</summary>
public unsafe struct FileNodeName_Float
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public float m_name;

    // Methods

    /// <summary>Creates a copy of this FileNodeName_Float instance, allocating a new IFileNodeName with identical value.
    /// <code>Offset: 0x00425CA0
    /// IFileNodeName* __thiscall FileNodeName_Float::Clone(FileNodeName_Float*)</code>
    /// </summary>
    /// <returns>A newly allocated IFileNodeName containing the cloned float name, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Float, ACBindings.Internal.IFileNodeName*>)0x00425CA0)(ref this);

    /// <summary>Parses a decimal number from the supplied string and writes the result into the given float buffer. Returns 0 if the input is not numeric or conversion fails; otherwise returns 1 after storing the value.
    /// <code>Offset: 0x0065BB50
    /// char __thiscall FileNodeName_Float::FromPString(float*,char**)</code>
    /// </summary>
    /// <param name="String">Pointer to a float array where the parsed numeric value will be written at index one.</param>
    /// <param name="a2">Double pointer to a reference‑counted C‑string containing the number to parse.</param>
    /// <returns>Non‑zero on successful conversion, zero if parsing fails or input is invalid.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Float, sbyte**, sbyte>)0x0065BB50)(ref this, a2);

    /// <summary>Converts the float member of FileNodeName_Float into a string using "%.8g" formatting and writes the resulting buffer pointer to the supplied argument.
    /// <code>Offset: 0x0065C130
    /// int* __thiscall FileNodeName_Float::ToPString(float*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the address of the formatted string buffer.</param>
    /// <returns>The same pointer passed in, pointing to the formatted string buffer.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Float, int*, int*>)0x0065C130)(ref this, a2);
}

