namespace ACBindings;

// CSurfaceTriStrips
public unsafe struct CSurfaceTriStrips : System.IDisposable
{
    // Members
    public uint surface_index;
    public uint num_strips;
    public ACBindings.CTriangleStrip* strips;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CSurfaceTriStrips::~CSurfaceTriStrips(CSurfaceTriStrips*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurfaceTriStrips, void>)0x00535A30)(ref this);
}

