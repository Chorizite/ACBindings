namespace ACBindings;

// CSurface
public unsafe struct CSurface
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj
    public ACBindings.GraphicsResource BaseClass_GraphicsResource; // ACBindings.GraphicsResource

    // Child Types
    // CSurface_vtbl
    public unsafe struct CSurface_vtbl
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
    public uint type;
    public ACBindings.SurfaceHandlerEnum handler;
    public uint color_value;
    public int solid_index;
    public ACBindings.IDClass___tagDataID indexed_texture_id;
    public ACBindings.ImgTex* base1map;
    public ACBindings.Palette* base1pal;
    public float translucency;
    public float luminosity;
    public float diffuse;
    public ACBindings.IDClass___tagDataID orig_texture_id;
    public ACBindings.IDClass___tagDataID orig_palette_id;
    public float orig_luminosity;
    public float orig_diffuse;

    // Generated Constructor
    public CSurface() {
        _ConstructorInternal();
    }
    public CSurface(ACBindings.CSurface* cs) {
        _ConstructorInternal(cs);
    }

    // Methods
    // DBObj* __cdecl CSurface::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7BB0)();
    // unsigned int __thiscall CSurface::GetDBOType(CSurface*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, uint>)0x00527D70)(ref this);
    // void __thiscall CSurface::SetPalette(CSurface*,Palette*)
    public void SetPalette(ACBindings.Palette* palette) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.Palette*, void>)0x00536BE0)(ref this, palette);
    // void __cdecl CSurface::releaseCustomSurface(CSurface*)
    public static void releaseCustomSurface(ACBindings.CSurface* surface) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, void>)0x00536C10)(surface);
    // int __thiscall CSurface::ClearSurface(CSurface*)
    public int ClearSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, int>)0x00536C20)(ref this);
    // int __thiscall CSurface::UsePalette(CSurface*,Palette*)
    public int UsePalette(ACBindings.Palette* pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.Palette*, int>)0x00536C60)(ref this, pal);
    // int __thiscall CSurface::RestorePalette(CSurface*)
    public int RestorePalette() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, int>)0x00536CA0)(ref this);
    // int __thiscall CSurface::SetTextureAndPalette(CSurface*,ImgTex*,const Palette*)
    public int SetTextureAndPalette(ACBindings.ImgTex* texture, ACBindings.Palette* palette) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.ImgTex*, ACBindings.Palette*, int>)0x00536CF0)(ref this, texture, palette);
    // bool __thiscall CSurface::PurgeResource(CSurface*)
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, byte>)0x00536D70)(ref this);
    // void __thiscall CSurface::CSurface(CSurface*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, void>)0x00536DA0)(ref this);
    // void __thiscall CSurface::CSurface(CSurface*,const CSurface*)
    public void _ConstructorInternal(ACBindings.CSurface* cs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.CSurface*, void>)0x00536E40)(ref this, cs);
    // void __thiscall CSurface::Destroy(CSurface*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, void>)0x00536F30)(ref this);
    // CSurface* __cdecl CSurface::makeCustomSurface(SurfaceHandlerEnum)
    public static ACBindings.CSurface* makeCustomSurface(ACBindings.SurfaceHandlerEnum sh) => ((delegate* unmanaged[Cdecl]<ACBindings.SurfaceHandlerEnum, ACBindings.CSurface*>)0x00536FB0)(sh);
    // CSurface* __cdecl CSurface::makeCustomSurface(CSurface*)
    public static ACBindings.CSurface* makeCustomSurface(ACBindings.CSurface* copy_surface) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, ACBindings.CSurface*>)0x00536FF0)(copy_surface);
    // int __thiscall CSurface::UseTextureMap(int,int,int)
    public int UseTextureMap(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, int, int, int>)0x00537020)(ref this, a2, a3);
    // int __thiscall CSurface::UseTextureMap(CSurface*,ImgTex*,SurfaceHandlerEnum)
    public int UseTextureMap(ACBindings.ImgTex* texture, ACBindings.SurfaceHandlerEnum sh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.ImgTex*, ACBindings.SurfaceHandlerEnum, int>)0x00537090)(ref this, texture, sh);
    // _DWORD* __thiscall CSurface::GetOriginalTextureMapID(_DWORD*,_DWORD*)
    public int* GetOriginalTextureMapID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, int*, int*>)0x00537120)(ref this, a2);
    // _DWORD* __thiscall CSurface::GetOriginalPaletteID(_DWORD*,_DWORD*)
    public int* GetOriginalPaletteID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, int*, int*>)0x00537130)(ref this, a2);
    // void __thiscall CSurface::InitEnd(CSurface*,SurfaceInitType)
    public void InitEnd(ACBindings.SurfaceInitType init_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.SurfaceInitType, void>)0x00537140)(ref this, init_type);
    // bool __thiscall CSurface::RestorePalShiftSurface(CSurface*)
    public byte RestorePalShiftSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, byte>)0x00537270)(ref this);
    // void __thiscall CSurface::Serialize(CSurface*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.Archive*, void>)0x00537330)(ref this, io_archive);
    // void __thiscall CSurface::GetSubDataIDs(CSurface*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.QualifiedDataIDArray*, void>)0x00537490)(ref this, id_array);
    // bool __thiscall CSurface::RestoreLostSurface(CSurface*)
    public byte RestoreLostSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, byte>)0x005374C0)(ref this);
    // bool __thiscall CSurface::RestoreResource(CSurface*)
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, byte>)0x005375E0)(ref this);
    // ImgTex* __thiscall CSurface::GetTextureMap(CSurface*)
    public ACBindings.ImgTex* GetTextureMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSurface, ACBindings.ImgTex*>)0x0059D4C0)(ref this);
}

