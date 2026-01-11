namespace ACBindings.Internal;

public unsafe struct ImgTex : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Statics
    public static uint* min_tex_size = (uint*)0x0081F928;
    public static ACBindings.Internal.ImageScaleType* fLandTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846774;
    public static ACBindings.Internal.ImageScaleType* fClipmapTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846778;
    public static ACBindings.Internal.ImageScaleType* fRGBATextureScale = (ACBindings.Internal.ImageScaleType*)0x0084677C;
    public static ACBindings.Internal.ImageScaleType* fIndexedTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846780;
    public static ACBindings.Internal.ImageScaleType* fCurrentTextureScale = (ACBindings.Internal.ImageScaleType*)0x00846784;

    // Child Types
    public unsafe struct ImgTex_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004F7B90
    /// DBObj* __cdecl ImgTex::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B90)();

    /// <summary>
    /// <code>Offset: 0x00503F50
    /// DBObj* __cdecl ImgTex::Get(int)</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x00503F50)(a1);

    /// <summary>
    /// <code>Offset: 0x00536BC0
    /// PixelFormatID __thiscall ImgTex::get_image_type(ImgTex*)</code>
    /// </summary>
    public ACBindings.Internal.PixelFormatID get_image_type() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.PixelFormatID>)0x00536BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053F1F0
    /// unsigned int __thiscall ImgTex::get_width(ImgTex*)</code>
    /// </summary>
    public uint get_width() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, uint>)0x0053F1F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053F210
    /// unsigned int __thiscall ImgTex::get_height(ImgTex*)</code>
    /// </summary>
    public uint get_height() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, uint>)0x0053F210)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053F230
    /// bool __thiscall ImgTex::CSI2TGA(ImgTex*,unsigned __int8*,int,int,unsigned __int8*,int,int,int)</code>
    /// </summary>
    public byte CSI2TGA(byte* csi_data, int csi_width, int csi_height, byte* tga_data, int tga_width, int tga_height, int tga_pitch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte*, int, int, byte*, int, int, int, byte>)0x0053F230)(ref this, csi_data, csi_width, csi_height, tga_data, tga_width, tga_height, tga_pitch);

    /// <summary>
    /// <code>Offset: 0x0053F270
    /// unsigned __int8* __thiscall ImgTex::GetData(ImgTex*)</code>
    /// </summary>
    public byte* GetData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte*>)0x0053F270)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053F2B0
    /// bool __thiscall ImgTex::PurgeResource(ImgTex*)</code>
    /// </summary>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x0053F2B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053F310
    /// IDirect3DTexture9* __thiscall ImgTex::GetD3DTexture(ImgTex*)</code>
    /// </summary>
    public System.IntPtr GetD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, System.IntPtr>)0x0053F310)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053F4A0
    /// void __cdecl ImgTex::TileCSI(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int)</code>
    /// </summary>
    public static void TileCSI(byte* data, uint dest_height, uint dest_width, ACBindings.Internal.ImgTex* csi_tex, uint tiling) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*, uint, void>)0x0053F4A0)(data, dest_height, dest_width, csi_tex, tiling);

    /// <summary>
    /// <code>Offset: 0x0053F5D0
    /// void __cdecl ImgTex::MergeTexture(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int,ImgTex*,LandDefs::Rotation)</code>
    /// </summary>
    public static void MergeTexture(byte* data, uint dest_height, uint dest_width, ACBindings.Internal.ImgTex* csi_merge_tex, uint tiling, ACBindings.Internal.ImgTex* alpha_map, ACBindings.Internal.LandDefs.Rotation rot) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*, uint, ACBindings.Internal.ImgTex*, ACBindings.Internal.LandDefs.Rotation, void>)0x0053F5D0)(data, dest_height, dest_width, csi_merge_tex, tiling, alpha_map, rot);

    /// <summary>
    /// <code>Offset: 0x0053F9C0
    /// bool __cdecl ImgTex::CopyIntoData(unsigned __int8*,int,ImgTex*,const Palette*,bool)</code>
    /// </summary>
    public static byte CopyIntoData(byte* dst_data, int dst_pitch, ACBindings.Internal.ImgTex* texture, ACBindings.Internal.Palette* palette, byte clipmap) => ((delegate* unmanaged[Cdecl]<byte*, int, ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, byte, byte>)0x0053F9C0)(dst_data, dst_pitch, texture, palette, clipmap);

    /// <summary>
    /// <code>Offset: 0x0053FB10
    /// bool __thiscall ImgTex::CreateD3DTexture(ImgTex*)</code>
    /// </summary>
    public byte CreateD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x0053FB10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053FDE0
    /// bool __thiscall ImgTex::RestoreResource(ImgTex*)</code>
    /// </summary>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x0053FDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053FE40
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall ImgTex::GetSurfaceDID(int,IDClass&lt;_tagDataID,32,0&gt;*)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* GetSurfaceDID(ACBindings.Internal.IDClass____tagDataID* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.IDClass____tagDataID*, ACBindings.Internal.IDClass____tagDataID*>)0x0053FE40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0053FFD0
    /// void __thiscall ImgTex::CreateFromRenderSurface_Internal(ImgTex*,RenderSurface*)</code>
    /// </summary>
    public void CreateFromRenderSurface_Internal(ACBindings.Internal.RenderSurface* i_pRS) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.RenderSurface*, void>)0x0053FFD0)(ref this, i_pRS);

    /// <summary>
    /// <code>Offset: 0x00540030
    /// void __cdecl ImgTex::CopyCSI(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int)</code>
    /// </summary>
    public static void CopyCSI(byte* data, uint height, uint width, ACBindings.Internal.ImgTex* csi_tex, uint tiling) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*, uint, void>)0x00540030)(data, height, width, csi_tex, tiling);

    /// <summary>
    /// <code>Offset: 0x00540060
    /// bool __thiscall ImgTex::Load(ImgTex*,ImgTex*)</code>
    /// </summary>
    public byte Load(ACBindings.Internal.ImgTex* texture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.ImgTex*, byte>)0x00540060)(ref this, texture);

    /// <summary>
    /// <code>Offset: 0x00540100
    /// void __thiscall ImgTex::GetSubDataIDs(ImgTex*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00540100)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005401C0
    /// void __thiscall ImgTex::ImgTex(ImgTex*,RenderSurface*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.RenderSurface* i_pRS) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.RenderSurface*, void>)0x005401C0)(ref this, i_pRS);

    /// <summary>
    /// <code>Offset: 0x00540240
    /// bool __thiscall ImgTex::InitLoad(ImgTex*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte>)0x00540240)(ref this);

    /// <summary>
    /// <code>Offset: 0x00540290
    /// void __thiscall ImgTex::Serialize(ImgTex*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.Archive*, void>)0x00540290)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00540B80
    /// ImgTex* __cdecl ImgTex::AllocateTempBuffer(int,int,PixelFormatID)</code>
    /// </summary>
    public static ACBindings.Internal.ImgTex* AllocateTempBuffer(int width, int height, ACBindings.Internal.PixelFormatID image_type) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.Internal.PixelFormatID, ACBindings.Internal.ImgTex*>)0x00540B80)(width, height, image_type);

    /// <summary>
    /// <code>Offset: 0x00540CE0
    /// void __thiscall ImgTex::~ImgTex(ImgTex*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, void>)0x00540CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00540DC0
    /// ImgTex* __cdecl ImgTex::GetTempBuffer(int,int,PixelFormatID)</code>
    /// </summary>
    public static ACBindings.Internal.ImgTex* GetTempBuffer(int width, int height, ACBindings.Internal.PixelFormatID image_type) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.Internal.PixelFormatID, ACBindings.Internal.ImgTex*>)0x00540DC0)(width, height, image_type);

    /// <summary>
    /// <code>Offset: 0x00540EE0
    /// bool __thiscall ImgTex::Combine(ImgTex*,ImgTex*,const Palette*,bool)</code>
    /// </summary>
    public byte Combine(ACBindings.Internal.ImgTex* texture, ACBindings.Internal.Palette* palette, byte clipmap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, byte, byte>)0x00540EE0)(ref this, texture, palette, clipmap);

    /// <summary>
    /// <code>Offset: 0x00540FF0
    /// bool __thiscall ImgTex::LoadCSI(ImgTex*,unsigned __int8*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte LoadCSI(byte* csi_data, uint csi_width, uint csi_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ImgTex, byte*, uint, uint, byte>)0x00540FF0)(ref this, csi_data, csi_width, csi_height);

    /// <summary>
    /// <code>Offset: 0x005410D0
    /// ImgTex* __cdecl ImgTex::CreateCombinedTexture(ImgTex*,const Palette*,bool)</code>
    /// </summary>
    public static ACBindings.Internal.ImgTex* CreateCombinedTexture(ACBindings.Internal.ImgTex* i_pIndexedImage, ACBindings.Internal.Palette* i_pPalette, byte fHasClipmap) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, byte, ACBindings.Internal.ImgTex*>)0x005410D0)(i_pIndexedImage, i_pPalette, fHasClipmap);

    /// <summary>
    /// <code>Offset: 0x005411D0
    /// ImgTex* __cdecl ImgTex::CreateLScapeTexture(unsigned __int8*,unsigned int,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.ImgTex* CreateLScapeTexture(byte* i_pRawData, uint i_width, uint i_height) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.Internal.ImgTex*>)0x005411D0)(i_pRawData, i_width, i_height);
}

