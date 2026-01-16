namespace ACBindings.Internal;


/// <summary>Provides access to skill data, including names, descriptions, formulas, and attribute information for the game’s skill system.</summary>
public unsafe struct SkillSystem
{
    // Methods

    /// <summary>Retrieves the name of a skill identified by the supplied key and copies it into the provided string buffer.
    /// <code>Offset: 0x005C96C0
    /// char __cdecl SkillSystem::InqSkillName(volatile LONG*,int*)</code>
    /// </summary>
    /// <param name="key">Pointer to the identifier for the desired skill.</param>
    /// <param name="a2">Destination buffer where the skill name will be stored.</param>
    /// <returns>Non‑zero if the skill was found and its name copied; zero otherwise.</returns>
    public static sbyte InqSkillName(int* key, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, sbyte>)0x005C96C0)(key, a2);

    /// <summary>Retrieves a skill’s textual description for the supplied key and writes it to the provided string parameter; returns 1 if successful, otherwise 0.
    /// <code>Offset: 0x005C9750
    /// char __cdecl SkillSystem::InqSkillDescription(volatile LONG*,int*)</code>
    /// </summary>
    /// <param name="key">Pointer to a long holding the skill identifier.</param>
    /// <param name="a2">Output string that receives the skill’s description.</param>
    /// <returns>1 when the description is successfully retrieved, or 0 on failure (null key, missing skill table or base).</returns>
    public static sbyte InqSkillDescription(int* key, int* a2) => ((delegate* unmanaged[Cdecl]<int*, int*, sbyte>)0x005C9750)(key, a2);

    /// <summary>
    /// Retrieves the human‑readable name of a skill attribute identified by its numeric ID and writes it into the supplied character buffer.
    /// 
    /// <code>Offset: 0x005C97E0
    /// char __cdecl SkillSystem::InqAttributeName(int,int*)</code>
    /// </summary>
    /// <param name="a1">Numeric identifier representing the desired attribute (e.g., 1 for Strength, 2 for Endurance).</param>
    /// <param name="a2">Pointer to a character array where the resolved attribute name will be stored.</param>
    /// <returns>1 if the ID is valid and the name was written; otherwise 0.</returns>
    public static sbyte InqAttributeName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x005C97E0)(a1, a2);

    /// <summary>Retrieves the display name for a secondary attribute identified by its numeric ID.
    /// <code>Offset: 0x005C9880
    /// char __cdecl SkillSystem::InqAttribute2ndName(int,int*)</code>
    /// </summary>
    /// <param name="a1">The numeric identifier of the attribute (e.g., 1 = Maximum Health, 2 = Health, etc.).</param>
    /// <param name="a2">Pointer to a buffer where the attribute name will be written.</param>
    /// <returns>Non‑zero if the ID was recognized and a name was set; zero otherwise.</returns>
    public static sbyte InqAttribute2ndName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, sbyte>)0x005C9880)(a1, a2);

    /// <summary>Retrieves the name of a skill identified by the input pointer and stores it in a wide‑character buffer.
    /// <code>Offset: 0x005C9920
    /// char __cdecl SkillSystem::InqSkillName(volatile LONG*,wchar_t**)</code>
    /// </summary>
    /// <param name="a1">Pointer to the identifier of the skill to query.</param>
    /// <param name="a2">Receives a pointer to the wide string containing the skill name.</param>
    /// <returns>Non‑zero if the skill name was successfully retrieved; zero otherwise.</returns>
    public static sbyte InqSkillName(int* a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<int*, System.IntPtr, sbyte>)0x005C9920)(a1, a2);

    /// <summary>Builds a readable representation of the specified skill’s formula and writes it into the supplied string buffer, returning a status flag.
    /// <code>Offset: 0x005C9990
    /// char __cdecl SkillSystem::InqSkillFormula(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="key">A <c>CLogonHeader::HandshakeWireData</c> instance whose <c>ClientVersion.m_buffer</c> field identifies the skill to format, and whose <c>cbAuthData</c> points to a string buffer that receives the formatted formula.</param>
    /// <returns>1 if the formula was successfully constructed and written; 0 otherwise (e.g., skill not found or required data missing).</returns>
    public static sbyte InqSkillFormula(ACBindings.Internal.CLogonHeader.HandshakeWireData key) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, sbyte>)0x005C9990)(key);

    /// <summary>Gets the skill formula string for the specified skill identifier and writes it into the provided wide‑character buffer.
    /// <code>Offset: 0x005C9C90
    /// char __cdecl SkillSystem::InqSkillFormula(unsigned int,wchar_t**)</code>
    /// </summary>
    /// <param name="a1">Skill identifier used to query the formula.</param>
    /// <param name="a2">Pointer to a wide‑character buffer that receives the formatted skill formula string; must be large enough to hold the result.</param>
    /// <returns>Non‑zero if the formula was successfully retrieved and written; zero otherwise.</returns>
    public static sbyte InqSkillFormula(uint a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<uint, System.IntPtr, sbyte>)0x005C9C90)(a1, a2);

    /// <summary>Retrieves the description text of a skill identified by the supplied id and writes it into the provided wide‑character buffer. Returns non‑zero if the description is successfully retrieved, otherwise zero.
    /// <code>Offset: 0x005C9D00
    /// char __cdecl SkillSystem::InqSkillDescription(volatile LONG*,wchar_t**)</code>
    /// </summary>
    /// <param name="a1">Pointer to the identifier of the skill whose description is requested.</param>
    /// <param name="a2">Output parameter that receives a pointer to a wide‑character string containing the skill description.</param>
    /// <returns>Non‑zero if the operation succeeds; zero on failure.</returns>
    public static sbyte InqSkillDescription(int* a1, System.IntPtr a2) => ((delegate* unmanaged[Cdecl]<int*, System.IntPtr, sbyte>)0x005C9D00)(a1, a2);

    /// <summary>Retrieves the human-readable name for a specified character attribute by its identifier.
    /// <code>Offset: 0x005C9D70
    /// char __cdecl SkillSystem::InqAttributeName(int,void**)</code>
    /// </summary>
    /// <param name="a1">Identifier of the attribute to query (e.g., 1=Strength, 2=Endurance).</param>
    /// <param name="a2">Pointer to receive the wide-string representation of the attribute name; may be set to NULL if the ID is invalid.</param>
    /// <returns>Non-zero when the attribute identifier is recognized and the name has been stored; zero otherwise.</returns>
    public static sbyte InqAttributeName(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9D70)(a1, a2);

    /// <summary>Retrieves the descriptive text for an attribute identified by its numeric code.
    /// <code>Offset: 0x005C9E10
    /// char __cdecl SkillSystem::InqAttributeDescription(int,void**)</code>
    /// </summary>
    /// <param name="a1">The attribute type index (e.g., 1 for muscular power, 2 for health).</param>
    /// <param name="a2">Pointer to a string buffer that will receive the UTF‑16 description of the attribute.</param>
    /// <returns>Non‑zero if the attribute code is valid and the description was written; zero otherwise.</returns>
    public static sbyte InqAttributeDescription(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9E10)(a1, a2);

    /// <summary>Retrieves the localized secondary name for an attribute based on its identifier and stores it in the supplied buffer.
    /// <code>Offset: 0x005C9EB0
    /// char __cdecl SkillSystem::InqAttribute2ndName(int,void**)</code>
    /// </summary>
    /// <param name="a1">Identifier of the attribute whose secondary name is requested.</param>
    /// <param name="a2">Pointer to a location where the function will store the resulting string pointer.</param>
    /// <returns>Non-zero if the attribute identifier was recognized; zero otherwise.</returns>
    public static sbyte InqAttribute2ndName(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9EB0)(a1, a2);

    /// <summary>Retrieves the secondary description for a given skill attribute and returns it via an output parameter.
    /// <code>Offset: 0x005C9F50
    /// char __cdecl SkillSystem::InqAttribute2ndDescription(int,void**)</code>
    /// </summary>
    /// <param name="a1">Identifier of the skill attribute whose description is requested.</param>
    /// <param name="a2">Pointer to store the resulting wide string description; must be non‑null when a description exists.</param>
    /// <returns>Non‑zero if a valid description was retrieved; zero otherwise.</returns>
    public static sbyte InqAttribute2ndDescription(int a1, void** a2) => ((delegate* unmanaged[Cdecl]<int, void**, sbyte>)0x005C9F50)(a1, a2);
}

