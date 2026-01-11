namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0065B970
    /// char __thiscall FileNodeName_UInt32::FromPString(char*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt32, sbyte**, sbyte>)0x0065B970)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065BF00
    /// int* __thiscall FileNodeName_UInt32::ToPString(_DWORD*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_UInt32, int*, int*>)0x0065BF00)(ref this, a2);
}

