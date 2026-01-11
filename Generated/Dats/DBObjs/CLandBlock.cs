namespace ACBindings.Internal;

public unsafe struct CLandBlock
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.CLandBlockStruct BaseClass_CLandBlockStruct; // ACBindings.Internal.CLandBlockStruct

    // Child Types
    public unsafe struct CLandBlock_vtbl
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
    public ACBindings.Internal.SqCoord block_coord;
    public ACBindings.Internal.Frame block_frame;
    public float max_zval;
    public float min_zval;
    public int dyn_objs_init_done;
    public int lbi_exists;
    public ACBindings.Internal.LandDefs.Direction dir;
    public ACBindings.Internal.SqCoord closest;
    public ACBindings.Internal.BoundingType in_view;
    public ACBindings.Internal.CLandBlockInfo* lbi;
    public uint num_static_objects;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr static_objects;
    public uint num_buildings;
    public ACBindings.Internal.CBuildingObj** buildings;
    public uint stab_num;
    public uint* stablist;
    public ACBindings.Internal.CLandCell** draw_array;
    public uint draw_array_size;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7A70
    /// DBObj* __cdecl CLandBlock::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7A70)();

    /// <summary>
    /// <code>Offset: 0x0052FE80
    /// void __thiscall CLandBlock::destroy_buildings(CLandBlock*)</code>
    /// </summary>
    public void destroy_buildings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x0052FE80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052FF10
    /// void __thiscall CLandBlock::get_land_limits(CLandBlock*)</code>
    /// </summary>
    public void get_land_limits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x0052FF10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530000
    /// unsigned int __thiscall CLandBlock::Pack(CLandBlock*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void**, uint, uint>)0x00530000)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00530050
    /// int __thiscall CLandBlock::UnPack(CLandBlock*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void**, uint, int>)0x00530050)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00530090
    /// void __thiscall CLandBlock::release_objs(CLandBlock*)</code>
    /// </summary>
    public void release_objs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530090)(ref this);

    /// <summary>
    /// <code>Offset: 0x005300F0
    /// void __thiscall CLandBlock::init_dyn_objs(CLandBlock*)</code>
    /// </summary>
    public void init_dyn_objs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005300F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530150
    /// void __thiscall CLandBlock::init_lcell_ptrs(CLandBlock*)</code>
    /// </summary>
    public void init_lcell_ptrs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530150)(ref this);

    /// <summary>
    /// <code>Offset: 0x005301A0
    /// void __thiscall CLandBlock::grab_visible_cells(CLandBlock*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005301A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005301C0
    /// void __thiscall CLandBlock::release_visible_cells(CLandBlock*)</code>
    /// </summary>
    public void release_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005301C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005301E0
    /// int __thiscall CLandBlock::calc_sq_draw_order(CLandBlock*,LandDefs::Direction,const SqCoord*)</code>
    /// </summary>
    public int calc_sq_draw_order(ACBindings.Internal.LandDefs.Direction new_dir, ACBindings.Internal.SqCoord* coord) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.LandDefs.Direction, ACBindings.Internal.SqCoord*, int>)0x005301E0)(ref this, new_dir, coord);

    /// <summary>
    /// <code>Offset: 0x00530650
    /// void __thiscall CLandBlock::add_static_object(CLandBlock*,CPhysicsObj*)</code>
    /// </summary>
    public void add_static_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.CPhysicsObj*, void>)0x00530650)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00530790
    /// void __thiscall CLandBlock::destroy_static_objects(CLandBlock*)</code>
    /// </summary>
    public void destroy_static_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530790)(ref this);

    /// <summary>
    /// <code>Offset: 0x005307E0
    /// void __thiscall CLandBlock::Destroy(CLandBlock*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005307E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530850
    /// void __cdecl CLandBlock::init()</code>
    /// </summary>
    public static void init() => ((delegate* unmanaged[Cdecl]<void>)0x00530850)();

    /// <summary>
    /// <code>Offset: 0x005308B0
    /// unsigned int __thiscall CLandBlock::get_terrain(CLandBlock*,unsigned int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public uint get_terrain(uint cell_id, ACBindings.Internal.AC1Legacy.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, uint, ACBindings.Internal.AC1Legacy.Vector3*, uint>)0x005308B0)(ref this, cell_id, vc);

    /// <summary>
    /// <code>Offset: 0x005309A0
    /// void __thiscall CLandBlock::GetSubDataIDs(CLandBlock*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005309A0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005309E0
    /// bool __thiscall CLandBlock::InitLoad(CLandBlock*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, byte>)0x005309E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530A30
    /// void __thiscall CLandBlock::release_all(CLandBlock*)</code>
    /// </summary>
    public void release_all() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530A30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530A60
    /// CLandCell* __thiscall CLandBlock::get_landcell(CLandBlock*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CLandCell* get_landcell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, uint, ACBindings.Internal.CLandCell*>)0x00530A60)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x00530AC0
    /// void __thiscall CLandBlock::init_buildings(CLandBlock*)</code>
    /// </summary>
    public void init_buildings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530C30
    /// void __thiscall CLandBlock::adjust_scene_obj_height(CLandBlock*)</code>
    /// </summary>
    public void adjust_scene_obj_height() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530C30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00530D30
    /// int __thiscall CLandBlock::on_road(CLandBlock*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int on_road(ACBindings.Internal.AC1Legacy.Vector3* obj_vector) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00530D30)(ref this, obj_vector);

    /// <summary>
    /// <code>Offset: 0x00530F80
    /// int __thiscall CLandBlock::PreFetchCells(CLandBlock*)</code>
    /// </summary>
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, int>)0x00530F80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00531000
    /// void __thiscall CLandBlock::notify_change_size(CLandBlock*)</code>
    /// </summary>
    public void notify_change_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00531000)(ref this);

    /// <summary>
    /// <code>Offset: 0x00531050
    /// unsigned int __thiscall CLandBlock::add_ambient_sounds(CLandBlock*,Position*)</code>
    /// </summary>
    public uint add_ambient_sounds(ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.Position*, uint>)0x00531050)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005311A0
    /// void __thiscall CLandBlock::get_land_scenes(CLandBlock*)</code>
    /// </summary>
    public void get_land_scenes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005311A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00531780
    /// void __thiscall CLandBlock::init_static_objs(CLandBlock*,int)</code>
    /// </summary>
    public void init_static_objs(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, int, void>)0x00531780)(ref this, a2);
}

