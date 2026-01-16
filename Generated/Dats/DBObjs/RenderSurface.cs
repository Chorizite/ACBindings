namespace ACBindings.Internal;


/// <summary>Encapsulates an image buffer for rendering, storing its dimensions, pixel format, and lock state to manage read/write access efficiently.</summary>
public unsafe struct RenderSurface : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderSurface_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.RenderSurfaceSourceData sourceData;
    public uint width;
    public uint height;
    public uint size;
    public ACBindings.Internal.SurfaceWindow window;
    public byte locked;
    public ACBindings.Internal.PixelFormatDesc pfDesc;
    public System.IntPtr m_pSurfaceBits;
    public ACBindings.Internal.IDClass____tagDataID m_didPalatte;
    public byte m_IsDirty;
    public byte m_ReadOnlyLock;

    // Generated Constructor
    public RenderSurface() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines if the given pixel format is supported as a Direct3D texture format.
    /// <code>Offset: 0x00443AC0
    /// bool __cdecl RenderSurface::IsD3DFormat(PixelFormatID)</code>
    /// </summary>
    /// <param name="pf">Identifier of the pixel format to test.</param>
    /// <returns>True when the format can be used directly with Direct3D; otherwise, false.</returns>
    public static byte IsD3DFormat(ACBindings.Internal.PixelFormatID pf) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PixelFormatID, byte>)0x00443AC0)(pf);

    /// <summary>Initializes or resets a rendering surface by clearing its dimensions, pixel format, lock status, dirty flag, palette ID, and surface bits.
    /// <code>Offset: 0x00443BC0
    /// void __thiscall RenderSurface::Begin(RenderSurface*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00443BC0)(ref this);

    /// <summary>Initializes the surface for loading by releasing any existing resource when running in a runtime environment. If not in runtime mode, initialization succeeds immediately.
    /// <code>Offset: 0x00443C20
    /// bool __thiscall RenderSurface::InitLoad(RenderSurface*)</code>
    /// </summary>
    /// <returns>True if initialization succeeded; otherwise false.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, byte>)0x00443C20)(ref this);

    /// <summary>Locks a region of the render surface for pixel manipulation, computing row stride and data pointer for the specified rectangle.
    /// <code>Offset: 0x00443C40
    /// bool __thiscall RenderSurface::Lock(RenderSurface*,const tagRECT*,const unsigned int,int*,void**)</code>
    /// </summary>
    /// <param name="rect">The rectangular area to lock within the surface.</param>
    /// <param name="flags">Bit flags controlling the lock; bit 1 indicates a read‑only lock.</param>
    /// <param name="pitch">Receives the number of bytes per scanline in the locked region.</param>
    /// <param name="data">Receives a pointer to the start of the locked pixel data.</param>
    /// <returns>True if the surface was successfully locked; false if it is already locked.</returns>
    public byte Lock(ACBindings.Internal.tagRECT* rect, uint flags, int* pitch, void** data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.tagRECT*, uint, int*, void**, byte>)0x00443C40)(ref this, rect, flags, pitch, data);

    /// <summary>Unlocks a previously locked render surface, clearing its lock status. If the lock was not read‑only, marks the surface as dirty to indicate that it has been modified.
    /// <code>Offset: 0x00443CC0
    /// void __thiscall RenderSurface::Unlock(RenderSurface*)</code>
    /// </summary>
    public void Unlock() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00443CC0)(ref this);

    /// <summary>Chooses an appropriate pixel format for the current render surface by considering runtime renderer state, data category, and source format flags. If no conversion is required or conditions are not met, returns the original format.
    /// <code>Offset: 0x00443CF0
    /// PixelFormatID __thiscall RenderSurface::SelectSurfaceFormat(RenderSurface*,const PixelFormatID)</code>
    /// </summary>
    /// <param name="format">The requested pixel format to evaluate.</param>
    /// <returns>The selected PixelFormatID; may be identical to the input if no changes are necessary.</returns>
    public ACBindings.Internal.PixelFormatID SelectSurfaceFormat(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID>)0x00443CF0)(ref this, format);

    /// <summary>Saves the current render surface to a JPEG image file.
    /// <code>Offset: 0x00443DC0
    /// char __thiscall RenderSurface::SaveJPG(_DWORD*,const char**)</code>
    /// </summary>
    /// <param name="a2">The path of the output JPEG file.</param>
    /// <returns>Non‑zero on success, zero otherwise.</returns>
    public sbyte SaveJPG(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, sbyte**, sbyte>)0x00443DC0)(ref this, a2);

    /// <summary>Copies pixel data from a source RenderSurface to the destination surface, performing a direct blit when formats and sizes match or creating temporary surfaces via the render device for differing formats.
    /// <code>Offset: 0x00443F60
    /// bool __thiscall RenderSurface::Convert(RenderSurface*,const RenderSurface*)</code>
    /// </summary>
    /// <param name="source">The source RenderSurface whose contents are copied into this surface.</param>
    /// <returns>True if the conversion succeeded; otherwise false.</returns>
    public byte Convert(ACBindings.Internal.RenderSurface* source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.RenderSurface*, byte>)0x00443F60)(ref this, source);

    /// <summary>Releases the internal source surface bits buffer if allocated, then clears the reference.
    /// <code>Offset: 0x004440D0
    /// void __thiscall RenderSurface::DestroySourceSurfaceBits(RenderSurface*)</code>
    /// </summary>
    public void DestroySourceSurfaceBits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x004440D0)(ref this);

    /// <summary>Initializes a new RenderSurface instance by constructing its base DBObj and GraphicsResource components, configuring surface descriptors, creating an associated SurfaceWindow, and then calling Begin to complete setup.
    /// <code>Offset: 0x004440F0
    /// void __thiscall RenderSurface::RenderSurface(RenderSurface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x004440F0)(ref this);

    /// <summary>Creates a render surface with specified width, height, and pixel format, initializing internal state and allocating local memory for the surface bits when required.
    /// <code>Offset: 0x00444150
    /// bool __thiscall RenderSurface::Create(RenderSurface*,unsigned int,unsigned int,PixelFormatID,bool)</code>
    /// </summary>
    /// <param name="width">Desired width of the surface in pixels.</param>
    /// <param name="height">Desired height of the surface in pixels.</param>
    /// <param name="pixelFormat">Identifier of the pixel format used for the surface.</param>
    /// <param name="bLocalData">If true or if the pixel format is not a Direct3D format, allocates local memory for the surface bits; otherwise leaves the buffer unallocated for external usage.</param>
    /// <returns>True when creation succeeds; false if allocating the surface buffer fails.</returns>
    public byte Create(uint width, uint height, ACBindings.Internal.PixelFormatID pixelFormat, byte bLocalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, uint, uint, ACBindings.Internal.PixelFormatID, byte, byte>)0x00444150)(ref this, width, height, pixelFormat, bLocalData);

    /// <summary>Creates a render surface from the object's source data, performing format selection, JPEG decoding when required, allocating resources, copying pixel bits into the new surface, and cleaning up temporary buffers.
    /// <code>Offset: 0x00444200
    /// bool __thiscall RenderSurface::CreateFromSourceData(RenderSurface*)</code>
    /// </summary>
    /// <returns>True if the surface was successfully created; otherwise false.</returns>
    public byte CreateFromSourceData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, byte>)0x00444200)(ref this);

    /// <summary>Allocates and initializes a RenderSurface instance. If runtime caching is enabled it retrieves an existing renderer resource; otherwise it creates a new RenderSurface object and returns its database handle.
    /// <code>Offset: 0x00444500
    /// DBObj* __thiscall RenderSurface::Allocator(RenderSurface*)</code>
    /// </summary>
    /// <param name="this">The RenderSurface object to initialize (or create).</param>
    /// <returns>A DBObj pointer representing the allocated surface, or null if allocation fails or no renderer is available.</returns>
    public ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.DBObj*>)0x00444500)(ref this);

    /// <summary>Destroys the surface’s internal buffers by freeing allocated source and pixel data memory, resets related pointers to null, and triggers a reinitialization routine via RenderSurface::Begin.
    /// <code>Offset: 0x00444540
    /// void __thiscall RenderSurface::Destroy(RenderSurface*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00444540)(ref this);

    /// <summary>Destroys a RenderSurface instance by freeing its source bits and surface bit array, terminating the linked SurfaceWindow, and invoking the destructors of its GraphicsResource and DBObj base classes to release all owned resources.
    /// <code>Offset: 0x00444580
    /// void __thiscall RenderSurface::~RenderSurface(RenderSurface*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, void>)0x00444580)(ref this);

    /// <summary>Collects sub‑data identifiers for this render surface, retrieving its palette data ID and adding it to the supplied array.
    /// <code>Offset: 0x004445F0
    /// void __thiscall RenderSurface::GetSubDataIDs(RenderSurface*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The collection to receive the resulting QualifiedDataID entries.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004445F0)(ref this, id_array);

    /// <summary>Serializes the RenderSurface's dimensions, pixel format, image size, raw bits, and optional palette identifier to or from an Archive. When deserializing, it allocates memory for the surface bits and populates them from the archive data.
    /// <code>Offset: 0x00444640
    /// void __thiscall RenderSurface::Serialize(RenderSurface*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive object used for reading or writing the surface data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderSurface, ACBindings.Internal.Archive*, void>)0x00444640)(ref this, io_archive);
}

