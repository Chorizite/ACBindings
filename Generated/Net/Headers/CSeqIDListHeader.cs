namespace ACBindings;

// CSeqIDListHeader<4096,33>
public unsafe struct CSeqIDListHeader
{
    // Base Classes
    public ACBindings.COptionalHeader BaseClass_COptionalHeader; // ACBindings.COptionalHeader

    // Members
    public fixed uint m_IDs[115];

    // Methods
}

