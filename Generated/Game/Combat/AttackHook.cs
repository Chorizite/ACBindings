namespace ACBindings.Internal;


/// <summary>Defines an animation hook that encapsulates a pair of attack cones and manages their serialization and execution.</summary>
/// <remarks>Integrates with the animation system via CAnimHook baseclass, enabling directional attacks on physics objects.</remarks>
public unsafe struct AttackHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct AttackHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, void> AttackHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AttackHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AttackCone attack_cone;

    // Generated Constructor
    public AttackHook() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new AttackHook instance by setting default hook linkage and direction, assigning the appropriate v-table pointer, and performing cleanup or casting operations on the attack cone boundaries.
    /// <code>Offset: 0x005273D0
    /// void __thiscall AttackHook::AttackHook(AttackHook*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, void>)0x005273D0)(ref this);

    /// <summary>Computes the total number of bytes needed to serialize an AttackHook instance, adding the sizes of its left and right attack cones plus a fixed overhead.
    /// <code>Offset: 0x00527750
    /// unsigned int __thiscall AttackHook::pack_size(AttackHook*)</code>
    /// </summary>
    /// <returns>The packed data size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, uint>)0x00527750)(ref this);

    /// <summary>Executes an attack on the specified physics object using the attack cone defined in this hook.
    /// <code>Offset: 0x00527770
    /// void __thiscall AttackHook::Execute(AttackHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to target with the attack.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527770)(ref this, object_);

    /// <summary>Packs the attack cone data into a memory block.
    /// <code>Offset: 0x005283D0
    /// unsigned int __thiscall AttackHook::Pack(AttackHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to buffer where packed data will be stored.</param>
    /// <param name="size">Size of the buffer in bytes.</param>
    /// <returns>The number of bytes written or a status code indicating success.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, void**, uint, uint>)0x005283D0)(ref this, addr, size);

    /// <summary>Extracts serialized attack cone data into this hook’s <c>attack_cone</c> member using the supplied buffer.
    /// <code>Offset: 0x005283E0
    /// int __thiscall AttackHook::UnPack(AttackHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the source buffer containing packed data.</param>
    /// <param name="size">Number of bytes in the buffer that represent the packed attack cone.</param>
    /// <returns>The result code returned by <c>AttackCone::UnPack</c>, indicating success or failure of the unpack operation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackHook, void**, uint, int>)0x005283E0)(ref this, addr, size);
}

