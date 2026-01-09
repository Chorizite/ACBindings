namespace ACBindings;

// PView
public unsafe struct PView : System.IDisposable
{
    // Statics
    public static uint* master_timestamp = (uint*)0x008EE6C8;

    // Members
    public ACBindings.portal_view_type outside_view;
    public int draw_landscape;
    public ACBindings.CBldPortal** outdoor_portal_list;
    public ACBindings.DArray__CEnvCell_ptr cell_draw_list;
    public uint cell_draw_num;
    public ACBindings.DArray__CellListType_ptr cell_todo_list;
    public uint cell_todo_num;
    public ACBindings.LScape* lscape;

    // Generated Constructor
    public PView(int draw_lscape) {
        _ConstructorInternal(draw_lscape);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall PView::remove_views(PView*,unsigned __int16,unsigned int*)
    public void remove_views(ushort num_stabs, uint* stab_list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ushort, uint*, void>)0x005A53F0)(ref this, num_stabs, stab_list);
    // void __thiscall PView::GetClip(PView*,Sidedness,CPolygon*,Vec2Dscreen**,int*,int)
    public void GetClip(ACBindings.Sidedness side, ACBindings.CPolygon* ppoly, ACBindings.Vec2Dscreen** clip_view, int* clip_pts, int check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.Sidedness, ACBindings.CPolygon*, ACBindings.Vec2Dscreen**, int*, int, void>)0x005A5430)(ref this, side, ppoly, clip_view, clip_pts, check);
    // void __thiscall PView::DrawCells(PView*,int)
    public void DrawCells(int from_outside) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, int, void>)0x005A5950)(ref this, from_outside);
    // int __thiscall PView::InitCell(PView*,CEnvCell*,unsigned __int16)
    public int InitCell(ACBindings.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, ushort, int>)0x005A5C80)(ref this, cell, portal_in);
    // void __thiscall PView::AddToCell(PView*,CEnvCell*,unsigned __int16)
    public void AddToCell(ACBindings.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, ushort, void>)0x005A5EA0)(ref this, cell, portal_in);
    // void __thiscall PView::SetOtherSeen(PView*,CEnvCell*,unsigned int)
    public void SetOtherSeen(ACBindings.CEnvCell* pres_cell, uint portal_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, uint, void>)0x005A5F40)(ref this, pres_cell, portal_id);
    // int __thiscall PView::AdjustDrawList(PView*,CEnvCell*,CEnvCell*)
    public int AdjustDrawList(ACBindings.CEnvCell* cell_in_list, ACBindings.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, ACBindings.CEnvCell*, int>)0x005A5FA0)(ref this, cell_in_list, new_cell);
    // void __thiscall PView::InsCellTodoList(PView*,CEnvCell*,float)
    public void InsCellTodoList(ACBindings.CEnvCell* cell, float dist) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, float, void>)0x005A6060)(ref this, cell, dist);
    // void __thiscall PView::AdjustCellPlace(PView*,CEnvCell*,CEnvCell*)
    public void AdjustCellPlace(ACBindings.CEnvCell* cell_in_list, ACBindings.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, ACBindings.CEnvCell*, void>)0x005A6120)(ref this, cell_in_list, new_cell);
    // void __thiscall PView::~PView(PView*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, void>)0x005A6280)(ref this);
    // void __thiscall PView::add_views(PView*,unsigned __int16,unsigned int*)
    public void add_views(ushort num_stabs, uint* stab_list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ushort, uint*, void>)0x005A6320)(ref this, num_stabs, stab_list);
    // void __thiscall PView::FixCellList(PView*,CEnvCell*,CEnvCell*)
    public void FixCellList(ACBindings.CEnvCell* cell_in_list, ACBindings.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, ACBindings.CEnvCell*, void>)0x005A6360)(ref this, cell_in_list, new_cell);
    // void __thiscall PView::PView(PView*,int)
    public void _ConstructorInternal(int draw_lscape) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, int, void>)0x005A6380)(ref this, draw_lscape);
    // void __thiscall PView::AddViewToPortals(PView*,CEnvCell*)
    public void AddViewToPortals(ACBindings.CEnvCell* pres_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, void>)0x005A63E0)(ref this, pres_cell);
    // int __thiscall PView::OtherPortalClip(PView*,CCellPortal*,Vec2Dscreen**,int*)
    public int OtherPortalClip(ACBindings.CCellPortal* portal, ACBindings.Vec2Dscreen** clip_view, int* clip_pts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CCellPortal*, ACBindings.Vec2Dscreen**, int*, int>)0x005A6510)(ref this, portal, clip_view, clip_pts);
    // int __thiscall PView::ClipPortals(PView*,CEnvCell*,unsigned int)
    public int ClipPortals(ACBindings.CEnvCell* pres_cell, uint first_view) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, uint, int>)0x005A6630)(ref this, pres_cell, first_view);
    // void __thiscall PView::AdjustCellView(PView*,CEnvCell*)
    public void AdjustCellView(ACBindings.CEnvCell* pres_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, void>)0x005A6880)(ref this, pres_cell);
    // void __thiscall PView::ConstructView(PView*,CEnvCell*,unsigned __int16)
    public void ConstructView(ACBindings.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, ushort, void>)0x005A68C0)(ref this, cell, portal_in);
    // void __thiscall PView::DrawInside(PView*,CEnvCell*)
    public void DrawInside(ACBindings.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CEnvCell*, void>)0x005A6970)(ref this, cell);
    // int __thiscall PView::ConstructView(PView*,CBldPortal*,CPolygon*,int,int)
    public int ConstructView(ACBindings.CBldPortal* outside_portal, ACBindings.CPolygon* ppoly, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CBldPortal*, ACBindings.CPolygon*, int, int, int>)0x005A6AB0)(ref this, outside_portal, ppoly, check, portalPolyOrPortalContents);
    // void __thiscall PView::DrawPortal(PView*,CPortalPoly*,int,int)
    public void DrawPortal(ACBindings.CPortalPoly* portal, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PView, ACBindings.CPortalPoly*, int, int, void>)0x005A6BC0)(ref this, portal, check, portalPolyOrPortalContents);
}

