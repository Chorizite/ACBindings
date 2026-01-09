namespace ACBindings;

// Turbine_GUID
public unsafe struct Turbine_GUID
{
    // Members
    public uint m_data1;
    public ushort m_data2;
    public ushort m_data3;
    public fixed byte m_data4[8];

    // Methods
    // bool __thiscall Turbine_GUID::Convert(Turbine_GUID*,const char*)
    public byte Convert(sbyte* pString) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Turbine_GUID, sbyte*, byte>)0x0040FD30)(ref this, pString);
    // int* __thiscall Turbine_GUID::ToString(unsigned __int16*,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Turbine_GUID, int*, int*>)0x0040FDE0)(ref this, a2);
}

