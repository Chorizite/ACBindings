namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0065B9D0
    /// char __thiscall FileNodeName_Int32::FromPString(char*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int32, sbyte**, sbyte>)0x0065B9D0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065BF70
    /// int* __thiscall FileNodeName_Int32::ToPString(_DWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int32, int*, int*>)0x0065BF70)(ref this, a2);
}

