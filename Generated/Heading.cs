namespace ACBindings.Internal;

public unsafe struct Heading
{
    // Child Types
    // Heading::unit_type
    public enum unit_type : byte
    {
        DEGREES = 0x0,
        RADIANS = 0x1
    }

    // Members
    public float m_degrees;

    // Methods
}

