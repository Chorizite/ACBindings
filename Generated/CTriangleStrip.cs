namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00535A70
    /// void __thiscall CTriangleStrip::~CTriangleStrip(CTriangleStrip*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTriangleStrip, void>)0x00535A70)(ref this);
}

