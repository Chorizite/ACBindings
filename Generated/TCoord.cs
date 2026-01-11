namespace ACBindings.Internal;

public unsafe struct TCoord
{
    // Members
    public int x;
    public int y;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A7EC0
    /// int __thiscall TCoord::IsValid(TCoord*)</code>
    /// </summary>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TCoord, int>)0x004A7EC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A8250
    /// int __thiscall TCoord::UnPack(TCoord*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TCoord, void**, uint, int>)0x004A8250)(ref this, addr, size);
}

