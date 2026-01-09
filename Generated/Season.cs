namespace ACBindings;

// Season
public unsafe struct Season
{
    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte season_name;
    public int begin;

    // Methods
    // int __thiscall Season::UnPack(Season*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Season, void**, uint*, int>)0x005A7DF0)(ref this, addr, size);
}

