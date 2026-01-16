namespace ACBindings.Internal;


/// <summary>Specializes an animation hook to toggle the visibility of a physics object by applying its no‑draw flag.</summary>
public unsafe struct NoDrawHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct NoDrawHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, void> NoDrawHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoDrawHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int _no_draw;

    // Methods

    /// <summary>Returns the type identifier for NoDrawHook hooks.
    /// <code>Offset: 0x00527450
    /// unsigned int __thiscall NoDrawHook::GetType(Position*)</code>
    /// </summary>
    /// <returns>The unsigned integer identifier, which is always 16.</returns>
    public uint GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoDrawHook, uint>)0x00527450)(ref this);

    /// <summary>Computes the byte count needed to serialize the light hook state and, when sufficient space is provided, writes the lights_on flag into the supplied buffer.
    /// <code>Offset: 0x00527780
    /// unsigned int __thiscall NoDrawHook::Pack(SetLightHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory buffer where serialized data will be written; after execution it points to the next free byte.</param>
    /// <param name="size">Number of bytes currently available in the buffer.</param>
    /// <returns>Required size in bytes for serializing this object.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoDrawHook, void**, uint, uint>)0x00527780)(ref this, addr, size);

    /// <summary>Configures the specified physics object's visibility by applying the no‑draw flag stored in the hook.
    /// <code>Offset: 0x005277E0
    /// void __thiscall NoDrawHook::Execute(NoDrawHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to modify.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoDrawHook, ACBindings.Internal.CPhysicsObj*, void>)0x005277E0)(ref this, object_);
}

