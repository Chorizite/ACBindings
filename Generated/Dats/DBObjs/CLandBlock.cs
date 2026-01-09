namespace ACBindings;

// CLandBlock
public unsafe struct CLandBlock
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj
    public ACBindings.CLandBlockStruct BaseClass_CLandBlockStruct; // ACBindings.CLandBlockStruct

    // Child Types
    // CLandBlock_vtbl
    public unsafe struct CLandBlock_vtbl
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
    public ACBindings.SqCoord block_coord;
    public ACBindings.Frame block_frame;
    public float max_zval;
    public float min_zval;
    public int dyn_objs_init_done;
    public int lbi_exists;
    public ACBindings.LandDefs.Direction dir;
    public ACBindings.SqCoord closest;
    public ACBindings.BoundingType in_view;
    public ACBindings.CLandBlockInfo* lbi;
    public uint num_static_objects;
    public ACBindings.DArray__CPhysicsObj_ptr static_objects;
    public uint num_buildings;
    public ACBindings.CBuildingObj** buildings;
    public uint stab_num;
    public uint* stablist;
    public ACBindings.CLandCell** draw_array;
    public uint draw_array_size;

    // Methods
    // DBObj* __cdecl CLandBlock::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7A70)();
    // void __thiscall CLandBlock::destroy_buildings(CLandBlock*)
    public void destroy_buildings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x0052FE80)(ref this);
    // void __thiscall CLandBlock::get_land_limits(CLandBlock*)
    public void get_land_limits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x0052FF10)(ref this);
    // unsigned int __thiscall CLandBlock::Pack(CLandBlock*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void**, uint, uint>)0x00530000)(ref this, addr, size);
    // int __thiscall CLandBlock::UnPack(CLandBlock*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void**, uint, int>)0x00530050)(ref this, addr, size);
    // void __thiscall CLandBlock::release_objs(CLandBlock*)
    public void release_objs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00530090)(ref this);
    // void __thiscall CLandBlock::init_dyn_objs(CLandBlock*)
    public void init_dyn_objs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x005300F0)(ref this);
    // void __thiscall CLandBlock::init_lcell_ptrs(CLandBlock*)
    public void init_lcell_ptrs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00530150)(ref this);
    // void __thiscall CLandBlock::grab_visible_cells(CLandBlock*)
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x005301A0)(ref this);
    // void __thiscall CLandBlock::release_visible_cells(CLandBlock*)
    public void release_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x005301C0)(ref this);
    // int __thiscall CLandBlock::calc_sq_draw_order(CLandBlock*,LandDefs::Direction,const SqCoord*)
    public int calc_sq_draw_order(ACBindings.LandDefs.Direction new_dir, ACBindings.SqCoord* coord) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, ACBindings.LandDefs.Direction, ACBindings.SqCoord*, int>)0x005301E0)(ref this, new_dir, coord);
    // void __thiscall CLandBlock::add_static_object(CLandBlock*,CPhysicsObj*)
    public void add_static_object(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, ACBindings.CPhysicsObj*, void>)0x00530650)(ref this, object_);
    // void __thiscall CLandBlock::destroy_static_objects(CLandBlock*)
    public void destroy_static_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00530790)(ref this);
    // void __thiscall CLandBlock::Destroy(CLandBlock*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x005307E0)(ref this);
    // void __cdecl CLandBlock::init()
    public static void init() => ((delegate* unmanaged[Cdecl]<void>)0x00530850)();
    // unsigned int __thiscall CLandBlock::get_terrain(CLandBlock*,unsigned int,const AC1Legacy::Vector3*)
    public uint get_terrain(uint cell_id, ACBindings.AC1Legacy.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, uint, ACBindings.AC1Legacy.Vector3*, uint>)0x005308B0)(ref this, cell_id, vc);
    // void __thiscall CLandBlock::GetSubDataIDs(CLandBlock*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, ACBindings.QualifiedDataIDArray*, void>)0x005309A0)(ref this, id_array);
    // bool __thiscall CLandBlock::InitLoad(CLandBlock*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, byte>)0x005309E0)(ref this);
    // void __thiscall CLandBlock::release_all(CLandBlock*)
    public void release_all() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00530A30)(ref this);
    // CLandCell* __thiscall CLandBlock::get_landcell(CLandBlock*,unsigned int)
    public ACBindings.CLandCell* get_landcell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, uint, ACBindings.CLandCell*>)0x00530A60)(ref this, cell_id);
    // void __thiscall CLandBlock::init_buildings(CLandBlock*)
    public void init_buildings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00530AC0)(ref this);
    // void __thiscall CLandBlock::adjust_scene_obj_height(CLandBlock*)
    public void adjust_scene_obj_height() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00530C30)(ref this);
    // int __thiscall CLandBlock::on_road(CLandBlock*,const AC1Legacy::Vector3*)
    public int on_road(ACBindings.AC1Legacy.Vector3* obj_vector) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, ACBindings.AC1Legacy.Vector3*, int>)0x00530D30)(ref this, obj_vector);
    // int __thiscall CLandBlock::PreFetchCells(CLandBlock*)
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, int>)0x00530F80)(ref this);
    // void __thiscall CLandBlock::notify_change_size(CLandBlock*)
    public void notify_change_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x00531000)(ref this);
    // unsigned int __thiscall CLandBlock::add_ambient_sounds(CLandBlock*,Position*)
    public uint add_ambient_sounds(ACBindings.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, ACBindings.Position*, uint>)0x00531050)(ref this, a2);
    // void __thiscall CLandBlock::get_land_scenes(CLandBlock*)
    public void get_land_scenes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, void>)0x005311A0)(ref this);
    // void __thiscall CLandBlock::init_static_objs(CLandBlock*,int)
    public void init_static_objs(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlock, int, void>)0x00531780)(ref this, a2);
}

