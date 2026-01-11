namespace ACBindings.Internal;

public unsafe struct TransparentHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct TransparentHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, void> TransparentHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TransparentHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527830
    /// void __thiscall TransparentHook::Execute(TransparentHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransparentHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527830)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00683760
    /// int __thiscall TransparentHook::GetType(TransparentHook*)</code>
    /// </summary>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransparentHook, int>)0x00683760)(ref this);
}

