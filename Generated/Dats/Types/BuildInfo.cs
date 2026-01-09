namespace ACBindings;

// BuildInfo
public unsafe struct BuildInfo : System.IDisposable
{
    // Members
    public ACBindings.IDClass___tagDataID building_id;
    public ACBindings.Frame building_frame;
    public uint num_leaves;
    public uint num_portals;
    public ACBindings.CBldPortal** portals;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall BuildInfo::~BuildInfo(BuildInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BuildInfo, void>)0x0052F480)(ref this);
}

