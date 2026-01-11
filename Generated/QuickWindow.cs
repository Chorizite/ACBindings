namespace ACBindings.Internal;

public unsafe struct QuickWindow
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct QuickWindow_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickWindow*, void> QuickWindow_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickWindow*, void> Render; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0050A150
    /// void __thiscall QuickWindow::SetWindowID(InterpolationManager*,CPhysicsObj*)</code>
    /// </summary>
    public void SetWindowID(ACBindings.Internal.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.CPhysicsObj*, void>)0x0050A150)(ref this, new_physobj);

    /// <summary>
    /// <code>Offset: 0x006998A0
    /// void __thiscall QuickWindow::SetColorAndOpacity(QuickWindow*,const RGBAColor*)</code>
    /// </summary>
    public void SetColorAndOpacity(ACBindings.Internal.RGBAColor* ColorAndOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.RGBAColor*, void>)0x006998A0)(ref this, ColorAndOpacity);

    /// <summary>
    /// <code>Offset: 0x006998C0
    /// void __thiscall QuickWindow::SetBackgroundTexture(QuickWindow*,RenderTexture*)</code>
    /// </summary>
    public void SetBackgroundTexture(ACBindings.Internal.RenderTexture* pBackgroundTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.RenderTexture*, void>)0x006998C0)(ref this, pBackgroundTexture);

    /// <summary>
    /// <code>Offset: 0x006998F0
    /// void __thiscall QuickWindow::RenderWindowBackground(QuickWindow*,RenderTexture*,const RGBAColor*)</code>
    /// </summary>
    public void RenderWindowBackground(ACBindings.Internal.RenderTexture* pTexture, ACBindings.Internal.RGBAColor* ColorAndOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, ACBindings.Internal.RenderTexture*, ACBindings.Internal.RGBAColor*, void>)0x006998F0)(ref this, pTexture, ColorAndOpacity);

    /// <summary>
    /// <code>Offset: 0x00699A30
    /// void __thiscall QuickWindow::RenderText(QuickWindow*,const int,const int,const char*,const unsigned int)</code>
    /// </summary>
    public void RenderText(int X, int Y, sbyte* pText, uint Color32) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, int, int, sbyte*, uint, void>)0x00699A30)(ref this, X, Y, pText, Color32);

    /// <summary>
    /// <code>Offset: 0x00699B10
    /// bool __thiscall QuickWindow::Init(QuickWindow*,const int,const int,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte Init(int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, int, int, uint, uint, uint, uint, byte>)0x00699B10)(ref this, X, Y, Width, Height, BorderWidth, BorderHeight);

    /// <summary>
    /// <code>Offset: 0x00699B60
    /// void __thiscall QuickWindow::SetPosition(QuickWindow*,const int,const int)</code>
    /// </summary>
    public void SetPosition(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, int, int, void>)0x00699B60)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x00699BA0
    /// void __thiscall QuickWindow::Render(QuickWindow*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickWindow, void>)0x00699BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00699BB0
    /// TResult* __cdecl QuickWindow::Create(TResult*,QuickWindow**,const int,const int,const unsigned int,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.TResult* Create(ACBindings.Internal.TResult* result, ACBindings.Internal.QuickWindow** pOutObject, int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.TResult*, ACBindings.Internal.QuickWindow**, int, int, uint, uint, uint, uint, ACBindings.Internal.TResult*>)0x00699BB0)(result, pOutObject, X, Y, Width, Height, BorderWidth, BorderHeight);
}

