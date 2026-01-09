namespace ACBindings;

// DataFilePropertyValue
public unsafe struct DataFilePropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.IDClass___tagDataID m_value;

    // Methods
    // bool __thiscall DataFilePropertyValue::InqDataID(StringTokenPropertyValue*,unsigned int*)
    public byte InqDataID(uint* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DataFilePropertyValue, uint*, byte>)0x00423510)(ref this, value);
    // bool __thiscall DataFilePropertyValue::SetValue(DataFilePropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DataFilePropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424050)(ref this, value);
    // bool __thiscall DataFilePropertyValue::Compare(DataFilePropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DataFilePropertyValue, ACBindings.BasePropertyValue*, byte>)0x004240C0)(ref this, p);
    // char __thiscall DataFilePropertyValue::GetValueAsString(_DWORD*,int,PStringBase<char>,int)
    public sbyte GetValueAsString(int a2, ACBindings.PStringBase__sbyte ArgList, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DataFilePropertyValue, int, ACBindings.PStringBase__sbyte, int, sbyte>)0x0042B3A0)(ref this, a2, ArgList, a4);
}

