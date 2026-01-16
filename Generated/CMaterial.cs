namespace ACBindings.Internal;


/// <summary>Encapsulates a Direct3D 9 material and manages its lifetime through reference counting, with an indicator for alpha transparency.</summary>
public unsafe struct CMaterial
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CMaterial_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CMaterial*, void> CMaterial_dtor_0; // function pointer

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

    /// <summary>Checks the material's ambient, diffuse, specular, and emissive color components for transparency and updates has_alpha accordingly.
    /// <code>Offset: 0x0053A3E0
    /// void __thiscall CMaterial::CheckAlphaValues(CMaterial*)</code>
    /// </summary>
    public void CheckAlphaValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, void>)0x0053A3E0)(ref this);

    /// <summary>Adjusts the material's ambient, diffuse, specular, and emissive alpha values according to the specified translucency level.
    /// <code>Offset: 0x0053A430
    /// void __thiscall CMaterial::SetTranslucencySimple(CMaterial*,float)</code>
    /// </summary>
    /// <param name="trans">The desired transparency factor (0 = opaque, 1 = fully transparent).</param>
    public void SetTranslucencySimple(float trans) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float, void>)0x0053A430)(ref this, trans);

    /// <summary>Calculates the material's translucency factor based on its diffuse alpha channel.
    /// <code>Offset: 0x0053A450
    /// float __thiscall CMaterial::GetTranslucencySimple(CMaterial*)</code>
    /// </summary>
    /// <returns>The translucency value (1 minus the diffuse alpha), ranging from 0 for fully opaque to 1 for fully transparent.</returns>
    public float GetTranslucencySimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float>)0x0053A450)(ref this);

    /// <summary>Sets the material’s emissive color to a uniform luminance value.
    /// <code>Offset: 0x0053A460
    /// void __thiscall CMaterial::SetLuminositySimple(CMaterial*,float)</code>
    /// </summary>
    /// <param name="lumi">The luminance level applied equally to the red, green, and blue components of the material’s emissive color.</param>
    public void SetLuminositySimple(float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float, void>)0x0053A460)(ref this, lumi);

    /// <summary>Retrieves the simple luminosity value from the material's emissive color.
    /// <code>Offset: 0x0053A480
    /// float __thiscall CMaterial::GetLuminositySimple(CMaterial*)</code>
    /// </summary>
    /// <returns>The red component of the emissive color, interpreted as luminosity.</returns>
    public float GetLuminositySimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float>)0x0053A480)(ref this);

    /// <summary>Sets the material's diffuse color intensity uniformly across RGB channels.
    /// <code>Offset: 0x0053A490
    /// void __thiscall CMaterial::SetDiffuseSimple(CMaterial*,float)</code>
    /// </summary>
    /// <param name="diffuse">The value to assign to the red, green, and blue components of the diffuse color.</param>
    public void SetDiffuseSimple(float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float, void>)0x0053A490)(ref this, diffuse);

    /// <summary>Constructs a CMaterial instance with default white diffuse and ambient colors, no alpha flag, and initializes its reference counter and base class vftable.
    /// <code>Offset: 0x0053A4B0
    /// void __thiscall CMaterial::CMaterial(CMaterial*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, void>)0x0053A4B0)(ref this);

    /// <summary>Creates a CMaterial instance, initializing its reference counter and virtual function table based on another material.
    /// <code>Offset: 0x0053A500
    /// void __thiscall CMaterial::CMaterial(CMaterial*,const CMaterial*)</code>
    /// </summary>
    /// <param name="material">The material to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.CMaterial* material) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, ACBindings.Internal.CMaterial*, void>)0x0053A500)(ref this, material);

    /// <summary>Returns the red channel of the material's diffuse color.
    /// <code>Offset: 0x0069F540
    /// float __thiscall CMaterial::GetColorDiffuseSimple(CMaterial*)</code>
    /// </summary>
    /// <returns>The diffuse color's red component as a floating‑point value.</returns>
    public float GetColorDiffuseSimple() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMaterial, float>)0x0069F540)(ref this);
}

