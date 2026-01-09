namespace ACBindings;

// StringTokenPropertyValue
public unsafe struct StringTokenPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public uint m_value;
    public ACBindings.PStringBase__sbyte m_tokenName;

    // Methods
    // bool __thiscall StringTokenPropertyValue::SetValue(StringTokenPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTokenPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00426690)(ref this, value);
    // bool __thiscall StringTokenPropertyValue::Compare(StringTokenPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTokenPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004266B0)(ref this, p);
    // BasePropertyValue* __thiscall StringTokenPropertyValue::Copy(StringTokenPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTokenPropertyValue, ACBindings.BasePropertyValue*>)0x00426730)(ref this);
    // bool __thiscall StringTokenPropertyValue::FromFileNode(StringTokenPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTokenPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426770)(ref this, desc, node);
    // bool __thiscall StringTokenPropertyValue::ToFileNode(StringTokenPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTokenPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x004270C0)(ref this, desc, node);
    // char __thiscall StringTokenPropertyValue::GetValueAsString(_DWORD*,int,char**,char)
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringTokenPropertyValue, int, sbyte**, sbyte, sbyte>)0x00427F50)(ref this, a2, a3, a4);
}

