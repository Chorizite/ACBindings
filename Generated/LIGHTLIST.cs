namespace ACBindings.Internal;


/// <summary>Represents a list of light objects in a scene, storing the number of lights and providing access to them via a pointer to LIGHTOBJ.</summary>
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

    /// <summary>Applies a given frame as the global offset to all lights contained in the LIGHTLIST.
    /// <code>Offset: 0x00518790
    /// void __thiscall LIGHTLIST::set_frame(LIGHTLIST*,const Frame*)</code>
    /// </summary>
    /// <param name="offset">The Frame whose values are copied into each light object's global_offset field.</param>
    public void set_frame(ACBindings.Internal.Frame* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTLIST, ACBindings.Internal.Frame*, void>)0x00518790)(ref this, offset);

    /// <summary>Creates a light list containing the given number of lights, allocating memory for each and initializing them to default values.
    /// <code>Offset: 0x00519170
    /// void __thiscall LIGHTLIST::LIGHTLIST(LIGHTLIST*,unsigned int)</code>
    /// </summary>
    /// <param name="num_lights">The desired count of light objects in the list.</param>
    public void _ConstructorInternal(uint num_lights) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LIGHTLIST, uint, void>)0x00519170)(ref this, num_lights);
}

