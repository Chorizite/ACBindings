namespace ACBindings;

// PhysicsScriptData
public unsafe struct PhysicsScriptData
{
    // Members
    public double start_time;
    public ACBindings.CAnimHook* hook;

    // Methods
    // int __cdecl PhysicsScriptData::Sort(const void*,const void*)
    public static int Sort(void* a, void* b) => ((delegate* unmanaged[Cdecl]<void*, void*, int>)0x00522120)(a, b);
}

