namespace ACBindings;

// Heading
public unsafe struct Heading
{
    // Statics
    public static ACBindings.Heading* ZERO = (ACBindings.Heading*)0x008F86A4;
    public static ACBindings.Heading* EPSILON = (ACBindings.Heading*)0x008F86A8;

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

