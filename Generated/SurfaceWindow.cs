namespace ACBindings.Internal;

public unsafe struct SurfaceWindow
{
    // Child Types
    public unsafe struct SurfaceWindow_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SurfaceWindow*, void> SurfaceWindow_dtor_0; // function pointer

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
    public ACBindings.Internal.RenderSurface* surface;
    public ACBindings.Internal.SurfaceWindow* parent;
    public ACBindings.Internal.tagRECT rect;
    public uint lockCount;
    public byte writable;
    public System.IntPtr data;
    public int pitch;

    // Generated Constructor
    public SurfaceWindow() {
        _ConstructorInternal();
    }
    public SurfaceWindow(ACBindings.Internal.RenderSurface* surface, ACBindings.Internal.tagRECT* rect) {
        _ConstructorInternal(surface, rect);
    }
    public SurfaceWindow(ACBindings.Internal.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) {
        _ConstructorInternal(surface, x0, y0, x1, y1);
    }
    public SurfaceWindow(ACBindings.Internal.SurfaceWindow* window, ACBindings.Internal.tagRECT* rect) {
        _ConstructorInternal(window, rect);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00440F40
    /// bool __thiscall SurfaceWindow::End(SurfaceWindow*)</code>
    /// </summary>
    public byte End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, byte>)0x00440F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00440F50
    /// void __thiscall SurfaceWindow::Attach(SurfaceWindow*,RenderSurface*,const tagRECT*)</code>
    /// </summary>
    public void Attach(ACBindings.Internal.RenderSurface* surface, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, ACBindings.Internal.tagRECT*, void>)0x00440F50)(ref this, surface, rect);

    /// <summary>
    /// <code>Offset: 0x00440FE0
    /// void __thiscall SurfaceWindow::Attach(SurfaceWindow*,RenderSurface*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void Attach(ACBindings.Internal.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, uint, uint, uint, uint, void>)0x00440FE0)(ref this, surface, x0, y0, x1, y1);

    /// <summary>
    /// <code>Offset: 0x00441020
    /// void __thiscall SurfaceWindow::Attach(SurfaceWindow*,SurfaceWindow*,const tagRECT*)</code>
    /// </summary>
    public void Attach(ACBindings.Internal.SurfaceWindow* window, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.tagRECT*, void>)0x00441020)(ref this, window, rect);

    /// <summary>
    /// <code>Offset: 0x00441080
    /// void __thiscall SurfaceWindow::WindowToClip(SurfaceWindow*,const int,const int,float*,float*)</code>
    /// </summary>
    public void WindowToClip(int x, int y, float* clipX, float* clipY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, float*, float*, void>)0x00441080)(ref this, x, y, clipX, clipY);

    /// <summary>
    /// <code>Offset: 0x004410C0
    /// bool __thiscall SurfaceWindow::Lock(SurfaceWindow*,const bool)</code>
    /// </summary>
    public byte Lock(byte readOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, byte, byte>)0x004410C0)(ref this, readOnly);

    /// <summary>
    /// <code>Offset: 0x004411D0
    /// bool __thiscall SurfaceWindow::Unlock(SurfaceWindow*)</code>
    /// </summary>
    public byte Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, byte>)0x004411D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00441280
    /// bool __thiscall SurfaceWindow::CopyAlpha(SurfaceWindow*,const SurfaceWindow*)</code>
    /// </summary>
    public byte CopyAlpha(ACBindings.Internal.SurfaceWindow* i_swSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, byte>)0x00441280)(ref this, i_swSource);

    /// <summary>
    /// <code>Offset: 0x004413B0
    /// bool __thiscall SurfaceWindow::DrawLine(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)</code>
    /// </summary>
    public byte DrawLine(ACBindings.Internal.RGBAColor* color, int aX, int aY, int bX, int bY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, int, int, byte>)0x004413B0)(ref this, color, aX, aY, bX, bY);

    /// <summary>
    /// <code>Offset: 0x00441590
    /// bool __thiscall SurfaceWindow::DrawBox(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)</code>
    /// </summary>
    public byte DrawBox(ACBindings.Internal.RGBAColor* color, int tlX, int tlY, int brX, int brY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, int, int, byte>)0x00441590)(ref this, color, tlX, tlY, brX, brY);

    /// <summary>
    /// <code>Offset: 0x004416D0
    /// bool __thiscall SurfaceWindow::ReplaceColor(SurfaceWindow*,const RGBAColor*,const RGBAColor*)</code>
    /// </summary>
    public byte ReplaceColor(ACBindings.Internal.RGBAColor* i_oldColor, ACBindings.Internal.RGBAColor* i_newColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, byte>)0x004416D0)(ref this, i_oldColor, i_newColor);

    /// <summary>
    /// <code>Offset: 0x00441750
    /// bool __thiscall SurfaceWindow::ReplaceColor(SurfaceWindow*,const RGBAColor*,const SurfaceWindow*)</code>
    /// </summary>
    public byte ReplaceColor(ACBindings.Internal.RGBAColor* i_oldColor, ACBindings.Internal.SurfaceWindow* i_newData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, ACBindings.Internal.SurfaceWindow*, byte>)0x00441750)(ref this, i_oldColor, i_newData);

    /// <summary>
    /// <code>Offset: 0x00441840
    /// bool __thiscall SurfaceWindow::PointTestOverlay(SurfaceWindow*,const int,const int)</code>
    /// </summary>
    public byte PointTestOverlay(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, byte>)0x00441840)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x004418D0
    /// bool __thiscall SurfaceWindow::GetColorFromPoint(SurfaceWindow*,RGBAColor*,const int,const int)</code>
    /// </summary>
    public byte GetColorFromPoint(ACBindings.Internal.RGBAColor* cColor, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, byte>)0x004418D0)(ref this, cColor, x, y);

    /// <summary>
    /// <code>Offset: 0x00441950
    /// bool __thiscall SurfaceWindow::SearchForColor(SurfaceWindow*,int*,int*,const RGBAColor*,bool)</code>
    /// </summary>
    public byte SearchForColor(int* o_x, int* o_y, ACBindings.Internal.RGBAColor* i_cColor, byte bReturnClosest) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int*, int*, ACBindings.Internal.RGBAColor*, byte, byte>)0x00441950)(ref this, o_x, o_y, i_cColor, bReturnClosest);

    /// <summary>
    /// <code>Offset: 0x00441CD0
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, void>)0x00441CD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00441D00
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,RenderSurface*,const tagRECT*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* surface, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, ACBindings.Internal.tagRECT*, void>)0x00441D00)(ref this, surface, rect);

    /// <summary>
    /// <code>Offset: 0x00441D40
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,RenderSurface*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, uint, uint, uint, uint, void>)0x00441D40)(ref this, surface, x0, y0, x1, y1);

    /// <summary>
    /// <code>Offset: 0x00441DB0
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,SurfaceWindow*,const tagRECT*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SurfaceWindow* window, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.tagRECT*, void>)0x00441DB0)(ref this, window, rect);

    /// <summary>
    /// <code>Offset: 0x00441DF0
    /// bool __thiscall SurfaceWindow::LegacyBlit(SurfaceWindow*,const SurfaceWindow*,const unsigned int,const float,const RGBAColor*,const SurfaceWindow*)</code>
    /// </summary>
    public byte LegacyBlit(ACBindings.Internal.SurfaceWindow* source, uint flags, float AlphaBlendOpacity, ACBindings.Internal.RGBAColor* pDyeColor, ACBindings.Internal.SurfaceWindow* pDyeMask) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, uint, float, ACBindings.Internal.RGBAColor*, ACBindings.Internal.SurfaceWindow*, byte>)0x00441DF0)(ref this, source, flags, AlphaBlendOpacity, pDyeColor, pDyeMask);

    /// <summary>
    /// <code>Offset: 0x00442780
    /// bool __thiscall SurfaceWindow::NotColorBits(SurfaceWindow*,const int,const int,const int,const int)</code>
    /// </summary>
    public byte NotColorBits(int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, int, int, byte>)0x00442780)(ref this, x0, y0, x1, y1);

    /// <summary>
    /// <code>Offset: 0x004428B0
    /// bool __thiscall SurfaceWindow::BlitAndColor(SurfaceWindow*,const SurfaceWindow*,BlitMode,float,const SurfaceWindow*,BlitMode,const unsigned int)</code>
    /// </summary>
    public byte BlitAndColor(ACBindings.Internal.SurfaceWindow* i_pswSource, ACBindings.Internal.BlitMode i_eBlitMode, float i_fBlitModeMultiplier, ACBindings.Internal.SurfaceWindow* i_pswAlpha, ACBindings.Internal.BlitMode i_eColorMode, uint i_dwARGB) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, float, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, uint, byte>)0x004428B0)(ref this, i_pswSource, i_eBlitMode, i_fBlitModeMultiplier, i_pswAlpha, i_eColorMode, i_dwARGB);

    /// <summary>
    /// <code>Offset: 0x00442C70
    /// bool __thiscall SurfaceWindow::Blit(SurfaceWindow*,const SurfaceWindow*,BlitMode,float)</code>
    /// </summary>
    public byte Blit(ACBindings.Internal.SurfaceWindow* i_swSource, ACBindings.Internal.BlitMode i_eBlitMode, float i_fBlitModeMultiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, float, byte>)0x00442C70)(ref this, i_swSource, i_eBlitMode, i_fBlitModeMultiplier);

    /// <summary>
    /// <code>Offset: 0x00442C90
    /// bool __thiscall SurfaceWindow::Color(SurfaceWindow*,const SurfaceWindow*,BlitMode,const RGBAColor*)</code>
    /// </summary>
    public byte Color(ACBindings.Internal.SurfaceWindow* i_pswAlpha, ACBindings.Internal.BlitMode i_eColorMode, ACBindings.Internal.RGBAColor* i_rgbaColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, ACBindings.Internal.RGBAColor*, byte>)0x00442C90)(ref this, i_pswAlpha, i_eColorMode, i_rgbaColor);

    /// <summary>
    /// <code>Offset: 0x00442D10
    /// bool __thiscall SurfaceWindow::Color(SurfaceWindow*,const SurfaceWindow*,BlitMode,unsigned int)</code>
    /// </summary>
    public byte Color(ACBindings.Internal.SurfaceWindow* i_pswAlpha, ACBindings.Internal.BlitMode i_eColorMode, uint i_dwARGB) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, uint, byte>)0x00442D10)(ref this, i_pswAlpha, i_eColorMode, i_dwARGB);

    /// <summary>
    /// <code>Offset: 0x00442D30
    /// unsigned int __thiscall SurfaceWindow::DrawCharacter(SurfaceWindow*,const int,const int,const Font*,const unsigned __int16,unsigned int,const unsigned int,unsigned int)</code>
    /// </summary>
    public uint DrawCharacter(int x, int y, ACBindings.Internal.Font* font, ushort ch, uint pfColor, uint flags, uint pfBkColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, ACBindings.Internal.Font*, ushort, uint, uint, uint, uint>)0x00442D30)(ref this, x, y, font, ch, pfColor, flags, pfBkColor);

    /// <summary>
    /// <code>Offset: 0x00443040
    /// bool __thiscall SurfaceWindow::Fill(SurfaceWindow*,const RGBAColor*)</code>
    /// </summary>
    public byte Fill(ACBindings.Internal.RGBAColor* color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, byte>)0x00443040)(ref this, color);

    /// <summary>
    /// <code>Offset: 0x004431B0
    /// bool __thiscall SurfaceWindow::FillArea(SurfaceWindow*,const RGBAColor*,const tagRECT*)</code>
    /// </summary>
    public byte FillArea(ACBindings.Internal.RGBAColor* color, ACBindings.Internal.tagRECT* area) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, ACBindings.Internal.tagRECT*, byte>)0x004431B0)(ref this, color, area);

    /// <summary>
    /// <code>Offset: 0x00443250
    /// bool __thiscall SurfaceWindow::FillArea(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)</code>
    /// </summary>
    public byte FillArea(ACBindings.Internal.RGBAColor* color, int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, int, int, byte>)0x00443250)(ref this, color, x0, y0, x1, y1);

    /// <summary>
    /// <code>Offset: 0x00443290
    /// bool __thiscall SurfaceWindow::Blit(SurfaceWindow*,const SurfaceWindow*)</code>
    /// </summary>
    public byte Blit(ACBindings.Internal.SurfaceWindow* i_swSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, byte>)0x00443290)(ref this, i_swSource);
}

