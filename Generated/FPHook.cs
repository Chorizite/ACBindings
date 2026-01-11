namespace ACBindings.Internal;

public unsafe struct FPHook
{
    // Base Classes
    public ACBindings.Internal.PhysicsObjHook BaseClass_PhysicsObjHook; // ACBindings.Internal.PhysicsObjHook

    // Child Types
    public unsafe struct FPHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FPHook*, ACBindings.Internal.CPhysicsObj*, int> Execute; // function pointer

        // Methods
    }

    // Members
    public float start_value;
    public float end_value;

    // Generated Constructor
    public FPHook(ACBindings.Internal.PhysicsObjHook.HookType hook_type, double time_created, double delta, float start_value, float end_value, System.IntPtr user_data) {
        _ConstructorInternal(hook_type, time_created, delta, start_value, end_value, user_data);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051C580
    /// void __thiscall FPHook::FPHook(FPHook*,PhysicsObjHook::HookType,long double,long double,float,float,void*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.PhysicsObjHook.HookType hook_type, double time_created, double delta, float start_value, float end_value, System.IntPtr user_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FPHook, ACBindings.Internal.PhysicsObjHook.HookType, double, double, float, float, System.IntPtr, void>)0x0051C580)(ref this, hook_type, time_created, delta, start_value, end_value, user_data);
}

