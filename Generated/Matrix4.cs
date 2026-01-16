namespace ACBindings.Internal;


/// <summary>Represents a 4×4 homogeneous transformation matrix used for performing translations, rotations, scalings, and perspective projections on points in 3D space.</summary>
public unsafe struct Matrix4
{
    // Statics
    public static ACBindings.Internal.Matrix4* NULL_MATRIX4 = (ACBindings.Internal.Matrix4*)0x008F8650;

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

    /// <summary>Transforms a 3‑D vector by the matrix, performing a homogeneous divide to produce correct coordinates in view space.
    /// <code>Offset: 0x0043D940
    /// void __thiscall Matrix4::TransformVector_C(Matrix4*,const Vector3*,Vector3*)</code>
    /// </summary>
    /// <param name="src">The input vector to transform.</param>
    /// <param name="dst">Receives the transformed vector.</param>
    public void TransformVector_C(ACBindings.Internal.Vector3* src, ACBindings.Internal.Vector3* dst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, void>)0x0043D940)(ref this, src, dst);

    /// <summary>Multiplies two 4×4 matrices and stores the result in this instance following standard row‑major multiplication rules.
    /// <code>Offset: 0x0043D9C0
    /// void __thiscall Matrix4::Multiply_C(Matrix4*,const Matrix4*,const Matrix4*)</code>
    /// </summary>
    /// <param name="a">The first source matrix (left operand).</param>
    /// <param name="b">The second source matrix (right operand).</param>
    public void Multiply_C(ACBindings.Internal.Matrix4* a, ACBindings.Internal.Matrix4* b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Matrix4*, ACBindings.Internal.Matrix4*, void>)0x0043D9C0)(ref this, a, b);

    /// <summary>Computes the determinant of a 4×4 matrix stored in the current Matrix4 instance.
    /// <code>Offset: 0x0065DE70
    /// float __thiscall Matrix4::CalcDeterminant(Matrix4*)</code>
    /// </summary>
    /// <returns>A floating‑point value representing the determinant of the matrix.</returns>
    public float CalcDeterminant() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float>)0x0065DE70)(ref this);

    /// <summary>Sets this matrix to a pure translation transform with offsets (x, y, z).
    /// <code>Offset: 0x0065E030
    /// void __thiscall Matrix4::Translate(Matrix4*,float,float,float)</code>
    /// </summary>
    /// <param name="x">Translation offset along the X axis.</param>
    /// <param name="y">Translation offset along the Y axis.</param>
    /// <param name="z">Translation offset along the Z axis.</param>
    public void Translate(float x, float y, float z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, float, float, void>)0x0065E030)(ref this, x, y, z);

    /// <summary>Initializes a 4×4 matrix as an identity transform and sets its translation components along X and Y to the given offsets.
    /// <code>Offset: 0x0065E080
    /// void __thiscall Matrix4::Translate3(Matrix4*,float,float)</code>
    /// </summary>
    /// <param name="x">Translation offset in the X direction.</param>
    /// <param name="y">Translation offset in the Y direction.</param>
    public void Translate3(float x, float y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, float, void>)0x0065E080)(ref this, x, y);

    /// <summary>Transforms the matrix into a rotation about the X‑axis by the specified angle (in radians).
    /// <code>Offset: 0x0065E0D0
    /// void __thiscall Matrix4::RotateX(Matrix4*,float)</code>
    /// </summary>
    /// <param name="radians">The rotation angle in radians.</param>
    public void RotateX(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, void>)0x0065E0D0)(ref this, radians);

    /// <summary>Sets the matrix elements to represent a rotation about the Y‑axis by the specified angle in radians.
    /// <code>Offset: 0x0065E120
    /// void __thiscall Matrix4::RotateY(Matrix4*,float)</code>
    /// </summary>
    /// <param name="radians">The rotation angle, in radians.</param>
    public void RotateY(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, void>)0x0065E120)(ref this, radians);

    /// <summary>Sets the matrix to a rotation around the Z-axis by the given angle in radians.
    /// <code>Offset: 0x0065E170
    /// void __thiscall Matrix4::RotateZ(Matrix4*,float)</code>
    /// </summary>
    /// <param name="this">The Matrix4 instance to be configured as a Z‑axis rotation matrix.</param>
    /// <param name="radians">Angle of rotation, measured in radians.</param>
    public void RotateZ(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, void>)0x0065E170)(ref this, radians);

    /// <summary>Sets the matrix to a scaling transformation with scale factors along the X, Y, and Z axes.
    /// <code>Offset: 0x0065E1C0
    /// void __thiscall Matrix4::Scale(Matrix4*,float,float,float)</code>
    /// </summary>
    /// <param name="x">Scale factor for the X axis.</param>
    /// <param name="y">Scale factor for the Y axis.</param>
    /// <param name="z">Scale factor for the Z axis.</param>
    public void Scale(float x, float y, float z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, float, float, void>)0x0065E1C0)(ref this, x, y, z);

    /// <summary>Computes the adjugate (classical adjoint) of a 4x4 matrix and writes the result into the current matrix instance.
    /// <code>Offset: 0x0065E210
    /// void __thiscall Matrix4::Adjoint(Matrix4*,const Matrix4*)</code>
    /// </summary>
    /// <param name="src">The source matrix from which to compute the adjugate.</param>
    public void Adjoint(ACBindings.Internal.Matrix4* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Matrix4*, void>)0x0065E210)(ref this, src);

    /// <summary>Compares two 4×4 matrices element‑by‑element, returning true when every pair of entries differs by at most a small tolerance.
    /// <code>Offset: 0x0065E5A0
    /// bool __cdecl Matrix4::AreEqual(const Matrix4*,const Matrix4*)</code>
    /// </summary>
    /// <param name="mA">First matrix to compare.</param>
    /// <param name="mB">Second matrix to compare.</param>
    /// <returns>True if all corresponding elements differ by no more than 0.00019999999, otherwise false.</returns>
    public static byte AreEqual(ACBindings.Internal.Matrix4* mA, ACBindings.Internal.Matrix4* mB) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*, ACBindings.Internal.Matrix4*, byte>)0x0065E5A0)(mA, mB);

    /// <summary>Computes the inverse of the source matrix and stores it in the current instance. Returns the determinant of the original matrix, or 0 if the matrix is singular.
    /// <code>Offset: 0x0065E760
    /// float __thiscall Matrix4::Inverse(Matrix4*,const Matrix4*)</code>
    /// </summary>
    /// <param name="src">Matrix to be inverted.</param>
    /// <returns>Determinant of the input matrix; zero indicates a non‑invertible matrix.</returns>
    public float Inverse(ACBindings.Internal.Matrix4* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Matrix4*, float>)0x0065E760)(ref this, src);
}

