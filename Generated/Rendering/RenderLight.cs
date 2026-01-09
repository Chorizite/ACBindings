namespace ACBindings;

// RenderLight
public unsafe struct RenderLight
{
    // Members
    public ACBindings._D3DLIGHT9 d3dLight;
    public int d3dLightIndex;
    public uint cellID;
    public ACBindings.LIGHTINFO info;
    public float distancesq;

    // Generated Constructor
    public RenderLight() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall RenderLight::RenderLight(RenderLight*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderLight, void>)0x0054D6D0)(ref this);
}

