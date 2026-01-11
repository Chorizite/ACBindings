namespace ACBindings.Internal;

public unsafe struct ScriptData
{
    // Members
    public double start_time;
    public ACBindings.Internal.PhysicsScript* script;
    public ACBindings.Internal.ScriptData* next_data;

    // Methods
}

