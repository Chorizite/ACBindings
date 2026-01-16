namespace ACBindings.Internal;


/// <summary>Captures profiling statistics for a database object type, including its identifier, name, active/free counts, and recent activity timestamps.</summary>
/// <remarks>Used by the profiler to monitor resource allocation and usage patterns for different database types at runtime.</remarks>
public unsafe struct ProfilerDBObjStat
{
    // Members
    public uint DBType;
    public ACBindings.Internal.PStringBase__sbyte DBTypeName;
    public uint NumActive;
    public uint NumFree;
    public double LastLocalTimeNotEmpty;
    public double LastLocalTimeChanged;

    // Methods
}

