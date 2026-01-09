namespace ACBindings;

// PhysObjProfile
public unsafe struct PhysObjProfile
{
    // Members
    public ACBindings.IDClass___tagDataID setup;
    public ACBindings.IDClass___tagDataID motion_table;
    public ACBindings.IDClass___tagDataID sound_table;
    public ACBindings.IDClass___tagDataID physics_effect_table;
    public uint physics_bitmask;
    public uint placement;
    public double scale;
    public double friction;
    public double elasticity;
    public double translucency;
    public ACBindings.PScriptType default_script;
    public double default_script_intensity;

    // Methods
}

