namespace ACBindings;

// SurfaceWindow
public unsafe struct SurfaceWindow
{
    // Child Types
    // SurfaceWindow_vtbl
    public unsafe struct SurfaceWindow_vtbl
    {
        // Members
        public System.IntPtr SurfaceWindow_dtor_0; // function pointer

        // Methods
    }
    // SurfaceWindow::WhichBufferArg
    public enum WhichBufferArg : byte
    {
        baBlit = 0x0,
        baMask = 0x1
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.RenderSurface* surface;
    public ACBindings.SurfaceWindow* parent;
    public ACBindings.tagRECT rect;
    public uint lockCount;
    public byte writable;
    public System.IntPtr data;
    public int pitch;

    // Generated Constructor
    public SurfaceWindow() {
        _ConstructorInternal();
    }
    public SurfaceWindow(ACBindings.RenderSurface* surface, ACBindings.tagRECT* rect) {
        _ConstructorInternal(surface, rect);
    }
    public SurfaceWindow(ACBindings.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) {
        _ConstructorInternal(surface, x0, y0, x1, y1);
    }
    public SurfaceWindow(ACBindings.SurfaceWindow* window, ACBindings.tagRECT* rect) {
        _ConstructorInternal(window, rect);
    }

    // Methods
    // bool __thiscall SurfaceWindow::End(SurfaceWindow*)
    public byte End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, byte>)0x00440F40)(ref this);
    // void __thiscall SurfaceWindow::Attach(SurfaceWindow*,RenderSurface*,const tagRECT*)
    public void Attach(ACBindings.RenderSurface* surface, ACBindings.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RenderSurface*, ACBindings.tagRECT*, void>)0x00440F50)(ref this, surface, rect);
    // void __thiscall SurfaceWindow::Attach(SurfaceWindow*,RenderSurface*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)
    public void Attach(ACBindings.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RenderSurface*, uint, uint, uint, uint, void>)0x00440FE0)(ref this, surface, x0, y0, x1, y1);
    // void __thiscall SurfaceWindow::Attach(SurfaceWindow*,SurfaceWindow*,const tagRECT*)
    public void Attach(ACBindings.SurfaceWindow* window, ACBindings.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, ACBindings.tagRECT*, void>)0x00441020)(ref this, window, rect);
    // void __thiscall SurfaceWindow::WindowToClip(SurfaceWindow*,const int,const int,float*,float*)
    public void WindowToClip(int x, int y, float* clipX, float* clipY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, int, int, float*, float*, void>)0x00441080)(ref this, x, y, clipX, clipY);
    // bool __thiscall SurfaceWindow::Lock(SurfaceWindow*,const bool)
    public byte Lock(byte readOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, byte, byte>)0x004410C0)(ref this, readOnly);
    // bool __thiscall SurfaceWindow::Unlock(SurfaceWindow*)
    public byte Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, byte>)0x004411D0)(ref this);
    // bool __thiscall SurfaceWindow::CopyAlpha(SurfaceWindow*,const SurfaceWindow*)
    public byte CopyAlpha(ACBindings.SurfaceWindow* i_swSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, byte>)0x00441280)(ref this, i_swSource);
    // bool __thiscall SurfaceWindow::DrawLine(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)
    public byte DrawLine(ACBindings.RGBAColor* color, int aX, int aY, int bX, int bY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, int, int, int, int, byte>)0x004413B0)(ref this, color, aX, aY, bX, bY);
    // bool __thiscall SurfaceWindow::DrawBox(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)
    public byte DrawBox(ACBindings.RGBAColor* color, int tlX, int tlY, int brX, int brY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, int, int, int, int, byte>)0x00441590)(ref this, color, tlX, tlY, brX, brY);
    // bool __thiscall SurfaceWindow::ReplaceColor(SurfaceWindow*,const RGBAColor*,const RGBAColor*)
    public byte ReplaceColor(ACBindings.RGBAColor* i_oldColor, ACBindings.RGBAColor* i_newColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, ACBindings.RGBAColor*, byte>)0x004416D0)(ref this, i_oldColor, i_newColor);
    // bool __thiscall SurfaceWindow::ReplaceColor(SurfaceWindow*,const RGBAColor*,const SurfaceWindow*)
    public byte ReplaceColor(ACBindings.RGBAColor* i_oldColor, ACBindings.SurfaceWindow* i_newData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, ACBindings.SurfaceWindow*, byte>)0x00441750)(ref this, i_oldColor, i_newData);
    // bool __thiscall SurfaceWindow::PointTestOverlay(SurfaceWindow*,const int,const int)
    public byte PointTestOverlay(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, int, int, byte>)0x00441840)(ref this, x, y);
    // bool __thiscall SurfaceWindow::GetColorFromPoint(SurfaceWindow*,RGBAColor*,const int,const int)
    public byte GetColorFromPoint(ACBindings.RGBAColor* cColor, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, int, int, byte>)0x004418D0)(ref this, cColor, x, y);
    // bool __thiscall SurfaceWindow::SearchForColor(SurfaceWindow*,int*,int*,const RGBAColor*,bool)
    public byte SearchForColor(int* o_x, int* o_y, ACBindings.RGBAColor* i_cColor, byte bReturnClosest) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, int*, int*, ACBindings.RGBAColor*, byte, byte>)0x00441950)(ref this, o_x, o_y, i_cColor, bReturnClosest);
    // void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, void>)0x00441CD0)(ref this);
    // void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,RenderSurface*,const tagRECT*)
    public void _ConstructorInternal(ACBindings.RenderSurface* surface, ACBindings.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RenderSurface*, ACBindings.tagRECT*, void>)0x00441D00)(ref this, surface, rect);
    // void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,RenderSurface*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)
    public void _ConstructorInternal(ACBindings.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RenderSurface*, uint, uint, uint, uint, void>)0x00441D40)(ref this, surface, x0, y0, x1, y1);
    // void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,SurfaceWindow*,const tagRECT*)
    public void _ConstructorInternal(ACBindings.SurfaceWindow* window, ACBindings.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, ACBindings.tagRECT*, void>)0x00441DB0)(ref this, window, rect);
    // bool __thiscall SurfaceWindow::LegacyBlit(SurfaceWindow*,const SurfaceWindow*,const unsigned int,const float,const RGBAColor*,const SurfaceWindow*)
    public byte LegacyBlit(ACBindings.SurfaceWindow* source, uint flags, float AlphaBlendOpacity, ACBindings.RGBAColor* pDyeColor, ACBindings.SurfaceWindow* pDyeMask) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, uint, float, ACBindings.RGBAColor*, ACBindings.SurfaceWindow*, byte>)0x00441DF0)(ref this, source, flags, AlphaBlendOpacity, pDyeColor, pDyeMask);
    // bool __thiscall SurfaceWindow::NotColorBits(SurfaceWindow*,const int,const int,const int,const int)
    public byte NotColorBits(int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, int, int, int, int, byte>)0x00442780)(ref this, x0, y0, x1, y1);
    // bool __thiscall SurfaceWindow::BlitAndColor(SurfaceWindow*,const SurfaceWindow*,BlitMode,float,const SurfaceWindow*,BlitMode,const unsigned int)
    public byte BlitAndColor(ACBindings.SurfaceWindow* i_pswSource, ACBindings.BlitMode i_eBlitMode, float i_fBlitModeMultiplier, ACBindings.SurfaceWindow* i_pswAlpha, ACBindings.BlitMode i_eColorMode, uint i_dwARGB) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, ACBindings.BlitMode, float, ACBindings.SurfaceWindow*, ACBindings.BlitMode, uint, byte>)0x004428B0)(ref this, i_pswSource, i_eBlitMode, i_fBlitModeMultiplier, i_pswAlpha, i_eColorMode, i_dwARGB);
    // bool __thiscall SurfaceWindow::Blit(SurfaceWindow*,const SurfaceWindow*,BlitMode,float)
    public byte Blit(ACBindings.SurfaceWindow* i_swSource, ACBindings.BlitMode i_eBlitMode, float i_fBlitModeMultiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, ACBindings.BlitMode, float, byte>)0x00442C70)(ref this, i_swSource, i_eBlitMode, i_fBlitModeMultiplier);
    // bool __thiscall SurfaceWindow::Color(SurfaceWindow*,const SurfaceWindow*,BlitMode,const RGBAColor*)
    public byte Color(ACBindings.SurfaceWindow* i_pswAlpha, ACBindings.BlitMode i_eColorMode, ACBindings.RGBAColor* i_rgbaColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, ACBindings.BlitMode, ACBindings.RGBAColor*, byte>)0x00442C90)(ref this, i_pswAlpha, i_eColorMode, i_rgbaColor);
    // bool __thiscall SurfaceWindow::Color(SurfaceWindow*,const SurfaceWindow*,BlitMode,unsigned int)
    public byte Color(ACBindings.SurfaceWindow* i_pswAlpha, ACBindings.BlitMode i_eColorMode, uint i_dwARGB) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, ACBindings.BlitMode, uint, byte>)0x00442D10)(ref this, i_pswAlpha, i_eColorMode, i_dwARGB);
    // unsigned int __thiscall SurfaceWindow::DrawCharacter(SurfaceWindow*,const int,const int,const Font*,const unsigned __int16,unsigned int,const unsigned int,unsigned int)
    public uint DrawCharacter(int x, int y, ACBindings.Font* font, ushort ch, uint pfColor, uint flags, uint pfBkColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, int, int, ACBindings.Font*, ushort, uint, uint, uint, uint>)0x00442D30)(ref this, x, y, font, ch, pfColor, flags, pfBkColor);
    // bool __thiscall SurfaceWindow::Fill(SurfaceWindow*,const RGBAColor*)
    public byte Fill(ACBindings.RGBAColor* color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, byte>)0x00443040)(ref this, color);
    // bool __thiscall SurfaceWindow::FillArea(SurfaceWindow*,const RGBAColor*,const tagRECT*)
    public byte FillArea(ACBindings.RGBAColor* color, ACBindings.tagRECT* area) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, ACBindings.tagRECT*, byte>)0x004431B0)(ref this, color, area);
    // bool __thiscall SurfaceWindow::FillArea(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)
    public byte FillArea(ACBindings.RGBAColor* color, int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.RGBAColor*, int, int, int, int, byte>)0x00443250)(ref this, color, x0, y0, x1, y1);
    // bool __thiscall SurfaceWindow::Blit(SurfaceWindow*,const SurfaceWindow*)
    public byte Blit(ACBindings.SurfaceWindow* i_swSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindow, ACBindings.SurfaceWindow*, byte>)0x00443290)(ref this, i_swSource);
}

