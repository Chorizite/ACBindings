namespace ACBindings.Internal;

public unsafe struct PerlinNoise
{
    // Methods

    /// <summary>
    /// <code>Offset: 0x005B38D0
    /// void __thiscall PerlinNoise::Init(PerlinNoise*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerlinNoise, void>)0x005B38D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B3980
    /// float __thiscall PerlinNoise::Noise(PerlinNoise*,long double)</code>
    /// </summary>
    public float Noise(double arg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerlinNoise, double, float>)0x005B3980)(ref this, arg);

    /// <summary>
    /// <code>Offset: 0x005B3A10
    /// float __thiscall PerlinNoise::fBm1(PerlinNoise*,long double,long double,long double,long double)</code>
    /// </summary>
    public float fBm1(double point, double H, double lacunarity, double octaves) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerlinNoise, double, double, double, double, float>)0x005B3A10)(ref this, point, H, lacunarity, octaves);
}

