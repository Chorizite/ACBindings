namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00452740
    /// void __thiscall LIGHTINFO::SetDirection(LIGHTINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void SetDirection(ACBindings.Internal.AC1Legacy.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTINFO, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00452740)(ref this, direction);

    /// <summary>
    /// <code>Offset: 0x0059BBA0
    /// AC1Legacy::Vector3* __thiscall LIGHTINFO::GetDirection(LIGHTINFO*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* GetDirection(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTINFO, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0059BBA0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0059D420
    /// void __cdecl LIGHTINFO::convert_to_local(LIGHTINFO*,LIGHTINFO*,const Frame*)</code>
    /// </summary>
    public static void convert_to_local(ACBindings.Internal.LIGHTINFO* local_light, ACBindings.Internal.LIGHTINFO* global_light, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LIGHTINFO*, ACBindings.Internal.LIGHTINFO*, ACBindings.Internal.Frame*, void>)0x0059D420)(local_light, global_light, frame);
}

