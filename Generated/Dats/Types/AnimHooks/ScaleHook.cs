namespace ACBindings.Internal;

public unsafe struct ScaleHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct ScaleHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, void> ScaleHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ScaleHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float end;
    public float time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527A40
    /// void __thiscall ScaleHook::Execute(ScaleHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScaleHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527A40)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00527A90
    /// int __thiscall ScaleHook::UnPack(TextureVelocityHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ScaleHook, void**, uint, int>)0x00527A90)(ref this, addr, size);
}

