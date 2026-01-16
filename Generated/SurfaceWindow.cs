namespace ACBindings.Internal;


/// <summary>Represents a rectangular section of a render surface used during drawing operations, storing its bounds, pixel buffer, and synchronization state.</summary>
public unsafe struct SurfaceWindow
{
    // Child Types

    /// <summary>Defines the virtual function table for a surface window, holding pointers to its destructor and facilitating polymorphic cleanup.</summary>
    public unsafe struct SurfaceWindow_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SurfaceWindow*, void> SurfaceWindow_dtor_0; // function pointer

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

    /// <summary>Checks whether the surface window has no active locks and can be considered ready to end.
    /// <code>Offset: 0x00440F40
    /// bool __thiscall SurfaceWindow::End(SurfaceWindow*)</code>
    /// </summary>
    /// <returns>True if lockCount equals zero; otherwise false.</returns>
    public byte End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, byte>)0x00440F40)(ref this);

    /// <summary>Attaches a render surface to the window, setting its display rectangle while clamping coordinates to valid bounds within the surface and ensuring a minimum size of one pixel.
    /// <code>Offset: 0x00440F50
    /// void __thiscall SurfaceWindow::Attach(SurfaceWindow*,RenderSurface*,const tagRECT*)</code>
    /// </summary>
    /// <param name="surface">The render surface to attach.</param>
    /// <param name="rect">Desired area within the surface to use for this window.</param>
    public void Attach(ACBindings.Internal.RenderSurface* surface, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, ACBindings.Internal.tagRECT*, void>)0x00440F50)(ref this, surface, rect);

    /// <summary>Attaches the specified render surface to this window over a rectangular area defined by top‑left (x0, y0) and bottom‑right (x1, y1). The coordinates are inclusive; internally they are converted to a RECT with right and bottom increased by one before attachment.
    /// <code>Offset: 0x00440FE0
    /// void __thiscall SurfaceWindow::Attach(SurfaceWindow*,RenderSurface*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="surface">The render surface to attach.</param>
    /// <param name="x0">Left coordinate of the rectangle.</param>
    /// <param name="y0">Top coordinate of the rectangle.</param>
    /// <param name="x1">Right coordinate (inclusive) of the rectangle.</param>
    /// <param name="y1">Bottom coordinate (inclusive) of the rectangle.</param>
    public void Attach(ACBindings.Internal.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, uint, uint, uint, uint, void>)0x00440FE0)(ref this, surface, x0, y0, x1, y1);

    /// <summary>Attaches the current surface window to a new parent, positioning it using the supplied rectangle relative to the parent’s client area.
    /// <code>Offset: 0x00441020
    /// void __thiscall SurfaceWindow::Attach(SurfaceWindow*,SurfaceWindow*,const tagRECT*)</code>
    /// </summary>
    /// <param name="window">The SurfaceWindow that will become this window’s parent.</param>
    /// <param name="rect">Rectangle specifying this window’s bounds and position relative to the parent.</param>
    public void Attach(ACBindings.Internal.SurfaceWindow* window, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.tagRECT*, void>)0x00441020)(ref this, window, rect);

    /// <summary>Transforms pixel coordinates (x, y) within this surface window into clip space coordinates using the associated RenderSurface dimensions.
    /// <code>Offset: 0x00441080
    /// void __thiscall SurfaceWindow::WindowToClip(SurfaceWindow*,const int,const int,float*,float*)</code>
    /// </summary>
    /// <param name="x">The horizontal pixel coordinate relative to the window's client area.</param>
    /// <param name="y">The vertical pixel coordinate relative to the window's client area.</param>
    /// <param name="clipX">Pointer to store the resulting X clip coordinate.</param>
    /// <param name="clipY">Pointer to store the resulting Y clip coordinate.</param>
    public void WindowToClip(int x, int y, float* clipX, float* clipY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, float*, float*, void>)0x00441080)(ref this, x, y, clipX, clipY);

    /// <summary>Locks the render surface or inherits a lock from its parent, tracking nesting and writable status.
    /// <code>Offset: 0x004410C0
    /// bool __thiscall SurfaceWindow::Lock(SurfaceWindow*,const bool)</code>
    /// </summary>
    /// <param name="readOnly">If true requests a read‑only lock; if false requests write access.</param>
    /// <returns>True when the lock succeeds; otherwise returns false (e.g., surface unavailable, conflicting lock mode, or query failure).</returns>
    public byte Lock(byte readOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, byte, byte>)0x004410C0)(ref this, readOnly);

    /// <summary>Decrements the lock count of a surface window, unlocking it and propagating the unlock to its parent when the count reaches zero.
    /// <code>Offset: 0x004411D0
    /// bool __thiscall SurfaceWindow::Unlock(SurfaceWindow*)</code>
    /// </summary>
    /// <returns>True if the window was successfully unlocked; otherwise false when no surface is present or the window was not locked.</returns>
    public byte Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, byte>)0x004411D0)(ref this);

    /// <summary>Copies the alpha component from the specified source surface window to this window.
    /// <code>Offset: 0x00441280
    /// bool __thiscall SurfaceWindow::CopyAlpha(SurfaceWindow*,const SurfaceWindow*)</code>
    /// </summary>
    /// <param name="i_swSource">The source surface window whose alpha channel will be copied.</param>
    /// <returns>True if the copy succeeded; false when locking fails or pixel format unsupported.</returns>
    public byte CopyAlpha(ACBindings.Internal.SurfaceWindow* i_swSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, byte>)0x00441280)(ref this, i_swSource);

    /// <summary>Draws a straight line between two points on the surface window, clipping to its bounds and applying the specified RGBA color.
    /// <code>Offset: 0x004413B0
    /// bool __thiscall SurfaceWindow::DrawLine(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)</code>
    /// </summary>
    /// <param name="color">The RGBA color used for the line.</param>
    /// <param name="aX">The x‑coordinate of the start point.</param>
    /// <param name="aY">The y‑coordinate of the start point.</param>
    /// <param name="bX">The x‑coordinate of the end point.</param>
    /// <param name="bY">The y‑coordinate of the end point.</param>
    /// <returns>True if the line was rendered successfully; false when coordinates lie outside the window or the surface cannot be locked.</returns>
    public byte DrawLine(ACBindings.Internal.RGBAColor* color, int aX, int aY, int bX, int bY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, int, int, byte>)0x004413B0)(ref this, color, aX, aY, bX, bY);

    /// <summary>Draws a rectangle on the window by connecting its corners with straight lines using the provided color. Returns true when all four sides are rendered successfully.
    /// <code>Offset: 0x00441590
    /// bool __thiscall SurfaceWindow::DrawBox(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)</code>
    /// </summary>
    /// <param name="this">The SurfaceWindow instance where the box is drawn.</param>
    /// <param name="color">Color of the rectangle edges specified as RGBA values.</param>
    /// <param name="tlX">X coordinate of the top-left corner.</param>
    /// <param name="tlY">Y coordinate of the top-left corner.</param>
    /// <param name="brX">X coordinate of the bottom-right corner.</param>
    /// <param name="brY">Y coordinate of the bottom-right corner.</param>
    /// <returns>True if all four edges were drawn without error; otherwise false.</returns>
    public byte DrawBox(ACBindings.Internal.RGBAColor* color, int tlX, int tlY, int brX, int brY) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, int, int, byte>)0x00441590)(ref this, color, tlX, tlY, brX, brY);

    /// <summary>Replaces every pixel that matches the specified old color with the new color in the SurfaceWindow's surface.
    /// <code>Offset: 0x004416D0
    /// bool __thiscall SurfaceWindow::ReplaceColor(SurfaceWindow*,const RGBAColor*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="i_oldColor">The source color to be replaced.</param>
    /// <param name="i_newColor">The color that will replace occurrences of i_oldColor.</param>
    /// <returns>True if the operation succeeded; otherwise, false (e.g., if locking failed).</returns>
    public byte ReplaceColor(ACBindings.Internal.RGBAColor* i_oldColor, ACBindings.Internal.RGBAColor* i_newColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, byte>)0x004416D0)(ref this, i_oldColor, i_newColor);

    /// <summary>Replaces every pixel in the current surface that matches a specified color with the corresponding pixel from another surface.
    /// <code>Offset: 0x00441750
    /// bool __thiscall SurfaceWindow::ReplaceColor(SurfaceWindow*,const RGBAColor*,const SurfaceWindow*)</code>
    /// </summary>
    /// <param name="i_oldColor">The RGBAColor value to be replaced on this surface.</param>
    /// <param name="i_newData">Surface providing replacement pixels; must be at least as large as the current surface.</param>
    /// <returns>True if the operation succeeds; false if the new surface is smaller than the current or if locking fails.</returns>
    public byte ReplaceColor(ACBindings.Internal.RGBAColor* i_oldColor, ACBindings.Internal.SurfaceWindow* i_newData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, ACBindings.Internal.SurfaceWindow*, byte>)0x00441750)(ref this, i_oldColor, i_newData);

    /// <summary>Determines whether a specified point lies within the window’s area and corresponds to an opaque pixel in its render surface.
    /// <code>Offset: 0x00441840
    /// bool __thiscall SurfaceWindow::PointTestOverlay(SurfaceWindow*,const int,const int)</code>
    /// </summary>
    /// <param name="x">The x-coordinate of the point relative to the window.</param>
    /// <param name="y">The y-coordinate of the point relative to the window.</param>
    /// <returns>True if the point is inside the bounds and the pixel value is non‑zero after masking alpha; otherwise, false.</returns>
    public byte PointTestOverlay(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, byte>)0x00441840)(ref this, x, y);

    /// <summary>Retrieves the color of a pixel at (x, y) within the window's surface into the supplied RGBAColor structure.
    /// <code>Offset: 0x004418D0
    /// bool __thiscall SurfaceWindow::GetColorFromPoint(SurfaceWindow*,RGBAColor*,const int,const int)</code>
    /// </summary>
    /// <param name="cColor">Output parameter that receives the color read from the surface.</param>
    /// <param name="x">Horizontal coordinate relative to the window's rectangle.</param>
    /// <param name="y">Vertical coordinate relative to the window's rectangle.</param>
    /// <returns>True if the pixel was successfully read; false when coordinates are outside bounds or the surface cannot be locked.</returns>
    public byte GetColorFromPoint(ACBindings.Internal.RGBAColor* cColor, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, byte>)0x004418D0)(ref this, cColor, x, y);

    /// <summary>Searches the surface window's pixel data for a specified RGBA color and outputs its coordinates. If bReturnClosest is true, returns the nearest matching pixel; otherwise stops at the first exact match.
    /// <code>Offset: 0x00441950
    /// bool __thiscall SurfaceWindow::SearchForColor(SurfaceWindow*,int*,int*,const RGBAColor*,bool)</code>
    /// </summary>
    /// <param name="o_x">Output parameter that receives the X coordinate of the found pixel.</param>
    /// <param name="o_y">Output parameter that receives the Y coordinate of the found pixel.</param>
    /// <param name="i_cColor">The RGBA color to search for within the surface data.</param>
    /// <param name="bReturnClosest">When true, the function searches for and returns the closest matching pixel instead of requiring an exact match.</param>
    /// <returns>True if an exact match was found (or when searching for a close match, always true after scanning). False only when an exact match is not located and bReturnClosest is false.</returns>
    public byte SearchForColor(int* o_x, int* o_y, ACBindings.Internal.RGBAColor* i_cColor, byte bReturnClosest) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int*, int*, ACBindings.Internal.RGBAColor*, byte, byte>)0x00441950)(ref this, o_x, o_y, i_cColor, bReturnClosest);

    /// <summary>Initializes a SurfaceWindow instance with an empty state: no attached RenderSurface, zero rectangle bounds, no parent window, and default locking/writability settings.
    /// <code>Offset: 0x00441CD0
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, void>)0x00441CD0)(ref this);

    /// <summary>Initializes a new SurfaceWindow instance and associates it with the specified RenderSurface using the provided rectangle.
    /// <code>Offset: 0x00441D00
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,RenderSurface*,const tagRECT*)</code>
    /// </summary>
    /// <param name="surface">Render surface to which the window will be attached.</param>
    /// <param name="rect">Defines the area of the render surface that this window covers.</param>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* surface, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, ACBindings.Internal.tagRECT*, void>)0x00441D00)(ref this, surface, rect);

    /// <summary>Creates a SurfaceWindow covering the rectangle from (x0,y0) to (x1,y1), inclusive, and attaches it to the specified RenderSurface.
    /// <code>Offset: 0x00441D40
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,RenderSurface*,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="surface">Render surface to which the window will be attached.</param>
    /// <param name="x0">Left coordinate of the window's bounding rectangle.</param>
    /// <param name="y0">Top coordinate of the window's bounding rectangle.</param>
    /// <param name="x1">Right coordinate (inclusive) of the window's bounding rectangle.</param>
    /// <param name="y1">Bottom coordinate (inclusive) of the window's bounding rectangle.</param>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* surface, uint x0, uint y0, uint x1, uint y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RenderSurface*, uint, uint, uint, uint, void>)0x00441D40)(ref this, surface, x0, y0, x1, y1);

    /// <summary>Initializes a new SurfaceWindow instance, clearing internal state and attaching it to the specified parent within the given rectangle.
    /// <code>Offset: 0x00441DB0
    /// void __thiscall SurfaceWindow::SurfaceWindow(SurfaceWindow*,SurfaceWindow*,const tagRECT*)</code>
    /// </summary>
    /// <param name="window">The parent surface window or owner for this new window.</param>
    /// <param name="rect">Defines the bounds of the surface window relative to its parent.</param>
    public void _ConstructorInternal(ACBindings.Internal.SurfaceWindow* window, ACBindings.Internal.tagRECT* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.tagRECT*, void>)0x00441DB0)(ref this, window, rect);

    /// <summary>Copies pixel data from source SurfaceWindow to this destination, applying optional alpha blending, dye tinting and format conversion according to flags.
    /// <code>Offset: 0x00441DF0
    /// bool __thiscall SurfaceWindow::LegacyBlit(SurfaceWindow*,const SurfaceWindow*,const unsigned int,const float,const RGBAColor*,const SurfaceWindow*)</code>
    /// </summary>
    /// <param name="this">Destination surface window onto which pixels are written.</param>
    /// <param name="source">Source surface window providing pixel data.</param>
    /// <param name="flags">Bitmask controlling behavior such as blending, color keying or special conversions.</param>
    /// <param name="AlphaBlendOpacity">Opacity factor (0.0 to 1.0) used when alpha blending is enabled.</param>
    /// <param name="pDyeColor">Optional dye color to tint destination pixels; may be null for no tint.</param>
    /// <param name="pDyeMask">Optional mask surface that limits where the dye is applied; may be null if not used.</param>
    /// <returns>True if blit succeeded and surfaces were unlocked; false if locking failed or operation could not complete.</returns>
    public byte LegacyBlit(ACBindings.Internal.SurfaceWindow* source, uint flags, float AlphaBlendOpacity, ACBindings.Internal.RGBAColor* pDyeColor, ACBindings.Internal.SurfaceWindow* pDyeMask) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, uint, float, ACBindings.Internal.RGBAColor*, ACBindings.Internal.SurfaceWindow*, byte>)0x00441DF0)(ref this, source, flags, AlphaBlendOpacity, pDyeColor, pDyeMask);

    /// <summary>Inverts all color components (red, green, blue) within the specified rectangle on the surface while preserving alpha data.
    /// <code>Offset: 0x00442780
    /// bool __thiscall SurfaceWindow::NotColorBits(SurfaceWindow*,const int,const int,const int,const int)</code>
    /// </summary>
    /// <param name="x0">Left coordinate of the target rectangle; clipped to the surface bounds (minimum 0).</param>
    /// <param name="y0">Top coordinate of the target rectangle; clipped similarly.</param>
    /// <param name="x1">Right coordinate; if beyond the surface right edge it is clamped.</param>
    /// <param name="y1">Bottom coordinate; clamped to the surface bottom.</param>
    /// <returns>True when the surface was successfully locked and contains an alpha channel; otherwise false.</returns>
    public byte NotColorBits(int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, int, int, byte>)0x00442780)(ref this, x0, y0, x1, y1);

    /// <summary>Copies pixel data from a source SurfaceWindow onto the destination (this), optionally applying color tint and an alpha mask according to specified modes.
    /// <code>Offset: 0x004428B0
    /// bool __thiscall SurfaceWindow::BlitAndColor(SurfaceWindow*,const SurfaceWindow*,BlitMode,float,const SurfaceWindow*,BlitMode,const unsigned int)</code>
    /// </summary>
    /// <param name="this">Destination surface window that receives the blitted image.</param>
    /// <param name="i_pswSource">Source SurfaceWindow whose pixels are copied.</param>
    /// <param name="i_eBlitMode">Defines how source pixels combine with destination pixels (e.g., normal, alpha blending).</param>
    /// <param name="i_fBlitModeMultiplier">Alpha factor multiplier applied during the blit operation.</param>
    /// <param name="i_pswAlpha">Optional alpha mask SurfaceWindow used to modulate transparency; may be null.</param>
    /// <param name="i_eColorMode">Specifies additional color blending or tinting (e.g., none, multiply).</param>
    /// <param name="i_dwARGB">32‑bit ARGB color value applied when color mode is active.</param>
    /// <returns>True if the blit succeeded; otherwise false (for invalid parameters or unsupported formats).</returns>
    public byte BlitAndColor(ACBindings.Internal.SurfaceWindow* i_pswSource, ACBindings.Internal.BlitMode i_eBlitMode, float i_fBlitModeMultiplier, ACBindings.Internal.SurfaceWindow* i_pswAlpha, ACBindings.Internal.BlitMode i_eColorMode, uint i_dwARGB) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, float, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, uint, byte>)0x004428B0)(ref this, i_pswSource, i_eBlitMode, i_fBlitModeMultiplier, i_pswAlpha, i_eColorMode, i_dwARGB);

    /// <summary>Copies pixel data from a source surface window to the current surface window using the specified blit mode and multiplier.
    /// <code>Offset: 0x00442C70
    /// bool __thiscall SurfaceWindow::Blit(SurfaceWindow*,const SurfaceWindow*,BlitMode,float)</code>
    /// </summary>
    /// <param name="i_swSource">The source surface window whose pixels will be copied.</param>
    /// <param name="i_eBlitMode">The blit operation to apply (e.g., copy, blend).</param>
    /// <param name="i_fBlitModeMultiplier">A factor that modulates the intensity of the blit effect.</param>
    /// <returns>True if the blitting succeeds; otherwise, false.</returns>
    public byte Blit(ACBindings.Internal.SurfaceWindow* i_swSource, ACBindings.Internal.BlitMode i_eBlitMode, float i_fBlitModeMultiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, float, byte>)0x00442C70)(ref this, i_swSource, i_eBlitMode, i_fBlitModeMultiplier);

    /// <summary>Applies a color overlay to the current surface window using the specified blend mode and optional alpha source. The operation blends the provided RGBA color into the target surface, optionally modulated by another surface's alpha channel.
    /// <code>Offset: 0x00442C90
    /// bool __thiscall SurfaceWindow::Color(SurfaceWindow*,const SurfaceWindow*,BlitMode,const RGBAColor*)</code>
    /// </summary>
    /// <param name="i_pswAlpha">Optional source surface used as an alpha mask when blending the color onto the target.</param>
    /// <param name="i_eColorMode">Blend mode determining how the supplied color is combined with the target surface.</param>
    /// <param name="i_rgbaColor">RGBA values (components range 0.0–1.0) specifying the color to apply.</param>
    /// <returns>True if the blit and color operation completed successfully; otherwise false.</returns>
    public byte Color(ACBindings.Internal.SurfaceWindow* i_pswAlpha, ACBindings.Internal.BlitMode i_eColorMode, ACBindings.Internal.RGBAColor* i_rgbaColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, ACBindings.Internal.RGBAColor*, byte>)0x00442C90)(ref this, i_pswAlpha, i_eColorMode, i_rgbaColor);

    /// <summary>Applies an ARGB color to the surface window, optionally using a separate alpha source and specifying the blit mode.
    /// <code>Offset: 0x00442D10
    /// bool __thiscall SurfaceWindow::Color(SurfaceWindow*,const SurfaceWindow*,BlitMode,unsigned int)</code>
    /// </summary>
    /// <param name="i_pswAlpha">Surface providing alpha values; if null, full opacity is used.</param>
    /// <param name="i_eColorMode">Blending mode applied when coloring the target surface.</param>
    /// <param name="i_dwARGB">Color value in ARGB format to apply.</param>
    /// <returns>True when the color was successfully applied; otherwise false.</returns>
    public byte Color(ACBindings.Internal.SurfaceWindow* i_pswAlpha, ACBindings.Internal.BlitMode i_eColorMode, uint i_dwARGB) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, ACBindings.Internal.BlitMode, uint, byte>)0x00442D10)(ref this, i_pswAlpha, i_eColorMode, i_dwARGB);

    /// <summary>Draws a Unicode character onto the surface window using the specified font and rendering flags, returning the horizontal pixel width occupied by the glyph.
    /// <code>Offset: 0x00442D30
    /// unsigned int __thiscall SurfaceWindow::DrawCharacter(SurfaceWindow*,const int,const int,const Font*,const unsigned __int16,unsigned int,const unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="this">The target SurfaceWindow where the character will be rendered.</param>
    /// <param name="x">X coordinate within the window’s client area at which to start drawing the glyph.</param>
    /// <param name="y">Y coordinate; currently unused by the implementation and ignored when positioning the glyph.</param>
    /// <param name="font">Font providing glyph metrics and texture surfaces. If null, no rendering occurs and zero width is returned.</param>
    /// <param name="ch">Unicode code point of the character to render. If no matching glyph exists, rendering is skipped and zero width is returned.</param>
    /// <param name="pfColor">Foreground color applied when the font’s foreground surface lacks an alpha channel or when the 0x8000 flag forces color over alpha.</param>
    /// <param name="flags">Bitmask controlling layout and rendering behavior:<br/>
    /// • 0x0001 – force width to be the font’s maxCharWidth + 1.<br/>
    /// • 0x1000 – include glyph’s horizontal offset before and after the bitmap when calculating width.<br/>
    /// • 0x4000 – draw the background surface if available.<br/>
    /// • 0x2000 – suppress foreground drawing (only background is rendered).<br/>
    /// • 0x8000 – force color over alpha on the foreground surface.<br/>
    /// • 0x0100 – when set, copy only the alpha channel from the source surface; otherwise, perform a full color blit.</param>
    /// <param name="pfBkColor">Background color used when rendering the background surface or filling transparent areas of the glyph.</param>
    /// <returns>Pixel width occupied by the rendered character. Returns zero if the font is null, the window is not locked, or no matching glyph is found.</returns>
    public uint DrawCharacter(int x, int y, ACBindings.Internal.Font* font, ushort ch, uint pfColor, uint flags, uint pfBkColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, int, int, ACBindings.Internal.Font*, ushort, uint, uint, uint, uint>)0x00442D30)(ref this, x, y, font, ch, pfColor, flags, pfBkColor);

    /// <summary>Fills the surface window with a solid RGBA color.
    /// <code>Offset: 0x00443040
    /// bool __thiscall SurfaceWindow::Fill(SurfaceWindow*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="color">The color to use for filling the entire area of the window.</param>
    /// <returns>True if the fill succeeded; otherwise false.</returns>
    public byte Fill(ACBindings.Internal.RGBAColor* color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, byte>)0x00443040)(ref this, color);

    /// <summary>Fills a rectangular region of the surface window with the specified RGBA color.
    /// <code>Offset: 0x004431B0
    /// bool __thiscall SurfaceWindow::FillArea(SurfaceWindow*,const RGBAColor*,const tagRECT*)</code>
    /// </summary>
    /// <param name="color">The color to use when filling the area.</param>
    /// <param name="area">The rectangle defining the portion of the window to fill, relative to the window's origin.</param>
    /// <returns>True if the area was successfully filled; otherwise false.</returns>
    public byte FillArea(ACBindings.Internal.RGBAColor* color, ACBindings.Internal.tagRECT* area) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, ACBindings.Internal.tagRECT*, byte>)0x004431B0)(ref this, color, area);

    /// <summary>Fills a rectangular area of the surface window with the specified RGBA color.
    /// <code>Offset: 0x00443250
    /// bool __thiscall SurfaceWindow::FillArea(SurfaceWindow*,const RGBAColor*,const int,const int,const int,const int)</code>
    /// </summary>
    /// <param name="color">Color to apply to each pixel within the region.</param>
    /// <param name="x0">Left coordinate of the rectangle (inclusive).</param>
    /// <param name="y0">Top coordinate of the rectangle (inclusive).</param>
    /// <param name="x1">Right coordinate of the rectangle (inclusive).</param>
    /// <param name="y1">Bottom coordinate of the rectangle (inclusive).</param>
    /// <returns>True if the area was successfully filled; otherwise, false.</returns>
    public byte FillArea(ACBindings.Internal.RGBAColor* color, int x0, int y0, int x1, int y1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.RGBAColor*, int, int, int, int, byte>)0x00443250)(ref this, color, x0, y0, x1, y1);

    /// <summary>Copies pixel data from a source SurfaceWindow into this target SurfaceWindow. If both windows share format and dimensions, the data is copied directly; otherwise, appropriate alpha handling or color blending is performed.
    /// <code>Offset: 0x00443290
    /// bool __thiscall SurfaceWindow::Blit(SurfaceWindow*,const SurfaceWindow*)</code>
    /// </summary>
    /// <param name="this">The destination SurfaceWindow to receive the blitted data.</param>
    /// <param name="i_swSource">The source SurfaceWindow whose pixel data will be transferred.</param>
    /// <returns>True if the blit succeeded and both surfaces were successfully locked; otherwise, false.</returns>
    public byte Blit(ACBindings.Internal.SurfaceWindow* i_swSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindow, ACBindings.Internal.SurfaceWindow*, byte>)0x00443290)(ref this, i_swSource);
}

