namespace ACBindings.Internal;


/// <summary>Handles the rendering of an environment by maintaining portal views, cell draw queues, and landscape options for a scene view.</summary>
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

    /// <summary>Decrements the view counter for each visible cell referenced in the provided stab list, thereby removing those views from the scene.
    /// <code>Offset: 0x005A53F0
    /// void __thiscall PView::remove_views(PView*,unsigned __int16,unsigned int*)</code>
    /// </summary>
    /// <param name="num_stabs">Number of stabs to process.</param>
    /// <param name="stab_list">Pointer to an array of stab identifiers whose associated cells will have their view counts decreased.</param>
    public void remove_views(ushort num_stabs, uint* stab_list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ushort, uint*, void>)0x005A53F0)(ref this, num_stabs, stab_list);

    /// <summary>Transforms a polygon’s vertices into screen space and optionally clips them based on sidedness. The resulting clipped points are written to the supplied array, with their count returned through an out parameter.
    /// <code>Offset: 0x005A5430
    /// void __thiscall PView::GetClip(PView*,Sidedness,CPolygon*,Vec2Dscreen**,int*,int)</code>
    /// </summary>
    /// <param name="side">Specifies which side of the polygon to consider when clipping (e.g., front or back).</param>
    /// <param name="ppoly">The source polygon whose vertices will be transformed and potentially clipped.</param>
    /// <param name="clip_view">Receives pointers to the screen‑space points that remain after clipping.</param>
    /// <param name="clip_pts">Receives the number of points stored in clip_view.</param>
    /// <param name="check">If non‑zero, performs clipping; otherwise simply copies the transformed points into clip_view.</param>
    public void GetClip(ACBindings.Internal.Sidedness side, ACBindings.Internal.CPolygon* ppoly, ACBindings.Internal.Vec2Dscreen** clip_view, int* clip_pts, int check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.Sidedness, ACBindings.Internal.CPolygon*, ACBindings.Internal.Vec2Dscreen**, int*, int, void>)0x005A5430)(ref this, side, ppoly, clip_view, clip_pts, check);

    /// <summary>Draws all cells of the view by rendering landscape, portal geometry and cell surfaces while managing lighting and alpha blending.
    /// <code>Offset: 0x005A5950
    /// void __thiscall PView::DrawCells(PView*,int)</code>
    /// </summary>
    /// <param name="from_outside">Flag indicating whether to start drawing from an outside perspective (currently unused).</param>
    public void DrawCells(int from_outside) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, int, void>)0x005A5950)(ref this, from_outside);

    /// <summary>Prepares a portal view for rendering by evaluating which portals are visible from the current viewpoint, setting visibility flags, and computing the maximum distance to any portal within the cell.
    /// <code>Offset: 0x005A5C80
    /// int __thiscall PView::InitCell(PView*,CEnvCell*,unsigned __int16)</code>
    /// </summary>
    /// <param name="cell">The environment cell whose portals are being processed.</param>
    /// <param name="portal_in">Index of a portal that should be treated as seen when encountered during processing; used for special cases such as forced entry portals.</param>
    /// <returns>Returns 1 if the view was successfully initialized, or 0 if no views were available (view_count is zero).</returns>
    public int InitCell(ACBindings.Internal.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ushort, int>)0x005A5C80)(ref this, cell, portal_in);

    /// <summary>Updates rendering state for a cell by marking the specified portal as entered and ensuring all other portals in its most recent portal view are marked as seen.
    /// <code>Offset: 0x005A5EA0
    /// void __thiscall PView::AddToCell(PView*,CEnvCell*,unsigned __int16)</code>
    /// </summary>
    /// <param name="cell">The environment cell whose portal view is being updated.</param>
    /// <param name="portal_in">Index of the portal within the cell to mark as entered.</param>
    public void AddToCell(ACBindings.Internal.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ushort, void>)0x005A5EA0)(ref this, cell, portal_in);

    /// <summary>Marks the adjacent cell’s portal as seen for this view, establishing a back‑reference from the other side if it has not yet been set.
    /// <code>Offset: 0x005A5F40
    /// void __thiscall PView::SetOtherSeen(PView*,CEnvCell*,unsigned int)</code>
    /// </summary>
    /// <param name="pres_cell">The environment cell containing the portal being examined.</param>
    /// <param name="portal_id">The index of that portal within the cell’s portal array.</param>
    public void SetOtherSeen(ACBindings.Internal.CEnvCell* pres_cell, uint portal_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, uint, void>)0x005A5F40)(ref this, pres_cell, portal_id);

    /// <summary>Replaces a specified cell in the view's draw list with another cell, but only when the new cell is not already present in the list.
    /// <code>Offset: 0x005A5FA0
    /// int __thiscall PView::AdjustDrawList(PView*,CEnvCell*,CEnvCell*)</code>
    /// </summary>
    /// <param name="cell_in_list">The existing cell that should be replaced.</param>
    /// <param name="new_cell">The cell to insert into the draw list in place of <c>cell_in_list</c>.</param>
    /// <returns>Returns 1 when the replacement occurs; returns 0 if the new cell is already in the list or if the specified old cell cannot be found.</returns>
    public int AdjustDrawList(ACBindings.Internal.CEnvCell* cell_in_list, ACBindings.Internal.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ACBindings.Internal.CEnvCell*, int>)0x005A5FA0)(ref this, cell_in_list, new_cell);

    /// <summary>Adds the specified cell and its distance to the view's todo list, expanding the list if necessary and inserting the entry in ascending order of distance.
    /// <code>Offset: 0x005A6060
    /// void __thiscall PView::InsCellTodoList(PView*,CEnvCell*,float)</code>
    /// </summary>
    /// <param name="cell">The environment cell to schedule for processing.</param>
    /// <param name="dist">The distance associated with the cell, used for ordering.</param>
    public void InsCellTodoList(ACBindings.Internal.CEnvCell* cell, float dist) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, float, void>)0x005A6060)(ref this, cell, dist);

    /// <summary>Updates the rendering order for a given cell and propagates changes to neighboring cells connected by portals that meet specific visibility criteria.
    /// <code>Offset: 0x005A6120
    /// void __thiscall PView::AdjustCellPlace(PView*,CEnvCell*,CEnvCell*)</code>
    /// </summary>
    /// <param name="cell_in_list">The source cell currently in the view list.</param>
    /// <param name="new_cell">The target cell whose placement is being updated.</param>
    public void AdjustCellPlace(ACBindings.Internal.CEnvCell* cell_in_list, ACBindings.Internal.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ACBindings.Internal.CEnvCell*, void>)0x005A6120)(ref this, cell_in_list, new_cell);

    /// <summary>
    /// Releases all resources owned by a PView instance, including cell lists, drawing buffers, vertex and polygon data, and portal information. Invokes cleanup callbacks for each allocated DiskSpace object before deallocating the vertex array.
    /// 
    /// <code>Offset: 0x005A6280
    /// void __thiscall PView::~PView(PView*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, void>)0x005A6280)(ref this);

    /// <summary>Adds visible environment cells referenced by a list of identifiers to the current view stack.
    /// <code>Offset: 0x005A6320
    /// void __thiscall PView::add_views(PView*,unsigned __int16,unsigned int*)</code>
    /// </summary>
    /// <param name="num_stabs">The count of identifiers in stab_list.</param>
    /// <param name="stab_list">Array containing identifiers for environment cells to be added as views if they are visible.</param>
    public void add_views(ushort num_stabs, uint* stab_list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ushort, uint*, void>)0x005A6320)(ref this, num_stabs, stab_list);

    /// <summary>Synchronizes the view’s internal cell lists after a cell has been moved or its visibility status changed.
    /// <code>Offset: 0x005A6360
    /// void __thiscall PView::FixCellList(PView*,CEnvCell*,CEnvCell*)</code>
    /// </summary>
    /// <param name="cell_in_list">The cell whose list entry requires updating.</param>
    /// <param name="new_cell">The destination cell used for recalculating placement; can be null if the cell is removed from the view.</param>
    public void FixCellList(ACBindings.Internal.CEnvCell* cell_in_list, ACBindings.Internal.CEnvCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ACBindings.Internal.CEnvCell*, void>)0x005A6360)(ref this, cell_in_list, new_cell);

    /// <summary>Initializes a PView instance, setting up portal view structures and cell lists with default capacities and assigning the landscape drawing flag.
    /// <code>Offset: 0x005A6380
    /// void __thiscall PView::PView(PView*,int)</code>
    /// </summary>
    /// <param name="draw_lscape">Specifies whether the landscape should be drawn when rendering this view.</param>
    public void _ConstructorInternal(int draw_lscape) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, int, void>)0x005A6380)(ref this, draw_lscape);

    /// <summary>Propagates a rendering view from this PView to adjacent cells across portals, updating portal view counts and initializing neighboring cells as required.
    /// <code>Offset: 0x005A63E0
    /// void __thiscall PView::AddViewToPortals(PView*,CEnvCell*)</code>
    /// </summary>
    /// <param name="pres_cell">The cell whose portal connections are processed.</param>
    public void AddViewToPortals(ACBindings.Internal.CEnvCell* pres_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, void>)0x005A63E0)(ref this, pres_cell);

    /// <summary>Computes the screen‑space clipping polygon for a portal into its adjacent cell and stores the result in the provided buffers.
    /// <code>Offset: 0x005A6510
    /// int __thiscall PView::OtherPortalClip(PView*,CCellPortal*,Vec2Dscreen**,int*)</code>
    /// </summary>
    /// <param name="portal">The portal whose view should be clipped.</param>
    /// <param name="clip_view">Output array that receives the projected vertex coordinates of the clipped view.</param>
    /// <param name="clip_pts">Input/output parameter indicating the size of clip_view on entry and receiving the number of points produced.</param>
    /// <returns>Non‑zero if at least one clipping point was generated; zero otherwise or if the initial view copy failed.</returns>
    public int OtherPortalClip(ACBindings.Internal.CCellPortal* portal, ACBindings.Internal.Vec2Dscreen** clip_view, int* clip_pts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CCellPortal*, ACBindings.Internal.Vec2Dscreen**, int*, int>)0x005A6510)(ref this, portal, clip_view, clip_pts);

    /// <summary>Clips the portals of a given environment cell for rendering, generating per-view clipped polygons stored in the cell’s portal_view list.
    /// <code>Offset: 0x005A6630
    /// int __thiscall PView::ClipPortals(PView*,CEnvCell*,unsigned int)</code>
    /// </summary>
    /// <param name="pres_cell">Environment cell whose portals are processed.</param>
    /// <param name="first_view">Starting view index used when iterating over available views.</param>
    /// <returns>Non‑zero if at least one portal was visible and clipped; zero otherwise.</returns>
    public int ClipPortals(ACBindings.Internal.CEnvCell* pres_cell, uint first_view) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, uint, int>)0x005A6630)(ref this, pres_cell, first_view);

    /// <summary>Adjusts portal visibility for a cell by clipping its portals and adding the cell to active portal view lists.
    /// <code>Offset: 0x005A6880
    /// void __thiscall PView::AdjustCellView(PView*,CEnvCell*)</code>
    /// </summary>
    /// <param name="pres_cell">The environment cell whose view should be updated.</param>
    public void AdjustCellView(ACBindings.Internal.CEnvCell* pres_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, void>)0x005A6880)(ref this, pres_cell);

    /// <summary>Builds the rendering view hierarchy starting from a specified environment cell and propagates through connected portals to populate draw and todo lists.
    /// <code>Offset: 0x005A68C0
    /// void __thiscall PView::ConstructView(PView*,CEnvCell*,unsigned __int16)</code>
    /// </summary>
    /// <param name="cell">The starting environment cell for view construction.</param>
    /// <param name="portal_in">Index of the portal used to enter the cell, or 0 if entering directly.</param>
    public void ConstructView(ACBindings.Internal.CEnvCell* cell, ushort portal_in) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, ushort, void>)0x005A68C0)(ref this, cell, portal_in);

    /// <summary>Draws the interior of an environment cell within the current portal view, configuring rendering state and invoking child cell drawing routines.
    /// <code>Offset: 0x005A6970
    /// void __thiscall PView::DrawInside(PView*,CEnvCell*)</code>
    /// </summary>
    /// <param name="cell">The environment cell to render inside the current view.</param>
    public void DrawInside(ACBindings.Internal.CEnvCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CEnvCell*, void>)0x005A6970)(ref this, cell);

    /// <summary>Constructs a view from the perspective of an external portal by clipping the supplied polygon against the current camera frustum, copying visible cell data, optionally rendering the portal polygon, and recursing into adjacent cells unless instructed otherwise.
    /// <code>Offset: 0x005A6AB0
    /// int __thiscall PView::ConstructView(PView*,CBldPortal*,CPolygon*,int,int)</code>
    /// </summary>
    /// <param name="outside_portal">Portal through which the view is constructed; its side determines whether the polygon should be drawn in the current orientation.</param>
    /// <param name="ppoly">Polygon to clip and render as part of the new view.</param>
    /// <param name="check">Flag influencing how the polygon is clipped in GetClip.</param>
    /// <param name="portalPolyOrPortalContents">
    ///   Mode value:
    ///   <c>1</c> – render only the portal polygon and do not recurse into adjacent cells;  
    ///   <c>2</c> – skip rendering the portal polygon but continue recursion;  
    ///   any other value – render the portal polygon and continue recursion.
    /// </param>
    /// <returns>Non‑zero if the view was successfully constructed and rendered; zero on failure or when clipping removes the polygon.</returns>
    public int ConstructView(ACBindings.Internal.CBldPortal* outside_portal, ACBindings.Internal.CPolygon* ppoly, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CBldPortal*, ACBindings.Internal.CPolygon*, int, int, int>)0x005A6AB0)(ref this, outside_portal, ppoly, check, portalPolyOrPortalContents);

    /// <summary>Renders an outdoor portal by configuring rendering state, adding sub‑views from the portal’s stabs, building a view using the portal geometry, and drawing the portal’s contents based on supplied mode flags.
    /// <code>Offset: 0x005A6BC0
    /// void __thiscall PView::DrawPortal(PView*,CPortalPoly*,int,int)</code>
    /// </summary>
    /// <param name="portal">Portal definition containing an index into the view's outdoor portal list and a pointer to its polygon geometry.</param>
    /// <param name="check">Flag forwarded to ConstructView that influences how the view is built (e.g., validation or rendering options).</param>
    /// <param name="portalPolyOrPortalContents">Mode selector: when 1, cell rendering is skipped; otherwise cells are rendered. If view construction fails and this flag equals 3, the portal’s internal polygon is drawn directly.</param>
    public void DrawPortal(ACBindings.Internal.CPortalPoly* portal, int check, int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PView, ACBindings.Internal.CPortalPoly*, int, int, void>)0x005A6BC0)(ref this, portal, check, portalPolyOrPortalContents);
}

