namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0065BB50
    /// char __thiscall FileNodeName_Float::FromPString(float*,char**)</code>
    /// </summary>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Float, sbyte**, sbyte>)0x0065BB50)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065C130
    /// int* __thiscall FileNodeName_Float::ToPString(float*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Float, int*, int*>)0x0065C130)(ref this, a2);
}

