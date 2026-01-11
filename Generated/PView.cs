namespace ACBindings.Internal;

public unsafe struct PView : System.IDisposable
{
    // Statics
    public static uint* master_timestamp = (uint*)0x008EE6C8;

    // Members
    public ACBindings.Internal.portal_view_type outside_view;
    public int draw_landscape;
    public ACBindings.Internal.CBldPortal** outdoor_portal_list;
    public ACBindings.Internal.DArray___CEnvCell_ptr cell_draw_list;
    public uint cell_draw_num;
    public ACBindings.Internal.DArray___CellListType_ptr cell_todo_list;
    public uint cell_todo_num;
    public ACBindings.Internal.LScape* lscape;

    // Generated Constructor
    public PView(int draw_lscape) {
        _ConstructorInternal(draw_lscape);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005A53F0
    /// void __thiscall PView::remove_views(PView*,unsigned __int16,unsigned int*)</code>
    /// </summary>
    public void remove_views(ushort num_stabs, uint* stab_list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ushort, uint*, void>)0x005A53F0)(ref this, num_stabs, stab_list);

    /// <summary>
    /// <code>Offset: 0x005A5430
    /// void __thiscall PView::GetClip(PView*,Sidedness,CPolygon*,Vec2Dscreen**,int*,int)</code>
    /// </summary>
    public void GetClip(ACBindings.Internal.Sidedness side, ACBindings.Internal.CPolygon* ppoly, ACBindings.Internal.Vec2Dscreen** clip_view, int* clip_pts, int check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.Sidedness, ACBindings.Internal.CPolygon*, ACBindings.Internal.Vec2Dscreen**, int*, int, void>)0x005A5430)(ref this, side, ppoly, clip_view, clip_pts, check);

    /// <summary>
    /// <code>Offset: 0x005A5950
    /// void __thiscall PView::DrawCells(PView*,int)</code>
    /// </summary>
    public void DrawCells(int from_outside) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, int, void>)0x005A5950)(ref this, from_outside);

    /// <summary>
    /// <code>Offset: 0x005A5C80
    /// int __thiscall PView::InitCell(PView*,CEnvCell*,unsigned __int16)</code>
    /// </summary>
    public int InitCell(ACBindings.Internal.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ushort, int>)0x005A5C80)(ref this, cell, portal_in);

    /// <summary>
    /// <code>Offset: 0x005A5EA0
    /// void __thiscall PView::AddToCell(PView*,CEnvCell*,unsigned __int16)</code>
    /// </summary>
    public void AddToCell(ACBindings.Internal.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ushort, void>)0x005A5EA0)(ref this, cell, portal_in);

    /// <summary>
    /// <code>Offset: 0x005A5F40
    /// void __thiscall PView::SetOtherSeen(PView*,CEnvCell*,unsigned int)</code>
    /// </summary>
    public void SetOtherSeen(ACBindings.Internal.CEnvCell* pres_cell, uint portal_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, uint, void>)0x005A5F40)(ref this, pres_cell, portal_id);

    /// <summary>
    /// <code>Offset: 0x005A5FA0
    /// int __thiscall PView::AdjustDrawList(PView*,CEnvCell*,CEnvCell*)</code>
    /// </summary>
    public int AdjustDrawList(ACBindings.Internal.CEnvCell* cell_in_list, ACBindings.Internal.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ACBindings.Internal.CEnvCell*, int>)0x005A5FA0)(ref this, cell_in_list, new_cell);

    /// <summary>
    /// <code>Offset: 0x005A6060
    /// void __thiscall PView::InsCellTodoList(PView*,CEnvCell*,float)</code>
    /// </summary>
    public void InsCellTodoList(ACBindings.Internal.CEnvCell* cell, float dist) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, float, void>)0x005A6060)(ref this, cell, dist);

    /// <summary>
    /// <code>Offset: 0x005A6120
    /// void __thiscall PView::AdjustCellPlace(PView*,CEnvCell*,CEnvCell*)</code>
    /// </summary>
    public void AdjustCellPlace(ACBindings.Internal.CEnvCell* cell_in_list, ACBindings.Internal.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ACBindings.Internal.CEnvCell*, void>)0x005A6120)(ref this, cell_in_list, new_cell);

    /// <summary>
    /// <code>Offset: 0x005A6280
    /// void __thiscall PView::~PView(PView*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, void>)0x005A6280)(ref this);

    /// <summary>
    /// <code>Offset: 0x005A6320
    /// void __thiscall PView::add_views(PView*,unsigned __int16,unsigned int*)</code>
    /// </summary>
    public void add_views(ushort num_stabs, uint* stab_list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ushort, uint*, void>)0x005A6320)(ref this, num_stabs, stab_list);

    /// <summary>
    /// <code>Offset: 0x005A6360
    /// void __thiscall PView::FixCellList(PView*,CEnvCell*,CEnvCell*)</code>
    /// </summary>
    public void FixCellList(ACBindings.Internal.CEnvCell* cell_in_list, ACBindings.Internal.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ACBindings.Internal.CEnvCell*, void>)0x005A6360)(ref this, cell_in_list, new_cell);

    /// <summary>
    /// <code>Offset: 0x005A6380
    /// void __thiscall PView::PView(PView*,int)</code>
    /// </summary>
    public void _ConstructorInternal(int draw_lscape) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, int, void>)0x005A6380)(ref this, draw_lscape);

    /// <summary>
    /// <code>Offset: 0x005A63E0
    /// void __thiscall PView::AddViewToPortals(PView*,CEnvCell*)</code>
    /// </summary>
    public void AddViewToPortals(ACBindings.Internal.CEnvCell* pres_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, void>)0x005A63E0)(ref this, pres_cell);

    /// <summary>
    /// <code>Offset: 0x005A6510
    /// int __thiscall PView::OtherPortalClip(PView*,CCellPortal*,Vec2Dscreen**,int*)</code>
    /// </summary>
    public int OtherPortalClip(ACBindings.Internal.CCellPortal* portal, ACBindings.Internal.Vec2Dscreen** clip_view, int* clip_pts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CCellPortal*, ACBindings.Internal.Vec2Dscreen**, int*, int>)0x005A6510)(ref this, portal, clip_view, clip_pts);

    /// <summary>
    /// <code>Offset: 0x005A6630
    /// int __thiscall PView::ClipPortals(PView*,CEnvCell*,unsigned int)</code>
    /// </summary>
    public int ClipPortals(ACBindings.Internal.CEnvCell* pres_cell, uint first_view) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, uint, int>)0x005A6630)(ref this, pres_cell, first_view);

    /// <summary>
    /// <code>Offset: 0x005A6880
    /// void __thiscall PView::AdjustCellView(PView*,CEnvCell*)</code>
    /// </summary>
    public void AdjustCellView(ACBindings.Internal.CEnvCell* pres_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, void>)0x005A6880)(ref this, pres_cell);

    /// <summary>
    /// <code>Offset: 0x005A68C0
    /// void __thiscall PView::ConstructView(PView*,CEnvCell*,unsigned __int16)</code>
    /// </summary>
    public void ConstructView(ACBindings.Internal.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ushort, void>)0x005A68C0)(ref this, cell, portal_in);

    /// <summary>
    /// <code>Offset: 0x005A6970
    /// void __thiscall PView::DrawInside(PView*,CEnvCell*)</code>
    /// </summary>
    public void DrawInside(ACBindings.Internal.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, void>)0x005A6970)(ref this, cell);

    /// <summary>
    /// <code>Offset: 0x005A6AB0
    /// int __thiscall PView::ConstructView(PView*,CBldPortal*,CPolygon*,int,int)</code>
    /// </summary>
    public int ConstructView(ACBindings.Internal.CBldPortal* outside_portal, ACBindings.Internal.CPolygon* ppoly, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CBldPortal*, ACBindings.Internal.CPolygon*, int, int, int>)0x005A6AB0)(ref this, outside_portal, ppoly, check, portalPolyOrPortalContents);

    /// <summary>
    /// <code>Offset: 0x005A6BC0
    /// void __thiscall PView::DrawPortal(PView*,CPortalPoly*,int,int)</code>
    /// </summary>
    public void DrawPortal(ACBindings.Internal.CPortalPoly* portal, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CPortalPoly*, int, int, void>)0x005A6BC0)(ref this, portal, check, portalPolyOrPortalContents);
}

