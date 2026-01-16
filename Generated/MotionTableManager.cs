namespace ACBindings.Internal;


/// <summary>
/// Manages execution of motion tables for a physics object, tracking current state and queued animations.
/// Maintains animation timing and pending actions applied to the associated physics object.
/// </summary>
public unsafe struct MotionTableManager : System.IDisposable
{
    // Child Types

    /// <summary>Links an individual motion to its animation data, storing motion ID and the number of associated animations as a node in the manager’s doubly‑linked list.</summary>
    /// <remarks>Baseclass_0 provides DLListData linkage used by MotionTableManager for traversal and organization of animation nodes.</remarks>
    public unsafe struct AnimNode
    {
        // Base Classes
        public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

        // Members
        public uint motion;
        public uint num_anims;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.CMotionTable* table;
    public ACBindings.Internal.MotionState state;
    public int animation_counter;
    public ACBindings.Internal.DLList___MotionTableManager_AnimNode pending_animations;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the manager’s motion table to the specified ID, releasing any current table and loading a new one from the database.
    /// <code>Offset: 0x0051C700
    /// BOOL __thiscall MotionTableManager::SetMotionTableID(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the motion table to assign.</param>
    /// <returns>True if the new table was successfully retrieved; otherwise false.</returns>
    public byte SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, int, byte>)0x0051C700)(ref this, a2);

    /// <summary>Retrieves the identifier of the motion table associated with this manager and writes it into the provided location. If no table is present, writes a sentinel invalid identifier instead.
    /// <code>Offset: 0x0051C740
    /// unsigned int* __thiscall MotionTableManager::GetMotionTableID(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer that receives the motion table identifier or an invalid marker if none exists.</param>
    /// <returns>The same pointer passed in so callers can use its value directly.</returns>
    public uint* GetMotionTableID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, uint*, uint*>)0x0051C740)(ref this, a2);

    /// <summary>Creates a new MotionTableManager instance, initializing its members to default values and optionally assigning a motion table identifier.
    /// <code>Offset: 0x0051C780
    /// _DWORD* __cdecl MotionTableManager::Create(int)</code>
    /// </summary>
    /// <param name="a1">Identifier for the motion table; if it equals INVALID_DID_226.baseclass_0.id, no ID is set.</param>
    /// <returns>A pointer to the newly allocated MotionTableManager object, or null if memory allocation fails.</returns>
    public static int* Create(int a1) => ((delegate* unmanaged[Cdecl]<int, int*>)0x0051C780)(a1);

    /// <summary>Truncates the manager's pending animation list at a specified node by clearing animations from all subsequent nodes and removing the corresponding link animations from the supplied sequence.
    /// <code>Offset: 0x0051C7D0
    /// void __thiscall MotionTableManager::truncate_animation_list(MotionTableManager*,const MotionTableManager::AnimNode*,CSequence*)</code>
    /// </summary>
    /// <param name="node">The node in the pending animation list to truncate after; if null, no action is taken.</param>
    /// <param name="seq">The sequence from which link animations are removed.</param>
    public void truncate_animation_list(ACBindings.Internal.MotionTableManager.AnimNode* node, ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.MotionTableManager.AnimNode*, ACBindings.Internal.CSequence*, void>)0x0051C7D0)(ref this, node, seq);

    /// <summary>Marks a pending animation as completed, updates the internal counter and state, notifies the physics system of the result, then removes the animation from the queue.
    /// <code>Offset: 0x0051C810
    /// void __thiscall MotionTableManager::AnimationDone(MotionTableManager*,int)</code>
    /// </summary>
    /// <param name="success">Indicates whether the animation finished successfully; passed to the physics object.</param>
    public void AnimationDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, int, void>)0x0051C810)(ref this, success);

    /// <summary>Marks all pending animations as completed when the manager exits the world, ensuring cleanup of animation state.
    /// <code>Offset: 0x0051C8D0
    /// void __thiscall MotionTableManager::HandleExitWorld(MotionTableManager*,CSequence*)</code>
    /// </summary>
    public void HandleExitWorld(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051C8D0)(ref this, seq);

    /// <summary>Removes completed motions from the pending animation list, updates internal motion state, notifies the physics object that a motion has finished, and releases the associated node memory.
    /// <code>Offset: 0x0051C900
    /// void __thiscall MotionTableManager::CheckForCompletedMotions(MotionTableManager*)</code>
    /// </summary>
    public void CheckForCompletedMotions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, void>)0x0051C900)(ref this);

    /// <summary>Destroys the motion table manager by cleaning up pending animations and releasing its associated motion table.
    /// <code>Offset: 0x0051C990
    /// void __thiscall MotionTableManager::Destroy(MotionTableManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, void>)0x0051C990)(ref this);

    /// <summary>Destroys a MotionTableManager instance, freeing its internal state and any pending animations.
    /// <code>Offset: 0x0051CA00
    /// void __thiscall MotionTableManager::~MotionTableManager(MotionTableManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, void>)0x0051CA00)(ref this);

    /// <summary>Truncates the pending animation list when a preceding node matches the motion of the last linked node and satisfies specific flag conditions, eliminating redundant entries for the given sequence.
    /// <code>Offset: 0x0051CA20
    /// void __thiscall MotionTableManager::remove_redundant_links(MotionTableManager*,CSequence*)</code>
    /// </summary>
    /// <param name="seq">The animation sequence used to guide the truncation of the list during processing.</param>
    public void remove_redundant_links(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051CA20)(ref this, seq);

    /// <summary>Clears all link animations from a sequence and finalizes any pending animations for this manager.
    /// <code>Offset: 0x0051CAD0
    /// void __thiscall MotionTableManager::HandleEnterWorld(MotionTableManager*,CSequence*)</code>
    /// </summary>
    /// <param name="seq">The animation sequence whose link animations should be removed.</param>
    public void HandleEnterWorld(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051CAD0)(ref this, seq);

    /// <summary>Enqueues an animation request by inserting a new node into the manager's pending animations list and removes any redundant links in the sequence.
    /// <code>Offset: 0x0051CB10
    /// void __thiscall MotionTableManager::add_to_queue(MotionTableManager*,unsigned int,unsigned int,CSequence*)</code>
    /// </summary>
    /// <param name="motion">The motion identifier indicating which animation to play.</param>
    /// <param name="num_anims">The number of animation frames or sub-sequences associated with the motion.</param>
    /// <param name="seq">A pointer to a CSequence containing the detailed animation data for this request.</param>
    public void add_to_queue(uint motion, uint num_anims, ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, uint, uint, ACBindings.Internal.CSequence*, void>)0x0051CB10)(ref this, motion, num_anims, seq);

    /// <summary>Initializes the manager's motion state from a given sequence, establishing default animation data when present.
    /// <code>Offset: 0x0051CB60
    /// void __thiscall MotionTableManager::initialize_state(MotionTableManager*,CSequence*)</code>
    /// </summary>
    /// <param name="this">The MotionTableManager instance being initialized.</param>
    /// <param name="seq">Sequence used to set up the initial state and pending animations.</param>
    public void initialize_state(ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.CSequence*, void>)0x0051CB60)(ref this, seq);

    /// <summary>Executes a movement command defined by a MovementStruct on the manager’s physics object, updating animation state and queuing subsequent animations via the motion table.
    /// <code>Offset: 0x0051CBE0
    /// unsigned int __thiscall MotionTableManager::PerformMovement(MotionTableManager*,const MovementStruct*,CSequence*)</code>
    /// </summary>
    /// <param name="this">The MotionTableManager instance holding the physics object and motion table reference.</param>
    /// <param name="ms">A MovementStruct specifying the type of motion, the motion identifier, and associated parameters such as speed.</param>
    /// <param name="seq">The CSequence that receives animation updates during the movement execution.</param>
    /// <returns>An unsigned integer status code: 0 on success; 7 if no motion table is available; 67 if the motion cannot be performed; otherwise returns the sequence pointer cast to an unsigned value indicating an alternate result.</returns>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* ms, ACBindings.Internal.CSequence* seq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionTableManager, ACBindings.Internal.MovementStruct*, ACBindings.Internal.CSequence*, uint>)0x0051CBE0)(ref this, ms, seq);
}

