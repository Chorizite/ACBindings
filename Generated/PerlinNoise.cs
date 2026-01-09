namespace ACBindings;

// PerlinNoise
public unsafe struct PerlinNoise
{
    // Methods
    // void __thiscall PerlinNoise::Init(PerlinNoise*)
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerlinNoise, void>)0x005B38D0)(ref this);
    // float __thiscall PerlinNoise::Noise(PerlinNoise*,long double)
    public float Noise(double arg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerlinNoise, double, float>)0x005B3980)(ref this, arg);
    // float __thiscall PerlinNoise::fBm1(PerlinNoise*,long double,long double,long double,long double)
    public float fBm1(double point, double H, double lacunarity, double octaves) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PerlinNoise, double, double, double, double, float>)0x005B3A10)(ref this, point, H, lacunarity, octaves);
}

