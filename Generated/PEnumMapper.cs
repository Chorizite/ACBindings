namespace ACBindings;

// PEnumMapper
public unsafe struct PEnumMapper
{
    // Child Types
    // PEnumMapper::NumberingType
    public enum NumberingType : byte
    {
        NORMAL_NUMBERING = 0x0,
        SEQUENTIAL_NUMBERING = 0x1,
        BITFIELD_NUMBERING = 0x2,
        BITFIELD32_NUMBERING = 0x3,
        BITFIELD64_NUMBERING = 0x4
    }

    // Members
    public ACBindings.SmartArray__PEnum m_enum_array;
    public ACBindings.SmartArray__PAlias m_alias_array;
    public ACBindings.EnumMapper m_enum_mapper;
    public ACBindings.AutoGrowHashTable__CaseInsensitiveStringBase__PStringBase__sbyte__uint m_all_mappings;
    public uint m_nextEnumValue;
    public uint m_inheritance_depth;
    public uint m_numbering_type;
    public byte m_allCode;

    // Methods
}

