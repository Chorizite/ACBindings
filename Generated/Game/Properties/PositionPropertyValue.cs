namespace ACBindings;

// PositionPropertyValue
public unsafe struct PositionPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.Position m_value;

    // Methods
    // bool __thiscall PositionPropertyValue::HasValidData(PositionPropertyValue*)
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, byte>)0x00424D90)(ref this);
    // bool __thiscall PositionPropertyValue::SetValue(PositionPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424DA0)(ref this, value);
    // void __thiscall PositionPropertyValue::Serialize(PositionPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.Archive*, uint, void>)0x00424DC0)(ref this, io_archive, i_eName);
    // bool __thiscall PositionPropertyValue::Compare(PositionPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424DD0)(ref this, p);
    // BasePropertyValue* __thiscall PositionPropertyValue::Copy(PositionPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.BasePropertyValue*>)0x00425EA0)(ref this);
    // bool __thiscall PositionPropertyValue::FromFileNode(PositionPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425F80)(ref this, desc, node);
    // bool __thiscall PositionPropertyValue::InqPosition(PositionPropertyValue*,Position*)
    public byte InqPosition(ACBindings.Position* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.Position*, byte>)0x00426190)(ref this, value);
    // bool __thiscall PositionPropertyValue::SetPosition(PositionPropertyValue*,const Position*)
    public byte SetPosition(ACBindings.Position* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.Position*, byte>)0x004261B0)(ref this, value);
    // bool __thiscall PositionPropertyValue::ToFileNode(PositionPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00427B20)(ref this, desc, node);
    // char __thiscall PositionPropertyValue::GetValueAsString(int,int,void**,int)
    public sbyte GetValueAsString(int a2, void** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPropertyValue, int, void**, int, sbyte>)0x00427B70)(ref this, a2, a3, a4);
}

