namespace ACBindings.Internal;


/// <summary>
/// Direct3D‑specific vertex buffer that extends RenderVertexBuffer, tracking dirty vertex ranges and managing per‑stream vertex data for efficient rendering.
/// </summary>
public unsafe struct RenderVertexBufferD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.RenderVertexBuffer BaseClass_RenderVertexBuffer; // ACBindings.Internal.RenderVertexBuffer

    // Child Types
    public unsafe struct RenderVertexBufferD3D_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, void> RenderVertexBufferD3D_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, uint, uint, byte, byte, uint, byte> Startup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, void> Shutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, uint, uint, System.IntPtr> Lock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, byte, byte, void> Unlock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBuffer*, byte, uint*, uint*, byte, byte> RenderIndexedPrimitives; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, ACBindings.Internal.PrimType, uint, uint, uint*, uint*, byte> RenderPrimitives; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, uint, uint, System.IntPtr> LockVirtualArray; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, void> UnlockVirtualArray; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, ACBindings.Internal.VertexRange*, byte> AddDirtyRange; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___VertexRange m_saDirtyVertices;
    public ACBindings.Internal.SmartArray___RenderVertexStreamD3D_ptr m_saVertexStreams;

    // Generated Constructor
    public RenderVertexBufferD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Constructs a RenderVertexBufferD3D instance by initializing base classes and resetting internal state.
    /// <code>Offset: 0x005A27A0
    /// RenderVertexBufferD3D* __thiscall RenderVertexBufferD3D::RenderVertexBufferD3D(RenderVertexBufferD3D*)</code>
    /// </summary>
    /// <returns>A pointer to the initialized RenderVertexBufferD3D object.</returns>
    public ACBindings.Internal.RenderVertexBufferD3D* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.RenderVertexBufferD3D*>)0x005A27A0)(ref this);

    /// <summary>Releases all resources associated with the render vertex buffer, including freeing allocated memory for dirty vertices and vertex streams, and invokes cleanup routines of its base classes RenderVertexBuffer, VertexArray, and ReferenceCountTemplate.
    /// <code>Offset: 0x005A2830
    /// void __thiscall RenderVertexBufferD3D::~RenderVertexBufferD3D(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x005A2830)(ref this);

    /// <summary>Locks a range of vertices in the buffer for direct manipulation, optionally triggering a virtual‑array refresh.
    /// <code>Offset: 0x00699040
    /// int __thiscall RenderVertexBufferD3D::Lock(RenderVertexBufferD3D*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="firstVertex">Zero‑based index of the first vertex to lock.</param>
    /// <param name="numVertices">Number of consecutive vertices to lock.</param>
    /// <returns>Non‑zero if the operation succeeded; zero otherwise.</returns>
    public int Lock(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, uint, uint, int>)0x00699040)(ref this, a2, a3);

    /// <summary>Configures the render device’s vertex streams by setting each stream defined in this buffer and then applies the buffer’s vertex format to the device.
    /// <code>Offset: 0x006990F0
    /// void __thiscall RenderVertexBufferD3D::SetupVertexStreams(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void SetupVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x006990F0)(ref this);

    /// <summary>Clears material shader constants and profiler window references associated with the vertex buffer, preparing it for subsequent rendering operations.
    /// <code>Offset: 0x00699140
    /// void __thiscall RenderVertexBufferD3D::Begin(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x00699140)(ref this);

    /// <summary>
    /// Releases all vertex streams owned by this RenderVertexBufferD3D instance, freeing allocated memory and resetting internal state.
    /// 
    /// <code>Offset: 0x00699160
    /// void __thiscall RenderVertexBufferD3D::ReleaseVertexStreams(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void ReleaseVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x00699160)(ref this);

    /// <summary>Releases vertex streams, shuts down the underlying render vertex buffer, and resets material shader constants and profiler UI window collections to clean up all resources owned by this RenderVertexBufferD3D instance.
    /// <code>Offset: 0x00699250
    /// void __thiscall RenderVertexBufferD3D::Shutdown(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x00699250)(ref this);

    /// <summary>Copies vertex data from an internal stream into this buffer, handling virtual‑array scenarios and updating a base‑vertex index as needed.
    /// <code>Offset: 0x006992D0
    /// bool __thiscall RenderVertexBufferD3D::UpdateVertexBuffer(RenderVertexBufferD3D*,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="SwapYAndZ">Index of the first source vertex to copy from within the stream.</param>
    /// <param name="NumVertices">Number of vertices to transfer.</param>
    /// <param name="nBaseVertexIndex">Receives the base vertex index used during streaming; initialized to zero before the call.</param>
    /// <returns>True when all vertices were copied successfully, otherwise false (e.g., if a resource was lost).</returns>
    public byte UpdateVertexBuffer(uint SwapYAndZ, uint NumVertices, uint* nBaseVertexIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, uint, uint, uint*, byte>)0x006992D0)(ref this, SwapYAndZ, NumVertices, nBaseVertexIndex);

    /// <summary>Adds the specified vertex range to the buffer's list of dirty ranges after validating bounds and merging overlapping ranges.
    /// <code>Offset: 0x00699440
    /// char __thiscall RenderVertexBufferD3D::AddDirtyRange(RenderVertexBufferD3D*,VertexRange*)</code>
    /// </summary>
    /// <param name="range">The vertex range to mark as dirty.</param>
    /// <returns>Non-zero if the range was accepted and merged; zero if it lies outside the buffer bounds.</returns>
    public sbyte AddDirtyRange(ACBindings.Internal.VertexRange* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.VertexRange*, sbyte>)0x00699440)(ref this, a2);

    /// <summary>Create vertex streams for the render vertex buffer, allocating a new stream or referencing an existing one based on the object's configuration, and stores it in the internal vertex-stream array.
    /// <code>Offset: 0x006994E0
    /// char __thiscall RenderVertexBufferD3D::CreateVertexStreams(RenderVertexBufferD3D*)</code>
    /// </summary>
    /// <returns>Non-zero if the vertex stream was successfully created or referenced; zero otherwise.</returns>
    public sbyte CreateVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, sbyte>)0x006994E0)(ref this);

    /// <summary>Renders indexed primitives from the vertex buffer, updating virtual arrays and index buffers as needed before issuing a Direct3D draw call.
    /// <code>Offset: 0x006995A0
    /// char __thiscall RenderVertexBufferD3D::RenderIndexedPrimitives(RenderVertexBufferD3D*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBufferD3D*,bool,unsigned int*,unsigned int*,bool)</code>
    /// </summary>
    /// <param name="primType">The type of primitive to render (e.g., triangle list or strip).</param>
    /// <param name="startIndex">First index in the supplied index buffer for this draw call.</param>
    /// <param name="primitiveCount">Number of primitives to render.</param>
    /// <param name="firstVertexOffset">Offset applied when updating the vertex buffer and during virtual array handling.</param>
    /// <param name="numVertices">Number of vertices to update or refresh.</param>
    /// <param name="vertexBaseIndex">Base vertex index used for the draw call, adjusted based on whether a virtual array is active.</param>
    /// <param name="indexBuffer">Pointer to the index buffer containing indices for this draw call.</param>
    /// <param name="forceRefresh">If true, forces a refresh of the vertex data regardless of cached state.</param>
    /// <param name="outMaxVertexIndex">Optional output; receives the maximum vertex index after updating buffers.</param>
    /// <param name="outBaseVertexIndex">Optional output; receives the base vertex index passed to Direct3D.</param>
    /// <param name="useFullVirtualRange">When rendering a virtual array, selects whether to use the full range or an offset for Min and Base indices.</param>
    /// <returns>Non‑zero if rendering succeeded; zero on failure.</returns>
    public sbyte RenderIndexedPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.Internal.RenderIndexBufferD3D* a8, byte a9, uint* a10, uint* a11, byte a12) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBufferD3D*, byte, uint*, uint*, byte, sbyte>)0x006995A0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);

    /// <summary>Renders a sequence of primitives from the vertex buffer, updating the virtual array if required and issuing the draw call through the render device.
    /// <code>Offset: 0x00699700
    /// bool __thiscall RenderVertexBufferD3D::RenderPrimitives(RenderVertexBufferD3D*,enum PrimType,unsigned int,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Primitive type to render (point list, line list, triangle strip, etc.).</param>
    /// <param name="a3">Index of the first source vertex to use for rendering.</param>
    /// <param name="a4">Number of primitives to draw.</param>
    /// <param name="a5">Optional output pointer that receives the identifier of the internal virtual array used for this render. If null, no value is stored.</param>
    /// <param name="a6">Optional input/output pointer providing a vertex offset; the function writes back the offset actually used in the buffer. If null, an offset is automatically generated.</param>
    /// <returns>True if rendering succeeded; otherwise false.</returns>
    public byte RenderPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint* a5, uint* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.PrimType, uint, uint, uint*, uint*, byte>)0x00699700)(ref this, a2, a3, a4, a5, a6);
}

