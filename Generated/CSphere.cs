namespace ACBindings;

// CSphere
public unsafe struct CSphere
{
    // Members
    public ACBindings.AC1Legacy.Vector3 center;
    public float radius;

    // Methods
    // int __thiscall CSphere::UnPack(CSphere*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, void**, uint, int>)0x00520830)(ref this, addr, size);
    // int __thiscall CSphere::intersects(CSphere*,const CSphere*)
    public int intersects(ACBindings.CSphere* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.CSphere*, int>)0x005351E0)(ref this, s);
    // long double __thiscall CSphere::find_time_of_collision(CSphere*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const float)
    public double find_time_of_collision(ACBindings.AC1Legacy.Vector3* movement, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, float, double>)0x00537630)(ref this, movement, disp, radsum);
    // int __thiscall CSphere::collides_with_sphere(CSphere*,const AC1Legacy::Vector3*,const float)
    public int collides_with_sphere(ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.AC1Legacy.Vector3*, float, int>)0x00537720)(ref this, disp, radsum);
    // unsigned int __cdecl CSphere::attack(const Position*,const float,const float,const Position*,const Vec2D*,const Vec2D*,const float,const float)
    public static uint attack(ACBindings.Position* target_pos, float target_radius, float target_height, ACBindings.Position* attack_pos, ACBindings.Vec2D* left, ACBindings.Vec2D* right, float attackrad, float attackht) => ((delegate* unmanaged[Cdecl]<ACBindings.Position*, float, float, ACBindings.Position*, ACBindings.Vec2D*, ACBindings.Vec2D*, float, float, uint>)0x005377F0)(target_pos, target_radius, target_height, attack_pos, left, right, attackrad, attackht);
    // TransitionState __thiscall CSphere::step_sphere_down(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState step_sphere_down(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x00537A60)(ref this, object_, path, collisions, check_pos, disp, radsum);
    // TransitionState __thiscall CSphere::slide_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const AC1Legacy::Vector3*,float,int)
    public ACBindings.TransitionState slide_sphere(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.AC1Legacy.Vector3*, float, int, ACBindings.TransitionState>)0x00537C80)(ref this, object_, path, collisions, disp, radsum, sphere_num);
    // TransitionState __thiscall CSphere::collide_with_point(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float,int)
    public ACBindings.TransitionState collide_with_point(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, int, ACBindings.TransitionState>)0x00537F70)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);
    // TransitionState __thiscall CSphere::slide_sphere(CSphere*,SPHEREPATH*,COLLISIONINFO*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.TransitionState slide_sphere(ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.AC1Legacy.Vector3* collision_normal, ACBindings.AC1Legacy.Vector3* curr_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.TransitionState>)0x00538180)(ref this, path, collisions, collision_normal, curr_pos);
    // bool __thiscall CSphere::sphere_intersects_ray(CSphere*,const Ray*,long double*)
    public byte sphere_intersects_ray(ACBindings.Ray* ray, double* o_fTimeOfIntersection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.Ray*, double*, byte>)0x005384E0)(ref this, ray, o_fTimeOfIntersection);
    // TransitionState __thiscall CSphere::step_sphere_up(CSphere*,CTransition*,const CSphere*,const AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState step_sphere_up(ACBindings.CTransition* transition, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.CTransition*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x00538640)(ref this, transition, check_pos, disp, radsum);
    // TransitionState __thiscall CSphere::land_on_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)
    public ACBindings.TransitionState land_on_sphere(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float, ACBindings.TransitionState>)0x005386E0)(ref this, object_, path, collisions, check_pos, disp, radsum);
    // TransitionState __thiscall CSphere::slide_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float*,const int)
    public ACBindings.TransitionState slide_sphere(ACBindings.OBJECTINFO* object_, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* disp, float* radsum, int sphere_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.OBJECTINFO*, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, float*, int, ACBindings.TransitionState>)0x00538750)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_number);
    // TransitionState __thiscall CSphere::intersects_sphere(CSphere*,CTransition*,int)
    public ACBindings.TransitionState intersects_sphere(ACBindings.CTransition* transition, int is_creature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.CTransition*, int, ACBindings.TransitionState>)0x005387C0)(ref this, transition, is_creature);
    // TransitionState __thiscall CSphere::intersects_sphere(CSphere*,const Position*,float,CTransition*,int)
    public ACBindings.TransitionState intersects_sphere(ACBindings.Position* p, float scale, ACBindings.CTransition* transition, int is_creature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSphere, ACBindings.Position*, float, ACBindings.CTransition*, int, ACBindings.TransitionState>)0x00538D10)(ref this, p, scale, transition, is_creature);
}

