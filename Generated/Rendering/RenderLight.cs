namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0054D6D0
    /// void __thiscall RenderLight::RenderLight(RenderLight*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderLight, void>)0x0054D6D0)(ref this);
}

