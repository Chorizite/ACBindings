namespace ACBindings.Internal.AC1Legacy;

public unsafe struct Vector3
{
    // Base Classes
    public ACBindings.Internal.Vector3 BaseClass_Vector3; // ACBindings.Internal.Vector3

    // Methods

    /// <summary>
    /// <code>Offset: 0x00452410
    /// float __thiscall AC1Legacy::Vector3::magnitude(AC1Legacy::Vector3*)</code>
    /// </summary>
    public float magnitude() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, float>)0x00452410)(ref this);

    /// <summary>
    /// <code>Offset: 0x00452440
    /// AC1Legacy::Vector3* __thiscall AC1Legacy::Vector3::normalize(AC1Legacy::Vector3*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* normalize(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452440)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x004524A0
    /// int __thiscall AC1Legacy::Vector3::normalize_check_small(AC1Legacy::Vector3*)</code>
    /// </summary>
    public int normalize_check_small() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, int>)0x004524A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004576F0
    /// float __thiscall AC1Legacy::Vector3::get_heading(AC1Legacy::Vector3*)</code>
    /// </summary>
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, float>)0x004576F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00457750
    /// float __thiscall AC1Legacy::Vector3::get_pitch(AC1Legacy::Vector3*)</code>
    /// </summary>
    public float get_pitch() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, float>)0x00457750)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F280
    /// int __thiscall AC1Legacy::Vector3::is_zero(AC1Legacy::Vector3*)</code>
    /// </summary>
    public int is_zero() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, int>)0x0050F280)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517040
    /// int __thiscall AC1Legacy::Vector3::UnPack(AC1Legacy::Vector3*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, void**, uint, int>)0x00517040)(ref this, addr, size);
}

