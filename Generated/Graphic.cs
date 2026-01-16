namespace ACBindings.Internal;


/// <summary>Represents a graphical element, linking a unique identifier to its render surface for display.</summary>
public unsafe struct Graphic
{
    // Child Types

    /// <summary>VTable structure for Graphic objects, containing pointers to virtual functions such as the destructor.</summary>
    public unsafe struct Graphic_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Graphic*, void> Graphic_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IDClass____tagDataID m_id;
    public ACBindings.Internal.RenderSurface* m_image;

    // Generated Constructor
    public Graphic(ACBindings.Internal.Graphic* rhs) {
        _ConstructorInternal(rhs);
    }
    public Graphic(ACBindings.Internal.RenderSurface* i_pSurface) {
        _ConstructorInternal(i_pSurface);
    }
    public Graphic(uint a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Returns the width of the graphic’s image surface or zero when no image exists.
    /// <code>Offset: 0x006948F0
    /// int __thiscall Graphic::GetWidth(Graphic*)</code>
    /// </summary>
    /// <returns>The width in pixels.</returns>
    public int GetWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, int>)0x006948F0)(ref this);

    /// <summary>Retrieves the pixel height of the graphic's render surface; returns zero when no image is present.
    /// <code>Offset: 0x00694910
    /// int __thiscall Graphic::GetHeight(Graphic*)</code>
    /// </summary>
    /// <returns>The height in pixels, or 0 if the graphic has no associated image.</returns>
    public int GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, int>)0x00694910)(ref this);

    /// <summary>Tests whether the specified screen coordinates lie inside the graphic's image surface overlay.
    /// <code>Offset: 0x00694930
    /// bool __thiscall Graphic::PointTest(Graphic*,int,int)</code>
    /// </summary>
    /// <param name="x">The X coordinate to test.</param>
    /// <param name="y">The Y coordinate to test.</param>
    /// <returns>True if the point is within the overlay; otherwise, false.</returns>
    public byte PointTest(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, int, int, byte>)0x00694930)(ref this, x, y);

    /// <summary>Blits a selected portion of this Graphic's internal render surface onto the provided UISurface using the specified blend mode and alpha factor.
    /// <code>Offset: 0x00694950
    /// void __thiscall Graphic::PutImage(Graphic*,BlitMode,float,const Box2D*,const Box2D*,UISurface*)</code>
    /// </summary>
    /// <param name="eMode">The blending mode applied during the blit operation.</param>
    /// <param name="alphablendmod">Multiplier for the source image’s alpha channel used when blending.</param>
    /// <param name="src">Rectangle on this Graphic’s image that defines which portion to copy.</param>
    /// <param name="dst">Rectangle specifying where on the target UISurface the copied pixels should be rendered; its fields contain the destination coordinates.</param>
    /// <param name="surface">The UISurface onto which the source region is blitted.</param>
    public void PutImage(ACBindings.Internal.BlitMode eMode, float alphablendmod, ACBindings.Internal.Box2D* src, ACBindings.Internal.Box2D* dst, ACBindings.Internal.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.BlitMode, float, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void>)0x00694950)(ref this, eMode, alphablendmod, src, dst, surface);

    /// <summary>Constructs a Graphic instance by copying the identifier and image reference from another Graphic object, initializing internal state and managing reference counts.
    /// <code>Offset: 0x00694A00
    /// void __thiscall Graphic::Graphic(Graphic*,const Graphic*)</code>
    /// </summary>
    /// <param name="rhs">The source Graphic to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.Graphic* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.Graphic*, void>)0x00694A00)(ref this, rhs);

    /// <summary>Draws a portion of this Graphic's image onto the specified UISurface using the given blit mode and alpha blend factor, clipping to the destination bounds and supporting optional tiled rendering with an offset.
    /// <code>Offset: 0x00694A40
    /// void __thiscall Graphic::Draw(Graphic*,BlitMode,float,const Box2D*,const Box2D*,const Box2D*,const tagPOINT*,UISurface*)</code>
    /// </summary>
    /// <param name="i_eBlitFlags">Defines how pixels are combined during the copy (e.g., blending modes).</param>
    /// <param name="alphablendmod">Alpha multiplier applied when blending pixels.</param>
    /// <param name="bounds">Destination rectangle on the UISurface where the image will be rendered.</param>
    /// <param name="objectdirty">Rectangular region of the source image that has changed and should be considered during drawing.</param>
    /// <param name="elementdirty">Source rectangle within this->m_image to copy from.</param>
    /// <param name="i_ptTilingOffset">Offset applied when tiling the image across the destination area.</param>
    /// <param name="surface">Target UISurface onto which the image is drawn.</param>
    public void Draw(ACBindings.Internal.BlitMode i_eBlitFlags, float alphablendmod, ACBindings.Internal.Box2D* bounds, ACBindings.Internal.Box2D* objectdirty, ACBindings.Internal.Box2D* elementdirty, ACBindings.Internal.tagPOINT* i_ptTilingOffset, ACBindings.Internal.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.BlitMode, float, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, ACBindings.Internal.tagPOINT*, ACBindings.Internal.UISurface*, void>)0x00694A40)(ref this, i_eBlitFlags, alphablendmod, bounds, objectdirty, elementdirty, i_ptTilingOffset, surface);

    /// <summary>
    /// Creates a 32‑pixel square UI render surface for the graphic and initializes it with a background color and white border.
    /// 
    /// <code>Offset: 0x00694C90
    /// void __thiscall Graphic::SetToDefaultGraphic(Graphic*)</code>
    /// </summary>
    public void SetToDefaultGraphic() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, void>)0x00694C90)(ref this);

    /// <summary>Initializes a Graphic instance with an optional RenderSurface, establishing its identifier and reference count or resetting to a default graphic when no surface is supplied.
    /// <code>Offset: 0x00694D80
    /// void __thiscall Graphic::Graphic(Graphic*,RenderSurface*)</code>
    /// </summary>
    /// <param name="i_pSurface">Render surface to associate with the graphic; if nullptr the object reverts to its default state.</param>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.RenderSurface*, void>)0x00694D80)(ref this, i_pSurface);

    /// <summary>Initializes a Graphic instance with the specified identifier, loading its RenderSurface from the database and assigning a default if unavailable.
    /// <code>Offset: 0x00694E00
    /// Graphic* __thiscall Graphic::Graphic(Graphic*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The unique ID used to locate the graphic resource.</param>
    /// <returns>A pointer to the initialized Graphic object.</returns>
    public ACBindings.Internal.Graphic* _ConstructorInternal(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, uint, ACBindings.Internal.Graphic*>)0x00694E00)(ref this, a2);
}

