namespace ACBindings.Internal;


/// <summary>Defines a sphere geometry with a center point and radius, used for spatial calculations such as collision detection or visibility checks.</summary>
public unsafe struct CSphere
{
    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 center;
    public float radius;

    // Methods

    /// <summary>Unpacks the sphere’s center coordinates (x, y, z) and radius from a binary buffer, advancing the supplied pointer as data is consumed.
    /// <code>Offset: 0x00520830
    /// int __thiscall CSphere::UnPack(CSphere*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the buffer; updated to point past the unpacked values.</param>
    /// <param name="size">Number of bytes remaining in the buffer; if at least 12 bytes are available the center coordinates are read, otherwise only the radius is read.</param>
    /// <returns>Always returns 1 indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, void**, uint, int>)0x00520830)(ref this, addr, size);

    /// <summary>Checks whether this sphere intersects with another sphere based on their centers and radii.
    /// <code>Offset: 0x005351E0
    /// int __thiscall CSphere::intersects(CSphere*,const CSphere*)</code>
    /// </summary>
    /// <param name="s">The sphere to compare against.</param>
    /// <returns>Non‑zero if the spheres intersect; zero otherwise.</returns>
    public int intersects(ACBindings.Internal.CSphere* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.CSphere*, int>)0x005351E0)(ref this, s);

    /// <summary>Determines the time until this sphere collides with another moving at a given relative velocity, based on their initial displacement and combined radii.
    /// <code>Offset: 0x00537630
    /// long double __thiscall CSphere::find_time_of_collision(CSphere*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    /// <param name="movement">Relative velocity vector between the two spheres.</param>
    /// <param name="disp">Initial displacement from this sphere’s center to the other sphere’s center.</param>
    /// <param name="radsum">Sum of both spheres’ radii.</param>
    /// <returns>Time until collision; returns a negative value if the spheres are already intersecting or will never collide.</returns>
    public double find_time_of_collision(ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, float, double>)0x00537630)(ref this, movement, disp, radsum);

    /// <summary>Returns an unspecified integer value due to reliance on an uninitialized variable.
    /// <code>Offset: 0x00537720
    /// int __thiscall CSphere::collides_with_sphere(CSphere*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    /// <param name="disp">Displacement vector between sphere centers (unused).</param>
    /// <param name="radsum">Sum of radii of both spheres (unused).</param>
    /// <returns>An integer whose value cannot be determined reliably; typically 0 or 1 depending on the stack state.</returns>
    public int collides_with_sphere(ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.AC1Legacy.Vector3*, float, int>)0x00537720)(ref this, disp, radsum);

    /// <summary>Determines whether an attack originating from a given position, radius, and height intersects a target sphere defined by its center, radius, and height, respecting directional bounds specified by left and right vectors. Returns a bitmask identifying the hit region; a value of 0 means no intersection.
    /// <code>Offset: 0x005377F0
    /// unsigned int __cdecl CSphere::attack(const Position*,const float,const float,const Position*,const Vec2D*,const Vec2D*,const float,const float)</code>
    /// </summary>
    /// <param name="target_pos">Position of the target's center.</param>
    /// <param name="target_radius">Radius of the target sphere.</param>
    /// <param name="target_height">Vertical extent (height) of the target.</param>
    /// <param name="attack_pos">Origin position of the attack.</param>
    /// <param name="left">Vector defining one angular boundary of the attack cone.</param>
    /// <param name="right">Vector defining the opposite angular boundary of the attack cone.</param>
    /// <param name="attackrad">Additional radial offset applied to the attack range.</param>
    /// <param name="attackht">Height coordinate of the attack relative to the target's base, used to constrain vertical hit zones.</param>
    /// <returns>Bitmask indicating the quadrant and height slice where the attack hits; 0 indicates no hit.</returns>
    public static uint attack(ACBindings.Internal.Position* target_pos, float target_radius, float target_height, ACBindings.Internal.Position* attack_pos, ACBindings.Internal.Vec2D* left, ACBindings.Internal.Vec2D* right, float attackrad, float attackht) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, float, float, ACBindings.Internal.Position*, ACBindings.Internal.Vec2D*, ACBindings.Internal.Vec2D*, float, float, uint>)0x005377F0)(target_pos, target_radius, target_height, attack_pos, left, right, attackrad, attackht);

    /// <summary>Steps a sphere downward along a path by adjusting its displacement vector based on collision checks and updates contact plane information. Returns a transition state indicating whether the step was skipped, failed due to insufficient distance, or performed with updated collision data.
    /// <code>Offset: 0x00537A60
    /// TransitionState __thiscall CSphere::step_sphere_down(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="object">Information about the moving object, including scale, step properties, and state flags.</param>
    /// <param name="path">Current sphere path data used for computing offsets and verifying step feasibility.</param>
    /// <param name="collisions">Structure that receives updated contact plane information when a downward step occurs.</param>
    /// <param name="check_pos">Reference sphere against which collision detection is performed.</param>
    /// <param name="disp">Displacement vector to be modified, representing the new offset after stepping down.</param>
    /// <param name="radsum">Sum of radii used in sphere-sphere collision checks during the step calculation.</param>
    /// <returns>TransitionState value indicating whether the step was ignored (1), aborted due to insufficient distance (2), or completed with updated collision data (3).</returns>
    public ACBindings.Internal.TransitionState step_sphere_down(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x00537A60)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>Slides a specific sphere along its current trajectory by applying collision response derived from contact planes and normals.
    /// <code>Offset: 0x00537C80
    /// TransitionState __thiscall CSphere::slide_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    /// <param name="object">Object data associated with movement context (may influence step logic).</param>
    /// <param name="path">Path structure containing the sphere’s global position, center, and related offset information.</param>
    /// <param name="collisions">Collision information providing a valid contact plane or last known plane used for sliding calculation.</param>
    /// <param name="disp">Desired displacement vector to attempt movement along.</param>
    /// <param name="radsum">Sum of radii used in collision checks; currently unused by the routine.</param>
    /// <param name="sphere_num">Index identifying which sphere within the path arrays is being slid.</param>
    /// <returns>TransitionState value: 4 indicates successful slide, 2 indicates failure due to invalid contact data or geometry.</returns>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x00537C80)(ref this, object_, path, collisions, disp, radsum, sphere_num);

    /// <summary>Detects whether the sphere collides with a target point or sphere while moving along a path, updates collision normals, and adjusts the check position when a valid collision time is found. When the object's state flag 0x40 is not set, it simply records the relative direction as the collision normal.
    /// <code>Offset: 0x00537F70
    /// TransitionState __thiscall CSphere::collide_with_point(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float,int)</code>
    /// </summary>
    /// <param name="object">Object information containing state flags that enable detailed collision detection.</param>
    /// <param name="path">Movement path data used to obtain sphere positions and offsets during traversal.</param>
    /// <param name="collisions">Structure populated with the resulting collision normal when a collision occurs.</param>
    /// <param name="check_pos">Target sphere or point against which collision is tested.</param>
    /// <param name="disp">Displacement vector (unused in this implementation).</param>
    /// <param name="radsum">Sum of radii plus a small epsilon used to compute collision tolerance.</param>
    /// <param name="sphere_num">Index into the path’s global current center array identifying the active sphere segment.</param>
    /// <returns>TransitionState code: 2 if no valid collision time is found; 3 if a collision is detected and the check position offset is updated accordingly.</returns>
    public ACBindings.Internal.TransitionState collide_with_point(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum, int sphere_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, int, ACBindings.Internal.TransitionState>)0x00537F70)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_num);

    /// <summary>Slides the sphere along a path while resolving collisions with environmental geometry, updating collision information and adjusting the check position based on the current contact plane or provided normal.
    /// <code>Offset: 0x00538180
    /// TransitionState __thiscall CSphere::slide_sphere(CSphere*,SPHEREPATH*,COLLISIONINFO*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="path">Holds the movement data, current cell/position, and accumulates offsets during sliding.</param>
    /// <param name="collisions">Structure into which the function writes updated collision normals and planes.</param>
    /// <param name="collision_normal">Input normal used for calculations; may be overwritten with a computed normal when necessary. If zeroed out, a special offset is applied instead.</param>
    /// <param name="curr_pos">Current position of the sphere or object being slid, used to compute displacement vectors.</param>
    /// <returns>Returns a TransitionState value indicating the outcome: 3 for a simple offset case, 4 for successful sliding with adjustment, or 2 when no further movement is possible or the normal was normalized.</returns>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.AC1Legacy.Vector3* collision_normal, ACBindings.Internal.AC1Legacy.Vector3* curr_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.TransitionState>)0x00538180)(ref this, path, collisions, collision_normal, curr_pos);

    /// <summary>Determines whether a ray intersects this sphere and returns the distance along the ray to the first intersection point via an out parameter.
    /// <code>Offset: 0x005384E0
    /// bool __thiscall CSphere::sphere_intersects_ray(CSphere*,const Ray*,long double*)</code>
    /// </summary>
    /// <param name="ray">Ray to test against the sphere.</param>
    /// <param name="o_fTimeOfIntersection">Receives the distance from the ray origin to the nearest intersection point when one exists.</param>
    /// <returns>True if the ray intersects the sphere; otherwise, false.</returns>
    public byte sphere_intersects_ray(ACBindings.Internal.Ray* ray, double* o_fTimeOfIntersection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.Ray*, double*, byte>)0x005384E0)(ref this, ray, o_fTimeOfIntersection);

    /// <summary>Attempts to lift the sphere upward by the supplied displacement while resolving collisions against the transition context. If the target height is below the step‑up limit, delegates to slide_sphere; otherwise computes a collision normal and performs either an immediate step‑up or a sliding fallback.
    /// <code>Offset: 0x00538640
    /// TransitionState __thiscall CSphere::step_sphere_up(CSphere*,CTransition*,const CSphere*,const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="this">The sphere instance being moved.</param>
    /// <param name="transition">Context containing object info, path, and collision data used during stepping.</param>
    /// <param name="check_pos">Reference sphere for potential collision checks (unused in this implementation).</param>
    /// <param name="disp">Displacement vector applied to the sphere during the step‑up attempt.</param>
    /// <param name="radsum">Sum of radii influencing the step‑up calculation.</param>
    /// <returns>TransitionState indicating whether the sphere stepped up, slid, or failed to move.</returns>
    public ACBindings.Internal.TransitionState step_sphere_up(ACBindings.Internal.CTransition* transition, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.CTransition*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x00538640)(ref this, transition, check_pos, disp, radsum);

    /// <summary>Computes a collision normal from the sphere’s center to the current global position along a path, updates the path with this normal and sets a small walkable allowance, then returns a TransitionState code.
    /// <code>Offset: 0x005386E0
    /// TransitionState __thiscall CSphere::land_on_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="this">Sphere instance performing the landing calculation.</param>
    /// <param name="object">Object information; not used in this implementation.</param>
    /// <param name="path">Path structure that is updated with collision data.</param>
    /// <param name="collisions">Collision information; not used here.</param>
    /// <param name="check_pos">Reference sphere for checking; unused.</param>
    /// <param name="disp">Displacement vector output; unused.</param>
    /// <param name="radsum">Sum of radii; unused in this function.</param>
    /// <returns>2 if the computed collision normal is too small to normalize; otherwise 3 after updating the path.</returns>
    public ACBindings.Internal.TransitionState land_on_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float radsum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x005386E0)(ref this, object_, path, collisions, check_pos, disp, radsum);

    /// <summary>Calculates a collision normal between the current sphere and a target position on a path; returns early if the normal is too small, otherwise forwards the calculation to another slide_sphere overload that performs the actual sliding logic.
    /// <code>Offset: 0x00538750
    /// TransitionState __thiscall CSphere::slide_sphere(CSphere*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,AC1Legacy::Vector3*,float*,const int)</code>
    /// </summary>
    /// <param name="this">The sphere whose movement is being computed.</param>
    /// <param name="object">Physics object information associated with the operation (not used in this overload).</param>
    /// <param name="path">Path data containing current sphere positions; provides the target center via global_curr_center[sphere_number].</param>
    /// <param name="collisions">Collision information passed to the nested slide_sphere call.</param>
    /// <param name="check_pos">Reference sphere used for collision checks in the delegated call.</param>
    /// <param name="sphere_number">Index into path->global_curr_center selecting the target center point.</param>
    /// <returns>A TransitionState value: 2 if the computed normal is too small, otherwise the result returned by the nested slide_sphere overload.</returns>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* disp, float* radsum, int sphere_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, float*, int, ACBindings.Internal.TransitionState>)0x00538750)(ref this, object_, path, collisions, check_pos, disp, radsum, sphere_number);

    /// <summary>Checks whether the sphere represented by this object intersects or collides with a target sphere path defined in transition, handling various collision cases such as obstruction, walkable surfaces, stepping up/down and creature‑specific logic. Adjusts collision information accordingly and returns a TransitionState indicating the outcome.
    /// <code>Offset: 0x005387C0
    /// TransitionState __thiscall CSphere::intersects_sphere(CSphere*,CTransition*,int)</code>
    /// </summary>
    /// <param name="this">The sphere to test for intersections.</param>
    /// <param name="transition">Data structure containing the target sphere path and related collision data.</param>
    /// <param name="is_creature">Flag indicating whether the other object is a creature, altering collision handling.</param>
    /// <returns>TransitionState value representing the result of the intersection test (e.g., OK_TS, COLLIDED_TS, WALKABLE_TS).</returns>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.CTransition* transition, int is_creature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.CTransition*, int, ACBindings.Internal.TransitionState>)0x005387C0)(ref this, transition, is_creature);

    /// <summary>Scales the sphere by a factor, converts its center to global coordinates relative to a given position, then checks for intersection with a transition object.
    /// <code>Offset: 0x00538D10
    /// TransitionState __thiscall CSphere::intersects_sphere(CSphere*,const Position*,float,CTransition*,int)</code>
    /// </summary>
    /// <param name="this">The sphere instance whose transformed bounds are tested.</param>
    /// <param name="p">Reference position used in the local‑to‑global transformation.</param>
    /// <param name="scale">Factor applied to both radius and center coordinates.</param>
    /// <param name="transition">Context containing transition path information for intersection testing.</param>
    /// <param name="is_creature">Flag indicating whether creature-specific collision logic should be applied.</param>
    /// <returns>TransitionState value representing the result of the intersection test.</returns>
    public ACBindings.Internal.TransitionState intersects_sphere(ACBindings.Internal.Position* p, float scale, ACBindings.Internal.CTransition* transition, int is_creature) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSphere, ACBindings.Internal.Position*, float, ACBindings.Internal.CTransition*, int, ACBindings.Internal.TransitionState>)0x00538D10)(ref this, p, scale, transition, is_creature);
}

