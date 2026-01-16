namespace ACBindings.Internal;


/// <summary>
/// Represents an individual light source within the rendering engine, storing its Direct3D 9 configuration, spatial cell association, and distance data for culling.
/// </summary>
/// <remarks>
/// The constructor sets the light’s offset frame to an identity transform and caches it for efficient use during rendering passes.
/// </remarks>
public unsafe struct RenderLight
{
    // Members
    public ACBindings.Internal._D3DLIGHT9 d3dLight;
    public int d3dLightIndex;
    public uint cellID;
    public ACBindings.Internal.LIGHTINFO info;
    public float distancesq;

    // Generated Constructor
    public RenderLight() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the light's offset frame with an identity quaternion and zero translation, then caches the resulting transform for rendering.
    /// <code>Offset: 0x0054D6D0
    /// void __thiscall RenderLight::RenderLight(RenderLight*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderLight, void>)0x0054D6D0)(ref this);
}

