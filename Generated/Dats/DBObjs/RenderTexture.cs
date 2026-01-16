namespace ACBindings.Internal;


/// <summary>Represents a renderable texture resource in the graphics engine, encapsulating its type, pixel format, dimensions, mipmap levels, and management state for efficient rendering.</summary>
public unsafe struct RenderTexture : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct RenderTexture_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, uint, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte> Create2D; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte> CreateCube; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, ACBindings.Internal.RenderTexture*, byte> LoadTexture; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.RenderTexture*, uint, uint, ACBindings.Internal.GraphicsResource*> GetLevelRef; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.TextureType m_TextureType;
    public uint m_nNumLevels;
    public ACBindings.Internal.PixelFormatID m_PixelFormat;
    public uint m_Flags;
    public byte m_bDropLevelsCalled;
    public uint m_ManagedRefCount;
    public double m_LastManagedReleaseTime;
    public byte m_AllowManagement;
    public ACBindings.Internal.SmartArray___DBLevelInfo m_SourceLevels;
    public uint m_nWidth;
    public uint m_nHeight;
    public uint m_nEdgeLength;

    // Generated Constructor
    public RenderTexture() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates a 2D render texture with the specified width, height, mipmap levels, pixel format and flags; rejects incompatible flag combinations.
    /// <code>Offset: 0x0044B950
    /// bool __thiscall RenderTexture::Create2D(RenderTexture*,const unsigned int,const unsigned int,const unsigned int,const PixelFormatID,const unsigned int)</code>
    /// </summary>
    /// <param name="this">The RenderTexture instance to initialize.</param>
    /// <param name="nWidth">Desired texture width in texels.</param>
    /// <param name="nHeight">Desired texture height in texels.</param>
    /// <param name="nNumLevels">Number of mipmap levels to allocate.</param>
    /// <param name="PixelFormat">Identifier for the pixel format used by the texture.</param>
    /// <param name="Flags">Bitmask controlling creation behavior; flags 1 and 2 cannot be set simultaneously.</param>
    /// <returns>True if the texture was initialized successfully; otherwise false when incompatible flags are supplied.</returns>
    public byte Create2D(uint nWidth, uint nHeight, uint nNumLevels, ACBindings.Internal.PixelFormatID PixelFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, uint, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte>)0x0044B950)(ref this, nWidth, nHeight, nNumLevels, PixelFormat, Flags);

    /// <summary>Creates a cube texture with the specified edge length, mip levels, pixel format and creation flags; initializes internal state and marks the resource as available.
    /// <code>Offset: 0x0044B9A0
    /// bool __thiscall RenderTexture::CreateCube(RenderTexture*,const unsigned int,const unsigned int,const PixelFormatID,const unsigned int)</code>
    /// </summary>
    /// <param name="nEdgeLength">The size of each cube face in texels.</param>
    /// <param name="nNumLevels">Number of mipmap levels to allocate for the texture.</param>
    /// <param name="PixelFormat">Identifier of the desired pixel format.</param>
    /// <param name="Flags">Bitmask controlling creation options; must not contain both flag 0x1 and flag 0x2 simultaneously.</param>
    /// <returns>True if the cube texture was successfully created; otherwise, false when the rendering device is unavailable or incompatible flags are supplied.</returns>
    public byte CreateCube(uint nEdgeLength, uint nNumLevels, ACBindings.Internal.PixelFormatID PixelFormat, uint Flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, uint, uint, ACBindings.Internal.PixelFormatID, uint, byte>)0x0044B9A0)(ref this, nEdgeLength, nNumLevels, PixelFormat, Flags);

    /// <summary>Determines whether high‑detail rendering for this texture should be suppressed based on current resource usage or system constraints.
    /// <code>Offset: 0x0044B9F0
    /// bool __cdecl RenderTexture::ShouldDropHighDetail()</code>
    /// </summary>
    /// <returns>True if high detail should be dropped; otherwise, false.</returns>
    public static byte ShouldDropHighDetail() => ((delegate* unmanaged[Cdecl]<byte>)0x0044B9F0)();

    /// <summary>Refreshes the render texture, verifying its readiness for use.
    /// <code>Offset: 0x0044BA10
    /// bool __thiscall RenderTexture::Refresh(void*,int)</code>
    /// </summary>
    /// <param name="a2">Ignored parameter.</param>
    /// <returns>True if both internal refresh checks succeed; otherwise, false.</returns>
    public byte Refresh(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, int, byte>)0x0044BA10)(ref this, a2);

    /// <summary>Chooses a suitable texture format for rendering based on runtime conditions and format properties.
    /// <code>Offset: 0x0044BA40
    /// PixelFormatID __cdecl RenderTexture::SelectTextureFormat(const PixelFormatID)</code>
    /// </summary>
    /// <param name="format">The original pixel format identifier to evaluate.</param>
    /// <returns>The selected pixel format identifier, possibly adjusted by renderer settings or unchanged if no conversion is required.</returns>
    public static ACBindings.Internal.PixelFormatID SelectTextureFormat(ACBindings.Internal.PixelFormatID format) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PixelFormatID, ACBindings.Internal.PixelFormatID>)0x0044BA40)(format);

    /// <summary>Releases all source level texture resources associated with the RenderTexture instance, ensuring each resource is properly freed and its reference cleared.
    /// <code>Offset: 0x0044BAC0
    /// void __thiscall RenderTexture::ReleaseSourceLevelReferences(RenderTexture*)</code>
    /// </summary>
    public void ReleaseSourceLevelReferences() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044BAC0)(ref this);

    /// <summary>Releases sub‑objects of a render texture during runtime by clearing its source level references.
    /// <code>Offset: 0x0044BB20
    /// bool __thiscall RenderTexture::ReleaseSubObjects(RenderTexture*)</code>
    /// </summary>
    /// <returns>True if the operation succeeded, which it always does for this implementation.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BB20)(ref this);

    /// <summary>Loads texture level resources from the database and associates them with the RenderTexture instance.
    /// <code>Offset: 0x0044BB40
    /// bool __thiscall RenderTexture::LoadLevelResources(RenderTexture*)</code>
    /// </summary>
    /// <returns>True if all levels were successfully loaded; otherwise, false.</returns>
    public byte LoadLevelResources() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BB40)(ref this);

    /// <summary>Creates a graphics texture from this object's source levels, choosing an appropriate pixel format and allocating GPU resources for 2D or cube textures. Handles special cases such as Movie2D by releasing references. Returns true if the texture was successfully constructed; otherwise false.
    /// <code>Offset: 0x0044BC30
    /// bool __thiscall RenderTexture::ConstructTexture(RenderTexture*)</code>
    /// </summary>
    /// <returns>True on success; false on failure.</returns>
    public byte ConstructTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BC30)(ref this);

    /// <summary>Retrieves subobjects for a render texture by loading required level resources and constructing the texture during runtime. Returns true when not in runtime mode or after successful construction; otherwise returns false.
    /// <code>Offset: 0x0044BF80
    /// bool __thiscall RenderTexture::GetSubObjects(RenderTexture*)</code>
    /// </summary>
    /// <returns>True if the subobjects were retrieved successfully, otherwise false.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044BF80)(ref this);

    /// <summary>Constructs a RenderTexture instance, initializing its base objects and setting default values for texture type, level count, pixel format, flags, dimensions, and management state.
    /// <code>Offset: 0x0044C430
    /// void __thiscall RenderTexture::RenderTexture(RenderTexture*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C430)(ref this);

    /// <summary>Retrieves the database object type identifier for this render texture.
    /// <code>Offset: 0x0044C4A0
    /// unsigned int __thiscall RenderTexture::GetDBOType(RenderTexture*)</code>
    /// </summary>
    /// <returns>The DBO type identifier as an unsigned integer (currently always 30).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, uint>)0x0044C4A0)(ref this);

    /// <summary>Releases all source level references for this render texture and resets its internal level array, cleaning up resources after rendering operations complete.
    /// <code>Offset: 0x0044C4C0
    /// void __thiscall RenderTexture::End(RenderTexture*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C4C0)(ref this);

    /// <summary>Destroys a RenderTexture instance by releasing all associated source level references and resetting its internal state to default values.
    /// <code>Offset: 0x0044C4F0
    /// void __thiscall RenderTexture::Destroy(RenderTexture*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C4F0)(ref this);

    /// <summary>Reduces the number of stored mipmap levels for this render texture based on current rendering quality settings, freeing higher‑detail data when it is not needed.
    /// <code>Offset: 0x0044C550
    /// bool __thiscall RenderTexture::DropUnwantedLevels(RenderTexture*)</code>
    /// </summary>
    /// <returns>True if the operation succeeded; false if no renderer is available.</returns>
    public byte DropUnwantedLevels() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044C550)(ref this);

    /// <summary>Allocates a rendering texture resource for the current instance. When runtime caching is active and a renderer exists, the allocation request is forwarded to the renderer; otherwise, a new RenderTexture object is constructed with operator new.
    /// <code>Offset: 0x0044C660
    /// DBObj* __thiscall RenderTexture::Allocate(RenderTexture*)</code>
    /// </summary>
    /// <returns>A pointer to the allocated DBObj representing the texture resource, or null if allocation fails or conditions are not met.</returns>
    public ACBindings.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.DBObj*>)0x0044C660)(ref this);

    /// <summary>Destroys a RenderTexture, releasing all source level references, resetting internal arrays, and invoking base class destructors to clean up graphics resources.
    /// <code>Offset: 0x0044C6C0
    /// void __thiscall RenderTexture::~RenderTexture(RenderTexture*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, void>)0x0044C6C0)(ref this);

    /// <summary>Copies the texture data from this RenderTexture into the supplied DBObj structure, including metadata and source level references while updating reference counts.
    /// <code>Offset: 0x0044C710
    /// bool __thiscall RenderTexture::CopyInto(RenderTexture*,DBObj*)</code>
    /// </summary>
    /// <param name="Retval">Destination DBObj that will receive the copied texture information.</param>
    /// <returns>True if the copy succeeds; otherwise false.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* Retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.DBObj*, byte>)0x0044C710)(ref this, Retval);

    /// <summary>
    /// Collects qualified data identifiers for all sub-resources across texture source levels, optionally dropping unused levels during runtime.
    /// 
    /// <code>Offset: 0x0044C880
    /// void __thiscall RenderTexture::GetSubDataIDs(RenderTexture*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="aQDID">
    /// Receives the list of QualifiedDataIDs corresponding to each available resource within the render texture. Each identifier is added with a qualifier indicating whether it belongs to the first level when multiple levels exist.
    /// </param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* aQDID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0044C880)(ref this, aQDID);

    /// <summary>Initializes the render texture by discarding unwanted mipmap levels when running in runtime mode, returning success status.
    /// <code>Offset: 0x0044C920
    /// bool __thiscall RenderTexture::InitLoad(RenderTexture*)</code>
    /// </summary>
    /// <returns>True if initialization succeeds or is unnecessary at runtime; otherwise false.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, byte>)0x0044C920)(ref this);

    /// <summary>Serializes the RenderTexture's state—including texture type and source level information—to or from an Archive, updating internal arrays when loading.
    /// <code>Offset: 0x0044C940
    /// void __thiscall RenderTexture::Serialize(RenderTexture*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTexture, ACBindings.Internal.Archive*, void>)0x0044C940)(ref this, io_archive);
}

