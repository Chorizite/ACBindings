namespace ACBindings;

// MotionState
public unsafe struct MotionState
{
    // Members
    public uint style;
    public uint substate;
    public float substate_mod;
    public ACBindings.MotionList* modifier_head;
    public ACBindings.MotionList* action_head;
    public ACBindings.MotionList* action_tail;

    // Generated Constructor
    public MotionState() {
        _ConstructorInternal();
    }
    public MotionState(ACBindings.MotionState* s) {
        _ConstructorInternal(s);
    }

    // Methods
    // void __thiscall MotionState::MotionState(MotionState*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, void>)0x00526BD0)(ref this);
    // void __thiscall MotionState::add_modifier_no_check(MotionState*,unsigned int,float)
    public void add_modifier_no_check(uint modifier, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, uint, float, void>)0x00526BF0)(ref this, modifier, speed_mod);
    // void __thiscall MotionState::remove_modifier(MotionState*,MotionList*,MotionList*)
    public void remove_modifier(ACBindings.MotionList* curr, ACBindings.MotionList* prev) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, ACBindings.MotionList*, ACBindings.MotionList*, void>)0x00526C40)(ref this, curr, prev);
    // void __thiscall MotionState::clear_modifiers(MotionState*)
    public void clear_modifiers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, void>)0x00526C70)(ref this);
    // void __thiscall MotionState::add_action(MotionState*,unsigned int,float)
    public void add_action(uint action, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, uint, float, void>)0x00526CA0)(ref this, action, speed_mod);
    // void __thiscall MotionState::clear_actions(MotionState*)
    public void clear_actions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, void>)0x00526CF0)(ref this);
    // unsigned int __thiscall MotionState::remove_action_head(MotionState*)
    public uint remove_action_head() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, uint>)0x00526D20)(ref this);
    // void __thiscall MotionState::copy(MotionState*,const MotionState*)
    public void copy(ACBindings.MotionState* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, ACBindings.MotionState*, void>)0x00526DD0)(ref this, s);
    // void __thiscall MotionState::Destroy(MotionState*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, void>)0x00526EE0)(ref this);
    // int __thiscall MotionState::add_modifier(MotionState*,unsigned int,float)
    public int add_modifier(uint modifier, float speed_mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, uint, float, int>)0x00526F40)(ref this, modifier, speed_mod);
    // void __thiscall MotionState::MotionState(MotionState*,const MotionState*)
    public void _ConstructorInternal(ACBindings.MotionState* s) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MotionState, ACBindings.MotionState*, void>)0x00527390)(ref this, s);
}

