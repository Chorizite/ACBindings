namespace ACBindings.Internal;


/// <summary>Specifies rendering preferences, controlling texture filtering, detail levels, draw distances, aspect ratio, brightness, field of view, and hardware class for the graphics subsystem.</summary>
public unsafe struct RenderPrefs
{
    // Members
    public uint TextureFiltering;
    public byte LandscapeDetailTextures;
    public byte EnvironmentDetailTextures;
    public byte MultiPassAlpha;
    public uint LandscapeTextureDetail;
    public uint EnvironmentTextureDetail;
    public uint SceneryDrawDistance;
    public uint LandscapeDrawDistance;
    public uint AspectRatio;
    public uint DisplayAdapter;
    public uint MaxHardwareClass;
    public float ScreenBrightness;
    public float FieldOfView;
    public uint ModelDetail;

    // Methods
}

