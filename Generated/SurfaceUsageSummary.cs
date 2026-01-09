namespace ACBindings;

// SurfaceUsageSummary
public unsafe struct SurfaceUsageSummary
{
    // Members
    public uint Bytes;
    public ACBindings.PStringBase__sbyte Name;
    public uint ElementWidth;
    public uint ElementHeight;
    public uint SurfaceWidth;
    public uint SurfaceHeight;

    // Generated Constructor
    public SurfaceUsageSummary() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SurfaceUsageSummary::SurfaceUsageSummary(ProfilerDBObjStat*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceUsageSummary, void>)0x004599E0)(ref this);
}

