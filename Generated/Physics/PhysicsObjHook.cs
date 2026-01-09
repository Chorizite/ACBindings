namespace ACBindings;

// PhysicsObjHook
public unsafe struct PhysicsObjHook
{
    // Child Types
    // PhysicsObjHook_vtbl
    public unsafe struct PhysicsObjHook_vtbl
    {
        // Members
        public System.IntPtr Execute; // function pointer

        // Methods
    }
    // PhysicsObjHook::HookType
    public enum HookType : uint
    {
        CSetup = 0x1,
        MTABLE = 0x2,
        VELOCITY = 0x4,
        ACCELERATION = 0x8,
        OMEGA = 0x10,
        PARENT = 0x20,
        CHILDREN = 0x40,
        OBJSCALE = 0x80,
        FRICTION = 0x100,
        ELASTICITY = 0x200,
        TIMESTAMPS = 0x400,
        STABLE = 0x800,
        PETABLE = 0x1000,
        DEFAULT_SCRIPT = 0x2000,
        DEFAULT_SCRIPT_INTENSITY = 0x4000,
        POSITION = 0x8000,
        MOVEMENT = 0x10000,
        ANIMFRAME_ID = 0x20000,
        TRANSLUCENCY = 0x40000,
        FORCE_PhysicsDescInfo_32_BIT = 0x7FFFFFFF
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PhysicsObjHook.HookType hook_type;
    public double time_created;
    public double interpolation_time;
    public ACBindings.PhysicsObjHook* prev;
    public ACBindings.PhysicsObjHook* next;
    public System.IntPtr user_data;

    // Methods
}

