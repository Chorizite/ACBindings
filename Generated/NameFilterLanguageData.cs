namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00680330
    /// void __thiscall NameFilterLanguageData::Serialize(NameFilterLanguageData*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NameFilterLanguageData, ACBindings.Internal.Archive*, void>)0x00680330)(ref this, rArchive);
}

