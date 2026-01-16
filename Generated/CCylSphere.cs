namespace ACBindings.Internal;


/// <summary>Represents a cylindrical sphere used for collision detection and physics calculations. Stores the cylinder's low point coordinates, height, and radius to define its position and size in space.</summary>
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

    /// <summary>Determines whether a cylinder and sphere intersect by comparing the squared radial distance to a radius sum and checking vertical overlap.
    /// <code>Offset: 0x0053B5E0
    /// int __thiscall CCylSphere::collides_with_sphere(CCylSphere*,const CSphere*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    /// <param name="check_pos">The sphere to test against the cylinder.</param>
    /// <param name="disp">Displacement vector from the cylinder’s origin to the sphere’s center.</param>
    /// <param name="radsum">Sum of the cylinder’s effective radius and the sphere’s radius used for the horizontal collision check.</param>
    /// <returns>Non‑zero if a collision occurs; zero otherwise.</returns>
    public int collides_with_sphere(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int>)0x0053B5E0)(ref this, check_pos, disp, radsum);

    /// <summary>Initializes a cylindrical sphere's low point to the origin and sets its height and radius to zero.
    /// <code>Offset: 0x0053B640
    /// void __thiscall CCylSphere::CCylSphere(CCylSphere*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, void>)0x0053B640)(ref this);

    /// <summary>Serializes a CCylSphere into a 20‑byte binary representation consisting of low point coordinates, radius, and height.
    /// <code>Offset: 0x0053B660
    /// unsigned int __thiscall CCylSphere::Pack(CCylSphere*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in a buffer. If the buffer contains at least 20 bytes, the function writes the data starting at *addr and updates it to point past the last byte written; otherwise no write occurs.</param>
    /// <param name="size">Number of bytes available from the current address in the destination buffer.</param>
    /// <returns>Always returns 20, the size of the serialized representation.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, void**, uint, uint>)0x0053B660)(ref this, addr, size);

    /// <summary>Deserializes a CCylSphere from binary data by reading the low point (x, y, z), radius, and height, while advancing the input pointer accordingly.
    /// <code>Offset: 0x0053B6C0
    /// int __thiscall CCylSphere::UnPack(CCylSphere*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer position; updated to point after the consumed bytes.</param>
    /// <param name="size">Number of bytes remaining in the buffer for the low point data. If fewer than 12, the low point is skipped.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, void**, uint, int>)0x0053B6C0)(ref this, addr, size);

    /// <summary>Attempts to move a cylindrical sphere downward along a defined path, checking for collisions and updating contact plane information. Returns a TransitionState indicating whether the movement succeeded or was blocked.
    /// <code>Offset: 0x0053B710
    /// TransitionState __thiscall CCylSphere::step_sphere_down(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="object">Object metadata including state and step heights used during the transition.</param>
    /// <param name="path">Path data describing the sphere trajectory and step characteristics.</param>
    /// <param name="collisions">Collision structure to receive updated contact plane information.</param>
    /// <param name="check_pos">Sphere representing the current position used for collision checks.</param>
    /// <param name="disp">Displacement vector applied during collision testing.</param>
    /// <param name="radsum">Sum of radii threshold used in collision detection.</param>
    /// <returns>TransitionState value (1, 2, or 3) indicating the result of the step attempt.</returns>
    public ACBindings.Internal.TransitionState step_sphere_down(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053B710)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>Computes a collision normal for this cylinder-sphere against a target sphere defined by path data, storing the result in normal and indicating whether a valid collision was detected.
    /// <code>Offset: 0x0053B8B0
    /// int __thiscall CCylSphere::normal_of_collision(CCylSphere*,SPHEREPATH*,const CSphere*,const AC1Legacy::Vector3*,float,int,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="path">Path containing positions of spheres along the cylinder's sweep.</param>
    /// <param name="check_pos">Sphere used to test overlap with this cylinder-sphere.</param>
    /// <param name="disp">Displacement applied during collision detection.</param>
    /// <param name="radsum">Sum of radii for distance checks between sphere centers.</param>
    /// <param name="sphere_num">Index into path->global_curr_center indicating which sphere to evaluate.</param>
    /// <param name="normal">Output vector set to the computed collision normal.</param>
    /// <returns>Non‑zero if a collision normal was produced; zero otherwise.</returns>
    public int normal_of_collision(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num, ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053B8B0)(ref this, path, check_pos, disp, radsum, sphere_num, normal);

    /// <summary>Evaluates and resolves collision between a cylindrical object and a spherical point, computing the collision normal, applying displacement if needed, and updating collision information.
    /// <code>Offset: 0x0053BA10
    /// TransitionState __thiscall CCylSphere::collide_with_point(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    /// <param name="object">Information about the entity being checked for collision.</param>
    /// <param name="path">Data describing the sphere’s movement path and environmental context.</param>
    /// <param name="collisions">Container to store resulting collision normals and related state.</param>
    /// <param name="check_pos">Sphere used as the point of collision detection against the cylinder.</param>
    /// <param name="disp">Displacement vector applied when a collision occurs.</param>
    /// <param name="radsum">Sum of radii used to define the collision tolerance.</param>
    /// <param name="sphere_num">Index of the sphere along the movement path.</param>
    /// <returns>TransitionState value indicating whether a transition (3) or no collision (2) was detected.</returns>
    public ACBindings.Internal.TransitionState collide_with_point(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x0053BA10)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);

    /// <summary>Slides a sphere along a defined path while accounting for collision normals and returns the resulting transition state.
    /// <code>Offset: 0x0053C000
    /// TransitionState __thiscall CCylSphere::slide_sphere(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    /// <param name="object">Information about the physics object involved in the slide, including its scale and step parameters.</param>
    /// <param name="path">Represents the sphere’s trajectory and environmental data used to compute sliding behavior.</param>
    /// <param name="collisions">Holds contact planes, normals, and collided objects relevant to the current slide operation.</param>
    /// <param name="check_pos">The sphere whose position is being updated through the slide calculation.</param>
    /// <param name="disp">Displacement vector applied to the sphere before collision response is determined.</param>
    /// <param name="radsum">Combined radius of the cylinder and sphere used for collision detection.</param>
    /// <param name="sphere_num">Index identifying which sphere within the path’s array is currently being processed.</param>
    /// <returns>A TransitionState value; returns 2 if the computed normal is too small to allow sliding, otherwise forwards the result from CSphere::slide_sphere.</returns>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x0053C000)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);

    /// <summary>Attempts to lift the cylindrical sphere along a transition path, performing collision checks and falling back to sliding when the step‑up is infeasible.
    /// <code>Offset: 0x0053C070
    /// TransitionState __thiscall CCylSphere::step_sphere_up(CCylSphere*,CTransition*,const CSphere*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="this">The cylindrical sphere being moved.</param>
    /// <param name="transition">Context containing object information, the sphere path, collision data, and cell references.</param>
    /// <param name="check_pos">Sphere used for collision checking against the transition geometry.</param>
    /// <param name="disp">Local‑space displacement vector applied during the step‑up attempt.</param>
    /// <param name="radsum">Sum of the radii involved in the collision normal calculation.</param>
    /// <returns>TransitionState value: 0 when sliding occurs, 1 when a successful upward step is performed, and 2 when the computed collision normal is invalid or too small.</returns>
    public ACBindings.Internal.TransitionState step_sphere_up(ACBindings.Internal.CTransition* transition, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.CTransition*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053C070)(ref this, transition, check_pos, disp, radsum);

    /// <summary>Calculates a collision normal for an object landing on a cylindrical surface, updates the sphere path with this normal and a walkable allowance, and returns a transition state.
    /// <code>Offset: 0x0053C130
    /// TransitionState __thiscall CCylSphere::land_on_cylinder(CCylSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="object">Physics information for the object attempting to land.</param>
    /// <param name="path">Sphere path data updated with the calculated collision normal.</param>
    /// <param name="collisions">Collision context; not used in this routine.</param>
    /// <param name="check_pos">Position of the sphere at contact, used as a reference point.</param>
    /// <param name="disp">Displacement vector applied during calculation.</param>
    /// <param name="radsum">Sum of relevant radii for normal computation.</param>
    /// <returns>TransitionState value (2 if the normal could not be normalized; 3 if the collision normal was successfully set).</returns>
    public ACBindings.Internal.TransitionState land_on_cylinder(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053C130)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>Determines whether the cylinder intersects spheres defined in a transition path and performs appropriate collision resolution based on the transition's configuration. Returns a TransitionState indicating how the intersection was handled.
    /// <code>Offset: 0x0053C1A0
    /// TransitionState __thiscall CCylSphere::intersects_sphere(CCylSphere*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Transition information containing sphere path, collision flags, and state data used for the intersection test.</param>
    /// <returns>TransitionState value representing the outcome of the intersection check (e.g., no collision, collision detected, stepped up/down, walked, etc.).</returns>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0053C1A0)(ref this, transition);

    /// <summary>Checks whether a scaled cylindrical sphere intersects the target sphere during a transition.
    /// <code>Offset: 0x0053C650
    /// TransitionState __thiscall CCylSphere::intersects_sphere(CCylSphere*,const Position*,float,CTransition*)</code>
    /// </summary>
    /// <param name="p">Position used to transform the cylinder's local coordinates into world space.</param>
    /// <param name="scale">Factor by which the cylinder's radius and height are multiplied before the intersection test.</param>
    /// <param name="transition">Transition data that contains the sphere path, collision information, and cell references for the check.</param>
    /// <returns>The resulting TransitionState indicating whether an intersection occurred.</returns>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.Position* p, float scale, ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCylSphere, ACBindings.Internal.Position*, float, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0053C650)(ref this, p, scale, transition);
}

