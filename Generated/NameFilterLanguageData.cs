namespace ACBindings;

// NameFilterLanguageData
public unsafe struct NameFilterLanguageData
{
    // Members
    public uint m_MaximumSameCharactersInARow;
    public uint m_MaximumVowelsInARow;
    public uint m_FirstNCharactersMustHaveAVowel;
    public uint m_VowelContainingSubstringLength;
    public ACBindings.PStringBase__ushort m_ExtraAllowedCharacters;
    public ACBindings.SmartArray__PStringBase__ushort m_CompoundLetterGroups;

    // Methods
    // void __thiscall NameFilterLanguageData::Serialize(NameFilterLanguageData*,Archive*)
    public void Serialize(ACBindings.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NameFilterLanguageData, ACBindings.Archive*, void>)0x00680330)(ref this, rArchive);
}

