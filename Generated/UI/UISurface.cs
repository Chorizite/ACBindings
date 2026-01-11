namespace ACBindings.Internal;

public unsafe struct UISurface
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Statics
    public static int* s_nBytesConsumed = (int*)0x00838CD4;

    // Child Types
    public unsafe struct UISurface_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurface*, void> UISurface_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RenderTexture* m_pLocalTexture;
    public ACBindings.Internal.RenderSurface* m_pLocalSurface;
    public ACBindings.Internal.RenderTexture* m_pRemoteTexture;
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

    /// <summary>
    /// <code>Offset: 0x004407F0
    /// void __thiscall UISurface::UISurface(UISurface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, void>)0x004407F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00440820
    /// bool __thiscall UISurface::SetupVertexBuffer(UISurface*)</code>
    /// </summary>
    public byte SetupVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, byte>)0x00440820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00440940
    /// void __thiscall UISurface::DestroySurface(UISurface*)</code>
    /// </summary>
    public void DestroySurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, void>)0x00440940)(ref this);

    /// <summary>
    /// <code>Offset: 0x004409F0
    /// bool __cdecl UISurface::GetBestWidthHeight(const unsigned int,const unsigned int,unsigned int*,unsigned int*,const bool)</code>
    /// </summary>
    public static byte GetBestWidthHeight(uint width, uint height, uint* bestWidth, uint* bestHeight, byte i_bForceCheck) => ((delegate* unmanaged[Cdecl]<uint, uint, uint*, uint*, byte, byte>)0x004409F0)(width, height, bestWidth, bestHeight, i_bForceCheck);

    /// <summary>
    /// <code>Offset: 0x00440AD0
    /// bool __cdecl UISurface::IsPowerOfTwo(const unsigned int,const unsigned int)</code>
    /// </summary>
    public static byte IsPowerOfTwo(uint i_nWidth, uint i_nHeight) => ((delegate* unmanaged[Cdecl]<uint, uint, byte>)0x00440AD0)(i_nWidth, i_nHeight);

    /// <summary>
    /// <code>Offset: 0x00440B30
    /// bool __thiscall UISurface::CreateSurface(UISurface*,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte CreateSurface(uint nWidth, uint nHeight, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, uint, uint, uint, byte>)0x00440B30)(ref this, nWidth, nHeight, Flags);

    /// <summary>
    /// <code>Offset: 0x00440D20
    /// bool __thiscall UISurface::PrepareSurface(UISurface*)</code>
    /// </summary>
    public byte PrepareSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, byte>)0x00440D20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00440DB0
    /// bool __thiscall UISurface::Resize(UISurface*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte Resize(uint nNewWidth, uint nNewHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, uint, uint, byte>)0x00440DB0)(ref this, nNewWidth, nNewHeight);

    /// <summary>
    /// <code>Offset: 0x00440E50
    /// bool __thiscall UISurface::RefreshHardware(UISurface*)</code>
    /// </summary>
    public byte RefreshHardware() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, byte>)0x00440E50)(ref this);
}

