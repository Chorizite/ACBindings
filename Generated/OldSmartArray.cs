namespace ACBindings.Internal;


/// <summary>Dynamic container that stores and manages an array of PhysicsScriptData pointers, automatically resizing as elements are inserted.</summary>
public unsafe struct OldSmartArray___PhysicsScriptData_ptr
{
    // Members
    public ACBindings.Internal.PhysicsScriptData** data;
    public int grow_size;
    public int mem_size;
    public int num_in_array;

    // Methods
}

