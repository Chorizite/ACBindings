namespace ACBindings.Internal;


/// <summary>Manages a vertex collection for rendering, supporting optional virtual storage that can be refreshed, locked, and bound to hardware formats while maintaining bounding boxes.</summary>
public unsafe struct RenderVertexBuffer
{
    // Base Classes
    public ACBindings.Internal.VertexArray BaseClass_VertexArray; // ACBindings.Internal.VertexArray

    // Child Types
    public unsafe struct RenderVertexBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, void> RenderVertexBuffer_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, uint, uint, byte, byte, uint, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, uint, uint, System.IntPtr> Lock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBuffer*, byte, byte, void> Unlock; // function pointer
        public System.IntPtr RenderIndexedPrimitives;
        public System.IntPtr RenderPrimitives;
        public System.IntPtr LockVirtualArray;
        public System.IntPtr UnlockVirtualArray;
        public System.IntPtr AddDirtyRange;

        // Methods
    }

    // Members
    public byte m_UseVirtualArray;
    public ACBindings.Internal.VertexFormatInfo m_HardwareVertexFormat;
    public System.IntPtr m_pVirtualArray;
    public byte m_IsVirtualArrayLocked;
    public byte m_NeedRefreshVirtualArray;
    public ACBindings.Internal.BBox m_VirtualArrayBoundingBox;
    public byte m_IsVirtualArrayBoundingBoxValid;

    // Generated Constructor
    public RenderVertexBuffer() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Prepares the vertex buffer for a new drawing operation by resetting its internal state, including virtual array flags and bounding boxes.
    /// <code>Offset: 0x004474E0
    /// RenderVertexBuffer* __thiscall RenderVertexBuffer::Begin(RenderVertexBuffer*)</code>
    /// </summary>
    /// <returns>A reference to the initialized RenderVertexBuffer instance.</returns>
    public ACBindings.Internal.RenderVertexBuffer* Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.RenderVertexBuffer*>)0x004474E0)(ref this);

    /// <summary>Releases the virtual vertex array owned by the RenderVertexBuffer instance and clears its pointer, freeing any dynamically allocated memory.
    /// <code>Offset: 0x00447520
    /// void __thiscall RenderVertexBuffer::End(void**)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, void>)0x00447520)(ref this);

    /// <summary>Initializes the render vertex buffer by delegating to VertexArray::Startup and then configuring its hardware format, optional virtual array allocation, and bounding box state.
    /// <code>Offset: 0x00447550
    /// char __thiscall RenderVertexBuffer::Startup(RenderVertexBuffer*,unsigned int,unsigned int,bool,bool,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Number of vertices in the buffer.</param>
    /// <param name="a3">Size or stride per vertex (in bytes).</param>
    /// <param name="a4">Flag controlling whether the virtual array is locked; when false, locking is enabled.</param>
    /// <param name="a5">Indicates if the vertex data should be treated as static.</param>
    /// <param name="a6">Bitmask for selecting hardware vertex format components.</param>
    /// <returns>Non‑zero on successful initialization; zero indicates failure.</returns>
    public sbyte Startup(uint a2, uint a3, byte a4, byte a5, uint a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, uint, uint, byte, byte, uint, sbyte>)0x00447550)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Releases the virtual array memory, invokes the base VertexArray shutdown routine, clears internal flags, and resets the bounding box to an empty state.
    /// <code>Offset: 0x00447620
    /// void __thiscall RenderVertexBuffer::Shutdown(void**)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, void>)0x00447620)(ref this);

    /// <summary>Unlocks the virtual vertex buffer when it is active, clearing any pending refresh flag if set.
    /// <code>Offset: 0x00447680
    /// char __thiscall RenderVertexBuffer::UnlockVirtualArray(RenderVertexBuffer*)</code>
    /// </summary>
    /// <returns>True if a refresh was pending before unlocking; otherwise false.</returns>
    public sbyte UnlockVirtualArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, sbyte>)0x00447680)(ref this);

    /// <summary>Unlocks the vertex buffer and returns whether a virtual array was locked before unlocking; if so, marks the virtual‑array bounding box as valid.
    /// <code>Offset: 0x004476A0
    /// char __thiscall RenderVertexBuffer::Unlock(RenderVertexBuffer*,bool,bool)</code>
    /// </summary>
    /// <param name="a2">Flag forwarded to VertexArray::Unlock, controlling unlock behavior (e.g., discard changes).</param>
    /// <param name="a3">Additional flag passed to VertexArray::Unlock for extended unlock options.</param>
    /// <returns>Non‑zero if a virtual array was locked before this call; zero otherwise.</returns>
    public sbyte Unlock(byte a2, byte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, byte, byte, sbyte>)0x004476A0)(ref this, a2, a3);

    /// <summary>Copies vertex data from a source buffer to a destination buffer, converting between differing vertex formats and optionally swapping the Y and Z coordinates.
    /// <code>Offset: 0x004476D0
    /// void __cdecl RenderVertexBuffer::TransferVertices(const void*,const VertexFormatInfo*,void*,const VertexFormatInfo*,const unsigned int,const bool)</code>
    /// </summary>
    /// <param name="pSourceData">Pointer to the beginning of the source vertex array.</param>
    /// <param name="SourceVFI">Description of the format for the source vertices.</param>
    /// <param name="pDestData">Pointer to the destination buffer where converted vertices will be written.</param>
    /// <param name="DestVFI">Description of the format for the destination vertices.</param>
    /// <param name="NumVertices">Number of vertices to transfer.</param>
    /// <param name="SwapYAndZ">If true, the Y and Z components of position, normal, and texture coordinates are swapped during conversion.</param>
    public static void TransferVertices(void* pSourceData, ACBindings.Internal.VertexFormatInfo* SourceVFI, System.IntPtr pDestData, ACBindings.Internal.VertexFormatInfo* DestVFI, uint NumVertices, byte SwapYAndZ) => ((delegate* unmanaged[Cdecl]<void*, ACBindings.Internal.VertexFormatInfo*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, uint, byte, void>)0x004476D0)(pSourceData, SourceVFI, pDestData, DestVFI, NumVertices, SwapYAndZ);

    /// <summary>Renders indexed geometry from this vertex buffer using specified material layers for a given render pass, applying diffuse and ambient color scaling and optional translucency. Returns non‑zero when at least one layer was rendered successfully.
    /// <code>Offset: 0x00447AA0
    /// char __thiscall RenderVertexBuffer::RenderIndexedUsingMaterial(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBuffer*,const RenderMaterial*,const RenderMaterial*,enum RenderPassType,RGBAColor*,RGBAColor*,bool,int,unsigned int*,unsigned int*,int)</code>
    /// </summary>
    /// <param name="a2">Primitive type used for drawing (e.g., triangles or lines).</param>
    /// <param name="a3">Index of the first vertex within this buffer to start rendering from.</param>
    /// <param name="a4">Number of vertices to render.</param>
    /// <param name="a5">Offset into the index buffer at which to begin reading indices.</param>
    /// <param name="a6">Count of indices to use for drawing.</param>
    /// <param name="a7">Implementation‑specific value passed to the underlying rendering routine.</param>
    /// <param name="a8">Pointer to a RenderIndexBuffer that supplies vertex ordering information.</param>
    /// <param name="a9">Base material used to set up initial render state before processing layers.</param>
    /// <param name="a10">Material containing one or more layers that define how geometry should be drawn for the selected pass.</param>
    /// <param name="a11">Render pass type selecting which subset of material layers to process.</param>
    /// <param name="DiffuseColorScale">Multiplier applied to each layer's diffuse component.</param>
    /// <param name="AmbientLightBoost">Additional boost applied to the ambient lighting for each layer.</param>
    /// <param name="ForceTranslucent">If true, forces translucent rendering regardless of material opacity.</param>
    /// <param name="a15">Integer passed through to the underlying renderer; purpose is implementation‑defined.</param>
    /// <param name="a16">Pointer to an unsigned integer used internally by the render routine; purpose unspecified.</param>
    /// <param name="a17">Pointer to an unsigned integer used internally by the render routine; purpose unspecified.</param>
    /// <param name="a18">Integer flag providing additional options to the underlying renderer; purpose is implementation‑defined.</param>
    /// <returns>Non‑zero if rendering succeeded for at least one material layer; otherwise zero.</returns>
    public sbyte RenderIndexedUsingMaterial(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.Internal.RenderIndexBuffer* a8, ACBindings.Internal.RenderMaterial* a9, ACBindings.Internal.RenderMaterial* a10, ACBindings.Internal.RenderPassType a11, ACBindings.Internal.RGBAColor* DiffuseColorScale, ACBindings.Internal.RGBAColor* AmbientLightBoost, byte ForceTranslucent, int a15, uint* a16, uint* a17, int a18) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBuffer*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderPassType, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, byte, int, uint*, uint*, int, sbyte>)0x00447AA0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, DiffuseColorScale, AmbientLightBoost, ForceTranslucent, a15, a16, a17, a18);

    /// <summary>Renders the vertex buffer by iterating over applicable material layers derived from the supplied materials, setting render states for each layer and invoking the underlying draw call. Returns true if at least one layer was rendered successfully.
    /// <code>Offset: 0x00447BE0
    /// char __thiscall RenderVertexBuffer::RenderUsingMaterial(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,const RenderMaterial*,const RenderMaterial*,enum RenderPassType,RGBAColor*,RGBAColor*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Primitive type used for rendering (e.g., triangles, lines).</param>
    /// <param name="a3">Starting index within the vertex buffer to begin drawing.</param>
    /// <param name="a4">Number of vertices or indices to process during this draw call.</param>
    /// <param name="a5">Primary material providing textures and shaders for rendering.</param>
    /// <param name="a6">Secondary material whose layer indices determine which subsets of the primary material are applied per render pass.</param>
    /// <param name="a7">Render pass type controlling how layer indices are selected (e.g., lighting, shadow).</param>
    /// <param name="DiffuseColorScale">Multiplier applied to the diffuse component during state setup.</param>
    /// <param name="AmbientLightBoost">Additional ambient light factor applied during state setup.</param>
    /// <param name="a10">Output parameter receiving the vertex count rendered for this call.</param>
    /// <param name="a11">Output parameter receiving an auxiliary value such as the number of indices drawn.</param>
    /// <returns>Non‑zero if at least one layer was rendered successfully; otherwise zero.</returns>
    public sbyte RenderUsingMaterial(ACBindings.Internal.PrimType a2, uint a3, uint a4, ACBindings.Internal.RenderMaterial* a5, ACBindings.Internal.RenderMaterial* a6, ACBindings.Internal.RenderPassType a7, ACBindings.Internal.RGBAColor* DiffuseColorScale, ACBindings.Internal.RGBAColor* AmbientLightBoost, uint* a10, uint* a11) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.RenderPassType, ACBindings.Internal.RGBAColor*, ACBindings.Internal.RGBAColor*, uint*, uint*, sbyte>)0x00447BE0)(ref this, a2, a3, a4, a5, a6, a7, DiffuseColorScale, AmbientLightBoost, a10, a11);

    /// <summary>Initializes a RenderVertexBuffer by configuring its base VertexArray, resetting internal flags, initializing bounding boxes, and assigning the appropriate virtual function table.
    /// <code>Offset: 0x00447D80
    /// RenderVertexBuffer* __thiscall RenderVertexBuffer::RenderVertexBuffer(RenderVertexBuffer*)</code>
    /// </summary>
    /// <returns>The initialized RenderVertexBuffer instance.</returns>
    public ACBindings.Internal.RenderVertexBuffer* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.RenderVertexBuffer*>)0x00447D80)(ref this);

    /// <summary>Renders indexed primitives using this vertex buffer and the supplied index buffer.
    /// <code>Offset: 0x00447DF0
    /// char __thiscall RenderVertexBuffer::RenderIndexedPrimitives(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBuffer*,bool,unsigned int*,unsigned int*,bool)</code>
    /// </summary>
    /// <param name="a2">Primitive type to render, such as triangle list or line strip.</param>
    /// <param name="a3">Unsigned integer parameter controlling rendering; exact meaning depends on implementation.</param>
    /// <param name="a4">Unsigned integer parameter used in the draw call; specific purpose is implementation‑dependent.</param>
    /// <param name="a5">Unsigned integer parameter influencing rendering; its role is defined by the renderer.</param>
    /// <param name="a6">Unsigned integer parameter affecting the indexed draw operation; details are implementation‑specific.</param>
    /// <param name="a7">Unsigned integer parameter that may represent a count or offset for primitives; interpretation varies with context.</param>
    /// <param name="a8">Pointer to a RenderIndexBuffer containing indices used for drawing.</param>
    /// <param name="a9">Boolean flag that modifies rendering behavior, such as enabling or disabling certain options.</param>
    /// <param name="a10">Optional pointer to an unsigned integer that may receive auxiliary data during rendering.</param>
    /// <param name="a11">Optional pointer to an unsigned integer for additional output from the rendering process.</param>
    /// <param name="a12">Boolean flag influencing rendering, possibly controlling advanced options or optimizations.</param>
    /// <returns>Zero indicates successful rendering; non‑zero values may signal error conditions.</returns>
    public sbyte RenderIndexedPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.Internal.RenderIndexBuffer* a8, byte a9, uint* a10, uint* a11, byte a12) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBuffer*, byte, uint*, uint*, byte, sbyte>)0x00447DF0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);

    /// <summary>Renders primitives from a vertex buffer using the specified parameters.
    /// <code>Offset: 0x00447E00
    /// char __thiscall RenderVertexBuffer::RenderPrimitives(RenderVertexBuffer*,enum PrimType,unsigned int,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Primitive type to render (e.g., triangle list, line strip).</param>
    /// <param name="a3">Index of the first vertex in the buffer used for rendering.</param>
    /// <param name="a4">Number of vertices to render starting from a3.</param>
    /// <param name="a5">Pointer to user‑supplied data for rendering; interpretation is implementation dependent.</param>
    /// <param name="a6">Pointer to auxiliary information needed by the renderer; interpretation is implementation dependent.</param>
    /// <returns>Zero indicates success, nonzero may indicate an error condition.</returns>
    public sbyte RenderPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint* a5, uint* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, ACBindings.Internal.PrimType, uint, uint, uint*, uint*, sbyte>)0x00447E00)(ref this, a2, a3, a4, a5, a6);

    /// <summary>Allocates a new vertex buffer, delegating to the renderer when available; otherwise constructs a default instance.
    /// <code>Offset: 0x00447E40
    /// RenderVertexBuffer* RenderVertexBuffer::AllocateVertexBuffer()</code>
    /// </summary>
    /// <returns>Pointer to the allocated RenderVertexBuffer or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.RenderVertexBuffer* AllocateVertexBuffer() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RenderVertexBuffer*>)0x00447E40)();

    /// <summary>Refreshes the virtual vertex array when a refresh is required, copying updated vertices from the base buffer to the virtual buffer and updating relevant state flags.
    /// <code>Offset: 0x00447E70
    /// void __thiscall RenderVertexBuffer::RefreshVirtualArray(RenderVertexBuffer*)</code>
    /// </summary>
    public void RefreshVirtualArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, void>)0x00447E70)(ref this);

    /// <summary>Prepares the render buffer's virtual vertex array for access by refreshing its contents and acquiring a lock, then returns a pointer into the vertex data.
    /// <code>Offset: 0x00447EE0
    /// unsigned int __thiscall RenderVertexBuffer::LockVirtualArray(RenderVertexBuffer*,int,int)</code>
    /// </summary>
    /// <param name="a2">The starting index within the virtual array to lock.</param>
    /// <param name="a3">Additional size or count information passed to an internal validation routine.</param>
    /// <returns>An unsigned integer representing the address of the locked vertex region, or zero if locking fails (e.g., when the buffer does not use a virtual array or is already locked).</returns>
    public uint LockVirtualArray(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBuffer, int, int, uint>)0x00447EE0)(ref this, a2, a3);
}

