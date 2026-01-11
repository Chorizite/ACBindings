namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0065E890
    /// void __thiscall Vector2::Vector2(Vector2*,float,float)</code>
    /// </summary>
    public void _ConstructorInternal(float x, float y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vector2, float, float, void>)0x0065E890)(ref this, x, y);
}

