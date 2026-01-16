namespace ACBindings.Internal;


/// <summary>Contains metadata for a collection of triangle strips associated with a particular surface, including its index, count, and reference to the strips.</summary>
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

    /// <summary>Destroys a CSurfaceTriStrips instance, deallocating each CTriangleStrip in its collection and freeing the associated index buffer memory.
    /// <code>Offset: 0x00535A30
    /// void __thiscall CSurfaceTriStrips::~CSurfaceTriStrips(CSurfaceTriStrips*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurfaceTriStrips, void>)0x00535A30)(ref this);
}

