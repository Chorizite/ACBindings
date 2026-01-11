namespace ACBindings.Internal;

public unsafe struct BSPTREE : System.IDisposable
{
    // Members
    public ACBindings.Internal.BSPNODE* root_node;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053A540
    /// const CSphere* __thiscall BSPTREE::GetSphere(BSPTREE*)</code>
    /// </summary>
    public ACBindings.Internal.CSphere* GetSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CSphere*>)0x0053A540)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053A550
    /// unsigned int __thiscall BSPTREE::Pack(BSPTREE*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void**, uint, uint>)0x0053A550)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053A590
    /// int __thiscall BSPTREE::UnPack(BSPTREE*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void**, uint, int>)0x0053A590)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053A5C0
    /// void __thiscall BSPTREE::build_draw_portals_only(BSPTREE*,int)</code>
    /// </summary>
    public void build_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, int, void>)0x0053A5C0)(ref this, portalPolyOrPortalContents);

    /// <summary>
    /// <code>Offset: 0x0053A6A0
    /// void __thiscall BSPTREE::~BSPTREE(BSPTREE*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void>)0x0053A6A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053A6C0
    /// TransitionState __thiscall BSPTREE::placement_insert(BSPTREE*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState placement_insert(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0053A6C0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0053A950
    /// int __thiscall BSPTREE::adjust_to_plane(BSPTREE*,CSphere*,const AC1Legacy::Vector3,const CPolygon*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int adjust_to_plane(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3 curr_pos, ACBindings.Internal.CPolygon* hit_poly, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3, ACBindings.Internal.CPolygon*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053A950)(ref this, check_pos, curr_pos, hit_poly, contact_pt);

    /// <summary>
    /// <code>Offset: 0x0053ABB0
    /// TransitionState __thiscall BSPTREE::slide_sphere(BSPTREE*,SPHEREPATH*,COLLISIONINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.TransitionState>)0x0053ABB0)(ref this, path, collisions, collision_normal);

    /// <summary>
    /// <code>Offset: 0x0053AC30
    /// TransitionState __thiscall BSPTREE::check_walkable(BSPTREE*,SPHEREPATH*,const CSphere*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState check_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* check_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, float, ACBindings.Internal.TransitionState>)0x0053AC30)(ref this, path, check_pos, scale);

    /// <summary>
    /// <code>Offset: 0x0053AC80
    /// TransitionState __thiscall BSPTREE::step_sphere_up(BSPTREE*,CTransition*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_sphere_up(ACBindings.Internal.CTransition* transition, ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CTransition*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.TransitionState>)0x0053AC80)(ref this, transition, collision_normal);

    /// <summary>
    /// <code>Offset: 0x0053ADA0
    /// void __thiscall BSPTREE::RemoveNonPortalNodes(BSPTREE*)</code>
    /// </summary>
    public void RemoveNonPortalNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void>)0x0053ADA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053ADF0
    /// TransitionState __thiscall BSPTREE::collide_with_pt(BSPTREE*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState collide_with_pt(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* curr_pos, ACBindings.Internal.CPolygon* hit_poly, ACBindings.Internal.AC1Legacy.Vector3* contact_pt, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053ADF0)(ref this, object_, path, collisions, check_pos, curr_pos, hit_poly, contact_pt, scale);

    /// <summary>
    /// <code>Offset: 0x0053AF70
    /// TransitionState __thiscall BSPTREE::step_sphere_down(BSPTREE*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_sphere_down(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, float, ACBindings.Internal.TransitionState>)0x0053AF70)(ref this, path, collisions, check_pos, scale);

    /// <summary>
    /// <code>Offset: 0x0053B1A0
    /// TransitionState __thiscall BSPTREE::find_collisions(BSPTREE*,CTransition*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CTransition*, float, ACBindings.Internal.TransitionState>)0x0053B1A0)(ref this, transition, scale);
}

