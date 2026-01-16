namespace ACBindings.Internal;


/// <summary>Encapsulates the data required to render a surface within the graphics subsystem, including type, color, translucency, luminosity, diffuse reflection, and references to textures, palettes, and handlers.</summary>
public unsafe struct CSurface
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.GraphicsResource BaseClass_GraphicsResource; // ACBindings.Internal.GraphicsResource

    // Child Types
    public unsafe struct CSurface_vtbl
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

    /// <summary>Allocates a new CSurface, constructs it, and returns a pointer to its DBObj base.
    /// <code>Offset: 0x004F7BB0
    /// DBObj* __cdecl CSurface::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created surface object, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7BB0)();

    /// <summary>Retrieves the database object type identifier for this surface.
    /// <code>Offset: 0x00527D70
    /// unsigned int __thiscall CSurface::GetDBOType(CSurface*)</code>
    /// </summary>
    /// <returns>The identifier value (always 13).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, uint>)0x00527D70)(ref this);

    /// <summary>Assigns a new palette to the surface, replacing and releasing any existing palette.
    /// <code>Offset: 0x00536BE0
    /// void __thiscall CSurface::SetPalette(CSurface*,Palette*)</code>
    /// </summary>
    /// <param name="palette">The palette to associate with this surface; may be null.</param>
    public void SetPalette(ACBindings.Internal.Palette* palette) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.Palette*, void>)0x00536BE0)(ref this, palette);

    /// <summary>Releases a custom surface, decrementing its reference count via the underlying interface.
    /// <code>Offset: 0x00536C10
    /// void __cdecl CSurface::releaseCustomSurface(CSurface*)</code>
    /// </summary>
    /// <param name="surface">The surface to release.</param>
    public static void releaseCustomSurface(ACBindings.Internal.CSurface* surface) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, void>)0x00536C10)(surface);

    /// <summary>Releases the surface’s image and palette resources, resetting their references.
    /// <code>Offset: 0x00536C20
    /// int __thiscall CSurface::ClearSurface(CSurface*)</code>
    /// </summary>
    /// <returns>Returns 1 on successful clearance; returns 0 if the surface is managed by a maintainer and cannot be cleared.</returns>
    public int ClearSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int>)0x00536C20)(ref this);

    /// <summary>Applies the provided Palette to the surface when its handler is in a custom‑database state; otherwise leaves the surface unchanged.
    /// <code>Offset: 0x00536C60
    /// int __thiscall CSurface::UsePalette(CSurface*,Palette*)</code>
    /// </summary>
    /// <param name="pal">The palette to associate with this surface.</param>
    /// <returns>1 if the palette was successfully set, 0 otherwise.</returns>
    public int UsePalette(ACBindings.Internal.Palette* pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.Palette*, int>)0x00536C60)(ref this, pal);

    /// <summary>Restores the surface’s palette by copying it from the associated image texture.
    /// <code>Offset: 0x00536CA0
    /// int __thiscall CSurface::RestorePalette(CSurface*)</code>
    /// </summary>
    /// <returns>Non‑zero if the palette was successfully restored; zero if no image texture exists or restoration cannot be performed.</returns>
    public int RestorePalette() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int>)0x00536CA0)(ref this);

    /// <summary>Assigns a new combined texture and palette to the surface, replacing any existing base map and configuring rendering settings based on surface type.
    /// <code>Offset: 0x00536CF0
    /// int __thiscall CSurface::SetTextureAndPalette(CSurface*,ImgTex*,const Palette*)</code>
    /// </summary>
    /// <param name="texture">The source image texture to combine with the palette.</param>
    /// <param name="palette">Palette data used when creating the combined texture.</param>
    /// <returns>Non‑zero if the combined texture was created and assigned successfully; otherwise zero.</returns>
    public int SetTextureAndPalette(ACBindings.Internal.ImgTex* texture, ACBindings.Internal.Palette* palette) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.ImgTex*, ACBindings.Internal.Palette*, int>)0x00536CF0)(ref this, texture, palette);

    /// <summary>Purges the graphics resource of this surface when it has been loaded, resetting its internal state and releasing associated handles.
    /// <code>Offset: 0x00536D70
    /// bool __thiscall CSurface::PurgeResource(CSurface*)</code>
    /// </summary>
    /// <returns>True if the purge succeeded; otherwise false.</returns>
    public byte PurgeResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x00536D70)(ref this);

    /// <summary>Constructs a CSurface instance, initializing its DBObj and GraphicsResource bases, setting default surface attributes such as color, solid index, type, handler, and texture identifiers, and enabling automatic restoration of the graphics resource.
    /// <code>Offset: 0x00536DA0
    /// void __thiscall CSurface::CSurface(CSurface*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, void>)0x00536DA0)(ref this);

    /// <summary>Creates a new CSurface instance by copying the state of another surface, translating database handlers to custom ones and managing texture and palette references.
    /// <code>Offset: 0x00536E40
    /// void __thiscall CSurface::CSurface(CSurface*,const CSurface*)</code>
    /// </summary>
    /// <param name="cs">The source surface whose data will be copied into the new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.CSurface* cs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.CSurface*, void>)0x00536E40)(ref this, cs);

    /// <summary>Releases the surface’s texture and palette resources and resets all properties to their default states.
    /// <code>Offset: 0x00536F30
    /// void __thiscall CSurface::Destroy(CSurface*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, void>)0x00536F30)(ref this);

    /// <summary>Creates a new surface instance configured with the specified handler. If the handler identifier is invalid or memory allocation fails, no object is created and null is returned.
    /// <code>Offset: 0x00536FB0
    /// CSurface* __cdecl CSurface::makeCustomSurface(SurfaceHandlerEnum)</code>
    /// </summary>
    /// <param name="sh">The enumerated handler type used to configure the custom surface.</param>
    /// <returns>Pointer to the allocated and initialized CSurface, or nullptr on failure.</returns>
    public static ACBindings.Internal.CSurface* makeCustomSurface(ACBindings.Internal.SurfaceHandlerEnum sh) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SurfaceHandlerEnum, ACBindings.Internal.CSurface*>)0x00536FB0)(sh);

    /// <summary>Duplicates the supplied surface by allocating a new instance and copying its contents.
    /// <code>Offset: 0x00536FF0
    /// CSurface* __cdecl CSurface::makeCustomSurface(CSurface*)</code>
    /// </summary>
    /// <param name="copy_surface">Surface to duplicate; must not be null for a meaningful result.</param>
    /// <returns>A pointer to the newly created copy, or nullptr if allocation fails or input is null.</returns>
    public static ACBindings.Internal.CSurface* makeCustomSurface(ACBindings.Internal.CSurface* copy_surface) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, ACBindings.Internal.CSurface*>)0x00536FF0)(copy_surface);

    /// <summary>Attempts to assign a new texture map to the surface when it is not already using one and meets required state conditions, releasing any existing palette if present.
    /// <code>Offset: 0x00537020
    /// int __thiscall CSurface::UseTextureMap(int,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier or index of the texture map to apply.</param>
    /// <param name="a3">Optional flag that may override certain constraints during assignment.</param>
    /// <returns>Non‑zero if the texture map was successfully set; zero otherwise (e.g., surface already in use or state conditions not met).</returns>
    public int UseTextureMap(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int, int, int>)0x00537020)(ref this, a2, a3);

    /// <summary>Applies a new texture map to the surface, setting type 2, updating reference counts, and preserving the original texture ID if it has not yet been recorded.
    /// <code>Offset: 0x00537090
    /// int __thiscall CSurface::UseTextureMap(CSurface*,ImgTex*,SurfaceHandlerEnum)</code>
    /// </summary>
    /// <param name="texture">The ImgTex object to use as the surface’s base texture; operation fails when null.</param>
    /// <param name="sh">Expected handler identifier that must match the surface’s current handler for the operation to succeed.</param>
    /// <returns>Returns 1 if the texture map is successfully applied; otherwise returns 0 when a maintainer exists, handlers differ, or no texture is provided.</returns>
    public int UseTextureMap(ACBindings.Internal.ImgTex* texture, ACBindings.Internal.SurfaceHandlerEnum sh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.ImgTex*, ACBindings.Internal.SurfaceHandlerEnum, int>)0x00537090)(ref this, texture, sh);

    /// <summary>Retrieves the identifier of the surface’s original texture map and writes it into the supplied address.
    /// <code>Offset: 0x00537120
    /// _DWORD* __thiscall CSurface::GetOriginalTextureMapID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD that receives the original texture map ID.</param>
    /// <returns>The same pointer passed as <c>a2</c>, now pointing to the retrieved value.</returns>
    public int* GetOriginalTextureMapID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int*, int*>)0x00537120)(ref this, a2);

    /// <summary>Copies this surface’s original palette identifier into the supplied location and returns a pointer to that location.
    /// <code>Offset: 0x00537130
    /// _DWORD* __thiscall CSurface::GetOriginalPaletteID(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Location where the surface's original palette ID will be stored.</param>
    /// <returns>A pointer to the provided storage containing the original palette identifier.</returns>
    public int* GetOriginalPaletteID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, int*, int*>)0x00537130)(ref this, a2);

    /// <summary>Finalizes surface initialization by loading the appropriate image data and palette based on stored texture identifiers, releasing any previous resources, and setting flags for translucency and format handling.
    /// <code>Offset: 0x00537140
    /// void __thiscall CSurface::InitEnd(CSurface*,SurfaceInitType)</code>
    /// </summary>
    /// <param name="init_type">Specifies the context of the initialization (e.g., loading, restoring, or adding a new surface).</param>
    public void InitEnd(ACBindings.Internal.SurfaceInitType init_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.SurfaceInitType, void>)0x00537140)(ref this, init_type);

    /// <summary>Restores the surface's palette‑shifted texture by loading the indexed texture from the database, combining it with the base palette, and updating internal references.
    /// <code>Offset: 0x00537270
    /// bool __thiscall CSurface::RestorePalShiftSurface(CSurface*)</code>
    /// </summary>
    /// <returns>True if the combined texture was successfully created and assigned; otherwise false.</returns>
    public byte RestorePalShiftSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x00537270)(ref this);

    /// <summary>Saves or loads surface properties to or from an Archive, handling different storage modes based on the surface type. During load it restores original texture/palette identifiers or color value, sets visual attributes, and finalizes initialization.
    /// <code>Offset: 0x00537330
    /// void __thiscall CSurface::Serialize(CSurface*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing surface data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.Archive*, void>)0x00537330)(ref this, io_archive);

    /// <summary>Retrieves the original texture identifier associated with this surface and appends it to the supplied array of qualified data identifiers.
    /// <code>Offset: 0x00537490
    /// void __thiscall CSurface::GetSubDataIDs(CSurface*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to which the surface's original texture ID will be added.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00537490)(ref this, id_array);

    /// <summary>Restores the surface resource that has been lost, loading or reinitializing texture data based on its handler type.
    /// <code>Offset: 0x005374C0
    /// bool __thiscall CSurface::RestoreLostSurface(CSurface*)</code>
    /// </summary>
    /// <returns>True if the surface was successfully restored; otherwise, false.</returns>
    public byte RestoreLostSurface() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x005374C0)(ref this);

    /// <summary>Restores the graphics resource associated with the surface, attempting to recover any lost data and clearing the lost flag upon success.
    /// <code>Offset: 0x005375E0
    /// bool __thiscall CSurface::RestoreResource(CSurface*)</code>
    /// </summary>
    /// <returns>True if the resource and related surface data were successfully restored; otherwise false.</returns>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, byte>)0x005375E0)(ref this);

    /// <summary>Retrieves the texture map associated with this surface, restoring the resource if it was lost and updating usage timestamps.
    /// <code>Offset: 0x0059D4C0
    /// ImgTex* __thiscall CSurface::GetTextureMap(CSurface*)</code>
    /// </summary>
    /// <returns>A pointer to the ImgTex representing the surface's texture map; returns nullptr when no texture map is assigned.</returns>
    public ACBindings.Internal.ImgTex* GetTextureMap() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSurface, ACBindings.Internal.ImgTex*>)0x0059D4C0)(ref this);
}

