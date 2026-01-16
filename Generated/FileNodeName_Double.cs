namespace ACBindings.Internal;


/// <summary>Represents a file node name stored as a long double value, enabling cloning, serialization, and conversions to and from string representations.</summary>
public unsafe struct FileNodeName_Double
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public double m_name;

    // Methods

    /// <summary>Create a copy of this FileNodeName_Double instance by allocating new memory and duplicating its long double name field.
    /// <code>Offset: 0x00425460
    /// IFileNodeName* __thiscall FileNodeName_Double::Clone(FileNodeName_Double*)</code>
    /// </summary>
    /// <returns>Pointer to the newly allocated IFileNodeName object, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Double, ACBindings.Internal.IFileNodeName*>)0x00425460)(ref this);

    /// <summary>Serializes the long double member m_name of FileNodeName_Double into the provided Archive.
    /// <code>Offset: 0x00425490
    /// void __thiscall FileNodeName_Double::Serialize(FileNodeName_Double*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing the serialized data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Double, ACBindings.Internal.Archive*, void>)0x00425490)(ref this, io_archive);

    /// <summary>Retrieves the type identifier for this file node name, always returning 3.
    /// <code>Offset: 0x00527400
    /// unsigned int __stdcall FileNodeName_Double::GetType()</code>
    /// </summary>
    /// <returns>The unsigned integer value 3, indicating a double‑precision node name type.</returns>
    public static uint GetType() => ((delegate* unmanaged[Stdcall]<uint>)0x00527400)();

    /// <summary>Attempts to convert the text pointed to by a2 into a double value and stores it in String[1]. Returns non‑zero if parsing succeeds; otherwise returns 0.
    /// <code>Offset: 0x0065BAF0
    /// char __thiscall FileNodeName_Double::FromPString(double*,char**)</code>
    /// </summary>
    /// <param name="String">Destination buffer where the parsed numeric value is written.</param>
    /// <param name="a2">Pointer to the string containing the number, whose reference count is incremented before conversion.</param>
    /// <returns>Nonzero when the string represents a valid double; zero otherwise.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Double, sbyte**, sbyte>)0x0065BAF0)(ref this, a2);

    /// <summary>Formats this node’s double value into a string and stores the resulting buffer address in the supplied argument.
    /// <code>Offset: 0x0065C0C0
    /// int* __thiscall FileNodeName_Double::ToPString(double*,int*)</code>
    /// </summary>
    /// <param name="a2">Receives the pointer to the allocated character buffer containing the formatted number.</param>
    /// <returns>The same pointer passed in (int*), pointing to the output parameter location.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Double, int*, int*>)0x0065C0C0)(ref this, a2);
}

