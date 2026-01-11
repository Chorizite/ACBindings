namespace ACBindings.Internal;

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
    public ACBindings.Internal.AC1Legacy.Vector3 viewer_heading;
    public ACBindings.Internal.GfxObjDegradeInfo* degrades;
    public uint deg_level;
    public int deg_mode;
    public int draw_state;
    public ACBindings.Internal.CGfxObj** gfxobj;
    public ACBindings.Internal.AC1Legacy.Vector3 gfxobj_scale;
    public ACBindings.Internal.Position pos;
    public ACBindings.Internal.Position draw_pos;
    public ACBindings.Internal.CMaterial* material;
    public ACBindings.Internal.CSurface** surfaces;
    public ACBindings.Internal.IDClass____tagDataID original_palette_id;
    public float curTranslucency;
    public float curDiffuse;
    public float curLuminosity;
    public ACBindings.Internal.Palette* shiftPal;
    public uint m_current_render_frame_num;
    public ACBindings.Internal.CPhysicsObj* physobj;
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

    /// <summary>
    /// <code>Offset: 0x0050DF60
    /// unsigned int __thiscall CPhysicsPart::get_physobj_id(CPhysicsPart*)</code>
    /// </summary>
    public uint get_physobj_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, uint>)0x0050DF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050DF80
    /// bool __thiscall CPhysicsPart::IsPartOfPlayerObj(CPhysicsPart*)</code>
    /// </summary>
    public byte IsPartOfPlayerObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, byte>)0x0050DF80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050DFA0
    /// bool __thiscall CPhysicsPart::GetDrawnThisFrame(CPhysicsPart*)</code>
    /// </summary>
    public byte GetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, byte>)0x0050DFA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050DFC0
    /// void __thiscall CPhysicsPart::SetDrawnThisFrame(CPhysicsPart*)</code>
    /// </summary>
    public void SetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050DFC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050DFE0
    /// float __thiscall CPhysicsPart::GetMaxDegradeDistance(CPhysicsPart*)</code>
    /// </summary>
    public float GetMaxDegradeDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float>)0x0050DFE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E000
    /// void __cdecl CPhysicsPart::ReleaseGfxObjArray(GfxObjDegradeInfo**,CGfxObj***)</code>
    /// </summary>
    public static void ReleaseGfxObjArray(ACBindings.Internal.GfxObjDegradeInfo** old_degrades, ACBindings.Internal.CGfxObj*** old_gfxobj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GfxObjDegradeInfo**, ACBindings.Internal.CGfxObj***, void>)0x0050E000)(old_degrades, old_gfxobj);

    /// <summary>
    /// <code>Offset: 0x0050E070
    /// _DWORD* __thiscall CPhysicsPart::GetOriginalPaletteID(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetOriginalPaletteID(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int*, int*>)0x0050E070)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0050E080
    /// void __thiscall CPhysicsPart::RestorePalette(CPhysicsPart*)</code>
    /// </summary>
    public void RestorePalette() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E080)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E0D0
    /// const BBox* __thiscall CPhysicsPart::GetBoundingBox(CPhysicsPart*)</code>
    /// </summary>
    public ACBindings.Internal.BBox* GetBoundingBox() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.BBox*>)0x0050E0D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E0E0
    /// void __thiscall CPhysicsPart::SetNoDraw(CPhysicsPart*,int)</code>
    /// </summary>
    public void SetNoDraw(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int, void>)0x0050E0E0)(ref this, no_draw);

    /// <summary>
    /// <code>Offset: 0x0050E100
    /// int __thiscall CPhysicsPart::CopyMaterial(CPhysicsPart*)</code>
    /// </summary>
    public int CopyMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050E100)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E170
    /// int __thiscall CPhysicsPart::CopySurfaces(CPhysicsPart*)</code>
    /// </summary>
    public int CopySurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050E170)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E200
    /// void __thiscall CPhysicsPart::RestoreSurfaces(CPhysicsPart*)</code>
    /// </summary>
    public void RestoreSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E200)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E270
    /// void __thiscall CPhysicsPart::Draw(CPhysicsPart*,int)</code>
    /// </summary>
    public void Draw(int building_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int, void>)0x0050E270)(ref this, building_flag);

    /// <summary>
    /// <code>Offset: 0x0050E370
    /// int __thiscall CPhysicsPart::Always2D(CPhysicsPart*)</code>
    /// </summary>
    public int Always2D() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050E370)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E3A0
    /// TransitionState __thiscall CPhysicsPart::find_obj_collisions(CPhysicsPart*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_obj_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0050E3A0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0050E4B0
    /// bool __thiscall CPhysicsPart::CurSettingsAreDefault(CPhysicsPart*)</code>
    /// </summary>
    public byte CurSettingsAreDefault() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, byte>)0x0050E4B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E550
    /// void __thiscall CPhysicsPart::CPhysicsPart(CPhysicsPart*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E550)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E640
    /// bool __thiscall CPhysicsPart::MorphToExistingObject(CPhysicsPart*,const CPhysicsPart*)</code>
    /// </summary>
    public byte MorphToExistingObject(ACBindings.Internal.CPhysicsPart* pTemplate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.CPhysicsPart*, byte>)0x0050E640)(ref this, pTemplate);

    /// <summary>
    /// <code>Offset: 0x0050E750
    /// void __thiscall CPhysicsPart::DetermineBasePal(CPhysicsPart*)</code>
    /// </summary>
    public void DetermineBasePal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050E750)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050E7C0
    /// int __cdecl CPhysicsPart::LoadGfxObjArray(int,GfxObjDegradeInfo**,CGfxObj***)</code>
    /// </summary>
    public static int LoadGfxObjArray(int a1, ACBindings.Internal.GfxObjDegradeInfo** old_degrades, ACBindings.Internal.CGfxObj*** old_gfxobj) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.GfxObjDegradeInfo**, ACBindings.Internal.CGfxObj***, int>)0x0050E7C0)(a1, old_degrades, old_gfxobj);

    /// <summary>
    /// <code>Offset: 0x0050E900
    /// int __thiscall CPhysicsPart::SetTextureMap(CPhysicsPart*,int,int)</code>
    /// </summary>
    public int SetTextureMap(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int, int, int>)0x0050E900)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x0050E9A0
    /// int __thiscall CPhysicsPart::UsePalette(CPhysicsPart*,Palette*)</code>
    /// </summary>
    public int UsePalette(ACBindings.Internal.Palette* pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.Palette*, int>)0x0050E9A0)(ref this, pal);

    /// <summary>
    /// <code>Offset: 0x0050EA40
    /// void __thiscall CPhysicsPart::RestoreMaterial(CPhysicsPart*)</code>
    /// </summary>
    public void RestoreMaterial() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EA40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050EA70
    /// void __thiscall CPhysicsPart::calc_draw_frame(CPhysicsPart*)</code>
    /// </summary>
    public void calc_draw_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EA70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050EB00
    /// void __thiscall CPhysicsPart::UpdateViewerDistance(CPhysicsPart*)</code>
    /// </summary>
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EB00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050EC70
    /// void __thiscall CPhysicsPart::UpdateViewerDistance(CPhysicsPart*,float,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void UpdateViewerDistance(float CYpt, ACBindings.Internal.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050EC70)(ref this, CYpt, viewer_heading);

    /// <summary>
    /// <code>Offset: 0x0050ED00
    /// CPhysicsPart* __cdecl CPhysicsPart::makePhysicsPart(const CPhysicsPart*)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsPart* makePhysicsPart(ACBindings.Internal.CPhysicsPart* pTemplate) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.CPhysicsPart*>)0x0050ED00)(pTemplate);

    /// <summary>
    /// <code>Offset: 0x0050ED40
    /// void __thiscall CPhysicsPart::~CPhysicsPart(CPhysicsPart*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050ED40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050EDB0
    /// void __thiscall CPhysicsPart::SetGfxObjArray(CPhysicsPart*,GfxObjDegradeInfo*,CGfxObj**)</code>
    /// </summary>
    public void SetGfxObjArray(ACBindings.Internal.GfxObjDegradeInfo* new_degrades, ACBindings.Internal.CGfxObj** new_gfxobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.GfxObjDegradeInfo*, ACBindings.Internal.CGfxObj**, void>)0x0050EDB0)(ref this, new_degrades, new_gfxobj);

    /// <summary>
    /// <code>Offset: 0x0050EE80
    /// int __thiscall CPhysicsPart::InitObjDescChanges(CPhysicsPart*)</code>
    /// </summary>
    public int InitObjDescChanges() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, int>)0x0050EE80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050EED0
    /// void __thiscall CPhysicsPart::SetLighting(CPhysicsPart*,float,float)</code>
    /// </summary>
    public void SetLighting(float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, float, void>)0x0050EED0)(ref this, luminosity, diffuse);

    /// <summary>
    /// <code>Offset: 0x0050EF70
    /// void __thiscall CPhysicsPart::RestoreLighting(CPhysicsPart*)</code>
    /// </summary>
    public void RestoreLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, void>)0x0050EF70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F040
    /// void __thiscall CPhysicsPart::SetDiffusion(CPhysicsPart*,float)</code>
    /// </summary>
    public void SetDiffusion(float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, void>)0x0050F040)(ref this, diffuse);

    /// <summary>
    /// <code>Offset: 0x0050F0C0
    /// void __thiscall CPhysicsPart::SetLuminosity(CPhysicsPart*,float)</code>
    /// </summary>
    public void SetLuminosity(float luminosity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, void>)0x0050F0C0)(ref this, luminosity);

    /// <summary>
    /// <code>Offset: 0x0050F140
    /// void __thiscall CPhysicsPart::SetTranslucency(CPhysicsPart*,float)</code>
    /// </summary>
    public void SetTranslucency(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, float, void>)0x0050F140)(ref this, translucency);

    /// <summary>
    /// <code>Offset: 0x0050F1D0
    /// int __thiscall CPhysicsPart::SetPart(CPhysicsPart*,CGfxObj**)</code>
    /// </summary>
    public int SetPart(ACBindings.Internal.CGfxObj** new_gfxobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsPart, ACBindings.Internal.CGfxObj**, int>)0x0050F1D0)(ref this, new_gfxobj);

    /// <summary>
    /// <code>Offset: 0x0050F230
    /// CPhysicsPart* __cdecl CPhysicsPart::makePhysicsPart(CGfxObj**)</code>
    /// </summary>
    public static ACBindings.Internal.CPhysicsPart* makePhysicsPart(ACBindings.Internal.CGfxObj** a1) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CGfxObj**, ACBindings.Internal.CPhysicsPart*>)0x0050F230)(a1);
}

