namespace ACBindings;

// FileNodeName_Binary
public unsafe struct FileNodeName_Binary
{
    // Base Classes
    public ACBindings.IFileNodeName BaseClass_IFileNodeName; // ACBindings.IFileNodeName

    // Members
    public ACBindings.SmartBuffer m_name;

    // Methods
    // IFileNodeName* __thiscall FileNodeName_Binary::Clone(FileNodeName_Binary*)
    public ACBindings.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Binary, ACBindings.IFileNodeName*>)0x00444820)(ref this);
    // void __thiscall FileNodeName_Binary::Serialize(FileNodeName_Binary*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Binary, ACBindings.Archive*, void>)0x004448E0)(ref this, io_archive);
    // char __thiscall FileNodeName_Binary::FromPString(_DWORD*,volatile LONG*)
    public sbyte FromPString(int* EndPtr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Binary, int*, sbyte>)0x0065BC90)(ref this, EndPtr);
    // _DWORD* __thiscall FileNodeName_Binary::ToPString(int,_DWORD*)
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FileNodeName_Binary, int*, int*>)0x0065BD10)(ref this, a2);
}

