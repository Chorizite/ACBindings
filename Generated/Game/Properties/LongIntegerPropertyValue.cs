namespace ACBindings;

// LongIntegerPropertyValue
public unsafe struct LongIntegerPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public long m_value;

    // Methods
    // void __thiscall LongIntegerPropertyValue::Serialize(LongIntegerPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.Archive*, uint, void>)0x00423AD0)(ref this, io_archive, i_eName);
    // bool __thiscall LongIntegerPropertyValue::SetValue(LongIntegerPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424900)(ref this, value);
    // bool __thiscall LongIntegerPropertyValue::Compare(LongIntegerPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424920)(ref this, p);
    // bool __thiscall LongIntegerPropertyValue::InqLessThan(LongIntegerPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00424970)(ref this, i_pcRHS, o_rbLessThan);
    // bool __thiscall LongIntegerPropertyValue::operator>(LongIntegerPropertyValue*,const BasePropertyValue*)
//     public byte operator>(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424AD0)(ref this, i_rcRhs);
    // bool __thiscall LongIntegerPropertyValue::operator<(LongIntegerPropertyValue*,const BasePropertyValue*)
//     public byte operator__(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424B70)(ref this, i_rcRhs);
    // BasePropertyValue* __thiscall LongIntegerPropertyValue::Copy(LongIntegerPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyValue*>)0x00424CB0)(ref this);
    // bool __thiscall LongIntegerPropertyValue::FromFileNode(LongIntegerPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00427730)(ref this, desc, node);
    // bool __thiscall LongIntegerPropertyValue::ToFileNode(LongIntegerPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x004278D0)(ref this, desc, node);
    // char __thiscall LongIntegerPropertyValue::GetValueAsString(_DWORD*,int,void**,int)
    public sbyte GetValueAsString(int a2, void** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LongIntegerPropertyValue, int, void**, int, sbyte>)0x004279C0)(ref this, a2, a3, a4);
}

