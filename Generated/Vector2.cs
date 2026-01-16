namespace ACBindings.Internal;


/// <summary>Represents a two‑dimensional vector with X and Y components used for spatial positioning and calculations.</summary>
public unsafe struct Vector2
{
    // Members
    public float x;
    public float y;

    // Generated Constructor
    public Vector2(float x, float y) {
        _ConstructorInternal(x, y);
    }

    // Methods

    /// <summary>Initializes a new instance of Vector2 with the given X and Y values.
    /// <code>Offset: 0x0065E890
    /// void __thiscall Vector2::Vector2(Vector2*,float,float)</code>
    /// </summary>
    /// <param name="x">The X component of the vector.</param>
    /// <param name="y">The Y component of the vector.</param>
    public void _ConstructorInternal(float x, float y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector2, float, float, void>)0x0065E890)(ref this, x, y);
}

