namespace ACBindings.Internal.AC1Legacy;


/// <summary>Three‑dimensional vector used for position, direction, and transformation calculations.</summary>
public unsafe struct Vector3
{
    // Base Classes
    public ACBindings.Internal.Vector3 BaseClass_Vector3; // ACBindings.Internal.Vector3

    // Methods

    /// <summary>Computes the Euclidean length of the vector.
    /// <code>Offset: 0x00452410
    /// float __thiscall AC1Legacy::Vector3::magnitude(AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <returns>The vector's magnitude as a float.</returns>
    public float magnitude() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, float>)0x00452410)(ref this);

    /// <summary>Normalizes the current vector, storing a unit-length copy in the supplied result pointer while updating the original.
    /// <code>Offset: 0x00452440
    /// AC1Legacy::Vector3* __thiscall AC1Legacy::Vector3::normalize(AC1Legacy::Vector3*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that receives the normalized coordinates.</param>
    /// <returns>The same pointer passed as result, now pointing to the normalized vector.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* normalize(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00452440)(ref this, result);

    /// <summary>Normalizes this vector to unit length unless its magnitude falls below 0.0002, leaving the vector unchanged when too small.
    /// <code>Offset: 0x004524A0
    /// int __thiscall AC1Legacy::Vector3::normalize_check_small(AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <returns>1 if the vector's length was less than 0.0002 (and normalization was skipped); otherwise 0 after successful normalization.</returns>
    public int normalize_check_small() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, int>)0x004524A0)(ref this);

    /// <summary>Computes the heading of the vector projected onto the XY plane, expressed in degrees clockwise from north. If the vector magnitude is negligible, zero is returned.
    /// <code>Offset: 0x004576F0
    /// float __thiscall AC1Legacy::Vector3::get_heading(AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <returns>The heading angle in degrees between 0 and 360. Returns 0 for a near‑zero vector.</returns>
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, float>)0x004576F0)(ref this);

    /// <summary>Computes the pitch (angle relative to the horizontal plane) of a 3‑D vector, expressed in degrees.
    /// <code>Offset: 0x00457750
    /// float __thiscall AC1Legacy::Vector3::get_pitch(AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <returns>Returns the pitch angle in degrees if the vector has sufficient magnitude; otherwise returns zero.</returns>
    public float get_pitch() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, float>)0x00457750)(ref this);

    /// <summary>Determines whether the vector’s x, y and z components are effectively zero within a small epsilon.
    /// <code>Offset: 0x0050F280
    /// int __thiscall AC1Legacy::Vector3::is_zero(AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <returns>An int that evaluates to non‑zero when all components are below the tolerance (≈0.0002); otherwise returns 0.</returns>
    public int is_zero() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, int>)0x0050F280)(ref this);

    /// <summary>Unpacks three consecutive floats from a byte buffer into this vector and advances the buffer pointer.
    /// <code>Offset: 0x00517040
    /// int __thiscall AC1Legacy::Vector3::UnPack(AC1Legacy::Vector3*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the data buffer; updated past the read bytes after successful unpacking.</param>
    /// <param name="size">Number of bytes remaining at *addr; must be at least 12 for a successful unpack.</param>
    /// <returns>1 if the vector was populated and the pointer advanced, otherwise 0 when insufficient data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.Vector3, void**, uint, int>)0x00517040)(ref this, addr, size);
}

