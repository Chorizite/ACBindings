namespace ACBindings.Internal;

public unsafe struct CSurfaceTriStrips : System.IDisposable
{
    // Members
    public uint surface_index;
    public uint num_strips;
    public ACBindings.Internal.CTriangleStrip* strips;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00535A30
    /// void __thiscall CSurfaceTriStrips::~CSurfaceTriStrips(CSurfaceTriStrips*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurfaceTriStrips, void>)0x00535A30)(ref this);
}

