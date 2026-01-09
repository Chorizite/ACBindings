namespace ACBindings;

// PhysicsTimestampPack
public unsafe struct PhysicsTimestampPack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // PhysicsTimestampPack_vtbl
    public unsafe struct PhysicsTimestampPack_vtbl
    {
        // Members
        public System.IntPtr PhysicsTimestampPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ushort ts1;
    public ushort ts2;

    // Generated Constructor
    public PhysicsTimestampPack() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall PhysicsTimestampPack::PhysicsTimestampPack(PhysicsTimestampPack*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsTimestampPack, void>)0x005179F0)(ref this);
    // unsigned int __thiscall PhysicsTimestampPack::Pack(PhysicsTimestampPack*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsTimestampPack, void**, uint, uint>)0x00517A10)(ref this, addr, size);
    // int __thiscall PhysicsTimestampPack::UnPack(PhysicsTimestampPack*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsTimestampPack, void**, uint, int>)0x00517A50)(ref this, addr, size);
}

