namespace ACBindings.Internal;


/// <summary>Defines a hook that adjusts the translucency of a physics object part over time, storing target part ID, start and end opacity values, and transition duration.</summary>
public unsafe struct TransparentPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TransparentPartHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, void> TransparentPartHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>Sets the translucency of a specified part of the provided physics object, interpolating from the initial value to a target value over a defined duration.
    /// <code>Offset: 0x005278C0
    /// void __thiscall TransparentPartHook::Execute(TransparentPartHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose part's translucency is being modified.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransparentPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x005278C0)(ref this, object_);

    /// <summary>Unpacks a TransparentPartHook object from serialized data by reading consecutive values for part, start, end, and time from the provided address pointer.
    /// <code>Offset: 0x005278F0
    /// int __thiscall TransparentPartHook::UnPack(DiffusePartHook*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; it is advanced as each field is extracted.</param>
    /// <param name="size">Size of the remaining data in bytes (unused in this implementation).</param>
    /// <returns>1 indicating the data was unpacked successfully.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransparentPartHook, void**, uint, int>)0x005278F0)(ref this, addr, size);
}

