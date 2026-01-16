namespace ACBindings.Internal;


/// <summary>
/// Represents a triangle strip defined by an array of vertex indices, providing the count of indices and a pointer to the index data for rendering.
/// </summary>
public unsafe struct CTriangleStrip : System.IDisposable
{
    // Members
    public uint num_indices;
    public ushort* indices;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases memory allocated for indices within a triangle strip.
    /// <code>Offset: 0x00535A70
    /// void __thiscall CTriangleStrip::~CTriangleStrip(CTriangleStrip*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTriangleStrip, void>)0x00535A70)(ref this);
}

