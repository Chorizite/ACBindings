namespace ACBindings.Internal;

public unsafe struct PhysicsScriptData
{
    // Members
    public double start_time;
    public ACBindings.Internal.CAnimHook* hook;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00522120
    /// int __cdecl PhysicsScriptData::Sort(const void*,const void*)</code>
    /// </summary>
    public static int Sort(void* a, void* b) => ((delegate* unmanaged[Cdecl]<void*, void*, int>)0x00522120)(a, b);
}

