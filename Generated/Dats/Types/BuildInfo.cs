namespace ACBindings.Internal;


/// <summary>Holds metadata for a building instance, including its unique identifier, spatial frame, leaf count, portal count, and references to portal data.</summary>
public unsafe struct BuildInfo : System.IDisposable
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID building_id;
    public ACBindings.Internal.Frame building_frame;
    public uint num_leaves;
    public uint num_portals;
    public ACBindings.Internal.CBldPortal** portals;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a BuildInfo instance by deleting all portal objects, freeing the portals array, nullifying pointers, resetting counts, and assigning an invalid identifier to building_id.
    /// <code>Offset: 0x0052F480
    /// void __thiscall BuildInfo::~BuildInfo(BuildInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BuildInfo, void>)0x0052F480)(ref this);
}

