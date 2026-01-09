namespace ACBindings;

// BSPTREE
public unsafe struct BSPTREE : System.IDisposable
{
    // Members
    public ACBindings.BSPNODE* root_node;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // const CSphere* __thiscall BSPTREE::GetSphere(BSPTREE*)
    public ACBindings.CSphere* GetSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.CSphere*>)0x0053A540)(ref this);
    // unsigned int __thiscall BSPTREE::Pack(BSPTREE*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, void**, uint, uint>)0x0053A550)(ref this, addr, size);
    // int __thiscall BSPTREE::UnPack(BSPTREE*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, void**, uint, int>)0x0053A590)(ref this, addr, size);
    // void __thiscall BSPTREE::build_draw_portals_only(BSPTREE*,int)
    public void build_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, int, void>)0x0053A5C0)(ref this, portalPolyOrPortalContents);
    // void __thiscall BSPTREE::~BSPTREE(BSPTREE*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, void>)0x0053A6A0)(ref this);
    // TransitionState __thiscall BSPTREE::placement_insert(BSPTREE*,CTransition*)
    public ACBindings.TransitionState placement_insert(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.CTransition*, ACBindings.TransitionState>)0x0053A6C0)(ref this, transition);
    // int __thiscall BSPTREE::adjust_to_plane(BSPTREE*,CSphere*,const AC1Legacy::Vector3,const CPolygon*,AC1Legacy::Vector3*)
    public int adjust_to_plane(ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3 curr_pos, ACBindings.CPolygon* hit_poly, ACBindings.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3, ACBindings.CPolygon*, ACBindings.AC1Legacy.Vector3*, int>)0x0053A950)(ref this, check_pos, curr_pos, hit_poly, contact_pt);
    // TransitionState __thiscall BSPTREE::slide_sphere(BSPTREE*,SPHEREPATH*,COLLISIONINFO*,const AC1Legacy::Vector3*)
    public ACBindings.TransitionState slide_sphere(ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.AC1Legacy.Vector3*, ACBindings.TransitionState>)0x0053ABB0)(ref this, path, collisions, collision_normal);
    // TransitionState __thiscall BSPTREE::check_walkable(BSPTREE*,SPHEREPATH*,const CSphere*,float)
    public ACBindings.TransitionState check_walkable(ACBindings.SPHEREPATH* path, ACBindings.CSphere* check_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.SPHEREPATH*, ACBindings.CSphere*, float, ACBindings.TransitionState>)0x0053AC30)(ref this, path, check_pos, scale);
    // TransitionState __thiscall BSPTREE::step_sphere_up(BSPTREE*,CTransition*,const AC1Legacy::Vector3*)
    public ACBindings.TransitionState step_sphere_up(ACBindings.CTransition* transition, ACBindings.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.CTransition*, ACBindings.AC1Legacy.Vector3*, ACBindings.TransitionState>)0x0053AC80)(ref this, transition, collision_normal);
    // void __thiscall BSPTREE::RemoveNonPortalNodes(BSPTREE*)
    public void RemoveNonPortalNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, void>)0x0053ADA0)(ref this);
    // TransitionState __thiscall BSPTREE::collide_with_pt(BSPTREE*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon*,AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState collide_with_pt(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* curr_pos, ACBindings.CPolygon* hit_poly, ACBindings.AC1Legacy.Vector3* contact_pt, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.CPolygon*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x0053ADF0)(ref this, object_, path, collisions, check_pos, curr_pos, hit_poly, contact_pt, scale);
    // TransitionState __thiscall BSPTREE::step_sphere_down(BSPTREE*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,float)
    public ACBindings.TransitionState step_sphere_down(ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, float, ACBindings.TransitionState>)0x0053AF70)(ref this, path, collisions, check_pos, scale);
    // TransitionState __thiscall BSPTREE::find_collisions(BSPTREE*,CTransition*,float)
    public ACBindings.TransitionState find_collisions(ACBindings.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPTREE, ACBindings.CTransition*, float, ACBindings.TransitionState>)0x0053B1A0)(ref this, transition, scale);
}

