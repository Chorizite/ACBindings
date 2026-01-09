namespace ACBindings;

// FileNodeName_PString
public unsafe struct FileNodeName_PString
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public ACBindings.PStringBase__sbyte m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_PString::Clone(FileNodeName_PString*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_PString, ACBindings.IFileNodeName*>)0x004260F0)(ref this);
    // char __thiscall FileNodeName_PString::FromPString(LONG*,LONG*)
    public sbyte FromPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_PString, int*, sbyte>)0x00426120)(ref this, a2);
    // _DWORD* __thiscall FileNodeName_PString::ToPString(_DWORD*,_DWORD*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_PString, int*, int*>)0x00426140)(ref this, a2);
    // void __thiscall FileNodeName_PString::Serialize(FileNodeName_PString*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_PString, ACBindings.Archive*, void>)0x004276E0)(ref this, io_archive);
}

