namespace ACBindings;

// AvailablePropertySet
public unsafe struct AvailablePropertySet
{
    // Members
    public ACBindings.HashTable__uint__AvailableProperty m_reqHash;

    // Methods
    // _DWORD* __thiscall AvailablePropertySet::end(char*,_DWORD*)
    public int* end(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AvailablePropertySet, int*, int*>)0x0042BCF0)(ref this, a2);
    // bool __thiscall AvailablePropertySet::contains(AvailablePropertySet*,unsigned int)
    public byte contains(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AvailablePropertySet, uint, byte>)0x0042BD10)(ref this, name);
    // bool __thiscall AvailablePropertySet::AddProperty(AvailablePropertySet*,unsigned int)
    public byte AddProperty(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AvailablePropertySet, uint, byte>)0x0042BE30)(ref this, name);
    // void __thiscall AvailablePropertySet::Serialize(AvailablePropertySet*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AvailablePropertySet, ACBindings.Archive*, void>)0x0042C070)(ref this, io_archive);
}

