namespace ACBindings.Internal;


/// <summary>
/// Represents an off‑screen UI surface that holds local and remote textures, a render surface, and a vertex buffer for drawing.
/// Tracks whether it has been initialized and if it contains an alpha channel, allowing creation, resizing, refreshing, and destruction while managing GPU resources.
/// </summary>
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UISurface*, void> UISurface_dtor_0; // function pointer

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

    /// <summary>Initializes a new UISurface object with default values, setting the reference count to one and clearing all texture, surface, vertex buffer pointers, and flags.
    /// <code>Offset: 0x004407F0
    /// void __thiscall UISurface::UISurface(UISurface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, void>)0x004407F0)(ref this);

    /// <summary>Initializes the surface’s vertex buffer by allocating a new buffer, setting its attributes and uploading vertex data. If an existing buffer is present it is released first.
    /// <code>Offset: 0x00440820
    /// bool __thiscall UISurface::SetupVertexBuffer(UISurface*)</code>
    /// </summary>
    /// <returns>True if allocation and initialization succeed; otherwise false.</returns>
    public byte SetupVertexBuffer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, byte>)0x00440820)(ref this);

    /// <summary>Releases all graphics resources associated with the surface and marks it as uninitialized.
    /// <code>Offset: 0x00440940
    /// void __thiscall UISurface::DestroySurface(UISurface*)</code>
    /// </summary>
    public void DestroySurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, void>)0x00440940)(ref this);

    /// <summary>Determines the optimal width and height for a surface, adjusting requested values to power‑of‑two sizes or limiting them to 2048 when necessary.
    /// <code>Offset: 0x004409F0
    /// bool __cdecl UISurface::GetBestWidthHeight(const unsigned int,const unsigned int,unsigned int*,unsigned int*,const bool)</code>
    /// </summary>
    /// <param name="width">The desired width of the surface. If zero, no adjustment is performed.</param>
    /// <param name="height">The desired height of the surface. If zero, no adjustment is performed.</param>
    /// <param name="bestWidth">Receives the calculated best width based on power‑of‑two alignment and device constraints.</param>
    /// <param name="bestHeight">Receives the calculated best height based on power‑of‑two alignment and device constraints.</param>
    /// <param name="i_bForceCheck">When true, forces recalculation even if the render device is initialized; otherwise the supplied dimensions are used directly.</param>
    /// <returns>True to indicate that the calculation was performed (the function always returns true).</returns>
    public static byte GetBestWidthHeight(uint width, uint height, uint* bestWidth, uint* bestHeight, byte i_bForceCheck) => ((delegate* unmanaged[Cdecl]<uint, uint, uint*, uint*, byte, byte>)0x004409F0)(width, height, bestWidth, bestHeight, i_bForceCheck);

    /// <summary>Checks if the supplied width and height are power‑of‑two dimensions by comparing them against the nearest power‑of‑two values returned from UISurface::GetBestWidthHeight.
    /// <code>Offset: 0x00440AD0
    /// bool __cdecl UISurface::IsPowerOfTwo(const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="i_nWidth">The width to test for a power‑of‑two size.</param>
    /// <param name="i_nHeight">The height to test for a power‑of‑two size.</param>
    /// <returns>True if both dimensions match the nearest power‑of‑two values; otherwise, false.</returns>
    public static byte IsPowerOfTwo(uint i_nWidth, uint i_nHeight) => ((delegate* unmanaged[Cdecl]<uint, uint, byte>)0x00440AD0)(i_nWidth, i_nHeight);

    /// <summary>Creates an off‑screen UI surface of the specified width and height. The surface may contain an alpha channel if flag bit 0 is set.
    /// <code>Offset: 0x00440B30
    /// bool __thiscall UISurface::CreateSurface(UISurface*,const unsigned int,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="nWidth">The desired width in pixels, which must be greater than zero and no larger than 2048.</param>
    /// <param name="nHeight">The desired height in pixels, which must be greater than zero and no larger than 2048.</param>
    /// <param name="Flags">Bit flags controlling surface features; bit 0 requests an alpha channel.</param>
    /// <returns>True if the surface was successfully created and initialized; otherwise false.</returns>
    public byte CreateSurface(uint nWidth, uint nHeight, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, uint, uint, uint, byte>)0x00440B30)(ref this, nWidth, nHeight, Flags);

    /// <summary>Prepares the UI surface for rendering by ensuring its local texture and render surface are valid. If either component has been lost or the surface is uninitialized, it recreates them using stored width, height, and alpha settings.
    /// <code>Offset: 0x00440D20
    /// bool __thiscall UISurface::PrepareSurface(UISurface*)</code>
    /// </summary>
    /// <returns>True when the surface is successfully prepared and ready for use; false if preparation fails or the surface remains uninitialized.</returns>
    public byte PrepareSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, byte>)0x00440D20)(ref this);

    /// <summary>Resizes the surface to the specified width and height within allowed limits.
    /// <code>Offset: 0x00440DB0
    /// bool __thiscall UISurface::Resize(UISurface*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="nNewWidth">Desired width in pixels (must be greater than 0 and not exceed 2048).</param>
    /// <param name="nNewHeight">Desired height in pixels (must be greater than 0 and not exceed 2048).</param>
    /// <returns>True if the surface was successfully resized; otherwise, false.</returns>
    public byte Resize(uint nNewWidth, uint nNewHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, uint, uint, byte>)0x00440DB0)(ref this, nNewWidth, nNewHeight);

    /// <summary>Refreshes the hardware representation of a surface by ensuring the remote texture matches the local texture and handling lost resources.
    /// <code>Offset: 0x00440E50
    /// bool __thiscall UISurface::RefreshHardware(UISurface*)</code>
    /// </summary>
    /// <returns>True when the refresh succeeds or is unnecessary; false if initialization, preparation, or resource creation fails.</returns>
    public byte RefreshHardware() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UISurface, byte>)0x00440E50)(ref this);
}

