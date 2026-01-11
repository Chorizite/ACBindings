namespace ACBindings.Internal;

public unsafe struct LuminousPartHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct LuminousPartHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, void> LuminousPartHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527470
    /// int __thiscall LuminousPartHook::GetType(LuminousPartHook*)</code>
    /// </summary>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LuminousPartHook, int>)0x00527470)(ref this);

    /// <summary>
    /// <code>Offset: 0x00527930
    /// void __thiscall LuminousPartHook::Execute(LuminousPartHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LuminousPartHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527930)(ref this, object_);
}

