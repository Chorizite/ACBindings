namespace ACBindings.Internal;


/// <summary>
/// Represents a Direct3D 9 render texture, holding references to a 2D or cube surface and the per‑level resource array.
/// </summary>
public unsafe struct RenderTextureD3D : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.RenderTexture BaseClass_RenderTexture; // ACBindings.Internal.RenderTexture

    // Child Types
    public unsafe struct RenderTextureD3D_vtbl
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
    public System.IntPtr m_p2DTextureD3D;
    public System.IntPtr m_pCubeTextureD3D;
    public ACBindings.Internal.SmartArray___D3DLevelResourceType m_D3DSurfaces;

    // Generated Constructor
    public RenderTextureD3D() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether sub‑objects are available for the texture, delegating to the base RenderTexture implementation when a renderer exists.
    /// <code>Offset: 0x00696060
    /// bool __thiscall RenderTextureD3D::GetSubObjects(RenderTextureD3D*)</code>
    /// </summary>
    /// <returns>True if sub‑objects can be retrieved; otherwise, false.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696060)(ref this);

    /// <summary>Releases all Direct3D surface resources associated with this texture and clears the internal surface array.
    /// <code>Offset: 0x006961D0
    /// void __thiscall RenderTextureD3D::ReleaseD3DSurfaces(RenderTextureD3D*)</code>
    /// </summary>
    public void ReleaseD3DSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x006961D0)(ref this);

    /// <summary>Releases Direct3D 2D and cube textures associated with the render texture, invalidates any cached device references, frees GPU resources, and updates the global texture byte counter.
    /// <code>Offset: 0x00696240
    /// void __thiscall RenderTextureD3D::ReleaseD3DTexture(RenderTextureD3D*)</code>
    /// </summary>
    public void ReleaseD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x00696240)(ref this);

    /// <summary>Releases the Direct3D texture resource associated with this RenderTextureD3D instance and prepares it for reloading.
    /// <code>Offset: 0x006962D0
    /// bool __thiscall RenderTextureD3D::PurgeResource(RenderTextureD3D*)</code>
    /// </summary>
    /// <returns>True if the resource was successfully released; otherwise, false.</returns>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x006962D0)(ref this);

    /// <summary>Copies all Direct3D surface resources from this texture to another RenderTextureD3D instance, replacing any existing surfaces in the target and updating resource references accordingly.
    /// <code>Offset: 0x00696380
    /// bool __thiscall RenderTextureD3D::CopyInto(RenderTextureD3D*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">The destination RenderTextureD3D that will receive the copied data.</param>
    /// <returns>True if the copy succeeds; otherwise false.</returns>
    public byte CopyInto(ACBindings.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, ACBindings.Internal.DBObj*, byte>)0x00696380)(ref this, retval);

    /// <summary>Releases Direct3D texture resources for a RenderTextureD3D instance and forwards sub‑object cleanup to its RenderTexture base class.
    /// <code>Offset: 0x00696440
    /// bool __thiscall RenderTextureD3D::ReleaseSubObjects(RenderTextureD3D*)</code>
    /// </summary>
    /// <returns>True when the operation is performed outside runtime or if the base class cleanup succeeds; otherwise false.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696440)(ref this);

    /// <summary>Create Direct3D textures for a 2D or cube render target based on its properties, allocating GPU resources and initializing surface descriptors. Returns true if creation succeeds.
    /// <code>Offset: 0x00696470
    /// bool __thiscall RenderTextureD3D::CreateD3DTexture(RenderTextureD3D*)</code>
    /// </summary>
    /// <returns>True when the texture(s) were successfully created; false otherwise.</returns>
    public byte CreateD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696470)(ref this);

    /// <summary>Restores the Direct3D texture associated with this render texture after a device loss, recreating resources if necessary.
    /// <code>Offset: 0x00696840
    /// bool __thiscall RenderTextureD3D::RestoreResource(RenderTextureD3D*)</code>
    /// </summary>
    /// <returns>True if the resource was successfully restored or already valid; otherwise false.</returns>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, byte>)0x00696840)(ref this);

    /// <summary>Destroys the Direct3D texture object, releasing any runtime textures and cleaning up subobjects. Resets internal pointers and marks the graphics resource as not lost.
    /// <code>Offset: 0x00696880
    /// void __thiscall RenderTextureD3D::Destroy(RenderTextureD3D*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x00696880)(ref this);

    /// <summary>Retrieves or creates the Direct3D 9 2D texture for this render texture, restoring it from a lost state when necessary and updating usage timestamps.
    /// <code>Offset: 0x006968D0
    /// IDirect3DTexture9* __thiscall RenderTextureD3D::Get2DTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    /// <param name="this">The RenderTextureD3D instance whose texture is requested.</param>
    /// <returns>Pointer to the IDirect3DTexture9 object or nullptr if restoration fails.</returns>
    public System.IntPtr Get2DTextureD3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, System.IntPtr>)0x006968D0)(ref this);

    /// <summary>Provides access to the Direct3D cube texture for this render target, restoring it when lost and generating it on demand.
    /// <code>Offset: 0x00696930
    /// IDirect3DCubeTexture9* __thiscall RenderTextureD3D::GetCubeTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    /// <returns>A pointer to the IDirect3DCubeTexture9 instance, or nullptr if restoration fails.</returns>
    public System.IntPtr GetCubeTextureD3D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, System.IntPtr>)0x00696930)(ref this);

    /// <summary>Constructs a RenderTextureD3D object, initializing the base RenderTexture component and clearing all Direct3D texture references.
    /// <code>Offset: 0x00696990
    /// void __thiscall RenderTextureD3D::RenderTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x00696990)(ref this);

    /// <summary>Destroys a RenderTextureD3D instance, releasing Direct3D textures and sub‑objects, clearing internal resources, and restoring base class state.
    /// <code>Offset: 0x006969E0
    /// void __thiscall RenderTextureD3D::~RenderTextureD3D(RenderTextureD3D*)</code>
    /// </summary>
    /// <param name="this">Pointer to the RenderTextureD3D object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, void>)0x006969E0)(ref this);

    /// <summary>Retrieves a reference to the graphics resource for a specified mipmap level and sub‑resource index of a 2D or cube texture, incrementing its reference count before returning.
    /// <code>Offset: 0x00696A60
    /// GraphicsResource* __thiscall RenderTextureD3D::GetLevelRef(RenderTextureD3D*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="nLevel">Zero‑based mipmap level to access.</param>
    /// <param name="Resource">Sub‑resource offset within that level (e.g., face index for cube maps).</param>
    /// <returns>Pointer to the requested GraphicsResource, or null if the texture type is unsupported, the level index exceeds available levels, or the sub‑resource does not exist.</returns>
    public ACBindings.Internal.GraphicsResource* GetLevelRef(uint nLevel, uint Resource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, uint, uint, ACBindings.Internal.GraphicsResource*>)0x00696A60)(ref this, nLevel, Resource);

    /// <summary>Copies a Direct3D texture resource from the specified source into this render texture, validating flags and type before creating or copying the underlying D3D texture.
    /// <code>Offset: 0x00696B00
    /// bool __thiscall RenderTextureD3D::LoadTexture(RenderTextureD3D*,const RenderTexture*)</code>
    /// </summary>
    /// <param name="Source">The source RenderTexture containing the data to load.</param>
    /// <returns>True if the texture was successfully loaded; otherwise, false.</returns>
    public byte LoadTexture(ACBindings.Internal.RenderTexture* Source) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderTextureD3D, ACBindings.Internal.RenderTexture*, byte>)0x00696B00)(ref this, Source);
}

