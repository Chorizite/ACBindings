namespace ACBindings.Internal;


/// <summary>Represents a portal node within the BSP tree, extending BSPNODE and storing the number of connected portals along with pointers to their polygon definitions.</summary>
public unsafe struct BSPPORTAL
{
    // Base Classes
    public ACBindings.Internal.BSPNODE BaseClass_BSPNODE; // ACBindings.Internal.BSPNODE

    // Child Types
    public unsafe struct BSPPORTAL_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, void> BSPPORTAL_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int> sphere_intersects_poly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.CSphere*, int, int> sphere_intersects_solid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_intersects_solid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int> sphere_intersects_solid_poly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint> TraceRay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void> find_walkable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPPORTAL*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int> hits_walkable; // function pointer

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

    /// <summary>Initializes a new BSPPORTAL instance by constructing its base BSPNODE component, setting portal count to zero, clearing the portal list, and assigning the correct virtual function table.
    /// <code>Offset: 0x0053E5B0
    /// void __thiscall BSPPORTAL::BSPPORTAL(BSPPORTAL*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void>)0x0053E5B0)(ref this);

    /// <summary>Draws all portal geometry in the BSP tree rooted at this node, traversing child nodes according to the camera’s position relative to each splitting plane and rendering only portals or their contents as specified by the flag.
    /// <code>Offset: 0x0053E5D0
    /// void __thiscall BSPPORTAL::portal_draw_portals_only(BSPPORTAL*,int)</code>
    /// </summary>
    /// <param name="portalPolyOrPortalContents">Specifies whether portal polygons themselves are rendered (e.g., 1) or if the content behind each portal is drawn; this value is passed through recursive calls.</param>
    public void portal_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, int, void>)0x0053E5D0)(ref this, portalPolyOrPortalContents);

    /// <summary>Destroys the BSPPORTAL instance by freeing all stored portal polygons, clearing internal arrays, and invoking the base node destructor to release remaining resources.
    /// <code>Offset: 0x0053E740
    /// void __thiscall BSPPORTAL::Destroy(BSPPORTAL*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void>)0x0053E740)(ref this);

    /// <summary>Computes the byte size required to serialize the current portal node and its children into a packed format, adjusting the calculation according to whether tree packing is enabled.
    /// <code>Offset: 0x0053E7A0
    /// unsigned int __thiscall BSPPORTAL::pack_portal_size(BSPPORTAL*)</code>
    /// </summary>
    /// <returns>The total number of bytes needed to represent this portal in the packed data stream.</returns>
    public uint pack_portal_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, uint>)0x0053E7A0)(ref this);

    /// <summary>Serializes a BSPPORTAL into a binary stream when the supplied buffer has sufficient space, returning the total byte count needed.
    /// <code>Offset: 0x0053E800
    /// unsigned int __thiscall BSPPORTAL::PackPortal(BSPPORTAL*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current write position in the buffer; updated as data is written.</param>
    /// <param name="size">Remaining capacity of the buffer; serialization proceeds only if size ≥ required bytes.</param>
    /// <returns>The number of bytes that would be written (the required buffer size).</returns>
    public uint PackPortal(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void**, uint, uint>)0x0053E800)(ref this, addr, size);

    /// <summary>Unpacks a BSPPORTAL instance from binary data, restoring its plane, child nodes, and optional portal information.
    /// <code>Offset: 0x0053E8D0
    /// int __thiscall BSPPORTAL::UnPackPortal(BSPPORTAL*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; will be advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer that may be read.</param>
    /// <returns>Non‑zero on successful unpacking, zero if the data is incomplete or corrupted.</returns>
    public int UnPackPortal(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPPORTAL, void**, uint, int>)0x0053E8D0)(ref this, addr, size);
}

