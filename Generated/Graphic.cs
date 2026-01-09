namespace ACBindings;

// Graphic
public unsafe struct Graphic
{
    // Child Types
    // Graphic_vtbl
    public unsafe struct Graphic_vtbl
    {
        // Members
        public System.IntPtr Graphic_dtor_0; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.IDClass___tagDataID m_id;
    public ACBindings.RenderSurface* m_image;

    // Generated Constructor
    public Graphic(ACBindings.Graphic* rhs) {
        _ConstructorInternal(rhs);
    }
    public Graphic(ACBindings.RenderSurface* i_pSurface) {
        _ConstructorInternal(i_pSurface);
    }
    public Graphic(uint a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // int __thiscall Graphic::GetWidth(Graphic*)
    public int GetWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, int>)0x006948F0)(ref this);
    // int __thiscall Graphic::GetHeight(Graphic*)
    public int GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, int>)0x00694910)(ref this);
    // bool __thiscall Graphic::PointTest(Graphic*,int,int)
    public byte PointTest(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, int, int, byte>)0x00694930)(ref this, x, y);
    // void __thiscall Graphic::PutImage(Graphic*,BlitMode,float,const Box2D*,const Box2D*,UISurface*)
    public void PutImage(ACBindings.BlitMode eMode, float alphablendmod, ACBindings.Box2D* src, ACBindings.Box2D* dst, ACBindings.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, ACBindings.BlitMode, float, ACBindings.Box2D*, ACBindings.Box2D*, ACBindings.UISurface*, void>)0x00694950)(ref this, eMode, alphablendmod, src, dst, surface);
    // void __thiscall Graphic::Graphic(Graphic*,const Graphic*)
    public void _ConstructorInternal(ACBindings.Graphic* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, ACBindings.Graphic*, void>)0x00694A00)(ref this, rhs);
    // void __thiscall Graphic::Draw(Graphic*,BlitMode,float,const Box2D*,const Box2D*,const Box2D*,const tagPOINT*,UISurface*)
    public void Draw(ACBindings.BlitMode i_eBlitFlags, float alphablendmod, ACBindings.Box2D* bounds, ACBindings.Box2D* objectdirty, ACBindings.Box2D* elementdirty, ACBindings.tagPOINT* i_ptTilingOffset, ACBindings.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, ACBindings.BlitMode, float, ACBindings.Box2D*, ACBindings.Box2D*, ACBindings.Box2D*, ACBindings.tagPOINT*, ACBindings.UISurface*, void>)0x00694A40)(ref this, i_eBlitFlags, alphablendmod, bounds, objectdirty, elementdirty, i_ptTilingOffset, surface);
    // void __thiscall Graphic::SetToDefaultGraphic(Graphic*)
    public void SetToDefaultGraphic() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, void>)0x00694C90)(ref this);
    // void __thiscall Graphic::Graphic(Graphic*,RenderSurface*)
    public void _ConstructorInternal(ACBindings.RenderSurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, ACBindings.RenderSurface*, void>)0x00694D80)(ref this, i_pSurface);
    // Graphic* __thiscall Graphic::Graphic(Graphic*,unsigned int)
    public ACBindings.Graphic* _ConstructorInternal(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Graphic, uint, ACBindings.Graphic*>)0x00694E00)(ref this, a2);
}

