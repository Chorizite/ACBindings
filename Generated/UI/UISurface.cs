namespace ACBindings;

// UISurface
public unsafe struct UISurface
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Statics
    public static int* s_nBytesConsumed = (int*)0x00838CD4;

    // Child Types
    // UISurface_vtbl
    public unsafe struct UISurface_vtbl
    {
        // Members
        public System.IntPtr UISurface_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.RenderTexture* m_pLocalTexture;
    public ACBindings.RenderSurface* m_pLocalSurface;
    public ACBindings.RenderTexture* m_pRemoteTexture;
    public System.IntPtr m_pVertexBuffer;
    public byte m_bHasAlpha;
    public uint m_nPhysicalWidth;
    public uint m_nPhysicalHeight;
    public byte m_IsInitialized;

    // Generated Constructor
    public UISurface() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UISurface::UISurface(UISurface*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, void>)0x004407F0)(ref this);
    // bool __thiscall UISurface::SetupVertexBuffer(UISurface*)
    public byte SetupVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, byte>)0x00440820)(ref this);
    // void __thiscall UISurface::DestroySurface(UISurface*)
    public void DestroySurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, void>)0x00440940)(ref this);
    // bool __cdecl UISurface::GetBestWidthHeight(const unsigned int,const unsigned int,unsigned int*,unsigned int*,const bool)
    public static byte GetBestWidthHeight(uint width, uint height, uint* bestWidth, uint* bestHeight, byte i_bForceCheck) => ((delegate* unmanaged[Cdecl]<uint, uint, uint*, uint*, byte, byte>)0x004409F0)(width, height, bestWidth, bestHeight, i_bForceCheck);
    // bool __cdecl UISurface::IsPowerOfTwo(const unsigned int,const unsigned int)
    public static byte IsPowerOfTwo(uint i_nWidth, uint i_nHeight) => ((delegate* unmanaged[Cdecl]<uint, uint, byte>)0x00440AD0)(i_nWidth, i_nHeight);
    // bool __thiscall UISurface::CreateSurface(UISurface*,const unsigned int,const unsigned int,const unsigned int)
    public byte CreateSurface(uint nWidth, uint nHeight, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, uint, uint, uint, byte>)0x00440B30)(ref this, nWidth, nHeight, Flags);
    // bool __thiscall UISurface::PrepareSurface(UISurface*)
    public byte PrepareSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, byte>)0x00440D20)(ref this);
    // bool __thiscall UISurface::Resize(UISurface*,const unsigned int,const unsigned int)
    public byte Resize(uint nNewWidth, uint nNewHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, uint, uint, byte>)0x00440DB0)(ref this, nNewWidth, nNewHeight);
    // bool __thiscall UISurface::RefreshHardware(UISurface*)
    public byte RefreshHardware() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UISurface, byte>)0x00440E50)(ref this);
}

