namespace ACBindings.Internal;

public unsafe struct CPartArray : System.IDisposable
{
    // Members
    public uint pa_state;
    public ACBindings.Internal.CPhysicsObj* owner;
    public ACBindings.Internal.CSequence sequence;
    public ACBindings.Internal.MotionTableManager* motion_table_manager;
    public System.IntPtr setup;
    public uint num_parts;
    public ACBindings.Internal.CPhysicsPart** parts;
    public ACBindings.Internal.AC1Legacy.Vector3 scale;
    public ACBindings.Internal.Palette** pals;
    public ACBindings.Internal.LIGHTLIST* lights;
    public ACBindings.Internal.AnimFrame* last_animframe;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00518860
    /// void __thiscall CPartArray::AnimationDone(CPartArray*,int)</code>
    /// </summary>
    public void AnimationDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, void>)0x00518860)(ref this, success);

    /// <summary>
    /// <code>Offset: 0x00518890
    /// void __thiscall CPartArray::HandleMovement(CPartArray*)</code>
    /// </summary>
    public void HandleMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00518890)(ref this);

    /// <summary>
    /// <code>Offset: 0x005188A0
    /// void __thiscall CPartArray::HandleEnterWorld(CPartArray*)</code>
    /// </summary>
    public void HandleEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x005188A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005188C0
    /// void __thiscall CPartArray::HandleExitWorld(CPartArray*)</code>
    /// </summary>
    public void HandleExitWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x005188C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005188E0
    /// void __thiscall CPartArray::Update(CPartArray*,float,Frame*)</code>
    /// </summary>
    public void Update(float quantum, ACBindings.Internal.Frame* offset_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, ACBindings.Internal.Frame*, void>)0x005188E0)(ref this, quantum, offset_frame);

    /// <summary>
    /// <code>Offset: 0x00518900
    /// void __thiscall CPartArray::SetCellID(CPartArray*,const unsigned int)</code>
    /// </summary>
    public void SetCellID(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, void>)0x00518900)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x00518930
    /// void __thiscall CPartArray::RemoveParts(CPartArray*,CObjCell*)</code>
    /// </summary>
    public void RemoveParts(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, void>)0x00518930)(ref this, obj_cell);

    /// <summary>
    /// <code>Offset: 0x00518970
    /// void __thiscall CPartArray::AddPartsShadow(CPartArray*,CObjCell*,unsigned int)</code>
    /// </summary>
    public void AddPartsShadow(ACBindings.Internal.CObjCell* obj_cell, uint num_shadow_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, uint, void>)0x00518970)(ref this, obj_cell, num_shadow_parts);

    /// <summary>
    /// <code>Offset: 0x005189D0
    /// void __thiscall CPartArray::AddLightsToCell(CPartArray*,CObjCell*)</code>
    /// </summary>
    public void AddLightsToCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, void>)0x005189D0)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x00518A20
    /// void __thiscall CPartArray::RemoveLightsFromCell(CPartArray*,CObjCell*)</code>
    /// </summary>
    public void RemoveLightsFromCell(ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, void>)0x00518A20)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x00518A70
    /// int __thiscall CPartArray::InitParts(CPartArray*)</code>
    /// </summary>
    public int InitParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518A70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518B90
    /// unsigned int __thiscall CPartArray::GetNumSphere(CPartArray*)</code>
    /// </summary>
    public uint GetNumSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint>)0x00518B90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518BA0
    /// const CSphere* __thiscall CPartArray::GetSphere(CPartArray*)</code>
    /// </summary>
    public ACBindings.Internal.CSphere* GetSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CSphere*>)0x00518BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518BB0
    /// unsigned int __thiscall CPartArray::GetNumCylsphere(CPartArray*)</code>
    /// </summary>
    public uint GetNumCylsphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint>)0x00518BB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518BC0
    /// const CCylSphere* __thiscall CPartArray::GetCylsphere(CPartArray*)</code>
    /// </summary>
    public ACBindings.Internal.CCylSphere* GetCylsphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CCylSphere*>)0x00518BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518BD0
    /// float __thiscall CPartArray::GetRadius(CPartArray*)</code>
    /// </summary>
    public float GetRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float>)0x00518BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518BE0
    /// float __thiscall CPartArray::GetHeight(CPartArray*)</code>
    /// </summary>
    public float GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float>)0x00518BE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518BF0
    /// int __thiscall CPartArray::AllowsFreeHeading(CPartArray*)</code>
    /// </summary>
    public int AllowsFreeHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518C40
    /// int __thiscall CPartArray::CacheHasPhysicsBSP(CPartArray*)</code>
    /// </summary>
    public int CacheHasPhysicsBSP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518C40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518C90
    /// void __thiscall CPartArray::calc_cross_cells_static(CPartArray*,const CObjCell*,CELLARRAY*)</code>
    /// </summary>
    public void calc_cross_cells_static(ACBindings.Internal.CObjCell* cell, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CObjCell*, ACBindings.Internal.CELLARRAY*, void>)0x00518C90)(ref this, cell, cell_array);

    /// <summary>
    /// <code>Offset: 0x00518CB0
    /// TransitionState __thiscall CPartArray::FindObjCollisions(CPartArray*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState FindObjCollisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00518CB0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x00518CF0
    /// int __thiscall CPartArray::InitPals(CPartArray*)</code>
    /// </summary>
    public int InitPals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00518CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518D40
    /// void __thiscall CPartArray::DestroyPals(CPartArray*)</code>
    /// </summary>
    public void DestroyPals() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00518D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518D90
    /// void __thiscall CPartArray::UpdateViewerDistance(CPartArray*)</code>
    /// </summary>
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00518D90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00518DC0
    /// void __thiscall CPartArray::UpdateViewerDistance(CPartArray*,float,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void UpdateViewerDistance(float CYpt, ACBindings.Internal.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00518DC0)(ref this, CYpt, viewer_heading);

    /// <summary>
    /// <code>Offset: 0x00518E00
    /// void __thiscall CPartArray::Draw(CPartArray*,const Position*)</code>
    /// </summary>
    public void Draw(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.Position*, void>)0x00518E00)(ref this, p);

    /// <summary>
    /// <code>Offset: 0x00518E30
    /// void __thiscall CPartArray::SetNoDrawInternal(CPartArray*,int)</code>
    /// </summary>
    public void SetNoDrawInternal(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, void>)0x00518E30)(ref this, no_draw);

    /// <summary>
    /// <code>Offset: 0x00518E70
    /// void __thiscall CPartArray::SetTranslucencyInternal(CPartArray*,float)</code>
    /// </summary>
    public void SetTranslucencyInternal(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, void>)0x00518E70)(ref this, translucency);

    /// <summary>
    /// <code>Offset: 0x00518EB0
    /// void __thiscall CPartArray::SetPartTranslucencyInternal(CPartArray*,unsigned int,float)</code>
    /// </summary>
    public void SetPartTranslucencyInternal(uint part_index, float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, float, void>)0x00518EB0)(ref this, part_index, translucency);

    /// <summary>
    /// <code>Offset: 0x00518EE0
    /// void __thiscall CPartArray::SetLuminosityInternal(CPartArray*,float)</code>
    /// </summary>
    public void SetLuminosityInternal(float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, void>)0x00518EE0)(ref this, lumi);

    /// <summary>
    /// <code>Offset: 0x00518F20
    /// void __thiscall CPartArray::SetPartLuminosityInternal(CPartArray*,unsigned int,float)</code>
    /// </summary>
    public void SetPartLuminosityInternal(uint part_index, float lumi) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, float, void>)0x00518F20)(ref this, part_index, lumi);

    /// <summary>
    /// <code>Offset: 0x00518F50
    /// void __thiscall CPartArray::SetDiffusionInternal(CPartArray*,float)</code>
    /// </summary>
    public void SetDiffusionInternal(float diff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, float, void>)0x00518F50)(ref this, diff);

    /// <summary>
    /// <code>Offset: 0x00518F90
    /// void __thiscall CPartArray::SetPartDiffusionInternal(CPartArray*,unsigned int,float)</code>
    /// </summary>
    public void SetPartDiffusionInternal(uint part_index, float diff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, float, void>)0x00518F90)(ref this, part_index, diff);

    /// <summary>
    /// <code>Offset: 0x00519070
    /// int __thiscall CPartArray::InitObjDescChanges(CPartArray*)</code>
    /// </summary>
    public int InitObjDescChanges() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00519070)(ref this);

    /// <summary>
    /// <code>Offset: 0x005190B0
    /// int __thiscall CPartArray::SetPart(CPartArray*,const AnimPartChange*)</code>
    /// </summary>
    public int SetPart(ACBindings.Internal.AnimPartChange* changes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.AnimPartChange*, int>)0x005190B0)(ref this, changes);

    /// <summary>
    /// <code>Offset: 0x00519110
    /// int __thiscall CPartArray::SetTextureMap(CPartArray*,const TextureMapChange*)</code>
    /// </summary>
    public int SetTextureMap(ACBindings.Internal.TextureMapChange* changes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.TextureMapChange*, int>)0x00519110)(ref this, changes);

    /// <summary>
    /// <code>Offset: 0x00519210
    /// int __thiscall CPartArray::SetMotionTableID(int,int)</code>
    /// </summary>
    public int SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, int>)0x00519210)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00519280
    /// unsigned int __thiscall CPartArray::DoInterpretedMotion(CPartArray*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint DoInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, ACBindings.Internal.MovementParameters*, uint>)0x00519280)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00519320
    /// unsigned int __thiscall CPartArray::StopInterpretedMotion(CPartArray*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint StopInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, ACBindings.Internal.MovementParameters*, uint>)0x00519320)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x005193C0
    /// unsigned int __thiscall CPartArray::StopCompletelyInternal(CPartArray*)</code>
    /// </summary>
    public uint StopCompletelyInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint>)0x005193C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00519450
    /// void __thiscall CPartArray::DestroyParts(CPartArray*)</code>
    /// </summary>
    public void DestroyParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00519450)(ref this);

    /// <summary>
    /// <code>Offset: 0x005194B0
    /// void __thiscall CPartArray::InitDefaults(CPartArray*)</code>
    /// </summary>
    public void InitDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x005194B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00519530
    /// int __thiscall CPartArray::SetScaleInternal(CPartArray*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int SetScaleInternal(ACBindings.Internal.AC1Legacy.Vector3* new_scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00519530)(ref this, new_scale);

    /// <summary>
    /// <code>Offset: 0x005195E0
    /// _DWORD* __thiscall CPartArray::GetSetupID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetSetupID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int*, int*>)0x005195E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005195F0
    /// unsigned int* __thiscall CPartArray::GetDataID(int,unsigned int*)</code>
    /// </summary>
    public uint* GetDataID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint*, uint*>)0x005195F0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00519630
    /// const CSphere* __thiscall CPartArray::GetSortingSphere(CPartArray*)</code>
    /// </summary>
    public ACBindings.Internal.CSphere* GetSortingSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CSphere*>)0x00519630)(ref this);

    /// <summary>
    /// <code>Offset: 0x005196B0
    /// int __thiscall CPartArray::GetSelectionSphere(CPartArray*,CSphere*)</code>
    /// </summary>
    public int GetSelectionSphere(ACBindings.Internal.CSphere* selection_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CSphere*, int>)0x005196B0)(ref this, selection_sphere);

    /// <summary>
    /// <code>Offset: 0x00519730
    /// int __thiscall CPartArray::InitLights(CPartArray*)</code>
    /// </summary>
    public int InitLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int>)0x00519730)(ref this);

    /// <summary>
    /// <code>Offset: 0x00519870
    /// int __thiscall CPartArray::MorphToExistingObject(CPartArray*,const CPartArray*)</code>
    /// </summary>
    public int MorphToExistingObject(ACBindings.Internal.CPartArray* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.CPartArray*, int>)0x00519870)(ref this, pObj);

    /// <summary>
    /// <code>Offset: 0x00519940
    /// int __thiscall CPartArray::SetPalette(CPartArray*,int,Subpalette*)</code>
    /// </summary>
    public int SetPalette(int a2, ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, ACBindings.Internal.Subpalette*, int>)0x00519940)(ref this, a2, subs);

    /// <summary>
    /// <code>Offset: 0x00519A20
    /// void __thiscall CPartArray::GetBoundingBox(CPartArray*,BBox*)</code>
    /// </summary>
    public void GetBoundingBox(ACBindings.Internal.BBox* o_bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.BBox*, void>)0x00519A20)(ref this, o_bbox);

    /// <summary>
    /// <code>Offset: 0x00519C20
    /// void __thiscall CPartArray::UpdateParts(CPartArray*,const Frame*)</code>
    /// </summary>
    public void UpdateParts(ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.Frame*, void>)0x00519C20)(ref this, frame);

    /// <summary>
    /// <code>Offset: 0x00519C80
    /// BOOL __thiscall CPartArray::SetMeshID(CPartArray*,int)</code>
    /// </summary>
    public byte SetMeshID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, byte>)0x00519C80)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00519CE0
    /// void __thiscall CPartArray::DestroyLights(CPartArray*)</code>
    /// </summary>
    public void DestroyLights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00519CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00519D40
    /// int __thiscall CPartArray::DoObjDescChanges(CPartArray*,const ObjDesc*)</code>
    /// </summary>
    public int DoObjDescChanges(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.ObjDesc*, int>)0x00519D40)(ref this, objdesc);

    /// <summary>
    /// <code>Offset: 0x00519DD0
    /// void __thiscall CPartArray::Destroy(CPartArray*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x00519DD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00519E40
    /// void __thiscall CPartArray::SetFrame(CPartArray*,const Frame*)</code>
    /// </summary>
    public void SetFrame(ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.Frame*, void>)0x00519E40)(ref this, frame);

    /// <summary>
    /// <code>Offset: 0x00519E60
    /// int __thiscall CPartArray::SetSetupID(CPartArray*,int,int)</code>
    /// </summary>
    public int SetSetupID(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, int, int, int>)0x00519E60)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00519F00
    /// int __thiscall CPartArray::SetPlacementFrame(CPartArray*,unsigned int)</code>
    /// </summary>
    public int SetPlacementFrame(uint placement_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, uint, int>)0x00519F00)(ref this, placement_id);

    /// <summary>
    /// <code>Offset: 0x00519FB0
    /// int __thiscall CPartArray::DoObjDescChangesFromDefault(CPartArray*,const ObjDesc*)</code>
    /// </summary>
    public int DoObjDescChangesFromDefault(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, ACBindings.Internal.ObjDesc*, int>)0x00519FB0)(ref this, objdesc);

    /// <summary>
    /// <code>Offset: 0x0051A000
    /// void __thiscall CPartArray::~CPartArray(CPartArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartArray, void>)0x0051A000)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051A020
    /// CPartArray* __cdecl CPartArray::CreateParticle(CPhysicsObj*,unsigned int,const CSphere*)</code>
    /// </summary>
    public static ACBindings.Internal.CPartArray* CreateParticle(ACBindings.Internal.CPhysicsObj* owner, uint num_parts, ACBindings.Internal.CSphere* sorting_sphere) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CPartArray*>)0x0051A020)(owner, num_parts, sorting_sphere);

    /// <summary>
    /// <code>Offset: 0x0051A0D0
    /// CPartArray* __cdecl CPartArray::CreateSetup(CPhysicsObj*,int,int)</code>
    /// </summary>
    public static ACBindings.Internal.CPartArray* CreateSetup(ACBindings.Internal.CPhysicsObj* phys_obj, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, int, int, ACBindings.Internal.CPartArray*>)0x0051A0D0)(phys_obj, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0051A170
    /// CPartArray* __cdecl CPartArray::CreateMesh(CPhysicsObj*,int)</code>
    /// </summary>
    public static ACBindings.Internal.CPartArray* CreateMesh(ACBindings.Internal.CPhysicsObj* phys_obj, int a2) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, int, ACBindings.Internal.CPartArray*>)0x0051A170)(phys_obj, a2);
}

