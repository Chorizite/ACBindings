namespace ACBindings.Internal;

public unsafe struct FileNodeName_Guid
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.Turbine_GUID m_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0065B2B0
    /// NodeNameType __thiscall FileNodeName_Guid::GetType(FileNodeName_Guid*)</code>
    /// </summary>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, ACBindings.Internal.NodeNameType>)0x0065B2B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B2C0
    /// IFileNodeName* __thiscall FileNodeName_Guid::Clone(FileNodeName_Guid*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, ACBindings.Internal.IFileNodeName*>)0x0065B2C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065B470
    /// bool __thiscall FileNodeName_Guid::FromPString(int,char*)</code>
    /// </summary>
    public byte FromPString(sbyte* Buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, sbyte*, byte>)0x0065B470)(ref this, Buffer);

    /// <summary>
    /// <code>Offset: 0x0065B760
    /// void __thiscall FileNodeName_Guid::Serialize(FileNodeName_Guid*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, ACBindings.Internal.Archive*, void>)0x0065B760)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0065BD70
    /// int* __thiscall FileNodeName_Guid::ToPString(unsigned __int16*,int*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, int*, int*>)0x0065BD70)(ref this, a2);
}

