namespace ACBindings.Internal;


/// <summary>Handles the completion of an animation, triggering physics logic when an object finishes its motion.</summary>
/// <remarks>Derives from CAnimHook and overrides Execute to call Hook_AnimDone on the associated physics object.</remarks>
public unsafe struct AnimDoneHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct AnimDoneHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, void> AnimDoneHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AnimDoneHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Executes the animation completion routine for a physics object.
    /// <code>Offset: 0x00527820
    /// void __thiscall AnimDoneHook::Execute(AnimDoneHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The AnimDoneHook instance invoking execution.</param>
    /// <param name="object">The physics object whose animation has just finished.</param>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimDoneHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527820)(ref this, object_);
}

