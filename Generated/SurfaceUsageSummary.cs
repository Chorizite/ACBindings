namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x004599E0
    /// void __thiscall SurfaceUsageSummary::SurfaceUsageSummary(ProfilerDBObjStat*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceUsageSummary, void>)0x004599E0)(ref this);
}

