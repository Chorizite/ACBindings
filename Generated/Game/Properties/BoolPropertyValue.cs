namespace ACBindings;

// BoolPropertyValue
public unsafe struct BoolPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public byte m_value;

    // Methods
    // bool __thiscall BoolPropertyValue::InqBool(BoolPropertyValue*,bool*)
    public byte InqBool(byte* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, byte*, byte>)0x00423AF0)(ref this, value);
    // bool __thiscall BoolPropertyValue::SetBool(BoolPropertyValue*,const bool)
    public byte SetBool(byte value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, byte, byte>)0x00423B00)(ref this, value);
    // bool __thiscall BoolPropertyValue::SetValue(BoolPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00423B10)(ref this, value);
    // bool __thiscall BoolPropertyValue::Compare(BoolPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00423B30)(ref this, p);
    // bool __thiscall BoolPropertyValue::InqLessThan(BoolPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00423B70)(ref this, i_pcRHS, o_rbLessThan);
    // void __thiscall BoolPropertyValue::toggle(BoolPropertyValue*)
    public void toggle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, void>)0x00423CA0)(ref this);
    // BasePropertyValue* __thiscall BoolPropertyValue::Copy(BoolPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.BasePropertyValue*>)0x00423CB0)(ref this);
    // void __thiscall BoolPropertyValue::Serialize(BoolPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.Archive*, uint, void>)0x00423CE0)(ref this, io_archive, i_eName);
    // bool __thiscall BoolPropertyValue::ToFileNode(BoolPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00423D00)(ref this, desc, node);
    // bool __thiscall BoolPropertyValue::FromFileNode(BoolPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426B90)(ref this, desc, node);
    // char __thiscall BoolPropertyValue::GetValueAsString(_BYTE*,int,void**,int)
    public sbyte GetValueAsString(int a2, void** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoolPropertyValue, int, void**, int, sbyte>)0x00427630)(ref this, a2, a3, a4);
}

