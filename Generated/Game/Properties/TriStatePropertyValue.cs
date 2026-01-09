namespace ACBindings;

// TriStatePropertyValue
public unsafe struct TriStatePropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.TriState m_value;

    // Methods
    // bool __thiscall TriStatePropertyValue::SetTriState(StringTokenPropertyValue*,const unsigned int)
    public byte SetTriState(uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, uint, byte>)0x00423520)(ref this, value);
    // bool __thiscall TriStatePropertyValue::SetValue(TriStatePropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.BasePropertyValue*, byte>)0x004251A0)(ref this, value);
    // bool __thiscall TriStatePropertyValue::Compare(TriStatePropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.BasePropertyValue*, byte>)0x004251C0)(ref this, p);
    // bool __thiscall TriStatePropertyValue::InqLessThan(TriStatePropertyValue*,const BasePropertyValue*,bool*)
    public byte InqLessThan(ACBindings.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.BasePropertyValue*, byte*, byte>)0x00425200)(ref this, i_pcRHS, o_rbLessThan);
    // BasePropertyValue* __thiscall TriStatePropertyValue::Copy(TriStatePropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.BasePropertyValue*>)0x00425240)(ref this);
    // char __thiscall TriStatePropertyValue::GetValueAsString(_DWORD*,int,LONG*,int)
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, int, int*, int, sbyte>)0x004267E0)(ref this, a2, a3, a4);
    // void __thiscall TriStatePropertyValue::Serialize(TriStatePropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.Archive*, uint, void>)0x00427120)(ref this, io_archive, i_eName);
    // bool __thiscall TriStatePropertyValue::ToFileNode(TriStatePropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00427160)(ref this, desc, node);
    // bool __thiscall TriStatePropertyValue::FromFileNode(TriStatePropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TriStatePropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00427FA0)(ref this, desc, node);
}

