namespace ACBindings;

// CPortalPoly
public unsafe struct CPortalPoly : System.IDisposable
{
    // Members
    public uint portal_index;
    public ACBindings.CPolygon* portal;

    // Generated Constructor
    public CPortalPoly() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CPortalPoly::CPortalPoly(CPortalPoly*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPortalPoly, void>)0x0053ECD0)(ref this);
    // void __thiscall CPortalPoly::~CPortalPoly(CPortalPoly*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPortalPoly, void>)0x0053ECE0)(ref this);
}

