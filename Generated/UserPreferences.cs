namespace ACBindings;

// UserPreferences
public unsafe struct UserPreferences
{
    // Statics
    public static byte* sm_bTools = (byte*)0x00818AFC;
    public static byte* sm_bPrefsLoadedOK = (byte*)0x00818AFD;
    public static ACBindings.PStringBase__sbyte* sm_strDefaultFile = (ACBindings.PStringBase__sbyte*)0x00838188;

    // Methods
    // char __thiscall UserPreferences::RegisterPreference(void*,volatile LONG**,int*,void*,char*,int,int)
    public sbyte RegisterPreference(int** String, int* a3, System.IntPtr a4, sbyte* SubStr, int a6, int a7) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UserPreferences, int**, int*, System.IntPtr, sbyte*, int, int, sbyte>)0x004020E0)(ref this, String, a3, a4, SubStr, a6, a7);
    // bool __cdecl UserPreferences::IsPreferenceRegistered(volatile LONG**,int)
    public static byte IsPreferenceRegistered(int** a1, int a2) => ((delegate* unmanaged[Cdecl]<int**, int, byte>)0x004370C0)(a1, a2);
    // char __cdecl UserPreferences::FindPreference(volatile LONG**,int*)
    public static sbyte FindPreference(int** a1, int* String) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00437140)(a1, String);
    // char __cdecl UserPreferences::InqValue(volatile LONG**,_BYTE*)
    public static sbyte InqValue(int** a1, byte* a2) => ((delegate* unmanaged[Cdecl]<int**, byte*, sbyte>)0x004371C0)(a1, a2);
    // char __cdecl UserPreferences::InqValue(volatile LONG**,_DWORD*)
    public static sbyte InqValue(int** a1, int* a2) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00437280)(a1, a2);
    // char __cdecl UserPreferences::SetValue(volatile LONG**,int*)
    public static sbyte SetValue(int** a1, int* a2) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00437D20)(a1, a2);
    // void __cdecl UserPreferences::Cleanup()
    public static void Cleanup() => ((delegate* unmanaged[Cdecl]<void>)0x00437F60)();
    // bool __cdecl UserPreferences::FindDefaultFile(int*)
    public static byte FindDefaultFile(int* a1) => ((delegate* unmanaged[Cdecl]<int*, byte>)0x00437FE0)(a1);
    // bool __cdecl UserPreferences::Save()
    public static byte Save() => ((delegate* unmanaged[Cdecl]<byte>)0x00438230)();
    // bool __cdecl UserPreferences::ConsoleCommand_SavePreferences()
    public static byte ConsoleCommand_SavePreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x004386C0)();
    // char __cdecl UserPreferences::InqChoiceValues(volatile LONG**,_DWORD*)
    public static sbyte InqChoiceValues(int** a1, int* a2) => ((delegate* unmanaged[Cdecl]<int**, int*, sbyte>)0x00438750)(a1, a2);
    // char __cdecl UserPreferences::InqChoiceStrings(volatile LONG**,int)
    public static sbyte InqChoiceStrings(int** a1, int a2) => ((delegate* unmanaged[Cdecl]<int**, int, sbyte>)0x00438860)(a1, a2);
    // bool __cdecl UserPreferences::Load()
    public static byte Load() => ((delegate* unmanaged[Cdecl]<byte>)0x00438940)();
    // bool __cdecl UserPreferences::ConsoleCommand_LoadPreferences()
    public static byte ConsoleCommand_LoadPreferences() => ((delegate* unmanaged[Cdecl]<byte>)0x00438F50)();
    // char __cdecl UserPreferences::Initialize(volatile LONG*,volatile LONG**)
    public static sbyte Initialize(int* a1, int** a2) => ((delegate* unmanaged[Cdecl]<int*, int**, sbyte>)0x00438FE0)(a1, a2);
}

