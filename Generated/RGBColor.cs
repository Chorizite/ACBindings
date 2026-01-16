namespace ACBindings.Internal;


/// <summary>Represents a color using red, green, and blue components expressed as floating-point values.</summary>
public unsafe struct RGBColor
{
    // Members
    public float r;
    public float g;
    public float b;

    // Methods

    /// <summary>Sets the color components from a packed 32‑bit integer, extracting each byte and normalizing to the [0,1] range.
    /// <code>Offset: 0x00451A60
    /// void __thiscall RGBColor::SetColor32(RGBColor*,const unsigned int)</code>
    /// </summary>
    /// <param name="color">Packed RGB value where bits 16–23 contain red, bits 8–15 contain green, and bits 0–7 contain blue; the most significant byte is ignored.</param>
    public void SetColor32(uint color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBColor, uint, void>)0x00451A60)(ref this, color);

    /// <summary>Packs the RGB components of this color into a 32‑bit integer, writes it to the memory location referenced by addr, advances that pointer past the written data, and reports the number of bytes written.
    /// <code>Offset: 0x005AB0D0
    /// unsigned int __thiscall RGBColor::Pack(RGBColor*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; after calling, points to the next free byte.</param>
    /// <param name="size">Size of the destination buffer (unused in current implementation).</param>
    /// <returns>The count of bytes written (always 4).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBColor, void**, uint, uint>)0x005AB0D0)(ref this, addr, size);

    /// <summary>Unpacks a 32‑bit color value from the provided buffer into the RGBColor object, advancing the buffer pointer past the consumed data.
    /// <code>Offset: 0x005AB130
    /// int __thiscall RGBColor::UnPack(RGBColor*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; will be advanced by four bytes after unpacking.</param>
    /// <param name="size">Size of remaining buffer (unused but part of the signature).</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RGBColor, void**, uint, int>)0x005AB130)(ref this, addr, size);
}

