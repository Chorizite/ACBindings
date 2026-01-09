namespace ACBindings;

// Matrix4
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
    // void __thiscall Matrix4::TransformVector_C(Matrix4*,const Vector3*,Vector3*)
    public void TransformVector_C(ACBindings.Vector3* src, ACBindings.Vector3* dst) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, ACBindings.Vector3*, ACBindings.Vector3*, void>)0x0043D940)(ref this, src, dst);
    // void __thiscall Matrix4::Multiply_C(Matrix4*,const Matrix4*,const Matrix4*)
    public void Multiply_C(ACBindings.Matrix4* a, ACBindings.Matrix4* b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, ACBindings.Matrix4*, ACBindings.Matrix4*, void>)0x0043D9C0)(ref this, a, b);
    // float __thiscall Matrix4::CalcDeterminant(Matrix4*)
    public float CalcDeterminant() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float>)0x0065DE70)(ref this);
    // void __thiscall Matrix4::Translate(Matrix4*,float,float,float)
    public void Translate(float x, float y, float z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float, float, float, void>)0x0065E030)(ref this, x, y, z);
    // void __thiscall Matrix4::Translate3(Matrix4*,float,float)
    public void Translate3(float x, float y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float, float, void>)0x0065E080)(ref this, x, y);
    // void __thiscall Matrix4::RotateX(Matrix4*,float)
    public void RotateX(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float, void>)0x0065E0D0)(ref this, radians);
    // void __thiscall Matrix4::RotateY(Matrix4*,float)
    public void RotateY(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float, void>)0x0065E120)(ref this, radians);
    // void __thiscall Matrix4::RotateZ(Matrix4*,float)
    public void RotateZ(float radians) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float, void>)0x0065E170)(ref this, radians);
    // void __thiscall Matrix4::Scale(Matrix4*,float,float,float)
    public void Scale(float x, float y, float z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, float, float, float, void>)0x0065E1C0)(ref this, x, y, z);
    // void __thiscall Matrix4::Adjoint(Matrix4*,const Matrix4*)
    public void Adjoint(ACBindings.Matrix4* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, ACBindings.Matrix4*, void>)0x0065E210)(ref this, src);
    // bool __cdecl Matrix4::AreEqual(const Matrix4*,const Matrix4*)
    public static byte AreEqual(ACBindings.Matrix4* mA, ACBindings.Matrix4* mB) => ((delegate* unmanaged[Cdecl]<ACBindings.Matrix4*, ACBindings.Matrix4*, byte>)0x0065E5A0)(mA, mB);
    // float __thiscall Matrix4::Inverse(Matrix4*,const Matrix4*)
    public float Inverse(ACBindings.Matrix4* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Matrix4, ACBindings.Matrix4*, float>)0x0065E760)(ref this, src);
}

