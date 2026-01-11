namespace ACBindings.Internal;

public unsafe struct CallPESHook
{
    // Base Classes
    public ACBindings.Internal.CAnimHook BaseClass_CAnimHook; // ACBindings.Internal.CAnimHook

    // Child Types
    public unsafe struct CallPESHook_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, void> CallPESHook_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, ACBindings.Internal.CPhysicsObj*, void> Execute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, int> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, uint> pack_size; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CallPESHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID pes;
    public float pause;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00527A20
    /// void __thiscall CallPESHook::Execute(CallPESHook*,CPhysicsObj*)</code>
    /// </summary>
    public void Execute(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, ACBindings.Internal.CPhysicsObj*, void>)0x00527A20)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x00527DC0
    /// int __thiscall CallPESHook::GetType(CallPESHook*)</code>
    /// </summary>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, int>)0x00527DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005283F0
    /// unsigned int __thiscall CallPESHook::Pack(CallPESHook*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, void**, uint, uint>)0x005283F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00528420
    /// int __thiscall CallPESHook::UnPack(CallPESHook*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CallPESHook, void**, uint, int>)0x00528420)(ref this, addr, size);
}

