namespace ACBindings.Internal;


/// <summary>Holds lighting parameters for a scene, including ambient and sun colors and collections of static and dynamic render lights. Initializes each light to an identity quaternion and zero position, then caches its frame for rendering.</summary>
public unsafe struct LightParms
{
    // Members
    public ACBindings.Internal.RGBColor ambient_color;
    public ACBindings.Internal.RGBColor sunlight_color;
    public ACBindings.Internal.AC1Legacy.Vector3 sunlight;
    public byte m_bSunlightValid;
    public ACBindings.Internal.RenderLight m_Sunlight;
    public int num_static_lights;
    public fixed byte static_lights_Raw[13200];
    public ACBindings.Internal.RenderLight* static_lights => (ACBindings.Internal.RenderLight*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref static_lights_Raw[0]);
    public fixed byte sorted_static_lights_Raw[60 * 4];
    public ACBindings.Internal.RenderLight** sorted_static_lights => (ACBindings.Internal.RenderLight**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref sorted_static_lights_Raw[0]);
    public int num_dynamic_lights;
    public fixed byte dynamic_lights_Raw[2200];
    public ACBindings.Internal.RenderLight* dynamic_lights => (ACBindings.Internal.RenderLight*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dynamic_lights_Raw[0]);
    public fixed byte sorted_dynamic_lights_Raw[10 * 4];
    public ACBindings.Internal.RenderLight** sorted_dynamic_lights => (ACBindings.Internal.RenderLight**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref sorted_dynamic_lights_Raw[0]);

    // Generated Constructor
    public LightParms() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a LightParms instance by setting all lights to an identity quaternion and zero position, then caching each light’s frame for rendering use.
    /// <code>Offset: 0x0054E3B0
    /// void __thiscall LightParms::LightParms(LightParms*)</code>
    /// </summary>
    /// <returns>No value is returned; the constructor configures the object in place.</returns>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LightParms, void>)0x0054E3B0)(ref this);
}

