namespace ACBindings.Internal;

public unsafe struct FileNodeName_PString
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_name;

    // Methods

    /// <summary>
    /// Creates a deep copy of this FileNodeName_PString instance, allocating a new object initialized with the same name string.
    /// 
    /// <code>Offset: 0x004260F0
    /// IFileNodeName* __thiscall FileNodeName_PString::Clone(FileNodeName_PString*)</code>
    /// </summary>
    /// <returns>
    /// A pointer to the newly allocated IFileNodeName representing the cloned node; null if memory allocation fails.
    /// </returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_PString, ACBindings.Internal.IFileNodeName*>)0x004260F0)(ref this);

    /// <summary>Assigns the supplied string to the object's name member.
    /// <code>Offset: 0x00426120
    /// char __thiscall FileNodeName_PString::FromPString(LONG*,LONG*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the source string data.</param>
    /// <returns>Non-zero value indicating successful assignment.</returns>
    public sbyte FromPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_PString, int*, sbyte>)0x00426120)(ref this, a2);

    /// <summary>Copies the internal PStringBase pointer to the supplied output parameter and increments its reference count.
    /// <code>Offset: 0x00426140
    /// _DWORD* __thiscall FileNodeName_PString::ToPString(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the PStringBase instance.</param>
    /// <returns>The same pointer passed as a2 after storing the value.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_PString, int*, int*>)0x00426140)(ref this, a2);

    /// <summary>Serializes the file node's name into the specified archive, using the underlying string serializer.
    /// <code>Offset: 0x004276E0
    /// void __thiscall FileNodeName_PString::Serialize(FileNodeName_PString*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive to write the serialized data to.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_PString, ACBindings.Internal.Archive*, void>)0x004276E0)(ref this, io_archive);
}

