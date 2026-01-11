namespace ACBindings.Internal;

public unsafe struct RenderVertexBufferD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.RenderVertexBuffer BaseClass_RenderVertexBuffer; // ACBindings.Internal.RenderVertexBuffer

    // Child Types
    public unsafe struct RenderVertexBufferD3D_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, void> RenderVertexBufferD3D_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, uint, uint, byte, byte, uint, byte> Startup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, void> Shutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, uint, uint, System.IntPtr> Lock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, byte, byte, void> Unlock; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBuffer*, byte, uint*, uint*, byte, byte> RenderIndexedPrimitives; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, ACBindings.Internal.PrimType, uint, uint, uint*, uint*, byte> RenderPrimitives; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, uint, uint, System.IntPtr> LockVirtualArray; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, void> UnlockVirtualArray; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderVertexBufferD3D*, ACBindings.Internal.VertexRange*, byte> AddDirtyRange; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005A27A0
    /// RenderVertexBufferD3D* __thiscall RenderVertexBufferD3D::RenderVertexBufferD3D(RenderVertexBufferD3D*)</code>
    /// </summary>
    public ACBindings.Internal.RenderVertexBufferD3D* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.RenderVertexBufferD3D*>)0x005A27A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A2830
    /// void __thiscall RenderVertexBufferD3D::~RenderVertexBufferD3D(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x005A2830)(ref this);

    /// <summary>
    /// <code>Offset: 0x00699040
    /// int __thiscall RenderVertexBufferD3D::Lock(RenderVertexBufferD3D*,unsigned int,unsigned int)</code>
    /// </summary>
    public int Lock(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, uint, uint, int>)0x00699040)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006990F0
    /// void __thiscall RenderVertexBufferD3D::SetupVertexStreams(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void SetupVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x006990F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00699140
    /// void __thiscall RenderVertexBufferD3D::Begin(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x00699140)(ref this);

    /// <summary>
    /// <code>Offset: 0x00699160
    /// void __thiscall RenderVertexBufferD3D::ReleaseVertexStreams(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void ReleaseVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x00699160)(ref this);

    /// <summary>
    /// <code>Offset: 0x00699250
    /// void __thiscall RenderVertexBufferD3D::Shutdown(RenderVertexBufferD3D*)</code>
    /// </summary>
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, void>)0x00699250)(ref this);

    /// <summary>
    /// <code>Offset: 0x006992D0
    /// bool __thiscall RenderVertexBufferD3D::UpdateVertexBuffer(RenderVertexBufferD3D*,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte UpdateVertexBuffer(uint SwapYAndZ, uint NumVertices, uint* nBaseVertexIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, uint, uint, uint*, byte>)0x006992D0)(ref this, SwapYAndZ, NumVertices, nBaseVertexIndex);

    /// <summary>
    /// <code>Offset: 0x00699440
    /// char __thiscall RenderVertexBufferD3D::AddDirtyRange(RenderVertexBufferD3D*,VertexRange*)</code>
    /// </summary>
    public sbyte AddDirtyRange(ACBindings.Internal.VertexRange* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.VertexRange*, sbyte>)0x00699440)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006994E0
    /// char __thiscall RenderVertexBufferD3D::CreateVertexStreams(RenderVertexBufferD3D*)</code>
    /// </summary>
    public sbyte CreateVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, sbyte>)0x006994E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006995A0
    /// char __thiscall RenderVertexBufferD3D::RenderIndexedPrimitives(RenderVertexBufferD3D*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBufferD3D*,bool,unsigned int*,unsigned int*,bool)</code>
    /// </summary>
    public sbyte RenderIndexedPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.Internal.RenderIndexBufferD3D* a8, byte a9, uint* a10, uint* a11, byte a12) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.PrimType, uint, uint, uint, uint, uint, ACBindings.Internal.RenderIndexBufferD3D*, byte, uint*, uint*, byte, sbyte>)0x006995A0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);

    /// <summary>
    /// <code>Offset: 0x00699700
    /// bool __thiscall RenderVertexBufferD3D::RenderPrimitives(RenderVertexBufferD3D*,enum PrimType,unsigned int,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    public byte RenderPrimitives(ACBindings.Internal.PrimType a2, uint a3, uint a4, uint* a5, uint* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderVertexBufferD3D, ACBindings.Internal.PrimType, uint, uint, uint*, uint*, byte>)0x00699700)(ref this, a2, a3, a4, a5, a6);
}

