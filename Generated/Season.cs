namespace ACBindings.Internal;

public unsafe struct Season
{
    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte season_name;
    public int begin;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A7DF0
    /// int __thiscall Season::UnPack(Season*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Season, void**, uint*, int>)0x005A7DF0)(ref this, addr, size);
}

