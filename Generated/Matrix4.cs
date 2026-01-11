namespace ACBindings.Internal;

public unsafe struct Matrix4
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

    /// <summary>
    /// <code>Offset: 0x0043D940
    /// void __thiscall Matrix4::TransformVector_C(Matrix4*,const Vector3*,Vector3*)</code>
    /// </summary>
    public void TransformVector_C(ACBindings.Internal.Vector3* src, ACBindings.Internal.Vector3* dst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Vector3*, ACBindings.Internal.Vector3*, void>)0x0043D940)(ref this, src, dst);

    /// <summary>
    /// <code>Offset: 0x0043D9C0
    /// void __thiscall Matrix4::Multiply_C(Matrix4*,const Matrix4*,const Matrix4*)</code>
    /// </summary>
    public void Multiply_C(ACBindings.Internal.Matrix4* a, ACBindings.Internal.Matrix4* b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Matrix4*, ACBindings.Internal.Matrix4*, void>)0x0043D9C0)(ref this, a, b);

    /// <summary>
    /// <code>Offset: 0x0065DE70
    /// float __thiscall Matrix4::CalcDeterminant(Matrix4*)</code>
    /// </summary>
    public float CalcDeterminant() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float>)0x0065DE70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0065E030
    /// void __thiscall Matrix4::Translate(Matrix4*,float,float,float)</code>
    /// </summary>
    public void Translate(float x, float y, float z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, float, float, void>)0x0065E030)(ref this, x, y, z);

    /// <summary>
    /// <code>Offset: 0x0065E080
    /// void __thiscall Matrix4::Translate3(Matrix4*,float,float)</code>
    /// </summary>
    public void Translate3(float x, float y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, float, void>)0x0065E080)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x0065E0D0
    /// void __thiscall Matrix4::RotateX(Matrix4*,float)</code>
    /// </summary>
    public void RotateX(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, void>)0x0065E0D0)(ref this, radians);

    /// <summary>
    /// <code>Offset: 0x0065E120
    /// void __thiscall Matrix4::RotateY(Matrix4*,float)</code>
    /// </summary>
    public void RotateY(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, void>)0x0065E120)(ref this, radians);

    /// <summary>
    /// <code>Offset: 0x0065E170
    /// void __thiscall Matrix4::RotateZ(Matrix4*,float)</code>
    /// </summary>
    public void RotateZ(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, void>)0x0065E170)(ref this, radians);

    /// <summary>
    /// <code>Offset: 0x0065E1C0
    /// void __thiscall Matrix4::Scale(Matrix4*,float,float,float)</code>
    /// </summary>
    public void Scale(float x, float y, float z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, float, float, float, void>)0x0065E1C0)(ref this, x, y, z);

    /// <summary>
    /// <code>Offset: 0x0065E210
    /// void __thiscall Matrix4::Adjoint(Matrix4*,const Matrix4*)</code>
    /// </summary>
    public void Adjoint(ACBindings.Internal.Matrix4* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Matrix4*, void>)0x0065E210)(ref this, src);

    /// <summary>
    /// <code>Offset: 0x0065E5A0
    /// bool __cdecl Matrix4::AreEqual(const Matrix4*,const Matrix4*)</code>
    /// </summary>
    public static byte AreEqual(ACBindings.Internal.Matrix4* mA, ACBindings.Internal.Matrix4* mB) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Matrix4*, ACBindings.Internal.Matrix4*, byte>)0x0065E5A0)(mA, mB);

    /// <summary>
    /// <code>Offset: 0x0065E760
    /// float __thiscall Matrix4::Inverse(Matrix4*,const Matrix4*)</code>
    /// </summary>
    public float Inverse(ACBindings.Internal.Matrix4* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Matrix4, ACBindings.Internal.Matrix4*, float>)0x0065E760)(ref this, src);
}

