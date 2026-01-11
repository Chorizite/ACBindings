namespace ACBindings.Internal;

public unsafe struct CCylSphere
{
    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 low_pt;
    public float height;
    public float radius;

    // Generated Constructor
    public CCylSphere() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053B5E0
    /// int __thiscall CCylSphere::collides_with_sphere(CCylSphere*,const CSphere*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    public int collides_with_sphere(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int>)0x0053B5E0)(ref this, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x0053B640
    /// void __thiscall CCylSphere::CCylSphere(CCylSphere*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, void>)0x0053B640)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053B660
    /// unsigned int __thiscall CCylSphere::Pack(CCylSphere*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, void**, uint, uint>)0x0053B660)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053B6C0
    /// int __thiscall CCylSphere::UnPack(CCylSphere*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, void**, uint, int>)0x0053B6C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053B710
    /// TransitionState __thiscall CCylSphere::step_sphere_down(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_sphere_down(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053B710)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x0053B8B0
    /// int __thiscall CCylSphere::normal_of_collision(CCylSphere*,SPHEREPATH*,const CSphere*,const AC1Legacy::Vector3*,float,int,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int normal_of_collision(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num, ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053B8B0)(ref this, path, check_pos, disp, radsum, sphere_num, normal);

    /// <summary>
    /// <code>Offset: 0x0053BA10
    /// TransitionState __thiscall CCylSphere::collide_with_point(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState collide_with_point(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x0053BA10)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);

    /// <summary>
    /// <code>Offset: 0x0053C000
    /// TransitionState __thiscall CCylSphere::slide_sphere(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x0053C000)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);

    /// <summary>
    /// <code>Offset: 0x0053C070
    /// TransitionState __thiscall CCylSphere::step_sphere_up(CCylSphere*,CTransition*,const CSphere*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_sphere_up(ACBindings.Internal.CTransition* transition, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.CTransition*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053C070)(ref this, transition, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x0053C130
    /// TransitionState __thiscall CCylSphere::land_on_cylinder(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState land_on_cylinder(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053C130)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>
    /// <code>Offset: 0x0053C1A0
    /// TransitionState __thiscall CCylSphere::intersects_sphere(CCylSphere*,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0053C1A0)(ref this, transition);

    /// <summary>
    /// <code>Offset: 0x0053C650
    /// TransitionState __thiscall CCylSphere::intersects_sphere(CCylSphere*,const Position*,float,CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.Position* p, float scale, ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.Position*, float, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0053C650)(ref this, p, scale, transition);
}

