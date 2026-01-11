namespace ACBindings.Internal;

public unsafe struct TransparentPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TransparentPartHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, void> TransparentPartHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005278C0
    /// void __thiscall TransparentPartHook::Execute(TransparentPartHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransparentPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x005278C0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x005278F0
    /// int __thiscall TransparentPartHook::UnPack(DiffusePartHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransparentPartHook, void**, uint, int>)0x005278F0)(ref this, addr, size);
}

