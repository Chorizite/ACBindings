namespace ACBindings;

// StructPropertyValue
public unsafe struct StructPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.AutoGrowHashTable__uint__BaseProperty m_value;

    // Generated Constructor
    public StructPropertyValue(int* a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // char* __thiscall StructPropertyValue::GetHash(char*)
    public sbyte* GetHash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, sbyte*>)0x00426990)(ref this);
    // bool __thiscall StructPropertyValue::InqStructElement(StructPropertyValue*,unsigned int,BaseProperty*)
    public byte InqStructElement(uint name, ACBindings.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, uint, ACBindings.BaseProperty*, byte>)0x00429030)(ref this, name, value);
    // const BaseProperty* __thiscall StructPropertyValue::GetStructElement(StructPropertyValue*,const unsigned int)
    public ACBindings.BaseProperty* GetStructElement(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, uint, ACBindings.BaseProperty*>)0x004290D0)(ref this, name);
    // bool __thiscall StructPropertyValue::SetStructElement(StructPropertyValue*,unsigned int,const BaseProperty*)
    public byte SetStructElement(uint name, ACBindings.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, uint, ACBindings.BaseProperty*, byte>)0x00429100)(ref this, name, value);
    // bool __thiscall StructPropertyValue::RemoveStructElement(StructPropertyValue*,unsigned int)
    public byte RemoveStructElement(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, uint, byte>)0x004291C0)(ref this, name);
    // bool __thiscall StructPropertyValue::SetValue(StructPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00429260)(ref this, value);
    // void*** __thiscall StructPropertyValue::StructPropertyValue(void***,_DWORD*)
    public void*** _ConstructorInternal(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, int*, void***>)0x004296E0)(ref this, a2);
    // void __thiscall StructPropertyValue::Serialize(StructPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, ACBindings.Archive*, uint, void>)0x00429730)(ref this, io_archive, i_eName);
    // bool __thiscall StructPropertyValue::ToFileNode(StructPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042C0A0)(ref this, desc, node);
    // char __thiscall StructPropertyValue::GetValueAsString(_DWORD*,int,char**,char)
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, int, sbyte**, sbyte, sbyte>)0x0042C120)(ref this, a2, a3, a4);
    // bool __thiscall StructPropertyValue::Compare(StructPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, ACBindings.BasePropertyValue*, byte>)0x0042C160)(ref this, p);
    // bool __thiscall StructPropertyValue::FromFileNode(StructPropertyValue*,BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StructPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042C320)(ref this, desc, node);
}

