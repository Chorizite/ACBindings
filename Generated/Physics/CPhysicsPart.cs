namespace ACBindings;

// CPhysicsPart
public unsafe struct CPhysicsPart : System.IDisposable
{
    // Statics
    public static uint* viewcone_check_object_id = (uint*)0x00844BFC;
    public static int* selected_object_in_view = (int*)0x00844C00;
    public static int* creature_mode = (int*)0x00844C04;
    public static uint* player_iid = (uint*)0x00844C08;

    // Child Types
    // CPhysicsPart::PartDrawState
    public enum PartDrawState : uint
    {
        DEFAULT_DS = 0x0,
        NODRAW_DS = 0x1,
        FORCE_PartDrawState_32_BIT = 0x7FFFFFFF
    }

    // Members
    public float CYpt;
    public ACBindings.AC1Legacy.Vector3 viewer_heading;
    public ACBindings.GfxObjDegradeInfo* degrades;
    public uint deg_level;
    public int deg_mode;
    public int draw_state;
    public ACBindings.CGfxObj** gfxobj;
    public ACBindings.AC1Legacy.Vector3 gfxobj_scale;
    public ACBindings.Position pos;
    public ACBindings.Position draw_pos;
    public ACBindings.CMaterial* material;
    public ACBindings.CSurface** surfaces;
    public ACBindings.IDClass___tagDataID original_palette_id;
    public float curTranslucency;
    public float curDiffuse;
    public float curLuminosity;
    public ACBindings.Palette* shiftPal;
    public uint m_current_render_frame_num;
    public ACBindings.CPhysicsObj* physobj;
    public int physobj_index;

    // Generated Constructor
    public CPhysicsPart() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall CPhysicsPart::get_physobj_id(CPhysicsPart*)
    public uint get_physobj_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, uint>)0x0050DF60)(ref this);
    // bool __thiscall CPhysicsPart::IsPartOfPlayerObj(CPhysicsPart*)
    public byte IsPartOfPlayerObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, byte>)0x0050DF80)(ref this);
    // bool __thiscall CPhysicsPart::GetDrawnThisFrame(CPhysicsPart*)
    public byte GetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, byte>)0x0050DFA0)(ref this);
    // void __thiscall CPhysicsPart::SetDrawnThisFrame(CPhysicsPart*)
    public void SetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050DFC0)(ref this);
    // float __thiscall CPhysicsPart::GetMaxDegradeDistance(CPhysicsPart*)
    public float GetMaxDegradeDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, float>)0x0050DFE0)(ref this);
    // void __cdecl CPhysicsPart::ReleaseGfxObjArray(GfxObjDegradeInfo**,CGfxObj***)
    public static void ReleaseGfxObjArray(ACBindings.GfxObjDegradeInfo** old_degrades, ACBindings.CGfxObj*** old_gfxobj) => ((delegate* unmanaged[Cdecl]<ACBindings.GfxObjDegradeInfo**, ACBindings.CGfxObj***, void>)0x0050E000)(old_degrades, old_gfxobj);
    // _DWORD* __thiscall CPhysicsPart::GetOriginalPaletteID(_DWORD*,_DWORD*)
    public int* GetOriginalPaletteID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int*, int*>)0x0050E070)(ref this, a2);
    // void __thiscall CPhysicsPart::RestorePalette(CPhysicsPart*)
    public void RestorePalette() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050E080)(ref this);
    // const BBox* __thiscall CPhysicsPart::GetBoundingBox(CPhysicsPart*)
    public ACBindings.BBox* GetBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, ACBindings.BBox*>)0x0050E0D0)(ref this);
    // void __thiscall CPhysicsPart::SetNoDraw(CPhysicsPart*,int)
    public void SetNoDraw(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int, void>)0x0050E0E0)(ref this, no_draw);
    // int __thiscall CPhysicsPart::CopyMaterial(CPhysicsPart*)
    public int CopyMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int>)0x0050E100)(ref this);
    // int __thiscall CPhysicsPart::CopySurfaces(CPhysicsPart*)
    public int CopySurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int>)0x0050E170)(ref this);
    // void __thiscall CPhysicsPart::RestoreSurfaces(CPhysicsPart*)
    public void RestoreSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050E200)(ref this);
    // void __thiscall CPhysicsPart::Draw(CPhysicsPart*,int)
    public void Draw(int building_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int, void>)0x0050E270)(ref this, building_flag);
    // int __thiscall CPhysicsPart::Always2D(CPhysicsPart*)
    public int Always2D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int>)0x0050E370)(ref this);
    // TransitionState __thiscall CPhysicsPart::find_obj_collisions(CPhysicsPart*,CTransition*)
    public ACBindings.TransitionState find_obj_collisions(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, ACBindings.CTransition*, ACBindings.TransitionState>)0x0050E3A0)(ref this, transition);
    // bool __thiscall CPhysicsPart::CurSettingsAreDefault(CPhysicsPart*)
    public byte CurSettingsAreDefault() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, byte>)0x0050E4B0)(ref this);
    // void __thiscall CPhysicsPart::CPhysicsPart(CPhysicsPart*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050E550)(ref this);
    // bool __thiscall CPhysicsPart::MorphToExistingObject(CPhysicsPart*,const CPhysicsPart*)
    public byte MorphToExistingObject(ACBindings.CPhysicsPart* pTemplate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, ACBindings.CPhysicsPart*, byte>)0x0050E640)(ref this, pTemplate);
    // void __thiscall CPhysicsPart::DetermineBasePal(CPhysicsPart*)
    public void DetermineBasePal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050E750)(ref this);
    // int __cdecl CPhysicsPart::LoadGfxObjArray(int,GfxObjDegradeInfo**,CGfxObj***)
    public static int LoadGfxObjArray(int a1, ACBindings.GfxObjDegradeInfo** old_degrades, ACBindings.CGfxObj*** old_gfxobj) => ((delegate* unmanaged[Cdecl]<int, ACBindings.GfxObjDegradeInfo**, ACBindings.CGfxObj***, int>)0x0050E7C0)(a1, old_degrades, old_gfxobj);
    // int __thiscall CPhysicsPart::SetTextureMap(CPhysicsPart*,int,int)
    public int SetTextureMap(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int, int, int>)0x0050E900)(ref this, a2, a3);
    // int __thiscall CPhysicsPart::UsePalette(CPhysicsPart*,Palette*)
    public int UsePalette(ACBindings.Palette* pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, ACBindings.Palette*, int>)0x0050E9A0)(ref this, pal);
    // void __thiscall CPhysicsPart::RestoreMaterial(CPhysicsPart*)
    public void RestoreMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050EA40)(ref this);
    // void __thiscall CPhysicsPart::calc_draw_frame(CPhysicsPart*)
    public void calc_draw_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050EA70)(ref this);
    // void __thiscall CPhysicsPart::UpdateViewerDistance(CPhysicsPart*)
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050EB00)(ref this);
    // void __thiscall CPhysicsPart::UpdateViewerDistance(CPhysicsPart*,float,const AC1Legacy::Vector3*)
    public void UpdateViewerDistance(float CYpt, ACBindings.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, float, ACBindings.AC1Legacy.Vector3*, void>)0x0050EC70)(ref this, CYpt, viewer_heading);
    // CPhysicsPart* __cdecl CPhysicsPart::makePhysicsPart(const CPhysicsPart*)
    public static ACBindings.CPhysicsPart* makePhysicsPart(ACBindings.CPhysicsPart* pTemplate) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsPart*, ACBindings.CPhysicsPart*>)0x0050ED00)(pTemplate);
    // void __thiscall CPhysicsPart::~CPhysicsPart(CPhysicsPart*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050ED40)(ref this);
    // void __thiscall CPhysicsPart::SetGfxObjArray(CPhysicsPart*,GfxObjDegradeInfo*,CGfxObj**)
    public void SetGfxObjArray(ACBindings.GfxObjDegradeInfo* new_degrades, ACBindings.CGfxObj** new_gfxobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, ACBindings.GfxObjDegradeInfo*, ACBindings.CGfxObj**, void>)0x0050EDB0)(ref this, new_degrades, new_gfxobj);
    // int __thiscall CPhysicsPart::InitObjDescChanges(CPhysicsPart*)
    public int InitObjDescChanges() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, int>)0x0050EE80)(ref this);
    // void __thiscall CPhysicsPart::SetLighting(CPhysicsPart*,float,float)
    public void SetLighting(float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, float, float, void>)0x0050EED0)(ref this, luminosity, diffuse);
    // void __thiscall CPhysicsPart::RestoreLighting(CPhysicsPart*)
    public void RestoreLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, void>)0x0050EF70)(ref this);
    // void __thiscall CPhysicsPart::SetDiffusion(CPhysicsPart*,float)
    public void SetDiffusion(float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, float, void>)0x0050F040)(ref this, diffuse);
    // void __thiscall CPhysicsPart::SetLuminosity(CPhysicsPart*,float)
    public void SetLuminosity(float luminosity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, float, void>)0x0050F0C0)(ref this, luminosity);
    // void __thiscall CPhysicsPart::SetTranslucency(CPhysicsPart*,float)
    public void SetTranslucency(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, float, void>)0x0050F140)(ref this, translucency);
    // int __thiscall CPhysicsPart::SetPart(CPhysicsPart*,CGfxObj**)
    public int SetPart(ACBindings.CGfxObj** new_gfxobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPhysicsPart, ACBindings.CGfxObj**, int>)0x0050F1D0)(ref this, new_gfxobj);
    // CPhysicsPart* __cdecl CPhysicsPart::makePhysicsPart(CGfxObj**)
    public static ACBindings.CPhysicsPart* makePhysicsPart(ACBindings.CGfxObj** a1) => ((delegate* unmanaged[Cdecl]<ACBindings.CGfxObj**, ACBindings.CPhysicsPart*>)0x0050F230)(a1);
}

