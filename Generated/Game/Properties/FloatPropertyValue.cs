namespace ACBindings;

// FloatPropertyValue
public unsafe struct FloatPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public float m_value;

    // Methods
    // bool __thiscall FloatPropertyValue::SetValue(FloatPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424250)(ref this, value);
    // bool __thiscall FloatPropertyValue::InqLessThan(FloatPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00424270)(ref this, i_pcRHS, o_rbLessThan);
    // bool __thiscall FloatPropertyValue::operator>(FloatPropertyValue*,const BasePropertyValue*)
//     public byte operator>(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424380)(ref this, i_rcRhs);
    // bool __thiscall FloatPropertyValue::operator<(FloatPropertyValue*,const BasePropertyValue*)
//     public byte operator__(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424400)(ref this, i_rcRhs);
    // BasePropertyValue* __thiscall FloatPropertyValue::Copy(FloatPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyValue*>)0x00424500)(ref this);
    // bool __thiscall FloatPropertyValue::Compare(FloatPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424570)(ref this, p);
    // bool __thiscall FloatPropertyValue::ToFileNode(FloatPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425C20)(ref this, desc, node);
    // bool __thiscall FloatPropertyValue::FromFileNode(FloatPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426C80)(ref this, desc, node);
    // char __thiscall FloatPropertyValue::GetValueAsString(float*,int,char**,char)
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FloatPropertyValue, int, sbyte**, sbyte, sbyte>)0x004276A0)(ref this, a2, a3, a4);
}

