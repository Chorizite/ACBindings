namespace ACBindings;

// FileNodeName_Bool
public unsafe struct FileNodeName_Bool
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public byte m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_Bool::Clone(FileNodeName_Bool*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Bool, ACBindings.IFileNodeName*>)0x00423D80)(ref this);
    // void __thiscall FileNodeName_Bool::Serialize(FileNodeName_Bool*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Bool, ACBindings.Archive*, void>)0x00424530)(ref this, io_archive);
    // int __thiscall FileNodeName_Bool::FromPString(_BYTE*,const char**)
    public int FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Bool, sbyte**, int>)0x0065BC10)(ref this, a2);
    // volatile LONG** __thiscall FileNodeName_Bool::ToPString(_BYTE*,volatile LONG**)
    public int** ToPString(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Bool, int**, int**>)0x0065BC60)(ref this, a2);
}

