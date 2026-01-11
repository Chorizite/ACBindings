namespace ACBindings.Internal;

public unsafe struct BSPPORTAL
{
    // Base Classes
    public ACBindings.Internal.BSPNODE BaseClass_BSPNODE; // ACBindings.Internal.BSPNODE

    // Child Types
    public unsafe struct BSPPORTAL_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, void> BSPPORTAL_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int> sphere_intersects_poly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.CSphere*, int, int> sphere_intersects_solid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_intersects_solid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int> sphere_intersects_solid_poly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint> TraceRay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void> find_walkable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int> hits_walkable; // function pointer

        // Methods
    }

    // Members
    public uint num_portals;
    public ACBindings.Internal.CPortalPoly** in_portals;

    // Generated Constructor
    public BSPPORTAL() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053E5B0
    /// void __thiscall BSPPORTAL::BSPPORTAL(BSPPORTAL*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void>)0x0053E5B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053E5D0
    /// void __thiscall BSPPORTAL::portal_draw_portals_only(BSPPORTAL*,int)</code>
    /// </summary>
    public void portal_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, int, void>)0x0053E5D0)(ref this, portalPolyOrPortalContents);

    /// <summary>
    /// <code>Offset: 0x0053E740
    /// void __thiscall BSPPORTAL::Destroy(BSPPORTAL*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void>)0x0053E740)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053E7A0
    /// unsigned int __thiscall BSPPORTAL::pack_portal_size(BSPPORTAL*)</code>
    /// </summary>
    public uint pack_portal_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, uint>)0x0053E7A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053E800
    /// unsigned int __thiscall BSPPORTAL::PackPortal(BSPPORTAL*,void**,unsigned int)</code>
    /// </summary>
    public uint PackPortal(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void**, uint, uint>)0x0053E800)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053E8D0
    /// int __thiscall BSPPORTAL::UnPackPortal(BSPPORTAL*,void**,unsigned int)</code>
    /// </summary>
    public int UnPackPortal(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void**, uint, int>)0x0053E8D0)(ref this, addr, size);
}

