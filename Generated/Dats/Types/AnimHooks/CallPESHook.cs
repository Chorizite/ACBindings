namespace ACBindings;

// CallPESHook
public unsafe struct CallPESHook
{
    // Base Classes
    public ACBindings.CAnimHook BaseClass_CAnimHook; // ACBindings.CAnimHook

    // Child Types
    // CallPESHook_vtbl
    public unsafe struct CallPESHook_vtbl
    {
        // Members
        public System.IntPtr CallPESHook_dtor_0; // function pointer
        public System.IntPtr Execute; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr pack_size; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID pes;
    public float pause;

    // Methods
    // void __thiscall CallPESHook::Execute(CallPESHook*,CPhysicsObj*)
    public void Execute(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CallPESHook, ACBindings.CPhysicsObj*, void>)0x00527A20)(ref this, object_);
    // int __thiscall CallPESHook::GetType(CallPESHook*)
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CallPESHook, int>)0x00527DC0)(ref this);
    // unsigned int __thiscall CallPESHook::Pack(CallPESHook*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CallPESHook, void**, uint, uint>)0x005283F0)(ref this, addr, size);
    // int __thiscall CallPESHook::UnPack(CallPESHook*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CallPESHook, void**, uint, int>)0x00528420)(ref this, addr, size);
}

