namespace ACBindings.Internal;

public unsafe struct SkillSystem
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005C96C0
    /// char __cdecl SkillSystem::InqSkillName(volatile LONG*,int*)</code>
    /// </summary>
    public static sbyte InqSkillName(int* key, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, sbyte>)0x005C96C0)(key, a2);

    /// <summary>
    /// <code>Offset: 0x005C9750
    /// char __cdecl SkillSystem::InqSkillDescription(volatile LONG*,int*)</code>
    /// </summary>
    public static sbyte InqSkillDescription(int* key, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, sbyte>)0x005C9750)(key, a2);

    /// <summary>
    /// <code>Offset: 0x005C97E0
    /// char __cdecl SkillSystem::InqAttributeName(int,int*)</code>
    /// </summary>
    public static sbyte InqAttributeName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x005C97E0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9880
    /// char __cdecl SkillSystem::InqAttribute2ndName(int,int*)</code>
    /// </summary>
    public static sbyte InqAttribute2ndName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x005C9880)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9920
    /// char __cdecl SkillSystem::InqSkillName(volatile LONG*,wchar_t**)</code>
    /// </summary>
    public static sbyte InqSkillName(int* a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<int*, System.IntPtr, sbyte>)0x005C9920)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9990
    /// char __cdecl SkillSystem::InqSkillFormula(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    public static sbyte InqSkillFormula(ACBindings.Internal.CLogonHeader.HandshakeWireData key) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, sbyte>)0x005C9990)(key);

    /// <summary>
    /// <code>Offset: 0x005C9C90
    /// char __cdecl SkillSystem::InqSkillFormula(unsigned int,wchar_t**)</code>
    /// </summary>
    public static sbyte InqSkillFormula(uint a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<uint, System.IntPtr, sbyte>)0x005C9C90)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9D00
    /// char __cdecl SkillSystem::InqSkillDescription(volatile LONG*,wchar_t**)</code>
    /// </summary>
    public static sbyte InqSkillDescription(int* a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<int*, System.IntPtr, sbyte>)0x005C9D00)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9D70
    /// char __cdecl SkillSystem::InqAttributeName(int,void**)</code>
    /// </summary>
    public static sbyte InqAttributeName(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9D70)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9E10
    /// char __cdecl SkillSystem::InqAttributeDescription(int,void**)</code>
    /// </summary>
    public static sbyte InqAttributeDescription(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9E10)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9EB0
    /// char __cdecl SkillSystem::InqAttribute2ndName(int,void**)</code>
    /// </summary>
    public static sbyte InqAttribute2ndName(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9EB0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005C9F50
    /// char __cdecl SkillSystem::InqAttribute2ndDescription(int,void**)</code>
    /// </summary>
    public static sbyte InqAttribute2ndDescription(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9F50)(a1, a2);
}

