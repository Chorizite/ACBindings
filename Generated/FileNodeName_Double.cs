namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00527400
    /// unsigned int __stdcall FileNodeName_Double::GetType()</code>
    /// </summary>
    public static uint GetType() => ((delegate* unmanaged[Stdcall]<uint>)0x00527400)();

    /// <summary>
    /// <code>Offset: 0x0065BAF0
    /// char __thiscall FileNodeName_Double::FromPString(double*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Double, sbyte**, sbyte>)0x0065BAF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065C0C0
    /// int* __thiscall FileNodeName_Double::ToPString(double*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Double, int*, int*>)0x0065C0C0)(ref this, a2);
}

