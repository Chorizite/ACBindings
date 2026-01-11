namespace ACBindings.Internal;

public unsafe struct FileNodeName_Binary
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.SmartBuffer m_name;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00444820
    /// IFileNodeName* __thiscall FileNodeName_Binary::Clone(FileNodeName_Binary*)</code>
    /// </summary>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, ACBindings.Internal.IFileNodeName*>)0x00444820)(ref this);

    /// <summary>
    /// <code>Offset: 0x004448E0
    /// void __thiscall FileNodeName_Binary::Serialize(FileNodeName_Binary*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, ACBindings.Internal.Archive*, void>)0x004448E0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0065BC90
    /// char __thiscall FileNodeName_Binary::FromPString(_DWORD*,volatile LONG*)</code>
    /// </summary>
    public sbyte FromPString(int* EndPtr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, int*, sbyte>)0x0065BC90)(ref this, EndPtr);

    /// <summary>
    /// <code>Offset: 0x0065BD10
    /// _DWORD* __thiscall FileNodeName_Binary::ToPString(int,_DWORD*)</code>
    /// </summary>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Binary, int*, int*>)0x0065BD10)(ref this, a2);
}

