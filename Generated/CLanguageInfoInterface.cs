namespace ACBindings;

// CLanguageInfoInterface
public unsafe struct CLanguageInfoInterface
{
    // Statics
    public static ACBindings.CLanguageInfoInterface* m_instance = (ACBindings.CLanguageInfoInterface*)0x00837CC8;

    // Members
    public ACBindings.CLanguageInfo* m_pLanguageInfo;

    // Methods
    // bool __thiscall CLanguageInfoInterface::GetNumDecDigits(CLanguageInfoInterface*,unsigned __int16*)
    public byte GetNumDecDigits(ushort* digits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, ushort*, byte>)0x004220E0)(ref this, digits);
    // bool __thiscall CLanguageInfoInterface::GetLeadingZero(CLanguageInfoInterface*,bool*)
    public byte GetLeadingZero(byte* zero) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, byte*, byte>)0x00422100)(ref this, zero);
    // bool __thiscall CLanguageInfoInterface::GetBase(CLanguageInfoInterface*,unsigned __int16*)
    public byte GetBase(ushort* base_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, ushort*, byte>)0x00422120)(ref this, base_);
    // bool __thiscall CLanguageInfoInterface::GetGroupingSize(CLanguageInfoInterface*,unsigned __int16*)
    public byte GetGroupingSize(ushort* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, ushort*, byte>)0x00422140)(ref this, size);
    // bool __thiscall CLanguageInfoInterface::IsNumberSingular(CLanguageInfoInterface*,int)
    public byte IsNumberSingular(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int, byte>)0x00422160)(ref this, num);
    // bool __cdecl CLanguageInfoInterface::Startup()
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x004221C0)();
    // bool __cdecl CLanguageInfoInterface::Shutdown()
    public static byte Shutdown() => ((delegate* unmanaged[Cdecl]<byte>)0x00422210)();
    // char __thiscall CLanguageInfoInterface::GetNumerals(int*,int*)
    public sbyte GetNumerals(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, sbyte>)0x00422510)(ref this, a2);
    // char __thiscall CLanguageInfoInterface::GetGroupingSeperator(int*,int*)
    public sbyte GetGroupingSeperator(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, sbyte>)0x00422560)(ref this, a2);
    // char __thiscall CLanguageInfoInterface::GetDecimalSeperator(int*,int*)
    public sbyte GetDecimalSeperator(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, sbyte>)0x004225B0)(ref this, a2);
    // char __thiscall CLanguageInfoInterface::GetNegNumFormat(int*,int*)
    public sbyte GetNegNumFormat(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, sbyte>)0x00422600)(ref this, a2);
    // char __thiscall CLanguageInfoInterface::GetMaleMetaLetters(int*,int*)
    public sbyte GetMaleMetaLetters(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, sbyte>)0x00422650)(ref this, a2);
    // char __thiscall CLanguageInfoInterface::GetFemaleMetaLetters(int*,int*)
    public sbyte GetFemaleMetaLetters(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, sbyte>)0x004226A0)(ref this, a2);
    // char __thiscall CLanguageInfoInterface::GetTreasureMetaLetters(_DWORD*,int*,int*,int*)
    public sbyte GetTreasureMetaLetters(int* a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLanguageInfoInterface, int*, int*, int*, sbyte>)0x004226F0)(ref this, a2, a3, a4);
}

