namespace ACBindings.Internal;


/// <summary>Defines linguistic constraints applied during name filtering, such as maximum consecutive identical characters, vowel repetition limits, mandatory vowel occurrence in the prefix, and allowable vowel‑containing substrings. Includes additional allowed characters and compound letter group definitions for language‑specific rules.</summary>
public unsafe struct NameFilterLanguageData
{
    // Members
    public uint m_MaximumSameCharactersInARow;
    public uint m_MaximumVowelsInARow;
    public uint m_FirstNCharactersMustHaveAVowel;
    public uint m_VowelContainingSubstringLength;
    public ACBindings.Internal.PStringBase__ushort m_ExtraAllowedCharacters;
    public ACBindings.Internal.SmartArray___PStringBase__ushort m_CompoundLetterGroups;

    // Methods

    /// <summary>Serializes or deserializes NameFilterLanguageData fields to or from an Archive, handling alignment checks and conditional read/write based on archive flags.
    /// <code>Offset: 0x00680330
    /// void __thiscall NameFilterLanguageData::Serialize(NameFilterLanguageData*,Archive*)</code>
    /// </summary>
    /// <param name="rArchive">The Archive used for reading or writing the data.</param>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NameFilterLanguageData, ACBindings.Internal.Archive*, void>)0x00680330)(ref this, rArchive);
}

