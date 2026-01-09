namespace ACBindings;

// CCylSphere
public unsafe struct CCylSphere
{
    // Members
    public ACBindings.AC1Legacy.Vector3 low_pt;
    public float height;
    public float radius;

    // Generated Constructor
    public CCylSphere() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CCylSphere::collides_with_sphere(CCylSphere*,const CSphere*,const AC1Legacy::Vector3*,const float)
    public int collides_with_sphere(ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, int>)0x0053B5E0)(ref this, check_pos, disp, radsum);
    // void __thiscall CCylSphere::CCylSphere(CCylSphere*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, void>)0x0053B640)(ref this);
    // unsigned int __thiscall CCylSphere::Pack(CCylSphere*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, void**, uint, uint>)0x0053B660)(ref this, addr, size);
    // int __thiscall CCylSphere::UnPack(CCylSphere*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, void**, uint, int>)0x0053B6C0)(ref this, addr, size);
    // TransitionState __thiscall CCylSphere::step_sphere_down(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState step_sphere_down(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x0053B710)(ref this, object_, path, collisions, check_pos, disp, radsum);
    // int __thiscall CCylSphere::normal_of_collision(CCylSphere*,SPHEREPATH*,const CSphere*,const AC1Legacy::Vector3*,float,int,AC1Legacy::Vector3*)
    public int normal_of_collision(ACBindings.SPHEREPATH* path, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum, int sphere_num, ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, int, ACBindings.AC1Legacy.Vector3*, int>)0x0053B8B0)(ref this, path, check_pos, disp, radsum, sphere_num, normal);
    // TransitionState __thiscall CCylSphere::collide_with_point(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float,int)
    public ACBindings.TransitionState collide_with_point(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, int, ACBindings.TransitionState>)0x0053BA10)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);
    // TransitionState __thiscall CCylSphere::slide_sphere(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,float,int)
    public ACBindings.TransitionState slide_sphere(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, int, ACBindings.TransitionState>)0x0053C000)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);
    // TransitionState __thiscall CCylSphere::step_sphere_up(CCylSphere*,CTransition*,const CSphere*,const AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState step_sphere_up(ACBindings.CTransition* transition, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.CTransition*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x0053C070)(ref this, transition, check_pos, disp, radsum);
    // TransitionState __thiscall CCylSphere::land_on_cylinder(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState land_on_cylinder(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x0053C130)(ref this, object_, path, collisions, check_pos, disp, radsum);
    // TransitionState __thiscall CCylSphere::intersects_sphere(CCylSphere*,CTransition*)
    public ACBindings.TransitionState intersects_sphere(ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.CTransition*, ACBindings.TransitionState>)0x0053C1A0)(ref this, transition);
    // TransitionState __thiscall CCylSphere::intersects_sphere(CCylSphere*,const Position*,float,CTransition*)
    public ACBindings.TransitionState intersects_sphere(ACBindings.Position* p, float scale, ACBindings.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCylSphere, ACBindings.Position*, float, ACBindings.CTransition*, ACBindings.TransitionState>)0x0053C650)(ref this, p, scale, transition);
}

