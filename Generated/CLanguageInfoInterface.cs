namespace ACBindings.Internal;


/// <summary>Offers a global language information interface that exposes formatting rules, meta‑letters, and numeral data for the current locale. It serves as a singleton wrapper around CLanguageInfo instances, providing thread‑safe access to localization resources.</summary>
public unsafe struct CLanguageInfoInterface
{
    // Statics
    public static ACBindings.Internal.CLanguageInfoInterface** m_instance = (ACBindings.Internal.CLanguageInfoInterface**)0x00837CC8;

    // Members
    public ACBindings.Internal.CLanguageInfo* m_pLanguageInfo;

    // Methods

    /// <summary>Retrieves the number of decimal digits used by the current language.
    /// <code>Offset: 0x004220E0
    /// bool __thiscall CLanguageInfoInterface::GetNumDecDigits(CLanguageInfoInterface*,unsigned __int16*)</code>
    /// </summary>
    /// <param name="digits">Pointer that receives the digit count when available.</param>
    /// <returns>True if the language information is present; otherwise, false.</returns>
    public byte GetNumDecDigits(ushort* digits) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, ushort*, byte>)0x004220E0)(ref this, digits);

    /// <summary>Retrieves whether numbers are displayed with a leading zero from the associated language information.
    /// <code>Offset: 0x00422100
    /// bool __thiscall CLanguageInfoInterface::GetLeadingZero(CLanguageInfoInterface*,bool*)</code>
    /// </summary>
    /// <param name="zero">Receives true if leading‑zero formatting is enabled; otherwise false.</param>
    /// <returns>True when language information exists and the flag was retrieved, otherwise false.</returns>
    public byte GetLeadingZero(byte* zero) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, byte*, byte>)0x00422100)(ref this, zero);

    /// <summary>Retrieves the base identifier from the associated CLanguageInfo object.
    /// <code>Offset: 0x00422120
    /// bool __thiscall CLanguageInfoInterface::GetBase(CLanguageInfoInterface*,unsigned __int16*)</code>
    /// </summary>
    /// <param name="base">Pointer to store the retrieved base value.</param>
    /// <returns>True when a valid CLanguageInfo exists and the base is written; otherwise false.</returns>
    public byte GetBase(ushort* base_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, ushort*, byte>)0x00422120)(ref this, base_);

    /// <summary>Retrieves the grouping size for the associated language.
    /// <code>Offset: 0x00422140
    /// bool __thiscall CLanguageInfoInterface::GetGroupingSize(CLanguageInfoInterface*,unsigned __int16*)</code>
    /// </summary>
    /// <param name="size">Receives the grouping size when the operation succeeds.</param>
    /// <returns>True if language information is available; otherwise, false.</returns>
    public byte GetGroupingSize(ushort* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, ushort*, byte>)0x00422140)(ref this, size);

    /// <summary>Determines whether a given integer value should be treated as singular in the current language context.
    /// <code>Offset: 0x00422160
    /// bool __thiscall CLanguageInfoInterface::IsNumberSingular(CLanguageInfoInterface*,int)</code>
    /// </summary>
    /// <param name="num">The numeric value to evaluate for singularity.</param>
    /// <returns>True if the number is considered singular according to language rules; otherwise, false.</returns>
    public byte IsNumberSingular(int num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int, byte>)0x00422160)(ref this, num);

    /// <summary>Initializes the language info interface by allocating storage for a database object reference and obtaining the corresponding DBObj instance.
    /// <code>Offset: 0x004221C0
    /// bool __cdecl CLanguageInfoInterface::Startup()</code>
    /// </summary>
    /// <returns>True when the initialization succeeds; otherwise, false.</returns>
    public static byte Startup() => ((delegate* unmanaged[Cdecl]<byte>)0x004221C0)();

    /// <summary>Shuts down the global CLanguageInfoInterface instance, releasing associated language resources and destroying the singleton object.
    /// <code>Offset: 0x00422210
    /// bool __cdecl CLanguageInfoInterface::Shutdown()</code>
    /// </summary>
    /// <returns>True when the shutdown completes successfully.</returns>
    public static byte Shutdown() => ((delegate* unmanaged[Cdecl]<byte>)0x00422210)();

    /// <summary>Ensures the provided numerals handle refers to the current language’s numerals, updating it if necessary and adjusting reference counts.
    /// <code>Offset: 0x00422510
    /// char __thiscall CLanguageInfoInterface::GetNumerals(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer that receives the numerals handle for this language; updated only when it differs from the existing value.</param>
    /// <returns>Non-zero (true) when the language information is available; otherwise zero (false).</returns>
    public sbyte GetNumerals(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, sbyte>)0x00422510)(ref this, a2);

    /// <summary>Updates an optional language information reference handle when the underlying data changes and reports success.
    /// <code>Offset: 0x00422560
    /// char __thiscall CLanguageInfoInterface::GetGroupingSeperator(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a cache handle that receives the current language info object; updated only if it differs from the interface’s stored value.</param>
    /// <returns>Non‑zero (1) if the interface instance is valid; zero if the instance pointer is null.</returns>
    public sbyte GetGroupingSeperator(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, sbyte>)0x00422560)(ref this, a2);

    /// <summary>Retrieves the language's decimal separator and updates an external reference to it.
    /// <code>Offset: 0x004225B0
    /// char __thiscall CLanguageInfoInterface::GetDecimalSeperator(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer that will receive a reference to the decimal separator string or object; its reference count is adjusted by this call.</param>
    /// <returns>Non‑zero if the decimal separator was successfully retrieved; zero otherwise.</returns>
    public sbyte GetDecimalSeperator(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, sbyte>)0x004225B0)(ref this, a2);

    /// <summary>Retrieves the negative‑number formatting information for the current language, updating the supplied format reference if necessary.
    /// <code>Offset: 0x00422600
    /// char __thiscall CLanguageInfoInterface::GetNegNumFormat(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the negative number format object; its reference count is adjusted by the method.</param>
    /// <returns>Non‑zero if a valid language interface exists and the format was obtained; zero otherwise.</returns>
    public sbyte GetNegNumFormat(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, sbyte>)0x00422600)(ref this, a2);

    /// <summary>Retrieves the current male meta‑letters handle for the language information object, updating a supplied variable while maintaining proper reference counts.
    /// <code>Offset: 0x00422650
    /// char __thiscall CLanguageInfoInterface::GetMaleMetaLetters(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer that holds the current male meta‑letters handle; updated with the object's stored value if it differs from the existing one.</param>
    /// <returns>1 if the operation succeeded; 0 if the language info object is null.</returns>
    public sbyte GetMaleMetaLetters(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, sbyte>)0x00422650)(ref this, a2);

    /// <summary>Provides access to a language’s female meta‑letters data, ensuring the supplied reference points to the current resource and handling reference counting appropriately.
    /// <code>Offset: 0x004226A0
    /// char __thiscall CLanguageInfoInterface::GetFemaleMetaLetters(int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an identifier that will be updated to refer to the current language’s female meta‑letters resource. The caller should provide a valid pointer; it is modified by this method.</param>
    /// <returns>Non‑zero if the operation succeeds (the object and resource are available); zero otherwise.</returns>
    public sbyte GetFemaleMetaLetters(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, sbyte>)0x004226A0)(ref this, a2);

    /// <summary>Retrieves the treasure metadata letter objects for the current language and updates the supplied pointers, managing reference counts appropriately.
    /// <code>Offset: 0x004226F0
    /// char __thiscall CLanguageInfoInterface::GetTreasureMetaLetters(_DWORD*,int*,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive a reference to the first meta‑letter object.</param>
    /// <param name="a3">Pointer to receive a reference to the second meta‑letter object.</param>
    /// <param name="a4">Pointer to receive a reference to the third meta‑letter object.</param>
    /// <returns>Non‑zero if the operation succeeded; zero otherwise.</returns>
    public sbyte GetTreasureMetaLetters(int* a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLanguageInfoInterface, int*, int*, int*, sbyte>)0x004226F0)(ref this, a2, a3, a4);
}

