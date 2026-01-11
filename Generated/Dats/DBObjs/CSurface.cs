namespace ACBindings.Internal;

public unsafe struct CSurface
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct CSurface_vtbl
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
    public uint type;
    public ACBindings.Internal.SurfaceHandlerEnum handler;
    public uint color_value;
    public int solid_index;
    public ACBindings.Internal.IDClass____tagDataID indexed_texture_id;
    public ACBindings.Internal.ImgTex* base1map;
    public ACBindings.Internal.Palette* base1pal;
    public float translucency;
    public float luminosity;
    public float diffuse;
    public ACBindings.Internal.IDClass____tagDataID orig_texture_id;
    public ACBindings.Internal.IDClass____tagDataID orig_palette_id;
    public float orig_luminosity;
    public float orig_diffuse;

    // Generated Constructor
    public CSurface() {
        _ConstructorInternal();
    }
    public CSurface(ACBindings.Internal.CSurface* cs) {
        _ConstructorInternal(cs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7BB0
    /// DBObj* __cdecl CSurface::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7BB0)();

    /// <summary>
    /// <code>Offset: 0x00527D70
    /// unsigned int __thiscall CSurface::GetDBOType(CSurface*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, uint>)0x00527D70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536BE0
    /// void __thiscall CSurface::SetPalette(CSurface*,Palette*)</code>
    /// </summary>
    public void SetPalette(ACBindings.Internal.Palette* palette) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.Palette*, void>)0x00536BE0)(ref this, palette);

    /// <summary>
    /// <code>Offset: 0x00536C10
    /// void __cdecl CSurface::releaseCustomSurface(CSurface*)</code>
    /// </summary>
    public static void releaseCustomSurface(ACBindings.Internal.CSurface* surface) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x00536C10)(surface);

    /// <summary>
    /// <code>Offset: 0x00536C20
    /// int __thiscall CSurface::ClearSurface(CSurface*)</code>
    /// </summary>
    public int ClearSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int>)0x00536C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536C60
    /// int __thiscall CSurface::UsePalette(CSurface*,Palette*)</code>
    /// </summary>
    public int UsePalette(ACBindings.Internal.Palette* pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.Palette*, int>)0x00536C60)(ref this, pal);

    /// <summary>
    /// <code>Offset: 0x00536CA0
    /// int __thiscall CSurface::RestorePalette(CSurface*)</code>
    /// </summary>
    public int RestorePalette() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int>)0x00536CA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536CF0
    /// int __thiscall CSurface::SetTextureAndPalette(CSurface*,ImgTex*,const Palette*)</code>
    /// </summary>
    public int SetTextureAndPalette(ACBindings.Internal.ImgTex* texture, ACBindings.Internal.Palette* palette) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, int>)0x00536CF0)(ref this, texture, palette);

    /// <summary>
    /// <code>Offset: 0x00536D70
    /// bool __thiscall CSurface::PurgeResource(CSurface*)</code>
    /// </summary>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x00536D70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536DA0
    /// void __thiscall CSurface::CSurface(CSurface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, void>)0x00536DA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536E40
    /// void __thiscall CSurface::CSurface(CSurface*,const CSurface*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CSurface* cs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.CSurface*, void>)0x00536E40)(ref this, cs);

    /// <summary>
    /// <code>Offset: 0x00536F30
    /// void __thiscall CSurface::Destroy(CSurface*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, void>)0x00536F30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00536FB0
    /// CSurface* __cdecl CSurface::makeCustomSurface(SurfaceHandlerEnum)</code>
    /// </summary>
    public static ACBindings.Internal.CSurface* makeCustomSurface(ACBindings.Internal.SurfaceHandlerEnum sh) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SurfaceHandlerEnum, ACBindings.Internal.CSurface*>)0x00536FB0)(sh);

    /// <summary>
    /// <code>Offset: 0x00536FF0
    /// CSurface* __cdecl CSurface::makeCustomSurface(CSurface*)</code>
    /// </summary>
    public static ACBindings.Internal.CSurface* makeCustomSurface(ACBindings.Internal.CSurface* copy_surface) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, ACBindings.Internal.CSurface*>)0x00536FF0)(copy_surface);

    /// <summary>
    /// <code>Offset: 0x00537020
    /// int __thiscall CSurface::UseTextureMap(int,int,int)</code>
    /// </summary>
    public int UseTextureMap(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int, int, int>)0x00537020)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00537090
    /// int __thiscall CSurface::UseTextureMap(CSurface*,ImgTex*,SurfaceHandlerEnum)</code>
    /// </summary>
    public int UseTextureMap(ACBindings.Internal.ImgTex* texture, ACBindings.Internal.SurfaceHandlerEnum sh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.ImgTex*, ACBindings.Internal.SurfaceHandlerEnum, int>)0x00537090)(ref this, texture, sh);

    /// <summary>
    /// <code>Offset: 0x00537120
    /// _DWORD* __thiscall CSurface::GetOriginalTextureMapID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetOriginalTextureMapID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int*, int*>)0x00537120)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00537130
    /// _DWORD* __thiscall CSurface::GetOriginalPaletteID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetOriginalPaletteID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int*, int*>)0x00537130)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00537140
    /// void __thiscall CSurface::InitEnd(CSurface*,SurfaceInitType)</code>
    /// </summary>
    public void InitEnd(ACBindings.Internal.SurfaceInitType init_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.SurfaceInitType, void>)0x00537140)(ref this, init_type);

    /// <summary>
    /// <code>Offset: 0x00537270
    /// bool __thiscall CSurface::RestorePalShiftSurface(CSurface*)</code>
    /// </summary>
    public byte RestorePalShiftSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x00537270)(ref this);

    /// <summary>
    /// <code>Offset: 0x00537330
    /// void __thiscall CSurface::Serialize(CSurface*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.Archive*, void>)0x00537330)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00537490
    /// void __thiscall CSurface::GetSubDataIDs(CSurface*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00537490)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005374C0
    /// bool __thiscall CSurface::RestoreLostSurface(CSurface*)</code>
    /// </summary>
    public byte RestoreLostSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x005374C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005375E0
    /// bool __thiscall CSurface::RestoreResource(CSurface*)</code>
    /// </summary>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x005375E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059D4C0
    /// ImgTex* __thiscall CSurface::GetTextureMap(CSurface*)</code>
    /// </summary>
    public ACBindings.Internal.ImgTex* GetTextureMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.ImgTex*>)0x0059D4C0)(ref this);
}

