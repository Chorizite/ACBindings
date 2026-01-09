namespace ACBindings;

// CTriangleStrip
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
    // void __thiscall CTriangleStrip::~CTriangleStrip(CTriangleStrip*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTriangleStrip, void>)0x00535A70)(ref this);
}

