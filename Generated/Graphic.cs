namespace ACBindings.Internal;

public unsafe struct Graphic
{
    // Child Types
    public unsafe struct Graphic_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Graphic*, void> Graphic_dtor_0; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x006948F0
    /// int __thiscall Graphic::GetWidth(Graphic*)</code>
    /// </summary>
    public int GetWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, int>)0x006948F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00694910
    /// int __thiscall Graphic::GetHeight(Graphic*)</code>
    /// </summary>
    public int GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, int>)0x00694910)(ref this);

    /// <summary>
    /// <code>Offset: 0x00694930
    /// bool __thiscall Graphic::PointTest(Graphic*,int,int)</code>
    /// </summary>
    public byte PointTest(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, int, int, byte>)0x00694930)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x00694950
    /// void __thiscall Graphic::PutImage(Graphic*,BlitMode,float,const Box2D*,const Box2D*,UISurface*)</code>
    /// </summary>
    public void PutImage(ACBindings.Internal.BlitMode eMode, float alphablendmod, ACBindings.Internal.Box2D* src, ACBindings.Internal.Box2D* dst, ACBindings.Internal.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.BlitMode, float, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void>)0x00694950)(ref this, eMode, alphablendmod, src, dst, surface);

    /// <summary>
    /// <code>Offset: 0x00694A00
    /// void __thiscall Graphic::Graphic(Graphic*,const Graphic*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Graphic* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.Graphic*, void>)0x00694A00)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x00694A40
    /// void __thiscall Graphic::Draw(Graphic*,BlitMode,float,const Box2D*,const Box2D*,const Box2D*,const tagPOINT*,UISurface*)</code>
    /// </summary>
    public void Draw(ACBindings.Internal.BlitMode i_eBlitFlags, float alphablendmod, ACBindings.Internal.Box2D* bounds, ACBindings.Internal.Box2D* objectdirty, ACBindings.Internal.Box2D* elementdirty, ACBindings.Internal.tagPOINT* i_ptTilingOffset, ACBindings.Internal.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.BlitMode, float, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, ACBindings.Internal.tagPOINT*, ACBindings.Internal.UISurface*, void>)0x00694A40)(ref this, i_eBlitFlags, alphablendmod, bounds, objectdirty, elementdirty, i_ptTilingOffset, surface);

    /// <summary>
    /// <code>Offset: 0x00694C90
    /// void __thiscall Graphic::SetToDefaultGraphic(Graphic*)</code>
    /// </summary>
    public void SetToDefaultGraphic() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, void>)0x00694C90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00694D80
    /// void __thiscall Graphic::Graphic(Graphic*,RenderSurface*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, ACBindings.Internal.RenderSurface*, void>)0x00694D80)(ref this, i_pSurface);

    /// <summary>
    /// <code>Offset: 0x00694E00
    /// Graphic* __thiscall Graphic::Graphic(Graphic*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.Graphic* _ConstructorInternal(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Graphic, uint, ACBindings.Internal.Graphic*>)0x00694E00)(ref this, a2);
}

