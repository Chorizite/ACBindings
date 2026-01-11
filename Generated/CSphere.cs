namespace ACBindings.Internal;

public unsafe struct CSphere
{
    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 center;
    public float radius;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00520830
    /// int __thiscall CSphere::UnPack(CSphere*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, void**, uint, int>)0x00520830)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005351E0
    /// int __thiscall CSphere::intersects(CSphere*,const CSphere*)</code>
    /// </summary>
    public int intersects(ACBindings.Internal.CSphere* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.CSphere*, int>)0x005351E0)(ref this, s);

    /// <summary>
    /// <code>Offset: 0x00537630
    /// long double __thiscall CSphere::find_time_of_collision(CSphere*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    public double find_time_of_collision(ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, float, double>)0x00537630)(ref this, movement, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x00537720
    /// int __thiscall CSphere::collides_with_sphere(CSphere*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    public int collides_with_sphere(ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.AC1Legacy.Vector3*, float, int>)0x00537720)(ref this, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x005377F0
    /// unsigned int __cdecl CSphere::attack(const Position*,const float,const float,const Position*,const Vec2D*,const Vec2D*,const float,const float)</code>
    /// </summary>
    public static uint attack(ACBindings.Internal.Position* target_pos, float target_radius, float target_height, ACBindings.Internal.Position* attack_pos, ACBindings.Internal.Vec2D* left, ACBindings.Internal.Vec2D* right, float attackrad, float attackht) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, float, float, ACBindings.Internal.Position*, ACBindings.Internal.Vec2D*, ACBindings.Internal.Vec2D*, float, float, uint>)0x005377F0)(target_pos, target_radius, target_height, attack_pos, left, right, attackrad, attackht);

    /// <summary>
    /// <code>Offset: 0x00537A60
    /// TransitionState __thiscall CSphere::step_sphere_down(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_sphere_down(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x00537A60)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x00537C80
    /// TransitionState __thiscall CSphere::slide_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x00537C80)(ref this, object_, path, collisions, disp, radsum, sphere_num);

    /// <summary>
    /// <code>Offset: 0x00537F70
    /// TransitionState __thiscall CSphere::collide_with_point(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState collide_with_point(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x00537F70)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);

    /// <summary>
    /// <code>Offset: 0x00538180
    /// TransitionState __thiscall CSphere::slide_sphere(CSphere*,SPHEREPATH*,COLLISIONINFO*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.AC1Legacy.Vector3* collision_normal, ACBindings.Internal.AC1Legacy.Vector3* curr_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.TransitionState>)0x00538180)(ref this, path, collisions, collision_normal, curr_pos);

    /// <summary>
    /// <code>Offset: 0x005384E0
    /// bool __thiscall CSphere::sphere_intersects_ray(CSphere*,const Ray*,long double*)</code>
    /// </summary>
    public byte sphere_intersects_ray(ACBindings.Internal.Ray* ray, double* o_fTimeOfIntersection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.Ray*, double*, byte>)0x005384E0)(ref this, ray, o_fTimeOfIntersection);

    /// <summary>
    /// <code>Offset: 0x00538640
    /// TransitionState __thiscall CSphere::step_sphere_up(CSphere*,CTransition*,const CSphere*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_sphere_up(ACBindings.Internal.CTransition* transition, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.CTransition*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x00538640)(ref this, transition, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x005386E0
    /// TransitionState __thiscall CSphere::land_on_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState land_on_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x005386E0)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x00538750
    /// TransitionState __thiscall CSphere::slide_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float*,const int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float* radsum, int sphere_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float*, int, ACBindings.Internal.TransitionState>)0x00538750)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_number);

    /// <summary>
    /// <code>Offset: 0x005387C0
    /// TransitionState __thiscall CSphere::intersects_sphere(CSphere*,CTransition*,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.CTransition* transition, int is_creature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.CTransition*, int, ACBindings.Internal.TransitionState>)0x005387C0)(ref this, transition, is_creature);

    /// <summary>
    /// <code>Offset: 0x00538D10
    /// TransitionState __thiscall CSphere::intersects_sphere(CSphere*,const Position*,float,CTransition*,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.Position* p, float scale, ACBindings.Internal.CTransition* transition, int is_creature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.Position*, float, ACBindings.Internal.CTransition*, int, ACBindings.Internal.TransitionState>)0x00538D10)(ref this, p, scale, transition, is_creature);
}

