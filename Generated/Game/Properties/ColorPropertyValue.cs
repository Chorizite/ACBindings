namespace ACBindings;

// ColorPropertyValue
public unsafe struct ColorPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.RGBAColor m_value;

    // Methods
    // bool __thiscall ColorPropertyValue::FromFileNode(ColorPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00423DF0)(ref this, desc, node);
    // bool __thiscall ColorPropertyValue::ToFileNode(ColorPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00423E10)(ref this, desc, node);
    // bool __thiscall ColorPropertyValue::InqColor(ColorPropertyValue*,RGBAColor*)
    public byte InqColor(ACBindings.RGBAColor* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.RGBAColor*, byte>)0x00423E30)(ref this, value);
    // bool __thiscall ColorPropertyValue::SetColor(ColorPropertyValue*,const RGBAColor*)
    public byte SetColor(ACBindings.RGBAColor* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.RGBAColor*, byte>)0x00423E60)(ref this, value);
    // bool __thiscall ColorPropertyValue::SetValue(ColorPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00423E90)(ref this, value);
    // void __thiscall ColorPropertyValue::Serialize(ColorPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.Archive*, uint, void>)0x00423EF0)(ref this, io_archive, i_eName);
    // bool __thiscall ColorPropertyValue::Compare(ColorPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00423F00)(ref this, p);
    // bool __thiscall ColorPropertyValue::InqLessThan(ColorPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00423FB0)(ref this, i_pcRHS, o_rbLessThan);
    // char __thiscall ColorPropertyValue::GetValueAsString(float*,int,char**,int)
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ColorPropertyValue, int, sbyte**, int, sbyte>)0x00427660)(ref this, a2, a3, a4);
}

