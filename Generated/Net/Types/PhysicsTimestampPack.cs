namespace ACBindings.Internal;

public unsafe struct PhysicsTimestampPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct PhysicsTimestampPack_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, void> PhysicsTimestampPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PhysicsTimestampPack*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005179F0
    /// void __thiscall PhysicsTimestampPack::PhysicsTimestampPack(PhysicsTimestampPack*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsTimestampPack, void>)0x005179F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00517A10
    /// unsigned int __thiscall PhysicsTimestampPack::Pack(PhysicsTimestampPack*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsTimestampPack, void**, uint, uint>)0x00517A10)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00517A50
    /// int __thiscall PhysicsTimestampPack::UnPack(PhysicsTimestampPack*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsTimestampPack, void**, uint, int>)0x00517A50)(ref this, addr, size);
}

