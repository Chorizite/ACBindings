namespace ACBindings.Internal;


/// <summary>Represents a timing node for executing physics scripts, holding the start time and pointer to the script along with linkage to subsequent nodes.</summary>
public unsafe struct ScriptData
{
    // Members
    public double start_time;
    public ACBindings.Internal.PhysicsScript* script;
    public ACBindings.Internal.ScriptData* next_data;

    // Methods
}

