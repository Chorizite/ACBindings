namespace ACBindings;

// TCoord
public unsafe struct TCoord
{
    // Members
    public int x;
    public int y;

    // Methods
    // int __thiscall TCoord::IsValid(TCoord*)
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TCoord, int>)0x004A7EC0)(ref this);
    // int __thiscall TCoord::UnPack(TCoord*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TCoord, void**, uint, int>)0x004A8250)(ref this, addr, size);
}

