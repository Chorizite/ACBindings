namespace ACBindings;

// CMaterial
public unsafe struct CMaterial
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // CMaterial_vtbl
    public unsafe struct CMaterial_vtbl
    {
        // Members
        public System.IntPtr CMaterial_dtor_0; // function pointer

        // Methods
    }

    // Members
    public int has_alpha;
    public ACBindings._D3DMATERIAL9 d3d_material;

    // Generated Constructor
    public CMaterial() {
        _ConstructorInternal();
    }
    public CMaterial(ACBindings.CMaterial* material) {
        _ConstructorInternal(material);
    }

    // Methods
    // void __thiscall CMaterial::CheckAlphaValues(CMaterial*)
    public void CheckAlphaValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, void>)0x0053A3E0)(ref this);
    // void __thiscall CMaterial::SetTranslucencySimple(CMaterial*,float)
    public void SetTranslucencySimple(float trans) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, float, void>)0x0053A430)(ref this, trans);
    // float __thiscall CMaterial::GetTranslucencySimple(CMaterial*)
    public float GetTranslucencySimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, float>)0x0053A450)(ref this);
    // void __thiscall CMaterial::SetLuminositySimple(CMaterial*,float)
    public void SetLuminositySimple(float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, float, void>)0x0053A460)(ref this, lumi);
    // float __thiscall CMaterial::GetLuminositySimple(CMaterial*)
    public float GetLuminositySimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, float>)0x0053A480)(ref this);
    // void __thiscall CMaterial::SetDiffuseSimple(CMaterial*,float)
    public void SetDiffuseSimple(float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, float, void>)0x0053A490)(ref this, diffuse);
    // void __thiscall CMaterial::CMaterial(CMaterial*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, void>)0x0053A4B0)(ref this);
    // void __thiscall CMaterial::CMaterial(CMaterial*,const CMaterial*)
    public void _ConstructorInternal(ACBindings.CMaterial* material) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, ACBindings.CMaterial*, void>)0x0053A500)(ref this, material);
    // float __thiscall CMaterial::GetColorDiffuseSimple(CMaterial*)
    public float GetColorDiffuseSimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMaterial, float>)0x0069F540)(ref this);
}

