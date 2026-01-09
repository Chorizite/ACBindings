namespace ACBindings;

// VectorPropertyValue
public unsafe struct VectorPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.Vector3 m_value;

    // Methods
    // bool __thiscall VectorPropertyValue::FromFileNode(VectorPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425520)(ref this, desc, node);
    // bool __thiscall VectorPropertyValue::ToFileNode(VectorPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425540)(ref this, desc, node);
    // bool __thiscall VectorPropertyValue::InqVector(VectorPropertyValue*,Vector3*)
    public byte InqVector(ACBindings.Vector3* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.Vector3*, byte>)0x00425560)(ref this, value);
    // bool __thiscall VectorPropertyValue::SetVector(VectorPropertyValue*,const Vector3*)
    public byte SetVector(ACBindings.Vector3* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.Vector3*, byte>)0x00425580)(ref this, value);
    // bool __thiscall VectorPropertyValue::SetValue(VectorPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004255A0)(ref this, value);
    // bool __thiscall VectorPropertyValue::Compare(VectorPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004255C0)(ref this, p);
    // bool __thiscall VectorPropertyValue::InqLessThan(VectorPropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00425610)(ref this, i_pcRHS, o_rbLessThan);
    // BasePropertyValue* __thiscall VectorPropertyValue::Copy(VectorPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.BasePropertyValue*>)0x004256A0)(ref this);
    // void __thiscall VectorPropertyValue::Serialize(VectorPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, ACBindings.Archive*, uint, void>)0x00426830)(ref this, io_archive, i_eName);
    // char __thiscall VectorPropertyValue::GetValueAsString(float*,int,char**,int)
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.VectorPropertyValue, int, sbyte**, int, sbyte>)0x004281E0)(ref this, a2, a3, a4);
}

