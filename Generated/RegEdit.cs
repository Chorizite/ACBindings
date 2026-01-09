namespace ACBindings;

// RegEdit
public unsafe struct RegEdit
{
    // Methods
    // bool __stdcall RegEdit::QueryStrValue(const CHAR**,LPCSTR*,LPBYTE,DWORD,HKEY)
    public static byte QueryStrValue(sbyte** Type, sbyte** a2, byte* lpData, uint cbData, int hKey) => ((delegate* unmanaged[Stdcall]<sbyte**, sbyte**, byte*, uint, int, byte>)0x0040E120)(Type, a2, lpData, cbData, hKey);
    // bool __stdcall RegEdit::QueryWStrValue(int*,int,int,int,int)
    public static byte QueryWStrValue(int* a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Stdcall]<int*, int, int, int, int, byte>)0x0040E1A0)(a1, a2, a3, a4, a5);
    // bool __thiscall RegEdit::DeleteValue(HKEY,const CHAR**,LPCSTR*,HKEY)
    public byte DeleteValue(sbyte** a2, sbyte** a3, int hKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RegEdit, sbyte**, sbyte**, int, byte>)0x0040E220)(ref this, a2, a3, hKey);
    // bool __stdcall RegEdit::QueryStrValue(const CHAR**,LPCSTR*,void**,HKEY)
    public static byte QueryStrValue(sbyte** Type, sbyte** a2, void** a3, int hKey) => ((delegate* unmanaged[Stdcall]<sbyte**, sbyte**, void**, int, byte>)0x0040E280)(Type, a2, a3, hKey);
    // bool __stdcall RegEdit::QueryWStrValue(int*,int,void**,int)
    public static byte QueryWStrValue(int* a1, int a2, void** a3, int a4) => ((delegate* unmanaged[Stdcall]<int*, int, void**, int, byte>)0x0040E2E0)(a1, a2, a3, a4);
}

