namespace ACBindings.Internal;

public unsafe struct CMaterial
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CMaterial_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CMaterial*, void> CMaterial_dtor_0; // function pointer

        // Methods
    }

    // Members
    public int has_alpha;
    public ACBindings.Internal._D3DMATERIAL9 d3d_material;

    // Generated Constructor
    public CMaterial() {
        _ConstructorInternal();
    }
    public CMaterial(ACBindings.Internal.CMaterial* material) {
        _ConstructorInternal(material);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053A3E0
    /// void __thiscall CMaterial::CheckAlphaValues(CMaterial*)</code>
    /// </summary>
    public void CheckAlphaValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, void>)0x0053A3E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053A430
    /// void __thiscall CMaterial::SetTranslucencySimple(CMaterial*,float)</code>
    /// </summary>
    public void SetTranslucencySimple(float trans) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float, void>)0x0053A430)(ref this, trans);

    /// <summary>
    /// <code>Offset: 0x0053A450
    /// float __thiscall CMaterial::GetTranslucencySimple(CMaterial*)</code>
    /// </summary>
    public float GetTranslucencySimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float>)0x0053A450)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053A460
    /// void __thiscall CMaterial::SetLuminositySimple(CMaterial*,float)</code>
    /// </summary>
    public void SetLuminositySimple(float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float, void>)0x0053A460)(ref this, lumi);

    /// <summary>
    /// <code>Offset: 0x0053A480
    /// float __thiscall CMaterial::GetLuminositySimple(CMaterial*)</code>
    /// </summary>
    public float GetLuminositySimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float>)0x0053A480)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053A490
    /// void __thiscall CMaterial::SetDiffuseSimple(CMaterial*,float)</code>
    /// </summary>
    public void SetDiffuseSimple(float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float, void>)0x0053A490)(ref this, diffuse);

    /// <summary>
    /// <code>Offset: 0x0053A4B0
    /// void __thiscall CMaterial::CMaterial(CMaterial*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, void>)0x0053A4B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053A500
    /// void __thiscall CMaterial::CMaterial(CMaterial*,const CMaterial*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CMaterial* material) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, ACBindings.Internal.CMaterial*, void>)0x0053A500)(ref this, material);

    /// <summary>
    /// <code>Offset: 0x0069F540
    /// float __thiscall CMaterial::GetColorDiffuseSimple(CMaterial*)</code>
    /// </summary>
    public float GetColorDiffuseSimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float>)0x0069F540)(ref this);
}

