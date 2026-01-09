namespace ACBindings;

// CPartArray
public unsafe struct CPartArray : System.IDisposable
{
    // Members
    public uint pa_state;
    public ACBindings.CPhysicsObj* owner;
    public ACBindings.CSequence sequence;
    public ACBindings.MotionTableManager* motion_table_manager;
    public System.IntPtr setup;
    public uint num_parts;
    public ACBindings.CPhysicsPart** parts;
    public ACBindings.AC1Legacy.Vector3 scale;
    public ACBindings.Palette** pals;
    public ACBindings.LIGHTLIST* lights;
    public ACBindings.AnimFrame* last_animframe;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CPartArray::AnimationDone(CPartArray*,int)
    public void AnimationDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int, void>)0x00518860)(ref this, success);
    // void __thiscall CPartArray::HandleMovement(CPartArray*)
    public void HandleMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x00518890)(ref this);
    // void __thiscall CPartArray::HandleEnterWorld(CPartArray*)
    public void HandleEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x005188A0)(ref this);
    // void __thiscall CPartArray::HandleExitWorld(CPartArray*)
    public void HandleExitWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x005188C0)(ref this);
    // void __thiscall CPartArray::Update(CPartArray*,float,Frame*)
    public void Update(float quantum, ACBindings.Frame* offset_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float, ACBindings.Frame*, void>)0x005188E0)(ref this, quantum, offset_frame);
    // void __thiscall CPartArray::SetCellID(CPartArray*,const unsigned int)
    public void SetCellID(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, void>)0x00518900)(ref this, cell_id);
    // void __thiscall CPartArray::RemoveParts(CPartArray*,CObjCell*)
    public void RemoveParts(ACBindings.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CObjCell*, void>)0x00518930)(ref this, obj_cell);
    // void __thiscall CPartArray::AddPartsShadow(CPartArray*,CObjCell*,unsigned int)
    public void AddPartsShadow(ACBindings.CObjCell* obj_cell, uint num_shadow_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CObjCell*, uint, void>)0x00518970)(ref this, obj_cell, num_shadow_parts);
    // void __thiscall CPartArray::AddLightsToCell(CPartArray*,CObjCell*)
    public void AddLightsToCell(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CObjCell*, void>)0x005189D0)(ref this, cell);
    // void __thiscall CPartArray::RemoveLightsFromCell(CPartArray*,CObjCell*)
    public void RemoveLightsFromCell(ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CObjCell*, void>)0x00518A20)(ref this, cell);
    // int __thiscall CPartArray::InitParts(CPartArray*)
    public int InitParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int>)0x00518A70)(ref this);
    // unsigned int __thiscall CPartArray::GetNumSphere(CPartArray*)
    public uint GetNumSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint>)0x00518B90)(ref this);
    // const CSphere* __thiscall CPartArray::GetSphere(CPartArray*)
    public ACBindings.CSphere* GetSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CSphere*>)0x00518BA0)(ref this);
    // unsigned int __thiscall CPartArray::GetNumCylsphere(CPartArray*)
    public uint GetNumCylsphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint>)0x00518BB0)(ref this);
    // const CCylSphere* __thiscall CPartArray::GetCylsphere(CPartArray*)
    public ACBindings.CCylSphere* GetCylsphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CCylSphere*>)0x00518BC0)(ref this);
    // float __thiscall CPartArray::GetRadius(CPartArray*)
    public float GetRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float>)0x00518BD0)(ref this);
    // float __thiscall CPartArray::GetHeight(CPartArray*)
    public float GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float>)0x00518BE0)(ref this);
    // int __thiscall CPartArray::AllowsFreeHeading(CPartArray*)
    public int AllowsFreeHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int>)0x00518BF0)(ref this);
    // int __thiscall CPartArray::CacheHasPhysicsBSP(CPartArray*)
    public int CacheHasPhysicsBSP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int>)0x00518C40)(ref this);
    // void __thiscall CPartArray::calc_cross_cells_static(CPartArray*,const CObjCell*,CELLARRAY*)
    public void calc_cross_cells_static(ACBindings.CObjCell* cell, ACBindings.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CObjCell*, ACBindings.CELLARRAY*, void>)0x00518C90)(ref this, cell, cell_array);
    // TransitionState __thiscall CPartArray::FindObjCollisions(CPartArray*,CTransition*)
    public ACBindings.TransitionState FindObjCollisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CTransition*, ACBindings.TransitionState>)0x00518CB0)(ref this, transition);
    // int __thiscall CPartArray::InitPals(CPartArray*)
    public int InitPals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int>)0x00518CF0)(ref this);
    // void __thiscall CPartArray::DestroyPals(CPartArray*)
    public void DestroyPals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x00518D40)(ref this);
    // void __thiscall CPartArray::UpdateViewerDistance(CPartArray*)
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x00518D90)(ref this);
    // void __thiscall CPartArray::UpdateViewerDistance(CPartArray*,float,const AC1Legacy::Vector3*)
    public void UpdateViewerDistance(float CYpt, ACBindings.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float, ACBindings.AC1Legacy.Vector3*, void>)0x00518DC0)(ref this, CYpt, viewer_heading);
    // void __thiscall CPartArray::Draw(CPartArray*,const Position*)
    public void Draw(ACBindings.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.Position*, void>)0x00518E00)(ref this, p);
    // void __thiscall CPartArray::SetNoDrawInternal(CPartArray*,int)
    public void SetNoDrawInternal(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int, void>)0x00518E30)(ref this, no_draw);
    // void __thiscall CPartArray::SetTranslucencyInternal(CPartArray*,float)
    public void SetTranslucencyInternal(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float, void>)0x00518E70)(ref this, translucency);
    // void __thiscall CPartArray::SetPartTranslucencyInternal(CPartArray*,unsigned int,float)
    public void SetPartTranslucencyInternal(uint part_index, float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, float, void>)0x00518EB0)(ref this, part_index, translucency);
    // void __thiscall CPartArray::SetLuminosityInternal(CPartArray*,float)
    public void SetLuminosityInternal(float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float, void>)0x00518EE0)(ref this, lumi);
    // void __thiscall CPartArray::SetPartLuminosityInternal(CPartArray*,unsigned int,float)
    public void SetPartLuminosityInternal(uint part_index, float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, float, void>)0x00518F20)(ref this, part_index, lumi);
    // void __thiscall CPartArray::SetDiffusionInternal(CPartArray*,float)
    public void SetDiffusionInternal(float diff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, float, void>)0x00518F50)(ref this, diff);
    // void __thiscall CPartArray::SetPartDiffusionInternal(CPartArray*,unsigned int,float)
    public void SetPartDiffusionInternal(uint part_index, float diff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, float, void>)0x00518F90)(ref this, part_index, diff);
    // int __thiscall CPartArray::InitObjDescChanges(CPartArray*)
    public int InitObjDescChanges() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int>)0x00519070)(ref this);
    // int __thiscall CPartArray::SetPart(CPartArray*,const AnimPartChange*)
    public int SetPart(ACBindings.AnimPartChange* changes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.AnimPartChange*, int>)0x005190B0)(ref this, changes);
    // int __thiscall CPartArray::SetTextureMap(CPartArray*,const TextureMapChange*)
    public int SetTextureMap(ACBindings.TextureMapChange* changes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.TextureMapChange*, int>)0x00519110)(ref this, changes);
    // int __thiscall CPartArray::SetMotionTableID(int,int)
    public int SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int, int>)0x00519210)(ref this, a2);
    // unsigned int __thiscall CPartArray::DoInterpretedMotion(CPartArray*,unsigned int,const MovementParameters*)
    public uint DoInterpretedMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, ACBindings.MovementParameters*, uint>)0x00519280)(ref this, motion, params_);
    // unsigned int __thiscall CPartArray::StopInterpretedMotion(CPartArray*,unsigned int,const MovementParameters*)
    public uint StopInterpretedMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, ACBindings.MovementParameters*, uint>)0x00519320)(ref this, motion, params_);
    // unsigned int __thiscall CPartArray::StopCompletelyInternal(CPartArray*)
    public uint StopCompletelyInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint>)0x005193C0)(ref this);
    // void __thiscall CPartArray::DestroyParts(CPartArray*)
    public void DestroyParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x00519450)(ref this);
    // void __thiscall CPartArray::InitDefaults(CPartArray*)
    public void InitDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x005194B0)(ref this);
    // int __thiscall CPartArray::SetScaleInternal(CPartArray*,const AC1Legacy::Vector3*)
    public int SetScaleInternal(ACBindings.AC1Legacy.Vector3* new_scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.AC1Legacy.Vector3*, int>)0x00519530)(ref this, new_scale);
    // _DWORD* __thiscall CPartArray::GetSetupID(_DWORD*,_DWORD*)
    public int* GetSetupID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int*, int*>)0x005195E0)(ref this, a2);
    // unsigned int* __thiscall CPartArray::GetDataID(int,unsigned int*)
    public uint* GetDataID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint*, uint*>)0x005195F0)(ref this, a2);
    // const CSphere* __thiscall CPartArray::GetSortingSphere(CPartArray*)
    public ACBindings.CSphere* GetSortingSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CSphere*>)0x00519630)(ref this);
    // int __thiscall CPartArray::GetSelectionSphere(CPartArray*,CSphere*)
    public int GetSelectionSphere(ACBindings.CSphere* selection_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CSphere*, int>)0x005196B0)(ref this, selection_sphere);
    // int __thiscall CPartArray::InitLights(CPartArray*)
    public int InitLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int>)0x00519730)(ref this);
    // int __thiscall CPartArray::MorphToExistingObject(CPartArray*,const CPartArray*)
    public int MorphToExistingObject(ACBindings.CPartArray* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.CPartArray*, int>)0x00519870)(ref this, pObj);
    // int __thiscall CPartArray::SetPalette(CPartArray*,int,Subpalette*)
    public int SetPalette(int a2, ACBindings.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int, ACBindings.Subpalette*, int>)0x00519940)(ref this, a2, subs);
    // void __thiscall CPartArray::GetBoundingBox(CPartArray*,BBox*)
    public void GetBoundingBox(ACBindings.BBox* o_bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.BBox*, void>)0x00519A20)(ref this, o_bbox);
    // void __thiscall CPartArray::UpdateParts(CPartArray*,const Frame*)
    public void UpdateParts(ACBindings.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.Frame*, void>)0x00519C20)(ref this, frame);
    // BOOL __thiscall CPartArray::SetMeshID(CPartArray*,int)
    public byte SetMeshID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int, byte>)0x00519C80)(ref this, a2);
    // void __thiscall CPartArray::DestroyLights(CPartArray*)
    public void DestroyLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x00519CE0)(ref this);
    // int __thiscall CPartArray::DoObjDescChanges(CPartArray*,const ObjDesc*)
    public int DoObjDescChanges(ACBindings.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.ObjDesc*, int>)0x00519D40)(ref this, objdesc);
    // void __thiscall CPartArray::Destroy(CPartArray*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x00519DD0)(ref this);
    // void __thiscall CPartArray::SetFrame(CPartArray*,const Frame*)
    public void SetFrame(ACBindings.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.Frame*, void>)0x00519E40)(ref this, frame);
    // int __thiscall CPartArray::SetSetupID(CPartArray*,int,int)
    public int SetSetupID(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, int, int, int>)0x00519E60)(ref this, a2, a3);
    // int __thiscall CPartArray::SetPlacementFrame(CPartArray*,unsigned int)
    public int SetPlacementFrame(uint placement_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, uint, int>)0x00519F00)(ref this, placement_id);
    // int __thiscall CPartArray::DoObjDescChangesFromDefault(CPartArray*,const ObjDesc*)
    public int DoObjDescChangesFromDefault(ACBindings.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, ACBindings.ObjDesc*, int>)0x00519FB0)(ref this, objdesc);
    // void __thiscall CPartArray::~CPartArray(CPartArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartArray, void>)0x0051A000)(ref this);
    // CPartArray* __cdecl CPartArray::CreateParticle(CPhysicsObj*,unsigned int,const CSphere*)
    public static ACBindings.CPartArray* CreateParticle(ACBindings.CPhysicsObj* owner, uint num_parts, ACBindings.CSphere* sorting_sphere) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, uint, ACBindings.CSphere*, ACBindings.CPartArray*>)0x0051A020)(owner, num_parts, sorting_sphere);
    // CPartArray* __cdecl CPartArray::CreateSetup(CPhysicsObj*,int,int)
    public static ACBindings.CPartArray* CreateSetup(ACBindings.CPhysicsObj* phys_obj, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, int, int, ACBindings.CPartArray*>)0x0051A0D0)(phys_obj, a2, a3);
    // CPartArray* __cdecl CPartArray::CreateMesh(CPhysicsObj*,int)
    public static ACBindings.CPartArray* CreateMesh(ACBindings.CPhysicsObj* phys_obj, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, int, ACBindings.CPartArray*>)0x0051A170)(phys_obj, a2);
}

