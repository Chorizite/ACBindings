namespace ACBindings;

// QuickWindow
public unsafe struct QuickWindow
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // QuickWindow_vtbl
    public unsafe struct QuickWindow_vtbl
    {
        // Members
        public System.IntPtr QuickWindow_dtor_0; // function pointer
        public System.IntPtr Render; // function pointer

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
    public ACBindings.RGBAColor m_ColorAndOpacity;
    public ACBindings.RenderTexture* m_pBackgroundTexture;
    public int m_ClientAreaX;
    public int m_ClientAreaY;
    public uint m_ClientAreaWidth;
    public uint m_ClientAreaHeight;

    // Methods
    // void __thiscall QuickWindow::SetWindowID(InterpolationManager*,CPhysicsObj*)
    public void SetWindowID(ACBindings.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, ACBindings.CPhysicsObj*, void>)0x0050A150)(ref this, new_physobj);
    // void __thiscall QuickWindow::SetColorAndOpacity(QuickWindow*,const RGBAColor*)
    public void SetColorAndOpacity(ACBindings.RGBAColor* ColorAndOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, ACBindings.RGBAColor*, void>)0x006998A0)(ref this, ColorAndOpacity);
    // void __thiscall QuickWindow::SetBackgroundTexture(QuickWindow*,RenderTexture*)
    public void SetBackgroundTexture(ACBindings.RenderTexture* pBackgroundTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, ACBindings.RenderTexture*, void>)0x006998C0)(ref this, pBackgroundTexture);
    // void __thiscall QuickWindow::RenderWindowBackground(QuickWindow*,RenderTexture*,const RGBAColor*)
    public void RenderWindowBackground(ACBindings.RenderTexture* pTexture, ACBindings.RGBAColor* ColorAndOpacity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, ACBindings.RenderTexture*, ACBindings.RGBAColor*, void>)0x006998F0)(ref this, pTexture, ColorAndOpacity);
    // void __thiscall QuickWindow::RenderText(QuickWindow*,const int,const int,const char*,const unsigned int)
    public void RenderText(int X, int Y, sbyte* pText, uint Color32) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, int, int, sbyte*, uint, void>)0x00699A30)(ref this, X, Y, pText, Color32);
    // bool __thiscall QuickWindow::Init(QuickWindow*,const int,const int,const unsigned int,const unsigned int,const unsigned int,const unsigned int)
    public byte Init(int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, int, int, uint, uint, uint, uint, byte>)0x00699B10)(ref this, X, Y, Width, Height, BorderWidth, BorderHeight);
    // void __thiscall QuickWindow::SetPosition(QuickWindow*,const int,const int)
    public void SetPosition(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, int, int, void>)0x00699B60)(ref this, X, Y);
    // void __thiscall QuickWindow::Render(QuickWindow*)
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuickWindow, void>)0x00699BA0)(ref this);
    // TResult* __cdecl QuickWindow::Create(TResult*,QuickWindow**,const int,const int,const unsigned int,const unsigned int,const unsigned int,const unsigned int)
    public static ACBindings.TResult* Create(ACBindings.TResult* result, ACBindings.QuickWindow** pOutObject, int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight) => ((delegate* unmanaged[Cdecl]<ACBindings.TResult*, ACBindings.QuickWindow**, int, int, uint, uint, uint, uint, ACBindings.TResult*>)0x00699BB0)(result, pOutObject, X, Y, Width, Height, BorderWidth, BorderHeight);
}

