namespace ACBindings.Internal;


/// <summary>Represents a heading angle expressed in degrees, used for directional calculations.</summary>
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

