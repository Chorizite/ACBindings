namespace ACBindings.Internal;


/// <summary>Tracks the initiation time of a physics script and holds a reference to its associated animation hook.</summary>
public unsafe struct PhysicsScriptData
{
    // Members
    public double start_time;
    public ACBindings.Internal.CAnimHook* hook;

    // Methods

    /// <summary>Provides a comparison for sorting PhysicsScriptData objects by their start time in ascending order.
    /// <code>Offset: 0x00522120
    /// int __cdecl PhysicsScriptData::Sort(const void*,const void*)</code>
    /// </summary>
    /// <param name="a">Pointer to the first element to compare.</param>
    /// <param name="b">Pointer to the second element to compare.</param>
    /// <returns>Negative if the first element precedes the second, positive otherwise.</returns>
    public static int Sort(void* a, void* b) => ((delegate* unmanaged[Cdecl]<void*, void*, int>)0x00522120)(a, b);
}

