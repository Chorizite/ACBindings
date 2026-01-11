namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00526BD0
    /// void __thiscall MotionState::MotionState(MotionState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526BF0
    /// void __thiscall MotionState::add_modifier_no_check(MotionState*,unsigned int,float)</code>
    /// </summary>
    public void add_modifier_no_check(uint modifier, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint, float, void>)0x00526BF0)(ref this, modifier, speed_mod);

    /// <summary>
    /// <code>Offset: 0x00526C40
    /// void __thiscall MotionState::remove_modifier(MotionState*,MotionList*,MotionList*)</code>
    /// </summary>
    public void remove_modifier(ACBindings.Internal.MotionList* curr, ACBindings.Internal.MotionList* prev) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, ACBindings.Internal.MotionList*, ACBindings.Internal.MotionList*, void>)0x00526C40)(ref this, curr, prev);

    /// <summary>
    /// <code>Offset: 0x00526C70
    /// void __thiscall MotionState::clear_modifiers(MotionState*)</code>
    /// </summary>
    public void clear_modifiers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526C70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526CA0
    /// void __thiscall MotionState::add_action(MotionState*,unsigned int,float)</code>
    /// </summary>
    public void add_action(uint action, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint, float, void>)0x00526CA0)(ref this, action, speed_mod);

    /// <summary>
    /// <code>Offset: 0x00526CF0
    /// void __thiscall MotionState::clear_actions(MotionState*)</code>
    /// </summary>
    public void clear_actions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526D20
    /// unsigned int __thiscall MotionState::remove_action_head(MotionState*)</code>
    /// </summary>
    public uint remove_action_head() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint>)0x00526D20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526DD0
    /// void __thiscall MotionState::copy(MotionState*,const MotionState*)</code>
    /// </summary>
    public void copy(ACBindings.Internal.MotionState* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, ACBindings.Internal.MotionState*, void>)0x00526DD0)(ref this, s);

    /// <summary>
    /// <code>Offset: 0x00526EE0
    /// void __thiscall MotionState::Destroy(MotionState*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, void>)0x00526EE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00526F40
    /// int __thiscall MotionState::add_modifier(MotionState*,unsigned int,float)</code>
    /// </summary>
    public int add_modifier(uint modifier, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, uint, float, int>)0x00526F40)(ref this, modifier, speed_mod);

    /// <summary>
    /// <code>Offset: 0x00527390
    /// void __thiscall MotionState::MotionState(MotionState*,const MotionState*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.MotionState* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MotionState, ACBindings.Internal.MotionState*, void>)0x00527390)(ref this, s);
}

