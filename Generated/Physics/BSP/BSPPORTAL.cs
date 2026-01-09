namespace ACBindings;

// BSPPORTAL
public unsafe struct BSPPORTAL
{
    // Base Classes
    public ACBindings.BSPNODE BaseClass_BSPNODE; // ACBindings.BSPNODE

    // Child Types
    // BSPPORTAL_vtbl
    public unsafe struct BSPPORTAL_vtbl
    {
        // Members
        public System.IntPtr BSPPORTAL_dtor_0; // function pointer
        public System.IntPtr sphere_intersects_poly; // function pointer
        public System.IntPtr sphere_intersects_solid; // function pointer
        public System.IntPtr point_intersects_solid; // function pointer
        public System.IntPtr sphere_intersects_solid_poly; // function pointer
        public System.IntPtr TraceRay; // function pointer
        public System.IntPtr find_walkable; // function pointer
        public System.IntPtr hits_walkable; // function pointer

        // Methods
    }

    // Members
    public uint num_portals;
    public ACBindings.CPortalPoly** in_portals;

    // Generated Constructor
    public BSPPORTAL() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall BSPPORTAL::BSPPORTAL(BSPPORTAL*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPPORTAL, void>)0x0053E5B0)(ref this);
    // void __thiscall BSPPORTAL::portal_draw_portals_only(BSPPORTAL*,int)
    public void portal_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPPORTAL, int, void>)0x0053E5D0)(ref this, portalPolyOrPortalContents);
    // void __thiscall BSPPORTAL::Destroy(BSPPORTAL*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPPORTAL, void>)0x0053E740)(ref this);
    // unsigned int __thiscall BSPPORTAL::pack_portal_size(BSPPORTAL*)
    public uint pack_portal_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPPORTAL, uint>)0x0053E7A0)(ref this);
    // unsigned int __thiscall BSPPORTAL::PackPortal(BSPPORTAL*,void**,unsigned int)
    public uint PackPortal(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPPORTAL, void**, uint, uint>)0x0053E800)(ref this, addr, size);
    // int __thiscall BSPPORTAL::UnPackPortal(BSPPORTAL*,void**,unsigned int)
    public int UnPackPortal(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPPORTAL, void**, uint, int>)0x0053E8D0)(ref this, addr, size);
}

