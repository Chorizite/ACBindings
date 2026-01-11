namespace ACBindings.Internal;

public unsafe struct CPortalPoly : System.IDisposable
{
    // Members
    public uint portal_index;
    public ACBindings.Internal.CPolygon* portal;

    // Generated Constructor
    public CPortalPoly() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053ECD0
    /// void __thiscall CPortalPoly::CPortalPoly(CPortalPoly*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPortalPoly, void>)0x0053ECD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053ECE0
    /// void __thiscall CPortalPoly::~CPortalPoly(CPortalPoly*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPortalPoly, void>)0x0053ECE0)(ref this);
}

