namespace ACBindings.Internal;


/// <summary>Wraps a RenderSurface with an IDirect3DSurface9, enabling DirectX 9 rendering and resource tracking for the surface.</summary>
/// <remarks>Holds the base RenderSurface data, a pointer to the underlying D3D surface, the pool type (_D3DPOOL), and flags indicating whether the surface counts as system or video memory for global accounting purposes.</remarks>
public unsafe struct RenderSurfaceD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.RenderSurface BaseClass_RenderSurface; // ACBindings.Internal.RenderSurface

    // Child Types
    public unsafe struct RenderSurfaceD3D_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, uint, uint, ACBindings.Internal.PixelFormatID, byte, byte> Create; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, byte> CreateFromSourceData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, ACBindings.Internal.tagRECT*, uint, int*, void**, byte> Lock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, void> Unlock; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, byte> Convert; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurface*, ACBindings.Internal.RenderSurface*, byte> ConvertToNormalMap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderSurfaceD3D*, System.IntPtr, byte, byte, byte> CreateFromD3DSurface; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr m_pD3DSurface;
    public ACBindings.Internal._D3DPOOL m_pool;
    public byte m_CountAsSystemMemory;
    public byte m_CountAsVideoMemory;

    // Generated Constructor
    public RenderSurfaceD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a RenderSurfaceD3D instance from an existing Direct3D surface, initializing its properties and tracking memory usage.
    /// <code>Offset: 0x00696BB0
    /// bool __thiscall RenderSurfaceD3D::CreateFromD3DSurface(RenderSurfaceD3D*,IDirect3DSurface9*,const bool,const bool)</code>
    /// </summary>
    /// <param name="pExistingSurface">The IDirect3DSurface9 to wrap.</param>
    /// <param name="CountAsSystemMemory">If true, counts the surface's memory as system memory.</param>
    /// <param name="CountAsVideoMemory">If true, counts the surface's memory as video memory and updates global remote byte counter.</param>
    /// <returns>True if the surface was successfully created; otherwise false.</returns>
    public byte CreateFromD3DSurface(System.IntPtr pExistingSurface, byte CountAsSystemMemory, byte CountAsVideoMemory) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, System.IntPtr, byte, byte, byte>)0x00696BB0)(ref this, pExistingSurface, CountAsSystemMemory, CountAsVideoMemory);

    /// <summary>Retrieves the DirectX 9 surface for this render surface, restoring it when necessary.
    /// <code>Offset: 0x00696C50
    /// IDirect3DSurface9* __thiscall RenderSurfaceD3D::GetDirect3DSurface(RenderSurfaceD3D*)</code>
    /// </summary>
    /// <returns>The underlying IDirect3DSurface9 pointer, or nullptr if restoration failed.</returns>
    public System.IntPtr GetDirect3DSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, System.IntPtr>)0x00696C50)(ref this);

    /// <summary>Copies surface data from a source RenderSurface into this RenderSurfaceD3D, handling either raw pixel buffers or Direct3D surfaces.
    /// <code>Offset: 0x00696CA0
    /// bool __thiscall RenderSurfaceD3D::Convert(RenderSurfaceD3D*,const RenderSurface*)</code>
    /// </summary>
    /// <param name="source">Source RenderSurface whose contents are to be transferred.</param>
    /// <returns>True when the conversion completes successfully; otherwise returns the result of the base class conversion routine.</returns>
    public byte Convert(ACBindings.Internal.RenderSurface* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, ACBindings.Internal.RenderSurface*, byte>)0x00696CA0)(ref this, source);

    /// <summary>Creates a Direct3D surface for this render surface if one does not already exist, calculates its memory size, updates graphics resource metadata, increments the global video‑memory counter when appropriate, and marks the resource as not lost.
    /// <code>Offset: 0x00696D00
    /// bool __thiscall RenderSurfaceD3D::CreateD3DSurface(RenderSurfaceD3D*)</code>
    /// </summary>
    /// <returns>Always returns true.</returns>
    public byte CreateD3DSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, byte>)0x00696D00)(ref this);

    /// <summary>Releases resources linked to the render surface, updating global counters and invoking any necessary cleanup callbacks.
    /// <code>Offset: 0x00696D90
    /// bool __thiscall RenderSurfaceD3D::PurgeResource(RenderSurfaceD3D*)</code>
    /// </summary>
    /// <returns>True if the purge succeeded; otherwise false.</returns>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, byte>)0x00696D90)(ref this);

    /// <summary>Constructs a RenderSurfaceD3D instance, initializing the base RenderSurface, clearing the Direct3D surface pointer, resetting memory‑usage flags, assigning appropriate vtables for DBObj and GraphicsResource, and setting the surface pool to scratch.
    /// <code>Offset: 0x00696DE0
    /// void __thiscall RenderSurfaceD3D::RenderSurfaceD3D(RenderSurfaceD3D*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00696DE0)(ref this);

    /// <summary>Create a Direct3D render surface with the specified dimensions and pixel format, allocating system or video memory as needed.
    /// <code>Offset: 0x00696E30
    /// bool __thiscall RenderSurfaceD3D::Create(RenderSurfaceD3D*,unsigned int,unsigned int,PixelFormatID,bool)</code>
    /// </summary>
    /// <param name="width">Width of the surface in pixels.</param>
    /// <param name="height">Height of the surface in pixels.</param>
    /// <param name="pixelFormat">Pixel format identifier for the surface.</param>
    /// <param name="bLocalData">Flag indicating whether to use local data storage (currently unused).</param>
    /// <returns>True if the surface was created successfully; otherwise, false.</returns>
    public byte Create(uint width, uint height, ACBindings.Internal.PixelFormatID pixelFormat, byte bLocalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, uint, uint, ACBindings.Internal.PixelFormatID, byte, byte>)0x00696E30)(ref this, width, height, pixelFormat, bLocalData);

    /// <summary>Releases the Direct3D surface held by this RenderSurfaceD3D object, adjusts video‑memory tracking, marks the underlying graphics resource as not lost, and calls the base class destructor to perform further cleanup.
    /// <code>Offset: 0x00696EB0
    /// void __thiscall RenderSurfaceD3D::Destroy(RenderSurfaceD3D*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00696EB0)(ref this);

    /// <summary>Locks the Direct3D surface for direct memory access, returning a pointer to the pixel buffer and its row stride.
    /// <code>Offset: 0x00696F10
    /// bool __thiscall RenderSurfaceD3D::Lock(RenderSurfaceD3D*,const tagRECT*,const unsigned int,int*,void**)</code>
    /// </summary>
    /// <param name="rect">Specifies the portion of the surface to lock; if null, the entire surface is locked.</param>
    /// <param name="flags">Bitmask controlling lock behavior (e.g., read-only, discard). Flags 2 and 4 affect how the Direct3D lock is requested.</param>
    /// <param name="pitch">Receives the number of bytes per row of the locked surface.</param>
    /// <param name="data">Receives a pointer to the start of the pixel data for the locked region.</param>
    /// <returns>True if the surface was successfully locked; otherwise, false.</returns>
    public byte Lock(ACBindings.Internal.tagRECT* rect, uint flags, int* pitch, void** data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, ACBindings.Internal.tagRECT*, uint, int*, void**, byte>)0x00696F10)(ref this, rect, flags, pitch, data);

    /// <summary>Releases the Direct3D surface associated with this render surface when necessary and unlocks the underlying surface data.
    /// <code>Offset: 0x00696FB0
    /// void __thiscall RenderSurfaceD3D::Unlock(RenderSurfaceD3D*)</code>
    /// </summary>
    public void Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00696FB0)(ref this);

    /// <summary>Restores the Direct3D surface for this RenderSurfaceD3D instance after a device loss. First delegates to GraphicsResource::RestoreResource; if successful it verifies that the pixel format is defined, an associated system‑memory bitmap exists, or creates a new D3D surface.
    /// <code>Offset: 0x00696FE0
    /// bool __thiscall RenderSurfaceD3D::RestoreResource(RenderSurfaceD3D*)</code>
    /// </summary>
    /// <returns>True when the surface has been successfully restored and all necessary resources are available; otherwise false.</returns>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, byte>)0x00696FE0)(ref this);

    /// <summary>Releases the associated Direct3D surface if present, updates video‑memory accounting when necessary, marks the graphics resource as not lost, and then invokes the base RenderSurface destructor.
    /// <code>Offset: 0x00697030
    /// void __thiscall RenderSurfaceD3D::~RenderSurfaceD3D(RenderSurfaceD3D*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurfaceD3D, void>)0x00697030)(ref this);
}

