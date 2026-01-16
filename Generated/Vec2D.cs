namespace ACBindings.Internal;


/// <summary>Represents a two‑dimensional vector with X and Y components, used for planar spatial calculations.</summary>
public unsafe struct Vec2D
{
    // Members
    public float x;
    public float y;

    // Methods

    /// <summary>Packs the vector's X and Y components into a contiguous buffer.
    /// <code>Offset: 0x005AAE80
    /// unsigned int __thiscall Vec2D::Pack(Vec2D*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position; updated after writing.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 8 for a successful pack.</param>
    /// <returns>Always returns 8, indicating the number of bytes written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vec2D, void**, uint, uint>)0x005AAE80)(ref this, addr, size);

    /// <summary>Deserializes a Vec2D from a buffer, reading two consecutive floats and advancing the pointer.
    /// <code>Offset: 0x005AAEB0
    /// int __thiscall Vec2D::UnPack(Vec2D*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the buffer; updated past the read values.</param>
    /// <param name="size">Size of the remaining data (unused).</param>
    /// <returns>Always 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Vec2D, void**, uint, int>)0x005AAEB0)(ref this, addr, size);
}

