namespace ACBindings.Internal;

public unsafe struct AutonomousPositionPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AutonomousPositionPack_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, void> AutonomousPositionPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutonomousPositionPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Position position;
    public int contact;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public AutonomousPositionPack(ACBindings.Internal.Position* position, int contact, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(position, contact, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00517570
    /// void __thiscall AutonomousPositionPack::AutonomousPositionPack(AutonomousPositionPack*,const Position*,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Position* position, int contact, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutonomousPositionPack, ACBindings.Internal.Position*, int, ushort, ushort, ushort, ushort, void>)0x00517570)(ref this, position, contact, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);

    /// <summary>
    /// <code>Offset: 0x005175F0
    /// unsigned int __thiscall AutonomousPositionPack::Pack(AutonomousPositionPack*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutonomousPositionPack, void**, uint, uint>)0x005175F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005176A0
    /// int __thiscall AutonomousPositionPack::UnPack(AutonomousPositionPack*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutonomousPositionPack, void**, uint, int>)0x005176A0)(ref this, addr, size);
}

