namespace ACBindings.Internal;


/// <summary>Tracks memory footprint and dimensional attributes of a graphical surface, storing its name, byte size, element size, and overall dimensions for resource management within the rendering system.</summary>
public unsafe struct SurfaceUsageSummary
{
    // Members
    public uint Bytes;
    public ACBindings.Internal.PStringBase__sbyte Name;
    public uint ElementWidth;
    public uint ElementHeight;
    public uint SurfaceWidth;
    public uint SurfaceHeight;

    // Generated Constructor
    public SurfaceUsageSummary() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a SurfaceUsageSummary instance by setting its name to an empty string and incrementing the reference counter for the shared string buffer.
    /// <code>Offset: 0x004599E0
    /// void __thiscall SurfaceUsageSummary::SurfaceUsageSummary(ProfilerDBObjStat*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceUsageSummary, void>)0x004599E0)(ref this);
}

