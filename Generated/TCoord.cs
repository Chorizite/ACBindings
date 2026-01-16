namespace ACBindings.Internal;


/// <summary>Represents a point on an 8×8 grid using integer X and Y values.</summary>
public unsafe struct TCoord
{
    // Members
    public int x;
    public int y;

    // Methods

    /// <summary>Determines whether the coordinate lies within an 8×8 grid (values 0–7 inclusive).
    /// <code>Offset: 0x004A7EC0
    /// int __thiscall TCoord::IsValid(TCoord*)</code>
    /// </summary>
    /// <returns>Non‑zero value if the coordinate is within bounds; zero otherwise.</returns>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TCoord, int>)0x004A7EC0)(ref this);

    /// <summary>Deserializes two 32‑bit integers into a TCoord object from a byte buffer.
    /// <code>Offset: 0x004A8250
    /// int __thiscall TCoord::UnPack(TCoord*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; advanced past the read data on success.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the call site.</param>
    /// <returns>Zero if insufficient data, one otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TCoord, void**, uint, int>)0x004A8250)(ref this, addr, size);
}

