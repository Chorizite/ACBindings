namespace ACBindings.Internal;


/// <summary>Defines the parameters governing a physical object’s behaviour, linking to setup, motion, sound, and physics‑effect tables while specifying placement flags, scaling, friction, elasticity, translucency, and the default script with its intensity.</summary>
public unsafe struct PhysObjProfile
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID setup;
    public ACBindings.Internal.IDClass____tagDataID motion_table;
    public ACBindings.Internal.IDClass____tagDataID sound_table;
    public ACBindings.Internal.IDClass____tagDataID physics_effect_table;
    public uint physics_bitmask;
    public uint placement;
    public double scale;
    public double friction;
    public double elasticity;
    public double translucency;
    public ACBindings.Internal.PScriptType default_script;
    public double default_script_intensity;

    // Methods
}

