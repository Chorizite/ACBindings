namespace ACBindings.Internal;


/// <summary>Generates Perlin noise for procedural content, offering single‑octave noise and fractal Brownian motion calculations with internally initialized gradient tables.</summary>
public unsafe struct PerlinNoise
{
    // Methods

    /// <summary>Initializes the PerlinNoise instance by generating gradient values and setting up permutation tables used for noise generation.
    /// <code>Offset: 0x005B38D0
    /// void __thiscall PerlinNoise::Init(PerlinNoise*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerlinNoise, void>)0x005B38D0)(ref this);

    /// <summary>Computes Perlin noise at the specified coordinate.
    /// <code>Offset: 0x005B3980
    /// float __thiscall PerlinNoise::Noise(PerlinNoise*,long double)</code>
    /// </summary>
    /// <param name="arg">The input coordinate to evaluate the noise function.</param>
    /// <returns>A floating-point noise value derived from a deterministic gradient table.</returns>
    public float Noise(double arg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerlinNoise, double, float>)0x005B3980)(ref this, arg);

    /// <summary>Computes fractal Brownian motion noise at a specified point using the given roughness, lacunarity, and octaves. Caches amplitude coefficients when H changes for efficiency.
    /// <code>Offset: 0x005B3A10
    /// float __thiscall PerlinNoise::fBm1(PerlinNoise*,long double,long double,long double,long double)</code>
    /// </summary>
    /// <param name="point">The position at which to evaluate the fBm function.</param>
    /// <param name="H">Exponent controlling the relative contribution of each octave (roughness).</param>
    /// <param name="lacunarity">Multiplier applied to the frequency between successive octaves.</param>
    /// <param name="octaves">Number of noise layers; fractional values interpolate the final octave’s contribution.</param>
    /// <returns>Float value representing the combined fBm noise at the input point.</returns>
    public float fBm1(double point, double H, double lacunarity, double octaves) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PerlinNoise, double, double, double, double, float>)0x005B3A10)(ref this, point, H, lacunarity, octaves);
}

