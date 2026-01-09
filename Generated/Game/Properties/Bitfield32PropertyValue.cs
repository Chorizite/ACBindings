namespace ACBindings;

// Bitfield32PropertyValue
public unsafe struct Bitfield32PropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public uint m_value;

    // Methods
    // bool __thiscall Bitfield32PropertyValue::SetValue(Bitfield32PropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*, byte>)0x00423530)(ref this, value);
    // bool __thiscall Bitfield32PropertyValue::Compare(Bitfield32PropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*, byte>)0x00423550)(ref this, p);
    // bool __thiscall Bitfield32PropertyValue::InqLessThan(Bitfield32PropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00423590)(ref this, i_pcRHS, o_rbLessThan);
    // void __thiscall Bitfield32PropertyValue::on(Bitfield32PropertyValue*,const BasePropertyValue*)
    public void on(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*, void>)0x00423600)(ref this, i_rcRhs);
    // bool __thiscall Bitfield32PropertyValue::contains(Bitfield32PropertyValue*,const BasePropertyValue*)
    public byte contains(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*, byte>)0x004236C0)(ref this, i_rcRhs);
    // void __thiscall Bitfield32PropertyValue::off(Bitfield32PropertyValue*,const BasePropertyValue*)
    public void off(ACBindings.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*, void>)0x00423700)(ref this, i_rcRhs);
    // void __thiscall Bitfield32PropertyValue::toggle(Bitfield32PropertyValue*)
    public void toggle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, void>)0x00423730)(ref this);
    // BasePropertyValue* __thiscall Bitfield32PropertyValue::Copy(Bitfield32PropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyValue*>)0x00423740)(ref this);
    // bool __thiscall Bitfield32PropertyValue::FromFileNode(Bitfield32PropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042ADB0)(ref this, desc, node);
    // bool __thiscall Bitfield32PropertyValue::ToFileNode(Bitfield32PropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042AE60)(ref this, desc, node);
    // char __thiscall Bitfield32PropertyValue::GetValueAsString(_DWORD*,int,int*,int)
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Bitfield32PropertyValue, int, int*, int, sbyte>)0x0042AFD0)(ref this, a2, a3, a4);
}

