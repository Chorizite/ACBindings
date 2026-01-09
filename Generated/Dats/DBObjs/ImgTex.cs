namespace ACBindings;

// ImgTex
public unsafe struct ImgTex : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj
    public ACBindings.GraphicsResource BaseClass_GraphicsResource; // ACBindings.GraphicsResource

    // Statics
    public static uint* min_tex_size = (uint*)0x0081F928;
    public static ACBindings.HashTable__PixelFormatID__HashTable__uint__ImgTex_ptr_ptr* temp_buffer_table = (ACBindings.HashTable__PixelFormatID__HashTable__uint__ImgTex_ptr_ptr*)0x0081F9FC;
    public static ACBindings.HashSet__ImgTex_ptr* custom_texture_table = (ACBindings.HashSet__ImgTex_ptr*)0x0081FA80;
    public static ACBindings.ImageScaleType* fLandTextureScale = (ACBindings.ImageScaleType*)0x00846774;
    public static ACBindings.ImageScaleType* fClipmapTextureScale = (ACBindings.ImageScaleType*)0x00846778;
    public static ACBindings.ImageScaleType* fRGBATextureScale = (ACBindings.ImageScaleType*)0x0084677C;
    public static ACBindings.ImageScaleType* fIndexedTextureScale = (ACBindings.ImageScaleType*)0x00846780;
    public static ACBindings.ImageScaleType* fCurrentTextureScale = (ACBindings.ImageScaleType*)0x00846784;

    // Child Types
    // ImgTex_vtbl
    public unsafe struct ImgTex_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SmartArray__IDClass___tagDataID m_SourceLevels;
    public ACBindings.RenderSurface* m_pImageData;
    public ACBindings.Palette* m_pPalette;
    public int m_cPitch;
    public ulong m_TextureCode;
    public System.IntPtr m_pD3DTexture;
    public ACBindings.RenderTexture* m_pRenderTexture;
    public ACBindings.RenderTexture* m_pSystemMemTexture;
    public byte m_IsLocked;

    // Generated Constructor
    public ImgTex(ACBindings.RenderSurface* i_pRS) {
        _ConstructorInternal(i_pRS);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl ImgTex::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7B90)();
    // DBObj* __cdecl ImgTex::Get(int)
    public static ACBindings.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x00503F50)(a1);
    // PixelFormatID __thiscall ImgTex::get_image_type(ImgTex*)
    public ACBindings.PixelFormatID get_image_type() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.PixelFormatID>)0x00536BC0)(ref this);
    // unsigned int __thiscall ImgTex::get_width(ImgTex*)
    public uint get_width() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, uint>)0x0053F1F0)(ref this);
    // unsigned int __thiscall ImgTex::get_height(ImgTex*)
    public uint get_height() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, uint>)0x0053F210)(ref this);
    // bool __thiscall ImgTex::CSI2TGA(ImgTex*,unsigned __int8*,int,int,unsigned __int8*,int,int,int)
    public byte CSI2TGA(byte* csi_data, int csi_width, int csi_height, byte* tga_data, int tga_width, int tga_height, int tga_pitch) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte*, int, int, byte*, int, int, int, byte>)0x0053F230)(ref this, csi_data, csi_width, csi_height, tga_data, tga_width, tga_height, tga_pitch);
    // unsigned __int8* __thiscall ImgTex::GetData(ImgTex*)
    public byte* GetData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte*>)0x0053F270)(ref this);
    // bool __thiscall ImgTex::PurgeResource(ImgTex*)
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte>)0x0053F2B0)(ref this);
    // IDirect3DTexture9* __thiscall ImgTex::GetD3DTexture(ImgTex*)
    public System.IntPtr GetD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, System.IntPtr>)0x0053F310)(ref this);
    // void __cdecl ImgTex::TileCSI(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int)
    public static void TileCSI(byte* data, uint dest_height, uint dest_width, ACBindings.ImgTex* csi_tex, uint tiling) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.ImgTex*, uint, void>)0x0053F4A0)(data, dest_height, dest_width, csi_tex, tiling);
    // void __cdecl ImgTex::MergeTexture(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int,ImgTex*,LandDefs::Rotation)
    public static void MergeTexture(byte* data, uint dest_height, uint dest_width, ACBindings.ImgTex* csi_merge_tex, uint tiling, ACBindings.ImgTex* alpha_map, ACBindings.LandDefs.Rotation rot) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.ImgTex*, uint, ACBindings.ImgTex*, ACBindings.LandDefs.Rotation, void>)0x0053F5D0)(data, dest_height, dest_width, csi_merge_tex, tiling, alpha_map, rot);
    // bool __cdecl ImgTex::CopyIntoData(unsigned __int8*,int,ImgTex*,const Palette*,bool)
    public static byte CopyIntoData(byte* dst_data, int dst_pitch, ACBindings.ImgTex* texture, ACBindings.Palette* palette, byte clipmap) => ((delegate* unmanaged[Cdecl]<byte*, int, ACBindings.ImgTex*, ACBindings.Palette*, byte, byte>)0x0053F9C0)(dst_data, dst_pitch, texture, palette, clipmap);
    // bool __thiscall ImgTex::CreateD3DTexture(ImgTex*)
    public byte CreateD3DTexture() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte>)0x0053FB10)(ref this);
    // bool __thiscall ImgTex::RestoreResource(ImgTex*)
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte>)0x0053FDE0)(ref this);
    // IDClass<_tagDataID,32,0>* __thiscall ImgTex::GetSurfaceDID(int,IDClass<_tagDataID,32,0>*)
    public ACBindings.IDClass___tagDataID* GetSurfaceDID(ACBindings.IDClass___tagDataID* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.IDClass___tagDataID*, ACBindings.IDClass___tagDataID*>)0x0053FE40)(ref this, a2);
    // void __thiscall ImgTex::CreateFromRenderSurface_Internal(ImgTex*,RenderSurface*)
    public void CreateFromRenderSurface_Internal(ACBindings.RenderSurface* i_pRS) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.RenderSurface*, void>)0x0053FFD0)(ref this, i_pRS);
    // void __cdecl ImgTex::CopyCSI(unsigned __int8*,unsigned int,unsigned int,ImgTex*,unsigned int)
    public static void CopyCSI(byte* data, uint height, uint width, ACBindings.ImgTex* csi_tex, uint tiling) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.ImgTex*, uint, void>)0x00540030)(data, height, width, csi_tex, tiling);
    // bool __thiscall ImgTex::Load(ImgTex*,ImgTex*)
    public byte Load(ACBindings.ImgTex* texture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.ImgTex*, byte>)0x00540060)(ref this, texture);
    // void __thiscall ImgTex::GetSubDataIDs(ImgTex*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.QualifiedDataIDArray*, void>)0x00540100)(ref this, id_array);
    // void __thiscall ImgTex::ImgTex(ImgTex*,RenderSurface*)
    public void _ConstructorInternal(ACBindings.RenderSurface* i_pRS) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.RenderSurface*, void>)0x005401C0)(ref this, i_pRS);
    // bool __thiscall ImgTex::InitLoad(ImgTex*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte>)0x00540240)(ref this);
    // void __thiscall ImgTex::Serialize(ImgTex*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.Archive*, void>)0x00540290)(ref this, io_archive);
    // ImgTex* __cdecl ImgTex::AllocateTempBuffer(int,int,PixelFormatID)
    public static ACBindings.ImgTex* AllocateTempBuffer(int width, int height, ACBindings.PixelFormatID image_type) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.PixelFormatID, ACBindings.ImgTex*>)0x00540B80)(width, height, image_type);
    // void __thiscall ImgTex::~ImgTex(ImgTex*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, void>)0x00540CE0)(ref this);
    // ImgTex* __cdecl ImgTex::GetTempBuffer(int,int,PixelFormatID)
    public static ACBindings.ImgTex* GetTempBuffer(int width, int height, ACBindings.PixelFormatID image_type) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.PixelFormatID, ACBindings.ImgTex*>)0x00540DC0)(width, height, image_type);
    // bool __thiscall ImgTex::Combine(ImgTex*,ImgTex*,const Palette*,bool)
    public byte Combine(ACBindings.ImgTex* texture, ACBindings.Palette* palette, byte clipmap) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, ACBindings.ImgTex*, ACBindings.Palette*, byte, byte>)0x00540EE0)(ref this, texture, palette, clipmap);
    // bool __thiscall ImgTex::LoadCSI(ImgTex*,unsigned __int8*,unsigned int,unsigned int)
    public byte LoadCSI(byte* csi_data, uint csi_width, uint csi_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ImgTex, byte*, uint, uint, byte>)0x00540FF0)(ref this, csi_data, csi_width, csi_height);
    // ImgTex* __cdecl ImgTex::CreateCombinedTexture(ImgTex*,const Palette*,bool)
    public static ACBindings.ImgTex* CreateCombinedTexture(ACBindings.ImgTex* i_pIndexedImage, ACBindings.Palette* i_pPalette, byte fHasClipmap) => ((delegate* unmanaged[Cdecl]<ACBindings.ImgTex*, ACBindings.Palette*, byte, ACBindings.ImgTex*>)0x005410D0)(i_pIndexedImage, i_pPalette, fHasClipmap);
    // ImgTex* __cdecl ImgTex::CreateLScapeTexture(unsigned __int8*,unsigned int,unsigned int)
    public static ACBindings.ImgTex* CreateLScapeTexture(byte* i_pRawData, uint i_width, uint i_height) => ((delegate* unmanaged[Cdecl]<byte*, uint, uint, ACBindings.ImgTex*>)0x005411D0)(i_pRawData, i_width, i_height);
}

