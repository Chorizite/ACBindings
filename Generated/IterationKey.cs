namespace ACBindings;

// IterationKey
public unsafe struct IterationKey
{
    // Child Types
    // IterationKey::SpecialKey
    public enum SpecialKey : byte
    {
        keyInvalid = 0x0,
        keyUnknown = 0x1,
        keyUnencrypted = 0x2
    }

    // Members
    public long m_Storage64;

    // Methods
}

