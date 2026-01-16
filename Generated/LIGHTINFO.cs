namespace ACBindings.Internal;


/// <summary>Represents a light source definition within the rendering engine, encapsulating type, spatial offset, viewer-space location, color, intensity, falloff distance, and cone angle for spotlight behavior.</summary>
public unsafe struct LIGHTINFO
{
    // Child Types
    // LIGHTINFO::LightType
    public enum LightType : uint
    {
        POINT_LIGHT = 0x0,
        DISTANT_LIGHT = 0x1,
        SPOT_LIGHT = 0x2,
        FORCE_LightType_32_BIT = 0x7FFFFFFF,
        INVALID_LIGHT_TYPE = 0xFFFFFFFF
    }

    // Members
    public int type;
    public ACBindings.Internal.Frame offset;
    public ACBindings.Internal.AC1Legacy.Vector3 viewerspace_location;
    public ACBindings.Internal.RGBColor color;
    public float intensity;
    public float falloff;
    public float cone_angle;

    // Methods

    /// <summary>Normalizes the supplied direction vector and updates the light's offset frame for directional or point lights.
    /// <code>Offset: 0x00452740
    /// void __thiscall LIGHTINFO::SetDirection(LIGHTINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="direction">The desired heading for the light.</param>
    public void SetDirection(ACBindings.Internal.AC1Legacy.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTINFO, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00452740)(ref this, direction);

    /// <summary>Retrieves the light’s directional vector. For lights of type 1 (directional) or 2 (spot), computes the heading from the offset frame; otherwise returns a zero vector.
    /// <code>Offset: 0x0059BBA0
    /// AC1Legacy::Vector3* __thiscall LIGHTINFO::GetDirection(LIGHTINFO*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Buffer to receive the computed direction.</param>
    /// <returns>A pointer to the supplied result vector containing the direction, or a zeroed vector when the light has no defined direction.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* GetDirection(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTINFO, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0059BBA0)(ref this, result);

    /// <summary>Converts a LIGHTINFO instance from global to local coordinate space using the specified Frame, copying type and light properties.
    /// <code>Offset: 0x0059D420
    /// void __cdecl LIGHTINFO::convert_to_local(LIGHTINFO*,LIGHTINFO*,const Frame*)</code>
    /// </summary>
    /// <param name="local_light">Destination LIGHTINFO that receives the converted data.</param>
    /// <param name="global_light">Source LIGHTINFO in world coordinates.</param>
    /// <param name="frame">Reference frame used for the conversion.</param>
    public static void convert_to_local(ACBindings.Internal.LIGHTINFO* local_light, ACBindings.Internal.LIGHTINFO* global_light, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, ACBindings.Internal.LIGHTINFO*, ACBindings.Internal.Frame*, void>)0x0059D420)(local_light, global_light, frame);
}

