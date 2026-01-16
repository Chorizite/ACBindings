namespace ACBindings.Internal;


/// <summary>Encapsulates a texture resource, managing its data across GPU and system memory, including multiple source mip levels, palette support, and lock state for safe access.</summary>
public unsafe struct ImgTex : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Statics
    public static uint* min_tex_size = (uint*)0x0081F928;
    public static ACBindings.Internal.HashSet___ImgTex_ptr* custom_texture_table = (ACBindings.Internal.HashSet___ImgTex_ptr*)0x0081FA80;
    public static ACBindings.Internal.ImageScaleType* fLandTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846774;
    public static ACBindings.Internal.ImageScaleType* fClipmapTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846778;
    public static ACBindings.Internal.ImageScaleType* fRGBATextureScale = (ACBindings.Internal.ImageScaleType*)0x0084677C;
    public static ACBindings.Internal.ImageScaleType* fIndexedTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846780;
    public static ACBindings.Internal.ImageScaleType* fCurrentTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846784;

    // Child Types
    public unsafe struct ImgTex_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.SmartArray___IDClass____tagDataID m_SourceLevels;
    public ACBindings.Internal.RenderSurface* m_pImageData;
    public ACBindings.Internal.Palette* m_pPalette;
    public int m_cPitch;
    public ulong m_TextureCode;
    public System.IntPtr m_pD3DTexture;
    public ACBindings.Internal.RenderTexture* m_pRenderTexture;
    public ACBindings.Internal.RenderTexture* m_pSystemMemTexture;
    public byte m_IsLocked;

    // Generated Constructor
    public ImgTex(ACBindings.Internal.RenderSurface* i_pRS) {
        _ConstructorInternal(i_pRS);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Allocates and constructs an ImgTex object, returning a pointer to its DBObj base.
    /// <code>Offset: 0x004F7B90
    /// DBObj* __cdecl ImgTex::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created ImgTex instance (as a DBObj), or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B90)();

    /// <summary>Retrieves the database object associated with the specified texture index.
    /// <code>Offset: 0x00503F50
    /// DBObj* __cdecl ImgTex::Get(int)</code>
    /// </summary>
    /// <param name="a1">The zero‑based index identifying the desired image texture level or source.</param>
    /// <returns>A pointer to the corresponding DBObj instance, or nullptr if no matching object exists.</returns>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x00503F50)(a1);

    /// <summary>Gets the pixel format identifier of the texture's image data, or 0 if no image is available.
    /// <code>Offset: 0x00536BC0
    /// PixelFormatID __thiscall ImgTex::get_image_type(ImgTex*)</code>
    /// </summary>
    /// <returns>The PixelFormatID representing the surface’s format, or 0 when m_pImageData is null.</returns>
    public ACBindings.Internal.PixelFormatID get_image_type() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.PixelFormatID>)0x00536BC0)(ref this);

    /// <summary>Retrieves the width of the associated render surface, returning 0 when no surface is present.
    /// <code>Offset: 0x0053F1F0
    /// unsigned int __thiscall ImgTex::get_width(ImgTex*)</code>
    /// </summary>
    /// <returns>The width in pixels, or 0 if the image data surface is null.</returns>
    public uint get_width() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, uint>)0x0053F1F0)(ref this);

    /// <summary>Returns the height of the image data surface associated with this texture, or 0 when no surface exists.
    /// <code>Offset: 0x0053F210
    /// unsigned int __thiscall ImgTex::get_height(ImgTex*)</code>
    /// </summary>
    /// <returns>The pixel height of the underlying render surface, or zero if the surface is null.</returns>
    public uint get_height() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, uint>)0x0053F210)(ref this);

    /// <summary>Copies image pixel data from a CSI source buffer into a TGA destination buffer when the dimensions match; otherwise returns failure.
    /// <code>Offset: 0x0053F230
    /// bool __thiscall ImgTex::CSI2TGA(ImgTex*,unsigned __int8*,int,int,unsigned __int8*,int,int,int)</code>
    /// </summary>
    /// <param name="csi_data">Source pixel data in CSI format.</param>
    /// <param name="csi_width">Width of the source image in pixels.</param>
    /// <param name="csi_height">Height of the source image in pixels.</param>
    /// <param name="tga_data">Destination buffer for TGA pixel data.</param>
    /// <param name="tga_width">Width of the destination image in pixels.</param>
    /// <param name="tga_height">Height of the destination image in pixels.</param>
    /// <param name="tga_pitch">Bytes per row in the destination buffer; ignored by this function.</param>
    /// <returns>True if source and destination dimensions match and data is copied; false otherwise.</returns>
    public byte CSI2TGA(byte* csi_data, int csi_width, int csi_height, byte* tga_data, int tga_width, int tga_height, int tga_pitch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte*, int, int, byte*, int, int, int, byte>)0x0053F230)(ref this, csi_data, csi_width, csi_height, tga_data, tga_width, tga_height, tga_pitch);

    /// <summary>Retrieves a pointer to the raw image data from the texture, locking the surface for direct access.
    /// <code>Offset: 0x0053F270
    /// unsigned __int8* __thiscall ImgTex::GetData(ImgTex*)</code>
    /// </summary>
    /// <returns>A byte pointer to the pixel buffer when successful; otherwise null.</returns>
    public byte* GetData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte*>)0x0053F270)(ref this);

    /// <summary>Purges the image texture’s graphics resources, marking them as lost and releasing any frame usage references.
    /// <code>Offset: 0x0053F2B0
    /// bool __thiscall ImgTex::PurgeResource(ImgTex*)</code>
    /// </summary>
    /// <returns>True if the purge succeeded; otherwise false when initialization fails.</returns>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x0053F2B0)(ref this);

    /// <summary>Retrieves the Direct3D9 texture associated with this image, restoring lost resources and recreating the render texture on demand.
    /// <code>Offset: 0x0053F310
    /// IDirect3DTexture9* __thiscall ImgTex::GetD3DTexture(ImgTex*)</code>
    /// </summary>
    /// <returns>The IDirect3DTexture9 interface for the image’s GPU texture, or null if restoration or creation failed.</returns>
    public System.IntPtr GetD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, System.IntPtr>)0x0053F310)(ref this);

    /// <summary>Copies pixel data from a source ImgTex and tiles it into a destination buffer, filling an area defined by dest_width and dest_height. The source image is repeatedly copied according to the tiling count.
    /// <code>Offset: 0x0053F4A0
    /// void __cdecl ImgTex::TileCSI(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int)</code>
    /// </summary>
    /// <param name="data">Pointer to the output buffer where the tiled pixels are written. The buffer must be large enough for dest_height × dest_width pixels (typically 4 bytes per pixel).</param>
    /// <param name="dest_height">Height of the destination area in pixels.</param>
    /// <param name="dest_width">Width of the destination area in pixels.</param>
    /// <param name="csi_tex">Source ImgTex whose image data is tiled into the output buffer.</param>
    /// <param name="tiling">Number of times the source texture should be repeated. If zero, no tiling occurs.</param>
    public static void TileCSI(byte* data, uint dest_height, uint dest_width, ACBindings.Internal.ImgTex* csi_tex, uint tiling) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*, uint, void>)0x0053F4A0)(data, dest_height, dest_width, csi_tex, tiling);

    /// <summary>Blends the image from a source ImgTex into a destination RGBA buffer, optionally applying rotation and per‑pixel alpha blending based on an alpha map.
    /// <code>Offset: 0x0053F5D0
    /// void __cdecl ImgTex::MergeTexture(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int,ImgTex*,LandDefs::Rotation)</code>
    /// </summary>
    /// <param name="data">Pointer to the destination pixel array (RGBA 8‑bit) that receives the merged result.</param>
    /// <param name="dest_height">Number of rows in the destination area.</param>
    /// <param name="dest_width">Number of columns in the destination area.</param>
    /// <param name="csi_merge_tex">Source ImgTex whose image data is blended into the buffer.</param>
    /// <param name="tiling">Reserved; currently unused by MergeTexture.</param>
    /// <param name="alpha_map">ImgTex providing per‑pixel alpha values used to blend source pixels with destination pixels.</param>
    /// <param name="rot">Rotation applied to the source texture before blending (e.g., 90°, 180°, 270°).</param>
    public static void MergeTexture(byte* data, uint dest_height, uint dest_width, ACBindings.Internal.ImgTex* csi_merge_tex, uint tiling, ACBindings.Internal.ImgTex* alpha_map, ACBindings.Internal.LandDefs.Rotation rot) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*, uint, ACBindings.Internal.ImgTex*, ACBindings.Internal.LandDefs.Rotation, void>)0x0053F5D0)(data, dest_height, dest_width, csi_merge_tex, tiling, alpha_map, rot);

    /// <summary>Copies pixel indices from an ImgTex surface into a 32‑bit RGBA buffer using the supplied palette.
    /// <code>Offset: 0x0053F9C0
    /// bool __cdecl ImgTex::CopyIntoData(unsigned __int8*,int,ImgTex*,const Palette*,bool)</code>
    /// </summary>
    /// <param name="dst_data">Destination buffer; writes one 32‑bit pixel per source index.</param>
    /// <param name="dst_pitch">Number of bytes between rows in dst_data.</param>
    /// <param name="texture">Source texture whose image data is read.</param>
    /// <param name="palette">Palette used to translate indices into 32‑bit colors; must be non‑null when clipmap is false.</param>
    /// <param name="clipmap">When true, source indices less than 8 are written as fully transparent (0) instead of looked up in the palette.</param>
    /// <returns>True on success – the function currently always returns true.</returns>
    public static byte CopyIntoData(byte* dst_data, int dst_pitch, ACBindings.Internal.ImgTex* texture, ACBindings.Internal.Palette* palette, byte clipmap) => ((delegate* unmanaged[Cdecl]<byte*, int, ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, byte, byte>)0x0053F9C0)(dst_data, dst_pitch, texture, palette, clipmap);

    /// <summary>Creates a render texture for this image by loading its surface into system memory, generating mipmaps, and updating resource usage when running in runtime mode.
    /// <code>Offset: 0x0053FB10
    /// bool __thiscall ImgTex::CreateD3DTexture(ImgTex*)</code>
    /// </summary>
    /// <returns>True if the texture was successfully created and resources updated; otherwise false.</returns>
    public byte CreateD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x0053FB10)(ref this);

    /// <summary>Restores an image texture’s GPU resources, recreating its Direct3D texture if required and marking the resource as valid when successful.
    /// <code>Offset: 0x0053FDE0
    /// bool __thiscall ImgTex::RestoreResource(ImgTex*)</code>
    /// </summary>
    /// <returns>True when the texture and its related data are successfully restored; otherwise false.</returns>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x0053FDE0)(ref this);

    /// <summary>Retrieves the data identifier for the image surface, selecting an appropriate level based on current detail settings and populating the supplied ID object.
    /// <code>Offset: 0x0053FE40
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall ImgTex::GetSurfaceDID(int,IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    /// <param name="a2">Receives the resulting surface DID. The function assigns its internal ID field before returning.</param>
    /// <returns>The same IDClass instance passed in as a2.</returns>
    public ACBindings.Internal.IDClass____tagDataID* GetSurfaceDID(ACBindings.Internal.IDClass____tagDataID* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.IDClass____tagDataID*, ACBindings.Internal.IDClass____tagDataID*>)0x0053FE40)(ref this, a2);

    /// <summary>Creates or updates an ImgTex instance based on a given RenderSurface, assigning the source image data and handling palette lookup or Direct3D texture creation as needed.
    /// <code>Offset: 0x0053FFD0
    /// void __thiscall ImgTex::CreateFromRenderSurface_Internal(ImgTex*,RenderSurface*)</code>
    /// </summary>
    /// <param name="i_pRS">The render surface supplying image data for this texture.</param>
    public void CreateFromRenderSurface_Internal(ACBindings.Internal.RenderSurface* i_pRS) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.RenderSurface*, void>)0x0053FFD0)(ref this, i_pRS);

    /// <summary>Copies pixel data from a source texture into the supplied buffer or fills the buffer with a default color if no source is provided.
    /// <code>Offset: 0x00540030
    /// void __cdecl ImgTex::CopyCSI(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int)</code>
    /// </summary>
    /// <param name="data">Pointer to the destination buffer that receives the copied image data.</param>
    /// <param name="height">Number of rows in the image.</param>
    /// <param name="width">Number of columns in the image.</param>
    /// <param name="csi_tex">Source ImgTex object from which pixel data is copied; if null, the buffer is cleared to a default value.</param>
    /// <param name="tiling">Tiling mode used when copying from the source texture.</param>
    public static void CopyCSI(byte* data, uint height, uint width, ACBindings.Internal.ImgTex* csi_tex, uint tiling) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*, uint, void>)0x00540030)(data, height, width, csi_tex, tiling);

    /// <summary>Loads image data from the supplied ImgTex into this instance, provided pixel format, width, and height match; otherwise fails.
    /// <code>Offset: 0x00540060
    /// bool __thiscall ImgTex::Load(ImgTex*,ImgTex*)</code>
    /// </summary>
    /// <param name="texture">Source ImgTex whose image data will be loaded into this instance.</param>
    /// <returns>True when data is successfully transferred and a Direct3D texture created; false on mismatch or failure.</returns>
    public byte Load(ACBindings.Internal.ImgTex* texture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.ImgTex*, byte>)0x00540060)(ref this, texture);

    /// <summary>Adds each source level ID of the image texture to the supplied QualifiedDataIDArray, using a type code of 12 for the first entry when multiple levels exist and 8 otherwise.
    /// <code>Offset: 0x00540100
    /// void __thiscall ImgTex::GetSubDataIDs(ImgTex*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the constructed QualifiedDataIDs representing the texture’s source levels.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00540100)(ref this, id_array);

    /// <summary>Initializes a new ImgTex instance from the supplied RenderSurface, establishing its resource state and preparing for rendering.
    /// <code>Offset: 0x005401C0
    /// void __thiscall ImgTex::ImgTex(ImgTex*,RenderSurface*)</code>
    /// </summary>
    /// <param name="i_pRS">Render surface to use as image data source.</param>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* i_pRS) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.RenderSurface*, void>)0x005401C0)(ref this, i_pRS);

    /// <summary>Initializes the image texture by retrieving its associated render surface, creating an internal texture representation, and releasing the temporary surface.
    /// <code>Offset: 0x00540240
    /// bool __thiscall ImgTex::InitLoad(ImgTex*)</code>
    /// </summary>
    /// <returns>True if initialization succeeds; always returns true in this implementation.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x00540240)(ref this);

    /// <summary>Serializes or deserializes an image texture's data, including its source level identifiers and related metadata, to or from the given archive.
    /// <code>Offset: 0x00540290
    /// void __thiscall ImgTex::Serialize(ImgTex*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing; when flags indicate write mode, current state is stored, otherwise the object's fields are populated from the archive.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.Archive*, void>)0x00540290)(ref this, io_archive);

    /// <summary>Creates a temporary texture buffer of specified size and pixel format for rendering operations.
    /// <code>Offset: 0x00540B80
    /// ImgTex* __cdecl ImgTex::AllocateTempBuffer(int,int,PixelFormatID)</code>
    /// </summary>
    /// <param name="width">Desired width in pixels.</param>
    /// <param name="height">Desired height in pixels.</param>
    /// <param name="image_type">Pixel format identifier specifying the buffer's data layout.</param>
    /// <returns>Pointer to a newly allocated ImgTex instance on success; otherwise, nullptr if allocation or surface creation fails.</returns>
    public static ACBindings.Internal.ImgTex* AllocateTempBuffer(int width, int height, ACBindings.Internal.PixelFormatID image_type) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.Internal.PixelFormatID, ACBindings.Internal.ImgTex*>)0x00540B80)(width, height, image_type);

    /// <summary>Releases COM objects (render surface, palette, Direct3D texture, and render textures), removes the texture from internal hash tables, frees any allocated source‑level data, and calls the destructors of its base classes.
    /// <code>Offset: 0x00540CE0
    /// void __thiscall ImgTex::~ImgTex(ImgTex*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, void>)0x00540CE0)(ref this);

    /// <summary>Retrieves a temporary image buffer of the specified size and pixel format, reusing an existing cached instance when available or allocating a new one otherwise.
    /// <code>Offset: 0x00540DC0
    /// ImgTex* __cdecl ImgTex::GetTempBuffer(int,int,PixelFormatID)</code>
    /// </summary>
    /// <param name="width">The width of the desired image buffer in pixels.</param>
    /// <param name="height">The height of the desired image buffer in pixels.</param>
    /// <param name="image_type">Identifier for the pixel format to be used.</param>
    /// <returns>Pointer to an ImgTex instance representing the temporary buffer, or null if allocation failed.</returns>
    public static ACBindings.Internal.ImgTex* GetTempBuffer(int width, int height, ACBindings.Internal.PixelFormatID image_type) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.Internal.PixelFormatID, ACBindings.Internal.ImgTex*>)0x00540DC0)(width, height, image_type);

    /// <summary>Combines the image data from a source ImgTex into this instance using an optional palette and a pixel format determined by the clipmap flag.
    /// <code>Offset: 0x00540EE0
    /// bool __thiscall ImgTex::Combine(ImgTex*,ImgTex*,const Palette*,bool)</code>
    /// </summary>
    /// <param name="texture">Source ImgTex whose image data will be merged into this texture.</param>
    /// <param name="palette">Palette used to translate indexed colors; may be null when not required.</param>
    /// <param name="clipmap">If true, creates a 21‑bit pixel format surface; otherwise uses a 22‑bit format.</param>
    /// <returns>True if the combination succeeded and the resulting texture was loaded into this ImgTex; false on failure.</returns>
    public byte Combine(ACBindings.Internal.ImgTex* texture, ACBindings.Internal.Palette* palette, byte clipmap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, byte, byte>)0x00540EE0)(ref this, texture, palette, clipmap);

    /// <summary>Loads CSI image data into the texture by creating a temporary surface, converting the data to an internal TGA format, and initializing the graphics resource.
    /// <code>Offset: 0x00540FF0
    /// bool __thiscall ImgTex::LoadCSI(ImgTex*,unsigned __int8*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="csi_data">Pointer to the raw CSI image buffer.</param>
    /// <param name="csi_width">Width of the image in pixels.</param>
    /// <param name="csi_height">Height of the image in pixels.</param>
    /// <returns>True if the texture was successfully loaded; otherwise, false.</returns>
    public byte LoadCSI(byte* csi_data, uint csi_width, uint csi_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte*, uint, uint, byte>)0x00540FF0)(ref this, csi_data, csi_width, csi_height);

    /// <summary>Creates a combined texture from an indexed image and palette, caching the result for reuse.
    /// <code>Offset: 0x005410D0
    /// ImgTex* __cdecl ImgTex::CreateCombinedTexture(ImgTex*,const Palette*,bool)</code>
    /// </summary>
    /// <param name="i_pIndexedImage">The source indexed image to combine.</param>
    /// <param name="i_pPalette">The palette used for color mapping of the resulting texture.</param>
    /// <param name="fHasClipmap">Indicates whether clipmapping should be applied during combination.</param>
    /// <returns>Pointer to the new or cached combined texture, or null if creation fails.</returns>
    public static ACBindings.Internal.ImgTex* CreateCombinedTexture(ACBindings.Internal.ImgTex* i_pIndexedImage, ACBindings.Internal.Palette* i_pPalette, byte fHasClipmap) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, byte, ACBindings.Internal.ImgTex*>)0x005410D0)(i_pIndexedImage, i_pPalette, fHasClipmap);

    /// <summary>Creates an ImgTex instance from raw pixel data, loads the texture, and registers it in the custom texture table.
    /// <code>Offset: 0x005411D0
    /// ImgTex* __cdecl ImgTex::CreateLScapeTexture(unsigned __int8*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_pRawData">Pointer to the raw image data buffer.</param>
    /// <param name="i_width">Width of the image in pixels.</param>
    /// <param name="i_height">Height of the image in pixels.</param>
    /// <returns>Returns a pointer to the initialized ImgTex object on success; otherwise, returns nullptr if allocation or loading fails.</returns>
    public static ACBindings.Internal.ImgTex* CreateLScapeTexture(byte* i_pRawData, uint i_width, uint i_height) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*>)0x005411D0)(i_pRawData, i_width, i_height);
}

