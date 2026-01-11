namespace ACBindings.Internal;

public unsafe struct LuminousHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct LuminousHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, void> LuminousHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LuminousHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527890
    /// int __thiscall LuminousHook::UnPack(TextureVelocityPartHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LuminousHook, void**, uint, int>)0x00527890)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00527960
    /// void __thiscall LuminousHook::Execute(LuminousHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LuminousHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527960)(ref this, object_);
}

