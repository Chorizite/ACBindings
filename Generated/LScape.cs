namespace ACBindings.Internal;

public unsafe struct LScape : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.RGBAUnion* sunlight_color = (ACBindings.Internal.RGBAUnion*)0x00842778;
    public static ACBindings.Internal.RGBAUnion* ambient_color = (ACBindings.Internal.RGBAUnion*)0x0084277C;
    public static float* ambient_level = (float*)0x00842780;
    public static ACBindings.Internal.RGBAUnion* m_override_fog_color = (ACBindings.Internal.RGBAUnion*)0x00842784;
    public static ACBindings.Internal.RGBAUnion* m_override_ambient_color = (ACBindings.Internal.RGBAUnion*)0x00842788;
    public static double* next_tick = (double*)0x00842798;
    public static double* next_light_tick = (double*)0x008427A0;
    public static float* m_override_ambient_level = (float*)0x008427AC;
    public static float* m_override_fog_min = (float*)0x008427B0;
    public static float* m_override_fog_max = (float*)0x008427B4;
    public static float* m_override_transition = (float*)0x008427B8;
    public static ACBindings.Internal.AC1Legacy.Vector3* sunlight = (ACBindings.Internal.AC1Legacy.Vector3*)0x00842950;

    // Members
    public int mid_radius;
    public int mid_width;
    public ACBindings.Internal.CLandBlock** land_blocks;
    public ACBindings.Internal.CLandBlock** block_draw_list;
    public uint loaded_cell_id;
    public uint viewer_cell_id;
    public int viewer_b_xoff;
    public int viewer_b_yoff;
    public ACBindings.Internal.GameSky* sky;
    public ACBindings.Internal.CSurface* landscape_detail_surface;
    public ACBindings.Internal.CSurface* environment_detail_surface;
    public ACBindings.Internal.CSurface* building_detail_surface;
    public ACBindings.Internal.CSurface* object_detail_surface;

    // Generated Constructor
    public LScape() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00455850
    /// float __cdecl LScape::calc_object_light()</code>
    /// </summary>
    public static float calc_object_light() => ((delegate* unmanaged[Cdecl]<float>)0x00455850)();

    /// <summary>
    /// <code>Offset: 0x005054C0
    /// int __thiscall LScape::get_block_shift(LScape*,unsigned int,unsigned int,int*,int*)</code>
    /// </summary>
    public int get_block_shift(uint cell_id1, uint cell_id2, int* x_shift, int* y_shift) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, uint, int*, int*, int>)0x005054C0)(ref this, cell_id1, cell_id2, x_shift, y_shift);

    /// <summary>
    /// <code>Offset: 0x00505540
    /// void __thiscall LScape::CleanupDetailSurfaces(LScape*)</code>
    /// </summary>
    public void CleanupDetailSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505540)(ref this);

    /// <summary>
    /// <code>Offset: 0x005055C0
    /// void __thiscall LScape::release_all(LScape*)</code>
    /// </summary>
    public void release_all() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005055C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00505660
    /// int __thiscall LScape::SetMidRadius(LScape*,int)</code>
    /// </summary>
    public int SetMidRadius(int radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, int, int>)0x00505660)(ref this, radius);

    /// <summary>
    /// <code>Offset: 0x00505690
    /// void __thiscall LScape::set_sky_position(LScape*,const Position*)</code>
    /// </summary>
    public void set_sky_position(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, ACBindings.Internal.Position*, void>)0x00505690)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x005056B0
    /// void __thiscall LScape::get_block_order(LScape*)</code>
    /// </summary>
    public void get_block_order() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005056B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00505920
    /// void __thiscall LScape::grab_visible_cells(LScape*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505920)(ref this);

    /// <summary>
    /// <code>Offset: 0x005059B0
    /// void __thiscall LScape::release_visible_cells(LScape*)</code>
    /// </summary>
    public void release_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005059B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005059F0
    /// void __thiscall LScape::get_block_orient(LScape*,int,int,int*,LandDefs::Direction*)</code>
    /// </summary>
    public void get_block_orient(int ix, int iy, int* size, ACBindings.Internal.LandDefs.Direction* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, int, int, int*, ACBindings.Internal.LandDefs.Direction*, void>)0x005059F0)(ref this, ix, iy, size, dir);

    /// <summary>
    /// <code>Offset: 0x00505B00
    /// void __thiscall LScape::landcell_check(LScape*,CLandBlock*)</code>
    /// </summary>
    public void landcell_check(ACBindings.Internal.CLandBlock* block) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, ACBindings.Internal.CLandBlock*, void>)0x00505B00)(ref this, block);

    /// <summary>
    /// <code>Offset: 0x00505D40
    /// void __cdecl LScape::SetDay(int)</code>
    /// </summary>
    public static void SetDay(int on) => ((delegate* unmanaged[Cdecl]<int, void>)0x00505D40)(on);

    /// <summary>
    /// <code>Offset: 0x00505DD0
    /// void __thiscall LScape::LScape(LScape*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505DD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00505E70
    /// void __thiscall LScape::~LScape(LScape*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505E70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00505F30
    /// void __thiscall LScape::set_landscape_lighting(LScape*,float,RGBAUnion,const AC1Legacy::Vector3*,RGBAUnion)</code>
    /// </summary>
    public void set_landscape_lighting(float ambient_level, ACBindings.Internal.RGBAUnion ambient_color, ACBindings.Internal.AC1Legacy.Vector3* sunlight, ACBindings.Internal.RGBAUnion sunlight_color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, float, ACBindings.Internal.RGBAUnion, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.RGBAUnion, void>)0x00505F30)(ref this, ambient_level, ambient_color, sunlight, sunlight_color);

    /// <summary>
    /// <code>Offset: 0x005060C0
    /// int __fastcall LScape::PreFetchCells(int,int,unsigned int,_DWORD*)</code>
    /// </summary>
    public static int PreFetchCells(int a1, int a2, uint a3, int* a4) => ((delegate* unmanaged[Fastcall]<int, int, uint, int*, int>)0x005060C0)(a1, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00506270
    /// void __thiscall LScape::add_ambient_sounds(LScape*,Position*)</code>
    /// </summary>
    public void add_ambient_sounds(ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, ACBindings.Internal.Position*, void>)0x00506270)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005062E0
    /// void __thiscall LScape::UseTime(LScape*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005062E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005066D0
    /// void __thiscall LScape::calc_draw_order(LScape*,unsigned int,int)</code>
    /// </summary>
    public void calc_draw_order(uint cell_id, int calc_block_order) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, int, void>)0x005066D0)(ref this, cell_id, calc_block_order);

    /// <summary>
    /// <code>Offset: 0x00506830
    /// DBObj* __stdcall LScape::get_all(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* get_all(uint a1) => ((delegate* unmanaged[Stdcall]<uint, ACBindings.Internal.DBObj*>)0x00506830)(a1);

    /// <summary>
    /// <code>Offset: 0x005068A0
    /// CLandBlock* __thiscall LScape::get_landblock(LScape*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CLandBlock* get_landblock(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, ACBindings.Internal.CLandBlock*>)0x005068A0)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x00506970
    /// CLandCell* __thiscall LScape::get_landcell(LScape*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CLandCell* get_landcell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, ACBindings.Internal.CLandCell*>)0x00506970)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x005069E0
    /// void __thiscall LScape::draw_check_blocks(LScape*)</code>
    /// </summary>
    public void draw_check_blocks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005069E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00506C90
    /// CSurface* __thiscall LScape::GenerateDetailSurface(LScape*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CSurface* GenerateDetailSurface(uint terrain_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, ACBindings.Internal.CSurface*>)0x00506C90)(ref this, terrain_number);

    /// <summary>
    /// <code>Offset: 0x00506D30
    /// void __thiscall LScape::update_viewpoint(LScape*,unsigned int)</code>
    /// </summary>
    public void update_viewpoint(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, void>)0x00506D30)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x00506D90
    /// void __thiscall LScape::draw(LScape*)</code>
    /// </summary>
    public void draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00506D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00506E00
    /// void __thiscall LScape::update_block(LScape*,unsigned int,int,int,int)</code>
    /// </summary>
    public void update_block(uint cell_id, int x_shift, int y_shift, int refresh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, int, int, int, void>)0x00506E00)(ref this, cell_id, x_shift, y_shift, refresh);

    /// <summary>
    /// <code>Offset: 0x005075A0
    /// bool __thiscall LScape::SetDetailTexturing(LScape*,int,int,int,int)</code>
    /// </summary>
    public byte SetDetailTexturing(int landscape, int building, int environment, int object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, int, int, int, int, byte>)0x005075A0)(ref this, landscape, building, environment, object_);

    /// <summary>
    /// <code>Offset: 0x00507710
    /// void __thiscall LScape::ChangeRegion(LScape*)</code>
    /// </summary>
    public void ChangeRegion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00507710)(ref this);

    /// <summary>
    /// <code>Offset: 0x00507730
    /// void __thiscall LScape::update_loadpoint(LScape*,unsigned int)</code>
    /// </summary>
    public void update_loadpoint(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, void>)0x00507730)(ref this, cell_id);
}

