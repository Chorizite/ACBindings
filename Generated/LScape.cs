namespace ACBindings;

// LScape
public unsafe struct LScape : System.IDisposable
{
    // Statics
    public static byte* m_fFogEnabled = (byte*)0x0081DBF8;
    public static byte* weather_enabled = (byte*)0x0081DBF9;
    public static ACBindings.RGBAUnion* sunlight_color = (ACBindings.RGBAUnion*)0x00842778;
    public static ACBindings.RGBAUnion* ambient_color = (ACBindings.RGBAUnion*)0x0084277C;
    public static float* ambient_level = (float*)0x00842780;
    public static ACBindings.RGBAUnion* m_override_fog_color = (ACBindings.RGBAUnion*)0x00842784;
    public static ACBindings.RGBAUnion* m_override_ambient_color = (ACBindings.RGBAUnion*)0x00842788;
    public static double* next_tick = (double*)0x00842798;
    public static double* next_light_tick = (double*)0x008427A0;
    public static byte* m_fAlwaysDaylight = (byte*)0x008427A8;
    public static byte* m_override_enabled = (byte*)0x008427A9;
    public static float* m_override_ambient_level = (float*)0x008427AC;
    public static float* m_override_fog_min = (float*)0x008427B0;
    public static float* m_override_fog_max = (float*)0x008427B4;
    public static float* m_override_transition = (float*)0x008427B8;
    public static ACBindings.AC1Legacy.Vector3* sunlight = (ACBindings.AC1Legacy.Vector3*)0x00842950;
    public static float* min_ambient = (float*)0x0084295C;

    // Members
    public int mid_radius;
    public int mid_width;
    public ACBindings.CLandBlock** land_blocks;
    public ACBindings.CLandBlock** block_draw_list;
    public uint loaded_cell_id;
    public uint viewer_cell_id;
    public int viewer_b_xoff;
    public int viewer_b_yoff;
    public ACBindings.GameSky* sky;
    public ACBindings.CSurface* landscape_detail_surface;
    public ACBindings.CSurface* environment_detail_surface;
    public ACBindings.CSurface* building_detail_surface;
    public ACBindings.CSurface* object_detail_surface;

    // Generated Constructor
    public LScape() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // float __cdecl LScape::calc_object_light()
    public static float calc_object_light() => ((delegate* unmanaged[Cdecl]<float>)0x00455850)();
    // int __thiscall LScape::get_block_shift(LScape*,unsigned int,unsigned int,int*,int*)
    public int get_block_shift(uint cell_id1, uint cell_id2, int* x_shift, int* y_shift) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, uint, int*, int*, int>)0x005054C0)(ref this, cell_id1, cell_id2, x_shift, y_shift);
    // void __thiscall LScape::CleanupDetailSurfaces(LScape*)
    public void CleanupDetailSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x00505540)(ref this);
    // void __thiscall LScape::release_all(LScape*)
    public void release_all() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x005055C0)(ref this);
    // int __thiscall LScape::SetMidRadius(LScape*,int)
    public int SetMidRadius(int radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, int, int>)0x00505660)(ref this, radius);
    // void __thiscall LScape::set_sky_position(LScape*,const Position*)
    public void set_sky_position(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, ACBindings.Position*, void>)0x00505690)(ref this, p);
    // void __thiscall LScape::get_block_order(LScape*)
    public void get_block_order() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x005056B0)(ref this);
    // void __thiscall LScape::grab_visible_cells(LScape*)
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x00505920)(ref this);
    // void __thiscall LScape::release_visible_cells(LScape*)
    public void release_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x005059B0)(ref this);
    // void __thiscall LScape::get_block_orient(LScape*,int,int,int*,LandDefs::Direction*)
    public void get_block_orient(int ix, int iy, int* size, ACBindings.LandDefs.Direction* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, int, int, int*, ACBindings.LandDefs.Direction*, void>)0x005059F0)(ref this, ix, iy, size, dir);
    // void __thiscall LScape::landcell_check(LScape*,CLandBlock*)
    public void landcell_check(ACBindings.CLandBlock* block) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, ACBindings.CLandBlock*, void>)0x00505B00)(ref this, block);
    // void __cdecl LScape::SetDay(int)
    public static void SetDay(int on) => ((delegate* unmanaged[Cdecl]<int, void>)0x00505D40)(on);
    // void __thiscall LScape::LScape(LScape*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x00505DD0)(ref this);
    // void __thiscall LScape::~LScape(LScape*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x00505E70)(ref this);
    // void __thiscall LScape::set_landscape_lighting(LScape*,float,RGBAUnion,const AC1Legacy::Vector3*,RGBAUnion)
    public void set_landscape_lighting(float ambient_level, ACBindings.RGBAUnion ambient_color, ACBindings.AC1Legacy.Vector3* sunlight, ACBindings.RGBAUnion sunlight_color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, float, ACBindings.RGBAUnion, ACBindings.AC1Legacy.Vector3*, ACBindings.RGBAUnion, void>)0x00505F30)(ref this, ambient_level, ambient_color, sunlight, sunlight_color);
    // int __fastcall LScape::PreFetchCells(int,int,unsigned int,_DWORD*)
    public static int PreFetchCells(int a1, int a2, uint a3, int* a4) => ((delegate* unmanaged[Fastcall]<int, int, uint, int*, int>)0x005060C0)(a1, a2, a3, a4);
    // void __thiscall LScape::add_ambient_sounds(LScape*,Position*)
    public void add_ambient_sounds(ACBindings.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, ACBindings.Position*, void>)0x00506270)(ref this, a2);
    // void __thiscall LScape::UseTime(LScape*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x005062E0)(ref this);
    // void __thiscall LScape::calc_draw_order(LScape*,unsigned int,int)
    public void calc_draw_order(uint cell_id, int calc_block_order) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, int, void>)0x005066D0)(ref this, cell_id, calc_block_order);
    // DBObj* __stdcall LScape::get_all(unsigned int)
    public static ACBindings.DBObj* get_all(uint a1) => ((delegate* unmanaged[Stdcall]<uint, ACBindings.DBObj*>)0x00506830)(a1);
    // CLandBlock* __thiscall LScape::get_landblock(LScape*,unsigned int)
    public ACBindings.CLandBlock* get_landblock(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, ACBindings.CLandBlock*>)0x005068A0)(ref this, cell_id);
    // CLandCell* __thiscall LScape::get_landcell(LScape*,unsigned int)
    public ACBindings.CLandCell* get_landcell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, ACBindings.CLandCell*>)0x00506970)(ref this, cell_id);
    // void __thiscall LScape::draw_check_blocks(LScape*)
    public void draw_check_blocks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x005069E0)(ref this);
    // CSurface* __thiscall LScape::GenerateDetailSurface(LScape*,unsigned int)
    public ACBindings.CSurface* GenerateDetailSurface(uint terrain_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, ACBindings.CSurface*>)0x00506C90)(ref this, terrain_number);
    // void __thiscall LScape::update_viewpoint(LScape*,unsigned int)
    public void update_viewpoint(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, void>)0x00506D30)(ref this, cell_id);
    // void __thiscall LScape::draw(LScape*)
    public void draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x00506D90)(ref this);
    // void __thiscall LScape::update_block(LScape*,unsigned int,int,int,int)
    public void update_block(uint cell_id, int x_shift, int y_shift, int refresh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, int, int, int, void>)0x00506E00)(ref this, cell_id, x_shift, y_shift, refresh);
    // bool __thiscall LScape::SetDetailTexturing(LScape*,int,int,int,int)
    public byte SetDetailTexturing(int landscape, int building, int environment, int object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, int, int, int, int, byte>)0x005075A0)(ref this, landscape, building, environment, object_);
    // void __thiscall LScape::ChangeRegion(LScape*)
    public void ChangeRegion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, void>)0x00507710)(ref this);
    // void __thiscall LScape::update_loadpoint(LScape*,unsigned int)
    public void update_loadpoint(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LScape, uint, void>)0x00507730)(ref this, cell_id);
}

