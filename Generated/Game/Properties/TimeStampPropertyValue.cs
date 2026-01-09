namespace ACBindings;

// TimeStampPropertyValue
public unsafe struct TimeStampPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public double m_value;

    // Methods
    // bool __thiscall TimeStampPropertyValue::InqTimeStamp(TimeStampPropertyValue*,long double*)
    public byte InqTimeStamp(double* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, double*, byte>)0x00423770)(ref this, value);
    // bool __thiscall TimeStampPropertyValue::HasValidData(TimeStampPropertyValue*)
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, byte>)0x004252A0)(ref this);
    // bool __thiscall TimeStampPropertyValue::SetValue(TimeStampPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004252C0)(ref this, value);
    // bool __thiscall TimeStampPropertyValue::Compare(TimeStampPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004252E0)(ref this, p);
    // bool __thiscall TimeStampPropertyValue::InqLessThan(TimeStampPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00425330)(ref this, i_pcRHS, o_rbLessThan);
    // BasePropertyValue* __thiscall TimeStampPropertyValue::Copy(TimeStampPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.BasePropertyValue*>)0x00425390)(ref this);
    // bool __thiscall TimeStampPropertyValue::ToFileNode(TimeStampPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x004253C0)(ref this, desc, node);
    // bool __thiscall TimeStampPropertyValue::FromFileNode(TimeStampPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x004280A0)(ref this, desc, node);
    // char __thiscall TimeStampPropertyValue::GetValueAsString(double*,int,char**,int)
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, int, sbyte**, int, sbyte>)0x004281C0)(ref this, a2, a3, a4);
    // void __thiscall TimeStampPropertyValue::Serialize(TimeStampPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeStampPropertyValue, ACBindings.Archive*, uint, void>)0x00428790)(ref this, io_archive, i_eName);
}

