namespace ACBindings;

// RenderVertexBufferD3D
public unsafe struct RenderVertexBufferD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.RenderVertexBuffer BaseClass_RenderVertexBuffer; // ACBindings.RenderVertexBuffer

    // Child Types
    // RenderVertexBufferD3D_vtbl
    public unsafe struct RenderVertexBufferD3D_vtbl
    {
        // Members
        public System.IntPtr RenderVertexBufferD3D_dtor_0; // function pointer
        public System.IntPtr Startup; // function pointer
        public System.IntPtr Shutdown; // function pointer
        public System.IntPtr Lock; // function pointer
        public System.IntPtr Unlock; // function pointer
        public System.IntPtr RenderIndexedPrimitives; // function pointer
        public System.IntPtr RenderPrimitives; // function pointer
        public System.IntPtr LockVirtualArray; // function pointer
        public System.IntPtr UnlockVirtualArray; // function pointer
        public System.IntPtr AddDirtyRange; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__VertexRange m_saDirtyVertices;
    public ACBindings.SmartArray__RenderVertexStreamD3D_ptr m_saVertexStreams;

    // Generated Constructor
    public RenderVertexBufferD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // RenderVertexBufferD3D* __thiscall RenderVertexBufferD3D::RenderVertexBufferD3D(RenderVertexBufferD3D*)
    public ACBindings.RenderVertexBufferD3D* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, ACBindings.RenderVertexBufferD3D*>)0x005A27A0)(ref this);
    // void __thiscall RenderVertexBufferD3D::~RenderVertexBufferD3D(RenderVertexBufferD3D*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, void>)0x005A2830)(ref this);
    // int __thiscall RenderVertexBufferD3D::Lock(RenderVertexBufferD3D*,unsigned int,unsigned int)
    public int Lock(uint a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, uint, uint, int>)0x00699040)(ref this, a2, a3);
    // void __thiscall RenderVertexBufferD3D::SetupVertexStreams(RenderVertexBufferD3D*)
    public void SetupVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, void>)0x006990F0)(ref this);
    // void __thiscall RenderVertexBufferD3D::Begin(RenderVertexBufferD3D*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, void>)0x00699140)(ref this);
    // void __thiscall RenderVertexBufferD3D::ReleaseVertexStreams(RenderVertexBufferD3D*)
    public void ReleaseVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, void>)0x00699160)(ref this);
    // void __thiscall RenderVertexBufferD3D::Shutdown(RenderVertexBufferD3D*)
    public void Shutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, void>)0x00699250)(ref this);
    // bool __thiscall RenderVertexBufferD3D::UpdateVertexBuffer(RenderVertexBufferD3D*,unsigned int,unsigned int,unsigned int*)
    public byte UpdateVertexBuffer(uint SwapYAndZ, uint NumVertices, uint* nBaseVertexIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, uint, uint, uint*, byte>)0x006992D0)(ref this, SwapYAndZ, NumVertices, nBaseVertexIndex);
    // char __thiscall RenderVertexBufferD3D::AddDirtyRange(RenderVertexBufferD3D*,VertexRange*)
    public sbyte AddDirtyRange(ACBindings.VertexRange* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, ACBindings.VertexRange*, sbyte>)0x00699440)(ref this, a2);
    // char __thiscall RenderVertexBufferD3D::CreateVertexStreams(RenderVertexBufferD3D*)
    public sbyte CreateVertexStreams() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, sbyte>)0x006994E0)(ref this);
    // char __thiscall RenderVertexBufferD3D::RenderIndexedPrimitives(RenderVertexBufferD3D*,enum PrimType,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,RenderIndexBufferD3D*,bool,unsigned int*,unsigned int*,bool)
    public sbyte RenderIndexedPrimitives(ACBindings.PrimType a2, uint a3, uint a4, uint a5, uint a6, uint a7, ACBindings.RenderIndexBufferD3D* a8, byte a9, uint* a10, uint* a11, byte a12) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, ACBindings.PrimType, uint, uint, uint, uint, uint, ACBindings.RenderIndexBufferD3D*, byte, uint*, uint*, byte, sbyte>)0x006995A0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);
    // bool __thiscall RenderVertexBufferD3D::RenderPrimitives(RenderVertexBufferD3D*,enum PrimType,unsigned int,unsigned int,unsigned int*,unsigned int*)
    public byte RenderPrimitives(ACBindings.PrimType a2, uint a3, uint a4, uint* a5, uint* a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderVertexBufferD3D, ACBindings.PrimType, uint, uint, uint*, uint*, byte>)0x00699700)(ref this, a2, a3, a4, a5, a6);
}

