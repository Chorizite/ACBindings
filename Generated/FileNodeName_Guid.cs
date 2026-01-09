namespace ACBindings;

// FileNodeName_Guid
public unsafe struct FileNodeName_Guid
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public ACBindings.Turbine_GUID m_name;

    // Methods
    // NodeNameType __thiscall FileNodeName_Guid::GetType(FileNodeName_Guid*)
    public ACBindings.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Guid, ACBindings.NodeNameType>)0x0065B2B0)(ref this);
    // IFileNodeName* __thiscall FileNodeName_Guid::Clone(FileNodeName_Guid*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Guid, ACBindings.IFileNodeName*>)0x0065B2C0)(ref this);
    // bool __thiscall FileNodeName_Guid::FromPString(int,char*)
    public byte FromPString(sbyte* Buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Guid, sbyte*, byte>)0x0065B470)(ref this, Buffer);
    // void __thiscall FileNodeName_Guid::Serialize(FileNodeName_Guid*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Guid, ACBindings.Archive*, void>)0x0065B760)(ref this, io_archive);
    // int* __thiscall FileNodeName_Guid::ToPString(unsigned __int16*,int*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Guid, int*, int*>)0x0065BD70)(ref this, a2);
}

