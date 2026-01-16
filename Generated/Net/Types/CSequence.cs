namespace ACBindings.Internal;


/// <summary>
/// Handles animation sequences for a character or object, maintaining an ordered list of nodes, current playback state, and physics-related properties such as velocity, angular velocity, and hook references. Supports cyclic playback and provides placement frame data for precise integration into the simulation.
/// </summary>
public unsafe struct CSequence : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSequence_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, void> CSequence_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.DLList___AnimSequenceNode anim_list;
    public ACBindings.Internal.AnimSequenceNode* first_cyclic;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.AC1Legacy.Vector3 omega;
    public ACBindings.Internal.CPhysicsObj* hook_obj;
    public double frame_number;
    public ACBindings.Internal.AnimSequenceNode* curr_anim;
    public ACBindings.Internal.AnimFrame* placement_frame;
    public uint placement_frame_id;
    public int bIsTrivial;

    // Generated Constructor
    public CSequence() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Associates the sequence with a physics object for subsequent animation updates.
    /// <code>Offset: 0x00525420
    /// void __thiscall CSequence::set_object(CSequence*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="phys_obj">The physics object to bind to this sequence.</param>
    public void set_object(ACBindings.Internal.CPhysicsObj* phys_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.CPhysicsObj*, void>)0x00525420)(ref this, phys_obj);

    /// <summary>Adds all hooks from the specified animation frame to the sequence’s physics object when the hook is present and its direction matches the supplied value or is unspecified.
    /// <code>Offset: 0x00525430
    /// void __thiscall CSequence::execute_hooks(CSequence*,const AnimFrame*,int)</code>
    /// </summary>
    /// <param name="animframe">The animation frame that may contain hooks to apply.</param>
    /// <param name="dir">Direction filter; hooks with this direction, or any direction (0), are applied.</param>
    public void execute_hooks(ACBindings.Internal.AnimFrame* animframe, int dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimFrame*, int, void>)0x00525430)(ref this, animframe, dir);

    /// <summary>Sets the sequence's velocity to the specified vector.
    /// <code>Offset: 0x00525480
    /// void __thiscall CSequence::set_velocity(CSequence*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="v">The new velocity vector to apply.</param>
    public void set_velocity(ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00525480)(ref this, v);

    /// <summary>Sets the sequence's angular velocity to the supplied vector.
    /// <code>Offset: 0x005254A0
    /// void __thiscall CSequence::set_omega(CSequence*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="o">The new angular velocity vector.</param>
    public void set_omega(ACBindings.Internal.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005254A0)(ref this, o);

    /// <summary>Adds the supplied linear and angular velocity vectors to the sequence's current velocity and omega components.
    /// <code>Offset: 0x005254C0
    /// void __thiscall CSequence::combine_physics(CSequence*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="v">Linear velocity increment.</param>
    /// <param name="o">Angular velocity increment.</param>
    public void combine_physics(ACBindings.Internal.AC1Legacy.Vector3* v, ACBindings.Internal.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005254C0)(ref this, v, o);

    /// <summary>Subtracts given linear and angular velocities from the sequence's current motion vectors.
    /// <code>Offset: 0x00525500
    /// void __thiscall CSequence::subtract_physics(CSequence*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="v">Linear velocity vector to subtract from the sequence’s velocity.</param>
    /// <param name="o">Angular velocity vector to subtract from the sequence’s omega.</param>
    public void subtract_physics(ACBindings.Internal.AC1Legacy.Vector3* v, ACBindings.Internal.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00525500)(ref this, v, o);

    /// <summary>Multiplies the framerate of every cyclic animation node in the sequence by the specified factor.
    /// <code>Offset: 0x00525540
    /// void __thiscall CSequence::multiply_cyclic_animation_fr(CSequence*,float)</code>
    /// </summary>
    /// <param name="multiplier">The value used to scale each node’s current frame rate.</param>
    public void multiply_cyclic_animation_fr(float multiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, float, void>)0x00525540)(ref this, multiplier);

    /// <summary>Retrieves the active animation frame for a sequence, using placement_frame when no active animation exists.
    /// <code>Offset: 0x00525570
    /// const AnimFrame* __thiscall CSequence::get_curr_animframe(CSequence*)</code>
    /// </summary>
    /// <param name="this">The sequence instance whose current frame is requested.</param>
    /// <returns>A pointer to the current AnimFrame, or the placement frame if no animation node is active.</returns>
    public ACBindings.Internal.AnimFrame* get_curr_animframe() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimFrame*>)0x00525570)(ref this);

    /// <summary>Updates the sequence’s placement frame and assigns its identifier.
    /// <code>Offset: 0x005255B0
    /// void __thiscall CSequence::set_placement_frame(CSequence*,const AnimFrame*,unsigned int)</code>
    /// </summary>
    /// <param name="placement_frame">The animation frame defining the sequence's placement.</param>
    /// <param name="id">Identifier corresponding to the placement frame.</param>
    public void set_placement_frame(ACBindings.Internal.AnimFrame* placement_frame, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimFrame*, uint, void>)0x005255B0)(ref this, placement_frame, id);

    /// <summary>Creates a new animation sequence object, initializing its internal state—including the linked list of animation nodes, velocity, angular velocity, frame tracking, and other flags—to default zero or null values.
    /// <code>Offset: 0x005255F0
    /// void __thiscall CSequence::CSequence(CSequence*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005255F0)(ref this);

    /// <summary>Destroys a CSequence instance, freeing its animation list and restoring the base class vtable.
    /// <code>Offset: 0x00525630
    /// void __thiscall CSequence::~CSequence(CSequence*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525630)(ref this);

    /// <summary>Applies physics integration to the specified frame using the sequence's velocity and angular velocity over the given time step.
    /// <code>Offset: 0x005256B0
    /// void __thiscall CSequence::apply_physics(CSequence*,Frame*,long double,long double)</code>
    /// </summary>
    /// <param name="frame">The frame whose position and orientation are updated.</param>
    /// <param name="quantum">Time delta for the simulation; may be positive or negative.</param>
    /// <param name="sign">Direction indicator for the integration (currently unused).</param>
    public void apply_physics(ACBindings.Internal.Frame* frame, double quantum, double sign) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.Frame*, double, double, void>)0x005256B0)(ref this, frame, quantum, sign);

    /// <summary>Removes and destroys all animation nodes preceding the current animation (or the first cyclic node) from the sequence's linked list.
    /// <code>Offset: 0x00525740
    /// void __thiscall CSequence::apricot(CSequence*)</code>
    /// </summary>
    public void apricot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525740)(ref this);

    /// <summary>Checks if the sequence contains any animation nodes.
    /// <code>Offset: 0x005257D0
    /// int __thiscall CSequence::has_anims(CSequence*)</code>
    /// </summary>
    /// <returns>Non‑zero if at least one animation node exists; zero otherwise.</returns>
    public int has_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, int>)0x005257D0)(ref this);

    /// <summary>Removes up to the specified number of preceding animation sequence nodes from the sequence's linked list, destroying each removed node and updating the current animation state as needed.
    /// <code>Offset: 0x005257E0
    /// void __thiscall CSequence::remove_link_animations(CSequence*,unsigned int)</code>
    /// </summary>
    /// <param name="n">The maximum number of link animations to remove; if fewer than n exist, all remaining are removed.</param>
    public void remove_link_animations(uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, uint, void>)0x005257E0)(ref this, n);

    /// <summary>Removes every link animation node from the sequence, resetting its internal linked list and adjusting the current animation pointer and frame number as needed.
    /// <code>Offset: 0x005258A0
    /// void __thiscall CSequence::remove_all_link_animations(CSequence*)</code>
    /// </summary>
    public void remove_all_link_animations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005258A0)(ref this);

    /// <summary>Resets the sequence's velocity and angular velocity vectors to zero, clearing any stored motion state.
    /// <code>Offset: 0x00525950
    /// void __thiscall CSequence::clear_physics(CSequence*)</code>
    /// </summary>
    public void clear_physics() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525950)(ref this);

    /// <summary>Removes all animation nodes from the sequence and resets internal pointers, counters, and state to their default values.
    /// <code>Offset: 0x005259C0
    /// void __thiscall CSequence::clear_animations(CSequence*)</code>
    /// </summary>
    public void clear_animations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005259C0)(ref this);

    /// <summary>Removes all cyclic animation nodes from the sequence, adjusting the current animation state as needed.
    /// <code>Offset: 0x00525A40
    /// void __thiscall CSequence::remove_cyclic_anims(CSequence*)</code>
    /// </summary>
    public void remove_cyclic_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525A40)(ref this);

    /// <summary>Computes the serialized size of this sequence, including its animation nodes and optional velocity or angular‑velocity data. The result is returned as a byte count while the number of animations and presence flags are written through the supplied pointers.
    /// <code>Offset: 0x00525B20
    /// unsigned int __thiscall CSequence::pack_size(CSequence*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="bitfield">Receives a bitmask where bit 0 indicates velocity data will be packed and bit 1 indicates angular‑velocity data will be packed.</param>
    /// <param name="num_anims">Receives the count of animation nodes that will be included in the pack.</param>
    /// <returns>Number of bytes required to serialize the sequence, accounting for headers, per‑animation packing, and any velocity or angular‑velocity data.</returns>
    public uint pack_size(uint* bitfield, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, uint*, uint*, uint>)0x00525B20)(ref this, bitfield, num_anims);

    /// <summary>Serializes the current state of an animation sequence into a contiguous block of memory, writing fields such as the number of animations, frame data, indices, flags, and optional velocity and angular‑velocity vectors.
    /// <code>Offset: 0x00525C20
    /// unsigned int __thiscall CSequence::Pack(CSequence*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a writable memory location where packed data is written; updated to point past the last byte written.</param>
    /// <param name="size">Maximum number of bytes available at *addr; if less than the required size no packing occurs.</param>
    /// <returns>Size, in bytes, that the sequence would occupy when fully serialized.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void**, uint, uint>)0x00525C20)(ref this, addr, size);

    /// <summary>
    /// Advances the animation sequence forward or backward depending on the sign of quantum. Updates the current animation node and frame number, then applies position frame adjustments and physics calculations to produce the resulting pose in retval.
    /// 
    /// <code>Offset: 0x00525EB0
    /// void __thiscall CSequence::advance_to_next_animation(CSequence*,long double,const AnimSequenceNode**,long double*,Frame*)</code>
    /// </summary>
    /// <param name="quantum">Time delta used for advancing; negative values move to the previous animation.</param>
    /// <param name="curr_anim">Reference to pointer of the current AnimSequenceNode; will be updated to point at the new node after stepping.</param>
    /// <param name="frame_number">Reference to the frame index within the current animation; set to the start or end frame of the selected node.</param>
    /// <param name="retval">Frame structure where the computed pose is written; may be null if no output is needed.</param>
    public void advance_to_next_animation(double quantum, ACBindings.Internal.AnimSequenceNode** curr_anim, double* frame_number, ACBindings.Internal.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, double, ACBindings.Internal.AnimSequenceNode**, double*, ACBindings.Internal.Frame*, void>)0x00525EB0)(ref this, quantum, curr_anim, frame_number, retval);

    /// <summary>Appends a new animation to the sequence list if it contains valid data, inserting the node into the internal linked list and updating sequence state such as current animation and frame number.
    /// <code>Offset: 0x00526110
    /// void __thiscall CSequence::append_animation(CSequence*,const AnimData*)</code>
    /// </summary>
    /// <param name="this">The CSequence instance receiving the animation.</param>
    /// <param name="new_data">Animation data describing frames, framerate, and other playback parameters.</param>
    public void append_animation(ACBindings.Internal.AnimData* new_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimData*, void>)0x00526110)(ref this, new_data);

    /// <summary>Clears all animation nodes and physics data from the sequence, resetting placement frame references.
    /// <code>Offset: 0x005261B0
    /// void __thiscall CSequence::clear(CSequence*)</code>
    /// </summary>
    public void clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005261B0)(ref this);

    /// <summary>Advances a CSequence's animation progress by a specified quantum, updating the current frame number, applying physics to an optional Frame result, executing hooks, and transitioning to the next animation node when needed.
    /// <code>Offset: 0x005261D0
    /// void __thiscall CSequence::update_internal(CSequence*,long double,AnimSequenceNode**,long double*,Frame*)</code>
    /// </summary>
    /// <param name="quantum">The time step or progression amount used to advance frames within the sequence.</param>
    /// <param name="curr_anim">Pointer to the current AnimSequenceNode; may be updated to point at a new node after advancing.</param>
    /// <param name="frame_number">Current frame index, incremented or decremented according to animation direction and quantum.</param>
    /// <param name="retval">Optional Frame buffer into which the resulting pose is accumulated; if null, only hooks and state updates occur.</param>
    public void update_internal(double quantum, ACBindings.Internal.AnimSequenceNode** curr_anim, double* frame_number, ACBindings.Internal.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, double, ACBindings.Internal.AnimSequenceNode**, double*, ACBindings.Internal.Frame*, void>)0x005261D0)(ref this, quantum, curr_anim, frame_number, retval);

    /// <summary>Deserializes a packed animation sequence into this CSequence object, resetting existing animations and physics state. The function reads animation nodes, frame information, optional velocity vectors, and updates the provided buffer pointer to reflect consumed data.
    /// <code>Offset: 0x005265D0
    /// int __thiscall CSequence::UnPack(CSequence*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A double pointer to the source data buffer; advanced past each read element during unpacking.</param>
    /// <param name="size">The number of bytes remaining in the buffer that can be safely read.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void**, uint, int>)0x005265D0)(ref this, addr, size);

    /// <summary>Advances a sequence by the specified time quantum, updating its timing and current animation node if any; writes the resulting frame into the supplied buffer.
    /// <code>Offset: 0x00526780
    /// void __thiscall CSequence::update(CSequence*,long double,Frame*)</code>
    /// </summary>
    /// <param name="quantum">Time increment applied to advance the sequence’s frame number and animations.</param>
    /// <param name="retval">Optional output buffer that receives the updated frame after processing; may be filled regardless of whether an active animation exists.</param>
    public void update(double quantum, ACBindings.Internal.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, double, ACBindings.Internal.Frame*, void>)0x00526780)(ref this, quantum, retval);
}

