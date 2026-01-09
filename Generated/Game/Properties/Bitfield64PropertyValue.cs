namespace ACBindings;

// Bitfield64PropertyValue
public unsafe struct Bitfield64PropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ulong m_value;

    // Methods
    // bool __thiscall Bitfield64PropertyValue::SetBitfield64(TimeStampPropertyValue*,const long double)
    public byte SetBitfield64(double value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, double, byte>)0x00423790)(ref this, value);
    // bool __thiscall Bitfield64PropertyValue::SetValue(Bitfield64PropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyValue*, byte>)0x004237B0)(ref this, value);
    // bool __thiscall Bitfield64PropertyValue::Compare(Bitfield64PropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyValue*, byte>)0x004237D0)(ref this, p);
    // bool __thiscall Bitfield64PropertyValue::InqLessThan(Bitfield64PropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00423820)(ref this, i_pcRHS, o_rbLessThan);
    // bool __thiscall Bitfield64PropertyValue::contains(Bitfield64PropertyValue*,const BasePropertyValue*)
    public byte contains(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyValue*, byte>)0x004239A0)(ref this, i_rcRhs);
    // void __thiscall Bitfield64PropertyValue::off(Bitfield64PropertyValue*,const BasePropertyValue*)
    public void off(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyValue*, void>)0x00423A40)(ref this, i_rcRhs);
    // void __thiscall Bitfield64PropertyValue::toggle(Bitfield64PropertyValue*)
    public void toggle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, void>)0x00423A80)(ref this);
    // BasePropertyValue* __thiscall Bitfield64PropertyValue::Copy(Bitfield64PropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyValue*>)0x00423AA0)(ref this);
    // bool __thiscall Bitfield64PropertyValue::FromFileNode(Bitfield64PropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042B100)(ref this, desc, node);
    // bool __thiscall Bitfield64PropertyValue::ToFileNode(Bitfield64PropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042B1B0)(ref this, desc, node);
    // char __thiscall Bitfield64PropertyValue::GetValueAsString(_QWORD*,int,int*,int)
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield64PropertyValue, int, int*, int, sbyte>)0x0042B260)(ref this, a2, a3, a4);
}

