namespace ACBindings.Internal;

public unsafe struct UIPreferences
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005DE940
    /// char __cdecl UIPreferences::InqPreference(char**,_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    public static sbyte InqPreference(sbyte** a1, int* a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<sbyte**, int*, int*, int*, sbyte>)0x005DE940)(a1, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x005DE990
    /// char __cdecl UIPreferences::SetPreferenceRange(char**,int,int)</code>
    /// </summary>
    public static sbyte SetPreferenceRange(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DE990)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005DE9E0
    /// char __cdecl UIPreferences::InqPreferenceRange(char**,int,int)</code>
    /// </summary>
    public static sbyte InqPreferenceRange(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DE9E0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005DEA30
    /// char __cdecl UIPreferences::InqPreferenceRange_1(char**,int,int)</code>
    /// </summary>
    public static sbyte InqPreferenceRange_1(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DEA30)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005DEA80
    /// char __cdecl UIPreferences::SetEnumChoices(char**,int)</code>
    /// </summary>
    public static sbyte SetEnumChoices(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEA80)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEAC0
    /// char __cdecl UIPreferences::InqEnumChoices(char**,int)</code>
    /// </summary>
    public static sbyte InqEnumChoices(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEAC0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEB90
    /// char __cdecl UIPreferences::ModifyPreference(char**,int)</code>
    /// </summary>
    public static sbyte ModifyPreference(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEB90)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEBD0
    /// char __cdecl UIPreferences::ModifyPreference_1(char**,int)</code>
    /// </summary>
    public static sbyte ModifyPreference_1(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEBD0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEC10
    /// char __cdecl UIPreferences::ModifyPreference_2(char**,int)</code>
    /// </summary>
    public static sbyte ModifyPreference_2(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC10)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEC50
    /// char __cdecl UIPreferences::ModifyPreference_3(char**,int)</code>
    /// </summary>
    public static sbyte ModifyPreference_3(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC50)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEC90
    /// char __cdecl UIPreferences::InqPreferenceValue(char**,int)</code>
    /// </summary>
    public static sbyte InqPreferenceValue(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC90)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DECD0
    /// char __cdecl UIPreferences::InqPreferenceValue_1(char**,int)</code>
    /// </summary>
    public static sbyte InqPreferenceValue_1(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DECD0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DED10
    /// char __cdecl UIPreferences::InqPreferenceValue_2(char**,int)</code>
    /// </summary>
    public static sbyte InqPreferenceValue_2(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DED10)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DED50
    /// char __cdecl UIPreferences::InqPreferenceValue_3(char**,int)</code>
    /// </summary>
    public static sbyte InqPreferenceValue_3(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DED50)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005DEE50
    /// char __cdecl UIPreferences::AttachPreference(char**,int,int,int,int)</code>
    /// </summary>
    public static sbyte AttachPreference(sbyte** a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, int, int, sbyte>)0x005DEE50)(a1, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005DEF70
    /// char __cdecl UIPreferences::DetachPreference(char**)</code>
    /// </summary>
    public static sbyte DetachPreference(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, sbyte>)0x005DEF70)(a1);
}

