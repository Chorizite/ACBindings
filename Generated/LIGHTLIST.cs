namespace ACBindings;

// LIGHTLIST
public unsafe struct LIGHTLIST
{
    // Members
    public uint num_lights;
    public ACBindings.LIGHTOBJ* lightobj;

    // Generated Constructor
    public LIGHTLIST(uint num_lights) {
        _ConstructorInternal(num_lights);
    }

    // Methods
    // void __thiscall LIGHTLIST::set_frame(LIGHTLIST*,const Frame*)
    public void set_frame(ACBindings.Frame* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LIGHTLIST, ACBindings.Frame*, void>)0x00518790)(ref this, offset);
    // void __thiscall LIGHTLIST::LIGHTLIST(LIGHTLIST*,unsigned int)
    public void _ConstructorInternal(uint num_lights) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LIGHTLIST, uint, void>)0x00519170)(ref this, num_lights);
}

