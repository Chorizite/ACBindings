namespace ACBindings;

// FPHook
public unsafe struct FPHook
{
    // Base Classes
    public ACBindings.PhysicsObjHook BaseClass_PhysicsObjHook; // ACBindings.PhysicsObjHook

    // Child Types
    // FPHook_vtbl
    public unsafe struct FPHook_vtbl
    {
        // Members
        public System.IntPtr Execute; // function pointer

        // Methods
    }

    // Members
    public float start_value;
    public float end_value;

    // Generated Constructor
    public FPHook(ACBindings.PhysicsObjHook.HookType hook_type, double time_created, double delta, float start_value, float end_value, System.IntPtr user_data) {
        _ConstructorInternal(hook_type, time_created, delta, start_value, end_value, user_data);
    }

    // Methods
    // void __thiscall FPHook::FPHook(FPHook*,PhysicsObjHook::HookType,long double,long double,float,float,void*)
    public void _ConstructorInternal(ACBindings.PhysicsObjHook.HookType hook_type, double time_created, double delta, float start_value, float end_value, System.IntPtr user_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FPHook, ACBindings.PhysicsObjHook.HookType, double, double, float, float, System.IntPtr, void>)0x0051C580)(ref this, hook_type, time_created, delta, start_value, end_value, user_data);
}

