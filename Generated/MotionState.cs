namespace ACBindings.Internal;


/// <summary>
/// Represents the current motion state for an entity, storing style, substate, a modifier modulus value, and linked lists of active modifiers and actions.
/// </summary>
public unsafe struct MotionState
{
    // Members
    public uint style;
    public uint substate;
    public float substate_mod;
    public ACBindings.Internal.MotionList* modifier_head;
    public ACBindings.Internal.MotionList* action_head;
    public ACBindings.Internal.MotionList* action_tail;

    // Generated Constructor
    public MotionState() {
        _ConstructorInternal();
    }
    public MotionState(ACBindings.Internal.MotionState* s) {
        _ConstructorInternal(s);
    }

    // Methods

    /// <summary>Initializes a MotionState instance with default values for style, substate, and linked list pointers.
    /// <code>Offset: 0x00526BD0
    /// void __thiscall MotionState::MotionState(MotionState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526BD0)(ref this);

    /// <summary>Adds a new motion modifier to the state, inserting it at the front of the modifier linked list.
    /// <code>Offset: 0x00526BF0
    /// void __thiscall MotionState::add_modifier_no_check(MotionState*,unsigned int,float)</code>
    /// </summary>
    /// <param name="modifier">The identifier for the motion modifier to add.</param>
    /// <param name="speed_mod">Multiplier applied to the speed when this modifier is active.</param>
    public void add_modifier_no_check(uint modifier, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint, float, void>)0x00526BF0)(ref this, modifier, speed_mod);

    /// <summary>Removes the specified modifier from the state’s modifier list and frees its memory.
    /// <code>Offset: 0x00526C40
    /// void __thiscall MotionState::remove_modifier(MotionState*,MotionList*,MotionList*)</code>
    /// </summary>
    /// <param name="this">The MotionState instance whose modifier is being removed.</param>
    /// <param name="curr">The modifier node to remove.</param>
    /// <param name="prev">The preceding modifier node, or null if curr is the head of the list.</param>
    public void remove_modifier(ACBindings.Internal.MotionList* curr, ACBindings.Internal.MotionList* prev) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, ACBindings.Internal.MotionList*, ACBindings.Internal.MotionList*, void>)0x00526C40)(ref this, curr, prev);

    /// <summary>Removes all motion modifiers attached to a MotionState instance, freeing their allocated memory.
    /// <code>Offset: 0x00526C70
    /// void __thiscall MotionState::clear_modifiers(MotionState*)</code>
    /// </summary>
    public void clear_modifiers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526C70)(ref this);

    /// <summary>Adds a new motion action to the state’s action list with specified speed modifier.
    /// <code>Offset: 0x00526CA0
    /// void __thiscall MotionState::add_action(MotionState*,unsigned int,float)</code>
    /// </summary>
    /// <param name="action">Identifier of the motion to add.</param>
    /// <param name="speed_mod">Multiplier applied to the motion’s speed.</param>
    public void add_action(uint action, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint, float, void>)0x00526CA0)(ref this, action, speed_mod);

    /// <summary>Clears all motion actions from the state by deleting each node and resetting head and tail pointers.
    /// <code>Offset: 0x00526CF0
    /// void __thiscall MotionState::clear_actions(MotionState*)</code>
    /// </summary>
    public void clear_actions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526CF0)(ref this);

    /// <summary>Removes the first action from the state's action list and returns its motion identifier, or zero when the list is empty.
    /// <code>Offset: 0x00526D20
    /// unsigned int __thiscall MotionState::remove_action_head(MotionState*)</code>
    /// </summary>
    /// <returns>The motion identifier of the removed action, or 0 if no actions were present.</returns>
    public uint remove_action_head() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint>)0x00526D20)(ref this);

    /// <summary>Copies all properties from the source MotionState to the current instance, duplicating its modifier and action lists.
    /// <code>Offset: 0x00526DD0
    /// void __thiscall MotionState::copy(MotionState*,const MotionState*)</code>
    /// </summary>
    /// <param name="s">The MotionState whose data is copied into this instance.</param>
    public void copy(ACBindings.Internal.MotionState* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, ACBindings.Internal.MotionState*, void>)0x00526DD0)(ref this, s);

    /// <summary>Deletes all motion modifier and action lists associated with the motion state, freeing allocated memory and resetting internal pointers.
    /// <code>Offset: 0x00526EE0
    /// void __thiscall MotionState::Destroy(MotionState*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526EE0)(ref this);

    /// <summary>Adds a motion modifier to the state unless it is already present or matches the current substate.
    /// <code>Offset: 0x00526F40
    /// int __thiscall MotionState::add_modifier(MotionState*,unsigned int,float)</code>
    /// </summary>
    /// <param name="modifier">Identifier of the motion modifier to add.</param>
    /// <param name="speed_mod">Adjustment factor applied when adding the modifier.</param>
    /// <returns>1 if the modifier was added; 0 if it was already active or matched the substate.</returns>
    public int add_modifier(uint modifier, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint, float, int>)0x00526F40)(ref this, modifier, speed_mod);

    /// <summary>Constructs a MotionState by copying style, substate, substate_mod, modifier_head, action_head, and action_tail from an existing MotionState instance.
    /// <code>Offset: 0x00527390
    /// void __thiscall MotionState::MotionState(MotionState*,const MotionState*)</code>
    /// </summary>
    /// <param name="s">The source MotionState whose values are duplicated into the new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.MotionState* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, ACBindings.Internal.MotionState*, void>)0x00527390)(ref this, s);
}

