namespace ACBindings;

// IntegerPropertyValue
public unsafe struct IntegerPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public int m_value;

    // Methods
    // void __thiscall IntegerPropertyValue::Serialize(IntegerPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.Archive*, uint, void>)0x00424550)(ref this, io_archive, i_eName);
    // bool __thiscall IntegerPropertyValue::SetValue(IntegerPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424650)(ref this, value);
    // bool __thiscall IntegerPropertyValue::Compare(IntegerPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424670)(ref this, p);
    // bool __thiscall IntegerPropertyValue::InqLessThan(IntegerPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x004246B0)(ref this, i_pcRHS, o_rbLessThan);
    // bool __thiscall IntegerPropertyValue::operator>(IntegerPropertyValue*,const BasePropertyValue*)
//     public byte operator>(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004247B0)(ref this, i_rcRhs);
    // bool __thiscall IntegerPropertyValue::operator<(IntegerPropertyValue*,const BasePropertyValue*)
//     public byte operator__(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424810)(ref this, i_rcRhs);
    // BasePropertyValue* __thiscall IntegerPropertyValue::Copy(IntegerPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyValue*>)0x004248D0)(ref this);
    // bool __thiscall IntegerPropertyValue::ToFileNode(IntegerPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425DB0)(ref this, desc, node);
    // bool __thiscall IntegerPropertyValue::FromFileNode(IntegerPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426E60)(ref this, desc, node);
    // char __thiscall IntegerPropertyValue::GetValueAsString(_DWORD*,int,char**,int)
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntegerPropertyValue, int, sbyte**, int, sbyte>)0x00427710)(ref this, a2, a3, a4);
}

