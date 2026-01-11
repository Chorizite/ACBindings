namespace ACBindings.Internal;

public unsafe struct AnimDoneHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct AnimDoneHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, void> AnimDoneHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527820
    /// void __thiscall AnimDoneHook::Execute(AnimDoneHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimDoneHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527820)(ref this, object_);
}

