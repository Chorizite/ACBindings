namespace ACBindings.Internal;


/// <summary>References a portal polygon within level geometry, storing its identifier and a direct link to the associated CPolygon instance.</summary>
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

    /// <summary>Initializes a CPortalPoly instance by setting its portal index to –1 and portal pointer to null, marking the object as unassigned.
    /// <code>Offset: 0x0053ECD0
    /// void __thiscall CPortalPoly::CPortalPoly(CPortalPoly*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPortalPoly, void>)0x0053ECD0)(ref this);

    /// <summary>Resets the CPortalPoly's portal reference to null and marks its index as invalid.
    /// <code>Offset: 0x0053ECE0
    /// void __thiscall CPortalPoly::~CPortalPoly(CPortalPoly*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPortalPoly, void>)0x0053ECE0)(ref this);
}

