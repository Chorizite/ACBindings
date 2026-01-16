namespace ACBindings.Internal;


/// <summary>Represents a 4×4 matrix of floating-point values aligned for SIMD, enabling efficient affine transformations and projections in graphics or physics calculations.</summary>
/// <remarks>Fields are laid out to match SSE register boundaries, facilitating direct use with intrinsic instructions on x86 CPUs.</remarks>
public unsafe struct SSE4xMatrix
{
    // Members
    public float _11;
    public float _12;
    public float _13;
    public float _14;
    public float _21;
    public float _22;
    public float _23;
    public float _24;
    public float _31;
    public float _32;
    public float _33;
    public float _34;
    public float _41;
    public float _42;
    public float _43;
    public float _44;

    // Methods
}

