namespace ACBindings.Internal;


/// <summary>Represents a physics object hook that interpolates between two scalar values over time, storing start and end values along with hook metadata via an embedded PhysicsObjHook.</summary>
/// <remarks>Contains a PhysicsObjHook member to hold type, creation timestamp, interpolation duration, user data, and linked list pointers; it does not inherit from PhysicsObjHook.</remarks>
public unsafe struct FPHook
{
    // Base Classes
    public ACBindings.Internal.PhysicsObjHook BaseClass_PhysicsObjHook; // ACBindings.Internal.PhysicsObjHook

    // Child Types
    public unsafe struct FPHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FPHook*, ACBindings.Internal.CPhysicsObj*, int> Execute; // function pointer

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

    /// <summary>Initializes an FPHook instance with specified interpolation parameters and stores start/end values for a physics object hook.
    /// <code>Offset: 0x0051C580
    /// void __thiscall FPHook::FPHook(FPHook*,PhysicsObjHook::HookType,long double,long double,float,float,void*)</code>
    /// </summary>
    /// <param name="hook_type">Type of the physics hook to apply.</param>
    /// <param name="time_created">Timestamp when the hook was created.</param>
    /// <param name="delta">Duration over which interpolation occurs.</param>
    /// <param name="start_value">Initial value at the start of interpolation.</param>
    /// <param name="end_value">Target value at the end of interpolation.</param>
    /// <param name="user_data">Pointer to user-defined data associated with the hook.</param>
    public void _ConstructorInternal(ACBindings.Internal.PhysicsObjHook.HookType hook_type, double time_created, double delta, float start_value, float end_value, System.IntPtr user_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FPHook, ACBindings.Internal.PhysicsObjHook.HookType, double, double, float, float, System.IntPtr, void>)0x0051C580)(ref this, hook_type, time_created, delta, start_value, end_value, user_data);
}

