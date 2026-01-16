namespace ACBindings.Internal;


/// <summary>
/// Provides utility functions that translate in‑game identifiers, status codes, and attributes into human‑readable strings used by the appraisal system, covering items, damage resistance, skills, lockpick difficulty, materials, and other descriptive data.
/// </summary>
public unsafe struct AppraisalSystem
{
    // Methods

    /// <summary>Converts a damage type bitmask into a slash‑separated string representation.
    /// <code>Offset: 0x005B52B0
    /// unsigned int __cdecl AppraisalSystem::DamageTypeToString(const DAMAGE_TYPE,char*,const unsigned int)</code>
    /// </summary>
    /// <param name="dtype">Bitmask specifying one or more damage types.</param>
    /// <param name="buf">Pointer to the buffer where the resulting string is written.</param>
    /// <param name="size">Size of the destination buffer in bytes.</param>
    /// <returns>Number of characters required, including the terminating null. If the supplied buffer size is insufficient, no text is written to <c>buf</c>.</returns>
    public static uint DamageTypeToString(ACBindings.Internal.DAMAGE_TYPE dtype, sbyte* buf, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DAMAGE_TYPE, sbyte*, uint, uint>)0x005B52B0)(dtype, buf, size);

    /// <summary>Converts a material type identifier into its corresponding name string.
    /// <code>Offset: 0x005B5690
    /// int __cdecl AppraisalSystem::InqMaterialName(int,int*)</code>
    /// </summary>
    /// <param name="materialId">Identifier of the material type to query.</param>
    /// <param name="nameOut">Pointer to an integer where the resulting name data will be stored.</param>
    /// <returns>Zero if conversion fails; non‑zero otherwise.</returns>
    public static int InqMaterialName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5690)(a1, a2);

    /// <summary>Transforms a lockpick success percentage into a descriptive difficulty string and writes it to the supplied output buffer.
    /// <code>Offset: 0x005B56B0
    /// int __cdecl AppraisalSystem::LockpickSuccessPercentToString(int,int*)</code>
    /// </summary>
    /// <param name="a1">Lockpick success probability as an integer percent (0‑100).</param>
    /// <param name="a2">Pointer to a character array where the resulting string is stored.</param>
    /// <returns>Non‑zero when the percentage was processed and the string set; zero if the input percent was negative or invalid.</returns>
    public static int LockpickSuccessPercentToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B56B0)(a1, a2);

    /// <summary>Retrieves the display name of a heritage group based on its identifier and places it into the supplied output buffer.
    /// <code>Offset: 0x005B57C0
    /// int __cdecl AppraisalSystem::InqHeritageGroupDisplayName(const char*,int*)</code>
    /// </summary>
    /// <param name="m_charbuffer">An integer value cast to a pointer that identifies the heritage group.</param>
    /// <param name="a2">Pointer to a string buffer where the resulting display name will be stored.</param>
    /// <returns>1 if a matching name was found and set; otherwise 0.</returns>
    public static int InqHeritageGroupDisplayName(sbyte* m_charbuffer, int* a2) => ((delegate* unmanaged[Cdecl]<sbyte*, int*, int>)0x005B57C0)(m_charbuffer, a2);

    /// <summary>Retrieves the display name for a specified gender identifier and writes it into the provided string reference, indicating success with a non-zero return value.
    /// <code>Offset: 0x005B5870
    /// int __cdecl AppraisalSystem::InqGenderDisplayName(int,int*)</code>
    /// </summary>
    /// <param name="a1">The integer identifier representing the gender whose display name is requested.</param>
    /// <param name="a2">Reference to receive the retrieved display name string; set only when a valid mapping exists.</param>
    /// <returns>Non-zero if a display name was successfully obtained; zero otherwise.</returns>
    public static int InqGenderDisplayName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5870)(a1, a2);

    /// <summary>Converts an attuned status code into its textual form, writing "Attuned" for valid codes 1 or 2.
    /// <code>Offset: 0x005B5900
    /// int __cdecl AppraisalSystem::AttunedStatusToString(int,int*)</code>
    /// </summary>
    /// <param name="a1">The status code to translate; only values 1 and 2 are recognized.</param>
    /// <param name="a2">Pointer to a string buffer where the resulting text is stored.</param>
    /// <returns>Returns 1 when conversion succeeds, otherwise returns 0 if the input code is out of range.</returns>
    public static int AttunedStatusToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5900)(a1, a2);

    /// <summary>Converts a bonded status code into its descriptive text, storing the result in the supplied buffer.
    /// <code>Offset: 0x005B5930
    /// int __cdecl AppraisalSystem::BondedStatusToString(int,int*)</code>
    /// </summary>
    /// <param name="a1">Integer representing the bonded status to translate.</param>
    /// <param name="a2">Pointer to a character buffer where the resulting string will be written.</param>
    /// <returns>Non‑zero (typically 1) if the status was recognized and the string set; zero otherwise.</returns>
    public static int BondedStatusToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5930)(a1, a2);

    /// <summary>Retrieves a workmanship adjective by index and writes it into the supplied string buffer, optionally appending “crafted” or “cut” for certain indices.
    /// <code>Offset: 0x005B5990
    /// int __cdecl AppraisalSystem::InqWorkmanshipAdjective(unsigned int,int*,int)</code>
    /// </summary>
    /// <param name="a1">Index of the adjective; values greater than 10 are clamped to 10.</param>
    /// <param name="a2">Pointer to a string object where the resulting adjective will be stored.</param>
    /// <param name="a3">When zero appends “crafted”; otherwise appends “cut” for indices 0‑4.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public static int InqWorkmanshipAdjective(uint a1, int* a2, int a3) => ((delegate* unmanaged[Cdecl]<uint, int*, int, int>)0x005B5990)(a1, a2, a3);

    /// <summary>Converts a handshake’s client version into a descriptive string (“Very Fast”, “Fast”, “Average”, “Slow” or “Very Slow”), appends authentication data to that string, and cleans up the handshake structure.
    /// <code>Offset: 0x005B5A20
    /// void __cdecl AppraisalSystem::WeaponTimeToString(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="a1">HandshakeWireData containing client version and authentication information.</param>
    public static void WeaponTimeToString(ACBindings.Internal.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, void>)0x005B5A20)(a1);

    /// <summary>Converts the skill identifier in the supplied handshake data to its textual name, storing the result back into the structure and appending the original numeric value.
    /// <code>Offset: 0x005B5AE0
    /// int __cdecl AppraisalSystem::SkillToString(CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="a1">Handshake data that contains the skill ID and buffer for output.</param>
    /// <returns>Non‑zero if the skill ID was recognized; zero otherwise.</returns>
    public static int SkillToString(ACBindings.Internal.CLogonHeader.HandshakeWireData a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, int>)0x005B5AE0)(a1);

    /// <summary>Builds a comma-separated list of covered body parts based on a priority bitmask and writes it into the supplied string buffer.
    /// <code>Offset: 0x005B5FE0
    /// int __cdecl AppraisalSystem::ClothingPriorityToString(int,int*)</code>
    /// </summary>
    /// <param name="a1">Bitmask indicating which clothing parts are present; each set bit corresponds to a specific body region such as head, chest, etc.</param>
    /// <param name="a2">Pointer to a string object where the resulting list will be stored.</param>
    /// <returns>Returns 1 if at least one body part was added to the string; otherwise returns 0.</returns>
    public static int ClothingPriorityToString(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B5FE0)(a1, a2);

    /// <summary>
    /// Creates a textual representation of a damage resistance value, including a qualitative rating derived from the multiplier and an optional armor effect note based on the type code in the handshake data.
    /// 
    /// <code>Offset: 0x005B6540
    /// int __cdecl AppraisalSystem::DamageResistanceToString(CLogonHeader::HandshakeWireData,float,int*)</code>
    /// </summary>
    /// <param name="a1">HandshakeWireData containing the damage type identifier used to determine the prefix and armor‑effect wording.</param>
    /// <param name="a2">Resistance multiplier; values map to ratings such as Poor, Below Average, Average, Above Average, Excellent, Unparalleled, or No effect when near zero.</param>
    /// <param name="a3">Pointer to a PStringBase&lt;char&gt; where the resulting description will be written.</param>
    /// <returns>1 if the string was constructed successfully; 0 if an unsupported damage type or armor code was encountered.</returns>
    public static int DamageResistanceToString(ACBindings.Internal.CLogonHeader.HandshakeWireData a1, float a2, int* a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CLogonHeader.HandshakeWireData, float, int*, int>)0x005B6540)(a1, a2, a3);

    /// <summary>Constructs a pluralized gem name string based on a material type identifier and writes it to an output buffer.
    /// <code>Offset: 0x005B68B0
    /// int __cdecl AppraisalSystem::InqPluralizedGemName(volatile LONG*,void**)</code>
    /// </summary>
    /// <param name="m_charbuffer">Pointer to the material type identifier used for lookup.</param>
    /// <param name="a2">Output pointer that receives the resulting string.</param>
    /// <returns>Always returns 1, indicating successful completion.</returns>
    public static int InqPluralizedGemName(int* m_charbuffer, void** a2) => ((delegate* unmanaged[Cdecl]<int*, void**, int>)0x005B68B0)(m_charbuffer, a2);

    /// <summary>Retrieves the display name for a creature and stores it in the supplied string, replacing spaces with underscores.
    /// <code>Offset: 0x005B6A90
    /// int __cdecl AppraisalSystem::InqCreatureDisplayName(int,int*)</code>
    /// </summary>
    /// <param name="a1">Identifier used to look up the creature's display name.</param>
    /// <param name="a2">Pointer to a string where the retrieved name will be stored.</param>
    /// <returns>Non‑zero if the name was found; zero otherwise.</returns>
    public static int InqCreatureDisplayName(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B6A90)(a1, a2);

    /// <summary>Constructs a gender‑heritage display name from the supplied gender ID, heritage group identifier or creature ID and writes the result into the HandshakeWireData.ClientVersion string buffer. Returns 1 on success, otherwise 0.
    /// <code>Offset: 0x005B6B90
    /// int __cdecl AppraisalSystem::InqGenderHeritageDisplay(int,const char*,int,CLogonHeader::HandshakeWireData)</code>
    /// </summary>
    /// <param name="a1">Gender identifier; when non‑zero the function retrieves its display name.</param>
    /// <param name="a2">Pointer to a heritage group identifier; used to obtain its display name if provided.</param>
    /// <param name="a3">Creature identifier; queried for its display name when no gender or heritage is supplied.</param>
    /// <param name="a4">HandshakeWireData structure whose ClientVersion string buffer will receive the constructed display name.</param>
    /// <returns>1 if a display name was successfully built and written to a4.ClientVersion, otherwise 0.</returns>
    public static int InqGenderHeritageDisplay(int a1, sbyte* a2, int a3, ACBindings.Internal.CLogonHeader.HandshakeWireData a4) => ((delegate* unmanaged[Cdecl]<int, sbyte*, int, ACBindings.Internal.CLogonHeader.HandshakeWireData, int>)0x005B6B90)(a1, a2, a3, a4);
}

