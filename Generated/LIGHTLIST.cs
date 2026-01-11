namespace ACBindings.Internal;

public unsafe struct LIGHTLIST
{
    // Members
    public uint num_lights;
    public ACBindings.Internal.LIGHTOBJ* lightobj;

    // Generated Constructor
    public LIGHTLIST(uint num_lights) {
        _ConstructorInternal(num_lights);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00518790
    /// void __thiscall LIGHTLIST::set_frame(LIGHTLIST*,const Frame*)</code>
    /// </summary>
    public void set_frame(ACBindings.Internal.Frame* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTLIST, ACBindings.Internal.Frame*, void>)0x00518790)(ref this, offset);

    /// <summary>
    /// <code>Offset: 0x00519170
    /// void __thiscall LIGHTLIST::LIGHTLIST(LIGHTLIST*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint num_lights) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTLIST, uint, void>)0x00519170)(ref this, num_lights);
}

