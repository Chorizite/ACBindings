namespace ACBindings.Internal;


/// <summary>Represents a lightweight UI window that stores position, size, border dimensions, optional background texture and color data, and manages its client area geometry for rendering.</summary>
public unsafe struct QuickWindow
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct QuickWindow_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickWindow*, void> QuickWindow_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickWindow*, void> Render; // function pointer

        // Methods
    }

    // Members
    public uint m_WindowID;
    public int m_X;
    public int m_Y;
    public uint m_Width;
    public uint m_Height;
    public uint m_BorderWidth;
    public uint m_BorderHeight;
    public ACBindings.Internal.RGBAColor m_ColorAndOpacity;
    public ACBindings.Internal.RenderTexture* m_pBackgroundTexture;
    public int m_ClientAreaX;
    public int m_ClientAreaY;
    public uint m_ClientAreaWidth;
    public uint m_ClientAreaHeight;

    // Methods

    /// <summary>Associates the specified physics object with this quick window, updating internal reference.
    /// <code>Offset: 0x0050A150
    /// void __thiscall QuickWindow::SetWindowID(InterpolationManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="new_physobj">The CPhysicsObj to bind to the window; may be nullptr to clear association.</param>
    public void SetWindowID(ACBindings.Internal.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.CPhysicsObj*, void>)0x0050A150)(ref this, new_physobj);

    /// <summary>Sets the QuickWindow's color and opacity based on the supplied RGBAColor value.
    /// <code>Offset: 0x006998A0
    /// void __thiscall QuickWindow::SetColorAndOpacity(QuickWindow*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="ColorAndOpacity">Pointer to an RGBAColor struct containing the desired color components and alpha value.</param>
    public void SetColorAndOpacity(ACBindings.Internal.RGBAColor* ColorAndOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.RGBAColor*, void>)0x006998A0)(ref this, ColorAndOpacity);

    /// <summary>Assigns a new background texture to the QuickWindow, updating reference counts and safely releasing any previously set texture.
    /// <code>Offset: 0x006998C0
    /// void __thiscall QuickWindow::SetBackgroundTexture(QuickWindow*,RenderTexture*)</code>
    /// </summary>
    /// <param name="pBackgroundTexture">The RenderTexture to set as the window's background; passing nullptr clears the current background.</param>
    public void SetBackgroundTexture(ACBindings.Internal.RenderTexture* pBackgroundTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.RenderTexture*, void>)0x006998C0)(ref this, pBackgroundTexture);

    /// <summary>Renders the window’s background as a quadrilateral, using an optional texture and a specified RGBA color.
    /// <code>Offset: 0x006998F0
    /// void __thiscall QuickWindow::RenderWindowBackground(QuickWindow*,RenderTexture*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="pTexture">The render texture to apply; if null, the background is drawn with a solid color.</param>
    /// <param name="ColorAndOpacity">RGBA color and opacity applied to the background polygon.</param>
    public void RenderWindowBackground(ACBindings.Internal.RenderTexture* pTexture, ACBindings.Internal.RGBAColor* ColorAndOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.RenderTexture*, ACBindings.Internal.RGBAColor*, void>)0x006998F0)(ref this, pTexture, ColorAndOpacity);

    /// <summary>Renders a debug text string at the specified client-area coordinates if within bounds using the global rendering device.
    /// <code>Offset: 0x00699A30
    /// void __thiscall QuickWindow::RenderText(QuickWindow*,const int,const int,const char*,const unsigned int)</code>
    /// </summary>
    /// <param name="X">Horizontal position relative to the window's client area.</param>
    /// <param name="Y">Vertical position relative to the window's client area.</param>
    /// <param name="pText">Null-terminated text string to display.</param>
    /// <param name="Color32">32‑bit color value for the text (e.g., ARGB).</param>
    public void RenderText(int X, int Y, sbyte* pText, uint Color32) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, int, int, sbyte*, uint, void>)0x00699A30)(ref this, X, Y, pText, Color32);

    /// <summary>Initializes window geometry, setting position, size, border dimensions, and computing the client area bounds accordingly.
    /// <code>Offset: 0x00699B10
    /// bool __thiscall QuickWindow::Init(QuickWindow*,const int,const int,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="X">The horizontal coordinate of the window's top-left corner.</param>
    /// <param name="Y">The vertical coordinate of the window's top-left corner.</param>
    /// <param name="Width">The total width of the window including borders.</param>
    /// <param name="Height">The total height of the window including borders.</param>
    /// <param name="BorderWidth">The thickness of the horizontal border on each side.</param>
    /// <param name="BorderHeight">The thickness of the vertical border at the top and bottom.</param>
    /// <returns>True after successful initialization.</returns>
    public byte Init(int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, int, int, uint, uint, uint, uint, byte>)0x00699B10)(ref this, X, Y, Width, Height, BorderWidth, BorderHeight);

    /// <summary>Sets the window's position to (X,Y) and recomputes its client area based on border dimensions.
    /// <code>Offset: 0x00699B60
    /// void __thiscall QuickWindow::SetPosition(QuickWindow*,const int,const int)</code>
    /// </summary>
    /// <param name="X">The new X coordinate for the window's top-left corner.</param>
    /// <param name="Y">The new Y coordinate for the window's top-left corner.</param>
    public void SetPosition(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, int, int, void>)0x00699B60)(ref this, X, Y);

    /// <summary>Renders the window background using the stored texture and color/opacity.
    /// <code>Offset: 0x00699BA0
    /// void __thiscall QuickWindow::Render(QuickWindow*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, void>)0x00699BA0)(ref this);

    /// <summary>Creates a QuickWindow with the specified position, size and border thickness, initializing its client area.
    /// <code>Offset: 0x00699BB0
    /// TResult* __cdecl QuickWindow::Create(TResult*,QuickWindow**,const int,const int,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="result">Status object whose m_val is set to 0 on success or a negative error code if allocation fails.</param>
    /// <param name="pOutObject">Set to the newly allocated QuickWindow when creation succeeds; otherwise null.</param>
    /// <param name="X">The x‑coordinate of the window’s top‑left corner.</param>
    /// <param name="Y">The y‑coordinate of the window’s top‑left corner.</param>
    /// <param name="Width">Total width, including borders.</param>
    /// <param name="Height">Total height, including borders.</param>
    /// <param name="BorderWidth">Horizontal border thickness applied to both left and right sides.</param>
    /// <param name="BorderHeight">Vertical border thickness applied to top and bottom.</param>
    /// <returns>Returns the supplied result pointer; m_val indicates success (0) or failure (negative).</returns>
    public static ACBindings.Internal.TResult* Create(ACBindings.Internal.TResult* result, ACBindings.Internal.QuickWindow** pOutObject, int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, ACBindings.Internal.QuickWindow**, int, int, uint, uint, uint, uint, ACBindings.Internal.TResult*>)0x00699BB0)(result, pOutObject, X, Y, Width, Height, BorderWidth, BorderHeight);
}

