namespace ACBindings;

// LIGHTINFO
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
    public ACBindings.Frame offset;
    public ACBindings.AC1Legacy.Vector3 viewerspace_location;
    public ACBindings.RGBColor color;
    public float intensity;
    public float falloff;
    public float cone_angle;

    // Methods
    // void __thiscall LIGHTINFO::SetDirection(LIGHTINFO*,const AC1Legacy::Vector3*)
    public void SetDirection(ACBindings.AC1Legacy.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LIGHTINFO, ACBindings.AC1Legacy.Vector3*, void>)0x00452740)(ref this, direction);
    // AC1Legacy::Vector3* __thiscall LIGHTINFO::GetDirection(LIGHTINFO*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* GetDirection(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LIGHTINFO, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x0059BBA0)(ref this, result);
    // void __cdecl LIGHTINFO::convert_to_local(LIGHTINFO*,LIGHTINFO*,const Frame*)
    public static void convert_to_local(ACBindings.LIGHTINFO* local_light, ACBindings.LIGHTINFO* global_light, ACBindings.Frame* frame) => ((delegate* unmanaged[Cdecl]<ACBindings.LIGHTINFO*, ACBindings.LIGHTINFO*, ACBindings.Frame*, void>)0x0059D420)(local_light, global_light, frame);
}

