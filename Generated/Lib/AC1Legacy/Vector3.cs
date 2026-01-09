namespace ACBindings.AC1Legacy;

// AC1Legacy::Vector3
public unsafe struct Vector3
{
    // Base Classes
    public ACBindings.Vector3 BaseClass_Vector3; // ACBindings.Vector3

    // Methods
    // float __thiscall AC1Legacy::Vector3::magnitude(AC1Legacy::Vector3*)
    public float magnitude() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, float>)0x00452410)(ref this);
    // AC1Legacy::Vector3* __thiscall AC1Legacy::Vector3::normalize(AC1Legacy::Vector3*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* normalize(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x00452440)(ref this, result);
    // int __thiscall AC1Legacy::Vector3::normalize_check_small(AC1Legacy::Vector3*)
    public int normalize_check_small() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, int>)0x004524A0)(ref this);
    // float __thiscall AC1Legacy::Vector3::get_heading(AC1Legacy::Vector3*)
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, float>)0x004576F0)(ref this);
    // float __thiscall AC1Legacy::Vector3::get_pitch(AC1Legacy::Vector3*)
    public float get_pitch() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, float>)0x00457750)(ref this);
    // int __thiscall AC1Legacy::Vector3::is_zero(AC1Legacy::Vector3*)
    public int is_zero() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, int>)0x0050F280)(ref this);
    // int __thiscall AC1Legacy::Vector3::UnPack(AC1Legacy::Vector3*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.Vector3, void**, uint, int>)0x00517040)(ref this, addr, size);
}

