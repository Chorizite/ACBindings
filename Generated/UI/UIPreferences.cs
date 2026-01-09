namespace ACBindings;

// UIPreferences
public unsafe struct UIPreferences
{
    // Statics
    public static ACBindings.HashTable__PStringBase__sbyte__UIPreferenceItem_ptr* m_uiPreferences = (ACBindings.HashTable__PStringBase__sbyte__UIPreferenceItem_ptr*)0x0082514C;

    // Methods
    // char __cdecl UIPreferences::InqPreference(char**,_DWORD*,_DWORD*,_DWORD*)
    public static sbyte InqPreference(sbyte** a1, int* a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<sbyte**, int*, int*, int*, sbyte>)0x005DE940)(a1, a2, a3, a4);
    // char __cdecl UIPreferences::SetPreferenceRange(char**,int,int)
    public static sbyte SetPreferenceRange(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DE990)(a1, a2, a3);
    // char __cdecl UIPreferences::InqPreferenceRange(char**,int,int)
    public static sbyte InqPreferenceRange(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DE9E0)(a1, a2, a3);
    // char __cdecl UIPreferences::SetEnumChoices(char**,int)
    public static sbyte SetEnumChoices(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEA80)(a1, a2);
    // char __cdecl UIPreferences::InqEnumChoices(char**,int)
    public static sbyte InqEnumChoices(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEAC0)(a1, a2);
    // char __cdecl UIPreferences::ModifyPreference(char**,int)
    public static sbyte ModifyPreference(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEB90)(a1, a2);
    // char __cdecl UIPreferences::InqPreferenceValue(char**,int)
    public static sbyte InqPreferenceValue(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC90)(a1, a2);
    // char __cdecl UIPreferences::AttachPreference(char**,int,int,int,int)
    public static sbyte AttachPreference(sbyte** a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, int, int, sbyte>)0x005DEE50)(a1, a2, a3, a4, a5);
    // char __cdecl UIPreferences::DetachPreference(char**)
    public static sbyte DetachPreference(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, sbyte>)0x005DEF70)(a1);
}

