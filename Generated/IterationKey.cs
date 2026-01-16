namespace ACBindings.Internal;


/// <summary>Represents a 64‑bit value that serves as an identifier for iteration processes throughout the application.</summary>
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

